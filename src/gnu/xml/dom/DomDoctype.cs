// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomDoctype: global::gnu.xml.dom.DomExtern,global::org.w3c.dom.DocumentType {
private global::gnu.xml.dom.DomNamedNodeMap _fnotations;

private global::gnu.xml.dom.DomNamedNodeMap _fentities;

private global::org.w3c.dom.DOMImplementation _fimplementation;

private global::java.lang.String _fsubset;

private global::java.util.HashMap _felements;

private bool _fids;

public static short _fELEMENT_1NODE = org.w3c.dom._iNode._fELEMENT_1NODE;

public static short _fATTRIBUTE_1NODE = org.w3c.dom._iNode._fATTRIBUTE_1NODE;

public static short _fTEXT_1NODE = org.w3c.dom._iNode._fTEXT_1NODE;

public static short _fCDATA_1SECTION_1NODE = org.w3c.dom._iNode._fCDATA_1SECTION_1NODE;

public static short _fENTITY_1REFERENCE_1NODE = org.w3c.dom._iNode._fENTITY_1REFERENCE_1NODE;

public static short _fENTITY_1NODE = org.w3c.dom._iNode._fENTITY_1NODE;

public static short _fPROCESSING_1INSTRUCTION_1NODE = org.w3c.dom._iNode._fPROCESSING_1INSTRUCTION_1NODE;

public static short _fCOMMENT_1NODE = org.w3c.dom._iNode._fCOMMENT_1NODE;

public static short _fDOCUMENT_1NODE = org.w3c.dom._iNode._fDOCUMENT_1NODE;

public static short _fDOCUMENT_1TYPE_1NODE = org.w3c.dom._iNode._fDOCUMENT_1TYPE_1NODE;

public static short _fDOCUMENT_1FRAGMENT_1NODE = org.w3c.dom._iNode._fDOCUMENT_1FRAGMENT_1NODE;

public static short _fNOTATION_1NODE = org.w3c.dom._iNode._fNOTATION_1NODE;

public static short _fDOCUMENT_1POSITION_1DISCONNECTED = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1DISCONNECTED;

public static short _fDOCUMENT_1POSITION_1PRECEDING = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1PRECEDING;

public static short _fDOCUMENT_1POSITION_1FOLLOWING = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1FOLLOWING;

public static short _fDOCUMENT_1POSITION_1CONTAINS = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1CONTAINS;

public static short _fDOCUMENT_1POSITION_1CONTAINED_1BY = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1CONTAINED_1BY;

public static short _fDOCUMENT_1POSITION_1IMPLEMENTATION_1SPECIFIC = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1IMPLEMENTATION_1SPECIFIC;

