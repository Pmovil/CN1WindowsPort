// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class StringTokenizer: global::java.lang.Object,global::java.util.Enumeration {
private global::java.lang.String _fstring;

private global::java.lang.String _fdelimiters;

private bool _freturnDelimiters;

private int _fposition;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    // Value= \011\012\015\014
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 9)), unchecked((char) unchecked((uint) 10)), unchecked((char) unchecked((uint) 13)), unchecked((char) unchecked((uint) 12))}));
    _r1.i = 0;
    ((global::java.util.StringTokenizer) _r2_o).@this((global::java.lang.String) _r3_o, (global::java.lang.String) _r0_o, 0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: void <init>(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = 0;
    ((global::java.util.StringTokenizer) _r1_o).@this((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, 0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: void <init>(java.lang.String, java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2, bool n3){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: void <init>(java.lang.String, java.lang.String, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3 ? 1 : 0;
    ((global::java.lang.Object) _r1_o).@this();
    if (_r2_o == null) goto label15;
    ((global::java.util.StringTokenizer) _r1_o)._fstring = (global::java.lang.String) _r2_o;
    ((global::java.util.StringTokenizer) _r1_o)._fdelimiters = (global::java.lang.String) _r3_o;
    ((global::java.util.StringTokenizer) _r1_o)._freturnDelimiters = 0!=_r4.i;
    _r0.i = 0;
    ((global::java.util.StringTokenizer) _r1_o)._fposition = _r0.i;
    return;
    label15:;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
//XMLVM_END_WRAPPER[java.util.StringTokenizer: void <init>(java.lang.String, java.lang.String, boolean)]
}

public virtual int countTokens(){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: int countTokens()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    _r7_o = this;
    _r6.i = 0;
    _r0.i = ((global::java.util.StringTokenizer) _r7_o)._fposition;
    _r1_o = ((global::java.util.StringTokenizer) _r7_o)._fstring;
    _r1.i = ((global::java.lang.String) _r1_o).length();
    _r2.i = _r6.i;
    _r3.i = _r6.i;
    label11:;
    if (_r0.i < _r1.i) goto label18;
    if (_r2.i == 0) goto label49;
    _r0.i = _r3.i + 1;
    label17:;
    return _r0.i;
    label18:;
    _r4_o = ((global::java.util.StringTokenizer) _r7_o)._fdelimiters;
    _r5_o = ((global::java.util.StringTokenizer) _r7_o)._fstring;
    _r5.i = ((global::java.lang.String) _r5_o).charAt((int) _r0.i);
    _r4.i = ((global::java.lang.String) _r4_o).indexOf((int) _r5.i, (int) _r6.i);
    if (_r4.i < 0) goto label47;
    _r4.i = ((global::java.util.StringTokenizer) _r7_o)._freturnDelimiters ? 1 : 0;
    if (_r4.i == 0) goto label38;
    _r3.i = _r3.i + 1;
    label38:;
    if (_r2.i == 0) goto label44;
    _r2.i = _r3.i + 1;
    _r3.i = _r2.i;
    _r2.i = _r6.i;
    label44:;
    _r0.i = _r0.i + 1;
    goto label11;
    label47:;
    _r2.i = 1;
    goto label44;
    label49:;
    _r0.i = _r3.i;
    goto label17;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: int countTokens()]
}

public virtual bool hasMoreElements(){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: boolean hasMoreElements()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.StringTokenizer) _r1_o).hasMoreTokens() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: boolean hasMoreElements()]
}

public virtual bool hasMoreTokens(){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: boolean hasMoreTokens()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r5.i = 1;
    _r4.i = 0;
    _r0_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    if (_r0_o != null) goto label12;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label12:;
    _r0_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r0.i = ((global::java.lang.String) _r0_o).length();
    _r1.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    if (_r1.i >= _r0.i) goto label32;
    _r1.i = ((global::java.util.StringTokenizer) _r6_o)._freturnDelimiters ? 1 : 0;
    if (_r1.i == 0) goto label28;
    _r0.i = _r5.i;
    label27:;
    return _r0.i!=0;
    label28:;
    _r1.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    label30:;
    if (_r1.i < _r0.i) goto label34;
    label32:;
    _r0.i = _r4.i;
    goto label27;
    label34:;
    _r2_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    _r3_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r3.i = ((global::java.lang.String) _r3_o).charAt((int) _r1.i);
    _r2.i = ((global::java.lang.String) _r2_o).indexOf((int) _r3.i, (int) _r4.i);
    _r3.i = -1;
    if (_r2.i != _r3.i) goto label51;
    _r0.i = _r5.i;
    goto label27;
    label51:;
    _r1.i = _r1.i + 1;
    goto label30;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: boolean hasMoreTokens()]
}

