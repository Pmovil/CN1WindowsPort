// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio.charset {
public class CoderResult: global::java.lang.Object {

static CoderResult() {
    @static();
}





public static global::java.nio.charset.CoderResult _fUNDERFLOW;

public static global::java.nio.charset.CoderResult _fOVERFLOW;

private static global::java.util.WeakHashMap _f_1malformedErrors;

private static global::java.util.WeakHashMap _f_1unmappableErrors;

private int _ftype;

private int _flength;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: void <clinit>()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r0_o = new global::java.nio.charset.CoderResult();
    _r1.i = 1;
    ((global::java.nio.charset.CoderResult) _r0_o).@this((int) _r1.i, (int) _r2.i);
    global::java.nio.charset.CoderResult._fUNDERFLOW = (global::java.nio.charset.CoderResult) _r0_o;
    _r0_o = new global::java.nio.charset.CoderResult();
    _r1.i = 2;
    ((global::java.nio.charset.CoderResult) _r0_o).@this((int) _r1.i, (int) _r2.i);
    global::java.nio.charset.CoderResult._fOVERFLOW = (global::java.nio.charset.CoderResult) _r0_o;
    _r0_o = new global::java.util.WeakHashMap();
    ((global::java.util.WeakHashMap) _r0_o).@this();
    global::java.nio.charset.CoderResult._f_1malformedErrors = (global::java.util.WeakHashMap) _r0_o;
    _r0_o = new global::java.util.WeakHashMap();
    ((global::java.util.WeakHashMap) _r0_o).@this();
    global::java.nio.charset.CoderResult._f_1unmappableErrors = (global::java.util.WeakHashMap) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: void <clinit>()]
}

private void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: void <init>(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.nio.charset.CoderResult) _r0_o)._ftype = _r1.i;
    ((global::java.nio.charset.CoderResult) _r0_o)._flength = _r2.i;
    return;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: void <init>(int, int)]
}

public static global::System.Object malformedForLength(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: java.nio.charset.CoderResult malformedForLength(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5.i = n1;
    _r1_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.nio.charset.CoderResult));
    global::System.Threading.Monitor.Enter(_r1_o);
    if (_r5.i <= 0) goto label42;
    try {
    _r2_o = global::java.lang.Integer.valueOf((int) _r5.i);
    _r3_o = global::java.nio.charset.CoderResult._f_1malformedErrors;
    global::System.Threading.Monitor.Enter(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    try {
    _r0_o = global::java.nio.charset.CoderResult._f_1malformedErrors;
    _r0_o = ((global::java.util.WeakHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    if (_r0_o != null) goto label33;
    _r0_o = new global::java.nio.charset.CoderResult();
    _r4.i = 3;
    ((global::java.nio.charset.CoderResult) _r0_o).@this((int) _r4.i, (int) _r5.i);
    _r4_o = global::java.nio.charset.CoderResult._f_1malformedErrors;
    ((global::java.util.WeakHashMap) _r4_o).put((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    label33:;
    try {
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return (global::java.nio.charset.CoderResult) _r0_o;
    label36:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    try {
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    label39:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
    label42:;
    try {
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=niochar.08
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 56))}));
    _r2_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (int) _r5.i);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: java.nio.charset.CoderResult malformedForLength(int)]
}

public static global::System.Object unmappableForLength(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: java.nio.charset.CoderResult unmappableForLength(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5.i = n1;
    _r1_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.nio.charset.CoderResult));
    global::System.Threading.Monitor.Enter(_r1_o);
    if (_r5.i <= 0) goto label42;
    try {
    _r2_o = global::java.lang.Integer.valueOf((int) _r5.i);
    _r3_o = global::java.nio.charset.CoderResult._f_1unmappableErrors;
    global::System.Threading.Monitor.Enter(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    try {
    _r0_o = global::java.nio.charset.CoderResult._f_1unmappableErrors;
    _r0_o = ((global::java.util.WeakHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    if (_r0_o != null) goto label33;
    _r0_o = new global::java.nio.charset.CoderResult();
    _r4.i = 4;
    ((global::java.nio.charset.CoderResult) _r0_o).@this((int) _r4.i, (int) _r5.i);
    _r4_o = global::java.nio.charset.CoderResult._f_1unmappableErrors;
    ((global::java.util.WeakHashMap) _r4_o).put((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    label33:;
    try {
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return (global::java.nio.charset.CoderResult) _r0_o;
    label36:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    try {
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    label39:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
    label42:;
    try {
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=niochar.08
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 56))}));
    _r2_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (int) _r5.i);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: java.nio.charset.CoderResult unmappableForLength(int)]
}

public virtual bool isUnderflow(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: boolean isUnderflow()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 1;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    if (_r0.i != _r1.i) goto label7;
    _r0.i = _r1.i;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = 0;
    goto label6;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: boolean isUnderflow()]
}

public virtual bool isError(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: boolean isError()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 3;
    if (_r0.i == _r1.i) goto label12;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 4;
    if (_r0.i == _r1.i) goto label12;
    _r0.i = 0;
    label11:;
    return _r0.i!=0;
    label12:;
    _r0.i = 1;
    goto label11;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: boolean isError()]
}

public virtual bool isMalformed(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: boolean isMalformed()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 3;
    if (_r0.i != _r1.i) goto label7;
    _r0.i = 1;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = 0;
    goto label6;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: boolean isMalformed()]
}

public virtual bool isOverflow(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: boolean isOverflow()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 2;
    if (_r0.i != _r1.i) goto label7;
    _r0.i = 1;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = 0;
    goto label6;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: boolean isOverflow()]
}

