// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2SynchronizedRandomAccessList: global::java.util.Collections_2SynchronizedList,global::java.util.RandomAccess {
private static long _fserialVersionUID = 1530674583602358482L;

public void @this(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: void <init>(java.util.List)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Collections_2SynchronizedList) _r0_o).@this((global::java.util.List) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: void <init>(java.util.List)]
}

public void @this(global::java.util.List n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: void <init>(java.util.List, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.Collections_2SynchronizedList) _r0_o).@this((global::java.util.List) _r1_o, (global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: void <init>(java.util.List, java.lang.Object)]
}

public override global::System.Object subList(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: java.util.List subList(int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r0_o = ((global::java.util.Collections_2SynchronizedRandomAccessList) _r4_o)._fmutex;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = new global::java.util.Collections_2SynchronizedRandomAccessList();
    _r2_o = ((global::java.util.Collections_2SynchronizedRandomAccessList) _r4_o)._flist;
    _r2_o = ((global::java.util.List) _r2_o).subList((int) _r5.i, (int) _r6.i);
    _r3_o = ((global::java.util.Collections_2SynchronizedRandomAccessList) _r4_o)._fmutex;
    ((global::java.util.Collections_2SynchronizedRandomAccessList) _r1_o).@this((global::java.util.List) _r2_o, (global::java.lang.Object) _r3_o);
    global::System.Threading.Monitor.Exit(_r0_o);
    return (global::java.util.List) _r1_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label18;
        }
        throw ex;
    } // end catch
    label18:;
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
            goto label18;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: java.util.List subList(int, int)]
}

private global::System.Object writeReplace(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: java.lang.Object writeReplace()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.util.Collections_2SynchronizedList();
    _r1_o = ((global::java.util.Collections_2SynchronizedRandomAccessList) _r2_o)._flist;
    ((global::java.util.Collections_2SynchronizedList) _r0_o).@this((global::java.util.List) _r1_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SynchronizedRandomAccessList: java.lang.Object writeReplace()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$SynchronizedRandomAccessList]
//XMLVM_END_WRAPPER[java.util.Collections$SynchronizedRandomAccessList]

} // end of class: Collections_2SynchronizedRandomAccessList

} // end of namespace: java.util
