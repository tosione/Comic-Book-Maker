# Comic Book Maker
A program for compressing and recompressing comic book files.

Official repository: https://github.com/tosione/Comic-Book-Maker

## Features

- Allowed input files:
  - Folders with files.
  - Archives: ZIP, 7Z, RAR.
  - Comic files: CBZ, CB7, CBR.
- Supported output comic files: CBZ, CB7, CBR[^1].
- Cleanup options:
  - Multiple wildcards for files to exclude.
  - Removing of unnecessary folder structures.
- Multi thread processing of files for increased speed.
- Deletion of input files.
- Drag-n-drop support.
- Integration into *SendTo* context menu of Windows Explorer for automatic opening of multiple files.
- Option for automatic start after adding files, and automatic close after successful completion, allowing automatic file processing when used together with *SendTo* context menu.

[^1]: Rar.exe from [WinRar](https://www.rarlab.com) is required for CBR creation.

## Usage

Add files, select options and click Go. 

### Adding files

There are different ways to add files:

1. Drag-n-drop files on *DataGrid*.
2. Start program by using *SendTo* context menu of Windows Explorer while selecting one or multiple input files/folders. Needs to add Comic Book Maker to the *SendTo* context menu (there is a button provided for this, se options below).
3. Start program by drag-n-dropping input files/folders onto it in Windows Explorer.
4. Start program with command line adding files to process: `"Comic Book Maker.exe" inputpath1 inputpath2 ...`

In all cases, only supported files will be added.

The added files are not maintained on *DataGrid* when closing program.

### Options

* Input files to enable: folder, archives or comics. The files corresponding to enabled filetypes will checked/unchecked automatically.

- Output type: CBZ, CB7 or CBR (if CBR is selected you need to specify Rar.exe location).
  - The recommended type is CBZ, because of higher compatibility 
    and no need for commercial compression software (WinRar).
  - In all cases the lowest compression rate is used (none), as
    all files should be JPG or PNG, which are already highly compressed. Using higher compression ratio only would slow down the creation, opening, and viewing of comic files at nearly no size benefit.
  - RAR4 compression will be used for CBR, instead of less compatible RAR5.
- Use or not the specified output path. 
  - If not, the input path will be used for output path.
  - If folder doesn't exists, it will be created.
- Action to do if output file exists: overwrite, skip or rename. 
  - Rename will suffix the specified pattern, which needs to include *\n* for numeric values (program will try 1 - 1000)
- Clean files: any file corresponding to the patterns will be excluded from output files. 
  - Wildcards *?* and *\** can be used in patterns. 
  - Multiple patterns can be separated with *|* . 
  - If more files than the specified limit would be excluded, this row will be skipped.
- Remove folder structure:
  - No: folder structure will be left as it is.
  - Yes: all files will be placed in the root folder and directories will be removed. If duplicate file names exist an error is generated for this row.
  - Smart: top level folders will be removed until two or more 
    folders/files are on the same level.
- Use multi-threading: can speed up considerably the process in a multi-core system.
- Start automatically after adding files: as soon as files are dropped onto program, or program is started with files added, the conversion will begin.
- Close after successful completion: 
  - If any error occurs during processing, this closing will not happen.
  - If no error occurs, a 5 s countdown will be presented, which could be canceled by clicking the corresponding button that will be shown.
- Delete input files after successful completion:
  - Files will be deleted to recycle bin.
  - If input file is the same as output file, no deletion will occur.
- Path to Rar.exe: if CBR is specified as output type, the path to this executable needs to be specified. Normally Winrar folder: `C:\Program Files\WinRAR\Rar.exe`.
- Button to remove/add Comic Book Maker to the *SendTo* context menu of Windows Explorer. This allows to open easily multiple files from Windows Explorer.

All options are saved at closing and restored at startup. 

### Actions and shortcut keys

* Go button (Enter): start conversion.
* Exit button (Esc): closes program. 
* Refresh files (F5): checks input files and updates output names.
* F2 (on *DataGrid*): enter edit mode of the output name for the selected row. Clicking on the output names of *DataGrid* has the same effect.

## Conversion details

The conversion process does the following steps for each row:
1. Create folder with files in the windows temp folder:
   - Copy the folder (folder input).
   - Extract files (archive or comic files input).
2. Cleanup the files (if enabled) in temp folder.
3. Compress into comic files.
4. Delete input files (if enabled).
5. Delete files of temp folder.

## License

This program uses 7Z.exe and 7z.dll from [7-Zip](https://www.7-zip.org), which are licensed under the GNU LGPL license, see [7-Zip license](https://www.7-zip.org/license.txt) for full details.

