// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLImageMap: global::com.codename1.ui.Button,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.ui.html.ImageMapData _fmapData;

public global::com.codename1.ui.html.HTMLComponent _fhtmlC;

public void @this(global::com.codename1.ui.html.HTMLComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLImageMap: void <init>(com.codename1.ui.html.HTMLComponent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.ui.Button) _r1_o).@this();
    ((global::com.codename1.ui.html.HTMLImageMap) _r1_o)._fhtmlC = (global::com.codename1.ui.html.HTMLComponent) _r2_o;
    // Value=HTMLLink
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107))}));
    ((global::com.codename1.ui.html.HTMLImageMap) _r1_o).setUIID((global::java.lang.String) _r0_o);
    ((global::com.codename1.ui.html.HTMLImageMap) _r1_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLImageMap: void <init>(com.codename1.ui.html.HTMLComponent)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLImageMap: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fmapData;
    if (_r5_o == null) goto label76;
    _r3.i = ((global::com.codename1.ui.events.ActionEvent) _r8_o).getX();
    _r4.i = ((global::com.codename1.ui.events.ActionEvent) _r8_o).getY();
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fmapData;
    _r5_o = ((global::com.codename1.ui.html.ImageMapData) _r5_o)._fareas;
    if (_r5_o == null) goto label77;
    _r5.i = -1;
    if (_r3.i == _r5.i) goto label77;
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fmapData;
    _r5_o = ((global::com.codename1.ui.html.ImageMapData) _r5_o)._fareas;
    _r0_o = ((global::java.util.Hashtable) _r5_o).keys();
    label29:;
    _r5.i = ((global::java.util.Enumeration) _r0_o).hasMoreElements() ? 1 : 0;
    if (_r5.i == 0) goto label77;
    _r2_o = ((global::java.util.Enumeration) _r0_o).nextElement();
    _r2_o = _r2_o;
    _r5.i = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o).getAbsoluteX();
    _r5.i = _r3.i - _r5.i;
    _r6.i = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o).getAbsoluteY();
    _r6.i = _r4.i - _r6.i;
    _r5.i = ((global::com.codename1.ui.geom.Rectangle) _r2_o).contains((int) _r5.i, (int) _r6.i) ? 1 : 0;
    if (_r5.i == 0) goto label29;
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fmapData;
    _r5_o = ((global::com.codename1.ui.html.ImageMapData) _r5_o)._fareas;
    _r1_o = ((global::java.util.Hashtable) _r5_o).get((global::java.lang.Object) _r2_o);
    _r1_o = _r1_o;
    if (_r1_o == null) goto label76;
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fhtmlC;
    global::com.codename1.ui.html.HTMLLink.processLink((global::com.codename1.ui.html.HTMLComponent) _r5_o, (global::java.lang.String) _r1_o);
    label76:;
    return;
    label77:;
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fmapData;
    _r5_o = ((global::com.codename1.ui.html.ImageMapData) _r5_o)._fdefaultLink;
    if (_r5_o == null) goto label76;
    _r5_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fhtmlC;
    _r6_o = ((global::com.codename1.ui.html.HTMLImageMap) _r7_o)._fmapData;
    _r6_o = ((global::com.codename1.ui.html.ImageMapData) _r6_o)._fdefaultLink;
    global::com.codename1.ui.html.HTMLLink.processLink((global::com.codename1.ui.html.HTMLComponent) _r5_o, (global::java.lang.String) _r6_o);
    goto label76;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLImageMap: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLImageMap]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLImageMap]

} // end of class: HTMLImageMap

} // end of namespace: com.codename1.ui.html
