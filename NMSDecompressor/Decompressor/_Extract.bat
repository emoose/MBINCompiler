@echo off

Title Extracting...

echo wait while the packs are all extracted. destination is .\post directory

for /F %%I IN ('dir /B .\pre\*.pak') DO (
   echo.Extracting .\pre\%%I
   psarc.exe extract -y --to=.\post .\pre\%%I > .\pre\%%I.txt
   call .\_CleanFile.bat .\pre\%%I.txt
   DEL /Q .\pre\%%I.txt
   echo.Moving .\pre\%%I to .\bak\...
   MOVE /Y .\pre\%%I .\bak\ > nul
)

pause