// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class ObjectStreamField: global::java.lang.Object,global::java.lang.Comparable {
public static int _fFIELD_1IS_1NOT_1RESOLVED = -1;

public static int _fFIELD_1IS_1ABSENT = -2;

private global::java.lang.String _fname;

private global::java.lang.Object _ftype;

public int _foffset;

private global::java.lang.String _ftypeString;

private bool _funshared;

private bool _fisDeserialized;

private long _fassocFieldID;

public virtual long getFieldID(global::org.xmlvm.runtime.RedTypeMarker n1, global::java.lang.Class n2){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: long getFieldID(org.apache.harmony.misc.accessors.ObjectAccessor, java.lang.Class)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r0.l = ((global::java.io.ObjectStreamField) _r4_o)._fassocFieldID;
    _r2.l = -1L;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i == 0) goto label11;
    _r0.l = ((global::java.io.ObjectStreamField) _r4_o)._fassocFieldID;
    label10:;
    return _r0.l;
    label11:;
    try {
    _r0_o = ((global::java.io.ObjectStreamField) _r4_o)._fname;
// Red class access removed: org.apache.harmony.misc.accessors.ObjectAccessor getFieldID
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.misc.accessors.ObjectAccessor getFieldID");
    ((global::java.io.ObjectStreamField) _r4_o)._fassocFieldID = _r0.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NoSuchFieldError) {
            _ex = ex;
            goto label22;
        }
        throw ex;
    } // end catch
    label19:;
    _r0.l = ((global::java.io.ObjectStreamField) _r4_o)._fassocFieldID;
    goto label10;
    label22:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0.l = -2L;
    ((global::java.io.ObjectStreamField) _r4_o)._fassocFieldID = _r0.l;
    goto label19;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: long getFieldID(org.apache.harmony.misc.accessors.ObjectAccessor, java.lang.Class)]
}

public void @this(global::java.lang.String n1, global::java.lang.Class n2){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void <init>(java.lang.String, java.lang.Class)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.l = -1L;
    ((global::java.io.ObjectStreamField) _r2_o)._fassocFieldID = _r0.l;
    if (_r3_o == null) goto label11;
    if (_r4_o != null) goto label17;
    label11:;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label17:;
    ((global::java.io.ObjectStreamField) _r2_o)._fname = (global::java.lang.String) _r3_o;
    _r0_o = new global::java.lang.@ref.WeakReference();
    ((global::java.lang.@ref.WeakReference) _r0_o).@this((global::java.lang.Object) _r4_o);
    ((global::java.io.ObjectStreamField) _r2_o)._ftype = (global::java.lang.Object) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void <init>(java.lang.String, java.lang.Class)]
}

public void @this(global::java.lang.String n1, global::java.lang.Class n2, bool n3){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void <init>(java.lang.String, java.lang.Class, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5.i = n3 ? 1 : 0;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.l = -1L;
    ((global::java.io.ObjectStreamField) _r2_o)._fassocFieldID = _r0.l;
    if (_r3_o == null) goto label11;
    if (_r4_o != null) goto label17;
    label11:;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label17:;
    ((global::java.io.ObjectStreamField) _r2_o)._fname = (global::java.lang.String) _r3_o;
    _r0_o = ((global::java.lang.Class) _r4_o).getClassLoader();
    if (_r0_o != null) goto label31;
    _r0_o = _r4_o;
    label26:;
    ((global::java.io.ObjectStreamField) _r2_o)._ftype = (global::java.lang.Object) _r0_o;
    ((global::java.io.ObjectStreamField) _r2_o)._funshared = 0!=_r5.i;
    return;
    label31:;
    _r0_o = new global::java.lang.@ref.WeakReference();
    ((global::java.lang.@ref.WeakReference) _r0_o).@this((global::java.lang.Object) _r4_o);
    goto label26;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void <init>(java.lang.String, java.lang.Class, boolean)]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void <init>(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.l = -1L;
    ((global::java.io.ObjectStreamField) _r2_o)._fassocFieldID = _r0.l;
    if (_r4_o != null) goto label15;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label15:;
    ((global::java.io.ObjectStreamField) _r2_o)._fname = (global::java.lang.String) _r4_o;
    _r0.i = 46;
    _r1.i = 47;
    _r0_o = ((global::java.lang.String) _r3_o).replace((char) _r0.i, (char) _r1.i);
    _r0_o = ((global::java.lang.String) _r0_o).intern();
    ((global::java.io.ObjectStreamField) _r2_o)._ftypeString = (global::java.lang.String) _r0_o;
    ((global::java.io.ObjectStreamField) _r2_o).defaultResolve();
    _r0.i = 1;
    ((global::java.io.ObjectStreamField) _r2_o)._fisDeserialized = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void <init>(java.lang.String, java.lang.String)]
}

