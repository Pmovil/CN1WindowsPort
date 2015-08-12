// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.math {
public class BitLevel: global::java.lang.Object {
private void @this(){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.math.BitLevel: void <init>()]
}

public static int bitLength(global::java.math.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: int bitLength(java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = n1;
    _r4.i = 1;
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fsign;
    if (_r0.i != 0) goto label7;
    _r0.i = 0;
    label6:;
    return _r0.i;
    label7:;
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r0.i = _r0.i << (0x1f & 5);
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r2.i = _r2.i - _r4.i;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i];
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fsign;
    if (_r2.i >= 0) goto label33;
    _r2.i = ((global::java.math.BigInteger) _r5_o).getFirstNonzeroDigit();
    _r3.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3.i = _r3.i - _r4.i;
    if (_r2.i != _r3.i) goto label33;
    _r1.i = _r1.i + -1;
    label33:;
    _r1.i = global::java.lang.Integer.numberOfLeadingZeros((int) _r1.i);
    _r0.i = _r0.i - _r1.i;
    goto label6;
//XMLVM_END_WRAPPER[java.math.BitLevel: int bitLength(java.math.BigInteger)]
}

public static int bitCount(global::java.math.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: int bitCount(java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = n1;
    _r2.i = 0;
    _r0.i = ((global::java.math.BigInteger) _r3_o)._fsign;
    if (_r0.i != 0) goto label7;
    _r0.i = _r2.i;
    label6:;
    return _r0.i;
    label7:;
    _r0.i = ((global::java.math.BigInteger) _r3_o).getFirstNonzeroDigit();
    _r1.i = ((global::java.math.BigInteger) _r3_o)._fsign;
    if (_r1.i <= 0) goto label34;
    _r1.i = _r2.i;
    label16:;
    _r2.i = ((global::java.math.BigInteger) _r3_o)._fnumberLength;
    if (_r0.i < _r2.i) goto label22;
    _r0.i = _r1.i;
    goto label6;
    label22:;
    _r2_o = ((global::java.math.BigInteger) _r3_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    _r2.i = global::java.lang.Integer.bitCount((int) _r2.i);
    _r1.i = _r1.i + _r2.i;
    _r0.i = _r0.i + 1;
    goto label16;
    label34:;
    _r1_o = ((global::java.math.BigInteger) _r3_o)._fdigits;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i];
    _r1.i = -_r1.i;
    _r1.i = global::java.lang.Integer.bitCount((int) _r1.i);
    _r1.i = _r1.i + _r2.i;
    _r0.i = _r0.i + 1;
    label46:;
    _r2.i = ((global::java.math.BigInteger) _r3_o)._fnumberLength;
    if (_r0.i < _r2.i) goto label56;
    _r0.i = ((global::java.math.BigInteger) _r3_o)._fnumberLength;
    _r0.i = _r0.i << (0x1f & 5);
    _r0.i = _r0.i - _r1.i;
    goto label6;
    label56:;
    _r2_o = ((global::java.math.BigInteger) _r3_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    _r2.i = _r2.i ^ -1;
    _r2.i = global::java.lang.Integer.bitCount((int) _r2.i);
    _r1.i = _r1.i + _r2.i;
    _r0.i = _r0.i + 1;
    goto label46;
//XMLVM_END_WRAPPER[java.math.BitLevel: int bitCount(java.math.BigInteger)]
}

public static bool testBit(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: boolean testBit(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = n1;
    _r4.i = n2;
    _r2.i = 1;
    _r0_o = ((global::java.math.BigInteger) _r3_o)._fdigits;
    _r1.i = _r4.i >> (0x1f & 5);
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i];
    _r1.i = _r4.i & 31;
    _r1.i = _r2.i << (0x1f & _r1.i);
    _r0.i = _r0.i & _r1.i;
    if (_r0.i == 0) goto label16;
    _r0.i = _r2.i;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0.i = 0;
    goto label15;
//XMLVM_END_WRAPPER[java.math.BitLevel: boolean testBit(java.math.BigInteger, int)]
}

public static bool nonZeroDroppedBits(int n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: boolean nonZeroDroppedBits(int, int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r5.i = n1;
    _r6_o = n2;
    _r4.i = 0;
    _r0.i = _r5.i >> (0x1f & 5);
    _r1.i = _r5.i & 31;
    _r2.i = _r4.i;
    label6:;
    if (_r2.i >= _r0.i) goto label12;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r2.i];
    if (_r3.i == 0) goto label25;
    label12:;
    if (_r2.i != _r0.i) goto label28;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r2.i];
    _r2.i = 32;
    _r1.i = _r2.i - _r1.i;
    _r0.i = _r0.i << (0x1f & _r1.i);
    if (_r0.i != 0) goto label28;
    _r0.i = _r4.i;
    label24:;
    return _r0.i!=0;
    label25:;
    _r2.i = _r2.i + 1;
    goto label6;
    label28:;
    _r0.i = 1;
    goto label24;
//XMLVM_END_WRAPPER[java.math.BitLevel: boolean nonZeroDroppedBits(int, int[])]
}

public static global::System.Object shiftLeft(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: java.math.BigInteger shiftLeft(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r5_o = n1;
    _r6.i = n2;
    _r0.i = _r6.i >> (0x1f & 5);
    _r1.i = _r6.i & 31;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r2.i = _r2.i + _r0.i;
    if (_r1.i != 0) goto label29;
    _r3.i = 0;
    label10:;
    _r2.i = _r2.i + _r3.i;
    _r3_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r2.i]);
    _r4_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    global::java.math.BitLevel.shiftLeft((global::org.xmlvm._nArrayAdapter<int>) _r3_o, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r0.i, (int) _r1.i);
    _r0_o = new global::java.math.BigInteger();
    _r1.i = ((global::java.math.BigInteger) _r5_o)._fsign;
    ((global::java.math.BigInteger) _r0_o).@this((int) _r1.i, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o);
    ((global::java.math.BigInteger) _r0_o).cutOffLeadingZeroes();
    return (global::java.math.BigInteger) _r0_o;
    label29:;
    _r3.i = 1;
    goto label10;
//XMLVM_END_WRAPPER[java.math.BitLevel: java.math.BigInteger shiftLeft(java.math.BigInteger, int)]
}

