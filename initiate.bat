@ECHO 
MOVE/y c:\new\* c:\import
START /WAIT c:\DHL\import.exe \import 33 \output
DEL /Q c:\import\*
TIMEOUT /t 30
MOVE/y c:\new\* c:\import
START /WAIT c:\DHL\import.exe \import 33 \output
DEL /Q c:\import\*