public virtual int compareTo(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: int compareTo(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.io.ObjectStreamField) _r2_o).isPrimitive() ? 1 : 0;
    _r1.i = ((global::java.io.ObjectStreamField) _r3_o).isPrimitive() ? 1 : 0;
    if (_r0.i == _r1.i) goto label18;
    if (_r0.i == 0) goto label16;
    _r0.i = -1;
    label15:;
    return _r0.i;
    label16:;
    _r0.i = 1;
    goto label15;
    label18:;
    _r0_o = ((global::java.io.ObjectStreamField) _r2_o).getName();
    _r1_o = ((global::java.io.ObjectStreamField) _r3_o).getName();
    _r0.i = ((global::java.lang.String) _r0_o).compareTo((global::java.lang.String) _r1_o);
    goto label15;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: int compareTo(java.lang.Object)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((_r2_o != null) && (_r2_o is global::java.io.ObjectStreamField)) ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0.i = ((global::java.io.ObjectStreamField) _r1_o).compareTo((global::java.lang.Object) _r2_o);
    if (_r0.i != 0) goto label12;
    _r0.i = 1;
    label11:;
    return _r0.i!=0;
    label12:;
    _r0.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.ObjectStreamField) _r1_o).getName();
    _r0.i = ((global::java.lang.String) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: int hashCode()]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.ObjectStreamField) _r1_o)._fname;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: java.lang.String getName()]
}

public virtual int getOffset(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: int getOffset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.io.ObjectStreamField) _r1_o)._foffset;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: int getOffset()]
}

private global::System.Object getTypeInternal(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: java.lang.Class getTypeInternal()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.ObjectStreamField) _r1_o)._ftype;
    _r0.i = ((_r0_o != null) && (_r0_o is global::java.lang.@ref.WeakReference)) ? 1 : 0;
    if (_r0.i == 0) goto label18;
    _r1_o = ((global::java.io.ObjectStreamField) _r1_o)._ftype;
    _r1_o = ((global::java.lang.@ref.WeakReference) _r1_o).get();
    _r0_o = _r1_o;
    label17:;
    return (global::java.lang.Class) _r0_o;
    label18:;
    _r1_o = ((global::java.io.ObjectStreamField) _r1_o)._ftype;
    _r0_o = _r1_o;
    goto label17;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: java.lang.Class getTypeInternal()]
}

public virtual global::System.Object getType(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: java.lang.Class getType()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.io.ObjectStreamField) _r2_o).getTypeInternal();
    _r1.i = ((global::java.io.ObjectStreamField) _r2_o)._fisDeserialized ? 1 : 0;
    if (_r1.i == 0) goto label16;
    _r1.i = ((global::java.lang.Class) _r0_o).isPrimitive() ? 1 : 0;
    if (_r1.i != 0) goto label16;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Object));
    label16:;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: java.lang.Class getType()]
}

