// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.lang.reflect {
public class ListOfTypes: global::java.lang.Object {

static ListOfTypes() {
    @static();
}

public static global::org.apache.harmony.luni.lang.reflect.ListOfTypes _fEMPTY;

private global::java.util.ArrayList _ftypes;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _fresolvedTypes;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void <init>(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this((int) _r2.i);
    ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r1_o)._ftypes = (global::java.util.ArrayList) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void <init>(int)]
}

public void @this(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void <init>(java.lang.reflect.Type[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    ((global::java.lang.Object) _r6_o).@this();
    _r4_o = new global::java.util.ArrayList();
    _r5.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    ((global::java.util.ArrayList) _r4_o).@this((int) _r5.i);
    ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r6_o)._ftypes = (global::java.util.ArrayList) _r4_o;
    _r0_o = _r7_o;
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = 0;
    label14:;
    if (_r1.i >= _r2.i) goto label26;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    _r4_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r6_o)._ftypes;
    ((global::java.util.ArrayList) _r4_o).add((global::java.lang.Object) _r3_o);
    _r1.i = _r1.i + 1;
    goto label14;
    label26:;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void <init>(java.lang.reflect.Type[])]
}

public virtual void add(global::java.lang.reflect.Type n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void add(java.lang.reflect.Type)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != null) goto label10;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=type == null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label10:;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r2_o)._ftypes;
    ((global::java.util.ArrayList) _r0_o).add((global::java.lang.Object) _r3_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void add(java.lang.reflect.Type)]
}

public virtual int length(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: int length()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r1_o)._ftypes;
    _r0.i = ((global::java.util.ArrayList) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: int length()]
}

public virtual global::System.Object getResolvedTypes(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: java.lang.reflect.Type[] getResolvedTypes()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r2_o)._fresolvedTypes;
    if (_r0_o == null) goto label6;
    _r1_o = _r0_o;
    label5:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    label6:;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r2_o)._ftypes;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r2_o).resolveTypes((global::java.util.List) _r1_o);
    ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r2_o)._fresolvedTypes = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    goto label5;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: java.lang.reflect.Type[] getResolvedTypes()]
}

private global::System.Object resolveTypes(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: java.lang.reflect.Type[] resolveTypes(java.util.List)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = ((global::java.util.List) _r7_o).size();
    _r3_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r5.i]);
    _r2.i = 0;
    label7:;
    _r5.i = ((global::java.util.List) _r7_o).size();
    if (_r2.i >= _r5.i) goto label37;
    _r4_o = ((global::java.util.List) _r7_o).get((int) _r2.i);
    _r4_o = _r4_o;
    try {
    _r0_o = _r4_o;
    _r0_o = _r0_o;
    _r5_o = _r0_o;
    _r5_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r5_o).getResolvedType();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r2.i] = _r5_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label32;
        }
        throw ex;
    } // end catch
    label29:;
    _r2.i = _r2.i + 1;
    goto label7;
    label32:;
    _r5_o = _ex.getJavaException();
    _ex = null;
    _r1_o = _r5_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r2.i] = _r4_o;
    goto label29;
    label37:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: java.lang.reflect.Type[] resolveTypes(java.util.List)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    _r0.i = 0;
    label6:;
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r3_o)._ftypes;
    _r2.i = ((global::java.util.ArrayList) _r2_o).size();
    if (_r0.i >= _r2.i) goto label33;
    if (_r0.i <= 0) goto label21;
    // Value=, 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    label21:;
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r3_o)._ftypes;
    _r2_o = ((global::java.util.ArrayList) _r2_o).get((int) _r0.i);
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.Object) _r2_o);
    _r0.i = _r0.i + 1;
    goto label6;
    label33:;
    _r2_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    return (global::java.lang.String) _r2_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: java.lang.String toString()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void <clinit>()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = new global::org.apache.harmony.luni.lang.reflect.ListOfTypes();
    _r1.i = 0;
    ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r0_o).@this((int) _r1.i);
    global::org.apache.harmony.luni.lang.reflect.ListOfTypes._fEMPTY = (global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfTypes]

} // end of class: ListOfTypes

} // end of namespace: org.apache.harmony.luni.lang.reflect
