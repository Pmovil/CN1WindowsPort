// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class DocumentOrderComparator: global::java.lang.Object,global::java.util.Comparator {
public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.DocumentOrderComparator: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.DocumentOrderComparator: void <init>()]
}

public virtual int compare(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.DocumentOrderComparator: int compare(org.w3c.dom.Node, org.w3c.dom.Node)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = ((global::org.w3c.dom.Node) _r2_o).compareDocumentPosition((global::org.w3c.dom.Node) _r3_o);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.xpath.DocumentOrderComparator: int compare(org.w3c.dom.Node, org.w3c.dom.Node)]
}

public virtual int compare(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.DocumentOrderComparator: int compare(java.lang.Object, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = ((global::gnu.xml.xpath.DocumentOrderComparator) _r1_o).compare((global::org.w3c.dom.Node) _r2_o, (global::org.w3c.dom.Node) _r3_o);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.xpath.DocumentOrderComparator: int compare(java.lang.Object, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.DocumentOrderComparator]
//XMLVM_END_WRAPPER[gnu.xml.xpath.DocumentOrderComparator]

} // end of class: DocumentOrderComparator

} // end of namespace: gnu.xml.xpath
