// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.renderers {
public class XYMultipleSeriesRenderer_2Orientation: global::java.lang.Enum {

static XYMultipleSeriesRenderer_2Orientation() {
    @static();
}

public static global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation _fHORIZONTAL;

public static global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation _fVERTICAL;

private int _fmAngle;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _f_2VALUES;

public static global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation[] values()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r0_o = global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._f_2VALUES;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._f_2VALUES;
    _r2_o = global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._f_2VALUES;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation[] values()]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation valueOf(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation));
    _r1_o = global::java.lang.Enum.valueOf((global::java.lang.Class) _r0_o, (global::java.lang.String) _r1_o);
    _r1_o = _r1_o;
    return (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation valueOf(java.lang.String)]
}

private void @this(global::java.lang.String n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: void <init>(java.lang.String, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    ((global::java.lang.Enum) _r1_o).@this((global::java.lang.String) _r2_o, (int) _r3.i);
    _r0.i = 0;
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r1_o)._fmAngle = _r0.i;
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r1_o)._fmAngle = _r4.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: void <init>(java.lang.String, int, int)]
}

public virtual int getAngle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: int getAngle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r1_o)._fmAngle;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: int getAngle()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r4.i = 1;
    _r3.i = 0;
    _r0_o = new global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation();
    // Value=HORIZONTAL
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)72)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 90)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 76))}));
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r3.i, (int) _r3.i);
    global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._fHORIZONTAL = (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r0_o;
    _r0_o = new global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation();
    // Value=VERTICAL
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)86)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 76))}));
    _r2.i = 90;
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r4.i, (int) _r2.i);
    global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._fVERTICAL = (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r0_o;
    _r0.i = 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._fHORIZONTAL;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i] = _r1_o;
    _r1_o = global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._fVERTICAL;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r4.i] = _r1_o;
    global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation._f_2VALUES = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation]
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation]

} // end of class: XYMultipleSeriesRenderer_2Orientation

} // end of namespace: com.codename1.charts.renderers
