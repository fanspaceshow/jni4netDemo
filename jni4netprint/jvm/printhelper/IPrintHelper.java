// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package printhelper;

@net.sf.jni4net.attributes.ClrInterface
public interface IPrintHelper {
    
    //<generated-interface>
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    java.lang.String HelloWorld();
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/String;")
    java.lang.String[] GetPrinters();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/String;")
    java.lang.String GetPrinterStatus(java.lang.String Printer);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/String;IIII)LSystem/String;")
    java.lang.String PrintPDF(java.lang.String Printer, java.lang.String FileName, int printRange, int pageFrom, int pageTo, int copies);
    //</generated-interface>
}
