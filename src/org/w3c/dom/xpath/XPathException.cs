// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom.xpath {
public class XPathException: global::java.lang.RuntimeException {
public short _fcode;

public static short _fINVALID_1EXPRESSION_1ERR = 51;

public static short _fTYPE_1ERR = 52;

public void @this(short n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.w3c.dom.xpath.XPathException: void <init>(short, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1.i = n1;
    _r2_o = n2;
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r2_o);
    ((global::org.w3c.dom.xpath.XPathException) _r0_o)._fcode = (short) _r1.i;
    return;
//XMLVM_END_WRAPPER[org.w3c.dom.xpath.XPathException: void <init>(short, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.xpath.XPathException]
//XMLVM_END_WRAPPER[org.w3c.dom.xpath.XPathException]

} // end of class: XPathException

} // end of namespace: org.w3c.dom.xpath
