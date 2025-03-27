@echo off

cd PHP\realproject
echo Starting Backend...
start /B "" php -S 127.0.0.1 router.php

cd ..\..

cd React
echo Starting Frontend...
start /B "" npm run dev

echo Servers started!
pause