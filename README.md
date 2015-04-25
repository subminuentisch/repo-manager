# Repo Manager

### Description
Repository manager for the [ArmA Click&Play](https://github.com/armabake/click-play) launcher. Lets you create mod repositories and generate links for easy joining.

### Requirements
- FTP server
- Microsoft .NET Framework 2.0 (included in Windows Server 2008 and later)

### Setup

###### FTP User
Create a FTP user with read access to a folder that contains all mods. The FTP user's home directory must be the mod folder. If you use a password it will be visible in join links.

###### Repo Manager
1. Download [RepoManager.exe](https://github.com/armabake/repo-manager/releases).
2. Upload `RepoManager.exe` to the mod folder on your server.
3. Double-click `RepoManager.exe` on the server.
4. Enter the FTP details under `Edit → Settings → FTP Server`.

###### User Config
Some mods come with a `userconfig` folder. Make sure it's placed inside the mod folder (e.g. `@task_force_radio/userconfig`).

### Usage
1. Click `Create`, configure the repository and confirm.
2. Click `Copy URL`. A link is copied to the clipboard.
3. Share the link with [ArmA Click&Play](https://github.com/armabake/click-play) users.
