// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.cloud {
public class CloudListModel_21: global::java.lang.Object,global::com.codename1.cloud.CloudResponse {
public int _fval_2startIndex;

public int _fval_2len;

public global::com.codename1.cloud.CloudListModel _fthis_20;

public void @this(global::com.codename1.cloud.CloudListModel n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$1: void <init>(com.codename1.cloud.CloudListModel, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3.i = n3;
    ((global::com.codename1.cloud.CloudListModel_21) _r0_o)._fthis_20 = (global::com.codename1.cloud.CloudListModel) _r1_o;
    ((global::com.codename1.cloud.CloudListModel_21) _r0_o)._fval_2startIndex = _r2.i;
    ((global::com.codename1.cloud.CloudListModel_21) _r0_o)._fval_2len = _r3.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$1: void <init>(com.codename1.cloud.CloudListModel, int, int)]
}

public virtual void onSuccess(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$1: void onSuccess(com.codename1.cloud.CloudObject[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.i = 0;
    label1:;
    _r1.i = ((global::org.xmlvm._nIArray) _r5_o).Length;
    if (_r0.i >= _r1.i) goto label24;
    _r1_o = ((global::com.codename1.cloud.CloudListModel_21) _r4_o)._fthis_20;
    _r1_o = global::com.codename1.cloud.CloudListModel.access_2000((global::com.codename1.cloud.CloudListModel) _r1_o);
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o)[_r0.i];
    _r2_o = ((global::com.codename1.cloud.CloudObject) _r2_o).getCloudId();
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o)[_r0.i];
    ((global::com.codename1.io.CacheMap) _r1_o).put((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r3_o);
    _r0.i = _r0.i + 1;
    goto label1;
    label24:;
    _r1_o = ((global::com.codename1.cloud.CloudListModel_21) _r4_o)._fthis_20;
    _r1_o = global::com.codename1.cloud.CloudListModel.access_2100((global::com.codename1.cloud.CloudListModel) _r1_o);
    _r2.i = ((global::com.codename1.cloud.CloudListModel_21) _r4_o)._fval_2startIndex;
    _r3.i = ((global::com.codename1.cloud.CloudListModel_21) _r4_o)._fval_2len;
    ((global::com.codename1.ui.util.EventDispatcher) _r1_o).fireDataChangeEvent((int) _r2.i, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$1: void onSuccess(com.codename1.cloud.CloudObject[])]
}

public virtual void onError(global::com.codename1.cloud.CloudException n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$1: void onError(com.codename1.cloud.CloudException)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_21) _r1_o)._fthis_20;
    ((global::com.codename1.cloud.CloudListModel) _r0_o).onError((global::com.codename1.cloud.CloudException) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$1: void onError(com.codename1.cloud.CloudException)]
}

public virtual void onSuccess(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$1: void onSuccess(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.cloud.CloudListModel_21) _r0_o).onSuccess((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$1: void onSuccess(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$1]
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$1]

} // end of class: CloudListModel_21

} // end of namespace: com.codename1.cloud
