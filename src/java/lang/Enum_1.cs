// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Enum_21: global::java.lang.Object,global::java.security.PrivilegedExceptionAction {
private global::java.lang.Class _fval_2enumType;

public void @this(global::java.lang.Class n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Enum$1: void <init>(java.lang.Class)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Enum_21) _r0_o)._fval_2enumType = (global::java.lang.Class) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.Enum$1: void <init>(java.lang.Class)]
}

public virtual global::System.Object run(){
//XMLVM_BEGIN_WRAPPER[java.lang.Enum$1: java.lang.reflect.Method run()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::java.lang.Enum_21) _r3_o)._fval_2enumType;
    // Value=values
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r2_o = null;
    _r0_o = ((global::java.lang.Class) _r0_o).getMethod((global::java.lang.String) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    _r1.i = 1;
    ((global::java.lang.reflect.Method) _r0_o).setAccessible(0!=_r1.i);
    return (global::java.lang.reflect.Method) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Enum$1: java.lang.reflect.Method run()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Enum$1]
//XMLVM_END_WRAPPER[java.lang.Enum$1]

} // end of class: Enum_21

} // end of namespace: java.lang
