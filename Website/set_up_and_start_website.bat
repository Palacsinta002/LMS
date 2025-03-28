@echo off
setlocal
setlocal enabledelayedexpansion
:: Check for XAMPP installation
if exist "C:\nemWindows\realXampp" set XAMPP_PATH=C:\nemWindows\realXampp
if exist "C:\xampp" set XAMPP_PATH=C:\xampp



if not defined XAMPP_PATH (
    echo XAMPP not found in common locations. Please set the path manually.
    pause
    exit /b
)


:: Check if MySQL is already running
echo Checking MySQL status...
"%XAMPP_PATH%\mysql\bin\mysqladmin" -u root ping >nul 2>&1
if %errorlevel% neq 0 (
    echo MySQL is not running. Starting services...

    echo Starting Apache on port 8080...
    start /B "" "%XAMPP_PATH%\apache\bin\httpd.exe"  

    echo Starting MySQL on port 3306...
    start /B "" "%XAMPP_PATH%\mysql_start.bat"

    echo Waiting for MySQL to fully start...
    timeout /t 10 /nobreak >nul
) else (
    echo MySQL is already running, skipping start.
)

:: Verify MySQL is running before proceeding
echo Checking MySQL status again...
"%XAMPP_PATH%\mysql\bin\mysqladmin" -u root ping >nul 2>&1
if %errorlevel% neq 0 (
    echo MySQL failed to start. Exiting...
    pause
    exit /b
)

:: Move to Database directory and migrate database
cd ..\Database
echo Migrating database...
set MYSQL_USER=root
set DATABASE_NAME=LMS
set MYSQL_PATH="%XAMPP_PATH%\mysql\bin"
set SQL_FILE="Database.sql"

"%MYSQL_PATH%\mysql" -u%MYSQL_USER% -e "source %SQL_FILE%" 

:: Start Backend
cd ..\Website
echo Starting Backend...
cd php\realproject
start /B "" php -S 127.0.0.1:8000 router.php

:: Start Frontend
cd ..\..
echo Installing Frontend dependencies...
cd React
call npm install --yes

echo Starting Frontend...
start /B "" npm run dev

echo Servers started!
pause
exit
