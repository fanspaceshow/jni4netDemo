@rem author tianming.fan
@echo off
@rem d:
cd /d D:\programme\jni4net-0.8.8.0-bin\bin
.\proxygen.exe E:\CWorkspace\PrintHelper\bin\Release\PrintHelper.dll -wd E:\compile -dp E:\CWorkspace\PrintHelper\bin\Release\O2S.Components.PDFRender4NET.dll
@rem d:
cd /d E:\compile
.\build.cmd
pause