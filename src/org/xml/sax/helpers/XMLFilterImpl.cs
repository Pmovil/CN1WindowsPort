// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax.helpers {
public class XMLFilterImpl: global::java.lang.Object,global::org.xml.sax.XMLFilter,global::org.xml.sax.EntityResolver,global::org.xml.sax.DTDHandler,global::org.xml.sax.ContentHandler,global::org.xml.sax.ErrorHandler {
private global::org.xml.sax.XMLReader _fparent;

private global::org.xml.sax.Locator _flocator;

private global::org.xml.sax.EntityResolver _fentityResolver;

private global::org.xml.sax.DTDHandler _fdtdHandler;

private global::org.xml.sax.ContentHandler _fcontentHandler;

private global::org.xml.sax.ErrorHandler _ferrorHandler;

public void @this(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fparent = (global::org.xml.sax.XMLReader) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._flocator = (global::org.xml.sax.Locator) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fentityResolver = (global::org.xml.sax.EntityResolver) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler = (global::org.xml.sax.DTDHandler) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler = (global::org.xml.sax.ContentHandler) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler = (global::org.xml.sax.ErrorHandler) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void <init>()]
}

public void @this(global::org.xml.sax.XMLReader n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void <init>(org.xml.sax.XMLReader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fparent = (global::org.xml.sax.XMLReader) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._flocator = (global::org.xml.sax.Locator) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fentityResolver = (global::org.xml.sax.EntityResolver) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler = (global::org.xml.sax.DTDHandler) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler = (global::org.xml.sax.ContentHandler) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler = (global::org.xml.sax.ErrorHandler) _r0_o;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o).setParent((global::org.xml.sax.XMLReader) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void <init>(org.xml.sax.XMLReader)]
}

public virtual void setParent(global::org.xml.sax.XMLReader n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setParent(org.xml.sax.XMLReader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r0_o)._fparent = (global::org.xml.sax.XMLReader) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setParent(org.xml.sax.XMLReader)]
}

public virtual global::System.Object getParent(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.XMLReader getParent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fparent;
    return (global::org.xml.sax.XMLReader) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.XMLReader getParent()]
}

public virtual void setFeature(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setFeature(java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2 ? 1 : 0;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    if (_r0_o == null) goto label10;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).setFeature((global::java.lang.String) _r4_o, 0!=_r5.i);
    return;
    label10:;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    _r1_o = new global::java.lang.StringBuilder();
    // Value=Feature: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r1_o).@this((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setFeature(java.lang.String, boolean)]
}

public virtual bool getFeature(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: boolean getFeature(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    if (_r0_o == null) goto label11;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    _r0.i = ((global::org.xml.sax.XMLReader) _r0_o).getFeature((global::java.lang.String) _r4_o) ? 1 : 0;
    return _r0.i!=0;
    label11:;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    _r1_o = new global::java.lang.StringBuilder();
    // Value=Feature: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r1_o).@this((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: boolean getFeature(java.lang.String)]
}

public virtual void setProperty(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setProperty(java.lang.String, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    if (_r0_o == null) goto label10;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).setProperty((global::java.lang.String) _r4_o, (global::java.lang.Object) _r5_o);
    return;
    label10:;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    _r1_o = new global::java.lang.StringBuilder();
    // Value=Property: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r1_o).@this((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setProperty(java.lang.String, java.lang.Object)]
}

public virtual global::System.Object getProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: java.lang.Object getProperty(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    if (_r0_o == null) goto label11;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r3_o)._fparent;
    _r0_o = ((global::org.xml.sax.XMLReader) _r0_o).getProperty((global::java.lang.String) _r4_o);
    return (global::java.lang.Object) _r0_o;
    label11:;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    _r1_o = new global::java.lang.StringBuilder();
    // Value=Property: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r1_o).@this((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: java.lang.Object getProperty(java.lang.String)]
}

public virtual void setEntityResolver(global::org.xml.sax.EntityResolver n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setEntityResolver(org.xml.sax.EntityResolver)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r0_o)._fentityResolver = (global::org.xml.sax.EntityResolver) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setEntityResolver(org.xml.sax.EntityResolver)]
}

public virtual global::System.Object getEntityResolver(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.EntityResolver getEntityResolver()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fentityResolver;
    return (global::org.xml.sax.EntityResolver) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.EntityResolver getEntityResolver()]
}

public virtual void setDTDHandler(global::org.xml.sax.DTDHandler n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setDTDHandler(org.xml.sax.DTDHandler)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r0_o)._fdtdHandler = (global::org.xml.sax.DTDHandler) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setDTDHandler(org.xml.sax.DTDHandler)]
}

public virtual global::System.Object getDTDHandler(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.DTDHandler getDTDHandler()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler;
    return (global::org.xml.sax.DTDHandler) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.DTDHandler getDTDHandler()]
}

public virtual void setContentHandler(global::org.xml.sax.ContentHandler n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setContentHandler(org.xml.sax.ContentHandler)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r0_o)._fcontentHandler = (global::org.xml.sax.ContentHandler) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setContentHandler(org.xml.sax.ContentHandler)]
}

public virtual global::System.Object getContentHandler(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.ContentHandler getContentHandler()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    return (global::org.xml.sax.ContentHandler) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.ContentHandler getContentHandler()]
}

public virtual void setErrorHandler(global::org.xml.sax.ErrorHandler n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setErrorHandler(org.xml.sax.ErrorHandler)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r0_o)._ferrorHandler = (global::org.xml.sax.ErrorHandler) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setErrorHandler(org.xml.sax.ErrorHandler)]
}