public virtual char getTypeCode(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: char getTypeCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.io.ObjectStreamField) _r2_o).getTypeInternal();
    _r1_o = global::java.lang.Integer._fTYPE;
    if (_r0_o != _r1_o) goto label11;
    _r0.i = 73;
    label10:;
    return (char) _r0.i;
    label11:;
    _r1_o = global::java.lang.Byte._fTYPE;
    if (_r0_o != _r1_o) goto label18;
    _r0.i = 66;
    goto label10;
    label18:;
    _r1_o = global::java.lang.Character._fTYPE;
    if (_r0_o != _r1_o) goto label25;
    _r0.i = 67;
    goto label10;
    label25:;
    _r1_o = global::java.lang.Short._fTYPE;
    if (_r0_o != _r1_o) goto label32;
    _r0.i = 83;
    goto label10;
    label32:;
    _r1_o = global::java.lang.Boolean._fTYPE;
    if (_r0_o != _r1_o) goto label39;
    _r0.i = 90;
    goto label10;
    label39:;
    _r1_o = global::java.lang.Long._fTYPE;
    if (_r0_o != _r1_o) goto label46;
    _r0.i = 74;
    goto label10;
    label46:;
    _r1_o = global::java.lang.Float._fTYPE;
    if (_r0_o != _r1_o) goto label53;
    _r0.i = 70;
    goto label10;
    label53:;
    _r1_o = global::java.lang.Double._fTYPE;
    if (_r0_o != _r1_o) goto label60;
    _r0.i = 68;
    goto label10;
    label60:;
    _r0.i = ((global::java.lang.Class) _r0_o).isArray() ? 1 : 0;
    if (_r0.i == 0) goto label69;
    _r0.i = 91;
    goto label10;
    label69:;
    _r0.i = 76;
    goto label10;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: char getTypeCode()]
}

public virtual global::System.Object getTypeString(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: java.lang.String getTypeString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.i = ((global::java.io.ObjectStreamField) _r4_o).isPrimitive() ? 1 : 0;
    if (_r0.i == 0) goto label8;
    _r0_o = null;
    label7:;
    return (global::java.lang.String) _r0_o;
    label8:;
    _r0_o = ((global::java.io.ObjectStreamField) _r4_o)._ftypeString;
    if (_r0_o != null) goto label41;
    _r0_o = ((global::java.io.ObjectStreamField) _r4_o).getTypeInternal();
    _r1_o = ((global::java.lang.Class) _r0_o).getName();
    _r2.i = 46;
    _r3.i = 47;
    _r1_o = ((global::java.lang.String) _r1_o).replace((char) _r2.i, (char) _r3.i);
    _r0.i = ((global::java.lang.Class) _r0_o).isArray() ? 1 : 0;
    if (_r0.i == 0) goto label44;
    _r0_o = _r1_o;
    label35:;
    _r0_o = ((global::java.lang.String) _r0_o).intern();
    ((global::java.io.ObjectStreamField) _r4_o)._ftypeString = (global::java.lang.String) _r0_o;
    label41:;
    _r0_o = ((global::java.io.ObjectStreamField) _r4_o)._ftypeString;
    goto label7;
    label44:;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=L
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)76))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r2_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = 59;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label35;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: java.lang.String getTypeString()]
}

public virtual bool isPrimitive(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: boolean isPrimitive()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.ObjectStreamField) _r1_o).getTypeInternal();
    if (_r0_o == null) goto label14;
    _r0.i = ((global::java.lang.Class) _r0_o).isPrimitive() ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: boolean isPrimitive()]
}

public virtual void setOffset(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void setOffset(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.io.ObjectStreamField) _r0_o)._foffset = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void setOffset(int)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    _r1_o = ((global::java.lang.Object) _r2_o).getClass();
    _r1_o = ((global::java.lang.Class) _r1_o).getName();
    _r1_o = global::java.lang.String.valueOf((global::java.lang.Object) _r1_o);
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.i = 40;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.io.ObjectStreamField) _r2_o).getName();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = 58;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.io.ObjectStreamField) _r2_o).getTypeInternal();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    _r1.i = 41;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: java.lang.String toString()]
}

