// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public abstract class Number: global::java.lang.Object,global::java.io.Serializable {

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.Number: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.Number: void <init>()]
}

public virtual sbyte byteValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Number: byte byteValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Number) _r1_o).intValue();
    _r0.i = (_r0.i << 24) >> 24;
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Number: byte byteValue()]
}

public abstract double doubleValue();

public abstract float floatValue();

public abstract int intValue();

public abstract long longValue();

public virtual short shortValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Number: short shortValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Number) _r1_o).intValue();
    _r0.i = (_r0.i << 16) >> 16;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Number: short shortValue()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Number]
//XMLVM_END_WRAPPER[java.lang.Number]

} // end of class: Number

} // end of namespace: java.lang
