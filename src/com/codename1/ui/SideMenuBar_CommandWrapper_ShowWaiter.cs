// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_2CommandWrapper_2ShowWaiter: global::java.lang.Object,global::java.lang.Runnable,global::com.codename1.ui.events.ActionListener {
private global::java.lang.Object _fLOCK;

public global::com.codename1.ui.SideMenuBar_2CommandWrapper _fthis_21;

public void @this(global::com.codename1.ui.SideMenuBar_2CommandWrapper n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter: void <init>(com.codename1.ui.SideMenuBar$CommandWrapper)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r1_o)._fthis_21 = (global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.lang.Object();
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r1_o)._fLOCK = (global::java.lang.Object) _r0_o;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r0_o);
    ((global::com.codename1.ui.Form) _r0_o).addShowListener((global::com.codename1.ui.events.ActionListener) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter: void <init>(com.codename1.ui.SideMenuBar$CommandWrapper)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).isEdt() ? 1 : 0;
    if (_r1.i == 0) goto label37;
    _r0_o = new global::com.codename1.ui.events.ActionEvent();
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r1_o)._fcmd;
    _r2_o = global::com.codename1.ui.events.ActionEvent_2Type._fCommand;
    ((global::com.codename1.ui.events.ActionEvent) _r0_o).@this((global::java.lang.Object) _r1_o, (global::com.codename1.ui.events.ActionEvent_2Type) _r2_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r1_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r1_o);
    _r2_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r5_o)._fthis_21;
    _r2_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fcmd;
    ((global::com.codename1.ui.Form) _r1_o).dispatchCommand((global::com.codename1.ui.Command) _r2_o, (global::com.codename1.ui.events.ActionEvent) _r0_o);
    label36:;
    return;
    label37:;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r5_o)._fLOCK;
    global::System.Threading.Monitor.Enter(_r1_o);
    label40:;
    try {
    _r2_o = global::com.codename1.ui.Display.getInstance();
    _r2_o = ((global::com.codename1.ui.Display) _r2_o).getCurrent();
    _r3_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r5_o)._fthis_21;
    _r3_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r3_o)._fthis_20;
    _r3_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label77;
        }
        throw ex;
    } // end catch
    if (_r2_o == _r3_o) goto label68;
    try {
    _r2_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r5_o)._fLOCK;
    _r3.l = 40L;
    ((global::java.lang.Object) _r2_o).wait((long) _r3.l);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label66;
        }
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label77;
        }
        throw ex;
    } // end catch
    goto label40;
    label66:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    goto label40;
    label68:;
    try {
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label77;
        }
        throw ex;
    } // end catch
    _r1_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r1_o).callSerially((global::java.lang.Runnable) _r5_o);
    goto label36;
    label77:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label77;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r2_o);
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter: void run()]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r2_o)._fLOCK;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r2_o)._fLOCK;
    ((global::java.lang.Object) _r1_o).notify();
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label10;
        }
        throw ex;
    } // end catch
    label10:;
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
            goto label10;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper$ShowWaiter]

} // end of class: SideMenuBar_2CommandWrapper_2ShowWaiter

} // end of namespace: com.codename1.ui