public static void sortFields(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void sortFields(java.io.ObjectStreamField[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r1.i = 1;
    if (_r0.i <= _r1.i) goto label12;
    _r0_o = new global::java.io.ObjectStreamField_21();
    ((global::java.io.ObjectStreamField_21) _r0_o).@this();
    global::java.util.Arrays.sort((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::java.util.Comparator) _r0_o);
    label12:;
    return;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void sortFields(java.io.ObjectStreamField[])]
}

public virtual void resolve(global::java.lang.ClassLoader n1){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void resolve(java.lang.ClassLoader)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r4.i = 0;
    _r3.i = 1;
    _r0_o = ((global::java.io.ObjectStreamField) _r5_o)._ftypeString;
    if (_r0_o != null) goto label22;
    _r0.i = ((global::java.io.ObjectStreamField) _r5_o).isPrimitive() ? 1 : 0;
    if (_r0.i == 0) goto label22;
    _r0.i = ((global::java.io.ObjectStreamField) _r5_o).getTypeCode();
    _r0_o = global::java.lang.String.valueOf((char) _r0.i);
    ((global::java.io.ObjectStreamField) _r5_o)._ftypeString = (global::java.lang.String) _r0_o;
    label22:;
    _r0_o = ((global::java.io.ObjectStreamField) _r5_o)._ftypeString;
    _r0.i = ((global::java.lang.String) _r0_o).length();
    if (_r0.i != _r3.i) goto label37;
    _r0.i = ((global::java.io.ObjectStreamField) _r5_o).defaultResolve() ? 1 : 0;
    if (_r0.i == 0) goto label37;
    label36:;
    return;
    label37:;
    _r0_o = ((global::java.io.ObjectStreamField) _r5_o)._ftypeString;
    _r1.i = 47;
    _r2.i = 46;
    _r0_o = ((global::java.lang.String) _r0_o).replace((char) _r1.i, (char) _r2.i);
    _r1.i = ((global::java.lang.String) _r0_o).charAt((int) _r4.i);
    _r2.i = 76;
    if (_r1.i != _r2.i) goto label64;
    _r1.i = ((global::java.lang.String) _r0_o).length();
    _r1.i = _r1.i - _r3.i;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r3.i, (int) _r1.i);
    label64:;
    _r1.i = 0;
    try {
    _r0_o = global::java.lang.Class.forName((global::java.lang.String) _r0_o, 0!=_r1.i, (global::java.lang.ClassLoader) _r6_o);
    _r1_o = ((global::java.lang.Class) _r0_o).getClassLoader();
    if (_r1_o != null) goto label80;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label78;
        }
        throw ex;
    } // end catch
    label75:;
    try {
    ((global::java.io.ObjectStreamField) _r5_o)._ftype = (global::java.lang.Object) _r0_o;
    goto label36;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label78;
        }
        throw ex;
    } // end catch
    label78:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label36;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label78;
        }
        throw ex;
    } // end catch
    label80:;
    try {
    _r1_o = new global::java.lang.@ref.WeakReference();
    ((global::java.lang.@ref.WeakReference) _r1_o).@this((global::java.lang.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label78;
        }
        throw ex;
    } // end catch
    _r0_o = _r1_o;
    goto label75;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void resolve(java.lang.ClassLoader)]
}

public virtual bool isUnshared(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: boolean isUnshared()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.io.ObjectStreamField) _r1_o)._funshared ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: boolean isUnshared()]
}

public virtual void setUnshared(bool n1){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: void setUnshared(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::java.io.ObjectStreamField) _r0_o)._funshared = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: void setUnshared(boolean)]
}

private bool defaultResolve(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField: boolean defaultResolve()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.i = 0;
    _r1.i = 1;
    _r0_o = ((global::java.io.ObjectStreamField) _r3_o)._ftypeString;
    _r0.i = ((global::java.lang.String) _r0_o).charAt((int) _r2.i);
    switch (_r0.i) {
    case 66: goto label23;
    case 67: goto label29;
    case 68: goto label59;
    case 70: goto label53;
    case 73: goto label17;
    case 74: goto label47;
    case 83: goto label35;
    case 90: goto label41;
    }
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Object));
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r2.i;
    label16:;
    return _r0.i!=0;
    label17:;
    _r0_o = global::java.lang.Integer._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label23:;
    _r0_o = global::java.lang.Byte._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label29:;
    _r0_o = global::java.lang.Character._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label35:;
    _r0_o = global::java.lang.Short._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label41:;
    _r0_o = global::java.lang.Boolean._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label47:;
    _r0_o = global::java.lang.Long._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label53:;
    _r0_o = global::java.lang.Float._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
    label59:;
    _r0_o = global::java.lang.Double._fTYPE;
    ((global::java.io.ObjectStreamField) _r3_o)._ftype = (global::java.lang.Object) _r0_o;
    _r0.i = _r1.i;
    goto label16;
//XMLVM_END_WRAPPER[java.io.ObjectStreamField: boolean defaultResolve()]
}

//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamField]
//XMLVM_END_WRAPPER[java.io.ObjectStreamField]

} // end of class: ObjectStreamField

} // end of namespace: java.io
