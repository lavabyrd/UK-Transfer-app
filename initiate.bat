@ECHO 
MOVE/y c:\new\* c:\import
START /WAIT c:\DHL\import.exe \import 33 \output
DEL /Q c:\import\*
