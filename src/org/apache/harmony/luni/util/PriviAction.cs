// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.util {
public class PriviAction: global::java.lang.Object,global::java.security.PrivilegedAction {
private global::java.lang.Object _farg1;

private global::java.lang.Object _farg2;

private int _faction;

private static int _fGET_1SYSTEM_1PROPERTY = 1;

private static int _fGET_1SECURITY_1POLICY = 2;

private static int _fSET_1ACCESSIBLE = 3;

private static int _fGET_1SECURITY_1PROPERTY = 4;

public static global::System.Object getSecurityProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: java.security.PrivilegedAction getSecurityProperty(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0_o = new global::org.apache.harmony.luni.util.PriviAction();
    _r1.i = 4;
    ((global::org.apache.harmony.luni.util.PriviAction) _r0_o).@this((int) _r1.i, (global::java.lang.Object) _r2_o);
    return (global::java.security.PrivilegedAction) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: java.security.PrivilegedAction getSecurityProperty(java.lang.String)]
}

private void @this(int n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(int, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1.i = n1;
    _r2_o = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::org.apache.harmony.luni.util.PriviAction) _r0_o)._faction = _r1.i;
    ((global::org.apache.harmony.luni.util.PriviAction) _r0_o)._farg1 = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(int, java.lang.Object)]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 2;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._faction = _r0.i;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>()]
}

public void @this(global::java.lang.reflect.AccessibleObject n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(java.lang.reflect.AccessibleObject)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 3;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._faction = _r0.i;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg1 = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(java.lang.reflect.AccessibleObject)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 1;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._faction = _r0.i;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg1 = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 1;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._faction = _r0.i;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg1 = (global::java.lang.Object) _r2_o;
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg2 = (global::java.lang.Object) _r3_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: void <init>(java.lang.String, java.lang.String)]
}

public virtual global::System.Object run(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction: java.lang.Object run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._faction;
    switch (_r0.i) {
    case 1: goto label7;
    case 2: goto label29;
    case 3: goto label34;
    case 4: goto label20;
    }
    label5:;
    _r0_o = null;
    label6:;
    return (global::java.lang.Object) _r0_o;
    label7:;
    _r0_o = ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg1;
    _r0_o = _r0_o;
    _r1_o = ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg2;
    _r1_o = _r1_o;
    _r0_o = global::java.lang.System.getProperty((global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o);
    goto label6;
    label20:;
    _r1_o = ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg1;
    _r1_o = _r1_o;
// Red class access removed: java.security.Security getProperty
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.security.Security getProperty");
    goto label6;
    label29:;
// Red class access removed: java.security.Policy getPolicy
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.security.Policy getPolicy");
    goto label6;
    label34:;
    _r1_o = ((global::org.apache.harmony.luni.util.PriviAction) _r1_o)._farg1;
    _r1_o = _r1_o;
    _r0.i = 1;
    ((global::java.lang.reflect.AccessibleObject) _r1_o).setAccessible(0!=_r0.i);
    goto label5;
    label44:;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction: java.lang.Object run()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.PriviAction]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.PriviAction]

} // end of class: PriviAction

} // end of namespace: org.apache.harmony.luni.util
