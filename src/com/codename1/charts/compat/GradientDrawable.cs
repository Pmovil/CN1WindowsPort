// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.compat {
public class GradientDrawable: global::java.lang.Object {
public global::com.codename1.charts.compat.GradientDrawable_2Orientation _forientation;

public global::org.xmlvm._nArrayAdapter<int> _fcolors;

public global::com.codename1.ui.geom.Rectangle _fbounds;

public void @this(global::com.codename1.charts.compat.GradientDrawable_2Orientation n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.GradientDrawable: void <init>(com.codename1.charts.compat.GradientDrawable$Orientation, int[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.ui.geom.Rectangle();
    ((global::com.codename1.ui.geom.Rectangle) _r0_o).@this();
    ((global::com.codename1.charts.compat.GradientDrawable) _r1_o)._fbounds = (global::com.codename1.ui.geom.Rectangle) _r0_o;
    ((global::com.codename1.charts.compat.GradientDrawable) _r1_o)._forientation = (global::com.codename1.charts.compat.GradientDrawable_2Orientation) _r2_o;
    ((global::com.codename1.charts.compat.GradientDrawable) _r1_o)._fcolors = (global::org.xmlvm._nArrayAdapter<int>) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.GradientDrawable: void <init>(com.codename1.charts.compat.GradientDrawable$Orientation, int[])]
}

public virtual void setBounds(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.GradientDrawable: void setBounds(int, int, int, int)]
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
    _r3_o = this;
    _r4.i = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r7.i = n4;
    _r0_o = ((global::com.codename1.charts.compat.GradientDrawable) _r3_o)._fbounds;
    _r1.i = _r6.i - _r4.i;
    _r2.i = _r7.i - _r5.i;
    ((global::com.codename1.ui.geom.Rectangle) _r0_o).setBounds((int) _r4.i, (int) _r5.i, (int) _r1.i, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.GradientDrawable: void setBounds(int, int, int, int)]
}

public virtual void draw(global::com.codename1.charts.compat.Canvas n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.GradientDrawable: void draw(com.codename1.charts.compat.Canvas)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.compat.Canvas) _r1_o).drawGradient((global::com.codename1.charts.compat.GradientDrawable) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.GradientDrawable: void draw(com.codename1.charts.compat.Canvas)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.GradientDrawable]
//XMLVM_END_WRAPPER[com.codename1.charts.compat.GradientDrawable]

} // end of class: GradientDrawable

} // end of namespace: com.codename1.charts.compat
