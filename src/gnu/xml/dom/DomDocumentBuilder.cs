// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomDocumentBuilder: global::javax.xml.parsers.DocumentBuilder {
public global::org.w3c.dom.DOMImplementation _fimpl;

public global::org.w3c.dom.ls.DOMImplementationLS _fls;

public global::org.w3c.dom.ls.LSParser _fparser;

public void @this(global::org.w3c.dom.DOMImplementation n1, global::org.w3c.dom.ls.DOMImplementationLS n2, global::org.w3c.dom.ls.LSParser n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: void <init>(org.w3c.dom.DOMImplementation, org.w3c.dom.ls.DOMImplementationLS, org.w3c.dom.ls.LSParser)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::javax.xml.parsers.DocumentBuilder) _r0_o).@this();
    ((global::gnu.xml.dom.DomDocumentBuilder) _r0_o)._fimpl = (global::org.w3c.dom.DOMImplementation) _r1_o;
    ((global::gnu.xml.dom.DomDocumentBuilder) _r0_o)._fls = (global::org.w3c.dom.ls.DOMImplementationLS) _r2_o;
    ((global::gnu.xml.dom.DomDocumentBuilder) _r0_o)._fparser = (global::org.w3c.dom.ls.LSParser) _r3_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: void <init>(org.w3c.dom.DOMImplementation, org.w3c.dom.ls.DOMImplementationLS, org.w3c.dom.ls.LSParser)]
}

public override bool isNamespaceAware(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: boolean isNamespaceAware()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r0_o).getDomConfig();
    // Value=namespaces
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r2_o = ((global::org.w3c.dom.DOMConfiguration) _r0_o).getParameter((global::java.lang.String) _r1_o);
    _r0.i = ((global::java.lang.Boolean) _r2_o).booleanValue() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: boolean isNamespaceAware()]
}

public override bool isValidating(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: boolean isValidating()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r0_o).getDomConfig();
    // Value=validating
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    _r2_o = ((global::org.w3c.dom.DOMConfiguration) _r0_o).getParameter((global::java.lang.String) _r1_o);
    _r0.i = ((global::java.lang.Boolean) _r2_o).booleanValue() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: boolean isValidating()]
}

public override bool isXIncludeAware(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: boolean isXIncludeAware()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r0_o).getDomConfig();
    // Value=xinclude-aware
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    _r2_o = ((global::org.w3c.dom.DOMConfiguration) _r0_o).getParameter((global::java.lang.String) _r1_o);
    _r0.i = ((global::java.lang.Boolean) _r2_o).booleanValue() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: boolean isXIncludeAware()]
}

public override void setEntityResolver(global::org.xml.sax.EntityResolver n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: void setEntityResolver(org.xml.sax.EntityResolver)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r0_o).getDomConfig();
    // Value=entity-resolver
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::org.w3c.dom.DOMConfiguration) _r0_o).setParameter((global::java.lang.String) _r1_o, (global::java.lang.Object) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: void setEntityResolver(org.xml.sax.EntityResolver)]
}

public override void setErrorHandler(global::org.xml.sax.ErrorHandler n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: void setErrorHandler(org.xml.sax.ErrorHandler)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r0_o).getDomConfig();
    // Value=error-handler
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::org.w3c.dom.DOMConfiguration) _r0_o).setParameter((global::java.lang.String) _r1_o, (global::java.lang.Object) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: void setErrorHandler(org.xml.sax.ErrorHandler)]
}

public override global::System.Object getDOMImplementation(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.DOMImplementation getDOMImplementation()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r1_o)._fimpl;
    return (global::org.w3c.dom.DOMImplementation) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.DOMImplementation getDOMImplementation()]
}

public override global::System.Object newDocument(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document newDocument()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = null;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fimpl;
    _r0_o = ((global::org.w3c.dom.DOMImplementation) _r0_o).createDocument((global::java.lang.String) _r1_o, (global::java.lang.String) _r1_o, (global::org.w3c.dom.DocumentType) _r1_o);
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document newDocument()]
}

public override global::System.Object parse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fls;
    _r0_o = ((global::org.w3c.dom.ls.DOMImplementationLS) _r0_o).createLSInput();
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setByteStream((global::java.io.InputStream) _r3_o);
    try {
    _r1_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r1_o).parse((global::org.w3c.dom.ls.LSInput) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::org.w3c.dom.ls.LSException) {
            _ex = ex;
            goto label16;
        }
        throw ex;
    } // end catch
    return (global::org.w3c.dom.Document) _r0_o;
    label16:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r2_o = ((global::org.w3c.dom.ls.LSException) _r0_o).getCause();
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.io.IOException)) ? 1 : 0;
    if (_r1.i == 0) goto label28;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r2_o);
    label28:;
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream)]
}

