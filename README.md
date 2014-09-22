**
this application was required to take a standard pipe-delimited file and take any item in column 33 and append it directly onto the end of the file. 

Requirements:
This must be easily usable on a client machine on a chron job running in the background. It is worth noting this will still create a popup but a VB script could be used to bypass that. So far this is not a requirement. 

The files should be placed in one folder, c:\new\ , the Batch file will move them to c:\import\ and then run the .exe. the .exe written in c# will then move the file to \output and .bat will remove the files from the import folder

Potential issues:

Fixed issues:
The batch file was removing the files before the .exe was running. Adding a /wait ensured this didn't happen.
updated to add a "|" at the end of each line as well as the file name from .psv to .csv as per request

note:
the original c# script was specced by Mark Preston but designed and written by https://gist.github.com/raylu
The compiled .exe can be found at https://www.raylu.net/f/import111.exe
The script has also been provide in Python but cannot be used due to clientside limitations

Many thanks to Raylu for the help with this and the guys over at ##learnprogramming on FreeNode

