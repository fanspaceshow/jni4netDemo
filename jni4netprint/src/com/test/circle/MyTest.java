/**
 * 
 */
package com.test.circle;

import java.io.File;
import java.io.IOException;

import net.sf.jni4net.Bridge;
import printhelper.PrintHelper;

/**
 * @author tianming.fan
 *
 */
public class MyTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {

		try {
			Bridge.setVerbose(true);
			Bridge.init();
			File load = new File("PrintHelper.j4n.dll");
			Bridge.LoadAndRegisterAssemblyFrom(load);
			
			System.out.println(new PrintHelper().HelloWorld());
			System.out.println(new PrintHelper().PrintPDF("HP Universal Printing PCL 6","E:\\Doc1.pdf",1,1,1,1));
			
		} catch (IOException e) {
			e.printStackTrace();
		}
		
	}

}
