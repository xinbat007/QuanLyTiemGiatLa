@ECHO OFF
:BEGIN
title Command
@ECHO Please wait...

::sqlcmd -S .\DATASQL -U sa -P 123456 -i a.sql -o a.txt
sqlcmd -S .\SQLEXPRESS 			-i a.sql -o a.txt


::mplay32 /play /close c:\windows\media\chimes.wav
::mplay32 /play /close "c:\windows\media\windows error.wav"
::mplay32 /play /close "c:\windows\media\windows ding.wav"
:: this is a remark line
rem this is another command line
:END
pause