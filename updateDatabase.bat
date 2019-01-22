@ECHO OFF
:BEGIN
title Command
@ECHO Please wait...

SET DATABASE=.\SQLEXPRESS
SET USERNAME=sa
SET PASSWORD=sa
SET SCRIPT_UPDATE=updateDatabase.sql
SET FILE_OUTPUT_UPDATE=resultUpdateDatabase.txt

sqlcmd -S %DATABASE% -U %USERNAME% -P %PASSWORD% -i %SCRIPT_UPDATE% -o %FILE_OUTPUT_UPDATE%

:END
pause