public void @this(global::org.w3c.dom.DOMImplementation n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: void <init>(org.w3c.dom.DOMImplementation, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r10_o = n4;
    _r11_o = n5;
    _r1.i = 10;
    _r2_o = null;
    _r0_o = _r6_o;
    _r3_o = _r8_o;
    _r4_o = _r9_o;
    _r5_o = _r10_o;
    ((global::gnu.xml.dom.DomExtern) _r0_o).@this((short) _r1.i, (global::gnu.xml.dom.DomDocument) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r0_o = new global::java.util.HashMap();
    ((global::java.util.HashMap) _r0_o).@this();
    ((global::gnu.xml.dom.DomDoctype) _r6_o)._felements = (global::java.util.HashMap) _r0_o;
    ((global::gnu.xml.dom.DomDoctype) _r6_o)._fimplementation = (global::org.w3c.dom.DOMImplementation) _r7_o;
    ((global::gnu.xml.dom.DomDoctype) _r6_o)._fsubset = (global::java.lang.String) _r11_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: void <init>(org.w3c.dom.DOMImplementation, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public void @this(global::gnu.xml.dom.DomDocument n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: void <init>(gnu.xml.dom.DomDocument, java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r10_o = n4;
    _r1.i = 10;
    _r0_o = _r6_o;
    _r2_o = _r7_o;
    _r3_o = _r8_o;
    _r4_o = _r9_o;
    _r5_o = _r10_o;
    ((global::gnu.xml.dom.DomExtern) _r0_o).@this((short) _r1.i, (global::gnu.xml.dom.DomDocument) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r0_o = new global::java.util.HashMap();
    ((global::java.util.HashMap) _r0_o).@this();
    ((global::gnu.xml.dom.DomDoctype) _r6_o)._felements = (global::java.util.HashMap) _r0_o;
    _r0_o = ((global::gnu.xml.dom.DomDocument) _r7_o).getImplementation();
    ((global::gnu.xml.dom.DomDoctype) _r6_o)._fimplementation = (global::org.w3c.dom.DOMImplementation) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: void <init>(gnu.xml.dom.DomDocument, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o).getNodeName();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.String getName()]
}

public virtual global::System.Object getEntities(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.NamedNodeMap getEntities()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fentities;
    if (_r0_o != null) goto label12;
    _r0_o = new global::gnu.xml.dom.DomNamedNodeMap();
    _r1.i = 6;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o).@this((global::gnu.xml.dom.DomNode) _r2_o, (short) _r1.i);
    ((global::gnu.xml.dom.DomDoctype) _r2_o)._fentities = (global::gnu.xml.dom.DomNamedNodeMap) _r0_o;
    label12:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fentities;
    return (global::org.w3c.dom.NamedNodeMap) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.NamedNodeMap getEntities()]
}

public virtual global::System.Object declareEntity(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.Entity declareEntity(java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r10_o = n4;
    _r3_o = null;
    _r2.i = 0;
    _r0.i = ((global::java.lang.String) _r7_o).charAt((int) _r2.i);
    _r1.i = 37;
    if (_r0.i == _r1.i) goto label18;
    // Value=[dtd]
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 93))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r7_o) ? 1 : 0;
    if (_r0.i == 0) goto label20;
    label18:;
    _r0_o = _r3_o;
    label19:;
    return (global::org.w3c.dom.Entity) _r0_o;
    label20:;
    _r0.i = ((global::gnu.xml.dom.DomDoctype) _r6_o).isReadonly() ? 1 : 0;
    if (_r0.i == 0) goto label33;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label33:;
    ((global::gnu.xml.dom.DomDoctype) _r6_o).getEntities();
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r6_o)._fowner;
    if (_r0_o == null) goto label65;
    // Value=1.1
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49))}));
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r6_o)._fowner;
    _r1_o = ((global::gnu.xml.dom.DomDocument) _r1_o).getXmlVersion();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    label52:;
    global::gnu.xml.dom.DomDocument.checkName((global::java.lang.String) _r7_o, 0!=_r0.i);
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r6_o)._fentities;
    _r0_o = ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o).getNamedItem((global::java.lang.String) _r7_o);
    if (_r0_o == null) goto label67;
    _r0_o = _r3_o;
    goto label19;
    label65:;
    _r0.i = _r2.i;
    goto label52;
    label67:;
    _r0_o = new global::gnu.xml.dom.DomEntity();
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r6_o)._fowner;
    _r2_o = _r7_o;
    _r3_o = _r8_o;
    _r4_o = _r9_o;
    _r5_o = _r10_o;
    ((global::gnu.xml.dom.DomEntity) _r0_o).@this((global::gnu.xml.dom.DomDocument) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r6_o)._fentities;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r1_o).setNamedItem((global::org.w3c.dom.Node) _r0_o);
    goto label19;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.Entity declareEntity(java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getNotations(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.NamedNodeMap getNotations()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fnotations;
    if (_r0_o != null) goto label13;
    _r0_o = new global::gnu.xml.dom.DomNamedNodeMap();
    _r1.i = 12;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o).@this((global::gnu.xml.dom.DomNode) _r2_o, (short) _r1.i);
    ((global::gnu.xml.dom.DomDoctype) _r2_o)._fnotations = (global::gnu.xml.dom.DomNamedNodeMap) _r0_o;
    label13:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fnotations;
    return (global::org.w3c.dom.NamedNodeMap) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.NamedNodeMap getNotations()]
}

public virtual global::System.Object declareNotation(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.Notation declareNotation(java.lang.String, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r0.i = ((global::gnu.xml.dom.DomDoctype) _r2_o).isReadonly() ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label13:;
    ((global::gnu.xml.dom.DomDoctype) _r2_o).getNotations();
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fowner;
    if (_r0_o == null) goto label48;
    // Value=1.1
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49))}));
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fowner;
    _r1_o = ((global::gnu.xml.dom.DomDocument) _r1_o).getXmlVersion();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    label32:;
    global::gnu.xml.dom.DomDocument.checkName((global::java.lang.String) _r3_o, 0!=_r0.i);
    _r0_o = new global::gnu.xml.dom.DomNotation();
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fowner;
    ((global::gnu.xml.dom.DomNotation) _r0_o).@this((global::gnu.xml.dom.DomDocument) _r1_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._fnotations;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r1_o).setNamedItem((global::org.w3c.dom.Node) _r0_o);
    return (global::org.w3c.dom.Notation) _r0_o;
    label48:;
    _r0.i = 0;
    goto label32;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.Notation declareNotation(java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getInternalSubset(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.String getInternalSubset()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fsubset;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.String getInternalSubset()]
}

public override global::System.Object getBaseURI(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.String getBaseURI()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.String getBaseURI()]
}

