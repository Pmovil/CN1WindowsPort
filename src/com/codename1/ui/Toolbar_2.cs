// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Toolbar_22: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.ui.Form _fval_2f;

public global::com.codename1.ui.Toolbar _fthis_20;

public void @this(global::com.codename1.ui.Toolbar n1, global::com.codename1.ui.Form n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Toolbar$2: void <init>(com.codename1.ui.Toolbar, com.codename1.ui.Form)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.Toolbar_22) _r0_o)._fthis_20 = (global::com.codename1.ui.Toolbar) _r1_o;
    ((global::com.codename1.ui.Toolbar_22) _r0_o)._fval_2f = (global::com.codename1.ui.Form) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Toolbar$2: void <init>(com.codename1.ui.Toolbar, com.codename1.ui.Form)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Toolbar$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.ui.Toolbar_22) _r2_o)._fthis_20;
    _r0.i = ((global::com.codename1.ui.Toolbar) _r0_o).getY();
    _r1_o = ((global::com.codename1.ui.Toolbar_22) _r2_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.Toolbar) _r1_o).getHeight();
    _r1.i = _r1.i / 2;
    _r0.i = _r0.i + _r1.i;
    if (_r0.i <= 0) goto label28;
    _r0_o = ((global::com.codename1.ui.Toolbar_22) _r2_o)._fthis_20;
    ((global::com.codename1.ui.Toolbar) _r0_o).showToolbar();
    label22:;
    _r0_o = ((global::com.codename1.ui.Toolbar_22) _r2_o)._fval_2f;
    ((global::com.codename1.ui.Form) _r0_o).repaint();
    return;
    label28:;
    _r0_o = ((global::com.codename1.ui.Toolbar_22) _r2_o)._fthis_20;
    ((global::com.codename1.ui.Toolbar) _r0_o).hideToolbar();
    goto label22;
//XMLVM_END_WRAPPER[com.codename1.ui.Toolbar$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Toolbar$2]
//XMLVM_END_WRAPPER[com.codename1.ui.Toolbar$2]

} // end of class: Toolbar_22

} // end of namespace: com.codename1.ui
