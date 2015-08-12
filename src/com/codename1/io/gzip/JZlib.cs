// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.gzip {
public class JZlib: global::java.lang.Object {

static JZlib() {
    // Value=1.1.0
    _fversion = new global::java.lang.String();
    _fversion.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48))}));
    @static();
}

private static global::java.lang.String _fversion;

public static int _fMAX_1WBITS = 15;

public static int _fDEF_1WBITS = 15;

public static global::com.codename1.io.gzip.JZlib_2WrapperType _fW_1NONE;

public static global::com.codename1.io.gzip.JZlib_2WrapperType _fW_1ZLIB;

public static global::com.codename1.io.gzip.JZlib_2WrapperType _fW_1GZIP;

public static global::com.codename1.io.gzip.JZlib_2WrapperType _fW_1ANY;

public static int _fZ_1NO_1COMPRESSION = 0;

public static int _fZ_1BEST_1SPEED = 1;

public static int _fZ_1BEST_1COMPRESSION = 9;

public static int _fZ_1DEFAULT_1COMPRESSION = -1;

public static int _fZ_1FILTERED = 1;

public static int _fZ_1HUFFMAN_1ONLY = 2;

public static int _fZ_1DEFAULT_1STRATEGY = 0;

public static int _fZ_1NO_1FLUSH = 0;

public static int _fZ_1PARTIAL_1FLUSH = 1;

public static int _fZ_1SYNC_1FLUSH = 2;

public static int _fZ_1FULL_1FLUSH = 3;

public static int _fZ_1FINISH = 4;

public static int _fZ_1OK = 0;

public static int _fZ_1STREAM_1END = 1;

public static int _fZ_1NEED_1DICT = 2;

public static int _fZ_1ERRNO = -1;

public static int _fZ_1STREAM_1ERROR = -2;

public static int _fZ_1DATA_1ERROR = -3;

public static int _fZ_1MEM_1ERROR = -4;

public static int _fZ_1BUF_1ERROR = -5;

public static int _fZ_1VERSION_1ERROR = -6;

public static sbyte _fZ_1BINARY = 0;

public static sbyte _fZ_1ASCII = 1;

public static sbyte _fZ_1UNKNOWN = 2;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.JZlib: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.JZlib: void <init>()]
}

public static global::System.Object version(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.JZlib: java.lang.String version()]
    global::System.Object _r0_o = null;
    // Value=1.1.0
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.JZlib: java.lang.String version()]
}

public static long adler32_1combine(long n1, long n2, long n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.JZlib: long adler32_combine(long, long, long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    _r2.l = n1;
    _r4.l = n2;
    _r6.l = n3;
    _r0.l = global::com.codename1.io.gzip.Adler32.combine((long) _r2.l, (long) _r4.l, (long) _r6.l);
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.JZlib: long adler32_combine(long, long, long)]
}

public static long crc32_1combine(long n1, long n2, long n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.JZlib: long crc32_combine(long, long, long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    _r2.l = n1;
    _r4.l = n2;
    _r6.l = n3;
    _r0.l = global::com.codename1.io.gzip.CRC32.combine((long) _r2.l, (long) _r4.l, (long) _r6.l);
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.JZlib: long crc32_combine(long, long, long)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.JZlib: void <clinit>()]
    global::System.Object _r0_o = null;
    _r0_o = new global::com.codename1.io.gzip.JZlib_2NONE();
    ((global::com.codename1.io.gzip.JZlib_2NONE) _r0_o).@this();
    global::com.codename1.io.gzip.JZlib._fW_1NONE = (global::com.codename1.io.gzip.JZlib_2WrapperType) _r0_o;
    _r0_o = new global::com.codename1.io.gzip.JZlib_2ZLIB();
    ((global::com.codename1.io.gzip.JZlib_2ZLIB) _r0_o).@this();
    global::com.codename1.io.gzip.JZlib._fW_1ZLIB = (global::com.codename1.io.gzip.JZlib_2WrapperType) _r0_o;
    _r0_o = new global::com.codename1.io.gzip.JZlib_2GZIP();
    ((global::com.codename1.io.gzip.JZlib_2GZIP) _r0_o).@this();
    global::com.codename1.io.gzip.JZlib._fW_1GZIP = (global::com.codename1.io.gzip.JZlib_2WrapperType) _r0_o;
    _r0_o = new global::com.codename1.io.gzip.JZlib_2ANY();
    ((global::com.codename1.io.gzip.JZlib_2ANY) _r0_o).@this();
    global::com.codename1.io.gzip.JZlib._fW_1ANY = (global::com.codename1.io.gzip.JZlib_2WrapperType) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.JZlib: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.JZlib]
//XMLVM_END_WRAPPER[com.codename1.io.gzip.JZlib]

} // end of class: JZlib

} // end of namespace: com.codename1.io.gzip
