// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class TextField_21: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.TextField _fthis_20;

public void @this(global::com.codename1.ui.TextField n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.TextField$1: void <init>(com.codename1.ui.TextField)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.TextField_21) _r0_o)._fthis_20 = (global::com.codename1.ui.TextField) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.TextField$1: void <init>(com.codename1.ui.TextField)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.TextField$1: void run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.TextField_21) _r1_o)._fthis_20;
    ((global::com.codename1.ui.TextField) _r0_o).fireDoneEvent();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.TextField$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.TextField$1]
//XMLVM_END_WRAPPER[com.codename1.ui.TextField$1]

} // end of class: TextField_21

} // end of namespace: com.codename1.ui
