// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class InvalidPropertiesFormatException: global::java.io.IOException {

new public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.util.InvalidPropertiesFormatException: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.InvalidPropertiesFormatException: void <init>(java.lang.String)]
}

new public void @this(global::java.lang.Throwable n1){
//XMLVM_BEGIN_WRAPPER[java.util.InvalidPropertiesFormatException: void <init>(java.lang.Throwable)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.io.IOException) _r0_o).@this();
    ((global::java.util.InvalidPropertiesFormatException) _r0_o).initCause((global::java.lang.Throwable) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.InvalidPropertiesFormatException: void <init>(java.lang.Throwable)]
}

private void writeObject(global::java.io.ObjectOutputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.InvalidPropertiesFormatException: void writeObject(java.io.ObjectOutputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.io.NotSerializableException();
    ((global::java.io.NotSerializableException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.NotSerializableException) _r0_o);
//XMLVM_END_WRAPPER[java.util.InvalidPropertiesFormatException: void writeObject(java.io.ObjectOutputStream)]
}

private void readObject(global::java.io.ObjectInputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.InvalidPropertiesFormatException: void readObject(java.io.ObjectInputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.io.NotSerializableException();
    ((global::java.io.NotSerializableException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.NotSerializableException) _r0_o);
//XMLVM_END_WRAPPER[java.util.InvalidPropertiesFormatException: void readObject(java.io.ObjectInputStream)]
}

//XMLVM_BEGIN_WRAPPER[java.util.InvalidPropertiesFormatException]
//XMLVM_END_WRAPPER[java.util.InvalidPropertiesFormatException]

} // end of class: InvalidPropertiesFormatException

} // end of namespace: java.util
