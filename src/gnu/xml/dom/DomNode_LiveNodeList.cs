// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomNode_2LiveNodeList: global::java.lang.Object,global::org.w3c.dom.NodeList,global::org.w3c.dom.events.EventListener,global::org.w3c.dom.traversal.NodeFilter {
private bool _fmatchAnyURI;

private bool _fmatchAnyName;

private global::java.lang.String _felementURI;

private global::java.lang.String _felementName;

private global::gnu.xml.dom.DomIterator _fcurrent;

private int _flastIndex;

public global::gnu.xml.dom.DomNode _fthis_20;

public static short _fFILTER_1ACCEPT = org.w3c.dom.traversal._iNodeFilter._fFILTER_1ACCEPT;

public static short _fFILTER_1REJECT = org.w3c.dom.traversal._iNodeFilter._fFILTER_1REJECT;

public static short _fFILTER_1SKIP = org.w3c.dom.traversal._iNodeFilter._fFILTER_1SKIP;

public static int _fSHOW_1ALL = org.w3c.dom.traversal._iNodeFilter._fSHOW_1ALL;

public static int _fSHOW_1ELEMENT = org.w3c.dom.traversal._iNodeFilter._fSHOW_1ELEMENT;

public static int _fSHOW_1ATTRIBUTE = org.w3c.dom.traversal._iNodeFilter._fSHOW_1ATTRIBUTE;

public static int _fSHOW_1TEXT = org.w3c.dom.traversal._iNodeFilter._fSHOW_1TEXT;

public static int _fSHOW_1CDATA_1SECTION = org.w3c.dom.traversal._iNodeFilter._fSHOW_1CDATA_1SECTION;

public static int _fSHOW_1ENTITY_1REFERENCE = org.w3c.dom.traversal._iNodeFilter._fSHOW_1ENTITY_1REFERENCE;

public static int _fSHOW_1ENTITY = org.w3c.dom.traversal._iNodeFilter._fSHOW_1ENTITY;

public static int _fSHOW_1PROCESSING_1INSTRUCTION = org.w3c.dom.traversal._iNodeFilter._fSHOW_1PROCESSING_1INSTRUCTION;

public static int _fSHOW_1COMMENT = org.w3c.dom.traversal._iNodeFilter._fSHOW_1COMMENT;

public static int _fSHOW_1DOCUMENT = org.w3c.dom.traversal._iNodeFilter._fSHOW_1DOCUMENT;

public static int _fSHOW_1DOCUMENT_1TYPE = org.w3c.dom.traversal._iNodeFilter._fSHOW_1DOCUMENT_1TYPE;

public static int _fSHOW_1DOCUMENT_1FRAGMENT = org.w3c.dom.traversal._iNodeFilter._fSHOW_1DOCUMENT_1FRAGMENT;

public static int _fSHOW_1NOTATION = org.w3c.dom.traversal._iNodeFilter._fSHOW_1NOTATION;

public void @this(global::gnu.xml.dom.DomNode n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: void <init>(gnu.xml.dom.DomNode, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6_o = n3;
    _r1.i = 1;
    // Value=*
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)42))}));
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fthis_20 = (global::gnu.xml.dom.DomNode) _r4_o;
    ((global::java.lang.Object) _r3_o).@this();
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementURI = (global::java.lang.String) _r5_o;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementName = (global::java.lang.String) _r6_o;
    // Value=*
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)42))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fmatchAnyURI = 0!=_r0.i;
    // Value=*
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)42))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r6_o) ? 1 : 0;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fmatchAnyName = 0!=_r0.i;
    // Value=DOMNodeInserted
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.DomNode) _r4_o).addEventListener((global::java.lang.String) _r0_o, (global::org.w3c.dom.events.EventListener) _r3_o, 0!=_r1.i);
    // Value=DOMNodeRemoved
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.DomNode) _r4_o).addEventListener((global::java.lang.String) _r0_o, (global::org.w3c.dom.events.EventListener) _r3_o, 0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: void <init>(gnu.xml.dom.DomNode, java.lang.String, java.lang.String)]
}

public virtual void detach(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: void detach()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.i = 1;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    if (_r0_o == null) goto label10;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    ((global::gnu.xml.dom.DomIterator) _r0_o).detach();
    label10:;
    _r0_o = null;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent = (global::gnu.xml.dom.DomIterator) _r0_o;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fthis_20;
    // Value=DOMNodeInserted
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.DomNode) _r0_o).removeEventListener((global::java.lang.String) _r1_o, (global::org.w3c.dom.events.EventListener) _r3_o, 0!=_r2.i);
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fthis_20;
    // Value=DOMNodeRemoved
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.DomNode) _r0_o).removeEventListener((global::java.lang.String) _r1_o, (global::org.w3c.dom.events.EventListener) _r3_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: void detach()]
}

