// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps.layers {
public class PointLayer: global::com.codename1.maps.Coord,global::com.codename1.maps.layers.Layer {
private global::java.lang.String _fname;

private global::com.codename1.ui.Image _ficon;

private bool _fdisplayName;

public void @this(global::com.codename1.maps.Coord n1, global::java.lang.String n2, global::com.codename1.ui.Image n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: void <init>(com.codename1.maps.Coord, java.lang.String, com.codename1.ui.Image)]
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
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.maps.Coord) _r0_o).@this((global::com.codename1.maps.Coord) _r1_o);
    ((global::com.codename1.maps.layers.PointLayer) _r0_o)._fname = (global::java.lang.String) _r2_o;
    ((global::com.codename1.maps.layers.PointLayer) _r0_o)._ficon = (global::com.codename1.ui.Image) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: void <init>(com.codename1.maps.Coord, java.lang.String, com.codename1.ui.Image)]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.maps.layers.PointLayer) _r1_o)._fname;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: java.lang.String getName()]
}

public virtual global::System.Object getIcon(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: com.codename1.ui.Image getIcon()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.maps.layers.PointLayer) _r1_o)._ficon;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: com.codename1.ui.Image getIcon()]
}

public virtual void setIcon(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: void setIcon(com.codename1.ui.Image)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.maps.layers.PointLayer) _r0_o)._ficon = (global::com.codename1.ui.Image) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: void setIcon(com.codename1.ui.Image)]
}

public virtual void setDisplayName(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: void setDisplayName(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.maps.layers.PointLayer) _r0_o)._fdisplayName = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: void setDisplayName(boolean)]
}

public virtual void paint(global::com.codename1.ui.Graphics n1, global::com.codename1.maps.Tile n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: void paint(com.codename1.ui.Graphics, com.codename1.maps.Tile)]
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
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r1_o = ((global::com.codename1.maps.Tile) _r11_o).pointPosition((global::com.codename1.maps.Coord) _r9_o);
    _r2.i = 6;
    _r0.i = 6;
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._ficon;
    if (_r5_o == null) goto label22;
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._ficon;
    _r2.i = ((global::com.codename1.ui.Image) _r5_o).getWidth();
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._ficon;
    _r0.i = ((global::com.codename1.ui.Image) _r5_o).getHeight();
    label22:;
    _r5.i = ((global::com.codename1.ui.geom.Point) _r1_o).getX();
    _r6.i = _r2.i / 2;
    _r3.i = _r5.i - _r6.i;
    _r5.i = ((global::com.codename1.ui.geom.Point) _r1_o).getY();
    _r6.i = _r0.i / 2;
    _r4.i = _r5.i - _r6.i;
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._ficon;
    if (_r5_o != null) goto label82;
    ((global::com.codename1.ui.Graphics) _r10_o).fillRect((int) _r3.i, (int) _r4.i, (int) _r2.i, (int) _r0.i);
    label45:;
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._fname;
    if (_r5_o == null) goto label81;
    _r5.i = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._fdisplayName ? 1 : 0;
    if (_r5.i == 0) goto label81;
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o).getName();
    _r6.i = _r3.i + _r2.i;
    _r6.i = _r6.i + 1;
    _r7.i = ((global::com.codename1.ui.geom.Point) _r1_o).getY();
    _r8_o = ((global::com.codename1.ui.Graphics) _r10_o).getFont();
    _r8.i = ((global::com.codename1.ui.Font) _r8_o).getHeight();
    _r8.i = _r8.i / 2;
    _r7.i = _r7.i - _r8.i;
    _r8.i = 1;
    _r7.i = _r7.i - _r8.i;
    ((global::com.codename1.ui.Graphics) _r10_o).drawString((global::java.lang.String) _r5_o, (int) _r6.i, (int) _r7.i);
    label81:;
    return;
    label82:;
    _r5_o = ((global::com.codename1.maps.layers.PointLayer) _r9_o)._ficon;
    ((global::com.codename1.ui.Graphics) _r10_o).drawImage((global::com.codename1.ui.Image) _r5_o, (int) _r3.i, (int) _r4.i);
    goto label45;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: void paint(com.codename1.ui.Graphics, com.codename1.maps.Tile)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = base.toString();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value= 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.maps.layers.PointLayer) _r2_o)._fname;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: java.lang.String toString()]
}

public virtual global::System.Object boundingBox(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer: com.codename1.maps.BoundingBox boundingBox()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = null;
    return (global::com.codename1.maps.BoundingBox) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer: com.codename1.maps.BoundingBox boundingBox()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.PointLayer]
//XMLVM_END_WRAPPER[com.codename1.maps.layers.PointLayer]

} // end of class: PointLayer

} // end of namespace: com.codename1.maps.layers
