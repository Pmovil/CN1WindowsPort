// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class PrettyPrinter: global::java.lang.Object {
public global::java.util.Map _fmyHashMap;

private void @this(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: void <init>(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.processing.PrettyPrinter) _r0_o)._fmyHashMap = (global::java.util.Map) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: void <init>(java.util.Map)]
}

public static global::System.Object print(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.Map)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0.i = 2;
    _r1.i = 0;
    _r0_o = global::com.codename1.processing.PrettyPrinter.print((global::java.util.Map) _r2_o, (int) _r0.i, (int) _r1.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.Map)]
}

public static global::System.Object print(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.List)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0.i = 2;
    _r1.i = 0;
    _r0_o = global::com.codename1.processing.PrettyPrinter.print((global::java.util.List) _r2_o, (int) _r0.i, (int) _r1.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.List)]
}

public static global::System.Object print(global::java.util.Map n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.Map, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = new global::com.codename1.processing.PrettyPrinter();
    ((global::com.codename1.processing.PrettyPrinter) _r0_o).@this((global::java.util.Map) _r2_o);
    _r1_o = ((global::com.codename1.processing.PrettyPrinter) _r0_o).toString((int) _r3.i, (int) _r4.i);
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.Map, int, int)]
}

public static global::System.Object print(global::java.util.List n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.List, int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    _r8_o = n1;
    _r9.i = n2;
    _r10.i = n3;
    _r7.i = 32;
    _r6.i = 10;
    _r2.i = ((global::java.util.List) _r8_o).size();
    if (_r2.i != 0) goto label13;
    // Value=[]
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91)), unchecked((char) unchecked((uint) 93))}));
    label12:;
    return (global::java.lang.String) _r5_o;
    label13:;
    _r4_o = new global::java.lang.StringBuffer();
    // Value=[
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91))}));
    ((global::java.lang.StringBuffer) _r4_o).@this((global::java.lang.String) _r5_o);
    _r5.i = 1;
    if (_r2.i != _r5.i) goto label45;
    _r5.i = 0;
    _r5_o = ((global::java.util.List) _r8_o).get((int) _r5.i);
    _r5_o = global::com.codename1.processing.PrettyPrinter.valueToString((global::java.lang.Object) _r5_o, (int) _r9.i, (int) _r10.i);
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r5_o);
    label35:;
    _r5.i = 93;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r5.i);
    _r5_o = ((global::java.lang.StringBuffer) _r4_o).toString();
    goto label12;
    label45:;
    _r3.i = _r10.i + _r9.i;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r6.i);
    _r0.i = 0;
    label51:;
    if (_r0.i >= _r2.i) goto label83;
    if (_r0.i <= 0) goto label60;
    // Value=,\012
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 10))}));
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r5_o);
    label60:;
    _r1.i = 0;
    label61:;
    if (_r1.i >= _r3.i) goto label69;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r7.i);
    _r1.i = _r1.i + 1;
    goto label61;
    label69:;
    _r5_o = ((global::java.util.List) _r8_o).get((int) _r0.i);
    _r5_o = global::com.codename1.processing.PrettyPrinter.valueToString((global::java.lang.Object) _r5_o, (int) _r9.i, (int) _r3.i);
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r5_o);
    _r0.i = _r0.i + 1;
    goto label51;
    label83:;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r6.i);
    _r0.i = 0;
    label87:;
    if (_r0.i >= _r10.i) goto label35;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r7.i);
    _r0.i = _r0.i + 1;
    goto label87;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String print(java.util.List, int, int)]
}

public virtual int length(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: int length()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.processing.PrettyPrinter) _r1_o)._fmyHashMap;
    _r0.i = ((global::java.util.Map) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: int length()]
}

public virtual global::System.Object keys(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.util.Enumeration keys()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.processing.PrettyPrinter) _r1_o)._fmyHashMap;
    _r0_o = ((global::java.util.Map) _r0_o).keySet();
    _r0_o = global::java.util.Collections.enumeration((global::java.util.Collection) _r0_o);
    return (global::java.util.Enumeration) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.util.Enumeration keys()]
}

