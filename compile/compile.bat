@rem author tianming.fan
@echo off

@rem cd /d D:\programme\jni4net-0.8.8.0-bin\bin
@rem D:\programme\jni4net-0.8.8.0-bin\bin\proxygen.exe E:\workspace\CWorkspace\ClassLibrary3\ClassLibrary3\bin\Release\PrintHelper.dll -wd E:\workspace\compile 
@rem -dp C:\Windows\System32\winspool.drv
D:\programme\jni4net-0.8.8.0-bin\bin\proxygen.exe E:\workspace\CWorkspace\PrintHelper\bin\Release\PrintHelper.dll -wd E:\workspace\compile -dp E:\workspace\CWorkspace\PrintHelper\bin\Release\O2S.Components.PDFRender4NET.dll


@rem cd /d E:\workspace\compile
@rem .\build.cmd
E:\workspace\compile\build.cmd

pause