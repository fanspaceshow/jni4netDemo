# jni4netDemo

一般Java调用C类语言有两种方式，COM和DLL。  

Jawin和Jacob都是基于使用COM调用。

JNI和基于JNI的增强版JNA就是可以直接调用DLL的工具，但是只支持C/C++。  

如果想用Java调用C#要么使用COM，要么用C/C++写胶水语言间接调用C#。  
因为如果在Windows上运行C#的功能肯定优于Java。

偶然间我发现论坛上有一种新的工具，可以很方便的调用C#，这就是jni4net，托管于Github上。

[详情见Wiki](https://github.com/fanspaceshow/jni4netDemo/wiki)
