// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class SubstringFunction: global::gnu.xml.xpath.Expr {
public global::gnu.xml.xpath.Expr _farg1;

public global::gnu.xml.xpath.Expr _farg2;

public global::gnu.xml.xpath.Expr _farg3;

public void @this(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction: void <init>(java.util.List)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 2;
    _r0.i = 0;
    _r0_o = ((global::java.util.List) _r5_o).get((int) _r0.i);
    _r1.i = 1;
    _r1_o = ((global::java.util.List) _r5_o).get((int) _r1.i);
    _r2.i = ((global::java.util.List) _r5_o).size();
    if (_r2.i <= _r3.i) goto label31;
    _r2_o = ((global::java.util.List) _r5_o).get((int) _r3.i);
    label27:;
    ((global::gnu.xml.xpath.SubstringFunction) _r4_o).@this((global::gnu.xml.xpath.Expr) _r0_o, (global::gnu.xml.xpath.Expr) _r1_o, (global::gnu.xml.xpath.Expr) _r2_o);
    return;
    label31:;
    _r2_o = null;
    goto label27;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction: void <init>(java.util.List)]
}

public void @this(global::gnu.xml.xpath.Expr n1, global::gnu.xml.xpath.Expr n2, global::gnu.xml.xpath.Expr n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr, gnu.xml.xpath.Expr)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    ((global::gnu.xml.xpath.SubstringFunction) _r0_o)._farg1 = (global::gnu.xml.xpath.Expr) _r1_o;
    ((global::gnu.xml.xpath.SubstringFunction) _r0_o)._farg2 = (global::gnu.xml.xpath.Expr) _r2_o;
    ((global::gnu.xml.xpath.SubstringFunction) _r0_o)._farg3 = (global::gnu.xml.xpath.Expr) _r3_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr, gnu.xml.xpath.Expr)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r4_o = this;
    _r5_o = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r0_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg1;
    _r0_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r5_o, (int) _r6.i, (int) _r7.i);
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg2;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).evaluate((global::org.w3c.dom.Node) _r5_o, (int) _r6.i, (int) _r7.i);
    _r0_o = global::gnu.xml.xpath.SubstringFunction._1string((global::org.w3c.dom.Node) _r5_o, (global::java.lang.Object) _r0_o);
    _r1.i = global::gnu.xml.xpath.Expr.intValue((global::java.lang.Object) _r1_o);
    _r2.i = 1;
    _r1.i = _r1.i - _r2.i;
    if (_r1.i >= 0) goto label25;
    _r1.i = 0;
    label25:;
    _r2.i = ((global::java.lang.String) _r0_o).length();
    _r2.i = _r2.i - _r1.i;
    if (_r2.i > 0) goto label35;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label34:;
    return (global::java.lang.Object) _r0_o;
    label35:;
    _r3_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg3;
    if (_r3_o == null) goto label52;
    _r3_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg3;
    _r3_o = ((global::gnu.xml.xpath.Expr) _r3_o).evaluate((global::org.w3c.dom.Node) _r5_o, (int) _r6.i, (int) _r7.i);
    _r3.i = global::gnu.xml.xpath.Expr.intValue((global::java.lang.Object) _r3_o);
    if (_r3.i >= _r2.i) goto label52;
    _r2.i = _r3.i;
    label52:;
    _r2.i = _r2.i + _r1.i;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r1.i, (int) _r2.i);
    goto label34;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = new global::gnu.xml.xpath.SubstringFunction();
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg1;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).clone((global::java.lang.Object) _r5_o);
    _r2_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg2;
    _r2_o = ((global::gnu.xml.xpath.Expr) _r2_o).clone((global::java.lang.Object) _r5_o);
    _r3_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg3;
    if (_r3_o != null) goto label23;
    _r3_o = null;
    label19:;
    ((global::gnu.xml.xpath.SubstringFunction) _r0_o).@this((global::gnu.xml.xpath.Expr) _r1_o, (global::gnu.xml.xpath.Expr) _r2_o, (global::gnu.xml.xpath.Expr) _r3_o);
    return (global::gnu.xml.xpath.Expr) _r0_o;
    label23:;
    _r3_o = ((global::gnu.xml.xpath.SubstringFunction) _r4_o)._farg3;
    _r3_o = ((global::gnu.xml.xpath.Expr) _r3_o).clone((global::java.lang.Object) _r5_o);
    goto label19;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.SubstringFunction) _r1_o)._farg1;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label20;
    _r0_o = ((global::gnu.xml.xpath.SubstringFunction) _r1_o)._farg2;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label20;
    _r0_o = ((global::gnu.xml.xpath.SubstringFunction) _r1_o)._farg3;
    if (_r0_o != null) goto label22;
    label20:;
    _r0.i = 0;
    label21:;
    return _r0.i!=0;
    label22:;
    _r0_o = ((global::gnu.xml.xpath.SubstringFunction) _r1_o)._farg3;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    goto label21;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r5_o = this;
    // Value=substring(
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 40))}));
    // Value=)
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)41))}));
    // Value=,
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44))}));
    _r0_o = ((global::gnu.xml.xpath.SubstringFunction) _r5_o)._farg3;
    if (_r0_o != null) goto label46;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=substring(
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 40))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r4_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r5_o)._farg1;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=,
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r5_o)._farg2;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)41))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    label45:;
    return (global::java.lang.String) _r0_o;
    label46:;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=substring(
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 40))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r4_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r5_o)._farg1;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=,
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r5_o)._farg2;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=,
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringFunction) _r5_o)._farg3;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)41))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label45;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringFunction]
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringFunction]

} // end of class: SubstringFunction

} // end of namespace: gnu.xml.xpath
