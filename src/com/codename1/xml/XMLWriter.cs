// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.xml {
public class XMLWriter: global::java.lang.Object {

static XMLWriter() {
    @static();
}

private bool _fencodeText;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _fescapes;

public void @this(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.xml.XMLWriter: void <init>(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.xml.XMLWriter) _r0_o)._fencodeText = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.xml.XMLWriter: void <init>(boolean)]
}

public virtual void writeXML(global::java.io.Writer n1, global::com.codename1.xml.Element n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.xml.XMLWriter: void writeXML(java.io.Writer, com.codename1.xml.Element)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1.i = 0;
    ((global::com.codename1.xml.XMLWriter) _r2_o).writeXML((global::java.io.Writer) _r3_o, (global::com.codename1.xml.Element) _r4_o, (global::java.lang.StringBuilder) _r0_o, 0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.xml.XMLWriter: void writeXML(java.io.Writer, com.codename1.xml.Element)]
}

private void writeXML(global::java.io.Writer n1, global::com.codename1.xml.Element n2, global::java.lang.StringBuilder n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.xml.XMLWriter: void writeXML(java.io.Writer, com.codename1.xml.Element, java.lang.StringBuilder, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    _r11_o = this;
    _r12_o = n1;
    _r13_o = n2;
    _r14_o = n3;
    _r15.i = n4 ? 1 : 0;
    _r9.i = 62;
    _r8.i = 10;
    // Value=Element contained child of invalid type
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    if (_r15.i != 0) goto label15;
    _r7_o = ((global::java.lang.StringBuilder) _r14_o).toString();
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    label15:;
    _r7.i = ((global::com.codename1.xml.Element) _r13_o).isTextElement() ? 1 : 0;
    if (_r7.i == 0) goto label33;
    _r7_o = ((global::com.codename1.xml.Element) _r13_o).getText();
    _r7_o = ((global::com.codename1.xml.XMLWriter) _r11_o).encodeIfRequired((global::java.lang.String) _r7_o);
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    label32:;
    return;
    label33:;
    _r7.i = 60;
    ((global::java.io.Writer) _r12_o).write((int) _r7.i);
    _r7_o = ((global::com.codename1.xml.Element) _r13_o).getTagName();
    _r4_o = ((global::com.codename1.xml.XMLWriter) _r11_o).encodeIfRequired((global::java.lang.String) _r7_o);
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r4_o);
    _r2_o = ((global::com.codename1.xml.Element) _r13_o).getAttributes();
    if (_r2_o == null) goto label107;
    _r6_o = ((global::java.util.Hashtable) _r2_o).keys();
    label59:;
    _r7.i = ((global::java.util.Enumeration) _r6_o).hasMoreElements() ? 1 : 0;
    if (_r7.i == 0) goto label107;
    _r0_o = ((global::java.util.Enumeration) _r6_o).nextElement();
    _r1_o = ((global::java.util.Hashtable) _r2_o).get((global::java.lang.Object) _r0_o);
    _r7.i = 32;
    ((global::java.io.Writer) _r12_o).write((int) _r7.i);
    _r7_o = ((global::com.codename1.xml.XMLWriter) _r11_o).encodeIfRequired((global::java.lang.String) _r0_o);
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    // Value==\042
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)61)), unchecked((char) unchecked((uint) 34))}));
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    _r7_o = ((global::com.codename1.xml.XMLWriter) _r11_o).encodeIfRequired((global::java.lang.String) _r1_o);
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    _r7.i = 34;
    ((global::java.io.Writer) _r12_o).write((int) _r7.i);
    goto label59;
    label107:;
    _r7.i = ((global::com.codename1.xml.Element) _r13_o).isEmpty() ? 1 : 0;
    if (_r7.i == 0) goto label119;
    // Value= />
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 62))}));
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    goto label32;
    label119:;
    ((global::java.io.Writer) _r12_o).write((int) _r9.i);
    if (_r15.i != 0) goto label177;
    _r7.i = ((global::com.codename1.xml.Element) _r13_o).hasTextChild() ? 1 : 0;
    if (_r7.i != 0) goto label177;
    ((global::java.io.Writer) _r12_o).write((int) _r8.i);
    _r7.i = 9;
    ((global::java.lang.StringBuilder) _r14_o).append((char) _r7.i);
    _r7_o = ((global::com.codename1.xml.Element) _r13_o).getChildren();
    _r5_o = ((global::java.util.Vector) _r7_o).iterator();
    label146:;
    _r7.i = ((global::java.util.Iterator) _r5_o).hasNext() ? 1 : 0;
    if (_r7.i == 0) goto label215;
    _r3_o = ((global::java.util.Iterator) _r5_o).next();
    _r7.i = ((_r3_o != null) && (_r3_o is global::com.codename1.xml.Element)) ? 1 : 0;
    if (_r7.i == 0) goto label169;
    ((global::com.codename1.xml.XMLWriter) _r11_o).writeXML((global::java.io.Writer) _r12_o, (global::com.codename1.xml.Element) _r3_o, (global::java.lang.StringBuilder) _r14_o, 0!=_r15.i);
    ((global::java.io.Writer) _r12_o).write((int) _r8.i);
    goto label146;
    label169:;
    _r7_o = new global::java.lang.IllegalStateException();
    // Value=Element contained child of invalid type
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.lang.IllegalStateException) _r7_o).@this((global::java.lang.String) _r10_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r7_o);
    label177:;
    _r15.i = 1;
    _r7_o = ((global::com.codename1.xml.Element) _r13_o).getChildren();
    _r5_o = ((global::java.util.Vector) _r7_o).iterator();
    label186:;
    _r7.i = ((global::java.util.Iterator) _r5_o).hasNext() ? 1 : 0;
    if (_r7.i == 0) goto label215;
    _r3_o = ((global::java.util.Iterator) _r5_o).next();
    _r7.i = ((_r3_o != null) && (_r3_o is global::com.codename1.xml.Element)) ? 1 : 0;
    if (_r7.i == 0) goto label207;
    _r7_o = null;
    ((global::com.codename1.xml.XMLWriter) _r11_o).writeXML((global::java.io.Writer) _r12_o, (global::com.codename1.xml.Element) _r3_o, (global::java.lang.StringBuilder) _r7_o, 0!=_r15.i);
    goto label186;
    label207:;
    _r7_o = new global::java.lang.IllegalStateException();
    // Value=Element contained child of invalid type
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.lang.IllegalStateException) _r7_o).@this((global::java.lang.String) _r10_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r7_o);
    label215:;
    if (_r15.i != 0) goto label233;
    _r7.i = ((global::java.lang.StringBuilder) _r14_o).length();
    _r8.i = 1;
    _r7.i = _r7.i - _r8.i;
    ((global::java.lang.StringBuilder) _r14_o).deleteCharAt((int) _r7.i);
    _r7_o = ((global::java.lang.StringBuilder) _r14_o).toString();
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    label233:;
    // Value=</
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 47))}));
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r7_o);
    ((global::java.io.Writer) _r12_o).write((global::java.lang.String) _r4_o);
    ((global::java.io.Writer) _r12_o).write((int) _r9.i);
    goto label32;
