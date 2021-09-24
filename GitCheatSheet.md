## Basics
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
To clone a repository from the server, navigate to the Windows folder you want to use and run:
```bash
git clone http://vm-gva-tfs07:8080/tfs/.../.../_git/..._main
```
To get new changes from the server:
```bash
git pull
```
To create a new feature branch:
```bash
git branch feature/branch-name # To create a new branch from current commit without switching to that branch
git checkout feature/branch-name # To switch to the new branch
# or
git checkout -b feature/branch-name # Causes a new branch to be created as if "git branch" were called and then checked out
```
To commit and push your changes to the server:
```bash
git commit -am "your comment" && git push
```
To merge the changes from DEV branch to the feature branch you are working on (feature1):
```bash
git checkout dev && git pull && git checkout feature/feature1 && git merge dev
```
If the merge has conflicts, run the command:
```bash
git mergetool
```
## Common
Determinate an original branch of your feature branch
```bash
git show-branch -a \
| grep '\*' \
| grep -v `git rev-parse --abbrev-ref HEAD` \
| head -n1 \
| sed 's/.*\[\(.*\)\].*/\1/' \
| sed 's/[\^~].*//'
```
KDiff3 and Git
```bash
git config --global --add merge.tool kdiff3
git config --global --add mergetool.kdiff3.path "C:/Program Files/KDiff3/kdiff3.exe"
git config --global --add mergetool.kdiff3.trustExitCode false

git config --global --add diff.guitool kdiff3
git config --global --add difftool.kdiff3.path "C:/Program Files/KDiff3/kdiff3.exe"
git config --global --add difftool.kdiff3.trustExitCode false
```
On undoing, fixing, or removing commits in git
https://sethrobertson.github.io/GitFixUm/fixup.html

RESET Windows Password
```bash
git config --global credential.helper wincred
```
Delete stale remote-tracking branches under origin:
```bash
git remote prune origin
```
Clean up unnecessary files and optimize the local repository (works best after git remote prune <remote-name>):
```bash
git gc
```