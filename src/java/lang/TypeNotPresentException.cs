// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class TypeNotPresentException: global::java.lang.RuntimeException {

private global::java.lang.String _ftypeName;

new public void @this(global::java.lang.String n1, global::java.lang.Throwable n2){
//XMLVM_BEGIN_WRAPPER[java.lang.TypeNotPresentException: void <init>(java.lang.String, java.lang.Throwable)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=Type 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    // Value= not present
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.lang.RuntimeException) _r2_o).@this((global::java.lang.String) _r0_o, (global::java.lang.Throwable) _r4_o);
    ((global::java.lang.TypeNotPresentException) _r2_o)._ftypeName = (global::java.lang.String) _r3_o;
    return;
//XMLVM_END_WRAPPER[java.lang.TypeNotPresentException: void <init>(java.lang.String, java.lang.Throwable)]
}

public virtual global::System.Object typeName(){
//XMLVM_BEGIN_WRAPPER[java.lang.TypeNotPresentException: java.lang.String typeName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.TypeNotPresentException) _r1_o)._ftypeName;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.TypeNotPresentException: java.lang.String typeName()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.TypeNotPresentException]
//XMLVM_END_WRAPPER[java.lang.TypeNotPresentException]

} // end of class: TypeNotPresentException

} // end of namespace: java.lang
