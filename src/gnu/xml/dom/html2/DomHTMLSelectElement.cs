// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.html2 {
public class DomHTMLSelectElement: global::gnu.xml.dom.html2.DomHTMLElement,global::org.w3c.dom.html2.HTMLSelectElement {
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

public void @this(global::gnu.xml.dom.html2.DomHTMLDocument n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::gnu.xml.dom.html2.DomHTMLElement) _r0_o).@this((global::gnu.xml.dom.html2.DomHTMLDocument) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getType(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: java.lang.String getType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=type
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: java.lang.String getType()]
}

public virtual int getSelectedIndex(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getSelectedIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r4_o).getOptions();
    _r1.i = ((global::org.w3c.dom.html2.HTMLOptionsCollection) _r0_o).getLength();
    _r2.i = 0;
    label9:;
    if (_r2.i < _r1.i) goto label13;
    _r0.i = -1;
    label12:;
    return _r0.i;
    label13:;
    _r4_o = ((global::org.w3c.dom.html2.HTMLOptionsCollection) _r0_o).item((int) _r2.i);
    _r3.i = ((global::org.w3c.dom.html2.HTMLOptionElement) _r4_o).getSelected() ? 1 : 0;
    if (_r3.i == 0) goto label27;
    _r0.i = _r2.i;
    goto label12;
    label27:;
    _r2.i = _r2.i + 1;
    goto label9;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getSelectedIndex()]
}

public virtual void setSelectedIndex(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setSelectedIndex(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = this;
    _r7.i = n1;
    _r5.i = 1;
    _r4.i = 0;
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r6_o).getOptions();
    _r1.i = ((global::org.w3c.dom.html2.HTMLOptionsCollection) _r0_o).getLength();
    if (_r7.i < 0) goto label14;
    if (_r7.i < _r1.i) goto label20;
    label14:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r5.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label20:;
    _r2.i = _r4.i;
    label21:;
    if (_r2.i < _r1.i) goto label24;
    return;
    label24:;
    _r6_o = ((global::org.w3c.dom.html2.HTMLOptionsCollection) _r0_o).item((int) _r2.i);
    if (_r2.i != _r7.i) goto label39;
    _r3.i = _r5.i;
    label33:;
    ((global::org.w3c.dom.html2.HTMLOptionElement) _r6_o).setSelected(0!=_r3.i);
    _r2.i = _r2.i + 1;
    goto label21;
    label39:;
    _r3.i = _r4.i;
    goto label33;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setSelectedIndex(int)]
}

public virtual global::System.Object getValue(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: java.lang.String getValue()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: java.lang.String getValue()]
}

public virtual void setValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setValue(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setValue(java.lang.String)]
}

public override int getLength(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getLength()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=length
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getIntHTMLAttribute((global::java.lang.String) _r0_o);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getLength()]
}

public virtual void setLength(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setLength(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    // Value=length
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setIntHTMLAttribute((global::java.lang.String) _r0_o, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setLength(int)]
}

public virtual global::System.Object getForm(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: org.w3c.dom.html2.HTMLFormElement getForm()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=form
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109))}));
    _r1_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getParentElement((global::java.lang.String) _r0_o);
    return (global::org.w3c.dom.html2.HTMLFormElement) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: org.w3c.dom.html2.HTMLFormElement getForm()]
}

public virtual global::System.Object getOptions(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: org.w3c.dom.html2.HTMLOptionsCollection getOptions()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = new global::gnu.xml.dom.html2.DomHTMLCollection();
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r2_o).getOwnerDocument();
    ((global::gnu.xml.dom.html2.DomHTMLCollection) _r1_o).@this((global::gnu.xml.dom.html2.DomHTMLDocument) _r0_o, (global::org.w3c.dom.Node) _r2_o);
    // Value=option
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::gnu.xml.dom.html2.DomHTMLCollection) _r1_o).addNodeName((global::java.lang.String) _r0_o);
    ((global::gnu.xml.dom.html2.DomHTMLCollection) _r1_o).evaluate();
    return (global::org.w3c.dom.html2.HTMLOptionsCollection) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: org.w3c.dom.html2.HTMLOptionsCollection getOptions()]
}

public virtual bool getDisabled(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: boolean getDisabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getBooleanHTMLAttribute((global::java.lang.String) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: boolean getDisabled()]
}

public virtual void setDisabled(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setDisabled(boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setBooleanHTMLAttribute((global::java.lang.String) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setDisabled(boolean)]
}

public virtual bool getMultiple(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: boolean getMultiple()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=multiple
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getBooleanHTMLAttribute((global::java.lang.String) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: boolean getMultiple()]
}

public virtual void setMultiple(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setMultiple(boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    // Value=multiple
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setBooleanHTMLAttribute((global::java.lang.String) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setMultiple(boolean)]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=name
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: java.lang.String getName()]
}

public virtual void setName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setName(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=name
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setName(java.lang.String)]
}

public virtual int getSize(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=size
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getIntHTMLAttribute((global::java.lang.String) _r0_o);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getSize()]
}

public virtual void setSize(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setSize(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    // Value=size
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setIntHTMLAttribute((global::java.lang.String) _r0_o, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setSize(int)]
}

public virtual int getTabIndex(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getTabIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=tabindex
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).getIntHTMLAttribute((global::java.lang.String) _r0_o);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: int getTabIndex()]
}

public virtual void setTabIndex(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setTabIndex(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    // Value=tabindex
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).setIntHTMLAttribute((global::java.lang.String) _r0_o, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void setTabIndex(int)]
}

public virtual void add(global::org.w3c.dom.html2.HTMLElement n1, global::org.w3c.dom.html2.HTMLElement n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void add(org.w3c.dom.html2.HTMLElement, org.w3c.dom.html2.HTMLElement)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r0_o).insertBefore((global::org.w3c.dom.Node) _r2_o, (global::org.w3c.dom.Node) _r1_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void add(org.w3c.dom.html2.HTMLElement, org.w3c.dom.html2.HTMLElement)]
}

public virtual void remove(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void remove(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r2_o).getOptions();
    _r1.i = ((global::org.w3c.dom.html2.HTMLOptionsCollection) _r0_o).getLength();
    if (_r3.i < 0) goto label12;
    if (_r3.i < _r1.i) goto label19;
    label12:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 1;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label19:;
    _r2_o = ((global::org.w3c.dom.html2.HTMLOptionsCollection) _r0_o).item((int) _r3.i);
    _r0_o = ((global::org.w3c.dom.html2.HTMLOptionElement) _r2_o).getParentNode();
    ((global::org.w3c.dom.Node) _r0_o).removeChild((global::org.w3c.dom.Node) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void remove(int)]
}

public virtual void blur(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void blur()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=blur
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).dispatchUIEvent((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void blur()]
}

public virtual void focus(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void focus()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=focus
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115))}));
    ((global::gnu.xml.dom.html2.DomHTMLSelectElement) _r1_o).dispatchUIEvent((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement: void focus()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement]
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLSelectElement]

} // end of class: DomHTMLSelectElement

} // end of namespace: gnu.xml.dom.html2
