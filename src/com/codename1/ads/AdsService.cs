// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ads {
public abstract class AdsService: global::com.codename1.io.ConnectionRequest {

static AdsService() {
    @static();
}

private global::java.lang.String _fcurrentAd;

private bool _finitialized;

private static global::java.lang.Class _fservice;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::com.codename1.io.ConnectionRequest) _r1_o).@this();
    _r0.i = 0;
    ((global::com.codename1.ads.AdsService) _r1_o)._finitialized = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void <init>()]
}

public virtual void initialize(global::com.codename1.components.Ads n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void initialize(com.codename1.components.Ads)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::com.codename1.ads.AdsService) _r1_o)._finitialized ? 1 : 0;
    if (_r0.i != 0) goto label10;
    ((global::com.codename1.ads.AdsService) _r1_o).initService((global::com.codename1.components.Ads) _r2_o);
    _r0.i = 1;
    ((global::com.codename1.ads.AdsService) _r1_o)._finitialized = 0!=_r0.i;
    label10:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void initialize(com.codename1.components.Ads)]
}

public abstract void initService(global::com.codename1.components.Ads n1);

public static global::System.Object createAdsService(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: com.codename1.ads.AdsService createAdsService()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    try {
    _r2_o = global::com.codename1.ads.AdsService._fservice;
    _r0_o = ((global::java.lang.Class) _r2_o).newInstance();
    _r0_o = _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.InstantiationException) {
            _ex = ex;
            goto label10;
        }
        if (_java_exception is global::java.lang.IllegalAccessException) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    _r2_o = _r0_o;
    label9:;
    return (global::com.codename1.ads.AdsService) _r2_o;
    label10:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    _r1_o = _r2_o;
    ((global::java.lang.InstantiationException) _r1_o).printStackTrace();
    label15:;
    _r2_o = null;
    goto label9;
    label17:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    _r1_o = _r2_o;
    ((global::java.lang.IllegalAccessException) _r1_o).printStackTrace();
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: com.codename1.ads.AdsService createAdsService()]
}

public static void setAdsProvider(global::java.lang.Class n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void setAdsProvider(java.lang.Class)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    global::com.codename1.ads.AdsService._fservice = (global::java.lang.Class) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void setAdsProvider(java.lang.Class)]
}

public virtual global::System.Object getCurrentAd(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: java.lang.String getCurrentAd()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ads.AdsService) _r1_o)._fcurrentAd;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: java.lang.String getCurrentAd()]
}

public virtual void requestAd(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void requestAd()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r0_o).addToQueue((global::com.codename1.io.ConnectionRequest) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void requestAd()]
}

public override void readResponse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void readResponse(java.io.InputStream)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9_o = n1;
    _r7.i = 0;
    _r2_o = new global::java.io.ByteArrayOutputStream();
    ((global::java.io.ByteArrayOutputStream) _r2_o).@this();
    _r5.i = 256;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r5.i]);
    label10:;
    _r1.i = ((global::java.io.InputStream) _r9_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o);
    if (_r1.i <= 0) goto label20;
    ((global::java.io.ByteArrayOutputStream) _r2_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r7.i, (int) _r1.i);
    goto label10;
    label20:;
    _r5_o = ((global::java.io.ByteArrayOutputStream) _r2_o).toByteArray();
    _r4.i = ((global::org.xmlvm._nIArray) _r5_o).Length;
    if (_r4.i <= 0) goto label50;
    _r3_o = new global::java.lang.String();
    _r5_o = ((global::java.io.ByteArrayOutputStream) _r2_o).toByteArray();
    // Value=UTF-8
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::java.lang.String) _r3_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r5_o, (int) _r7.i, (int) _r4.i, (global::java.lang.String) _r6_o);
    ((global::com.codename1.ads.AdsService) _r8_o)._fcurrentAd = (global::java.lang.String) _r3_o;
    _r5_o = new global::com.codename1.ui.events.ActionEvent();
    _r6_o = ((global::com.codename1.ads.AdsService) _r8_o)._fcurrentAd;
    ((global::com.codename1.ui.events.ActionEvent) _r5_o).@this((global::java.lang.Object) _r6_o);
    ((global::com.codename1.ads.AdsService) _r8_o).fireResponseListener((global::com.codename1.ui.events.ActionEvent) _r5_o);
    label50:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void readResponse(java.io.InputStream)]
}

public virtual void onAdDisplay(global::com.codename1.ui.html.HTMLComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void onAdDisplay(com.codename1.ui.html.HTMLComponent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void onAdDisplay(com.codename1.ui.html.HTMLComponent)]
}

public override void handleErrorResponseCode(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void handleErrorResponseCode(int, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4.i = n1;
    _r5_o = n2;
    _r0_o = global::java.lang.System._ferr;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=error=
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 61))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((int) _r4.i);
    // Value= 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r5_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.io.PrintStream) _r0_o).println((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void handleErrorResponseCode(int, java.lang.String)]
}

public override void handleRuntimeException(global::java.lang.RuntimeException n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void handleRuntimeException(java.lang.RuntimeException)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.RuntimeException) _r1_o).printStackTrace();
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void handleRuntimeException(java.lang.RuntimeException)]
}

public override void handleException(global::java.lang.Exception n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void handleException(java.lang.Exception)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Exception) _r1_o).printStackTrace();
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void handleException(java.lang.Exception)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.ads.InnerActive));
    global::com.codename1.ads.AdsService._fservice = (global::java.lang.Class) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ads.AdsService]
//XMLVM_END_WRAPPER[com.codename1.ads.AdsService]

} // end of class: AdsService

} // end of namespace: com.codename1.ads