public static void inplaceShiftLeft(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: void inplaceShiftLeft(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r5_o = n1;
    _r6.i = n2;
    _r4.i = 1;
    _r0.i = _r6.i >> (0x1f & 5);
    _r1.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r2_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r3.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3.i = _r3.i - _r4.i;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r3.i];
    _r2.i = global::java.lang.Integer.numberOfLeadingZeros((int) _r2.i);
    _r3.i = _r6.i & 31;
    _r2.i = _r2.i - _r3.i;
    if (_r2.i < 0) goto label42;
    _r2.i = 0;
    label22:;
    _r2.i = _r2.i + _r0.i;
    _r1.i = _r1.i + _r2.i;
    ((global::java.math.BigInteger) _r5_o)._fnumberLength = _r1.i;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r3.i = _r6.i & 31;
    global::java.math.BitLevel.shiftLeft((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (global::org.xmlvm._nArrayAdapter<int>) _r2_o, (int) _r0.i, (int) _r3.i);
    ((global::java.math.BigInteger) _r5_o).cutOffLeadingZeroes();
    ((global::java.math.BigInteger) _r5_o).unCache();
    return;
    label42:;
    _r2.i = _r4.i;
    goto label22;
//XMLVM_END_WRAPPER[java.math.BitLevel: void inplaceShiftLeft(java.math.BigInteger, int)]
}

public static void shiftLeft(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: void shiftLeft(int[], int[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r6_o = n1;
    _r7_o = n2;
    _r8.i = n3;
    _r9.i = n4;
    _r5.i = 0;
    _r4.i = 1;
    if (_r9.i != 0) goto label13;
    _r0.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r0.i = _r0.i - _r8.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r7_o, (int) _r5.i, (global::java.lang.Object) _r6_o, (int) _r8.i, (int) _r0.i);
    label9:;
    _r0.i = _r5.i;
    label10:;
    if (_r0.i < _r8.i) goto label48;
    return;
    label13:;
    _r0.i = 32;
    _r0.i = _r0.i - _r9.i;
    _r1.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r1.i = _r1.i - _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r5.i;
    _r1.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r1.i = _r1.i - _r4.i;
    label22:;
    if (_r1.i <= _r8.i) goto label9;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i];
    _r3.i = _r1.i - _r8.i;
    _r3.i = _r3.i - _r4.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r3.i];
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & (_r0.i)));
    _r2.i = _r2.i | _r3.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r2.i;
    _r2.i = _r1.i - _r4.i;
    _r3.i = _r1.i - _r8.i;
    _r3.i = _r3.i - _r4.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r3.i];
    _r3.i = _r3.i << (0x1f & _r9.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r2.i] = _r3.i;
    _r1.i = _r1.i + -1;
    goto label22;
    label48:;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i] = _r5.i;
    _r0.i = _r0.i + 1;
    goto label10;
