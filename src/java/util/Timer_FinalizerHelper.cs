// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Timer_2FinalizerHelper: global::java.lang.Object {
private global::java.util.Timer_2TimerImpl _fimpl;

public void @this(global::java.util.Timer_2TimerImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$FinalizerHelper: void <init>(java.util.Timer$TimerImpl)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.util.Timer_2FinalizerHelper) _r0_o)._fimpl = (global::java.util.Timer_2TimerImpl) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.Timer$FinalizerHelper: void <init>(java.util.Timer$TimerImpl)]
}

public override void @finally(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$FinalizerHelper: void finalize()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = ((global::java.util.Timer_2FinalizerHelper) _r3_o)._fimpl;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = ((global::java.util.Timer_2FinalizerHelper) _r3_o)._fimpl;
    _r2.i = 1;
    global::java.util.Timer_2TimerImpl.access_20((global::java.util.Timer_2TimerImpl) _r1_o, 0!=_r2.i);
    _r1_o = ((global::java.util.Timer_2FinalizerHelper) _r3_o)._fimpl;
    ((global::java.lang.Object) _r1_o).notify();
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label16;
        }
        throw ex;
    } // end catch
    label16:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label16;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.util.Timer$FinalizerHelper: void finalize()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Timer$FinalizerHelper]
//XMLVM_END_WRAPPER[java.util.Timer$FinalizerHelper]

} // end of class: Timer_2FinalizerHelper

} // end of namespace: java.util
