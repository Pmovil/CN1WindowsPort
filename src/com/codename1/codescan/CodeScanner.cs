// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.codescan {
public abstract class CodeScanner: global::java.lang.Object {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.codescan.CodeScanner: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.codescan.CodeScanner: void <init>()]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.codescan.CodeScanner: com.codename1.codescan.CodeScanner getInstance()]
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getCodeScanner();
    return (global::com.codename1.codescan.CodeScanner) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.codescan.CodeScanner: com.codename1.codescan.CodeScanner getInstance()]
}

public abstract void scanQRCode(global::com.codename1.codescan.ScanResult n1);

public abstract void scanBarCode(global::com.codename1.codescan.ScanResult n1);

//XMLVM_BEGIN_WRAPPER[com.codename1.codescan.CodeScanner]
//XMLVM_END_WRAPPER[com.codename1.codescan.CodeScanner]

} // end of class: CodeScanner

} // end of namespace: com.codename1.codescan
