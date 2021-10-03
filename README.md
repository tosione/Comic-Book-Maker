# Comic-Book-Maker
A program for compressing and recompressing comic book files.

Official repository: https://github.com/tosione/Comic-Book-Maker

## Features

- Allowed input files:
  - Folders with files
  - Archives: ZIP, 7Z, RAR
  - Comic files: CBZ, CB7, CBR

- Supported output comic files: CBZ, CB7, CBR[^1]
- Cleaning of files:
  - Multiple wildcards for files to clean.
  - Removing of unnecessary folder structures.
- Multi thread processing of files for increased speed.
- Deleting of input files.
- Drag-n-drop support.
- Integration into *SendTo* context menu of Windows Explorer for automatic opening of multiple files.
- Option for automatic start after adding files, and automatic close after successful completion, allowing automatic file processing when used together with *SendTo* context menu.

[^1]: Rar.exe from [RarLab](https://www.rarlab.com) is required for CBR creation.


## License

This program uses 7Z.exe and 7z.dll from [7-Zip](https://www.7-zip.org), which is is licensed under the GNU LGPL license, see [7-Zip license](https://www.7-zip.org/license.txt).

