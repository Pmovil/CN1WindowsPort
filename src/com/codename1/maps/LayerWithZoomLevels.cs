// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps {
public class LayerWithZoomLevels: global::java.lang.Object {
public global::com.codename1.maps.layers.Layer _flayer;

public int _fminZoomLevel;

public int _fmaxZoomLevel;

public void @this(global::com.codename1.maps.layers.Layer n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.LayerWithZoomLevels: void <init>(com.codename1.maps.layers.Layer, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3.i = n3;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.maps.LayerWithZoomLevels) _r0_o)._flayer = (global::com.codename1.maps.layers.Layer) _r1_o;
    ((global::com.codename1.maps.LayerWithZoomLevels) _r0_o)._fminZoomLevel = _r2.i;
    ((global::com.codename1.maps.LayerWithZoomLevels) _r0_o)._fmaxZoomLevel = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.LayerWithZoomLevels: void <init>(com.codename1.maps.layers.Layer, int, int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.LayerWithZoomLevels]
//XMLVM_END_WRAPPER[com.codename1.maps.LayerWithZoomLevels]

} // end of class: LayerWithZoomLevels

} // end of namespace: com.codename1.maps
