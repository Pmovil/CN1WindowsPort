// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.charset {
public class ISO_18859_11_2Decoder: global::java.nio.charset.CharsetDecoder {
public global::org.apache.harmony.niochar.charset.ISO_18859_11 _fthis_20;

private void @this(global::org.apache.harmony.niochar.charset.ISO_18859_11 n1, global::java.nio.charset.Charset n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.f = (float)1.0D;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_11_2Decoder) _r1_o)._fthis_20 = (global::org.apache.harmony.niochar.charset.ISO_18859_11) _r2_o;
    ((global::java.nio.charset.CharsetDecoder) _r1_o).@this((global::java.nio.charset.Charset) _r3_o, (float) _r0.f, (float) _r0.f);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset)]
}

private int nDecode(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3, long n4, int n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: int nDecode(char[], int, int, long, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: int nDecode(char[], int, int, long, int)]
}

public override global::System.Object decodeLoop(global::java.nio.ByteBuffer n1, global::java.nio.CharBuffer n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer, java.nio.CharBuffer)]
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
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r3.i = 0;
    _r0.i = ((global::java.nio.ByteBuffer) _r10_o).remaining();
    if (_r0.i != 0) goto label10;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    label9:;
    return (global::java.nio.charset.CoderResult) _r0_o;
    label10:;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).remaining();
    _r2.i = ((global::java.nio.CharBuffer) _r11_o).hasArray() ? 1 : 0;
    if (_r2.i == 0) goto label148;
    _r2.i = ((global::java.nio.ByteBuffer) _r10_o).hasArray() ? 1 : 0;
    if (_r2.i == 0) goto label85;
    if (_r1.i < _r0.i) goto label67;
    label28:;
    _r2_o = ((global::java.nio.ByteBuffer) _r10_o).array();
    _r3_o = ((global::java.nio.CharBuffer) _r11_o).array();
    _r4.i = ((global::java.nio.ByteBuffer) _r10_o).position();
    _r5.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r6.i = _r5.i;
    _r5.i = _r4.i;
    label46:;
    _r7.i = _r4.i + _r0.i;
    if (_r5.i < _r7.i) goto label69;
    ((global::java.nio.ByteBuffer) _r10_o).position((int) _r5.i);
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r6.i);
    if (_r0.i != _r1.i) goto label82;
    _r0.i = ((global::java.nio.ByteBuffer) _r10_o).hasRemaining() ? 1 : 0;
    if (_r0.i == 0) goto label82;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label9;
    label67:;
    _r0.i = _r1.i;
    goto label28;
    label69:;
    _r7.i = _r6.i + 1;
    _r8.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r5.i];
    _r8.i = _r8.i & 255;
    _r8.i = _r8.i & 0xffff;
    ((global::org.xmlvm._nArrayAdapter<char>) _r3_o)[_r6.i] = (char)_r8.i;
    _r5.i = _r5.i + 1;
    _r6.i = _r7.i;
    goto label46;
    label82:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label9;
    label85:;
    _r2.i = global::org.apache.harmony.niochar.CharsetProviderImpl.hasLoadedNatives() ? 1 : 0;
    if (_r2.i == 0) goto label148;
    _r2.i = ((global::java.nio.ByteBuffer) _r10_o).isDirect() ? 1 : 0;
    if (_r2.i == 0) goto label148;
    _r7.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r6.i = ((global::java.nio.ByteBuffer) _r10_o).position();
    if (_r1.i >= _r0.i) goto label188;
    _r0.i = 1;
    _r8.i = _r0.i;
    _r3.i = _r1.i;
    label110:;
    _r1_o = ((global::java.nio.CharBuffer) _r11_o).array();
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).arrayOffset();
    _r2.i = _r0.i + _r7.i;
// Red class access removed: org.apache.harmony.nio.AddressUtil getDirectBufferAddress
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.nio.AddressUtil getDirectBufferAddress");
    _r0_o = _r9_o;
    _r0.i = ((global::org.apache.harmony.niochar.charset.ISO_18859_11_2Decoder) _r0_o).nDecode((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (int) _r2.i, (int) _r3.i, (long) _r4.l, (int) _r6.i);
    _r1.i = _r7.i + _r0.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r1.i);
    _r0.i = _r0.i + _r6.i;
    ((global::java.nio.ByteBuffer) _r10_o).position((int) _r0.i);
    if (_r8.i == 0) goto label144;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label9;
    label144:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label9;
    label148:;
    if (_r1.i < _r0.i) goto label172;
    label150:;
    _r1_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    ((global::java.nio.ByteBuffer) _r10_o).get((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o);
    _r2_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r0.i]);
    label157:;
    if (_r3.i < _r0.i) goto label174;
    ((global::java.nio.CharBuffer) _r11_o).put((global::org.xmlvm._nArrayAdapter<char>) _r2_o);
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).remaining();
    if (_r0.i != 0) goto label184;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label9;
    label172:;
    _r0.i = _r1.i;
    goto label150;
    label174:;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r3.i];
    _r4.i = _r4.i & 255;
    _r4.i = _r4.i & 0xffff;
    ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r3.i] = (char)_r4.i;
    _r3.i = _r3.i + 1;
    goto label157;
    label184:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label9;
    label188:;
    _r8.i = _r3.i;
    _r3.i = _r0.i;
    goto label110;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer, java.nio.CharBuffer)]
}

public void @this(global::org.apache.harmony.niochar.charset.ISO_18859_11 n1, global::java.nio.charset.Charset n2, global::org.apache.harmony.niochar.charset.ISO_18859_11_2Decoder n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset, org.apache.harmony.niochar.charset.ISO_8859_1$Decoder)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_11_2Decoder) _r0_o).@this((global::org.apache.harmony.niochar.charset.ISO_18859_11) _r1_o, (global::java.nio.charset.Charset) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset, org.apache.harmony.niochar.charset.ISO_8859_1$Decoder)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Decoder]

} // end of class: ISO_18859_11_2Decoder

} // end of namespace: org.apache.harmony.niochar.charset
