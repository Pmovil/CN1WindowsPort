// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class InfiniteContainer_22: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.InfiniteContainer _fthis_20;

public void @this(global::com.codename1.ui.InfiniteContainer n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer$2: void <init>(com.codename1.ui.InfiniteContainer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.InfiniteContainer_22) _r0_o)._fthis_20 = (global::com.codename1.ui.InfiniteContainer) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer$2: void <init>(com.codename1.ui.InfiniteContainer)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer$2: void run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r1_o = new global::com.codename1.ui.InfiniteContainer_22_21();
    ((global::com.codename1.ui.InfiniteContainer_22_21) _r1_o).@this((global::com.codename1.ui.InfiniteContainer_22) _r2_o);
    ((global::com.codename1.ui.Display) _r0_o).scheduleBackgroundTask((global::java.lang.Runnable) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer$2: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer$2]
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer$2]

} // end of class: InfiniteContainer_22

} // end of namespace: com.codename1.ui
