// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.cloud {
public class CloudStorage_2StorageRequest: global::com.codename1.io.ConnectionRequest {
public global::com.codename1.cloud.CloudResponse _fresponse;

private int _freturnCode;

public global::com.codename1.cloud.CloudStorage _fthis_20;

public void @this(global::com.codename1.cloud.CloudStorage n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void <init>(com.codename1.cloud.CloudStorage)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r1_o)._fthis_20 = (global::com.codename1.cloud.CloudStorage) _r2_o;
    ((global::com.codename1.io.ConnectionRequest) _r1_o).@this();
    _r0.i = 2;
    ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r1_o)._freturnCode = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void <init>(com.codename1.cloud.CloudStorage)]
}

public override void buildRequestBody(global::java.io.OutputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void buildRequestBody(java.io.OutputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r8_o = null;
    _r7.i = 1;
    _r2_o = new global::java.io.DataOutputStream();
    ((global::java.io.DataOutputStream) _r2_o).@this((global::java.io.OutputStream) _r10_o);
    _r5_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r9_o)._fthis_20;
    _r5_o = global::com.codename1.cloud.CloudStorage.access_2100((global::com.codename1.cloud.CloudStorage) _r5_o);
    _r5.i = ((global::java.util.Vector) _r5_o).size();
    ((global::java.io.DataOutputStream) _r2_o).writeInt((int) _r5.i);
    _r5_o = global::com.codename1.cloud.CloudPersona.getCurrentPersona();
    _r5_o = ((global::com.codename1.cloud.CloudPersona) _r5_o).getToken();
    ((global::java.io.DataOutputStream) _r2_o).writeUTF((global::java.lang.String) _r5_o);
    _r5_o = global::com.codename1.ui.Display.getInstance();
    // Value=package_name
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r5_o = ((global::com.codename1.ui.Display) _r5_o).getProperty((global::java.lang.String) _r6_o, (global::java.lang.String) _r8_o);
    ((global::java.io.DataOutputStream) _r2_o).writeUTF((global::java.lang.String) _r5_o);
    _r5_o = global::com.codename1.ui.Display.getInstance();
    // Value=built_by_user
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r5_o = ((global::com.codename1.ui.Display) _r5_o).getProperty((global::java.lang.String) _r6_o, (global::java.lang.String) _r8_o);
    ((global::java.io.DataOutputStream) _r2_o).writeUTF((global::java.lang.String) _r5_o);
    _r4.i = 0;
    label58:;
    _r5_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r9_o)._fthis_20;
    _r5_o = global::com.codename1.cloud.CloudStorage.access_2100((global::com.codename1.cloud.CloudStorage) _r5_o);
    _r5.i = ((global::java.util.Vector) _r5_o).size();
    if (_r4.i >= _r5.i) goto label150;
    _r5_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r9_o)._fthis_20;
    _r5_o = global::com.codename1.cloud.CloudStorage.access_2100((global::com.codename1.cloud.CloudStorage) _r5_o);
    _r3_o = ((global::java.util.Vector) _r5_o).elementAt((int) _r4.i);
    _r5.i = ((_r3_o != null) && (_r3_o is global::java.lang.String)) ? 1 : 0;
    if (_r5.i == 0) goto label95;
    ((global::java.io.DataOutputStream) _r2_o).writeByte((int) _r7.i);
    ((global::java.io.DataOutputStream) _r2_o).writeUTF((global::java.lang.String) _r3_o);
    label92:;
    _r4.i = _r4.i + 1;
    goto label58;
    label95:;
    _r0_o = _r3_o;
    _r1_o = _r0_o;
    _r5_o = ((global::com.codename1.cloud.CloudObject) _r1_o).getCloudId();
    if (_r5_o != null) goto label124;
    _r5.i = 2;
    ((global::java.io.DataOutputStream) _r2_o).writeByte((int) _r5.i);
    _r5.i = ((global::com.codename1.cloud.CloudObject) _r1_o).getAccessPermissions();
    ((global::java.io.DataOutputStream) _r2_o).writeInt((int) _r5.i);
    _r5_o = ((global::com.codename1.cloud.CloudObject) _r1_o).getValues();
    global::com.codename1.io.Util.writeObject((global::java.lang.Object) _r5_o, (global::java.io.DataOutputStream) _r2_o);
    goto label92;
    label124:;
    _r5.i = 3;
    ((global::java.io.DataOutputStream) _r2_o).writeByte((int) _r5.i);
    _r5_o = ((global::com.codename1.cloud.CloudObject) _r1_o).getCloudId();
    ((global::java.io.DataOutputStream) _r2_o).writeUTF((global::java.lang.String) _r5_o);
    _r5.l = ((global::com.codename1.cloud.CloudObject) _r1_o).getLastModified();
    ((global::java.io.DataOutputStream) _r2_o).writeLong((long) _r5.l);
    _r5_o = ((global::com.codename1.cloud.CloudObject) _r1_o).getValues();
    global::com.codename1.io.Util.writeObject((global::java.lang.Object) _r5_o, (global::java.io.DataOutputStream) _r2_o);
    goto label92;
    label150:;
    ((global::java.io.DataOutputStream) _r2_o).writeInt((int) _r7.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void buildRequestBody(java.io.OutputStream)]
}

