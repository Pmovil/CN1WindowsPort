// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.stream {
public class XMLParser_2Doctype: global::java.lang.Object {
public global::java.lang.String _frootName;

public global::java.lang.String _fpublicId;

public global::java.lang.String _fsystemId;

private global::java.util.LinkedHashMap _felements;

private global::java.util.LinkedHashMap _fattlists;

private global::java.util.LinkedHashMap _fentities;

private global::java.util.LinkedHashMap _fnotations;

private global::java.util.LinkedHashMap _fcomments;

private global::java.util.LinkedHashMap _fpis;

private global::java.util.LinkedList _fentries;

private global::java.util.HashSet _fexternalEntities;

private global::java.util.HashSet _fexternalNotations;

private int _fanon;

public global::gnu.xml.stream.XMLParser _fthis_20;

public void @this(global::gnu.xml.stream.XMLParser n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void <init>(gnu.xml.stream.XMLParser, java.lang.String, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5_o = n4;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fthis_20 = (global::gnu.xml.stream.XMLParser) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._felements = (global::java.util.LinkedHashMap) _r0_o;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fattlists = (global::java.util.LinkedHashMap) _r0_o;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fentities = (global::java.util.LinkedHashMap) _r0_o;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fnotations = (global::java.util.LinkedHashMap) _r0_o;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fcomments = (global::java.util.LinkedHashMap) _r0_o;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fpis = (global::java.util.LinkedHashMap) _r0_o;
    _r0_o = new global::java.util.LinkedList();
    ((global::java.util.LinkedList) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fentries = (global::java.util.LinkedList) _r0_o;
    _r0_o = new global::java.util.HashSet();
    ((global::java.util.HashSet) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fexternalEntities = (global::java.util.HashSet) _r0_o;
    _r0_o = new global::java.util.HashSet();
    ((global::java.util.HashSet) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fexternalNotations = (global::java.util.HashSet) _r0_o;
    _r0.i = 1;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fanon = _r0.i;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._frootName = (global::java.lang.String) _r3_o;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fpublicId = (global::java.lang.String) _r4_o;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fsystemId = (global::java.lang.String) _r5_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void <init>(gnu.xml.stream.XMLParser, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual void addElementDecl(global::java.lang.String n1, global::java.lang.String n2, global::gnu.xml.stream.XMLParser_2ContentModel n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addElementDecl(java.lang.String, java.lang.String, gnu.xml.stream.XMLParser$ContentModel)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
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
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._felements;
    _r0.i = ((global::java.util.LinkedHashMap) _r0_o).containsKey((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label10;
    label9:;
    return;
    label10:;
    ((global::gnu.xml.stream.XMLParser_2ContentModel) _r6_o)._ftext = (global::java.lang.String) _r5_o;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fthis_20;
    _r0_o = global::gnu.xml.stream.XMLParser.access_2300((global::gnu.xml.stream.XMLParser) _r0_o);
    _r0.i = ((global::java.util.LinkedList) _r0_o).size();
    if (_r0.i == _r1.i) goto label57;
    _r0.i = _r1.i;
    label25:;
    ((global::gnu.xml.stream.XMLParser_2ContentModel) _r6_o)._fexternal = 0!=_r0.i;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._felements;
    ((global::java.util.LinkedHashMap) _r0_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r6_o);
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentries;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=E
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.util.LinkedList) _r0_o).add((global::java.lang.Object) _r1_o);
    goto label9;
    label57:;
    _r0.i = 0;
    goto label25;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addElementDecl(java.lang.String, java.lang.String, gnu.xml.stream.XMLParser$ContentModel)]
}

public virtual void addAttributeDecl(global::java.lang.String n1, global::java.lang.String n2, global::gnu.xml.stream.XMLParser_2AttributeDecl n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addAttributeDecl(java.lang.String, java.lang.String, gnu.xml.stream.XMLParser$AttributeDecl)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r2_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fattlists;
    _r0_o = ((global::java.util.LinkedHashMap) _r2_o).get((global::java.lang.Object) _r5_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label56;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    _r2_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fattlists;
    ((global::java.util.LinkedHashMap) _r2_o).put((global::java.lang.Object) _r5_o, (global::java.lang.Object) _r0_o);
    label20:;
    ((global::java.util.LinkedHashMap) _r0_o).put((global::java.lang.Object) _r6_o, (global::java.lang.Object) _r7_o);
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=A
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r5_o);
    _r1_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    _r2_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fentries;
    _r2.i = ((global::java.util.LinkedList) _r2_o).contains((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r2.i != 0) goto label55;
    _r2_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fentries;
    ((global::java.util.LinkedList) _r2_o).add((global::java.lang.Object) _r1_o);
    label55:;
    return;
    label56:;
    _r2.i = ((global::java.util.LinkedHashMap) _r0_o).containsKey((global::java.lang.Object) _r6_o) ? 1 : 0;
    if (_r2.i == 0) goto label20;
    goto label55;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addAttributeDecl(java.lang.String, java.lang.String, gnu.xml.stream.XMLParser$AttributeDecl)]
}

public virtual void addEntityDecl(global::java.lang.String n1, global::java.lang.String n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addEntityDecl(java.lang.String, java.lang.String, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3 ? 1 : 0;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentities;
    _r0.i = ((global::java.util.LinkedHashMap) _r0_o).containsKey((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label9;
    label8:;
    return;
    label9:;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentities;
    ((global::java.util.LinkedHashMap) _r0_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r5_o);
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentries;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=e
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.util.LinkedList) _r0_o).add((global::java.lang.Object) _r1_o);
    if (_r6.i == 0) goto label8;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fexternalEntities;
    ((global::java.util.HashSet) _r0_o).add((global::java.lang.Object) _r4_o);
    goto label8;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addEntityDecl(java.lang.String, java.lang.String, boolean)]
}

public virtual void addEntityDecl(global::java.lang.String n1, global::gnu.xml.stream.XMLParser_2ExternalIds n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addEntityDecl(java.lang.String, gnu.xml.stream.XMLParser$ExternalIds, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3 ? 1 : 0;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentities;
    _r0.i = ((global::java.util.LinkedHashMap) _r0_o).containsKey((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label9;
    label8:;
    return;
    label9:;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentities;
    ((global::java.util.LinkedHashMap) _r0_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r5_o);
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentries;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=e
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.util.LinkedList) _r0_o).add((global::java.lang.Object) _r1_o);
    if (_r6.i == 0) goto label8;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fexternalEntities;
    ((global::java.util.HashSet) _r0_o).add((global::java.lang.Object) _r4_o);
    goto label8;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addEntityDecl(java.lang.String, gnu.xml.stream.XMLParser$ExternalIds, boolean)]
}

public virtual void addNotationDecl(global::java.lang.String n1, global::gnu.xml.stream.XMLParser_2ExternalIds n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addNotationDecl(java.lang.String, gnu.xml.stream.XMLParser$ExternalIds, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3 ? 1 : 0;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fnotations;
    _r0.i = ((global::java.util.LinkedHashMap) _r0_o).containsKey((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label9;
    label8:;
    return;
    label9:;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fnotations;
    ((global::java.util.LinkedHashMap) _r0_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r5_o);
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fentries;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=n
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.util.LinkedList) _r0_o).add((global::java.lang.Object) _r1_o);
    if (_r6.i == 0) goto label8;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r3_o)._fexternalNotations;
    ((global::java.util.HashSet) _r0_o).add((global::java.lang.Object) _r4_o);
    goto label8;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addNotationDecl(java.lang.String, gnu.xml.stream.XMLParser$ExternalIds, boolean)]
}

public virtual void addComment(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addComment(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r1.i = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fanon;
    _r2.i = _r1.i + 1;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fanon = _r2.i;
    _r0_o = global::java.lang.Integer.toString((int) _r1.i);
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fcomments;
    ((global::java.util.LinkedHashMap) _r1_o).put((global::java.lang.Object) _r0_o, (global::java.lang.Object) _r5_o);
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fentries;
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=c
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.util.LinkedList) _r1_o).add((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addComment(java.lang.String)]
}

public virtual void addPI(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addPI(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r1.i = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fanon;
    _r2.i = _r1.i + 1;
    ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fanon = _r2.i;
    _r0_o = global::java.lang.Integer.toString((int) _r1.i);
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fpis;
    _r2.i = 2;
    _r2_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r2.i]);
    _r3.i = 0;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i] = _r5_o;
    _r3.i = 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i] = _r6_o;
    ((global::java.util.LinkedHashMap) _r1_o).put((global::java.lang.Object) _r0_o, (global::java.lang.Object) _r2_o);
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r4_o)._fentries;
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=p
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.util.LinkedList) _r1_o).add((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: void addPI(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getElementModel(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: gnu.xml.stream.XMLParser$ContentModel getElementModel(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._felements;
    _r1_o = ((global::java.util.LinkedHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    _r1_o = _r1_o;
    return (global::gnu.xml.stream.XMLParser_2ContentModel) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: gnu.xml.stream.XMLParser$ContentModel getElementModel(java.lang.String)]
}

public virtual global::System.Object getAttributeDecl(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: gnu.xml.stream.XMLParser$AttributeDecl getAttributeDecl(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r2_o)._fattlists;
    _r0_o = ((global::java.util.LinkedHashMap) _r1_o).get((global::java.lang.Object) _r3_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label12;
    _r1_o = null;
    label11:;
    return (global::gnu.xml.stream.XMLParser_2AttributeDecl) _r1_o;
    label12:;
    _r2_o = ((global::java.util.LinkedHashMap) _r0_o).get((global::java.lang.Object) _r4_o);
    _r2_o = _r2_o;
    _r1_o = _r2_o;
    goto label11;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: gnu.xml.stream.XMLParser$AttributeDecl getAttributeDecl(java.lang.String, java.lang.String)]
}

public virtual bool isAttributeDeclared(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: boolean isAttributeDeclared(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r2_o)._fattlists;
    _r0_o = ((global::java.util.LinkedHashMap) _r1_o).get((global::java.lang.Object) _r3_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label12;
    _r1.i = 0;
    label11:;
    return _r1.i!=0;
    label12:;
    _r1.i = ((global::java.util.LinkedHashMap) _r0_o).containsKey((global::java.lang.Object) _r4_o) ? 1 : 0;
    goto label11;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: boolean isAttributeDeclared(java.lang.String, java.lang.String)]
}

public virtual global::System.Object attlistIterator(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.util.Iterator attlistIterator(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r1_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r2_o)._fattlists;
    _r0_o = ((global::java.util.LinkedHashMap) _r1_o).get((global::java.lang.Object) _r3_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label17;
    _r1_o = global::java.util.Collections._fEMPTY_1LIST;
    _r1_o = ((global::java.util.List) _r1_o).iterator();
    label16:;
    return (global::java.util.Iterator) _r1_o;
    label17:;
    _r1_o = ((global::java.util.LinkedHashMap) _r0_o).entrySet();
    _r1_o = ((global::java.util.Set) _r1_o).iterator();
    goto label16;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.util.Iterator attlistIterator(java.lang.String)]
}

public virtual global::System.Object getEntity(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.lang.Object getEntity(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fentities;
    _r0_o = ((global::java.util.LinkedHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.lang.Object getEntity(java.lang.String)]
}

public virtual bool isEntityExternal(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: boolean isEntityExternal(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fexternalEntities;
    _r0.i = ((global::java.util.HashSet) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: boolean isEntityExternal(java.lang.String)]
}

public virtual global::System.Object entityIterator(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.util.Iterator entityIterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fentities;
    _r0_o = ((global::java.util.LinkedHashMap) _r0_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.util.Iterator entityIterator()]
}

public virtual global::System.Object getNotation(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: gnu.xml.stream.XMLParser$ExternalIds getNotation(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fnotations;
    _r1_o = ((global::java.util.LinkedHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    _r1_o = _r1_o;
    return (global::gnu.xml.stream.XMLParser_2ExternalIds) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: gnu.xml.stream.XMLParser$ExternalIds getNotation(java.lang.String)]
}

public virtual bool isNotationExternal(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: boolean isNotationExternal(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fexternalNotations;
    _r0.i = ((global::java.util.HashSet) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: boolean isNotationExternal(java.lang.String)]
}

public virtual global::System.Object getComment(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.lang.String getComment(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fcomments;
    _r1_o = ((global::java.util.LinkedHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    _r1_o = _r1_o;
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.lang.String getComment(java.lang.String)]
}

public virtual global::System.Object getPI(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.lang.String[] getPI(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fpis;
    _r1_o = ((global::java.util.LinkedHashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    _r1_o = _r1_o;
    _r1_o = _r1_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.lang.String[] getPI(java.lang.String)]
}

public virtual global::System.Object entryIterator(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.util.Iterator entryIterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2Doctype) _r1_o)._fentries;
    _r0_o = ((global::java.util.LinkedList) _r0_o).iterator();
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype: java.util.Iterator entryIterator()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$Doctype]
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$Doctype]

} // end of class: XMLParser_2Doctype

} // end of namespace: gnu.xml.stream
