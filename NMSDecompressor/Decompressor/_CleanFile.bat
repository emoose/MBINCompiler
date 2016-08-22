@Echo off

SET c=%~n1

rem overwrite original file if exists

IF EXIST .\pre\%c:~0,-4%.txt (
   del /Q .\pre\%c:~0,-4%.txt
)

FOR /F "tokens=2" %%a IN (%1) DO (
   echo %%a >> .\pre\%c:~0,-4%.txt
)