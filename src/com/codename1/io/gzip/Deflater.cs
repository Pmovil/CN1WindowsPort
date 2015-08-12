// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.gzip {
public class Deflater: global::com.codename1.io.gzip.ZStream {
private static int _fMAX_1WBITS = 15;

private static int _fDEF_1WBITS = 15;

private static int _fZ_1NO_1FLUSH = 0;

private static int _fZ_1PARTIAL_1FLUSH = 1;

private static int _fZ_1SYNC_1FLUSH = 2;

private static int _fZ_1FULL_1FLUSH = 3;

private static int _fZ_1FINISH = 4;

private static int _fMAX_1MEM_1LEVEL = 9;

private static int _fZ_1OK = 0;

private static int _fZ_1STREAM_1END = 1;

private static int _fZ_1NEED_1DICT = 2;

private static int _fZ_1ERRNO = -1;

private static int _fZ_1STREAM_1ERROR = -2;

private static int _fZ_1DATA_1ERROR = -3;

private static int _fZ_1MEM_1ERROR = -4;

private static int _fZ_1BUF_1ERROR = -5;

private static int _fZ_1VERSION_1ERROR = -6;

private bool _ffinished;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::com.codename1.io.gzip.ZStream) _r1_o).@this();
    _r0.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r1_o)._ffinished = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>()]
}

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 15;
    ((global::com.codename1.io.gzip.Deflater) _r1_o).@this((int) _r2.i, (int) _r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int)]
}

public void @this(int n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2 ? 1 : 0;
    _r0.i = 15;
    ((global::com.codename1.io.gzip.Deflater) _r1_o).@this((int) _r2.i, (int) _r0.i, 0!=_r3.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, boolean)]
}

public void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r1_o).@this((int) _r2.i, (int) _r3.i, 0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int)]
}

public void @this(int n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r7.i = n3 ? 1 : 0;
    ((global::com.codename1.io.gzip.ZStream) _r4_o).@this();
    _r1.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r4_o)._ffinished = 0!=_r1.i;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r4_o).init((int) _r5.i, (int) _r6.i, 0!=_r7.i);
    if (_r0.i == 0) goto label43;
    _r1_o = new global::com.codename1.io.gzip.GZIPException();
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((int) _r0.i);
    // Value=: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r3_o = ((global::com.codename1.io.gzip.Deflater) _r4_o)._fmsg;
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::com.codename1.io.gzip.GZIPException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::com.codename1.io.gzip.GZIPException) _r1_o);
    label43:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int, boolean)]
}

public void @this(int n1, int n2, int n3, global::com.codename1.io.gzip.JZlib_2WrapperType n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int, int, com.codename1.io.gzip.JZlib$WrapperType)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r8_o = n4;
    ((global::com.codename1.io.gzip.ZStream) _r4_o).@this();
    _r1.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r4_o)._ffinished = 0!=_r1.i;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r4_o).init((int) _r5.i, (int) _r6.i, (int) _r7.i, (global::com.codename1.io.gzip.JZlib_2WrapperType) _r8_o);
    if (_r0.i == 0) goto label43;
    _r1_o = new global::com.codename1.io.gzip.GZIPException();
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((int) _r0.i);
    // Value=: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r3_o = ((global::com.codename1.io.gzip.Deflater) _r4_o)._fmsg;
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::com.codename1.io.gzip.GZIPException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::com.codename1.io.gzip.GZIPException) _r1_o);
    label43:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int, int, com.codename1.io.gzip.JZlib$WrapperType)]
}

public void @this(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r7.i = n3;
    ((global::com.codename1.io.gzip.ZStream) _r4_o).@this();
    _r1.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r4_o)._ffinished = 0!=_r1.i;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r4_o).init((int) _r5.i, (int) _r6.i, (int) _r7.i);
    if (_r0.i == 0) goto label43;
    _r1_o = new global::com.codename1.io.gzip.GZIPException();
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((int) _r0.i);
    // Value=: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r3_o = ((global::com.codename1.io.gzip.Deflater) _r4_o)._fmsg;
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::com.codename1.io.gzip.GZIPException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::com.codename1.io.gzip.GZIPException) _r1_o);
    label43:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: void <init>(int, int, int)]
}

public virtual int init(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int init(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 15;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r1_o).init((int) _r2.i, (int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int init(int)]
}

public virtual int init(int n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2 ? 1 : 0;
    _r0.i = 15;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r1_o).init((int) _r2.i, (int) _r0.i, 0!=_r3.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, boolean)]
}

public virtual int init(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0.i = 0;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r1_o).init((int) _r2.i, (int) _r3.i, 0!=_r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int)]
}

public virtual int init(int n1, int n2, int n3, global::com.codename1.io.gzip.JZlib_2WrapperType n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int, int, com.codename1.io.gzip.JZlib$WrapperType)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r5.i = n3;
    _r6_o = n4;
    _r1.i = -2;
    _r0.i = 9;
    if (_r4.i < _r0.i) goto label9;
    _r0.i = 15;
    if (_r4.i <= _r0.i) goto label11;
    label9:;
    _r0.i = _r1.i;
    label10:;
    return _r0.i;
    label11:;
    _r0_o = global::com.codename1.io.gzip.JZlib._fW_1NONE;
    if (_r6_o != _r0_o) goto label22;
    _r4.i = _r4.i * -1;
    label17:;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r2_o).init((int) _r3.i, (int) _r4.i, (int) _r5.i);
    goto label10;
    label22:;
    _r0_o = global::com.codename1.io.gzip.JZlib._fW_1GZIP;
    if (_r6_o != _r0_o) goto label29;
    _r4.i = _r4.i + 16;
    goto label17;
    label29:;
    _r0_o = global::com.codename1.io.gzip.JZlib._fW_1ANY;
    if (_r6_o != _r0_o) goto label35;
    _r0.i = _r1.i;
    goto label10;
    label35:;
    _r0_o = global::com.codename1.io.gzip.JZlib._fW_1ZLIB;
    if (_r6_o != _r0_o) goto label17;
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int, int, com.codename1.io.gzip.JZlib$WrapperType)]
}

