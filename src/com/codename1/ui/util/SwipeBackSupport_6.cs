// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public class SwipeBackSupport_26: global::java.lang.Object,global::com.codename1.ui.Painter {
public global::com.codename1.ui.animations.Transition _fval_2t;

public global::com.codename1.ui.util.SwipeBackSupport _fthis_20;

public void @this(global::com.codename1.ui.util.SwipeBackSupport n1, global::com.codename1.ui.animations.Transition n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$6: void <init>(com.codename1.ui.util.SwipeBackSupport, com.codename1.ui.animations.Transition)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.util.SwipeBackSupport_26) _r0_o)._fthis_20 = (global::com.codename1.ui.util.SwipeBackSupport) _r1_o;
    ((global::com.codename1.ui.util.SwipeBackSupport_26) _r0_o)._fval_2t = (global::com.codename1.ui.animations.Transition) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$6: void <init>(com.codename1.ui.util.SwipeBackSupport, com.codename1.ui.animations.Transition)]
}

public virtual void paint(global::com.codename1.ui.Graphics n1, global::com.codename1.ui.geom.Rectangle n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$6: void paint(com.codename1.ui.Graphics, com.codename1.ui.geom.Rectangle)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.ui.util.SwipeBackSupport_26) _r1_o)._fval_2t;
    ((global::com.codename1.ui.animations.Transition) _r0_o).animate();
    _r0_o = ((global::com.codename1.ui.util.SwipeBackSupport_26) _r1_o)._fval_2t;
    ((global::com.codename1.ui.animations.Transition) _r0_o).paint((global::com.codename1.ui.Graphics) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$6: void paint(com.codename1.ui.Graphics, com.codename1.ui.geom.Rectangle)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$6]
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$6]

} // end of class: SwipeBackSupport_26

} // end of namespace: com.codename1.ui.util
