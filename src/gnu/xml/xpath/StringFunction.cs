// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class StringFunction: global::gnu.xml.xpath.Expr {
public global::gnu.xml.xpath.Expr _farg;

public void @this(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction: void <init>(java.util.List)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::java.util.List) _r2_o).size();
    if (_r0.i <= 0) goto label17;
    _r0.i = 0;
    _r0_o = ((global::java.util.List) _r2_o).get((int) _r0.i);
    label13:;
    ((global::gnu.xml.xpath.StringFunction) _r1_o).@this((global::gnu.xml.xpath.Expr) _r0_o);
    return;
    label17:;
    _r0_o = null;
    goto label13;
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction: void <init>(java.util.List)]
}

public void @this(global::gnu.xml.xpath.Expr n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction: void <init>(gnu.xml.xpath.Expr)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    ((global::gnu.xml.xpath.StringFunction) _r0_o)._farg = (global::gnu.xml.xpath.Expr) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction: void <init>(gnu.xml.xpath.Expr)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = ((global::gnu.xml.xpath.StringFunction) _r1_o)._farg;
    if (_r0_o != null) goto label10;
    _r0_o = null;
    label5:;
    _r0_o = global::gnu.xml.xpath.StringFunction._1string((global::org.w3c.dom.Node) _r2_o, (global::java.lang.Object) _r0_o);
    return (global::java.lang.Object) _r0_o;
    label10:;
    _r0_o = ((global::gnu.xml.xpath.StringFunction) _r1_o)._farg;
    _r0_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r2_o, (int) _r3.i, (int) _r4.i);
    goto label5;
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::gnu.xml.xpath.StringFunction();
    _r1_o = ((global::gnu.xml.xpath.StringFunction) _r2_o)._farg;
    if (_r1_o != null) goto label11;
    _r1_o = null;
    label7:;
    ((global::gnu.xml.xpath.StringFunction) _r0_o).@this((global::gnu.xml.xpath.Expr) _r1_o);
    return (global::gnu.xml.xpath.Expr) _r0_o;
    label11:;
    _r1_o = ((global::gnu.xml.xpath.StringFunction) _r2_o)._farg;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).clone((global::java.lang.Object) _r3_o);
    goto label7;
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.StringFunction) _r1_o)._farg;
    if (_r0_o != null) goto label6;
    _r0.i = 0;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0_o = ((global::gnu.xml.xpath.StringFunction) _r1_o)._farg;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    goto label5;
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.xpath.StringFunction) _r2_o)._farg;
    if (_r0_o != null) goto label7;
    // Value=string()
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    label6:;
    return (global::java.lang.String) _r0_o;
    label7:;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=string(
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 40))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.StringFunction) _r2_o)._farg;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)41))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label6;
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.StringFunction]
//XMLVM_END_WRAPPER[gnu.xml.xpath.StringFunction]

} // end of class: StringFunction

} // end of namespace: gnu.xml.xpath
