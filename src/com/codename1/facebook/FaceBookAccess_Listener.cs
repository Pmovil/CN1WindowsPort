// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class FaceBookAccess_2Listener: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
private global::com.codename1.facebook.FacebookRESTService _fcon;

private global::com.codename1.ui.events.ActionListener _fcallback;

public global::com.codename1.facebook.FaceBookAccess _fthis_20;

public void @this(global::com.codename1.facebook.FaceBookAccess n1, global::com.codename1.facebook.FacebookRESTService n2, global::com.codename1.ui.events.ActionListener n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$Listener: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.facebook.FacebookRESTService, com.codename1.ui.events.ActionListener)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.facebook.FaceBookAccess_2Listener) _r0_o)._fthis_20 = (global::com.codename1.facebook.FaceBookAccess) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.facebook.FaceBookAccess_2Listener) _r0_o)._fcon = (global::com.codename1.facebook.FacebookRESTService) _r2_o;
    ((global::com.codename1.facebook.FaceBookAccess_2Listener) _r0_o)._fcallback = (global::com.codename1.ui.events.ActionListener) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$Listener: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.facebook.FacebookRESTService, com.codename1.ui.events.ActionListener)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$Listener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.facebook.FaceBookAccess_2Listener) _r1_o)._fcon;
    _r0.i = ((global::com.codename1.facebook.FacebookRESTService) _r0_o).isAlive() ? 1 : 0;
    if (_r0.i != 0) goto label9;
    label8:;
    return;
    label9:;
    _r0_o = ((global::com.codename1.facebook.FaceBookAccess_2Listener) _r1_o)._fcallback;
    if (_r0_o == null) goto label8;
    _r0_o = ((global::com.codename1.facebook.FaceBookAccess_2Listener) _r1_o)._fcallback;
    ((global::com.codename1.ui.events.ActionListener) _r0_o).actionPerformed((global::com.codename1.ui.events.ActionEvent) _r2_o);
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$Listener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$Listener]
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$Listener]

} // end of class: FaceBookAccess_2Listener

} // end of namespace: com.codename1.facebook
