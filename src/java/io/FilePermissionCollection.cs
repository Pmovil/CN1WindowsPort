// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class FilePermissionCollection: global::java.security.PermissionCollection,global::java.io.Serializable {
private static long _fserialVersionUID = 2202956749081564585L;

public global::java.util.Vector _fpermissions;

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.io.FilePermissionCollection: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.security.PermissionCollection) _r1_o).@this();
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::java.io.FilePermissionCollection) _r1_o)._fpermissions = (global::java.util.Vector) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.FilePermissionCollection: void <init>()]
}

public override void add(global::java.security.Permission n1){
//XMLVM_BEGIN_WRAPPER[java.io.FilePermissionCollection: void add(java.security.Permission)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.io.FilePermissionCollection) _r2_o).isReadOnly() ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label12:;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.io.FilePermission)) ? 1 : 0;
    if (_r0.i == 0) goto label22;
    _r0_o = ((global::java.io.FilePermissionCollection) _r2_o)._fpermissions;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r3_o);
    return;
    label22:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    _r1_o = ((global::java.security.Permission) _r3_o).toString();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
//XMLVM_END_WRAPPER[java.io.FilePermissionCollection: void add(java.security.Permission)]
}

public override global::System.Object elements(){
//XMLVM_BEGIN_WRAPPER[java.io.FilePermissionCollection: java.util.Enumeration elements()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.FilePermissionCollection) _r1_o)._fpermissions;
    _r0_o = ((global::java.util.Vector) _r0_o).elements();
    return (global::java.util.Enumeration) _r0_o;
//XMLVM_END_WRAPPER[java.io.FilePermissionCollection: java.util.Enumeration elements()]
}

public override bool implies(global::java.security.Permission n1){
//XMLVM_BEGIN_WRAPPER[java.io.FilePermissionCollection: boolean implies(java.security.Permission)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r6.i = 0;
    _r1.i = ((_r8_o != null) && (_r8_o is global::java.io.FilePermission)) ? 1 : 0;
    if (_r1.i == 0) goto label54;
    _r0_o = _r8_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r3.i = _r6.i;
    _r4.i = _r6.i;
    label11:;
    _r2_o = ((global::java.io.FilePermissionCollection) _r7_o)._fpermissions;
    _r2.i = ((global::java.util.Vector) _r2_o).size();
    if (_r3.i >= _r2.i) goto label26;
    _r2.i = ((global::java.io.FilePermission) _r1_o)._fmask;
    _r2.i = _r2.i & _r4.i;
    _r5.i = ((global::java.io.FilePermission) _r1_o)._fmask;
    if (_r2.i != _r5.i) goto label35;
    label26:;
    _r2.i = ((global::java.io.FilePermission) _r1_o)._fmask;
    _r2.i = _r2.i & _r4.i;
    _r1.i = ((global::java.io.FilePermission) _r1_o)._fmask;
    if (_r2.i != _r1.i) goto label52;
    _r1.i = 1;
    label34:;
    return _r1.i!=0;
    label35:;
    _r2_o = ((global::java.io.FilePermissionCollection) _r7_o)._fpermissions;
    _r2_o = ((global::java.util.Vector) _r2_o).elementAt((int) _r3.i);
    _r2_o = _r2_o;
    _r2.i = ((global::java.io.FilePermission) _r2_o).impliesMask((global::java.security.Permission) _r8_o);
    _r2.i = _r2.i | _r4.i;
    _r3.i = _r3.i + 1;
    _r4.i = _r2.i;
    goto label11;
    label52:;
    _r1.i = _r6.i;
    goto label34;
    label54:;
    _r1.i = _r6.i;
    goto label34;
//XMLVM_END_WRAPPER[java.io.FilePermissionCollection: boolean implies(java.security.Permission)]
}

//XMLVM_BEGIN_WRAPPER[java.io.FilePermissionCollection]
//XMLVM_END_WRAPPER[java.io.FilePermissionCollection]

} // end of class: FilePermissionCollection

} // end of namespace: java.io
