// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public class SwipeBackSupport_2ManualMotion: global::com.codename1.ui.animations.Motion {
public global::com.codename1.ui.util.SwipeBackSupport _fthis_20;

public void @this(global::com.codename1.ui.util.SwipeBackSupport n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion: void <init>(com.codename1.ui.util.SwipeBackSupport, int, int, int)]
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
    _r2.i = n2;
    _r3.i = n3;
    _r4.i = n4;
    ((global::com.codename1.ui.util.SwipeBackSupport_2ManualMotion) _r0_o)._fthis_20 = (global::com.codename1.ui.util.SwipeBackSupport) _r1_o;
    ((global::com.codename1.ui.animations.Motion) _r0_o).@this((int) _r2.i, (int) _r3.i, (int) _r4.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion: void <init>(com.codename1.ui.util.SwipeBackSupport, int, int, int)]
}

public override int getValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion: int getValue()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r0.i = ((global::com.codename1.ui.util.SwipeBackSupport_2ManualMotion) _r7_o).getDestinationValue();
    _r3.i = ((global::com.codename1.ui.util.SwipeBackSupport_2ManualMotion) _r7_o).getSourceValue();
    _r5_o = ((global::com.codename1.ui.util.SwipeBackSupport_2ManualMotion) _r7_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.util.SwipeBackSupport) _r5_o)._fcurrentX;
    _r5.f = (float) _r5.i;
    _r6_o = global::com.codename1.ui.Display.getInstance();
    _r6.i = ((global::com.codename1.ui.Display) _r6_o).getDisplayWidth();
    _r6.f = (float) _r6.i;
    _r2.f = _r5.f / _r6.f;
    _r1.i = _r0.i - _r3.i;
    _r5.f = (float) _r3.i;
    _r6.f = (float) _r1.i;
    _r6.f = _r6.f * _r2.f;
    _r5.f = _r5.f + _r6.f;
    _r4.i = (int) _r5.f;
    if (_r0.i >= _r3.i) goto label38;
    _r5.i = global::java.lang.Math.max((int) _r0.i, (int) _r4.i);
    label37:;
    return _r5.i;
    label38:;
    _r5.i = global::java.lang.Math.min((int) _r0.i, (int) _r4.i);
    goto label37;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion: int getValue()]
}

public override bool isFinished(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion: boolean isFinished()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion: boolean isFinished()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion]
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport$ManualMotion]

} // end of class: SwipeBackSupport_2ManualMotion

} // end of namespace: com.codename1.ui.util
