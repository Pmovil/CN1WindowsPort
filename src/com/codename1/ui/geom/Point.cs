// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.geom {
public class Point: global::java.lang.Object {
private int _fx;

private int _fy;

public void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point: void <init>(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.geom.Point) _r0_o)._fx = _r1.i;
    ((global::com.codename1.ui.geom.Point) _r0_o)._fy = _r2.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point: void <init>(int, int)]
}

public virtual int getX(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point: int getX()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.geom.Point) _r1_o)._fx;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point: int getX()]
}

public virtual int getY(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point: int getY()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.geom.Point) _r1_o)._fy;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point: int getY()]
}

public virtual void setX(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point: void setX(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.geom.Point) _r0_o)._fx = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point: void setX(int)]
}

public virtual void setY(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point: void setY(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.geom.Point) _r0_o)._fy = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point: void setY(int)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1.i = ((global::com.codename1.ui.geom.Point) _r2_o)._fx;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=, 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.ui.geom.Point) _r2_o)._fy;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point]
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point]

} // end of class: Point

} // end of namespace: com.codename1.ui.geom
