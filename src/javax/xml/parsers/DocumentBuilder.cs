// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace javax.xml.parsers {
public abstract class DocumentBuilder: global::java.lang.Object {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: void <init>()]
}

public virtual global::System.Object parse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != null) goto label10;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=input stream is null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label10:;
    _r0_o = new global::org.xml.sax.InputSource();
    ((global::org.xml.sax.InputSource) _r0_o).@this((global::java.io.InputStream) _r3_o);
    _r0_o = ((global::javax.xml.parsers.DocumentBuilder) _r2_o).parse((global::org.xml.sax.InputSource) _r0_o);
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream)]
}

public virtual global::System.Object parse(global::java.io.InputStream n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    if (_r3_o != null) goto label10;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=input stream is null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label10:;
    _r0_o = new global::org.xml.sax.InputSource();
    ((global::org.xml.sax.InputSource) _r0_o).@this((global::java.io.InputStream) _r3_o);
    ((global::org.xml.sax.InputSource) _r0_o).setSystemId((global::java.lang.String) _r4_o);
    _r0_o = ((global::javax.xml.parsers.DocumentBuilder) _r2_o).parse((global::org.xml.sax.InputSource) _r0_o);
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream, java.lang.String)]
}

public virtual global::System.Object parse(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != null) goto label10;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=URI is null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label10:;
    _r0_o = new global::org.xml.sax.InputSource();
    ((global::org.xml.sax.InputSource) _r0_o).@this((global::java.lang.String) _r3_o);
    _r0_o = ((global::javax.xml.parsers.DocumentBuilder) _r2_o).parse((global::org.xml.sax.InputSource) _r0_o);
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.lang.String)]
}

public virtual global::System.Object parse(global::java.io.File n1){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.io.File)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != null) goto label10;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=file is null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label10:;
    _r0_o = new global::org.xml.sax.InputSource();
    _r1_o = new global::java.io.FileInputStream();
    ((global::java.io.FileInputStream) _r1_o).@this((global::java.io.File) _r3_o);
    ((global::org.xml.sax.InputSource) _r0_o).@this((global::java.io.InputStream) _r1_o);
    _r1_o = ((global::java.io.File) _r3_o).toURL();
    _r1_o = ((global::java.net.URL) _r1_o).toString();
    ((global::org.xml.sax.InputSource) _r0_o).setSystemId((global::java.lang.String) _r1_o);
    _r0_o = ((global::javax.xml.parsers.DocumentBuilder) _r2_o).parse((global::org.xml.sax.InputSource) _r0_o);
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: org.w3c.dom.Document parse(java.io.File)]
}

public abstract global::System.Object parse(global::org.xml.sax.InputSource n1);

public abstract bool isNamespaceAware();

public abstract bool isValidating();

public abstract void setEntityResolver(global::org.xml.sax.EntityResolver n1);

public abstract void setErrorHandler(global::org.xml.sax.ErrorHandler n1);

public abstract global::System.Object newDocument();

public abstract global::System.Object getDOMImplementation();

public virtual void reset(){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: void reset()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    return;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: void reset()]
}

public virtual global::System.Object getSchema(){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: java.lang.Object getSchema()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: java.lang.Object getSchema()]
}

public virtual bool isXIncludeAware(){
//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder: boolean isXIncludeAware()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder: boolean isXIncludeAware()]
}

//XMLVM_BEGIN_WRAPPER[javax.xml.parsers.DocumentBuilder]
//XMLVM_END_WRAPPER[javax.xml.parsers.DocumentBuilder]

} // end of class: DocumentBuilder

} // end of namespace: javax.xml.parsers
