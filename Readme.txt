Windows Environment Variables Manager

Environment Variables Manager (EnvMan) is a tool written in C# .Net 
intended to handle the administration of Windows Shell Environment Variables. 
It is designed to replace Control Panel System Environment Manager and easily manage long variable values.

HISTORY

04/04/2009  Release 1.4 RC1
	* Added handling of extensible variables
	* Implemented Automated Updates Manager notifications
	* Added connection through Proxy server for Automated Updates Manager
	* Added Settings screen to control Proxy settings and number of instances
	* Added version display for Beta versions
	* Fixed Variable Type Validation
	* EnvMan allows only one running instance
	* Minor Bug Fixes
18/12/2007	Release 1.3
	* BT1828033 Escape to Close 
        - Added Ctrl+X Shortcut on Main Form Exit File Menu
	* BT843838 Program does not check for changes on Cancel in Edit Form 
        - Added checking for user changes and prompt to save it on Cancel.
    * Added Release version display in Main Form Title bar
    * Added colour change for rows with invalid value paths in Main Form
    * Minor GUI Improvements
15/10/2007	Release 1.2.2
	* Fixed problem with Delete button on Edit Form
	* Removed Setup project. It will be replaced by WiX setup.
04/10/2007	Release 1.2.1
	* BT1767453 On value edit Undo Redo not recording
		Fixed problems when user does not enter text into value cell
	* BT1792173 Incorrectly detected Value type
		Checking that path string is starts with "<drive>:\"
	* BT1806716 Grid Cell accepts semi colon
		Added validation DataGridView in Edit form
11/09/2007	Release 1.2
	* Implementation of Import/Export variable values functionality (BT1709867)
	* Implementation of Locate/Open in Windows Explorer Edit Form Grid context menu 
	  (BT1729869 - Implemented by PRANKENST!EN)
	* Upgraded license to GPL Version 3
11/06/2007	Release 1.1.2
	* Added Help new menu entries.
	* Added credits box in About box 
	* modified CleanAll.bat to work with new projects
	* Added build of Setup project
	* Fixed reloading of Main Form on Row double click
	* Added remembering current row and setting it visible after reloading
	* Now SetBtnState happens on Dgv current selection change
	* Fixed row deletion when user hits delete key on keyboard
30/05/2007	Release 1.1.1.0
	* Implementation of Undo/Redo functionality (Bug Tracker ID: 1705000)
	* Added Tool Tip info for icons in Edit Form
25/05/2007	Release 1.1.0.2
	* Made single selection in the Edit form grid
	* Set minimum sizes for main and edit forms
	* Fixed bug on renaming variable name
30/04/2007	Release 1.1.0.1
	* Fix alignment of the delete button.
	* Simplify parsing of the variable value string by using string.split function
	* Add settings to save splitter position of the component
27/04/2007	Release 1.1.0.0 
	* Added Variable Type recognition in the edit form
	* Added forms location, size and state saving and loading using application settings  (Bug Tracker ID: 1705001)
19/04/2007	Release 1.0.0.0 - First Release of the EnvMan.



INSTALL

In order to run this program you need to have .Net 2.0 runtime installed. 
(http://www.microsoft.com/downloads/details.aspx?familyid=0856EACB-4362-4B0D-8EDD-AAB15C5E04F5&displaylang=en)
After installing .Net 2.0 runtime download program binaries from the EnvMan Project Website.
(https://sourceforge.net/projects/env-man/) Unzip EnvMan-x.x.x.x.zip file to where you want and set a short cut to EnvMan.exe 
file to desktop or start menu. You are now ready to run application.

UPGRADE

If you are using earlier version of the project. Download a latest release and replace 
corresponding exe and DLL files by removing the old ones and installing new versions.

Enjoy!

If you have problems please visit
Project Homepage: http://env-man.blogspot.com/2007/04/envman-user-guide.html
SourceForge page: http://sourceforge.net/projects/env-man for Bug Tracker options

Contact E-Mail: <envman-dev@googlegroups.com>
