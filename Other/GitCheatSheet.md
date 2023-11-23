## Git Command Cheat Sheet
| Command | Description |
|---|---|
| `git add .` | Adds all tracked files in the working directory to the staging area. |
| `git add <file>` | Adds the specified file to the staging area, preparing it for the next commit. |
| `git blame <file>` | Shows the revision history of a specific file, indicating which author made each change and when. |
| `git checkout -b <branch-name>` | Creates a new branch and switches to it, making its files the working directory. |
| `git checkout -b <branch-name> --track <remote-name>/<branch-name>` | Creates a new branch named `<branch-name>` and sets its upstream tracking branch to `<remote-name>/<branch-name>`. |
| `git checkout HEAD~<n>` | Switches to the commit specified by `<n>` positions back from the current commit. |
| `git checkout --theirs <file>` | Overwrites the contents of the specified file with the version from the tracked branch without merging. |
| `git clean -f -d -x` | Removes all untracked files and directories from the working directory and staging area. |
| `git commit -am` | Creates a new commit with the specified message. |
| `git commit --amend` | Modifies the most recent commit by adding or changing the commit message. |
| `git config --global --add diff.guitool kdiff3` | Sets KDiff3 as the default diff tool. |
| `git config --global --add merge.tool kdiff3` | Sets KDiff3 as the default merge tool. |
| `git diff --cached` | Shows the changes between the staging area and the latest commit. |
| `git diff --name-only` | Displays a list of files that have been modified, added, or removed since the last commit or the specified commit. |
| `git fetch` | Retrieves the latest changes from all remote repositories without merging them. |
| `git fetch -p` | Fetches the latest changes and updates the remote-tracking branches while also reporting which commits are already present in your local repository. |
| `git filter-branch <command>` | Applies the specified command to each commit in the branch history, rewriting the repository history. |
| `git for-each-ref` | Iterates over all references (branches, tags, and remote-tracking branches) in the repository and executes a specified command for each reference. |
| `git gc` | Performs garbage collection to remove unnecessary objects from the local repository. |
| `git init` | Initializes a new Git repository in the current directory. |
| `git log` | Displays the history of commits made to the repository. |
| `git merge` | Merges the changes from the specified branch into the current branch. |
| `git merge --no-ff` | Merges the specified branch into the current branch without fast-forwarding, creating a merge commit even if the history is linear. |
| `git merge --squash` | Merges the specified branch into the current branch but squashes the changes into a single commit. |
| `git push` | Pushes your local commits to the remote repository. |
| `git push -f` | Forces the push of local commits to the remote repository, overwriting any remote changes. |
| `git remote add origin <remote-url>` | Adds a remote repository named `origin` with the specified URL. |
| `git remote prune` | Removes remote tracking branches that no longer exist on the remote repository. |
| `git remote rm <remote-name>` | Removes the remote repository with the specified name. |
| `git remote set-branches <remote-name> <branch-name>` | Sets the default branch to track for the remote repository with the specified name. |
| `git remote set-url <remote-name> <new-url>` | Updates the URL of the remote repository with the specified name. |
| `git reset --hard HEAD~1` | Reverts the last commit, discarding all changes in the working directory and staging area. |
| `git reset --soft HEAD~1` | Reverts the last commit, keeping the changes in the working directory and staging area. |
| `git rebase --onto` | Reabases the current branch onto a different base commit. |
| `git remote update` | Fetches the latest changes from all remote repositories and updates the remote tracking branches. |
| `git show-branch -a ...` | Prints the name of the
