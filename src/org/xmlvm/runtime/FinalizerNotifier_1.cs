// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xmlvm.runtime {
public class FinalizerNotifier_21: global::java.lang.Thread {
public void @this(){
//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.FinalizerNotifier$1: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Thread) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.xmlvm.runtime.FinalizerNotifier$1: void <init>()]
}

public override void run(){
//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.FinalizerNotifier$1: void run()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 1;
    _r0.i = 0;
    label2:;
    if (_r0.i != 0) goto label63;
    _r1_o = global::org.xmlvm.runtime.FinalizerNotifier.access_2000();
    ((global::org.xmlvm.runtime.Mutex) _r1_o).@lock();
    _r1.i = global::org.xmlvm.runtime.FinalizerNotifier.access_2100() ? 1 : 0;
    if (_r1.i != 0) goto label31;
    global::org.xmlvm.runtime.FinalizerNotifier.access_2200(0!=_r3.i);
    _r1_o = global::org.xmlvm.runtime.FinalizerNotifier.access_2300();
    _r2_o = global::org.xmlvm.runtime.FinalizerNotifier.access_2000();
    ((global::org.xmlvm.runtime.Condition) _r1_o).wait((global::org.xmlvm.runtime.Mutex) _r2_o);
    label31:;
    _r1_o = global::org.xmlvm.runtime.FinalizerNotifier.access_2000();
    ((global::org.xmlvm.runtime.Mutex) _r1_o).unlock();
    _r0.i = global::org.xmlvm.runtime.FinalizerNotifier.access_2400() ? 1 : 0;
    _r1_o = global::org.xmlvm.runtime.FinalizerNotifier.access_2000();
    ((global::org.xmlvm.runtime.Mutex) _r1_o).@lock();
    global::org.xmlvm.runtime.FinalizerNotifier.access_2200(0!=_r3.i);
    _r1_o = global::org.xmlvm.runtime.FinalizerNotifier.access_2000();
    ((global::org.xmlvm.runtime.Mutex) _r1_o).unlock();
    global::java.lang.System.gc();
    goto label2;
    label63:;
    return;
//XMLVM_END_WRAPPER[org.xmlvm.runtime.FinalizerNotifier$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.FinalizerNotifier$1]
//XMLVM_END_WRAPPER[org.xmlvm.runtime.FinalizerNotifier$1]

} // end of class: FinalizerNotifier_21

} // end of namespace: org.xmlvm.runtime