public override global::System.Object parse(global::java.io.InputStream n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fls;
    _r0_o = ((global::org.w3c.dom.ls.DOMImplementationLS) _r0_o).createLSInput();
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setByteStream((global::java.io.InputStream) _r3_o);
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setSystemId((global::java.lang.String) _r4_o);
    try {
    _r1_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r1_o).parse((global::org.w3c.dom.ls.LSInput) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::org.w3c.dom.ls.LSException) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    return (global::org.w3c.dom.Document) _r0_o;
    label19:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r2_o = ((global::org.w3c.dom.ls.LSException) _r0_o).getCause();
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.io.IOException)) ? 1 : 0;
    if (_r1.i == 0) goto label31;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r2_o);
    label31:;
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(java.io.InputStream, java.lang.String)]
}

public override global::System.Object parse(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    try {
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r2_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r0_o).parseURI((global::java.lang.String) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::org.w3c.dom.ls.LSException) {
            _ex = ex;
            goto label7;
        }
        throw ex;
    } // end catch
    return (global::org.w3c.dom.Document) _r0_o;
    label7:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r2_o = ((global::org.w3c.dom.ls.LSException) _r0_o).getCause();
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.io.IOException)) ? 1 : 0;
    if (_r1.i == 0) goto label19;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r2_o);
    label19:;
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(java.lang.String)]
}

public override global::System.Object parse(global::org.xml.sax.InputSource n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(org.xml.sax.InputSource)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r4_o)._fls;
    _r0_o = ((global::org.w3c.dom.ls.DOMImplementationLS) _r0_o).createLSInput();
    _r1_o = ((global::org.xml.sax.InputSource) _r5_o).getSystemId();
    _r2_o = ((global::org.xml.sax.InputSource) _r5_o).getByteStream();
    if (_r2_o == null) goto label43;
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setByteStream((global::java.io.InputStream) _r2_o);
    label19:;
    _r2_o = ((global::org.xml.sax.InputSource) _r5_o).getPublicId();
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setPublicId((global::java.lang.String) _r2_o);
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setSystemId((global::java.lang.String) _r1_o);
    _r1_o = ((global::org.xml.sax.InputSource) _r5_o).getEncoding();
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setEncoding((global::java.lang.String) _r1_o);
    try {
    _r1_o = ((global::gnu.xml.dom.DomDocumentBuilder) _r4_o)._fparser;
    _r0_o = ((global::org.w3c.dom.ls.LSParser) _r1_o).parse((global::org.w3c.dom.ls.LSInput) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::org.w3c.dom.ls.LSException) {
            _ex = ex;
            goto label95;
        }
        throw ex;
    } // end catch
    return (global::org.w3c.dom.Document) _r0_o;
    label43:;
    _r2_o = ((global::org.xml.sax.InputSource) _r5_o).getCharacterStream();
    if (_r2_o == null) goto label53;
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setCharacterStream((global::java.io.Reader) _r2_o);
    goto label19;
    label53:;
    try {
    _r2_o = new global::java.net.URL();
    ((global::java.net.URL) _r2_o).@this((global::java.lang.String) _r1_o);
    _r2_o = ((global::java.net.URL) _r2_o).openStream();
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setByteStream((global::java.io.InputStream) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.MalformedURLException) {
            _ex = ex;
            goto label66;
        }
        throw ex;
    } // end catch
    goto label19;
    label66:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    _r2_o = new global::java.io.File();
    // Value=user.dir
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 114))}));
    _r3_o = global::java.lang.System.getProperty((global::java.lang.String) _r3_o);
    ((global::java.io.File) _r2_o).@this((global::java.lang.String) _r3_o);
    _r3_o = new global::java.net.URL();
    _r2_o = ((global::java.io.File) _r2_o).toURL();
    ((global::java.net.URL) _r3_o).@this((global::java.net.URL) _r2_o, (global::java.lang.String) _r1_o);
    _r2_o = ((global::java.net.URL) _r3_o).openStream();
    ((global::org.w3c.dom.ls.LSInput) _r0_o).setByteStream((global::java.io.InputStream) _r2_o);
    goto label19;
    label95:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r4_o = ((global::org.w3c.dom.ls.LSException) _r0_o).getCause();
    _r1.i = ((_r4_o != null) && (_r4_o is global::java.io.IOException)) ? 1 : 0;
    if (_r1.i == 0) goto label107;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r4_o);
    label107:;
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder: org.w3c.dom.Document parse(org.xml.sax.InputSource)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomDocumentBuilder]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomDocumentBuilder]

} // end of class: DomDocumentBuilder

} // end of namespace: gnu.xml.dom
