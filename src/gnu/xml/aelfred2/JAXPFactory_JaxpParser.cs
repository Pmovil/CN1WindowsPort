// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.aelfred2 {
public class JAXPFactory_2JaxpParser: global::javax.xml.parsers.SAXParser {
private global::gnu.xml.aelfred2.XmlReader _fae2;

private global::org.xml.sax.helpers.XMLReaderAdapter _fparser;

public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::javax.xml.parsers.SAXParser) _r1_o).@this();
    _r0_o = new global::gnu.xml.aelfred2.XmlReader();
    ((global::gnu.xml.aelfred2.XmlReader) _r0_o).@this();
    ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r1_o)._fae2 = (global::gnu.xml.aelfred2.XmlReader) _r0_o;
    _r0_o = null;
    ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r1_o)._fparser = (global::org.xml.sax.helpers.XMLReaderAdapter) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: void <init>()]
}

public override void setProperty(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: void setProperty(java.lang.String, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r1_o)._fae2;
    ((global::gnu.xml.aelfred2.XmlReader) _r0_o).setProperty((global::java.lang.String) _r2_o, (global::java.lang.Object) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: void setProperty(java.lang.String, java.lang.Object)]
}

public override global::System.Object getProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: java.lang.Object getProperty(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r1_o)._fae2;
    _r0_o = ((global::gnu.xml.aelfred2.XmlReader) _r0_o).getProperty((global::java.lang.String) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: java.lang.Object getProperty(java.lang.String)]
}

public override global::System.Object getParser(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: org.xml.sax.Parser getParser()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o)._fparser;
    if (_r0_o != null) goto label13;
    _r0_o = new global::org.xml.sax.helpers.XMLReaderAdapter();
    _r1_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o)._fae2;
    ((global::org.xml.sax.helpers.XMLReaderAdapter) _r0_o).@this((global::org.xml.sax.XMLReader) _r1_o);
    ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o)._fparser = (global::org.xml.sax.helpers.XMLReaderAdapter) _r0_o;
    label13:;
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o)._fparser;
    return (global::org.xml.sax.Parser) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: org.xml.sax.Parser getParser()]
}

public override global::System.Object getXMLReader(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: org.xml.sax.XMLReader getXMLReader()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r1_o)._fae2;
    return (global::org.xml.sax.XMLReader) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: org.xml.sax.XMLReader getXMLReader()]
}

public override bool isNamespaceAware(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: boolean isNamespaceAware()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    try {
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o)._fae2;
    // Value=http://xml.org/sax/features/namespaces
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r0.i = ((global::gnu.xml.aelfred2.XmlReader) _r0_o).getFeature((global::java.lang.String) _r1_o) ? 1 : 0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label9;
        }
        throw ex;
    } // end catch
    return _r0.i!=0;
    label9:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::java.lang.Error();
    ((global::java.lang.Error) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Error) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: boolean isNamespaceAware()]
}

public override bool isValidating(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: boolean isValidating()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    try {
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o)._fae2;
    // Value=http://xml.org/sax/features/validation
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::gnu.xml.aelfred2.XmlReader) _r0_o).getFeature((global::java.lang.String) _r1_o) ? 1 : 0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label9;
        }
        throw ex;
    } // end catch
    return _r0.i!=0;
    label9:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::java.lang.Error();
    ((global::java.lang.Error) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Error) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser: boolean isValidating()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser]
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory$JaxpParser]

} // end of class: JAXPFactory_2JaxpParser

} // end of namespace: gnu.xml.aelfred2
