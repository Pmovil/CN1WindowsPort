// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class FaceBookAccess_22: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.ui.events.ActionListener _fval_2al;

public global::com.codename1.facebook.FaceBookAccess _fthis_20;

public void @this(global::com.codename1.facebook.FaceBookAccess n1, global::com.codename1.ui.events.ActionListener n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$2: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.ui.events.ActionListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.facebook.FaceBookAccess_22) _r0_o)._fthis_20 = (global::com.codename1.facebook.FaceBookAccess) _r1_o;
    ((global::com.codename1.facebook.FaceBookAccess_22) _r0_o)._fval_2al = (global::com.codename1.ui.events.ActionListener) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$2: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.ui.events.ActionListener)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r1_o = ((global::com.codename1.ui.events.ActionEvent) _r3_o).getSource();
    _r1.i = ((_r1_o != null) && (_r1_o is global::java.lang.String)) ? 1 : 0;
    if (_r1.i == 0) goto label17;
    _r1_o = ((global::com.codename1.ui.events.ActionEvent) _r3_o).getSource();
    _r1_o = _r1_o;
    global::com.codename1.facebook.FaceBookAccess.access_2002((global::java.lang.String) _r1_o);
    label17:;
    _r1_o = ((global::com.codename1.ui.events.ActionEvent) _r3_o).getSource();
    _r1.i = ((_r1_o != null) && (_r1_o is global::com.codename1.io.AccessToken)) ? 1 : 0;
    if (_r1.i == 0) goto label38;
    _r0_o = ((global::com.codename1.ui.events.ActionEvent) _r3_o).getSource();
    _r0_o = _r0_o;
    _r1_o = ((global::com.codename1.io.AccessToken) _r0_o).getToken();
    global::com.codename1.facebook.FaceBookAccess.access_2002((global::java.lang.String) _r1_o);
    label38:;
    _r1_o = ((global::com.codename1.facebook.FaceBookAccess_22) _r2_o)._fval_2al;
    ((global::com.codename1.ui.events.ActionListener) _r1_o).actionPerformed((global::com.codename1.ui.events.ActionEvent) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$2]
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$2]

} // end of class: FaceBookAccess_22

} // end of namespace: com.codename1.facebook
