// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Stroke: global::java.lang.Object {
public static int _fJOIN_1MITER = 0;

public static int _fJOIN_1ROUND = 1;

public static int _fJOIN_1BEVEL = 2;

public static int _fCAP_1BUTT = 0;

public static int _fCAP_1ROUND = 1;

public static int _fCAP_1SQUARE = 2;

private int _fjoinStyle;

private int _fcapStyle;

private float _flineWidth;

private float _fmiterLimit;

public void @this(float n1, int n2, int n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: void <init>(float, int, int, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r1_o = this;
    _r2.f = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.f = n4;
    _r0.i = 0;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.Stroke) _r1_o)._fjoinStyle = _r0.i;
    ((global::com.codename1.ui.Stroke) _r1_o)._fcapStyle = _r0.i;
    _r0.f = (float)1.0D;
    ((global::com.codename1.ui.Stroke) _r1_o)._flineWidth = _r0.f;
    _r0.f = (float)4.0D;
    ((global::com.codename1.ui.Stroke) _r1_o)._fmiterLimit = _r0.f;
    ((global::com.codename1.ui.Stroke) _r1_o)._flineWidth = _r2.f;
    ((global::com.codename1.ui.Stroke) _r1_o)._fcapStyle = _r3.i;
    ((global::com.codename1.ui.Stroke) _r1_o)._fjoinStyle = _r4.i;
    ((global::com.codename1.ui.Stroke) _r1_o)._fmiterLimit = _r5.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: void <init>(float, int, int, float)]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.Stroke) _r1_o)._fjoinStyle = _r0.i;
    ((global::com.codename1.ui.Stroke) _r1_o)._fcapStyle = _r0.i;
    _r0.f = (float)1.0D;
    ((global::com.codename1.ui.Stroke) _r1_o)._flineWidth = _r0.f;
    _r0.f = (float)4.0D;
    ((global::com.codename1.ui.Stroke) _r1_o)._fmiterLimit = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: void <init>()]
}

public virtual int getJoinStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: int getJoinStyle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.Stroke) _r1_o)._fjoinStyle;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: int getJoinStyle()]
}

public virtual void setJoinStyle(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: void setJoinStyle(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.Stroke) _r0_o)._fjoinStyle = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: void setJoinStyle(int)]
}

public virtual int getCapStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: int getCapStyle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.Stroke) _r1_o)._fcapStyle;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: int getCapStyle()]
}

public virtual void setCapStyle(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: void setCapStyle(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.Stroke) _r0_o)._fcapStyle = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: void setCapStyle(int)]
}

public virtual float getLineWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: float getLineWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.ui.Stroke) _r1_o)._flineWidth;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: float getLineWidth()]
}

public virtual void setLineWidth(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: void setLineWidth(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.ui.Stroke) _r0_o)._flineWidth = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: void setLineWidth(float)]
}

public virtual float getMiterLimit(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: float getMiterLimit()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.ui.Stroke) _r1_o)._fmiterLimit;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: float getMiterLimit()]
}

public virtual void setMiterLimit(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: void setMiterLimit(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.ui.Stroke) _r0_o)._fmiterLimit = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: void setMiterLimit(float)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: boolean equals(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r4.i = 0;
    _r2.i = ((_r6_o != null) && (_r6_o is global::com.codename1.ui.Stroke)) ? 1 : 0;
    if (_r2.i == 0) goto label41;
    _r0_o = _r6_o;
    _r1_o = _r0_o;
    _r2.f = ((global::com.codename1.ui.Stroke) _r1_o)._fmiterLimit;
    _r3.f = ((global::com.codename1.ui.Stroke) _r5_o)._fmiterLimit;
    _r2.i = _r2.f > _r3.f ? 1 : (_r2.f == _r3.f ? 0 : -1);
    if (_r2.i != 0) goto label39;
    _r2.i = ((global::com.codename1.ui.Stroke) _r1_o)._fcapStyle;
    _r3.i = ((global::com.codename1.ui.Stroke) _r5_o)._fcapStyle;
    if (_r2.i != _r3.i) goto label39;
    _r2.i = ((global::com.codename1.ui.Stroke) _r1_o)._fjoinStyle;
    _r3.i = ((global::com.codename1.ui.Stroke) _r5_o)._fjoinStyle;
    if (_r2.i != _r3.i) goto label39;
    _r2.f = ((global::com.codename1.ui.Stroke) _r1_o)._flineWidth;
    _r3.f = ((global::com.codename1.ui.Stroke) _r5_o)._flineWidth;
    _r2.i = _r2.f > _r3.f ? 1 : (_r2.f == _r3.f ? 0 : -1);
    if (_r2.i != 0) goto label39;
    _r2.i = 1;
    label38:;
    return _r2.i!=0;
    label39:;
    _r2.i = _r4.i;
    goto label38;
    label41:;
    _r2.i = _r4.i;
    goto label38;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 7;
    _r1.i = _r0.i * 59;
    _r1.i = ((global::com.codename1.ui.Stroke) _r3_o)._fjoinStyle;
    _r0.i = _r1.i + 413;
    _r1.i = _r0.i * 59;
    _r2.i = ((global::com.codename1.ui.Stroke) _r3_o)._fcapStyle;
    _r0.i = _r1.i + _r2.i;
    _r1.i = _r0.i * 59;
    _r2.f = ((global::com.codename1.ui.Stroke) _r3_o)._flineWidth;
    _r2.i = global::java.lang.Float.floatToIntBits((float) _r2.f);
    _r0.i = _r1.i + _r2.i;
    _r1.i = _r0.i * 59;
    _r2.f = ((global::com.codename1.ui.Stroke) _r3_o)._fmiterLimit;
    _r2.i = global::java.lang.Float.floatToIntBits((float) _r2.f);
    _r0.i = _r1.i + _r2.i;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke: int hashCode()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Stroke]
//XMLVM_END_WRAPPER[com.codename1.ui.Stroke]

} // end of class: Stroke

} // end of namespace: com.codename1.ui