public virtual bool isUnmappable(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: boolean isUnmappable()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 4;
    if (_r0.i != _r1.i) goto label7;
    _r0.i = 1;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = 0;
    goto label6;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: boolean isUnmappable()]
}

public virtual int length(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: int length()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 3;
    if (_r0.i == _r1.i) goto label10;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    _r1.i = 4;
    if (_r0.i != _r1.i) goto label13;
    label10:;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._flength;
    return _r0.i;
    label13:;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    // Value=niochar.09
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 57))}));
    _r1_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: int length()]
}

public virtual void throwException(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: void throwException()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r2_o)._ftype;
    switch (_r0.i) {
    case 1: goto label11;
    case 2: goto label17;
    case 3: goto label31;
    case 4: goto label23;
    }
    _r0_o = new global::java.nio.charset.CharacterCodingException();
    ((global::java.nio.charset.CharacterCodingException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.charset.CharacterCodingException) _r0_o);
    label11:;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label17:;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label23:;
    _r0_o = new global::java.nio.charset.UnmappableCharacterException();
    _r1.i = ((global::java.nio.charset.CoderResult) _r2_o)._flength;
    ((global::java.nio.charset.UnmappableCharacterException) _r0_o).@this((int) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.charset.UnmappableCharacterException) _r0_o);
    label31:;
    _r0_o = new global::java.nio.charset.MalformedInputException();
    _r1.i = ((global::java.nio.charset.CoderResult) _r2_o)._flength;
    ((global::java.nio.charset.MalformedInputException) _r0_o).@this((int) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.charset.MalformedInputException) _r0_o);
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: void throwException()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = ((global::java.nio.charset.CoderResult) _r3_o)._ftype;
    switch (_r0.i) {
    case 1: goto label29;
    case 2: goto label32;
    case 3: goto label53;
    case 4: goto label35;
    }
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label7:;
    _r1_o = new global::java.lang.StringBuilder();
    // Value=CoderResult[
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 91))}));
    ((global::java.lang.StringBuilder) _r1_o).@this((global::java.lang.String) _r2_o);
    _r0_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r0_o);
    // Value=]
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label29:;
    // Value=UNDERFLOW error
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 87)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    goto label7;
    label32:;
    // Value=OVERFLOW error
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)79)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 87)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    goto label7;
    label35:;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=Unmappable-character error with erroneous input length 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.nio.charset.CoderResult) _r3_o)._flength;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label7;
    label53:;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=Malformed-input error with erroneous input length 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.nio.charset.CoderResult) _r3_o)._flength;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label7;
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[java.nio.charset.CoderResult]
//XMLVM_END_WRAPPER[java.nio.charset.CoderResult]

} // end of class: CoderResult

} // end of namespace: java.nio.charset
