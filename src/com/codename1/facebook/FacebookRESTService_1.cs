// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class FacebookRESTService_21: global::java.util.Vector {
public global::com.codename1.facebook.FacebookRESTService _fthis_20;

public void @this(global::com.codename1.facebook.FacebookRESTService n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FacebookRESTService$1: void <init>(com.codename1.facebook.FacebookRESTService)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.facebook.FacebookRESTService_21) _r0_o)._fthis_20 = (global::com.codename1.facebook.FacebookRESTService) _r1_o;
    ((global::java.util.Vector) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FacebookRESTService$1: void <init>(com.codename1.facebook.FacebookRESTService)]
}

public override void addElement(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FacebookRESTService$1: void addElement(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    global::System.Threading.Monitor.Enter(_r3_o);
    try {
    _r1_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.facebook.FacebookRESTService.access_2000((global::com.codename1.facebook.FacebookRESTService) _r1_o);
    if (_r1_o == null) goto label76;
    _r1_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r1.i = global::com.codename1.facebook.FacebookRESTService.access_2100((global::com.codename1.facebook.FacebookRESTService) _r1_o);
    _r2.i = -1;
    if (_r1.i != _r2.i) goto label29;
    _r1_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.facebook.FacebookRESTService.access_2000((global::com.codename1.facebook.FacebookRESTService) _r1_o);
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).addItem((global::java.lang.Object) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label73;
        }
        throw ex;
    } // end catch
    label27:;
    global::System.Threading.Monitor.Exit(_r3_o);
    return;
    label29:;
    try {
    _r1_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.facebook.FacebookRESTService.access_2000((global::com.codename1.facebook.FacebookRESTService) _r1_o);
    _r2_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r2.i = global::com.codename1.facebook.FacebookRESTService.access_2100((global::com.codename1.facebook.FacebookRESTService) _r2_o);
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o).getItemAt((int) _r2.i);
    _r0_o = _r0_o;
    _r4_o = _r4_o;
    ((global::java.util.Hashtable) _r0_o).putAll((global::java.util.Map) _r4_o);
    _r1_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.facebook.FacebookRESTService.access_2000((global::com.codename1.facebook.FacebookRESTService) _r1_o);
    _r2_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    _r2.i = global::com.codename1.facebook.FacebookRESTService.access_2100((global::com.codename1.facebook.FacebookRESTService) _r2_o);
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).setItem((int) _r2.i, (global::java.lang.Object) _r0_o);
    _r1_o = ((global::com.codename1.facebook.FacebookRESTService_21) _r3_o)._fthis_20;
    global::com.codename1.facebook.FacebookRESTService.access_2108((global::com.codename1.facebook.FacebookRESTService) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label73;
        }
        throw ex;
    } // end catch
    goto label27;
    label73:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r3_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r1_o);
    label76:;
    try {
    base.addElement((global::java.lang.Object) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label73;
        }
        throw ex;
    } // end catch
    goto label27;
//XMLVM_END_WRAPPER[com.codename1.facebook.FacebookRESTService$1: void addElement(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FacebookRESTService$1]
//XMLVM_END_WRAPPER[com.codename1.facebook.FacebookRESTService$1]

} // end of class: FacebookRESTService_21

} // end of namespace: com.codename1.facebook
