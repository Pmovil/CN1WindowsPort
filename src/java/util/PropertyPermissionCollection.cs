// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class PropertyPermissionCollection: global::java.security.PermissionCollection {

static PropertyPermissionCollection() {
    @static();
}


public global::java.util.Hashtable _fpermissions;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _fserialPersistentFields;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r0.i = 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = new global::java.io.ObjectStreamField();
    // Value=permissions
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115))}));
    _r4_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.util.Hashtable));
    ((global::java.io.ObjectStreamField) _r2_o).@this((global::java.lang.String) _r3_o, (global::java.lang.Class) _r4_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 1;
    _r2_o = new global::java.io.ObjectStreamField();
    // Value=all_allowed
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r4_o = global::java.lang.Boolean._fTYPE;
    ((global::java.io.ObjectStreamField) _r2_o).@this((global::java.lang.String) _r3_o, (global::java.lang.Class) _r4_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    global::java.util.PropertyPermissionCollection._fserialPersistentFields = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: void <clinit>()]
}

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: void <init>()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    ((global::java.security.PermissionCollection) _r2_o).@this();
    _r0_o = new global::java.util.Hashtable();
    _r1.i = 30;
    ((global::java.util.Hashtable) _r0_o).@this((int) _r1.i);
    ((global::java.util.PropertyPermissionCollection) _r2_o)._fpermissions = (global::java.util.Hashtable) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: void <init>()]
}

public override void add(global::java.security.Permission n1){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: void add(java.security.Permission)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = ((global::java.util.PropertyPermissionCollection) _r3_o).isReadOnly() ? 1 : 0;
    if (_r0.i != 0) goto label55;
    _r0_o = ((global::java.util.PropertyPermissionCollection) _r3_o)._fpermissions;
    _r1_o = ((global::java.security.Permission) _r4_o).getName();
    _r0_o = ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r4_o);
    if (_r0_o == null) goto label54;
    _r0_o = ((global::java.security.Permission) _r0_o).getActions();
    _r1_o = ((global::java.security.Permission) _r4_o).getActions();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label54;
    _r0_o = new global::java.util.PropertyPermission();
    _r1_o = ((global::java.security.Permission) _r4_o).getName();
    // Value=read,write
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.util.PropertyPermission) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    _r1_o = ((global::java.util.PropertyPermissionCollection) _r3_o)._fpermissions;
    _r2_o = ((global::java.security.Permission) _r4_o).getName();
    ((global::java.util.Hashtable) _r1_o).put((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r0_o);
    label54:;
    return;
    label55:;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: void add(java.security.Permission)]
}

public override global::System.Object elements(){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: java.util.Enumeration elements()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.PropertyPermissionCollection) _r1_o)._fpermissions;
    _r0_o = ((global::java.util.Hashtable) _r0_o).elements();
    return (global::java.util.Enumeration) _r0_o;
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: java.util.Enumeration elements()]
}

public override bool implies(global::java.security.Permission n1){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: boolean implies(java.security.Permission)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    _r1_o = ((global::java.util.PropertyPermissionCollection) _r4_o).elements();
    label5:;
    _r0.i = ((global::java.util.Enumeration) _r1_o).hasMoreElements() ? 1 : 0;
    if (_r0.i != 0) goto label59;
    _r0_o = ((global::java.security.Permission) _r5_o).getActions();
    // Value=read,write
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label73;
    _r0_o = new global::java.util.PropertyPermission();
    _r1_o = ((global::java.security.Permission) _r5_o).getName();
    // Value=read
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.util.PropertyPermission) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    _r0.i = ((global::java.util.PropertyPermissionCollection) _r4_o).implies((global::java.security.Permission) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label73;
    _r0_o = new global::java.util.PropertyPermission();
    _r1_o = ((global::java.security.Permission) _r5_o).getName();
    // Value=write
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.util.PropertyPermission) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    _r0.i = ((global::java.util.PropertyPermissionCollection) _r4_o).implies((global::java.security.Permission) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label73;
    _r0.i = _r3.i;
    label58:;
    return _r0.i!=0;
    label59:;
    _r0_o = ((global::java.util.Enumeration) _r1_o).nextElement();
    _r0.i = ((global::java.security.Permission) _r0_o).implies((global::java.security.Permission) _r5_o) ? 1 : 0;
    if (_r0.i == 0) goto label5;
    _r0.i = _r3.i;
    goto label58;
    label73:;
    _r0.i = 0;
    goto label58;
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: boolean implies(java.security.Permission)]
}

private void writeObject(global::java.io.ObjectOutputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: void writeObject(java.io.ObjectOutputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::java.io.ObjectOutputStream) _r4_o).putFields();
    // Value=permissions
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115))}));
    _r2_o = ((global::java.util.PropertyPermissionCollection) _r3_o)._fpermissions;
    ((global::java.io.ObjectOutputStream_2PutField) _r0_o).put((global::java.lang.String) _r1_o, (global::java.lang.Object) _r2_o);
    // Value=all_allowed
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r2.i = 0;
    ((global::java.io.ObjectOutputStream_2PutField) _r0_o).put((global::java.lang.String) _r1_o, 0!=_r2.i);
    ((global::java.io.ObjectOutputStream) _r4_o).writeFields();
    return;
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: void writeObject(java.io.ObjectOutputStream)]
}

private void readObject(global::java.io.ObjectInputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection: void readObject(java.io.ObjectInputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::java.io.ObjectInputStream) _r4_o).readFields();
    // Value=permissions
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115))}));
    _r2_o = null;
    _r0_o = ((global::java.io.ObjectInputStream_2GetField) _r0_o).get((global::java.lang.String) _r1_o, (global::java.lang.Object) _r2_o);
    ((global::java.util.PropertyPermissionCollection) _r3_o)._fpermissions = (global::java.util.Hashtable) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection: void readObject(java.io.ObjectInputStream)]
}

//XMLVM_BEGIN_WRAPPER[java.util.PropertyPermissionCollection]
//XMLVM_END_WRAPPER[java.util.PropertyPermissionCollection]

} // end of class: PropertyPermissionCollection

} // end of namespace: java.util
