// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io {
public class Oauth2_21: global::com.codename1.ui.Command {
public global::com.codename1.ui.Dialog _fval_2progress;

public global::com.codename1.ui.Form _fval_2old;

public global::com.codename1.io.Oauth2 _fthis_20;

public void @this(global::com.codename1.io.Oauth2 n1, global::java.lang.String n2, global::com.codename1.ui.Dialog n3, global::com.codename1.ui.Form n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Oauth2$1: void <init>(com.codename1.io.Oauth2, java.lang.String, com.codename1.ui.Dialog, com.codename1.ui.Form)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4_o = n4;
    ((global::com.codename1.io.Oauth2_21) _r0_o)._fthis_20 = (global::com.codename1.io.Oauth2) _r1_o;
    ((global::com.codename1.io.Oauth2_21) _r0_o)._fval_2progress = (global::com.codename1.ui.Dialog) _r3_o;
    ((global::com.codename1.io.Oauth2_21) _r0_o)._fval_2old = (global::com.codename1.ui.Form) _r4_o;
    ((global::com.codename1.ui.Command) _r0_o).@this((global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Oauth2$1: void <init>(com.codename1.io.Oauth2, java.lang.String, com.codename1.ui.Dialog, com.codename1.ui.Form)]
}

public override void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Oauth2$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getCurrent();
    _r1_o = ((global::com.codename1.io.Oauth2_21) _r2_o)._fval_2progress;
    if (_r0_o != _r1_o) goto label17;
    _r0_o = ((global::com.codename1.io.Oauth2_21) _r2_o)._fval_2progress;
    ((global::com.codename1.ui.Dialog) _r0_o).dispose();
    label17:;
    _r0_o = ((global::com.codename1.io.Oauth2_21) _r2_o)._fval_2old;
    ((global::com.codename1.ui.Form) _r0_o).showBack();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Oauth2$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.Oauth2$1]
//XMLVM_END_WRAPPER[com.codename1.io.Oauth2$1]

} // end of class: Oauth2_21

} // end of namespace: com.codename1.io