public virtual global::System.Object toString(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String toString(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 0;
    _r0_o = ((global::com.codename1.processing.PrettyPrinter) _r1_o).toString((int) _r2.i, (int) _r0.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String toString(int)]
}

public virtual global::System.Object toString(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String toString(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    _r11_o = this;
    _r12.i = n1;
    _r13.i = n2;
    _r9.i = 32;
    _r8.i = 10;
    _r7.i = 1;
    // Value=: 
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r2.i = ((global::com.codename1.processing.PrettyPrinter) _r11_o).length();
    if (_r2.i != 0) goto label16;
    // Value=\173\175
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)123)), unchecked((char) unchecked((uint) 125))}));
    label15:;
    return (global::java.lang.String) _r6_o;
    label16:;
    _r1_o = ((global::com.codename1.processing.PrettyPrinter) _r11_o).keys();
    _r5_o = new global::java.lang.StringBuffer();
    // Value=\173
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)123))}));
    ((global::java.lang.StringBuffer) _r5_o).@this((global::java.lang.String) _r6_o);
    _r3.i = _r13.i + _r12.i;
    if (_r2.i != _r7.i) goto label103;
    _r4_o = ((global::java.util.Enumeration) _r1_o).nextElement();
    _r6_o = ((global::java.lang.Object) _r4_o).toString();
    _r6_o = global::com.codename1.processing.PrettyPrinter.quote((global::java.lang.String) _r6_o);
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r6_o);
    // Value=: 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r10_o);
    _r6_o = ((global::com.codename1.processing.PrettyPrinter) _r11_o)._fmyHashMap;
    _r6_o = ((global::java.util.Map) _r6_o).get((global::java.lang.Object) _r4_o);
    _r6_o = global::com.codename1.processing.PrettyPrinter.valueToString((global::java.lang.Object) _r6_o, (int) _r12.i, (int) _r13.i);
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r6_o);
    label64:;
    _r6.i = 125;
    ((global::java.lang.StringBuffer) _r5_o).append((char) _r6.i);
    _r6_o = ((global::java.lang.StringBuffer) _r5_o).toString();
    goto label15;
    label74:;
    _r6_o = ((global::java.lang.Object) _r4_o).toString();
    _r6_o = global::com.codename1.processing.PrettyPrinter.quote((global::java.lang.String) _r6_o);
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r6_o);
    // Value=: 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r10_o);
    _r6_o = ((global::com.codename1.processing.PrettyPrinter) _r11_o)._fmyHashMap;
    _r6_o = ((global::java.util.Map) _r6_o).get((global::java.lang.Object) _r4_o);
    _r6_o = global::com.codename1.processing.PrettyPrinter.valueToString((global::java.lang.Object) _r6_o, (int) _r12.i, (int) _r3.i);
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r6_o);
    label103:;
    _r6.i = ((global::java.util.Enumeration) _r1_o).hasMoreElements() ? 1 : 0;
    if (_r6.i == 0) goto label137;
    _r4_o = ((global::java.util.Enumeration) _r1_o).nextElement();
    _r6.i = ((global::java.lang.StringBuffer) _r5_o).length();
    if (_r6.i <= _r7.i) goto label133;
    // Value=,\012
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 10))}));
    ((global::java.lang.StringBuffer) _r5_o).append((global::java.lang.String) _r6_o);
    label124:;
    _r0.i = 0;
    label125:;
    if (_r0.i >= _r3.i) goto label74;
    ((global::java.lang.StringBuffer) _r5_o).append((char) _r9.i);
    _r0.i = _r0.i + 1;
    goto label125;
    label133:;
    ((global::java.lang.StringBuffer) _r5_o).append((char) _r8.i);
    goto label124;
    label137:;
    _r6.i = ((global::java.lang.StringBuffer) _r5_o).length();
    if (_r6.i <= _r7.i) goto label64;
    ((global::java.lang.StringBuffer) _r5_o).append((char) _r8.i);
    _r0.i = 0;
    label147:;
    if (_r0.i >= _r13.i) goto label64;
    ((global::java.lang.StringBuffer) _r5_o).append((char) _r9.i);
    _r0.i = _r0.i + 1;
    goto label147;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String toString(int, int)]
}