public virtual global::System.Object nextElement(){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: java.lang.Object nextElement()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.StringTokenizer) _r1_o).nextToken();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: java.lang.Object nextElement()]
}

public virtual global::System.Object nextToken(){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: java.lang.String nextToken()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r5.i = 0;
    _r0_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    if (_r0_o != null) goto label11;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label11:;
    _r0.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r1_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r1.i = ((global::java.lang.String) _r1_o).length();
    if (_r0.i >= _r1.i) goto label178;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._freturnDelimiters ? 1 : 0;
    if (_r2.i == 0) goto label109;
    _r2_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    _r3_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r4.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r3.i = ((global::java.lang.String) _r3_o).charAt((int) _r4.i);
    _r2.i = ((global::java.lang.String) _r2_o).indexOf((int) _r3.i, (int) _r5.i);
    if (_r2.i < 0) goto label58;
    _r0_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r1.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r2.i = _r1.i + 1;
    ((global::java.util.StringTokenizer) _r6_o)._fposition = _r2.i;
    _r0.i = ((global::java.lang.String) _r0_o).charAt((int) _r1.i);
    _r0_o = global::java.lang.String.valueOf((char) _r0.i);
    label57:;
    return (global::java.lang.String) _r0_o;
    label58:;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r2.i = _r2.i + 1;
    ((global::java.util.StringTokenizer) _r6_o)._fposition = _r2.i;
    label64:;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    if (_r2.i < _r1.i) goto label75;
    _r1_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r0_o = ((global::java.lang.String) _r1_o).substring((int) _r0.i);
    goto label57;
    label75:;
    _r2_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    _r3_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r4.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r3.i = ((global::java.lang.String) _r3_o).charAt((int) _r4.i);
    _r2.i = ((global::java.lang.String) _r2_o).indexOf((int) _r3.i, (int) _r5.i);
    if (_r2.i < 0) goto label100;
    _r1_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r0_o = ((global::java.lang.String) _r1_o).substring((int) _r0.i, (int) _r2.i);
    goto label57;
    label100:;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r2.i = _r2.i + 1;
    ((global::java.util.StringTokenizer) _r6_o)._fposition = _r2.i;
    goto label64;
    label107:;
    _r0.i = _r0.i + 1;
    label109:;
    if (_r0.i >= _r1.i) goto label125;
    _r2_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    _r3_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r3.i = ((global::java.lang.String) _r3_o).charAt((int) _r0.i);
    _r2.i = ((global::java.lang.String) _r2_o).indexOf((int) _r3.i, (int) _r5.i);
    if (_r2.i >= 0) goto label107;
    label125:;
    ((global::java.util.StringTokenizer) _r6_o)._fposition = _r0.i;
    if (_r0.i >= _r1.i) goto label178;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r2.i = _r2.i + 1;
    ((global::java.util.StringTokenizer) _r6_o)._fposition = _r2.i;
    label135:;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    if (_r2.i < _r1.i) goto label146;
    _r1_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r0_o = ((global::java.lang.String) _r1_o).substring((int) _r0.i);
    goto label57;
    label146:;
    _r2_o = ((global::java.util.StringTokenizer) _r6_o)._fdelimiters;
    _r3_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r4.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r3.i = ((global::java.lang.String) _r3_o).charAt((int) _r4.i);
    _r2.i = ((global::java.lang.String) _r2_o).indexOf((int) _r3.i, (int) _r5.i);
    if (_r2.i < 0) goto label171;
    _r1_o = ((global::java.util.StringTokenizer) _r6_o)._fstring;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r0_o = ((global::java.lang.String) _r1_o).substring((int) _r0.i, (int) _r2.i);
    goto label57;
    label171:;
    _r2.i = ((global::java.util.StringTokenizer) _r6_o)._fposition;
    _r2.i = _r2.i + 1;
    ((global::java.util.StringTokenizer) _r6_o)._fposition = _r2.i;
    goto label135;
    label178:;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
//XMLVM_END_WRAPPER[java.util.StringTokenizer: java.lang.String nextToken()]
}

public virtual global::System.Object nextToken(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer: java.lang.String nextToken(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.StringTokenizer) _r1_o)._fdelimiters = (global::java.lang.String) _r2_o;
    _r0_o = ((global::java.util.StringTokenizer) _r1_o).nextToken();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.StringTokenizer: java.lang.String nextToken(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[java.util.StringTokenizer]
//XMLVM_END_WRAPPER[java.util.StringTokenizer]

} // end of class: StringTokenizer

} // end of namespace: java.util