public virtual global::System.Object getErrorHandler(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.ErrorHandler getErrorHandler()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    return (global::org.xml.sax.ErrorHandler) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.ErrorHandler getErrorHandler()]
}

public virtual void parse(global::org.xml.sax.InputSource n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void parse(org.xml.sax.InputSource)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o).setupParse();
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).parse((global::org.xml.sax.InputSource) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void parse(org.xml.sax.InputSource)]
}

public virtual void parse(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void parse(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::org.xml.sax.InputSource();
    ((global::org.xml.sax.InputSource) _r0_o).@this((global::java.lang.String) _r2_o);
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o).parse((global::org.xml.sax.InputSource) _r0_o);
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void parse(java.lang.String)]
}

public virtual global::System.Object resolveEntity(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.InputSource resolveEntity(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fentityResolver;
    if (_r0_o == null) goto label11;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fentityResolver;
    _r0_o = ((global::org.xml.sax.EntityResolver) _r0_o).resolveEntity((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    label10:;
    return (global::org.xml.sax.InputSource) _r0_o;
    label11:;
    _r0_o = null;
    goto label10;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: org.xml.sax.InputSource resolveEntity(java.lang.String, java.lang.String)]
}

public virtual void notationDecl(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void notationDecl(java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler;
    ((global::org.xml.sax.DTDHandler) _r0_o).notationDecl((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void notationDecl(java.lang.String, java.lang.String, java.lang.String)]
}

public virtual void unparsedEntityDecl(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void unparsedEntityDecl(java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
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
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fdtdHandler;
    ((global::org.xml.sax.DTDHandler) _r0_o).unparsedEntityDecl((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void unparsedEntityDecl(java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual void setDocumentLocator(global::org.xml.sax.Locator n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setDocumentLocator(org.xml.sax.Locator)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._flocator = (global::org.xml.sax.Locator) _r2_o;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label11;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).setDocumentLocator((global::org.xml.sax.Locator) _r2_o);
    label11:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setDocumentLocator(org.xml.sax.Locator)]
}

public virtual void startDocument(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void startDocument()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).startDocument();
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void startDocument()]
}

public virtual void endDocument(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void endDocument()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).endDocument();
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void endDocument()]
}

public virtual void startPrefixMapping(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void startPrefixMapping(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).startPrefixMapping((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void startPrefixMapping(java.lang.String, java.lang.String)]
}

public virtual void endPrefixMapping(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void endPrefixMapping(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).endPrefixMapping((global::java.lang.String) _r2_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void endPrefixMapping(java.lang.String)]
}

public virtual void startElement(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::org.xml.sax.Attributes n4){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void startElement(java.lang.String, java.lang.String, java.lang.String, org.xml.sax.Attributes)]
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
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).startElement((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::org.xml.sax.Attributes) _r5_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void startElement(java.lang.String, java.lang.String, java.lang.String, org.xml.sax.Attributes)]
}

public virtual void endElement(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void endElement(java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).endElement((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void endElement(java.lang.String, java.lang.String, java.lang.String)]
}

public virtual void characters(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void characters(char[], int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).characters((global::org.xmlvm._nArrayAdapter<char>) _r2_o, (int) _r3.i, (int) _r4.i);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void characters(char[], int, int)]
}

public virtual void ignorableWhitespace(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void ignorableWhitespace(char[], int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).ignorableWhitespace((global::org.xmlvm._nArrayAdapter<char>) _r2_o, (int) _r3.i, (int) _r4.i);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void ignorableWhitespace(char[], int, int)]
}

public virtual void processingInstruction(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void processingInstruction(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).processingInstruction((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void processingInstruction(java.lang.String, java.lang.String)]
}

public virtual void skippedEntity(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void skippedEntity(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._fcontentHandler;
    ((global::org.xml.sax.ContentHandler) _r0_o).skippedEntity((global::java.lang.String) _r2_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void skippedEntity(java.lang.String)]
}

public virtual void warning(global::org.xml.sax.SAXParseException n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void warning(org.xml.sax.SAXParseException)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    ((global::org.xml.sax.ErrorHandler) _r0_o).warning((global::org.xml.sax.SAXParseException) _r2_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void warning(org.xml.sax.SAXParseException)]
}

public virtual void error(global::org.xml.sax.SAXParseException n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void error(org.xml.sax.SAXParseException)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    ((global::org.xml.sax.ErrorHandler) _r0_o).error((global::org.xml.sax.SAXParseException) _r2_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void error(org.xml.sax.SAXParseException)]
}

public virtual void fatalError(global::org.xml.sax.SAXParseException n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void fatalError(org.xml.sax.SAXParseException)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r1_o)._ferrorHandler;
    ((global::org.xml.sax.ErrorHandler) _r0_o).fatalError((global::org.xml.sax.SAXParseException) _r2_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void fatalError(org.xml.sax.SAXParseException)]
}

private void setupParse(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setupParse()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r2_o)._fparent;
    if (_r0_o != null) goto label12;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=No parent for filter
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label12:;
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r2_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).setEntityResolver((global::org.xml.sax.EntityResolver) _r2_o);
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r2_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).setDTDHandler((global::org.xml.sax.DTDHandler) _r2_o);
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r2_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).setContentHandler((global::org.xml.sax.ContentHandler) _r2_o);
    _r0_o = ((global::org.xml.sax.helpers.XMLFilterImpl) _r2_o)._fparent;
    ((global::org.xml.sax.XMLReader) _r0_o).setErrorHandler((global::org.xml.sax.ErrorHandler) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl: void setupParse()]
}

//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLFilterImpl]
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLFilterImpl]

} // end of class: XMLFilterImpl

} // end of namespace: org.xml.sax.helpers
