// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public class SwipeBackSupport_22_21: global::java.lang.Object,global::com.codename1.ui.animations.Animation {
public int _fval_2increments;

public int _fval_2destNumber;

public global::com.codename1.ui.util.SwipeBackSupport_22 _fthis_21;

public void @this(global::com.codename1.ui.util.SwipeBackSupport_22 n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1: void <init>(com.codename1.ui.util.SwipeBackSupport$2, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3.i = n3;
    ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r0_o)._fthis_21 = (global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o;
    ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r0_o)._fval_2increments = _r2.i;
    ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r0_o)._fval_2destNumber = _r3.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1: void <init>(com.codename1.ui.util.SwipeBackSupport$2, int, int)]
}

public virtual bool animate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1: boolean animate()]
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
    _r5_o = this;
    _r4.i = 0;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r2.i = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX;
    _r3.i = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fval_2increments;
    _r2.i = _r2.i + _r3.i;
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX = _r2.i;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX;
    if (_r1.i <= 0) goto label30;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX;
    _r2.i = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fval_2destNumber;
    if (_r1.i >= _r2.i) goto label48;
    label30:;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX;
    if (_r1.i >= 0) goto label112;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX;
    _r2.i = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fval_2destNumber;
    if (_r1.i > _r2.i) goto label112;
    label48:;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r2.i = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fval_2destNumber;
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fcurrentX = _r2.i;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fdestinationForm;
    _r0_o = ((global::com.codename1.ui.Form) _r1_o).getTransitionInAnimator();
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fdestinationForm;
    _r2_o = global::com.codename1.ui.animations.CommonTransitions.createEmpty();
    ((global::com.codename1.ui.Form) _r1_o).setTransitionInAnimator((global::com.codename1.ui.animations.Transition) _r2_o);
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fdestinationForm;
    ((global::com.codename1.ui.Form) _r1_o).show();
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fdestinationForm;
    ((global::com.codename1.ui.Form) _r1_o).setTransitionInAnimator((global::com.codename1.ui.animations.Transition) _r0_o);
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    _r2_o = null;
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fdestinationForm = (global::com.codename1.ui.Form) _r2_o;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22_21) _r5_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.util.SwipeBackSupport_22) _r1_o)._fthis_20;
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fdragActivated = 0!=_r4.i;
    _r1.i = _r4.i;
    label111:;
    return _r1.i!=0;
    label112:;
    _r1.i = 1;
    goto label111;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1: boolean animate()]
}

public virtual void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1: void paint(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1: void paint(com.codename1.ui.Graphics)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1]
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$2$1]

} // end of class: SwipeBackSupport_22_21

} // end of namespace: com.codename1.ui.util
