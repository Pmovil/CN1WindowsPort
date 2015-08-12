// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Short: global::java.lang.Number,global::java.lang.Comparable {

static Short() {
    @static();
}


private short _fvalue;

public static short _fMAX_1VALUE = 32767;

public static short _fMIN_1VALUE = -32768;

public static int _fSIZE = 16;

public static global::java.lang.Class _fTYPE;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<short>(new short[_r0.i]);
    _r0_o = ((global::java.lang.Object) _r0_o).getClass();
    _r0_o = ((global::java.lang.Class) _r0_o).getComponentType();
    global::java.lang.Short._fTYPE = (global::java.lang.Class) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.lang.Short: void <clinit>()]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = global::java.lang.Short.parseShort((global::java.lang.String) _r2_o);
    ((global::java.lang.Short) _r1_o).@this((short) _r0.i);
    return;
//XMLVM_END_WRAPPER[java.lang.Short: void <init>(java.lang.String)]
}

public void @this(short n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: void <init>(short)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.lang.Number) _r0_o).@this();
    ((global::java.lang.Short) _r0_o)._fvalue = (short) _r1.i;
    return;
//XMLVM_END_WRAPPER[java.lang.Short: void <init>(short)]
}

public override sbyte byteValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: byte byteValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Short) _r1_o)._fvalue;
    _r0.i = (_r0.i << 24) >> 24;
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: byte byteValue()]
}

public virtual int compareTo(global::java.lang.Short n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: int compareTo(java.lang.Short)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.lang.Short) _r2_o)._fvalue;
    _r1.i = ((global::java.lang.Short) _r3_o)._fvalue;
    if (_r0.i <= _r1.i) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i;
    label8:;
    _r0.i = ((global::java.lang.Short) _r2_o)._fvalue;
    _r1.i = ((global::java.lang.Short) _r3_o)._fvalue;
    if (_r0.i >= _r1.i) goto label16;
    _r0.i = -1;
    goto label7;
    label16:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[java.lang.Short: int compareTo(java.lang.Short)]
}

public static global::System.Object decode(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: java.lang.Short decode(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0_o = global::java.lang.Integer.decode((global::java.lang.String) _r2_o);
    _r0.i = ((global::java.lang.Integer) _r0_o).intValue();
    _r1.i = (_r0.i << 16) >> 16;
    if (_r1.i != _r0.i) goto label16;
    _r0_o = global::java.lang.Short.valueOf((short) _r1.i);
    return (global::java.lang.Short) _r0_o;
    label16:;
    _r0_o = new global::java.lang.NumberFormatException();
    ((global::java.lang.NumberFormatException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NumberFormatException) _r0_o);
//XMLVM_END_WRAPPER[java.lang.Short: java.lang.Short decode(java.lang.String)]
}

public override double doubleValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: double doubleValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.lang.Short) _r2_o)._fvalue;
    _r0.d = (double) _r0.i;
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Short: double doubleValue()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.lang.Short)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0.i = ((global::java.lang.Short) _r2_o)._fvalue;
    _r1.i = ((global::java.lang.Short) _r3_o)._fvalue;
    if (_r0.i != _r1.i) goto label14;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[java.lang.Short: boolean equals(java.lang.Object)]
}

public override float floatValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: float floatValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Short) _r1_o)._fvalue;
    _r0.f = (float) _r0.i;
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Short: float floatValue()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Short) _r1_o)._fvalue;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: int hashCode()]
}

public override int intValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: int intValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Short) _r1_o)._fvalue;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: int intValue()]
}

public override long longValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: long longValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.lang.Short) _r2_o)._fvalue;
    _r0.l = (long) _r0.i;
    return _r0.l;
//XMLVM_END_WRAPPER[java.lang.Short: long longValue()]
}

public static short parseShort(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: short parseShort(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = 10;
    _r0.i = global::java.lang.Short.parseShort((global::java.lang.String) _r1_o, (int) _r0.i);
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: short parseShort(java.lang.String)]
}

public static short parseShort(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: short parseShort(java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = n1;
    _r3.i = n2;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r2_o, (int) _r3.i);
    _r1.i = (_r0.i << 16) >> 16;
    if (_r1.i != _r0.i) goto label8;
    return (short) _r1.i;
    label8:;
    _r0_o = new global::java.lang.NumberFormatException();
    ((global::java.lang.NumberFormatException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NumberFormatException) _r0_o);
//XMLVM_END_WRAPPER[java.lang.Short: short parseShort(java.lang.String, int)]
}

public override short shortValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: short shortValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Short) _r1_o)._fvalue;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: short shortValue()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Short) _r1_o)._fvalue;
    _r0_o = global::java.lang.Integer.toString((int) _r0.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Short: java.lang.String toString()]
}

public static global::System.Object toString(short n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: java.lang.String toString(short)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    _r0_o = global::java.lang.Integer.toString((int) _r1.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Short: java.lang.String toString(short)]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: java.lang.Short valueOf(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = global::java.lang.Short.parseShort((global::java.lang.String) _r1_o);
    _r0_o = global::java.lang.Short.valueOf((short) _r0.i);
    return (global::java.lang.Short) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Short: java.lang.Short valueOf(java.lang.String)]
}

public static global::System.Object valueOf(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: java.lang.Short valueOf(java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = n1;
    _r2.i = n2;
    _r0.i = global::java.lang.Short.parseShort((global::java.lang.String) _r1_o, (int) _r2.i);
    _r0_o = global::java.lang.Short.valueOf((short) _r0.i);
    return (global::java.lang.Short) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Short: java.lang.Short valueOf(java.lang.String, int)]
}

public static short reverseBytes(short n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: short reverseBytes(short)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r2.i = n1;
    _r0.i = _r2.i >> (0x1f & 8);
    _r0.i = _r0.i & 255;
    _r1.i = _r2.i & 255;
    _r1.i = _r1.i << (0x1f & 8);
    _r0.i = _r0.i | _r1.i;
    _r0.i = (_r0.i << 16) >> 16;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: short reverseBytes(short)]
}

public static global::System.Object valueOf(short n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: java.lang.Short valueOf(short)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r2.i = n1;
    _r0.i = -128;
    if (_r2.i < _r0.i) goto label8;
    _r0.i = 127;
    if (_r2.i <= _r0.i) goto label14;
    label8:;
    _r0_o = new global::java.lang.Short();
    ((global::java.lang.Short) _r0_o).@this((short) _r2.i);
    label13:;
    return (global::java.lang.Short) _r0_o;
    label14:;
    _r0_o = global::java.lang.Short_2valueOfCache.access_20();
    _r1.i = _r2.i + 128;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    goto label13;
//XMLVM_END_WRAPPER[java.lang.Short: java.lang.Short valueOf(short)]
}

public virtual int compareTo(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Short: int compareTo(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::java.lang.Short) _r1_o).compareTo((global::java.lang.Short) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Short: int compareTo(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Short]
//XMLVM_END_WRAPPER[java.lang.Short]

} // end of class: Short

} // end of namespace: java.lang
