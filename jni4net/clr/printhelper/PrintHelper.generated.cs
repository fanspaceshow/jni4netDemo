//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintHelper {
    
    
    #region Component Designer generated code 
    public partial class PrintHelper_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::PrintHelper.@__PrintHelper.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::PrintHelper.PrintHelper), typeof(global::PrintHelper.PrintHelper_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::PrintHelper.PrintHelper), typeof(global::PrintHelper.PrintHelper_))]
    internal sealed partial class @__PrintHelper : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__PrintHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::PrintHelper.@__PrintHelper.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__PrintHelper);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "HelloWorld", "HelloWorld0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetPrinters", "GetPrinters1", "()[Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetPrinterStatus", "GetPrinterStatus2", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "PrintPDF", "PrintPDF3", "(Ljava/lang/String;Ljava/lang/String;IIII)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorPrintHelper0", "__ctorPrintHelper0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle HelloWorld0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::PrintHelper.PrintHelper @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::PrintHelper.PrintHelper>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::PrintHelper.IPrintHelper)(@__real)).HelloWorld());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetPrinters1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Ljava/lang/String;
            // ()[LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::PrintHelper.PrintHelper @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::PrintHelper.PrintHelper>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2JString(@__env, ((global::PrintHelper.IPrintHelper)(@__real)).GetPrinters());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetPrinterStatus2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle Printer) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::PrintHelper.PrintHelper @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::PrintHelper.PrintHelper>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::PrintHelper.IPrintHelper)(@__real)).GetPrinterStatus(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, Printer)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle PrintPDF3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle Printer, global::net.sf.jni4net.utils.JniLocalHandle FileName, int printRange, int pageFrom, int pageTo, int copies) {
            // (Ljava/lang/String;Ljava/lang/String;IIII)Ljava/lang/String;
            // (LSystem/String;LSystem/String;IIII)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::PrintHelper.PrintHelper @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::PrintHelper.PrintHelper>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::PrintHelper.IPrintHelper)(@__real)).PrintPDF(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, Printer), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, FileName), printRange, pageFrom, pageTo, copies));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorPrintHelper0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::PrintHelper.PrintHelper @__real = new global::PrintHelper.PrintHelper();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::PrintHelper.@__PrintHelper(@__env);
            }
        }
    }
    #endregion
}
