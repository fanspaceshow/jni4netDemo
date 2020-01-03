package com.test.circle;

import java.io.File;
import java.io.IOException;

import classlibrary1.Class1;
import net.sf.jni4net.Bridge;

public class MyTEST {

	public static void main(String[] args) {
		try {
			Bridge.setVerbose(true);
			Bridge.init();
			File load = new File("ClassLibrary1.j4n.dll");
			Bridge.LoadAndRegisterAssemblyFrom(load);
			System.out.println(new Class1().getString("HelloWorld"));
			
		} catch (IOException e) {
			e.printStackTrace();
		}
		
	}

}
