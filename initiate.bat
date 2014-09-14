@ECHO 
MOVE/y c:\new\* c:\import
START c:\DHL\import.exe \import 33 \output
DEL c:\import\* -y
PAUSE