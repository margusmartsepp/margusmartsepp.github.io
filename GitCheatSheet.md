Revert local commit:
```bash
git reset --soft head~1
```
Revert local changes (not added files):
```bash
git reset --hard
```
Cherry pick:
```bash
git cherry-pick -x 3b689ebc
```
Clear unrelated changes:
```bash
git clean -f -d -x
```
Rebase
```bash
git rebase --onto <newparent> <oldparent>~1
git rebase --onto origin/hotfix-4.5.11-b 045403c2fc827a6e5468d5a00e86acfce9a20187
```
Remove expired item in git remote
```bash
bash git fetch --prune
```
Rename branch
```bash
git branch -m feature/12897-2 feature/BS-12897-2
```