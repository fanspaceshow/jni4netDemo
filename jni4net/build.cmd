@echo off
if not exist target mkdir target
if not exist target\classes mkdir target\classes


echo compile classes
javac -nowarn -d target\classes -sourcepath jvm -cp "d:\programme\java_workspace\jni4net-0.8.8.0-bin\lib\jni4net.j-0.8.8.0.jar"; "jvm\printhelper\IPrintHelper.java" "jvm\printhelper\IPrintHelper_.java" "jvm\printhelper\PrintHelper.java" "jvm\printhelper\PrinterStatus.java" 
IF %ERRORLEVEL% NEQ 0 goto end


echo PrintHelper.j4n.jar 
jar cvf PrintHelper.j4n.jar  -C target\classes "printhelper\IPrintHelper.class"  -C target\classes "printhelper\IPrintHelper_.class"  -C target\classes "printhelper\__IPrintHelper.class"  -C target\classes "printhelper\PrintHelper.class"  -C target\classes "printhelper\PrinterStatus.class"  > nul 
IF %ERRORLEVEL% NEQ 0 goto end


echo PrintHelper.j4n.dll 
csc /nologo /warn:0 /t:library /out:PrintHelper.j4n.dll /recurse:clr\*.cs  /reference:"E:\O2S.Components.PDFRender4NET.dll" /reference:"E:\PrintHelper.dll" /reference:"D:\programme\java_workspace\jni4net-0.8.8.0-bin\lib\jni4net.n-0.8.8.0.dll"
IF %ERRORLEVEL% NEQ 0 goto end


:end