//XMLVM_END_WRAPPER[com.codename1.xml.XMLWriter: void writeXML(java.io.Writer, com.codename1.xml.Element, java.lang.StringBuilder, boolean)]
}

private global::System.Object encodeIfRequired(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.xml.XMLWriter: java.lang.String encodeIfRequired(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r1.i = ((global::com.codename1.xml.XMLWriter) _r4_o)._fencodeText ? 1 : 0;
    if (_r1.i == 0) goto label31;
    _r0.i = 0;
    label5:;
    _r1_o = global::com.codename1.xml.XMLWriter._fescapes;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label31;
    _r1_o = global::com.codename1.xml.XMLWriter._fescapes;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    _r2.i = 0;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i];
    _r2_o = global::com.codename1.xml.XMLWriter._fescapes;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    _r3.i = 1;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r5_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r5_o, (global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    _r0.i = _r0.i + 1;
    goto label5;
    label31:;
    return (global::java.lang.String) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.xml.XMLWriter: java.lang.String encodeIfRequired(java.lang.String)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.xml.XMLWriter: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r6.i = 2;
    _r5.i = 1;
    _r4.i = 0;
    _r0.i = 5;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r6.i]);
    // Value=&
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)38))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i] = _r2_o;
    // Value=&amp;
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)38)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 59))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r5.i] = _r2_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r4.i] = _r1_o;
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r6.i]);
    // Value=\042
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i] = _r2_o;
    // Value=&quot;
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)38)), unchecked((char) unchecked((uint) 113)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 59))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r5.i] = _r2_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r5.i] = _r1_o;
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r6.i]);
    // Value=<
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i] = _r2_o;
    // Value=&lt;
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)38)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 59))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r5.i] = _r2_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r6.i] = _r1_o;
    _r1.i = 3;
    _r2_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r6.i]);
    // Value=>
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)62))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r4.i] = _r3_o;
    // Value=&gt;
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)38)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 59))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r5.i] = _r3_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 4;
    _r2_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r6.i]);
    // Value='
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)39))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r4.i] = _r3_o;
    // Value=&apos;
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)38)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 59))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r5.i] = _r3_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    global::com.codename1.xml.XMLWriter._fescapes = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.xml.XMLWriter: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.xml.XMLWriter]
//XMLVM_END_WRAPPER[com.codename1.xml.XMLWriter]

} // end of class: XMLWriter

} // end of namespace: com.codename1.xml
