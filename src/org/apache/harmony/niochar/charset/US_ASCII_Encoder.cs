// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.charset {
public class US_1ASCII_2Encoder: global::java.nio.charset.CharsetEncoder {
public global::org.apache.harmony.niochar.charset.US_1ASCII _fthis_20;

private void @this(global::org.apache.harmony.niochar.charset.US_1ASCII n1, global::java.nio.charset.Charset n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: void <init>(org.apache.harmony.niochar.charset.US_ASCII, java.nio.charset.Charset)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.f = (float)1.0D;
    ((global::org.apache.harmony.niochar.charset.US_1ASCII_2Encoder) _r1_o)._fthis_20 = (global::org.apache.harmony.niochar.charset.US_1ASCII) _r2_o;
    ((global::java.nio.charset.CharsetEncoder) _r1_o).@this((global::java.nio.charset.Charset) _r3_o, (float) _r0.f, (float) _r0.f);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: void <init>(org.apache.harmony.niochar.charset.US_ASCII, java.nio.charset.Charset)]
}

private void nEncode(long n1, int n2, global::org.xmlvm._nArrayAdapter<char> n3, int n4, global::org.xmlvm._nArrayAdapter<int> n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: void nEncode(long, int, char[], int, int[])]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: void nEncode(long, int, char[], int, int[])]
}

public override global::System.Object encodeLoop(global::java.nio.CharBuffer n1, global::java.nio.ByteBuffer n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer, java.nio.ByteBuffer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    _r10_o = this;
    _r11_o = n1;
    _r12_o = n2;
    _r0.i = ((global::java.nio.ByteBuffer) _r12_o).remaining();
    _r1.i = global::org.apache.harmony.niochar.CharsetProviderImpl.hasLoadedNatives() ? 1 : 0;
    if (_r1.i == 0) goto label136;
    _r1.i = ((global::java.nio.ByteBuffer) _r12_o).isDirect() ? 1 : 0;
    if (_r1.i == 0) goto label136;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r1.i == 0) goto label136;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).hasArray() ? 1 : 0;
    if (_r1.i == 0) goto label136;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).remaining();
    _r2.i = 0;
    _r7.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r3.i = ((global::java.nio.ByteBuffer) _r12_o).position();
    if (_r0.i >= _r1.i) goto label424;
    _r1.i = 1;
    _r8.i = _r1.i;
    label45:;
    _r1.i = 2;
    _r6_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r1.i = 0;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r0.i;