public virtual int init(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r1_o)._ffinished = 0!=_r0.i;
    _r0_o = new global::com.codename1.io.gzip.Deflate();
    ((global::com.codename1.io.gzip.Deflate) _r0_o).@this((global::com.codename1.io.gzip.ZStream) _r1_o);
    ((global::com.codename1.io.gzip.Deflater) _r1_o)._fdstate = (global::com.codename1.io.gzip.Deflate) _r0_o;
    _r0_o = ((global::com.codename1.io.gzip.Deflater) _r1_o)._fdstate;
    _r0.i = ((global::com.codename1.io.gzip.Deflate) _r0_o).deflateInit((int) _r2.i, (int) _r3.i, (int) _r4.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int, int)]
}

public virtual int init(int n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r5.i = n3 ? 1 : 0;
    _r0.i = 0;
    ((global::com.codename1.io.gzip.Deflater) _r2_o)._ffinished = 0!=_r0.i;
    _r0_o = new global::com.codename1.io.gzip.Deflate();
    ((global::com.codename1.io.gzip.Deflate) _r0_o).@this((global::com.codename1.io.gzip.ZStream) _r2_o);
    ((global::com.codename1.io.gzip.Deflater) _r2_o)._fdstate = (global::com.codename1.io.gzip.Deflate) _r0_o;
    _r0_o = ((global::com.codename1.io.gzip.Deflater) _r2_o)._fdstate;
    if (_r5.i == 0) goto label20;
    _r1.i = -_r4.i;
    label15:;
    _r0.i = ((global::com.codename1.io.gzip.Deflate) _r0_o).deflateInit((int) _r3.i, (int) _r1.i);
    return _r0.i;
    label20:;
    _r1.i = _r4.i;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int init(int, int, boolean)]
}

public override int deflate(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int deflate(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2.i = 1;
    _r1_o = ((global::com.codename1.io.gzip.Deflater) _r3_o)._fdstate;
    if (_r1_o != null) goto label7;
    _r1.i = -2;
    label6:;
    return _r1.i;
    label7:;
    _r1_o = ((global::com.codename1.io.gzip.Deflater) _r3_o)._fdstate;
    _r0.i = ((global::com.codename1.io.gzip.Deflate) _r1_o).deflate((int) _r4.i);
    if (_r0.i != _r2.i) goto label17;
    ((global::com.codename1.io.gzip.Deflater) _r3_o)._ffinished = 0!=_r2.i;
    label17:;
    _r1.i = _r0.i;
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int deflate(int)]
}

public override int end(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int end()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 1;
    ((global::com.codename1.io.gzip.Deflater) _r2_o)._ffinished = 0!=_r1.i;
    _r1_o = ((global::com.codename1.io.gzip.Deflater) _r2_o)._fdstate;
    if (_r1_o != null) goto label9;
    _r1.i = -2;
    label8:;
    return _r1.i;
    label9:;
    _r1_o = ((global::com.codename1.io.gzip.Deflater) _r2_o)._fdstate;
    _r0.i = ((global::com.codename1.io.gzip.Deflate) _r1_o).deflateEnd();
    _r1_o = null;
    ((global::com.codename1.io.gzip.Deflater) _r2_o)._fdstate = (global::com.codename1.io.gzip.Deflate) _r1_o;
    ((global::com.codename1.io.gzip.Deflater) _r2_o).free();
    _r1.i = _r0.i;
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int end()]
}

public virtual int @params(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int params(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0_o = ((global::com.codename1.io.gzip.Deflater) _r1_o)._fdstate;
    if (_r0_o != null) goto label6;
    _r0.i = -2;
    label5:;
    return _r0.i;
    label6:;
    _r0_o = ((global::com.codename1.io.gzip.Deflater) _r1_o)._fdstate;
    _r0.i = ((global::com.codename1.io.gzip.Deflate) _r0_o).deflateParams((int) _r2.i, (int) _r3.i);
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int params(int, int)]
}

public virtual int setDictionary(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int setDictionary(byte[], int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r0_o = ((global::com.codename1.io.gzip.Deflater) _r1_o)._fdstate;
    if (_r0_o != null) goto label6;
    _r0.i = -2;
    label5:;
    return _r0.i;
    label6:;
    _r0_o = ((global::com.codename1.io.gzip.Deflater) _r1_o)._fdstate;
    _r0.i = ((global::com.codename1.io.gzip.Deflate) _r0_o).deflateSetDictionary((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r3.i);
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int setDictionary(byte[], int)]
}

public override bool finished(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: boolean finished()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r1_o)._ffinished ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: boolean finished()]
}

public virtual int copy(global::com.codename1.io.gzip.Deflater n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater: int copy(com.codename1.io.gzip.Deflater)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r2_o)._ffinished ? 1 : 0;
    ((global::com.codename1.io.gzip.Deflater) _r1_o)._ffinished = 0!=_r0.i;
    _r0.i = global::com.codename1.io.gzip.Deflate.deflateCopy((global::com.codename1.io.gzip.ZStream) _r1_o, (global::com.codename1.io.gzip.ZStream) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater: int copy(com.codename1.io.gzip.Deflater)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.Deflater]
//XMLVM_END_WRAPPER[com.codename1.io.gzip.Deflater]

} // end of class: Deflater

} // end of namespace: com.codename1.io.gzip
