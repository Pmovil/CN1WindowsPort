// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public abstract class DomCharacterData: global::gnu.xml.dom.DomNode,global::org.w3c.dom.CharacterData {

static DomCharacterData() {
    @static();
}

public static global::org.w3c.dom.NodeList _fCHILD_1NODES;

private global::java.lang.String _ftext;

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

public static void @static(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void <clinit>()]
    global::System.Object _r0_o = null;
    _r0_o = new global::gnu.xml.dom.DomCharacterData_2EmptyNodeList();
    ((global::gnu.xml.dom.DomCharacterData_2EmptyNodeList) _r0_o).@this();
    global::gnu.xml.dom.DomCharacterData._fCHILD_1NODES = (global::org.w3c.dom.NodeList) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void <clinit>()]
}

public void @this(short n1, global::gnu.xml.dom.DomDocument n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void <init>(short, gnu.xml.dom.DomDocument, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r4_o = n3;
    ((global::gnu.xml.dom.DomNode) _r1_o).@this((short) _r2.i, (global::gnu.xml.dom.DomDocument) _r3_o);
    if (_r4_o != null) goto label10;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label7:;
    ((global::gnu.xml.dom.DomCharacterData) _r1_o)._ftext = (global::java.lang.String) _r0_o;
    return;
    label10:;
    _r0_o = _r4_o;
    goto label7;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void <init>(short, gnu.xml.dom.DomDocument, java.lang.String)]
}

public void @this(short n1, global::gnu.xml.dom.DomDocument n2, global::org.xmlvm._nArrayAdapter<char> n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void <init>(short, gnu.xml.dom.DomDocument, char[], int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5.i = n4;
    _r6.i = n5;
    ((global::gnu.xml.dom.DomNode) _r1_o).@this((short) _r2.i, (global::gnu.xml.dom.DomDocument) _r3_o);
    if (_r4_o != null) goto label10;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label7:;
    ((global::gnu.xml.dom.DomCharacterData) _r1_o)._ftext = (global::java.lang.String) _r0_o;
    return;
    label10:;
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (int) _r6.i);
    goto label7;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void <init>(short, gnu.xml.dom.DomDocument, char[], int, int)]
}

public virtual void appendData(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void appendData(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::gnu.xml.dom.DomCharacterData) _r2_o).isReadonly() ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label13:;
    _r0_o = new global::java.lang.StringBuilder();
    _r1_o = ((global::gnu.xml.dom.DomCharacterData) _r2_o)._ftext;
    _r1_o = global::java.lang.String.valueOf((global::java.lang.Object) _r1_o);
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::gnu.xml.dom.DomCharacterData) _r2_o).mutating((global::java.lang.String) _r0_o);
    ((global::gnu.xml.dom.DomCharacterData) _r2_o)._ftext = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void appendData(java.lang.String)]
}

public virtual void deleteData(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void deleteData(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7.i = n1;
    _r8.i = n2;
    _r5.i = 1;
    _r0.i = ((global::gnu.xml.dom.DomCharacterData) _r6_o).isReadonly() ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label14:;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r6_o)._ftext;
    _r0_o = ((global::java.lang.String) _r0_o).toCharArray();
    if (_r7.i < 0) goto label27;
    if (_r8.i < 0) goto label27;
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r7.i <= _r1.i) goto label33;
    label27:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r5.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label33:;
    _r1.i = _r7.i + _r8.i;
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r1.i <= _r2.i) goto label79;
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = _r1.i - _r7.i;
    label40:;
    if (_r1.i != 0) goto label43;
    label42:;
    return;
    label43:;
    try {
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = _r2.i - _r1.i;
    _r2_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r2.i]);
    _r3.i = 0;
    _r4.i = 0;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r4.i, (int) _r7.i);
    _r3.i = _r7.i + _r1.i;
    _r4.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = _r1.i + _r7.i;
    _r1.i = _r4.i - _r1.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r7.i, (int) _r1.i);
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r2_o);
    ((global::gnu.xml.dom.DomCharacterData) _r6_o).mutating((global::java.lang.String) _r0_o);
    ((global::gnu.xml.dom.DomCharacterData) _r6_o)._ftext = (global::java.lang.String) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IndexOutOfBoundsException) {
            _ex = ex;
            goto label72;
        }
        throw ex;
    } // end catch
    goto label42;
    label72:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r5.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label79:;
    _r1.i = _r8.i;
    goto label40;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void deleteData(int, int)]
}

public override global::System.Object getNodeValue(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String getNodeValue()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r1_o)._ftext;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String getNodeValue()]
}

public virtual global::System.Object getData(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String getData()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r1_o)._ftext;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String getData()]
}

public override int getLength(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: int getLength()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r1_o)._ftext;
    _r0.i = ((global::java.lang.String) _r0_o).length();
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: int getLength()]
}

public virtual void insertData(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void insertData(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6.i = n1;
    _r7_o = n2;
    _r0.i = ((global::gnu.xml.dom.DomCharacterData) _r5_o).isReadonly() ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label13:;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r5_o)._ftext;
    _r0_o = ((global::java.lang.String) _r0_o).toCharArray();
    _r1_o = ((global::java.lang.String) _r7_o).toCharArray();
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r3.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r2.i = _r2.i + _r3.i;
    _r2_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r2.i]);
    _r3.i = 0;
    _r4.i = 0;
    try {
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r4.i, (int) _r6.i);
    _r3.i = 0;
    _r4.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r6.i, (int) _r4.i);
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r1.i = _r1.i + _r6.i;
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r3.i = _r3.i - _r6.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r6.i, (global::java.lang.Object) _r2_o, (int) _r1.i, (int) _r3.i);
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r2_o);
    ((global::gnu.xml.dom.DomCharacterData) _r5_o).mutating((global::java.lang.String) _r0_o);
    ((global::gnu.xml.dom.DomCharacterData) _r5_o)._ftext = (global::java.lang.String) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IndexOutOfBoundsException) {
            _ex = ex;
            goto label56;
        }
        throw ex;
    } // end catch
    return;
    label56:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 1;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void insertData(int, java.lang.String)]
}