// Red class access removed: org.apache.harmony.nio.AddressUtil getDirectBufferAddress
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.nio.AddressUtil getDirectBufferAddress");
    _r4_o = ((global::java.nio.CharBuffer) _r11_o).array();
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).arrayOffset();
    _r5.i = _r0.i + _r7.i;
    _r0_o = _r10_o;
    ((global::org.apache.harmony.niochar.charset.US_1ASCII_2Encoder) _r0_o).nEncode((long) _r1.l, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (global::org.xmlvm._nArrayAdapter<int>) _r6_o);
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    if (_r0.i > 0) goto label117;
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r3.i - _r0.i;
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r0.i);
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r7.i - _r0.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    if (_r0.i == 0) goto label420;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    if (_r0.i >= 0) goto label109;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = -_r0.i;
    _r0_o = global::java.nio.charset.CoderResult.malformedForLength((int) _r0.i);
    label108:;
    return (global::java.nio.charset.CoderResult) _r0_o;
    label109:;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label108;
    label117:;
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r0.i + _r3.i;
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r0.i);
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r0.i + _r7.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    if (_r8.i == 0) goto label420;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label108;
    label136:;
    _r1.i = ((global::java.nio.ByteBuffer) _r12_o).hasArray() ? 1 : 0;
    if (_r1.i == 0) goto label414;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).hasArray() ? 1 : 0;
    if (_r1.i == 0) goto label414;
    _r1_o = ((global::java.nio.ByteBuffer) _r12_o).array();
    _r2_o = ((global::java.nio.CharBuffer) _r11_o).array();
    _r3.i = ((global::java.nio.CharBuffer) _r11_o).remaining();
    _r4.i = ((global::java.nio.ByteBuffer) _r12_o).position();
    if (_r0.i > _r3.i) goto label167;
    _r3.i = _r0.i;
    label167:;
    _r5.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r9.i = _r5.i;
    _r5.i = _r4.i;
    _r4.i = _r9.i;
    label174:;
    _r6.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r6.i = _r6.i + _r3.i;
    if (_r4.i < _r6.i) goto label198;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r4.i);
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r5.i);
    if (_r3.i != _r0.i) goto label420;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r0.i == 0) goto label420;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label108;
    label198:;
    _r6.i = ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r4.i];
    _r7.i = 127;
    if (_r6.i <= _r7.i) goto label285;
    _r0.i = 55296;
    if (_r6.i < _r0.i) goto label272;
    _r0.i = 57343;
    if (_r6.i > _r0.i) goto label272;
    _r0.i = _r4.i + 1;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).limit();
    if (_r0.i >= _r1.i) goto label249;
    _r0.i = _r4.i + 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r0.i];
    _r1.i = 55296;
    if (_r0.i < _r1.i) goto label259;
    _r1.i = 57343;
    if (_r0.i > _r1.i) goto label259;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r4.i);
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r5.i);
    _r0.i = 2;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label108;
    label249:;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r4.i);
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r5.i);
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label108;
    label259:;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r4.i);
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r5.i);
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.malformedForLength((int) _r0.i);
    goto label108;
    label272:;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r4.i);
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r5.i);
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label108;
    label285:;
    _r7.i = _r5.i + 1;
    _r6.i = (_r6.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r5.i] = (sbyte)_r6.i;
    _r4.i = _r4.i + 1;
    _r5.i = _r7.i;
    goto label174;
    label294:;
    if (_r0.i != 0) goto label300;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label108;
    label300:;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).get();
    _r2.i = 127;
    if (_r1.i <= _r2.i) goto label408;
    _r0.i = 55296;
    if (_r1.i < _r0.i) goto label392;
    _r0.i = 57343;
    if (_r1.i > _r0.i) goto label392;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r0.i == 0) goto label379;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).get();
    _r1.i = 55296;
    if (_r0.i < _r1.i) goto label354;
    _r1.i = 57343;
    if (_r0.i > _r1.i) goto label354;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 2;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 2;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label108;
    label354:;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.malformedForLength((int) _r0.i);
    goto label108;
    label379:;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label108;
    label392:;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label108;
    label408:;
    _r1.i = (_r1.i << 24) >> 24;
    ((global::java.nio.ByteBuffer) _r12_o).put((sbyte) _r1.i);
    _r0.i = _r0.i + -1;
    label414:;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r1.i != 0) goto label294;
    label420:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label108;
    label424:;
    _r8.i = _r2.i;
    _r0.i = _r1.i;
    goto label45;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer, java.nio.ByteBuffer)]
}

public void @this(global::org.apache.harmony.niochar.charset.US_1ASCII n1, global::java.nio.charset.Charset n2, global::org.apache.harmony.niochar.charset.US_1ASCII_2Encoder n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: void <init>(org.apache.harmony.niochar.charset.US_ASCII, java.nio.charset.Charset, org.apache.harmony.niochar.charset.US_ASCII$Encoder)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::org.apache.harmony.niochar.charset.US_1ASCII_2Encoder) _r0_o).@this((global::org.apache.harmony.niochar.charset.US_1ASCII) _r1_o, (global::java.nio.charset.Charset) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder: void <init>(org.apache.harmony.niochar.charset.US_ASCII, java.nio.charset.Charset, org.apache.harmony.niochar.charset.US_ASCII$Encoder)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.US_ASCII$Encoder]

} // end of class: US_1ASCII_2Encoder

} // end of namespace: org.apache.harmony.niochar.charset