public static global::System.Object valueToString(global::java.lang.Object n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String valueToString(java.lang.Object, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    if (_r2_o == null) goto label9;
    _r1_o = null;
    _r1.i = ((global::java.lang.Object) _r2_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label12;
    label9:;
    // Value=null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    label11:;
    return (global::java.lang.String) _r1_o;
    label12:;
    try {
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.String)) ? 1 : 0;
    if (_r1.i == 0) goto label26;
    _r0_o = _r2_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = global::com.codename1.processing.PrettyPrinter.quote((global::java.lang.String) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    goto label11;
    label25:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    label26:;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Float)) ? 1 : 0;
    if (_r1.i != 0) goto label50;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Double)) ? 1 : 0;
    if (_r1.i != 0) goto label50;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Byte)) ? 1 : 0;
    if (_r1.i != 0) goto label50;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Short)) ? 1 : 0;
    if (_r1.i != 0) goto label50;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Integer)) ? 1 : 0;
    if (_r1.i != 0) goto label50;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Long)) ? 1 : 0;
    if (_r1.i == 0) goto label55;
    label50:;
    _r1_o = global::com.codename1.processing.PrettyPrinter.numberToString((global::java.lang.Object) _r2_o);
    goto label11;
    label55:;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.lang.Boolean)) ? 1 : 0;
    if (_r1.i == 0) goto label64;
    _r1_o = ((global::java.lang.Object) _r2_o).toString();
    goto label11;
    label64:;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.util.Map)) ? 1 : 0;
    if (_r1.i == 0) goto label75;
    _r2_o = _r2_o;
    _r1_o = global::com.codename1.processing.PrettyPrinter.print((global::java.util.Map) _r2_o, (int) _r3.i, (int) _r4.i);
    goto label11;
    label75:;
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.util.List)) ? 1 : 0;
    if (_r1.i == 0) goto label86;
    _r2_o = _r2_o;
    _r1_o = global::com.codename1.processing.PrettyPrinter.print((global::java.util.List) _r2_o, (int) _r3.i, (int) _r4.i);
    goto label11;
    label86:;
    _r1_o = ((global::java.lang.Object) _r2_o).toString();
    _r1_o = global::com.codename1.processing.PrettyPrinter.quote((global::java.lang.String) _r1_o);
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String valueToString(java.lang.Object, int, int)]
}

public static global::System.Object quote(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String quote(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r11_o = null;
    _r11_o = n1;
    _r10.i = 92;
    _r9.i = 34;
    if (_r11_o == null) goto label12;
    _r6.i = ((global::java.lang.String) _r11_o).length();
    if (_r6.i != 0) goto label15;
    label12:;
    // Value=\042\042
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34)), unchecked((char) unchecked((uint) 34))}));
    label14:;
    return (global::java.lang.String) _r6_o;
    label15:;
    _r1.i = 0;
    _r3.i = ((global::java.lang.String) _r11_o).length();
    _r4_o = new global::java.lang.StringBuffer();
    _r6.i = _r3.i + 4;
    ((global::java.lang.StringBuffer) _r4_o).@this((int) _r6.i);
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r9.i);
    _r2.i = 0;
    label31:;
    if (_r2.i >= _r3.i) goto label155;
    _r0.i = _r1.i;
    _r1.i = ((global::java.lang.String) _r11_o).charAt((int) _r2.i);
    switch (_r1.i) {
    case 8: goto label121;
    case 9: goto label127;
    case 10: goto label133;
    case 12: goto label139;
    case 13: goto label145;
    case 34: goto label103;
    case 47: goto label110;
    case 92: goto label103;
    }
    _r6.i = 32;
    if (_r1.i >= _r6.i) goto label151;
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    // Value=000
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 48))}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r7_o = global::java.lang.Integer.toHexString((int) _r1.i);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r5_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    // Value=\134u
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 117))}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r7.i = ((global::java.lang.String) _r5_o).length();
    _r8.i = 4;
    _r7.i = _r7.i - _r8.i;
    _r7_o = ((global::java.lang.String) _r5_o).substring((int) _r7.i);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r6_o);
    label100:;
    _r2.i = _r2.i + 1;
    goto label31;
    label103:;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r10.i);
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r1.i);
    goto label100;
    label110:;
    _r6.i = 60;
    if (_r0.i != _r6.i) goto label117;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r10.i);
    label117:;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r1.i);
    goto label100;
    label121:;
    // Value=\134b
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 98))}));
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r6_o);
    goto label100;
    label127:;
    // Value=\134t
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r6_o);
    goto label100;
    label133:;
    // Value=\134n
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r6_o);
    goto label100;
    label139:;
    // Value=\134f
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 102))}));
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r6_o);
    goto label100;
    label145:;
    // Value=\134r
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.lang.StringBuffer) _r4_o).append((global::java.lang.String) _r6_o);
    goto label100;
    label151:;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r1.i);
    goto label100;
    label155:;
    ((global::java.lang.StringBuffer) _r4_o).append((char) _r9.i);
    _r6_o = ((global::java.lang.StringBuffer) _r4_o).toString();
    goto label14;
    label164:;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String quote(java.lang.String)]
}