public virtual void replaceData(int n1, int n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void replaceData(int, int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7.i = n1;
    _r8.i = n2;
    _r9_o = n3;
    _r5.i = 1;
    _r0.i = ((global::gnu.xml.dom.DomCharacterData) _r6_o)._freadonly ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label12:;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r6_o)._ftext;
    _r0_o = ((global::java.lang.String) _r0_o).toCharArray();
    if (_r7.i < 0) goto label25;
    if (_r8.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r7.i <= _r1.i) goto label31;
    label25:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r5.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label31:;
    _r1.i = _r7.i + _r8.i;
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r1.i <= _r2.i) goto label100;
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = _r1.i - _r7.i;
    label38:;
    try {
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = _r2.i - _r1.i;
    _r2_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r2.i]);
    _r3.i = 0;
    _r4.i = 0;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r4.i, (int) _r7.i);
    _r3.i = _r7.i + _r1.i;
    _r4.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = _r1.i + _r7.i;
    _r1.i = _r4.i - _r1.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r7.i, (int) _r1.i);
    _r1_o = ((global::java.lang.String) _r9_o).toCharArray();
    _r3.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r4.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r3.i = _r3.i + _r4.i;
    _r3_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r3.i]);
    _r3.i = 0;
    _r4.i = 0;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r4.i, (int) _r7.i);
    _r3.i = 0;
    _r4.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r7.i, (int) _r4.i);
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r1.i = _r1.i + _r7.i;
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r3.i = _r3.i - _r7.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r7.i, (global::java.lang.Object) _r2_o, (int) _r1.i, (int) _r3.i);
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r2_o);
    ((global::gnu.xml.dom.DomCharacterData) _r6_o).mutating((global::java.lang.String) _r0_o);
    ((global::gnu.xml.dom.DomCharacterData) _r6_o)._ftext = (global::java.lang.String) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IndexOutOfBoundsException) {
            _ex = ex;
            goto label93;
        }
        throw ex;
    } // end catch
    return;
    label93:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r5.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label100:;
    _r1.i = _r8.i;
    goto label38;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void replaceData(int, int, java.lang.String)]
}

public override void setNodeValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void setNodeValue(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::gnu.xml.dom.DomCharacterData) _r2_o).isReadonly() ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 7;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
    label13:;
    if (_r3_o != null) goto label23;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label17:;
    ((global::gnu.xml.dom.DomCharacterData) _r2_o).mutating((global::java.lang.String) _r0_o);
    ((global::gnu.xml.dom.DomCharacterData) _r2_o)._ftext = (global::java.lang.String) _r0_o;
    return;
    label23:;
    _r0_o = _r3_o;
    goto label17;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void setNodeValue(java.lang.String)]
}

public virtual void setData(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void setData(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.dom.DomCharacterData) _r0_o).setNodeValue((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void setData(java.lang.String)]
}

public virtual global::System.Object substringData(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String substringData(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    try {
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r2_o)._ftext;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r3.i, (int) _r4.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.StringIndexOutOfBoundsException) {
            _ex = ex;
            goto label7;
        }
        throw ex;
    } // end catch
    label6:;
    return (global::java.lang.String) _r0_o;
    label7:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    if (_r3.i < 0) goto label27;
    if (_r4.i < 0) goto label27;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r2_o)._ftext;
    _r0.i = ((global::java.lang.String) _r0_o).length();
    if (_r3.i >= _r0.i) goto label27;
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r2_o)._ftext;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r3.i);
    goto label6;
    label27:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 1;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String substringData(int, int)]
}

public override global::System.Object getChildNodes(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: org.w3c.dom.NodeList getChildNodes()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::gnu.xml.dom.DomCharacterData._fCHILD_1NODES;
    return (global::org.w3c.dom.NodeList) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: org.w3c.dom.NodeList getChildNodes()]
}

public override global::System.Object getBaseURI(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String getBaseURI()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: java.lang.String getBaseURI()]
}

private void mutating(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData: void mutating(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r4_o = null;
    _r3.i = 0;
    // Value=MutationEvents
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115))}));
    _r0_o = ((global::gnu.xml.dom.DomCharacterData) _r9_o).createEvent((global::java.lang.String) _r0_o);
    // Value=DOMCharacterDataModified
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r2.i = 1;
    _r5_o = ((global::gnu.xml.dom.DomCharacterData) _r9_o)._ftext;
    _r6_o = _r10_o;
    _r7_o = _r4_o;
    _r8.i = _r3.i;
    ((global::org.w3c.dom.events.MutationEvent) _r0_o).initMutationEvent((global::java.lang.String) _r1_o, 0!=_r2.i, 0!=_r3.i, (global::org.w3c.dom.Node) _r4_o, (global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o, (global::java.lang.String) _r7_o, (short) _r8.i);
    ((global::gnu.xml.dom.DomCharacterData) _r9_o).dispatchEvent((global::org.w3c.dom.events.Event) _r0_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData: void mutating(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCharacterData]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCharacterData]

} // end of class: DomCharacterData

} // end of namespace: gnu.xml.dom