public override void makeReadonly(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: void makeReadonly()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    base.makeReadonly();
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fentities;
    if (_r0_o == null) goto label12;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fentities;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o).makeReadonly();
    label12:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fnotations;
    if (_r0_o == null) goto label21;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fnotations;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o).makeReadonly();
    label21:;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: void makeReadonly()]
}

public override void setOwner(global::gnu.xml.dom.DomDocument n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: void setOwner(gnu.xml.dom.DomDocument)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fentities;
    if (_r0_o == null) goto label10;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fentities;
    _r0_o = ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o)._ffirst;
    label8:;
    if (_r0_o != null) goto label24;
    label10:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fnotations;
    if (_r0_o == null) goto label20;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fnotations;
    _r0_o = ((global::gnu.xml.dom.DomNamedNodeMap) _r0_o)._ffirst;
    label18:;
    if (_r0_o != null) goto label30;
    label20:;
    base.setOwner((global::gnu.xml.dom.DomDocument) _r2_o);
    return;
    label24:;
    ((global::gnu.xml.dom.DomNode) _r0_o).setOwner((global::gnu.xml.dom.DomDocument) _r2_o);
    _r0_o = ((global::gnu.xml.dom.DomNode) _r0_o)._fnext;
    goto label8;
    label30:;
    ((global::gnu.xml.dom.DomNode) _r0_o).setOwner((global::gnu.xml.dom.DomDocument) _r2_o);
    _r0_o = ((global::gnu.xml.dom.DomNode) _r0_o)._fnext;
    goto label18;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: void setOwner(gnu.xml.dom.DomDocument)]
}