public virtual short acceptNode(global::org.w3c.dom.Node n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: short acceptNode(org.w3c.dom.Node)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 3;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fthis_20;
    if (_r4_o != _r0_o) goto label7;
    _r0.i = _r2.i;
    label6:;
    return (short) _r0.i;
    label7:;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementURI;
    if (_r0_o == null) goto label47;
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fmatchAnyURI ? 1 : 0;
    if (_r0.i != 0) goto label29;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementURI;
    _r1_o = ((global::org.w3c.dom.Node) _r4_o).getNamespaceURI();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label29;
    _r0.i = _r2.i;
    goto label6;
    label29:;
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fmatchAnyName ? 1 : 0;
    if (_r0.i != 0) goto label65;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementName;
    _r1_o = ((global::org.w3c.dom.Node) _r4_o).getLocalName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label65;
    _r0.i = _r2.i;
    goto label6;
    label47:;
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fmatchAnyName ? 1 : 0;
    if (_r0.i != 0) goto label65;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementName;
    _r1_o = ((global::org.w3c.dom.Node) _r4_o).getNodeName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label65;
    _r0.i = _r2.i;
    goto label6;
    label65:;
    _r0.i = 1;
    goto label6;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: short acceptNode(org.w3c.dom.Node)]
}

private global::System.Object createIterator(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: gnu.xml.dom.DomIterator createIterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.i = 1;
    _r0_o = new global::gnu.xml.dom.DomIterator();
    _r1_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fthis_20;
    ((global::gnu.xml.dom.DomIterator) _r0_o).@this((global::org.w3c.dom.Node) _r1_o, (int) _r2.i, (global::org.w3c.dom.traversal.NodeFilter) _r3_o, 0!=_r2.i);
    return (global::gnu.xml.dom.DomIterator) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: gnu.xml.dom.DomIterator createIterator()]
}

public virtual void handleEvent(global::org.w3c.dom.events.Event n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: void handleEvent(org.w3c.dom.events.Event)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r4_o = _r4_o;
    _r0_o = ((global::org.w3c.dom.events.MutationEvent) _r4_o).getRelatedNode();
    _r1.i = ((global::org.w3c.dom.Node) _r0_o).getNodeType();
    _r2.i = 1;
    if (_r1.i != _r2.i) goto label29;
    _r1_o = ((global::org.w3c.dom.Node) _r0_o).getNodeName();
    _r2_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementName;
    if (_r1_o != _r2_o) goto label29;
    _r0_o = ((global::org.w3c.dom.Node) _r0_o).getNamespaceURI();
    _r1_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._felementURI;
    if (_r0_o == _r1_o) goto label30;
    label29:;
    return;
    label30:;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    if (_r0_o == null) goto label39;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    ((global::gnu.xml.dom.DomIterator) _r0_o).detach();
    label39:;
    _r0_o = null;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent = (global::gnu.xml.dom.DomIterator) _r0_o;
    goto label29;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: void handleEvent(org.w3c.dom.events.Event)]
}

public virtual global::System.Object item(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: org.w3c.dom.Node item(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2_o = null;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    if (_r0_o != null) goto label14;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o).createIterator();
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent = (global::gnu.xml.dom.DomIterator) _r0_o;
    _r0.i = -1;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex = _r0.i;
    label14:;
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex;
    if (_r4.i > _r0.i) goto label53;
    label18:;
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex;
    if (_r4.i != _r0.i) goto label36;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    _r0_o = ((global::gnu.xml.dom.DomIterator) _r0_o).previousNode();
    _r1_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    ((global::gnu.xml.dom.DomIterator) _r1_o).detach();
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent = (global::gnu.xml.dom.DomIterator) _r2_o;
    label35:;
    return (global::org.w3c.dom.Node) _r0_o;
    label36:;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    ((global::gnu.xml.dom.DomIterator) _r0_o).previousNode();
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex;
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex = _r0.i;
    goto label18;
    label48:;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    ((global::gnu.xml.dom.DomIterator) _r0_o).nextNode();
    label53:;
    _r0.i = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex;
    _r0.i = _r0.i + 1;
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._flastIndex = _r0.i;
    if (_r0.i != _r4.i) goto label48;
    _r0_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    _r0_o = ((global::gnu.xml.dom.DomIterator) _r0_o).nextNode();
    _r1_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent;
    ((global::gnu.xml.dom.DomIterator) _r1_o).detach();
    ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o)._fcurrent = (global::gnu.xml.dom.DomIterator) _r2_o;
    goto label35;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: org.w3c.dom.Node item(int)]
}

public virtual int getLength(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: int getLength()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 0;
    _r1_o = ((global::gnu.xml.dom.DomNode_2LiveNodeList) _r3_o).createIterator();
    label5:;
    _r2_o = ((global::org.w3c.dom.traversal.NodeIterator) _r1_o).nextNode();
    if (_r2_o != null) goto label15;
    ((global::org.w3c.dom.traversal.NodeIterator) _r1_o).detach();
    return _r0.i;
    label15:;
    _r0.i = _r0.i + 1;
    goto label5;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList: int getLength()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$LiveNodeList]

} // end of class: DomNode_2LiveNodeList

} // end of namespace: gnu.xml.dom
