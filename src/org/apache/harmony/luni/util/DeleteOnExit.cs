// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.util {
public class DeleteOnExit: global::java.lang.Object {

static DeleteOnExit() {
    @static();
}

private static global::java.util.Vector _fdeleteList;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void <clinit>()]
    global::System.Object _r0_o = null;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    global::org.apache.harmony.luni.util.DeleteOnExit._fdeleteList = (global::java.util.Vector) _r0_o;
// Red class access removed: org.apache.harmony.kernel.vm.VM deleteOnExit
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.kernel.vm.VM deleteOnExit");
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void <clinit>()]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void <init>()]
}

public static void addFile(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void addFile(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::org.apache.harmony.luni.util.DeleteOnExit._fdeleteList;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void addFile(java.lang.String)]
}

public static void deleteOnExit(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void deleteOnExit()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r0_o = global::org.apache.harmony.luni.util.DeleteOnExit._fdeleteList;
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    _r1.i = _r0.i;
    label9:;
    if (_r1.i >= 0) goto label12;
    return;
    label12:;
    _r0_o = global::org.apache.harmony.luni.util.DeleteOnExit._fdeleteList;
    _r0_o = ((global::java.util.Vector) _r0_o).elementAt((int) _r1.i);
    _r2_o = new global::java.io.File();
    ((global::java.io.File) _r2_o).@this((global::java.lang.String) _r0_o);
    ((global::java.io.File) _r2_o).delete();
    _r0.i = _r1.i + -1;
    _r1.i = _r0.i;
    goto label9;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit: void deleteOnExit()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.DeleteOnExit]

} // end of class: DeleteOnExit

} // end of namespace: org.apache.harmony.luni.util
