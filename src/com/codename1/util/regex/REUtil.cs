// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util.regex {
public class REUtil: global::java.lang.Object {

static REUtil() {
    // Value=complex:
    _fcomplexPrefix = new global::java.lang.String();
    _fcomplexPrefix.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 58))}));
}

private static global::java.lang.String _fcomplexPrefix;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REUtil: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REUtil: void <init>()]
}

public static global::System.Object createRE(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REUtil: com.codename1.util.regex.RE createRE(java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = n1;
    _r4.i = n2;
    // Value=complex:
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 58))}));
    // Value=complex:
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 58))}));
    _r0.i = ((global::java.lang.String) _r3_o).startsWith((global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r0.i == 0) goto label26;
    _r0_o = new global::com.codename1.util.regex.RE();
    // Value=complex:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 58))}));
    _r1.i = ((global::java.lang.String) _r2_o).length();
    _r1_o = ((global::java.lang.String) _r3_o).substring((int) _r1.i);
    ((global::com.codename1.util.regex.RE) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r4.i);
    label25:;
    return (global::com.codename1.util.regex.RE) _r0_o;
    label26:;
    _r0_o = new global::com.codename1.util.regex.RE();
    _r1_o = global::com.codename1.util.regex.RE.simplePatternToFullRegularExpression((global::java.lang.String) _r3_o);
    ((global::com.codename1.util.regex.RE) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r4.i);
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REUtil: com.codename1.util.regex.RE createRE(java.lang.String, int)]
}

public static global::System.Object createRE(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REUtil: com.codename1.util.regex.RE createRE(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0.i = 0;
    _r0_o = global::com.codename1.util.regex.REUtil.createRE((global::java.lang.String) _r1_o, (int) _r0.i);
    return (global::com.codename1.util.regex.RE) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REUtil: com.codename1.util.regex.RE createRE(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REUtil]
//XMLVM_END_WRAPPER[com.codename1.util.regex.REUtil]

} // end of class: REUtil

} // end of namespace: com.codename1.util.regex
