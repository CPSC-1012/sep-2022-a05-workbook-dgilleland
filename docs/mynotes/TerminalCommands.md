# Common Terminal Commands

The [DotNet](#dotnet-commands) and [git](#git-commands) are the ones we'll be using every day.

## DOS Commands

### `cd` - Change Directory

To change your terminal context to another directory, use the `cd` command. Its pattern is as follows:

```shell
cd path
```

where `path` is either an absolute or relative path to a folder; if the path includes spaces, you must enclose it in double quotes.

### `dir` - View Directory Contents

Typing `dir` in the terminal will display the contents of the current directory (files and folders).

### `mkdir` - Create a Folder/Directory

The `mkdir` command is used to create a folder in the current directory. For example, to create a folder called "Demo-22", you would type the following.

```shell
mkdir Demo-22
```

If your folder name contains spaces, you will need to enclose that name in double quotes. For example,

```shell
mkdir "My Sandbox"
```

----

## `DotNet` Commands

For reference, see the [official documentation on the .NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/). You can find help on all the `dotnet` commands by using the `--help` flag. For example, to find help on the `new` command, you would type

```shell
dotnet new --help
```

### `new` - New Project

The following will create a new C# project in the current folder.

```shell
dotnet new console
```

### `run`

The following will compile and run the C# project that is in the current folder.

```shell
dotnet run
```

----

## `git` Commands


----

## VS Code Commands

### `code -r path` - Reload VS Code

If you want to reload VS Code to use a specific folder, you can use the `-r` flag. The value for the path can be a relative or an absolute folder path on your computer.

For example, to reload VS Code using the current path in your termal, you would type

```shell
code -r .
```

As another example, if folder in your terminal is `C:\Users\StewDent\Documents\sep-2022-a05-workbook-stewdent\`, then typing `code -r src\Demo-01` will reload VS Code using the folder `C:\Users\StewDent\Documents\sep-2022-a05-workbook-stewdent\src\Demo-01`

----
