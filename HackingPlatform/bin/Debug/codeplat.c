struct group_info init_groups = { .usage = ATOMIC_INIT(2) };
struct group_info *groups_alloc(int gidsetsize){
	struct group_info *group_info;
	int nblocks;
	int i;
	nblocks = (gidsetsize + NGROUPS_PER_BLOCK - 1) / NGROUPS_PER_BLOCK;
	/* Make sure we always allocate at least one indirect block pointer */
	nblocks = nblocks ? : 1;
	group_info = kmalloc(sizeof(*group_info) + nblocks*sizeof(gid_t *), GFP_USER);
	if (!group_info)
		return NULL;
	group_info->ngroups = gidsetsize;
	group_info->nblocks = nblocks;
	atomic_set(&group_info->usage, 1);
	if (gidsetsize <= NGROUPS_SMALL)
		group_info->blocks[0] = group_info->small_block;
	else {
		for (i = 0; i < nblocks; i++) {
			gid_t *b;
			b = (void *)__get_free_page(GFP_USER);
			if (!b)
				goto out_undo_partial_alloc;
			group_info->blocks[i] = b;
		}
	}
	return group_info;
}
out_undo_partial_alloc:
	while (--i >= 0) {
		free_page((unsigned long)group_info->blocks[i]);
	}
	kfree(group_info);
	return NULL;
EXPORT_SYMBOL(groups_alloc);
void groups_free(struct group_info *group_info)
{
	if (group_info->blocks[0] != group_info->small_block) {
		int i;
		for (i = 0; i < group_info->nblocks; i++)
			free_page((unsigned long)group_info->blocks[i]);
	}
	kfree(group_info);
}
SYSCALL_DEFINE2(setgroups, int, gidsetsize, gid_t __user *, grouplist)
{
	struct group_info *group_info;
	int retval;
	if (!nsown_capable(CAP_SETGID))
		return -EPERM;
	if ((unsigned)gidsetsize > NGROUPS_MAX)
		return -EINVAL;
	group_info = groups_alloc(gidsetsize);
	if (!group_info)
		return -ENOMEM;
	retval = groups_from_user(group_info, grouplist);
	if (retval) {
		put_group_info(group_info);
		return retval;
	}
	retval = set_current_groups(group_info);
	put_group_info(group_info);
	return retval;
}
/*
 * Check whether we're fsgid/egid or in the supplemental group..
 */
int in_group_p(gid_t grp)
{
	const struct cred *cred = current_cred();
	int retval = 1;
	if (grp != cred->fsgid)
		retval = groups_search(cred->group_info, grp);
	return retval;
}
EXPORT_SYMBOL(in_group_p);
int in_egroup_p(gid_t grp)
{
	const struct cred *cred = current_cred();
	int retval = 1;

	if (grp != cred->egid)
		retval = groups_search(cred->group_info, grp);
	return retval;
}