// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class FaceBookAccess_218: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.facebook.Album _fval_2album;

public global::com.codename1.facebook.FaceBookAccess _fthis_20;

public void @this(global::com.codename1.facebook.FaceBookAccess n1, global::com.codename1.facebook.Album n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$18: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.facebook.Album)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.facebook.FaceBookAccess_218) _r0_o)._fthis_20 = (global::com.codename1.facebook.FaceBookAccess) _r1_o;
    ((global::com.codename1.facebook.FaceBookAccess_218) _r0_o)._fval_2album = (global::com.codename1.facebook.Album) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$18: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.facebook.Album)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$18: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r1_o = ((global::com.codename1.io.NetworkEvent) _r4_o).getMetaData();
    _r2.i = 0;
    _r0_o = ((global::java.util.Vector) _r1_o).elementAt((int) _r2.i);
    _r2_o = ((global::com.codename1.facebook.FaceBookAccess_218) _r3_o)._fval_2album;
    ((global::com.codename1.facebook.Album) _r2_o).copy((global::java.util.Hashtable) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$18: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$18]
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$18]

} // end of class: FaceBookAccess_218

} // end of namespace: com.codename1.facebook
