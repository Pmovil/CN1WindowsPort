// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Display_21: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.Display _fthis_20;

public void @this(global::com.codename1.ui.Display n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Display$1: void <init>(com.codename1.ui.Display)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Display_21) _r0_o)._fthis_20 = (global::com.codename1.ui.Display) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Display$1: void <init>(com.codename1.ui.Display)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Display$1: void run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    label0:;
    _r2_o = null;
    _r4_o = global::com.codename1.ui.Display._flock;
    global::System.Threading.Monitor.Enter(_r4_o);
    try {
    _r3_o = ((global::com.codename1.ui.Display_21) _r6_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Display.access_2000((global::com.codename1.ui.Display) _r3_o);
    _r3.i = ((global::java.util.ArrayList) _r3_o).size();
    if (_r3.i <= 0) goto label53;
    _r3_o = ((global::com.codename1.ui.Display_21) _r6_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Display.access_2000((global::com.codename1.ui.Display) _r3_o);
    _r5.i = 0;
    _r3_o = ((global::java.util.ArrayList) _r3_o).get((int) _r5.i);
    _r0_o = _r3_o;
    _r0_o = _r0_o;
    _r2_o = _r0_o;
    _r3_o = ((global::com.codename1.ui.Display_21) _r6_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Display.access_2000((global::com.codename1.ui.Display) _r3_o);
    _r5.i = 0;
    ((global::java.util.ArrayList) _r3_o).remove((int) _r5.i);
    global::System.Threading.Monitor.Exit(_r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    try {
    ((global::java.lang.Runnable) _r2_o).run();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label64;
        }
        throw ex;
    } // end catch
    label45:;
    _r3.l = 10L;
    try {
    global::java.lang.Thread.sleep((long) _r3.l);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.InterruptedException) {
            _ex = ex;
            goto label51;
        }
        throw ex;
    } // end catch
    goto label0;
    label51:;
    _r3_o = _ex.getJavaException();
    _ex = null;
    goto label0;
    label53:;
    try {
    _r3_o = ((global::com.codename1.ui.Display_21) _r6_o)._fthis_20;
    _r5_o = null;
    global::com.codename1.ui.Display.access_2102((global::com.codename1.ui.Display) _r3_o, (global::java.lang.Thread) _r5_o);
    global::System.Threading.Monitor.Exit(_r4_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    label61:;
    try {
    _r3_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r3_o);
    label64:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    ((global::java.lang.Throwable) _r1_o).printStackTrace();
    goto label45;
//XMLVM_END_WRAPPER[com.codename1.ui.Display$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Display$1]
//XMLVM_END_WRAPPER[com.codename1.ui.Display$1]

} // end of class: Display_21

} // end of namespace: com.codename1.ui