public virtual bool supports(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: boolean supports(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fimplementation;
    _r0.i = ((global::org.w3c.dom.DOMImplementation) _r0_o).hasFeature((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: boolean supports(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getImplementation(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.DOMImplementation getImplementation()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fimplementation;
    return (global::org.w3c.dom.DOMImplementation) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: org.w3c.dom.DOMImplementation getImplementation()]
}

public virtual void elementDecl(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: void elementDecl(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r2_o).getElementTypeInfo((global::java.lang.String) _r3_o);
    if (_r0_o != null) goto label17;
    _r0_o = new global::gnu.xml.dom.DTDElementTypeInfo();
    ((global::gnu.xml.dom.DTDElementTypeInfo) _r0_o).@this((global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o);
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r2_o)._felements;
    ((global::java.util.HashMap) _r1_o).put((global::java.lang.Object) _r3_o, (global::java.lang.Object) _r0_o);
    label16:;
    return;
    label17:;
    ((global::gnu.xml.dom.DTDElementTypeInfo) _r0_o)._fmodel = (global::java.lang.String) _r4_o;
    goto label16;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: void elementDecl(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getElementTypeInfo(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: gnu.xml.dom.DTDElementTypeInfo getElementTypeInfo(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._felements;
    _r1_o = ((global::java.util.HashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    return (global::gnu.xml.dom.DTDElementTypeInfo) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: gnu.xml.dom.DTDElementTypeInfo getElementTypeInfo(java.lang.String)]
}

public virtual void attributeDecl(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: void attributeDecl(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r10_o = n4;
    _r11_o = n5;
    _r0_o = new global::gnu.xml.dom.DTDAttributeTypeInfo();
    _r1_o = _r7_o;
    _r2_o = _r8_o;
    _r3_o = _r9_o;
    _r4_o = _r10_o;
    _r5_o = _r11_o;
    ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r6_o).getElementTypeInfo((global::java.lang.String) _r7_o);
    if (_r1_o != null) goto label27;
    _r1_o = new global::gnu.xml.dom.DTDElementTypeInfo();
    _r2_o = null;
    ((global::gnu.xml.dom.DTDElementTypeInfo) _r1_o).@this((global::java.lang.String) _r7_o, (global::java.lang.String) _r2_o);
    _r2_o = ((global::gnu.xml.dom.DomDoctype) _r6_o)._felements;
    ((global::java.util.HashMap) _r2_o).put((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    label27:;
    ((global::gnu.xml.dom.DTDElementTypeInfo) _r1_o).setAttributeTypeInfo((global::java.lang.String) _r8_o, (global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o);
    // Value=ID
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 68))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r9_o) ? 1 : 0;
    if (_r0.i == 0) goto label41;
    _r0.i = 1;
    ((global::gnu.xml.dom.DomDoctype) _r6_o)._fids = 0!=_r0.i;
    label41:;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: void attributeDecl(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getAttributeTypeInfo(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: gnu.xml.dom.DTDAttributeTypeInfo getAttributeTypeInfo(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r1_o)._felements;
    _r1_o = ((global::java.util.HashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    if (_r1_o != null) goto label12;
    _r0_o = null;
    label11:;
    return (global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o;
    label12:;
    _r0_o = ((global::gnu.xml.dom.DTDElementTypeInfo) _r1_o).getAttributeTypeInfo((global::java.lang.String) _r3_o);
    goto label11;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: gnu.xml.dom.DTDAttributeTypeInfo getAttributeTypeInfo(java.lang.String, java.lang.String)]
}

public virtual bool hasIds(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: boolean hasIds()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.dom.DomDoctype) _r1_o)._fids ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: boolean hasIds()]
}

public override bool isSameNode(global::org.w3c.dom.Node n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: boolean isSameNode(org.w3c.dom.Node)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    _r2.i = 0;
    _r0.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r0.i == 0) goto label10;
    _r0.i = _r3.i;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::org.w3c.dom.DocumentType)) ? 1 : 0;
    if (_r0.i != 0) goto label16;
    _r0.i = _r2.i;
    goto label9;
    label16:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r4_o).getPublicId();
    _r1_o = ((global::org.w3c.dom.DocumentType) _r5_o).getPublicId();
    _r0.i = ((global::gnu.xml.dom.DomDoctype) _r4_o).equal((global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label34;
    _r0.i = _r2.i;
    goto label9;
    label34:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r4_o).getSystemId();
    _r1_o = ((global::org.w3c.dom.DocumentType) _r5_o).getSystemId();
    _r0.i = ((global::gnu.xml.dom.DomDoctype) _r4_o).equal((global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label50;
    _r0.i = _r2.i;
    goto label9;
    label50:;
    _r0_o = ((global::gnu.xml.dom.DomDoctype) _r4_o).getInternalSubset();
    _r1_o = ((global::org.w3c.dom.DocumentType) _r5_o).getInternalSubset();
    _r0.i = ((global::gnu.xml.dom.DomDoctype) _r4_o).equal((global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label66;
    _r0.i = _r2.i;
    goto label9;
    label66:;
    _r0.i = _r3.i;
    goto label9;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: boolean isSameNode(org.w3c.dom.Node)]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.Object clone()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r4.i = 1;
    _r0_o = base.clone();
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r5_o)._fentities;
    if (_r1_o == null) goto label25;
    _r1_o = new global::gnu.xml.dom.DomNamedNodeMap();
    _r2.i = 6;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r1_o).@this((global::gnu.xml.dom.DomNode) _r0_o, (short) _r2.i);
    ((global::gnu.xml.dom.DomDoctype) _r0_o)._fentities = (global::gnu.xml.dom.DomNamedNodeMap) _r1_o;
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r5_o)._fentities;
    _r1_o = ((global::gnu.xml.dom.DomNamedNodeMap) _r1_o)._ffirst;
    label23:;
    if (_r1_o != null) goto label45;
    label25:;
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r5_o)._fnotations;
    if (_r1_o == null) goto label44;
    _r1_o = new global::gnu.xml.dom.DomNamedNodeMap();
    _r2.i = 12;
    ((global::gnu.xml.dom.DomNamedNodeMap) _r1_o).@this((global::gnu.xml.dom.DomNode) _r0_o, (short) _r2.i);
    ((global::gnu.xml.dom.DomDoctype) _r0_o)._fnotations = (global::gnu.xml.dom.DomNamedNodeMap) _r1_o;
    _r1_o = ((global::gnu.xml.dom.DomDoctype) _r5_o)._fnotations;
    _r1_o = ((global::gnu.xml.dom.DomNamedNodeMap) _r1_o)._ffirst;
    label42:;
    if (_r1_o != null) goto label57;
    label44:;
    return (global::java.lang.Object) _r0_o;
    label45:;
    _r2_o = ((global::gnu.xml.dom.DomDoctype) _r0_o)._fentities;
    _r3_o = ((global::gnu.xml.dom.DomNode) _r1_o).cloneNode(0!=_r4.i);
    ((global::gnu.xml.dom.DomNamedNodeMap) _r2_o).setNamedItem((global::org.w3c.dom.Node) _r3_o);
    _r1_o = ((global::gnu.xml.dom.DomNode) _r1_o)._fnext;
    goto label23;
    label57:;
    _r2_o = ((global::gnu.xml.dom.DomDoctype) _r0_o)._fnotations;
    _r3_o = ((global::gnu.xml.dom.DomNode) _r1_o).cloneNode(0!=_r4.i);
    ((global::gnu.xml.dom.DomNamedNodeMap) _r2_o).setNamedItem((global::org.w3c.dom.Node) _r3_o);
    _r1_o = ((global::gnu.xml.dom.DomNode) _r1_o)._fnext;
    goto label42;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype: java.lang.Object clone()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDoctype]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDoctype]

} // end of class: DomDoctype

} // end of namespace: gnu.xml.dom
