@echo off
color 0a
cls
cd Debug
echo Finishing install...
echo Please don't turn off application. This will take a few seconds.
echo Task: stabalizing files...
TIMEOUT /T 3 >nul
echo Task: Replacing files...
cd Update
echo --------------------------------------------------------------
echo                         List of files
echo --------------------------------------------------------------
tree /f
echo --------------------------------------------------------------
echo                        Files to replace
echo --------------------------------------------------------------
cd ..\
tree /f
echo --------------------------------------------------------------
echo                        Modifing files
echo --------------------------------------------------------------
echo Modifing...
cd Update
dir
copy * "..\"
cd Images
dir
copy * "..\..\Images"
cd ..\
cd Source
copy * "..\..\Source"
cd ..\
cd Videos
copy * "..\..\Videos"
cd ..\
copy * "..\"
echo ==============================================================
echo                              Done
echo ==============================================================
pause
exit