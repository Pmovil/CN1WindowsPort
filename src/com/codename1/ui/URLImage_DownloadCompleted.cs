// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class URLImage_2DownloadCompleted: global::java.lang.Object,global::com.codename1.ui.events.ActionListener,global::java.lang.Runnable {
private global::com.codename1.ui.EncodedImage _fadapt;

private global::com.codename1.ui.EncodedImage _fadaptedIns;

public global::com.codename1.ui.URLImage _fthis_20;

public void @this(global::com.codename1.ui.URLImage n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted: void <init>(com.codename1.ui.URLImage)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r0_o)._fthis_20 = (global::com.codename1.ui.URLImage) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted: void <init>(com.codename1.ui.URLImage)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r3_o)._fthis_20;
    _r0_o = global::com.codename1.ui.URLImage.access_2100((global::com.codename1.ui.URLImage) _r0_o);
    _r1_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r3_o)._fadapt;
    _r2_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r3_o)._fthis_20;
    _r2_o = global::com.codename1.ui.URLImage.access_2000((global::com.codename1.ui.URLImage) _r2_o);
    _r0_o = ((global::com.codename1.ui.URLImage_2ImageAdapter) _r0_o).adaptImage((global::com.codename1.ui.EncodedImage) _r1_o, (global::com.codename1.ui.EncodedImage) _r2_o);
    ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r3_o)._fadaptedIns = (global::com.codename1.ui.EncodedImage) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted: void run()]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10_o = n1;
    // Value=ImageURLTMP
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r6_o = global::com.codename1.ui.URLImage.access_2100((global::com.codename1.ui.URLImage) _r6_o);
    if (_r6_o == null) goto label186;
    try {
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r6_o = global::com.codename1.ui.URLImage.access_2200((global::com.codename1.ui.URLImage) _r6_o);
    if (_r6_o == null) goto label198;
    _r6_o = global::com.codename1.io.Storage.getInstance();
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    _r8_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r8_o = global::com.codename1.ui.URLImage.access_2200((global::com.codename1.ui.URLImage) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    // Value=ImageURLTMP
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    _r6.i = ((global::com.codename1.io.Storage) _r6_o).entrySize((global::java.lang.String) _r7_o);
    _r1_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r6.i]);
    _r6_o = global::com.codename1.io.Storage.getInstance();
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    _r8_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r8_o = global::com.codename1.ui.URLImage.access_2200((global::com.codename1.ui.URLImage) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    // Value=ImageURLTMP
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    _r4_o = ((global::com.codename1.io.Storage) _r6_o).createInputStream((global::java.lang.String) _r7_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label345;
        }
        throw ex;
    } // end catch
    label86:;
    try {
    global::com.codename1.io.Util.readFully((global::java.io.InputStream) _r4_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o);
    _r3_o = global::com.codename1.ui.EncodedImage.create((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o);
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r6_o = global::com.codename1.ui.URLImage.access_2100((global::com.codename1.ui.URLImage) _r6_o);
    _r6.i = ((global::com.codename1.ui.URLImage_2ImageAdapter) _r6_o).isAsyncAdapter() ? 1 : 0;
    if (_r6.i == 0) goto label269;
    ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fadapt = (global::com.codename1.ui.EncodedImage) _r3_o;
    _r6_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r6_o).invokeAndBlock((global::java.lang.Runnable) _r9_o);
    _r0_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fadaptedIns;
    _r6_o = null;
    ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fadaptedIns = (global::com.codename1.ui.EncodedImage) _r6_o;
    _r6_o = null;
    ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fadapt = (global::com.codename1.ui.EncodedImage) _r6_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label345;
        }
        throw ex;
    } // end catch
    label122:;
    try {
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r6_o = global::com.codename1.ui.URLImage.access_2200((global::com.codename1.ui.URLImage) _r6_o);
    if (_r6_o == null) goto label287;
    _r6_o = global::com.codename1.io.Storage.getInstance();
    _r7_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r7_o = global::com.codename1.ui.URLImage.access_2200((global::com.codename1.ui.URLImage) _r7_o);
    _r5_o = ((global::com.codename1.io.Storage) _r6_o).createOutputStream((global::java.lang.String) _r7_o);
    _r6_o = ((global::com.codename1.ui.EncodedImage) _r0_o).getImageData();
    ((global::java.io.OutputStream) _r5_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r6_o);
    ((global::java.io.OutputStream) _r5_o).close();
    _r6_o = global::com.codename1.io.Storage.getInstance();
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    _r8_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r8_o = global::com.codename1.ui.URLImage.access_2200((global::com.codename1.ui.URLImage) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    // Value=ImageURLTMP
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    ((global::com.codename1.io.Storage) _r6_o).deleteStorageFile((global::java.lang.String) _r7_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label345;
        }
        throw ex;
    } // end catch
    label186:;
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r7.i = 0;
    global::com.codename1.ui.URLImage.access_2402((global::com.codename1.ui.URLImage) _r6_o, 0!=_r7.i);
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    ((global::com.codename1.ui.URLImage) _r6_o).fetch();
    label197:;
    return;
    label198:;
    try {
    _r6_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    _r8_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r8_o = global::com.codename1.ui.URLImage.access_2300((global::com.codename1.ui.URLImage) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    // Value=ImageURLTMP
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    _r6.l = ((global::com.codename1.io.FileSystemStorage) _r6_o).getLength((global::java.lang.String) _r7_o);
    _r6.i = (int) _r6.l;
    _r1_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r6.i]);
    _r6_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    _r8_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r8_o = global::com.codename1.ui.URLImage.access_2300((global::com.codename1.ui.URLImage) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    // Value=ImageURLTMP
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    _r4_o = ((global::com.codename1.io.FileSystemStorage) _r6_o).openInputStream((global::java.lang.String) _r7_o);
    goto label86;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label345;
        }
        throw ex;
    } // end catch
    label269:;
    try {
    _r6_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r6_o = global::com.codename1.ui.URLImage.access_2100((global::com.codename1.ui.URLImage) _r6_o);
    _r7_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r7_o = global::com.codename1.ui.URLImage.access_2000((global::com.codename1.ui.URLImage) _r7_o);
    _r0_o = ((global::com.codename1.ui.URLImage_2ImageAdapter) _r6_o).adaptImage((global::com.codename1.ui.EncodedImage) _r3_o, (global::com.codename1.ui.EncodedImage) _r7_o);
    goto label122;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label345;
        }
        throw ex;
    } // end catch
    label287:;
    try {
    _r6_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r7_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r7_o = global::com.codename1.ui.URLImage.access_2300((global::com.codename1.ui.URLImage) _r7_o);
    _r5_o = ((global::com.codename1.io.FileSystemStorage) _r6_o).openOutputStream((global::java.lang.String) _r7_o);
    _r6_o = ((global::com.codename1.ui.EncodedImage) _r0_o).getImageData();
    ((global::java.io.OutputStream) _r5_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r6_o);
    ((global::java.io.OutputStream) _r5_o).close();
    _r6_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    _r8_o = ((global::com.codename1.ui.URLImage_2DownloadCompleted) _r9_o)._fthis_20;
    _r8_o = global::com.codename1.ui.URLImage.access_2300((global::com.codename1.ui.URLImage) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    // Value=ImageURLTMP
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 80))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    ((global::com.codename1.io.FileSystemStorage) _r6_o).delete((global::java.lang.String) _r7_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label345;
        }
        throw ex;
    } // end catch
    goto label186;
    label345:;
    _r6_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r6_o;
    ((global::java.io.IOException) _r2_o).printStackTrace();
    goto label197;
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted]
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$DownloadCompleted]

} // end of class: URLImage_2DownloadCompleted

} // end of namespace: com.codename1.ui