public static global::System.Object valueToString(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String valueToString(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    if (_r1_o == null) goto label9;
    _r0_o = null;
    _r0.i = ((global::java.lang.Object) _r1_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label12;
    label9:;
    // Value=null
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    label11:;
    return (global::java.lang.String) _r0_o;
    label12:;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.String)) ? 1 : 0;
    if (_r0.i == 0) goto label20;
    _r1_o = _r1_o;
    _r0_o = _r1_o;
    goto label11;
    label20:;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Float)) ? 1 : 0;
    if (_r0.i != 0) goto label44;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Double)) ? 1 : 0;
    if (_r0.i != 0) goto label44;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Byte)) ? 1 : 0;
    if (_r0.i != 0) goto label44;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Short)) ? 1 : 0;
    if (_r0.i != 0) goto label44;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Integer)) ? 1 : 0;
    if (_r0.i != 0) goto label44;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Long)) ? 1 : 0;
    if (_r0.i == 0) goto label49;
    label44:;
    _r0_o = global::com.codename1.processing.PrettyPrinter.numberToString((global::java.lang.Object) _r1_o);
    goto label11;
    label49:;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.lang.Boolean)) ? 1 : 0;
    if (_r0.i != 0) goto label61;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.util.Map)) ? 1 : 0;
    if (_r0.i != 0) goto label61;
    _r0.i = ((_r1_o != null) && (_r1_o is global::java.util.List)) ? 1 : 0;
    if (_r0.i == 0) goto label66;
    label61:;
    _r0_o = ((global::java.lang.Object) _r1_o).toString();
    goto label11;
    label66:;
    _r0_o = ((global::java.lang.Object) _r1_o).toString();
    _r0_o = global::com.codename1.processing.PrettyPrinter.quote((global::java.lang.String) _r0_o);
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String valueToString(java.lang.Object)]
}

public static global::System.Object trimNumber(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String trimNumber(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = n1;
    _r2.i = 1;
    _r1.i = 0;
    _r0.i = 46;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((int) _r0.i);
    if (_r0.i <= 0) goto label61;
    _r0.i = 101;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((int) _r0.i);
    if (_r0.i >= 0) goto label61;
    _r0.i = 69;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((int) _r0.i);
    if (_r0.i >= 0) goto label61;
    label26:;
    // Value=0
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48))}));
    _r0.i = ((global::java.lang.String) _r3_o).endsWith((global::java.lang.String) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label44;
    _r0.i = ((global::java.lang.String) _r3_o).length();
    _r0.i = _r0.i - _r2.i;
    _r3_o = ((global::java.lang.String) _r3_o).substring((int) _r1.i, (int) _r0.i);
    goto label26;
    label44:;
    // Value=.
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    _r0.i = ((global::java.lang.String) _r3_o).endsWith((global::java.lang.String) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label61;
    _r0.i = ((global::java.lang.String) _r3_o).length();
    _r0.i = _r0.i - _r2.i;
    _r3_o = ((global::java.lang.String) _r3_o).substring((int) _r1.i, (int) _r0.i);
    label61:;
    return (global::java.lang.String) _r3_o;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String trimNumber(java.lang.String)]
}

public static global::System.Object numberToString(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String numberToString(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    if (_r1_o != null) goto label4;
    _r0_o = null;
    label3:;
    return (global::java.lang.String) _r0_o;
    label4:;
    _r0_o = ((global::java.lang.Object) _r1_o).toString();
    _r0_o = global::com.codename1.processing.PrettyPrinter.trimNumber((global::java.lang.String) _r0_o);
    goto label3;
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter: java.lang.String numberToString(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.PrettyPrinter]
//XMLVM_END_WRAPPER[com.codename1.processing.PrettyPrinter]

} // end of class: PrettyPrinter

} // end of namespace: com.codename1.processing