//XMLVM_END_WRAPPER[java.math.BitLevel: void shiftLeft(int[], int[], int, int)]
}

public static void shiftLeftOneBit(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: void shiftLeftOneBit(int[], int[], int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3;
    _r0.i = 0;
    _r1.i = _r0.i;
    label2:;
    if (_r0.i < _r6.i) goto label9;
    if (_r1.i == 0) goto label8;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r6.i] = _r1.i;
    label8:;
    return;
    label9:;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r0.i];
    _r3.i = _r2.i << (0x1f & 1);
    _r1.i = _r1.i | _r3.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r0.i] = _r1.i;
    _r1.i = (int) (((uint) _r2.i) >> (0x1f & ((int) 31)));
    _r0.i = _r0.i + 1;
    goto label2;
//XMLVM_END_WRAPPER[java.math.BitLevel: void shiftLeftOneBit(int[], int[], int)]
}

public static global::System.Object shiftLeftOneBit(global::java.math.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: java.math.BigInteger shiftLeftOneBit(java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = n1;
    _r0.i = ((global::java.math.BigInteger) _r4_o)._fnumberLength;
    _r1.i = _r0.i + 1;
    _r2_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r3_o = ((global::java.math.BigInteger) _r4_o)._fdigits;
    global::java.math.BitLevel.shiftLeftOneBit((global::org.xmlvm._nArrayAdapter<int>) _r2_o, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r0.i);
    _r0_o = new global::java.math.BigInteger();
    _r3.i = ((global::java.math.BigInteger) _r4_o)._fsign;
    ((global::java.math.BigInteger) _r0_o).@this((int) _r3.i, (int) _r1.i, (global::org.xmlvm._nArrayAdapter<int>) _r2_o);
    ((global::java.math.BigInteger) _r0_o).cutOffLeadingZeroes();
    return (global::java.math.BigInteger) _r0_o;
//XMLVM_END_WRAPPER[java.math.BitLevel: java.math.BigInteger shiftLeftOneBit(java.math.BigInteger)]
}

public static global::System.Object shiftRight(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: java.math.BigInteger shiftRight(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r7_o = n1;
    _r8.i = n2;
    _r6.i = 0;
    _r0.i = _r8.i >> (0x1f & 5);
    _r1.i = _r8.i & 31;
    _r2.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    if (_r0.i < _r2.i) goto label19;
    _r0.i = ((global::java.math.BigInteger) _r7_o)._fsign;
    if (_r0.i >= 0) goto label16;
    _r0_o = global::java.math.BigInteger._fMINUS_1ONE;
    label15:;
    return (global::java.math.BigInteger) _r0_o;
    label16:;
    _r0_o = global::java.math.BigInteger._fZERO;
    goto label15;
    label19:;
    _r2.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    _r2.i = _r2.i - _r0.i;
    _r3.i = _r2.i + 1;
    _r3_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r4_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    global::java.math.BitLevel.shiftRight((global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r0.i, (int) _r1.i);
    _r4.i = ((global::java.math.BigInteger) _r7_o)._fsign;
    if (_r4.i >= 0) goto label100;
    _r4.i = _r6.i;
    label36:;
    if (_r4.i >= _r0.i) goto label44;
    _r5_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i];
    if (_r5.i == 0) goto label90;
    label44:;
    if (_r4.i < _r0.i) goto label59;
    if (_r1.i <= 0) goto label100;
    _r0_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r4.i];
    _r4.i = 32;
    _r1.i = _r4.i - _r1.i;
    _r0.i = _r0.i << (0x1f & _r1.i);
    if (_r0.i == 0) goto label100;
    label59:;
    _r0.i = _r6.i;
    label60:;
    if (_r0.i >= _r2.i) goto label67;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    _r4.i = -1;
    if (_r1.i == _r4.i) goto label93;
    label67:;
    if (_r0.i != _r2.i) goto label98;
    _r1.i = _r2.i + 1;
    label71:;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    _r2.i = _r2.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i] = _r2.i;
    _r0.i = _r1.i;
    label78:;
    _r1_o = new global::java.math.BigInteger();
    _r2.i = ((global::java.math.BigInteger) _r7_o)._fsign;
    ((global::java.math.BigInteger) _r1_o).@this((int) _r2.i, (int) _r0.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o);
    ((global::java.math.BigInteger) _r1_o).cutOffLeadingZeroes();
    _r0_o = _r1_o;
    goto label15;
    label90:;
    _r4.i = _r4.i + 1;
    goto label36;
    label93:;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i] = _r6.i;
    _r0.i = _r0.i + 1;
    goto label60;
    label98:;
    _r1.i = _r2.i;
    goto label71;
    label100:;
    _r0.i = _r2.i;
    goto label78;
