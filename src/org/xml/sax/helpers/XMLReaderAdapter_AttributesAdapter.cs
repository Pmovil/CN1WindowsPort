// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax.helpers {
public class XMLReaderAdapter_2AttributesAdapter: global::java.lang.Object,global::org.xml.sax.AttributeList {
private global::org.xml.sax.Attributes _fattributes;

public global::org.xml.sax.helpers.XMLReaderAdapter _fthis_20;

public void @this(global::org.xml.sax.helpers.XMLReaderAdapter n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: void <init>(org.xml.sax.helpers.XMLReaderAdapter)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r0_o)._fthis_20 = (global::org.xml.sax.helpers.XMLReaderAdapter) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: void <init>(org.xml.sax.helpers.XMLReaderAdapter)]
}

public virtual void setAttributes(global::org.xml.sax.Attributes n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: void setAttributes(org.xml.sax.Attributes)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r0_o)._fattributes = (global::org.xml.sax.Attributes) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: void setAttributes(org.xml.sax.Attributes)]
}

public virtual int getLength(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: int getLength()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r1_o)._fattributes;
    _r0.i = ((global::org.xml.sax.Attributes) _r0_o).getLength();
    return _r0.i;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: int getLength()]
}

public virtual global::System.Object getName(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getName(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r1_o)._fattributes;
    _r0_o = ((global::org.xml.sax.Attributes) _r0_o).getQName((int) _r2.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getName(int)]
}

public virtual global::System.Object getType(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getType(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r1_o)._fattributes;
    _r0_o = ((global::org.xml.sax.Attributes) _r0_o).getType((int) _r2.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getType(int)]
}

public virtual global::System.Object getValue(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getValue(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r1_o)._fattributes;
    _r0_o = ((global::org.xml.sax.Attributes) _r0_o).getValue((int) _r2.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getValue(int)]
}

public virtual global::System.Object getType(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getType(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r1_o)._fattributes;
    _r0_o = ((global::org.xml.sax.Attributes) _r0_o).getType((global::java.lang.String) _r2_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getType(java.lang.String)]
}

public virtual global::System.Object getValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getValue(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLReaderAdapter_2AttributesAdapter) _r1_o)._fattributes;
    _r0_o = ((global::org.xml.sax.Attributes) _r0_o).getValue((global::java.lang.String) _r2_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter: java.lang.String getValue(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter]
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderAdapter$AttributesAdapter]

} // end of class: XMLReaderAdapter_2AttributesAdapter

} // end of namespace: org.xml.sax.helpers
