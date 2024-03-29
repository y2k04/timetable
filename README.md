# Timetable by y2k04

Have your Timetable as a window on your computer instead of your desktop wallpaper!

### Compatibility
*Windows 8.1* to *Windows 11* on x86-64 CPU platform

(Tested on Win10 x64 and Win11 x64)

- .net Framework 4.8 required.

### [Download (Latest)](https://github.com/y2k04/timetable/releases/latest/download/Timetable.zip)

## Screenshots
![image](https://user-images.githubusercontent.com/29883287/197338291-92499efb-d727-44b9-85c2-0159a4c952a9.png)

![image](https://user-images.githubusercontent.com/29883287/197338299-947fd1e3-b277-4e8b-957c-9c40b294d8ef.png)

![image](https://user-images.githubusercontent.com/29883287/197338304-4455423b-f923-4983-be14-48c6096f7670.png)

![image](https://user-images.githubusercontent.com/29883287/197338312-1bee1488-58a5-426f-bd63-ca3bb6c2d90b.png)

![image](https://user-images.githubusercontent.com/29883287/197338317-d3eea8f5-f475-403b-9eab-ef119e5fc8d6.png)

![image](https://user-images.githubusercontent.com/29883287/197338320-ac08d3a8-5851-4ca5-ac93-d40a615354e9.png)

![image](https://user-images.githubusercontent.com/29883287/197338323-5a33b200-e6e2-483d-86ce-ad6038a6e83e.png)

## Patch Notes

### v3.0.1
- Fixed null reference error when retrieving registry value
- Fixed package retrieval when compiling Timetable yourself

### v3.0.0
- Rewrote the entire program
- Added a more graphical first time setup
- Added cropping
- Added a menu bar _(which appears when the program is focused)_
- Added a minimise and exit button
- Replaced the *Syncfusion.PDF* library with _Docnet.Core_ 
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
