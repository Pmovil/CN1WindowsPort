// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio.charset {
public class UnsupportedCharsetException: global::java.lang.IllegalArgumentException {
private static long _fserialVersionUID = 1490765524727386367L;

private global::java.lang.String _fcharsetName;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.UnsupportedCharsetException: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=niochar.04
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 52))}));
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r0_o, (global::java.lang.Object) _r2_o);
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r0_o);
    ((global::java.nio.charset.UnsupportedCharsetException) _r1_o)._fcharsetName = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.nio.charset.UnsupportedCharsetException: void <init>(java.lang.String)]
}

public virtual global::System.Object getCharsetName(){
//XMLVM_BEGIN_WRAPPER[java.nio.charset.UnsupportedCharsetException: java.lang.String getCharsetName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.charset.UnsupportedCharsetException) _r1_o)._fcharsetName;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.nio.charset.UnsupportedCharsetException: java.lang.String getCharsetName()]
}

//XMLVM_BEGIN_WRAPPER[java.nio.charset.UnsupportedCharsetException]
//XMLVM_END_WRAPPER[java.nio.charset.UnsupportedCharsetException]

} // end of class: UnsupportedCharsetException

} // end of namespace: java.nio.charset
