// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.cloud {
public class CloudListModel_22: global::java.lang.Object,global::com.codename1.cloud.CloudResponse {
private int _fresponseOffset;

public global::com.codename1.cloud.CloudListModel _fthis_20;

public void @this(global::com.codename1.cloud.CloudListModel n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$2: void <init>(com.codename1.cloud.CloudListModel)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.cloud.CloudListModel_22) _r0_o)._fthis_20 = (global::com.codename1.cloud.CloudListModel) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$2: void <init>(com.codename1.cloud.CloudListModel)]
}

public virtual void onSuccess(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$2: void onSuccess(java.lang.String[])]
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
    _r0.i = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fresponseOffset;
    if (_r0.i != 0) goto label114;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    global::com.codename1.cloud.CloudListModel.access_2202((global::com.codename1.cloud.CloudListModel) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r10_o);
    label9:;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    global::com.codename1.cloud.CloudListModel.access_2300((global::com.codename1.cloud.CloudListModel) _r0_o);
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r0_o = global::com.codename1.cloud.CloudListModel.access_2000((global::com.codename1.cloud.CloudListModel) _r0_o);
    // Value=keyIndex
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120))}));
    _r2_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r2_o = global::com.codename1.cloud.CloudListModel.access_2200((global::com.codename1.cloud.CloudListModel) _r2_o);
    ((global::com.codename1.io.CacheMap) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r0_o = global::com.codename1.cloud.CloudListModel.access_2100((global::com.codename1.cloud.CloudListModel) _r0_o);
    _r1.i = -1;
    _r2.i = 1;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).fireDataChangeEvent((int) _r1.i, (int) _r2.i);
    _r0.i = ((global::org.xmlvm._nIArray) _r10_o).Length;
    _r1_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r1.i = global::com.codename1.cloud.CloudListModel.access_2400((global::com.codename1.cloud.CloudListModel) _r1_o);
    if (_r0.i != _r1.i) goto label113;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r0_o = global::com.codename1.cloud.CloudListModel.access_2200((global::com.codename1.cloud.CloudListModel) _r0_o);
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fresponseOffset = _r0.i;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r0.i = global::com.codename1.cloud.CloudListModel.access_2500((global::com.codename1.cloud.CloudListModel) _r0_o);
    if (_r0.i <= 0) goto label141;
    _r0_o = global::com.codename1.cloud.CloudStorage.getInstance();
    _r1_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r1_o = global::com.codename1.cloud.CloudListModel.access_2600((global::com.codename1.cloud.CloudListModel) _r1_o);
    _r2_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r2.i = global::com.codename1.cloud.CloudListModel.access_2500((global::com.codename1.cloud.CloudListModel) _r2_o);
    _r3_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r3_o = global::com.codename1.cloud.CloudListModel.access_2700((global::com.codename1.cloud.CloudListModel) _r3_o);
    _r4_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r4_o = global::com.codename1.cloud.CloudListModel.access_2200((global::com.codename1.cloud.CloudListModel) _r4_o);
    _r4.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r5_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r5.i = global::com.codename1.cloud.CloudListModel.access_2400((global::com.codename1.cloud.CloudListModel) _r5_o);
    _r6_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r6.i = global::com.codename1.cloud.CloudListModel.access_2800((global::com.codename1.cloud.CloudListModel) _r6_o);
    _r7_o = _r9_o;
    ((global::com.codename1.cloud.CloudStorage) _r0_o).queryEqualsKeys((global::java.lang.String) _r1_o, (int) _r2.i, (global::java.lang.String) _r3_o, (int) _r4.i, (int) _r5.i, (int) _r6.i, (global::com.codename1.cloud.CloudResponse) _r7_o);
    label113:;
    return;
    label114:;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r0_o = global::com.codename1.cloud.CloudListModel.access_2200((global::com.codename1.cloud.CloudListModel) _r0_o);
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::org.xmlvm._nIArray) _r10_o).Length;
    _r0.i = _r0.i + _r1.i;
    _r8_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r0_o = global::com.codename1.cloud.CloudListModel.access_2200((global::com.codename1.cloud.CloudListModel) _r0_o);
    global::com.codename1.io.Util.mergeArrays((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r10_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o);
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    global::com.codename1.cloud.CloudListModel.access_2202((global::com.codename1.cloud.CloudListModel) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o);
    goto label9;
    label141:;
    _r0_o = global::com.codename1.cloud.CloudStorage.getInstance();
    _r1_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r1_o = global::com.codename1.cloud.CloudListModel.access_2600((global::com.codename1.cloud.CloudListModel) _r1_o);
    _r2_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r2.i = global::com.codename1.cloud.CloudListModel.access_2900((global::com.codename1.cloud.CloudListModel) _r2_o);
    _r3_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r3.i = global::com.codename1.cloud.CloudListModel.access_21000((global::com.codename1.cloud.CloudListModel) _r3_o) ? 1 : 0;
    _r4_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r4_o = global::com.codename1.cloud.CloudListModel.access_2200((global::com.codename1.cloud.CloudListModel) _r4_o);
    _r4.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r5_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r5.i = global::com.codename1.cloud.CloudListModel.access_2400((global::com.codename1.cloud.CloudListModel) _r5_o);
    _r6_o = ((global::com.codename1.cloud.CloudListModel_22) _r9_o)._fthis_20;
    _r6.i = global::com.codename1.cloud.CloudListModel.access_2800((global::com.codename1.cloud.CloudListModel) _r6_o);
    _r7_o = _r9_o;
    ((global::com.codename1.cloud.CloudStorage) _r0_o).querySortedKeys((global::java.lang.String) _r1_o, (int) _r2.i, 0!=_r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i, (global::com.codename1.cloud.CloudResponse) _r7_o);
    goto label113;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$2: void onSuccess(java.lang.String[])]
}

public virtual void onError(global::com.codename1.cloud.CloudException n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$2: void onError(com.codename1.cloud.CloudException)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.cloud.CloudListModel_22) _r1_o)._fthis_20;
    ((global::com.codename1.cloud.CloudListModel) _r0_o).onError((global::com.codename1.cloud.CloudException) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$2: void onError(com.codename1.cloud.CloudException)]
}

public virtual void onSuccess(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$2: void onSuccess(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r1_o = _r1_o;
    ((global::com.codename1.cloud.CloudListModel_22) _r0_o).onSuccess((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$2: void onSuccess(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudListModel$2]
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudListModel$2]

} // end of class: CloudListModel_22

} // end of namespace: com.codename1.cloud