//XMLVM_END_WRAPPER[java.math.BitLevel: java.math.BigInteger shiftRight(java.math.BigInteger, int)]
}

public static void inplaceShiftRight(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: void inplaceShiftRight(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r7_o = n1;
    _r8.i = n2;
    _r6.i = 0;
    _r0.i = ((global::java.math.BigInteger) _r7_o).signum();
    if (_r8.i == 0) goto label13;
    _r1.i = ((global::java.math.BigInteger) _r7_o).signum();
    if (_r1.i != 0) goto label14;
    label13:;
    return;
    label14:;
    _r1.i = _r8.i >> (0x1f & 5);
    _r2.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    _r2.i = _r2.i - _r1.i;
    ((global::java.math.BigInteger) _r7_o)._fnumberLength = _r2.i;
    _r2_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r3.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    _r4_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r5.i = _r8.i & 31;
    _r1.i = global::java.math.BitLevel.shiftRight((global::org.xmlvm._nArrayAdapter<int>) _r2_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r1.i, (int) _r5.i) ? 1 : 0;
    if (_r1.i != 0) goto label67;
    if (_r0.i >= 0) goto label67;
    _r0.i = _r6.i;
    label38:;
    _r1.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    if (_r0.i >= _r1.i) goto label49;
    _r1_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i];
    _r2.i = -1;
    if (_r1.i == _r2.i) goto label74;
    label49:;
    _r1.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    if (_r0.i != _r1.i) goto label59;
    _r1.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    _r1.i = _r1.i + 1;
    ((global::java.math.BigInteger) _r7_o)._fnumberLength = _r1.i;
    label59:;
    _r1_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i];
    _r2.i = _r2.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i] = _r2.i;
    label67:;
    ((global::java.math.BigInteger) _r7_o).cutOffLeadingZeroes();
    ((global::java.math.BigInteger) _r7_o).unCache();
    goto label13;
    label74:;
    _r1_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i] = _r6.i;
    _r0.i = _r0.i + 1;
    goto label38;
//XMLVM_END_WRAPPER[java.math.BitLevel: void inplaceShiftRight(java.math.BigInteger, int)]
}

public static bool shiftRight(global::org.xmlvm._nArrayAdapter<int> n1, int n2, global::org.xmlvm._nArrayAdapter<int> n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: boolean shiftRight(int[], int, int[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    _r6_o = n1;
    _r7.i = n2;
    _r8_o = n3;
    _r9.i = n4;
    _r10.i = n5;
    _r5.i = 1;
    _r3.i = 0;
    _r0.i = _r5.i;
    _r1.i = _r3.i;
    label4:;
    if (_r1.i < _r9.i) goto label12;
    if (_r10.i != 0) goto label23;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r8_o, (int) _r9.i, (global::java.lang.Object) _r6_o, (int) _r3.i, (int) _r7.i);
    label11:;
    return _r0.i!=0;
    label12:;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r1.i];
    if (_r2.i != 0) goto label21;
    _r2.i = _r5.i;
    label17:;
    _r0.i = _r0.i & _r2.i;
    _r1.i = _r1.i + 1;
    goto label4;
    label21:;
    _r2.i = _r3.i;
    goto label17;
    label23:;
    _r2.i = 32;
    _r2.i = _r2.i - _r10.i;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r1.i];
    _r1.i = _r1.i << (0x1f & _r2.i);
    if (_r1.i != 0) goto label48;
    _r1.i = _r5.i;
    label32:;
    _r0.i = _r0.i & _r1.i;
    _r1.i = _r3.i;
    label34:;
    _r3.i = _r7.i - _r5.i;
    if (_r1.i < _r3.i) goto label50;
    _r2.i = _r1.i + _r9.i;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r2.i];
    _r2.i = (int) (((uint) _r2.i) >> (0x1f & (_r10.i)));
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r2.i;
    _r1.i = _r1.i + 1;
    goto label11;
    label48:;
    _r1.i = _r3.i;
    goto label32;
    label50:;
    _r3.i = _r1.i + _r9.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r3.i];
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & (_r10.i)));
    _r4.i = _r1.i + _r9.i;
    _r4.i = _r4.i + 1;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r4.i];
    _r4.i = _r4.i << (0x1f & _r2.i);
    _r3.i = _r3.i | _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r3.i;
    _r1.i = _r1.i + 1;
    goto label34;
