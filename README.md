**
this application was required to take a standard pipe-delimited file and take any item in column 33 and append it directly onto the end of the file. 

Requirements:
This must be easily usable on a client machine on a chron job running in the background. It is worth noting this will still create a popup but a VB script could be used to bypass that. So far this is not a requirement. 

The files should be placed in one folder, c:\new\ , the Batch file will move them to c:\import\ and then run the .exe. the .exe written in c# will then move the file to \output and .bat will remove the files from the import folder

Potential issues:

the file is not | finished. This may cause an error and should be addressed. If so, can be recompiled in vbs

note:
the original c# script was specced by Mark Preston but designed and written by https://gist.github.com/raylu
The compiled .exe can be found at https://www.raylu.net/f/import111.exe

Many thanks to Raylu for the help with this and the guys over at ##learnprogramming on FreeNode