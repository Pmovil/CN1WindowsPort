// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax.helpers {
public class NewInstance: global::java.lang.Object {
public void @this(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.NewInstance: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.NewInstance: void <init>()]
}

public static global::System.Object newInstance(global::java.lang.ClassLoader n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.NewInstance: java.lang.Object newInstance(java.lang.ClassLoader, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = n1;
    _r2_o = n2;
    if (_r1_o != null) goto label11;
    _r0_o = global::java.lang.Class.forName((global::java.lang.String) _r2_o);
    label6:;
    _r0_o = ((global::java.lang.Class) _r0_o).newInstance();
    return (global::java.lang.Object) _r0_o;
    label11:;
    _r0_o = ((global::java.lang.ClassLoader) _r1_o).loadClass((global::java.lang.String) _r2_o);
    goto label6;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.NewInstance: java.lang.Object newInstance(java.lang.ClassLoader, java.lang.String)]
}

public static global::System.Object getClassLoader(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.NewInstance: java.lang.ClassLoader getClassLoader()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    try {
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Thread));
    // Value=getContextClassLoader
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r2_o = null;
    _r0_o = ((global::java.lang.Class) _r0_o).getMethod((global::java.lang.String) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NoSuchMethodException) {
            _ex = ex;
            goto label21;
        }
        throw ex;
    } // end catch
    try {
    _r1_o = global::java.lang.Thread.currentThread();
    _r2_o = null;
    _r0_o = ((global::java.lang.reflect.Method) _r0_o).invoke((global::java.lang.Object) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IllegalAccessException) {
            _ex = ex;
            goto label29;
        }
        if (_java_exception is global::java.lang.reflect.InvocationTargetException) {
            _ex = ex;
            goto label40;
        }
        throw ex;
    } // end catch
    label20:;
    return (global::java.lang.ClassLoader) _r0_o;
    label21:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::org.xml.sax.helpers.NewInstance));
    _r0_o = ((global::java.lang.Class) _r0_o).getClassLoader();
    goto label20;
    label29:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.lang.UnknownError();
    _r0_o = ((global::java.lang.IllegalAccessException) _r0_o).getMessage();
    ((global::java.lang.UnknownError) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnknownError) _r1_o);
    label40:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.lang.UnknownError();
    _r0_o = ((global::java.lang.reflect.InvocationTargetException) _r0_o).getMessage();
    ((global::java.lang.UnknownError) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnknownError) _r1_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.NewInstance: java.lang.ClassLoader getClassLoader()]
}

//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.NewInstance]
//XMLVM_END_WRAPPER[org.xml.sax.helpers.NewInstance]

} // end of class: NewInstance

} // end of namespace: org.xml.sax.helpers