public override void readResponse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void readResponse(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r8_o = this;
    _r9_o = n1;
    _r2_o = new global::java.io.DataInputStream();
    ((global::java.io.DataInputStream) _r2_o).@this((global::java.io.InputStream) _r9_o);
    _r7.i = ((global::java.io.DataInputStream) _r2_o).readInt();
    ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r8_o)._freturnCode = _r7.i;
    _r7.i = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r8_o)._freturnCode;
    if (_r7.i != 0) goto label73;
    _r5.l = ((global::java.io.DataInputStream) _r2_o).readLong();
    _r3.i = 0;
    label20:;
    _r7_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r8_o)._fthis_20;
    _r7_o = global::com.codename1.cloud.CloudStorage.access_2100((global::com.codename1.cloud.CloudStorage) _r7_o);
    _r7.i = ((global::java.util.Vector) _r7_o).size();
    if (_r3.i >= _r7.i) goto label73;
    _r7_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r8_o)._fthis_20;
    _r7_o = global::com.codename1.cloud.CloudStorage.access_2100((global::com.codename1.cloud.CloudStorage) _r7_o);
    _r4_o = ((global::java.util.Vector) _r7_o).elementAt((int) _r3.i);
    _r7.i = ((_r4_o != null) && (_r4_o is global::com.codename1.cloud.CloudObject)) ? 1 : 0;
    if (_r7.i == 0) goto label70;
    _r0_o = _r4_o;
    _r1_o = _r0_o;
    _r7_o = ((global::com.codename1.cloud.CloudObject) _r1_o).getCloudId();
    if (_r7_o != null) goto label63;
    _r7_o = ((global::java.io.DataInputStream) _r2_o).readUTF();
    ((global::com.codename1.cloud.CloudObject) _r1_o).setCloudId((global::java.lang.String) _r7_o);
    label63:;
    ((global::com.codename1.cloud.CloudObject) _r1_o).setLastModified((long) _r5.l);
    _r7.i = 1;
    ((global::com.codename1.cloud.CloudObject) _r1_o).setStatus((int) _r7.i);
    label70:;
    _r3.i = _r3.i + 1;
    goto label20;
    label73:;
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void readResponse(java.io.InputStream)]
}

public override void postResponse(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void postResponse()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r3_o)._fresponse;
    if (_r0_o == null) goto label38;
    _r0.i = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r3_o)._freturnCode;
    if (_r0.i != 0) goto label26;
    _r0_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r3_o)._fthis_20;
    _r0_o = global::com.codename1.cloud.CloudStorage.access_2100((global::com.codename1.cloud.CloudStorage) _r0_o);
    ((global::java.util.Vector) _r0_o).clear();
    _r0_o = global::com.codename1.io.Storage.getInstance();
    // Value=CN1StorageQueue
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 81)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.io.Storage) _r0_o).deleteStorageFile((global::java.lang.String) _r1_o);
    label26:;
    _r0_o = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r3_o)._fresponse;
    _r1_o = new global::java.lang.Integer();
    _r2.i = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r3_o)._freturnCode;
    ((global::java.lang.Integer) _r1_o).@this((int) _r2.i);
    ((global::com.codename1.cloud.CloudResponse) _r0_o).onSuccess((global::java.lang.Object) _r1_o);
    label38:;
    return;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: void postResponse()]
}

public virtual int getReturnCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: int getReturnCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.cloud.CloudStorage_2StorageRequest) _r1_o)._freturnCode;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest: int getReturnCode()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest]
//XMLVM_END_WRAPPER[com.codename1.cloud.CloudStorage$StorageRequest]

} // end of class: CloudStorage_2StorageRequest

} // end of namespace: com.codename1.cloud
