
Have your Timetable as a window on your computer instead of your desktop wallpaper!

[Download Timetable!](https://y2k04.github.io/timetable/Timetable.zip)

## Patch Notes

### v3.0.0
- Rewrote the entire program
- Added a more graphical first time setup
- Added cropping
- Added a menu bar _(which appears when the program is focused)_
- Added a minimise and exit button
- Replaced the Syncfusion.PDF library with _Docnet.Core_ 
- Moved the timetable and class list image location to the `AppData\Roaming` folder instead of using the application's folder
- Added last modified dates which are stored in the registry under `HKEY_CURRENT_USER\SOFTWARE\Timetable`
- Changed the icon for the program
- Changed the application font from _Microsoft Sans Serif_ to _Segoe UI_

#### Bug fixes
- Fixed the rapid relaunching to find the top-right corner of the screen (it was caused by a lazy exception fix I made 😂)
- Fixed the positioning of the Timetable window whenever the screen changes orientation (for example: rotating to portrait and then back to landscape would cause the window to move to the centre of the screen, instead of the corner)
- Fixed the application making the timetable and class list image read only when the program was open (it now stores it in memory)

#### Removed features
- Keyboard shortcuts (will be reimplemented in the next minor release)

### v1.9.2
 - Added context menu
 - Added settings window
 - Added window dragging (saving the window position is a work in progress)
 - Fixed bugs
 
 ***Note: Press alt to open context menu.***

### v1.8.1
 - Fixed User Profile finding bug

### v1.8
 - Added Class List import and popup window.
***Note: Use CTRL+Home to open Class List window.***

### v1.7
 - Added multi-monitor support
 
***Note: Use CTRL+1,2,3,4,5,6,7,8,9 to move Timetable to different screens.***

### v1.6
- Improved Timetable import (Note: need to fix PDF crop and resizer)

### v1.5
- Added Timetable import
- Added On-Startup link
- Added Error catching
- Added 'settings.txt'
- Removed 'startup.cmd'
- Removed 'README.txt'

### v1.0
- Added Timetable container
- Added 'startup.cmd'
- Added 'README.txt'
