// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class Insets: global::java.lang.Object {
public int _ftop;

public int _fleft;

public int _fbottom;

public int _fright;

public void @this(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: void <init>(int, int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    _r3.i = n3;
    _r4.i = n4;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.layouts.Insets) _r0_o).setValues((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: void <init>(int, int, int, int)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._ftop;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fbottom;
    _r0.i = _r0.i * _r1.i;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fleft;
    _r0.i = _r0.i * _r1.i;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fright;
    _r0.i = _r0.i * _r1.i;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._ftop;
    _r0.i = _r0.i + _r1.i;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fbottom;
    _r0.i = _r0.i + _r1.i;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fleft;
    _r0.i = _r0.i + _r1.i;
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fright;
    _r0.i = _r0.i + _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: int hashCode()]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: java.lang.Object clone()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r0_o = new global::com.codename1.ui.layouts.Insets();
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r5_o)._ftop;
    _r2.i = ((global::com.codename1.ui.layouts.Insets) _r5_o)._fleft;
    _r3.i = ((global::com.codename1.ui.layouts.Insets) _r5_o)._fbottom;
    _r4.i = ((global::com.codename1.ui.layouts.Insets) _r5_o)._fright;
    ((global::com.codename1.ui.layouts.Insets) _r0_o).@this((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: java.lang.Object clone()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: boolean equals(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 1;
    _r4.i = 0;
    if (_r7_o != _r6_o) goto label6;
    _r2.i = _r5.i;
    label5:;
    return _r2.i!=0;
    label6:;
    _r2.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.layouts.Insets)) ? 1 : 0;
    if (_r2.i == 0) goto label42;
    _r0_o = _r7_o;
    _r1_o = _r0_o;
    _r2.i = ((global::com.codename1.ui.layouts.Insets) _r1_o)._fleft;
    _r3.i = ((global::com.codename1.ui.layouts.Insets) _r6_o)._fleft;
    if (_r2.i != _r3.i) goto label40;
    _r2.i = ((global::com.codename1.ui.layouts.Insets) _r1_o)._fbottom;
    _r3.i = ((global::com.codename1.ui.layouts.Insets) _r6_o)._fbottom;
    if (_r2.i != _r3.i) goto label40;
    _r2.i = ((global::com.codename1.ui.layouts.Insets) _r1_o)._fright;
    _r3.i = ((global::com.codename1.ui.layouts.Insets) _r6_o)._fright;
    if (_r2.i != _r3.i) goto label40;
    _r2.i = ((global::com.codename1.ui.layouts.Insets) _r1_o)._ftop;
    _r3.i = ((global::com.codename1.ui.layouts.Insets) _r6_o)._ftop;
    if (_r2.i != _r3.i) goto label40;
    _r2.i = _r5.i;
    goto label5;
    label40:;
    _r2.i = _r4.i;
    goto label5;
    label42:;
    _r2.i = _r4.i;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: boolean equals(java.lang.Object)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::java.lang.Object) _r2_o).getClass();
    _r1_o = ((global::java.lang.Class) _r1_o).getName();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value=[left=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 61))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fleft;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=,top=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 61))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._ftop;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=,right=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 61))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fright;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=,bottom=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 61))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.ui.layouts.Insets) _r2_o)._fbottom;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=]
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: java.lang.String toString()]
}

public virtual void set(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: void set(int, int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    _r3.i = n3;
    _r4.i = n4;
    ((global::com.codename1.ui.layouts.Insets) _r0_o).setValues((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: void set(int, int, int, int)]
}

private void setValues(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets: void setValues(int, int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    _r3.i = n3;
    _r4.i = n4;
    ((global::com.codename1.ui.layouts.Insets) _r0_o)._ftop = _r1.i;
    ((global::com.codename1.ui.layouts.Insets) _r0_o)._fleft = _r2.i;
    ((global::com.codename1.ui.layouts.Insets) _r0_o)._fbottom = _r3.i;
    ((global::com.codename1.ui.layouts.Insets) _r0_o)._fright = _r4.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets: void setValues(int, int, int, int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.Insets]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.Insets]

} // end of class: Insets

} // end of namespace: com.codename1.ui.layouts
