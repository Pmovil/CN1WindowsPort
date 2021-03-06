// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio {
public class ReadWriteDoubleArrayBuffer: global::java.nio.DoubleArrayBuffer {
public static global::System.Object copy(global::java.nio.DoubleArrayBuffer n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.ReadWriteDoubleArrayBuffer copy(java.nio.DoubleArrayBuffer, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = n1;
    _r5.i = n2;
    _r0_o = new global::java.nio.ReadWriteDoubleArrayBuffer();
    _r1.i = ((global::java.nio.DoubleArrayBuffer) _r4_o).capacity();
    _r2_o = ((global::java.nio.DoubleArrayBuffer) _r4_o)._fbackingArray;
    _r3.i = ((global::java.nio.DoubleArrayBuffer) _r4_o)._foffset;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o).@this((int) _r1.i, (global::org.xmlvm._nArrayAdapter<double>) _r2_o, (int) _r3.i);
    _r1.i = ((global::java.nio.DoubleArrayBuffer) _r4_o).limit();
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o)._flimit = _r1.i;
    _r1.i = ((global::java.nio.DoubleArrayBuffer) _r4_o).position();
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o)._fposition = _r1.i;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o)._fmark = _r5.i;
    return (global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.ReadWriteDoubleArrayBuffer copy(java.nio.DoubleArrayBuffer, int)]
}

new public void @this(global::org.xmlvm._nArrayAdapter<double> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: void <init>(double[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.nio.DoubleArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<double>) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: void <init>(double[])]
}

new public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: void <init>(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.nio.DoubleArrayBuffer) _r0_o).@this((int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: void <init>(int)]
}

new public void @this(int n1, global::org.xmlvm._nArrayAdapter<double> n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: void <init>(int, double[], int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1.i = n1;
    _r2_o = n2;
    _r3.i = n3;
    ((global::java.nio.DoubleArrayBuffer) _r0_o).@this((int) _r1.i, (global::org.xmlvm._nArrayAdapter<double>) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: void <init>(int, double[], int)]
}

public override global::System.Object asReadOnlyBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer asReadOnlyBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r1_o)._fmark;
    _r0_o = global::java.nio.ReadOnlyDoubleArrayBuffer.copy((global::java.nio.DoubleArrayBuffer) _r1_o, (int) _r0.i);
    return (global::java.nio.DoubleBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer asReadOnlyBuffer()]
}

public override global::System.Object compact(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer compact()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r0_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fbackingArray;
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition;
    _r2.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._foffset;
    _r1.i = _r1.i + _r2.i;
    _r2_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fbackingArray;
    _r3.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._foffset;
    _r4.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o).remaining();
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r1.i, (global::java.lang.Object) _r2_o, (int) _r3.i, (int) _r4.i);
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._flimit;
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition = _r0.i;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fcapacity;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._flimit = _r0.i;
    _r0.i = -1;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fmark = _r0.i;
    return (global::java.nio.DoubleBuffer) _r5_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer compact()]
}

public override global::System.Object duplicate(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer duplicate()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r1_o)._fmark;
    _r0_o = global::java.nio.ReadWriteDoubleArrayBuffer.copy((global::java.nio.DoubleArrayBuffer) _r1_o, (int) _r0.i);
    return (global::java.nio.DoubleBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer duplicate()]
}

public override bool isReadOnly(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: boolean isReadOnly()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: boolean isReadOnly()]
}

public override global::System.Object protectedArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: double[] protectedArray()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r1_o)._fbackingArray;
    return (global::org.xmlvm._nArrayAdapter<double>) _r0_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: double[] protectedArray()]
}

public override int protectedArrayOffset(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: int protectedArrayOffset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r1_o)._foffset;
    return _r0.i;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: int protectedArrayOffset()]
}

public override bool protectedHasArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: boolean protectedHasArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: boolean protectedHasArray()]
}

public override global::System.Object put(double n1){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer put(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.d = n1;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r4_o)._fposition;
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r4_o)._flimit;
    if (_r0.i != _r1.i) goto label12;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r4_o)._fbackingArray;
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r4_o)._foffset;
    _r2.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r4_o)._fposition;
    _r3.i = _r2.i + 1;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r4_o)._fposition = _r3.i;
    _r1.i = _r1.i + _r2.i;
    ((global::org.xmlvm._nArrayAdapter<double>) _r0_o)[_r1.i] = _r5.d;
    return (global::java.nio.DoubleBuffer) _r4_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer put(double)]
}

public override global::System.Object put(int n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer put(int, double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3.i = n1;
    _r4.d = n2;
    if (_r3.i < 0) goto label6;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r2_o)._flimit;
    if (_r3.i < _r0.i) goto label12;
    label6:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r2_o)._fbackingArray;
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r2_o)._foffset;
    _r1.i = _r1.i + _r3.i;
    ((global::org.xmlvm._nArrayAdapter<double>) _r0_o)[_r1.i] = _r4.d;
    return (global::java.nio.DoubleBuffer) _r2_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer put(int, double)]
}

public override global::System.Object put(global::org.xmlvm._nArrayAdapter<double> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer put(double[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r5_o = this;
    _r6_o = n1;
    _r7.i = n2;
    _r8.i = n3;
    _r0.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    if (_r7.i < 0) goto label13;
    if (_r8.i < 0) goto label13;
    _r1.l = (long) _r7.i;
    _r3.l = (long) _r8.i;
    _r1.l = _r1.l + _r3.l;
    _r3.l = (long) _r0.i;
    _r0.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r0.i <= 0) goto label19;
    label13:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label19:;
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o).remaining();
    if (_r8.i <= _r0.i) goto label31;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label31:;
    _r0_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fbackingArray;
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._foffset;
    _r2.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition;
    _r1.i = _r1.i + _r2.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r6_o, (int) _r7.i, (global::java.lang.Object) _r0_o, (int) _r1.i, (int) _r8.i);
    _r0.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition;
    _r0.i = _r0.i + _r8.i;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition = _r0.i;
    return (global::java.nio.DoubleBuffer) _r5_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer put(double[], int, int)]
}

public override global::System.Object slice(){
//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer slice()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r0_o = new global::java.nio.ReadWriteDoubleArrayBuffer();
    _r1.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o).remaining();
    _r2_o = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fbackingArray;
    _r3.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._foffset;
    _r4.i = ((global::java.nio.ReadWriteDoubleArrayBuffer) _r5_o)._fposition;
    _r3.i = _r3.i + _r4.i;
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o).@this((int) _r1.i, (global::org.xmlvm._nArrayAdapter<double>) _r2_o, (int) _r3.i);
    return (global::java.nio.DoubleBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer: java.nio.DoubleBuffer slice()]
}

//XMLVM_BEGIN_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer]
//XMLVM_END_WRAPPER[java.nio.ReadWriteDoubleArrayBuffer]

} // end of class: ReadWriteDoubleArrayBuffer

} // end of namespace: java.nio
