// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public abstract class Writer: global::java.lang.Object,global::java.lang.Appendable,global::java.io.Closeable,global::java.io.Flushable {

static Writer() {
    // Value=null
    _fTOKEN_1NULL = new global::java.lang.String();
    _fTOKEN_1NULL.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
}

public static global::java.lang.String _fTOKEN_1NULL;

public global::java.lang.Object _flock;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.io.Writer) _r0_o)._flock = (global::java.lang.Object) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.Writer: void <init>()]
}

public void @this(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: void <init>(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    if (_r2_o != null) goto label11;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label11:;
    ((global::java.io.Writer) _r1_o)._flock = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.io.Writer: void <init>(java.lang.Object)]
}

public abstract void close();

public abstract void flush();

public virtual void write(global::org.xmlvm._nArrayAdapter<char> n1){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: void write(char[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    ((global::java.io.Writer) _r2_o).write((global::org.xmlvm._nArrayAdapter<char>) _r3_o, (int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.io.Writer: void write(char[])]
}

public abstract void write(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3);

public virtual void write(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: void write(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r0_o = ((global::java.io.Writer) _r4_o)._flock;
    global::System.Threading.Monitor.Enter(_r0_o);
    _r1.i = 1;
    try {
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    _r2.i = 0;
    _r3.i = _r5.i & 0xffff;
    ((global::org.xmlvm._nArrayAdapter<char>) _r1_o)[_r2.i] = (char)_r3.i;
    ((global::java.io.Writer) _r4_o).write((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label15;
        }
        throw ex;
    } // end catch
    label15:;
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
            goto label15;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.io.Writer: void write(int)]
}

public virtual void write(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: void write(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::java.lang.String) _r3_o).length();
    ((global::java.io.Writer) _r2_o).write((global::java.lang.String) _r3_o, (int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.io.Writer: void write(java.lang.String)]
}

public virtual void write(global::java.lang.String n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: void write(java.lang.String, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r2.i = 0;
    if (_r7.i >= 0) goto label9;
    _r0_o = new global::java.lang.StringIndexOutOfBoundsException();
    ((global::java.lang.StringIndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.StringIndexOutOfBoundsException) _r0_o);
    label9:;
    _r0_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r7.i]);
    _r1.i = _r6.i + _r7.i;
    ((global::java.lang.String) _r5_o).getChars((int) _r6.i, (int) _r1.i, (global::org.xmlvm._nArrayAdapter<char>) _r0_o, (int) _r2.i);
    _r1_o = ((global::java.io.Writer) _r4_o)._flock;
    global::System.Threading.Monitor.Enter(_r1_o);
    _r2.i = 0;
    try {
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    ((global::java.io.Writer) _r4_o).write((global::org.xmlvm._nArrayAdapter<char>) _r0_o, (int) _r2.i, (int) _r3.i);
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label26;
        }
        throw ex;
    } // end catch
    label26:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label26;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[java.io.Writer: void write(java.lang.String, int, int)]
}

public virtual global::System.Object append(char n1){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: java.io.Writer append(char)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.io.Writer) _r0_o).write((int) _r1.i);
    return (global::java.io.Writer) _r0_o;
//XMLVM_END_WRAPPER[java.io.Writer: java.io.Writer append(char)]
}

public virtual global::System.Object append(global::java.lang.CharSequence n1){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: java.io.Writer append(java.lang.CharSequence)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    if (_r2_o != null) goto label8;
    // Value=null
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.io.Writer) _r1_o).write((global::java.lang.String) _r0_o);
    label7:;
    return (global::java.io.Writer) _r1_o;
    label8:;
    _r0_o = ((global::java.lang.CharSequence) _r2_o).toString();
    ((global::java.io.Writer) _r1_o).write((global::java.lang.String) _r0_o);
    goto label7;
//XMLVM_END_WRAPPER[java.io.Writer: java.io.Writer append(java.lang.CharSequence)]
}

public virtual global::System.Object append(global::java.lang.CharSequence n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: java.io.Writer append(java.lang.CharSequence, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    if (_r2_o != null) goto label12;
    // Value=null
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r3.i, (int) _r4.i);
    ((global::java.io.Writer) _r1_o).write((global::java.lang.String) _r0_o);
    label11:;
    return (global::java.io.Writer) _r1_o;
    label12:;
    _r0_o = ((global::java.lang.CharSequence) _r2_o).subSequence((int) _r3.i, (int) _r4.i);
    _r0_o = ((global::java.lang.CharSequence) _r0_o).toString();
    ((global::java.io.Writer) _r1_o).write((global::java.lang.String) _r0_o);
    goto label11;
//XMLVM_END_WRAPPER[java.io.Writer: java.io.Writer append(java.lang.CharSequence, int, int)]
}

public virtual bool checkError(){
//XMLVM_BEGIN_WRAPPER[java.io.Writer: boolean checkError()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.io.Writer: boolean checkError()]
}

//XMLVM_BEGIN_WRAPPER[java.io.Writer]
//XMLVM_END_WRAPPER[java.io.Writer]

} // end of class: Writer

} // end of namespace: java.io
