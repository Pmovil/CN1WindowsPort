// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class ImplementationSource: global::java.lang.Object,global::org.w3c.dom.DOMImplementationSource {

static ImplementationSource() {
    // Value=1234567890
    _fDIGITS = new global::java.lang.String();
    _fDIGITS.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 55)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 48))}));
    @static();
}

private static global::java.lang.String _fDIGITS;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _fimplementations;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: void <clinit>()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    _r1_o = new global::gnu.xml.dom.DomImpl();
    ((global::gnu.xml.dom.DomImpl) _r1_o).@this();
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    try {
    // Value=gnu.xml.libxmlj.dom.GnomeDocumentBuilder
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)103)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 106)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 71)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = global::java.lang.Class.forName((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.lang.Class) _r1_o).newInstance();
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label42;
        }
        if (_java_exception is global::java.lang.UnsatisfiedLinkError) {
            _ex = ex;
            goto label40;
        }
        throw ex;
    } // end catch
    label26:;
    _r1.i = ((global::java.util.List) _r0_o).size();
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    global::gnu.xml.dom.ImplementationSource._fimplementations = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    _r1_o = global::gnu.xml.dom.ImplementationSource._fimplementations;
    ((global::java.util.List) _r0_o).toArray((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    return;
    label40:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    goto label26;
    label42:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    goto label26;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: void <clinit>()]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: void <init>()]
}

public virtual global::System.Object getDOMImplementation(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::gnu.xml.dom.ImplementationSource) _r2_o).getImplementations((global::java.lang.String) _r3_o);
    _r1.i = ((global::java.util.List) _r0_o).isEmpty() ? 1 : 0;
    if (_r1.i == 0) goto label12;
    _r0_o = null;
    label11:;
    return (global::org.w3c.dom.DOMImplementation) _r0_o;
    label12:;
    _r1.i = 0;
    _r2_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r2_o = _r2_o;
    _r0_o = _r2_o;
    goto label11;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: org.w3c.dom.DOMImplementation getDOMImplementation(java.lang.String)]
}

public virtual global::System.Object getDOMImplementationList(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::gnu.xml.dom.ImplementationSource) _r2_o).getImplementations((global::java.lang.String) _r3_o);
    _r1_o = new global::gnu.xml.dom.ImplementationList();
    ((global::gnu.xml.dom.ImplementationList) _r1_o).@this((global::java.util.List) _r0_o);
    return (global::org.w3c.dom.DOMImplementationList) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: org.w3c.dom.DOMImplementationList getDOMImplementationList(java.lang.String)]
}

private global::System.Object getImplementations(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: java.util.List getImplementations(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r0_o = new global::java.util.ArrayList();
    _r1_o = global::gnu.xml.dom.ImplementationSource._fimplementations;
    _r1_o = global::java.util.Arrays.asList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    ((global::java.util.ArrayList) _r0_o).@this((global::java.util.Collection) _r1_o);
    _r1_o = ((global::gnu.xml.dom.ImplementationSource) _r6_o).parseFeatures((global::java.lang.String) _r7_o);
    _r1_o = ((global::java.util.List) _r1_o).iterator();
    label19:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i != 0) goto label26;
    return (global::java.util.List) _r0_o;
    label26:;
    _r6_o = ((global::java.util.Iterator) _r1_o).next();
    _r6_o = _r6_o;
    _r2_o = null;
    _r3.i = 32;
    _r3.i = ((global::java.lang.String) _r6_o).indexOf((int) _r3.i);
    _r4.i = -1;
    if (_r3.i == _r4.i) goto label79;
    _r2.i = _r3.i + 1;
    _r2_o = ((global::java.lang.String) _r6_o).substring((int) _r2.i);
    _r4.i = 0;
    _r3_o = ((global::java.lang.String) _r6_o).substring((int) _r4.i, (int) _r3.i);
    label53:;
    _r4_o = ((global::java.util.List) _r0_o).iterator();
    label57:;
    _r5.i = ((global::java.util.Iterator) _r4_o).hasNext() ? 1 : 0;
    if (_r5.i == 0) goto label19;
    _r6_o = ((global::java.util.Iterator) _r4_o).next();
    _r6_o = _r6_o;
    _r5.i = ((global::org.w3c.dom.DOMImplementation) _r6_o).hasFeature((global::java.lang.String) _r3_o, (global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r5.i != 0) goto label57;
    ((global::java.util.Iterator) _r4_o).remove();
    goto label57;
    label79:;
    _r3_o = _r6_o;
    goto label53;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: java.util.List getImplementations(java.lang.String)]
}

public virtual global::System.Object parseFeatures(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: java.util.List parseFeatures(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r2.i = 0;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    _r1.i = ((global::java.lang.String) _r7_o).length();
    _r3.i = _r2.i;
    label11:;
    if (_r3.i < _r1.i) goto label23;
    if (_r3.i <= _r2.i) goto label22;
    _r1_o = ((global::gnu.xml.dom.ImplementationSource) _r6_o).getFeature((global::java.lang.String) _r7_o, (int) _r2.i, (int) _r1.i);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    label22:;
    return (global::java.util.List) _r0_o;
    label23:;
    _r4.i = ((global::java.lang.String) _r7_o).charAt((int) _r3.i);
    _r5.i = 32;
    if (_r4.i != _r5.i) goto label59;
    _r4.i = _r3.i + 1;
    if (_r4.i >= _r1.i) goto label59;
    // Value=1234567890
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 55)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 48))}));
    _r5.i = _r3.i + 1;
    _r5.i = ((global::java.lang.String) _r7_o).charAt((int) _r5.i);
    _r4.i = ((global::java.lang.String) _r4_o).indexOf((int) _r5.i);
    _r5.i = -1;
    if (_r4.i != _r5.i) goto label59;
    _r2_o = ((global::gnu.xml.dom.ImplementationSource) _r6_o).getFeature((global::java.lang.String) _r7_o, (int) _r2.i, (int) _r3.i);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r2_o);
    _r2.i = _r3.i + 1;
    label59:;
    _r3.i = _r3.i + 1;
    goto label11;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: java.util.List parseFeatures(java.lang.String)]
}

public virtual global::System.Object getFeature(global::java.lang.String n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource: java.lang.String getFeature(java.lang.String, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r5.i = n3;
    _r0.i = ((global::java.lang.String) _r3_o).length();
    if (_r0.i <= 0) goto label21;
    _r0.i = ((global::java.lang.String) _r3_o).charAt((int) _r4.i);
    _r1.i = 43;
    if (_r0.i != _r1.i) goto label21;
    _r0.i = _r4.i + 1;
    _r0_o = ((global::java.lang.String) _r3_o).substring((int) _r0.i, (int) _r5.i);
    label20:;
    return (global::java.lang.String) _r0_o;
    label21:;
    _r0_o = ((global::java.lang.String) _r3_o).substring((int) _r4.i, (int) _r5.i);
    goto label20;
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource: java.lang.String getFeature(java.lang.String, int, int)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ImplementationSource]
//XMLVM_END_WRAPPER[gnu.xml.dom.ImplementationSource]

} // end of class: ImplementationSource

} // end of namespace: gnu.xml.dom