//XMLVM_END_WRAPPER[java.math.BitLevel: boolean shiftRight(int[], int, int[], int, int)]
}

public static global::System.Object flipBit(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.BitLevel: java.math.BigInteger flipBit(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    _r10_o = n1;
    _r11.i = n2;
    _r9.i = -1;
    _r8.i = 1;
    _r7.i = 0;
    _r0.i = ((global::java.math.BigInteger) _r10_o)._fsign;
    if (_r0.i != 0) goto label52;
    _r0.i = _r8.i;
    label8:;
    _r1.i = _r11.i >> (0x1f & 5);
    _r2.i = _r11.i & 31;
    _r3.i = _r1.i + 1;
    _r4.i = ((global::java.math.BigInteger) _r10_o)._fnumberLength;
    _r3.i = global::java.lang.Math.max((int) _r3.i, (int) _r4.i);
    _r3.i = _r3.i + 1;
    _r4_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r2.i = _r8.i << (0x1f & _r2.i);
    _r5_o = ((global::java.math.BigInteger) _r10_o)._fdigits;
    _r6.i = ((global::java.math.BigInteger) _r10_o)._fnumberLength;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r5_o, (int) _r7.i, (global::java.lang.Object) _r4_o, (int) _r7.i, (int) _r6.i);
    _r5.i = ((global::java.math.BigInteger) _r10_o)._fsign;
    if (_r5.i >= 0) goto label119;
    _r5.i = ((global::java.math.BigInteger) _r10_o)._fnumberLength;
    if (_r1.i < _r5.i) goto label55;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    label43:;
    _r1_o = new global::java.math.BigInteger();
    ((global::java.math.BigInteger) _r1_o).@this((int) _r0.i, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o);
    ((global::java.math.BigInteger) _r1_o).cutOffLeadingZeroes();
    return (global::java.math.BigInteger) _r1_o;
    label52:;
    _r0.i = ((global::java.math.BigInteger) _r10_o)._fsign;
    goto label8;
    label55:;
    _r5.i = ((global::java.math.BigInteger) _r10_o).getFirstNonzeroDigit();
    if (_r1.i <= _r5.i) goto label67;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    _r2.i = _r2.i ^ _r5.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    goto label43;
    label67:;
    if (_r1.i >= _r5.i) goto label90;
    _r2.i = -_r2.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    _r1.i = _r1.i + 1;
    label74:;
    if (_r1.i < _r5.i) goto label85;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    _r5.i = _r2.i - _r8.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r5.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    goto label43;
    label85:;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r9.i;
    _r1.i = _r1.i + 1;
    goto label74;
    label90:;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    _r5.i = -_r5.i;
    _r2.i = _r2.i ^ _r5.i;
    _r2.i = -_r2.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    if (_r2.i != 0) goto label43;
    _r1.i = _r1.i + 1;
    label103:;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    if (_r2.i == _r9.i) goto label114;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    _r2.i = _r2.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    goto label43;
    label114:;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r7.i;
    _r1.i = _r1.i + 1;
    goto label103;
    label119:;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i];
    _r2.i = _r2.i ^ _r5.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r2.i;
    goto label43;
//XMLVM_END_WRAPPER[java.math.BitLevel: java.math.BigInteger flipBit(java.math.BigInteger, int)]
}

//XMLVM_BEGIN_WRAPPER[java.math.BitLevel]
//XMLVM_END_WRAPPER[java.math.BitLevel]

} // end of class: BitLevel

} // end of namespace: java.math
