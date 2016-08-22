@echo off
title Compressing files
echo working on text files...
pushd .\post

for /F %%I IN ('dir /B ..\pre\*.txt') DO (
   echo.Compressing ..\recomp\%%~nI.pak
   ..\psarc.exe create -a -y -q --zlib --inputfile=..\pre\%%I --output=..\recomp\%%~nI.pak
   del /Q %%I
)
popd 
pause