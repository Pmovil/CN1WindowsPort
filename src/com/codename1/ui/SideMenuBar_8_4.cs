// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_28_24: global::java.lang.Object,global::com.codename1.ui.animations.Animation {
public global::com.codename1.ui.animations.Motion _fval_2motion;

public global::com.codename1.ui.SideMenuBar_28 _fthis_21;

public void @this(global::com.codename1.ui.SideMenuBar_28 n1, global::com.codename1.ui.animations.Motion n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$4: void <init>(com.codename1.ui.SideMenuBar$8, com.codename1.ui.animations.Motion)]
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
    ((global::com.codename1.ui.SideMenuBar_28_24) _r0_o)._fthis_21 = (global::com.codename1.ui.SideMenuBar_28) _r1_o;
    ((global::com.codename1.ui.SideMenuBar_28_24) _r0_o)._fval_2motion = (global::com.codename1.ui.animations.Motion) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$4: void <init>(com.codename1.ui.SideMenuBar$8, com.codename1.ui.animations.Motion)]
}

public virtual bool animate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$4: boolean animate()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28) _r0_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fval_2motion;
    _r1.i = ((global::com.codename1.ui.animations.Motion) _r1_o).getValue();
    global::com.codename1.ui.SideMenuBar.access_2102((global::com.codename1.ui.SideMenuBar) _r0_o, (int) _r1.i);
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fval_2motion;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).isFinished() ? 1 : 0;
    if (_r0.i == 0) goto label29;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28) _r0_o)._fthis_20;
    _r1.i = 0;
    global::com.codename1.ui.SideMenuBar.access_2202((global::com.codename1.ui.SideMenuBar) _r0_o, 0!=_r1.i);
    label29:;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$4: boolean animate()]
}

public virtual void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$4: void paint(com.codename1.ui.Graphics)]
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
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    ((global::com.codename1.ui.SideMenuBar_28) _r0_o).repaint();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28) _r0_o)._fthis_20;
    _r0.i = global::com.codename1.ui.SideMenuBar.access_2100((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fval_2motion;
    _r1.i = ((global::com.codename1.ui.animations.Motion) _r1_o).getDestinationValue();
    if (_r0.i != _r1.i) goto label72;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fval_2motion;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).isFinished() ? 1 : 0;
    if (_r0.i == 0) goto label72;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28) _r0_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = global::com.codename1.ui.animations.CommonTransitions.createEmpty();
    ((global::com.codename1.ui.Form) _r0_o).setTransitionInAnimator((global::com.codename1.ui.animations.Transition) _r1_o);
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28) _r0_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r0_o);
    ((global::com.codename1.ui.Form) _r0_o).show();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_28_24) _r2_o)._fthis_21;
    ((global::com.codename1.ui.SideMenuBar_28) _r0_o).deregisterAnimated((global::com.codename1.ui.animations.Animation) _r2_o);
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r1_o = new global::com.codename1.ui.SideMenuBar_28_24_21();
    ((global::com.codename1.ui.SideMenuBar_28_24_21) _r1_o).@this((global::com.codename1.ui.SideMenuBar_28_24) _r2_o);
    ((global::com.codename1.ui.Display) _r0_o).callSerially((global::java.lang.Runnable) _r1_o);
    label72:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$4: void paint(com.codename1.ui.Graphics)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$4]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$4]

} // end of class: SideMenuBar_28_24

} // end of namespace: com.codename1.ui
