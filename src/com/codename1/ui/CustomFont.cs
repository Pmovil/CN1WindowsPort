// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class CustomFont: global::com.codename1.ui.Font {
private static int _fCOLOR_1CACHE_1SIZE = 5;

private global::java.util.Hashtable _fcolorCache;

private global::java.lang.String _fcharsets;

private int _fcolor;

public global::com.codename1.ui.Image _fcache;

public global::org.xmlvm._nArrayAdapter<int> _fcutOffsets;

public global::org.xmlvm._nArrayAdapter<int> _fcharWidth;

private int _fimageWidth;

private int _fimageHeight;

private global::java.lang.Object _fimageArrayRef;

private global::System.Object getImageArray(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int[] getImageArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1_o = ((global::com.codename1.ui.CustomFont) _r2_o)._fimageArrayRef;
    if (_r1_o == null) goto label12;
    _r2_o = ((global::com.codename1.ui.CustomFont) _r2_o)._fimageArrayRef;
    _r2_o = _r2_o;
    _r2_o = _r2_o;
    _r1_o = _r2_o;
    label11:;
    return (global::org.xmlvm._nArrayAdapter<int>) _r1_o;
    label12:;
    _r1_o = ((global::com.codename1.ui.CustomFont) _r2_o)._fcache;
    _r0_o = ((global::com.codename1.ui.Image) _r1_o).getRGBCached();
    ((global::com.codename1.ui.CustomFont) _r2_o)._fimageArrayRef = (global::java.lang.Object) _r0_o;
    _r1_o = _r0_o;
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int[] getImageArray()]
}

public void @this(global::com.codename1.ui.Image n1, global::org.xmlvm._nArrayAdapter<int> n2, global::org.xmlvm._nArrayAdapter<int> n3, global::java.lang.String n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: void <init>(com.codename1.ui.Image, int[], int[], java.lang.String)]
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
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9_o = n1;
    _r10_o = n2;
    _r11_o = n3;
    _r12_o = n4;
    _r2.i = 0;
    ((global::com.codename1.ui.Font) _r8_o).@this();
    _r0_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r0_o).@this();
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache = (global::java.util.Hashtable) _r0_o;
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcutOffsets = (global::org.xmlvm._nArrayAdapter<int>) _r10_o;
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcharWidth = (global::org.xmlvm._nArrayAdapter<int>) _r11_o;
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcharsets = (global::java.lang.String) _r12_o;
    _r0.i = ((global::com.codename1.ui.Image) _r9_o).getWidth();
    ((global::com.codename1.ui.CustomFont) _r8_o)._fimageWidth = _r0.i;
    _r0.i = ((global::com.codename1.ui.Image) _r9_o).getHeight();
    ((global::com.codename1.ui.CustomFont) _r8_o)._fimageHeight = _r0.i;
    _r0.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fimageWidth;
    _r3.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fimageHeight;
    _r0.i = _r0.i * _r3.i;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r5.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fimageWidth;
    _r6.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fimageHeight;
    _r0_o = _r9_o;
    _r3.i = _r2.i;
    _r4.i = _r2.i;
    ((global::com.codename1.ui.Image) _r0_o).getRGB((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    _r7.i = 0;
    label47:;
    _r0.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r7.i >= _r0.i) goto label62;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r7.i];
    _r2.i = 16711680;
    _r0.i = _r0.i & _r2.i;
    _r0.i = _r0.i << (0x1f & 8);
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r7.i] = _r0.i;
    _r7.i = _r7.i + 1;
    goto label47;
    label62:;
    _r0.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fimageWidth;
    _r2.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fimageHeight;
    _r0_o = global::com.codename1.ui.Image.createImage((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r0.i, (int) _r2.i);
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcache = (global::com.codename1.ui.Image) _r0_o;
    ((global::com.codename1.ui.CustomFont) _r8_o)._fimageArrayRef = (global::java.lang.Object) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: void <init>(com.codename1.ui.Image, int[], int[], java.lang.String)]
}

public override int charWidth(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int charWidth(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r1_o = ((global::com.codename1.ui.CustomFont) _r2_o)._fcharsets;
    _r0.i = ((global::java.lang.String) _r1_o).indexOf((int) _r3.i);
    if (_r0.i >= 0) goto label10;
    _r1.i = 0;
    label9:;
    return _r1.i;
    label10:;
    _r1_o = ((global::com.codename1.ui.CustomFont) _r2_o)._fcharWidth;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i];
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int charWidth(char)]
}

public override int getHeight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int getHeight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.CustomFont) _r1_o)._fimageHeight;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int getHeight()]
}

private bool checkCacheCurrentColor(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: boolean checkCacheCurrentColor(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9.i = n1;
    _r7.i = 5;
    _r1_o = new global::java.lang.Integer();
    _r5.i = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolor;
    ((global::java.lang.Integer) _r1_o).@this((int) _r5.i);
    _r4_o = new global::java.lang.Integer();
    ((global::java.lang.Integer) _r4_o).@this((int) _r9.i);
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r5_o = ((global::java.util.Hashtable) _r5_o).get((global::java.lang.Object) _r1_o);
    if (_r5_o != null) goto label28;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r6_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcache;
    ((global::java.util.Hashtable) _r5_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r6_o);
    label28:;
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcolor = _r9.i;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r3_o = ((global::java.util.Hashtable) _r5_o).get((global::java.lang.Object) _r4_o);
    if (_r3_o == null) goto label76;
    _r0_o = _r3_o;
    _r0_o = _r0_o;
    _r2_o = _r0_o;
    if (_r2_o == null) goto label71;
    ((global::com.codename1.ui.CustomFont) _r8_o)._fcache = (global::com.codename1.ui.Image) _r2_o;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r5.i = ((global::java.util.Hashtable) _r5_o).size();
    if (_r5.i <= _r7.i) goto label69;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r6_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r6_o = ((global::java.util.Hashtable) _r6_o).keys();
    _r6_o = ((global::java.util.Enumeration) _r6_o).nextElement();
    ((global::java.util.Hashtable) _r5_o).remove((global::java.lang.Object) _r6_o);
    label69:;
    _r5.i = 1;
    label70:;
    return _r5.i!=0;
    label71:;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    ((global::java.util.Hashtable) _r5_o).remove((global::java.lang.Object) _r4_o);
    label76:;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r5.i = ((global::java.util.Hashtable) _r5_o).size();
    if (_r5.i <= _r7.i) goto label99;
    _r5_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r6_o = ((global::com.codename1.ui.CustomFont) _r8_o)._fcolorCache;
    _r6_o = ((global::java.util.Hashtable) _r6_o).keys();
    _r6_o = ((global::java.util.Enumeration) _r6_o).nextElement();
    ((global::java.util.Hashtable) _r5_o).remove((global::java.lang.Object) _r6_o);
    label99:;
    _r5.i = 0;
    goto label70;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: boolean checkCacheCurrentColor(int)]
}

private void initColor(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: void initColor(com.codename1.ui.Graphics)]
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
    _r6_o = this;
    _r7_o = n1;
    _r2.i = ((global::com.codename1.ui.Graphics) _r7_o).getColor();
    _r3.i = ((global::com.codename1.ui.CustomFont) _r6_o)._fcolor;
    if (_r2.i == _r3.i) goto label51;
    _r3.i = ((global::com.codename1.ui.CustomFont) _r6_o).checkCacheCurrentColor((int) _r2.i) ? 1 : 0;
    if (_r3.i != 0) goto label51;
    _r3.i = 16777215;
    _r3.i = _r3.i & _r2.i;
    ((global::com.codename1.ui.CustomFont) _r6_o)._fcolor = _r3.i;
    _r0_o = ((global::com.codename1.ui.CustomFont) _r6_o).getImageArray();
    _r1.i = 0;
    label25:;
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r1.i >= _r3.i) goto label41;
    _r3.i = ((global::com.codename1.ui.CustomFont) _r6_o)._fcolor;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i];
    _r5.i = -16777216;
    _r4.i = _r4.i & _r5.i;
    _r3.i = _r3.i | _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r3.i;
    _r1.i = _r1.i + 1;
    goto label25;
    label41:;
    _r3.i = ((global::com.codename1.ui.CustomFont) _r6_o)._fimageWidth;
    _r4.i = ((global::com.codename1.ui.CustomFont) _r6_o)._fimageHeight;
    _r3_o = global::com.codename1.ui.Image.createImage((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r3.i, (int) _r4.i);
    ((global::com.codename1.ui.CustomFont) _r6_o)._fcache = (global::com.codename1.ui.Image) _r3_o;
    label51:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: void initColor(com.codename1.ui.Graphics)]
}

public override void drawChar(global::com.codename1.ui.Graphics n1, char n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: void drawChar(com.codename1.ui.Graphics, char, int, int)]
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
    _r7_o = this;
    _r8_o = n1;
    _r9.i = n2;
    _r10.i = n3;
    _r11.i = n4;
    _r2.i = ((global::com.codename1.ui.Graphics) _r8_o).getClipX();
    _r3.i = ((global::com.codename1.ui.Graphics) _r8_o).getClipY();
    _r1.i = ((global::com.codename1.ui.Graphics) _r8_o).getClipWidth();
    _r0.i = ((global::com.codename1.ui.Graphics) _r8_o).getClipHeight();
    _r5_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcharsets;
    _r4.i = ((global::java.lang.String) _r5_o).indexOf((int) _r9.i);
    _r5.i = -1;
    if (_r4.i <= _r5.i) goto label48;
    ((global::com.codename1.ui.CustomFont) _r7_o).initColor((global::com.codename1.ui.Graphics) _r8_o);
    _r5_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcharWidth;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i];
    _r6.i = ((global::com.codename1.ui.CustomFont) _r7_o)._fimageHeight;
    ((global::com.codename1.ui.Graphics) _r8_o).clipRect((int) _r10.i, (int) _r11.i, (int) _r5.i, (int) _r6.i);
    _r5_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcache;
    _r6_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcutOffsets;
    _r6.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r4.i];
    _r6.i = _r10.i - _r6.i;
    ((global::com.codename1.ui.Graphics) _r8_o).drawImage((global::com.codename1.ui.Image) _r5_o, (int) _r6.i, (int) _r11.i);
    label48:;
    ((global::com.codename1.ui.Graphics) _r8_o).setClip((int) _r2.i, (int) _r3.i, (int) _r1.i, (int) _r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: void drawChar(com.codename1.ui.Graphics, char, int, int)]
}

public override void addContrast(sbyte n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: void addContrast(byte)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6.i = n1;
    _r1_o = ((global::com.codename1.ui.CustomFont) _r5_o).getImageArray();
    _r2.i = 0;
    label5:;
    _r3.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r2.i >= _r3.i) goto label37;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i];
    _r3.i = _r3.i >> (0x1f & 24);
    _r0.i = _r3.i & 255;
    if (_r0.i == 0) goto label34;
    _r3.i = _r0.i + _r6.i;
    _r4.i = 255;
    _r0.i = global::java.lang.Math.min((int) _r3.i, (int) _r4.i);
    _r3.i = _r0.i << (0x1f & 24);
    _r4.i = -16777216;
    _r3.i = _r3.i & _r4.i;
    _r4.i = ((global::com.codename1.ui.CustomFont) _r5_o)._fcolor;
    _r3.i = _r3.i | _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i] = _r3.i;
    label34:;
    _r2.i = _r2.i + 1;
    goto label5;
    label37:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: void addContrast(byte)]
}

public override void drawString(global::com.codename1.ui.Graphics n1, global::java.lang.String n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: void drawString(com.codename1.ui.Graphics, java.lang.String, int, int)]
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
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r12.i = n3;
    _r13.i = n4;
    _r7_o = global::com.codename1.ui.Display.getInstance();
    _r7.i = ((global::com.codename1.ui.Display) _r7_o).isBidiAlgorithm() ? 1 : 0;
    if (_r7.i == 0) goto label39;
    _r5.i = 0;
    label11:;
    _r7.i = ((global::java.lang.String) _r11_o).length();
    if (_r5.i >= _r7.i) goto label39;
    _r7_o = global::com.codename1.ui.Display.getInstance();
    _r8.i = ((global::java.lang.String) _r11_o).charAt((int) _r5.i);
    _r7.i = ((global::com.codename1.ui.Display) _r7_o).isRTL((char) _r8.i) ? 1 : 0;
    if (_r7.i == 0) goto label91;
    _r7_o = global::com.codename1.ui.Display.getInstance();
    _r11_o = ((global::com.codename1.ui.Display) _r7_o).convertBidiLogicalToVisual((global::java.lang.String) _r11_o);
    label39:;
    ((global::com.codename1.ui.CustomFont) _r9_o).initColor((global::com.codename1.ui.Graphics) _r10_o);
    _r3.i = ((global::com.codename1.ui.Graphics) _r10_o).getClipX();
    _r4.i = ((global::com.codename1.ui.Graphics) _r10_o).getClipY();
    _r2.i = ((global::com.codename1.ui.Graphics) _r10_o).getClipWidth();
    _r1.i = ((global::com.codename1.ui.Graphics) _r10_o).getClipHeight();
    _r7.i = ((global::com.codename1.ui.CustomFont) _r9_o).getHeight();
    _r7.i = _r7.i + _r13.i;
    if (_r4.i > _r7.i) goto label135;
    _r7.i = _r4.i + _r1.i;
    if (_r7.i < _r13.i) goto label135;
    _r5.i = 0;
    label70:;
    _r7.i = ((global::java.lang.String) _r11_o).length();
    if (_r5.i >= _r7.i) goto label135;
    _r0.i = ((global::java.lang.String) _r11_o).charAt((int) _r5.i);
    _r7_o = ((global::com.codename1.ui.CustomFont) _r9_o)._fcharsets;
    _r6.i = ((global::java.lang.String) _r7_o).indexOf((int) _r0.i);
    if (_r6.i >= 0) goto label94;
    label88:;
    _r5.i = _r5.i + 1;
    goto label70;
    label91:;
    _r5.i = _r5.i + 1;
    goto label11;
    label94:;
    _r7_o = ((global::com.codename1.ui.CustomFont) _r9_o)._fcharWidth;
    _r7.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r6.i];
    _r8.i = ((global::com.codename1.ui.CustomFont) _r9_o)._fimageHeight;
    ((global::com.codename1.ui.Graphics) _r10_o).clipRect((int) _r12.i, (int) _r13.i, (int) _r7.i, (int) _r8.i);
    _r7.i = ((global::com.codename1.ui.Graphics) _r10_o).getClipWidth();
    if (_r7.i <= 0) goto label126;
    _r7.i = ((global::com.codename1.ui.Graphics) _r10_o).getClipHeight();
    if (_r7.i <= 0) goto label126;
    _r7_o = ((global::com.codename1.ui.CustomFont) _r9_o)._fcache;
    _r8_o = ((global::com.codename1.ui.CustomFont) _r9_o)._fcutOffsets;
    _r8.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r6.i];
    _r8.i = _r12.i - _r8.i;
    ((global::com.codename1.ui.Graphics) _r10_o).drawImage((global::com.codename1.ui.Image) _r7_o, (int) _r8.i, (int) _r13.i);
    label126:;
    _r7_o = ((global::com.codename1.ui.CustomFont) _r9_o)._fcharWidth;
    _r7.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r6.i];
    _r12.i = _r12.i + _r7.i;
    ((global::com.codename1.ui.Graphics) _r10_o).setClip((int) _r3.i, (int) _r4.i, (int) _r2.i, (int) _r1.i);
    goto label88;
    label135:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: void drawString(com.codename1.ui.Graphics, java.lang.String, int, int)]
}

public override void drawChars(global::com.codename1.ui.Graphics n1, global::org.xmlvm._nArrayAdapter<char> n2, int n3, int n4, int n5, int n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: void drawChars(com.codename1.ui.Graphics, char[], int, int, int, int)]
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
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r15_o = this;
    _r16_o = n1;
    _r17_o = n2;
    _r18.i = n3;
    _r19.i = n4;
    _r20.i = n5;
    _r21.i = n6;
    _r13_o = global::com.codename1.ui.Display.getInstance();
    _r13.i = ((global::com.codename1.ui.Display) _r13_o).isBidiAlgorithm() ? 1 : 0;
    if (_r13.i == 0) goto label59;
    _r10.i = _r18.i;
    label12:;
    _r0.i = _r10.i;
    _r1.i = _r19.i;
    if (_r0.i >= _r1.i) goto label59;
    _r13_o = global::com.codename1.ui.Display.getInstance();
    _r14.i = ((global::org.xmlvm._nArrayAdapter<char>) _r17_o)[_r10.i];
    _r13.i = ((global::com.codename1.ui.Display) _r13_o).isRTL((char) _r14.i) ? 1 : 0;
    if (_r13.i == 0) goto label114;
    _r13_o = global::com.codename1.ui.Display.getInstance();
    _r14_o = new global::java.lang.String();
    _r0_o = _r14_o;
    _r1_o = _r17_o;
    _r2.i = _r18.i;
    _r3.i = _r19.i;
    ((global::java.lang.String) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (int) _r2.i, (int) _r3.i);
    _r12_o = ((global::com.codename1.ui.Display) _r13_o).convertBidiLogicalToVisual((global::java.lang.String) _r14_o);
    _r17_o = ((global::java.lang.String) _r12_o).toCharArray();
    _r18.i = 0;
    _r19.i = ((global::java.lang.String) _r12_o).length();
    label59:;
    ((global::com.codename1.ui.CustomFont) _r15_o).initColor((global::com.codename1.ui.Graphics) _r16_o);
    _r8.i = ((global::com.codename1.ui.Graphics) _r16_o).getClipX();
    _r9.i = ((global::com.codename1.ui.Graphics) _r16_o).getClipY();
    _r7.i = ((global::com.codename1.ui.Graphics) _r16_o).getClipWidth();
    _r6.i = ((global::com.codename1.ui.Graphics) _r16_o).getClipHeight();
    _r13.i = ((global::com.codename1.ui.CustomFont) _r15_o).getHeight();
    _r13.i = _r13.i + _r21.i;
    if (_r9.i > _r13.i) goto label179;
    _r13.i = _r9.i + _r6.i;
    _r0.i = _r13.i;
    _r1.i = _r21.i;
    if (_r0.i < _r1.i) goto label179;
    _r10.i = 0;
    label94:;
    _r0.i = _r10.i;
    _r1.i = _r19.i;
    if (_r0.i >= _r1.i) goto label179;
    _r13.i = _r18.i + _r10.i;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<char>) _r17_o)[_r13.i];
    _r13_o = ((global::com.codename1.ui.CustomFont) _r15_o)._fcharsets;
    _r11.i = ((global::java.lang.String) _r13_o).indexOf((int) _r5.i);
    if (_r11.i >= 0) goto label117;
    label111:;
    _r10.i = _r10.i + 1;
    goto label94;
    label114:;
    _r10.i = _r10.i + 1;
    goto label12;
    label117:;
    _r13_o = ((global::com.codename1.ui.CustomFont) _r15_o)._fcharWidth;
    _r13.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r11.i];
    _r14.i = ((global::com.codename1.ui.CustomFont) _r15_o)._fimageHeight;
    _r0_o = _r16_o;
    _r1.i = _r20.i;
    _r2.i = _r21.i;
    _r3.i = _r13.i;
    _r4.i = _r14.i;
    ((global::com.codename1.ui.Graphics) _r0_o).clipRect((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    _r13.i = ((global::com.codename1.ui.Graphics) _r16_o).getClipWidth();
    if (_r13.i <= 0) goto label163;
    _r13.i = ((global::com.codename1.ui.Graphics) _r16_o).getClipHeight();
    if (_r13.i <= 0) goto label163;
    _r13_o = ((global::com.codename1.ui.CustomFont) _r15_o)._fcache;
    _r14_o = ((global::com.codename1.ui.CustomFont) _r15_o)._fcutOffsets;
    _r14.i = ((global::org.xmlvm._nArrayAdapter<int>) _r14_o)[_r11.i];
    _r14.i = _r20.i - _r14.i;
    _r0_o = _r16_o;
    _r1_o = _r13_o;
    _r2.i = _r14.i;
    _r3.i = _r21.i;
    ((global::com.codename1.ui.Graphics) _r0_o).drawImage((global::com.codename1.ui.Image) _r1_o, (int) _r2.i, (int) _r3.i);
    label163:;
    _r13_o = ((global::com.codename1.ui.CustomFont) _r15_o)._fcharWidth;
    _r13.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r11.i];
    _r20.i = _r20.i + _r13.i;
    _r0_o = _r16_o;
    _r1.i = _r8.i;
    _r2.i = _r9.i;
    _r3.i = _r7.i;
    _r4.i = _r6.i;
    ((global::com.codename1.ui.Graphics) _r0_o).setClip((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    goto label111;
    label179:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: void drawChars(com.codename1.ui.Graphics, char[], int, int, int, int)]
}

public override global::System.Object getCharset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: java.lang.String getCharset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.CustomFont) _r1_o)._fcharsets;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: java.lang.String getCharset()]
}

public override int charsWidth(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int charsWidth(char[], int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r1.i = 0;
    _r0.i = 0;
    label2:;
    if (_r0.i >= _r6.i) goto label16;
    _r2.i = _r0.i + _r5.i;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<char>) _r4_o)[_r2.i];
    _r2.i = ((global::com.codename1.ui.CustomFont) _r3_o).charWidth((char) _r2.i);
    _r1.i = _r1.i + _r2.i;
    _r0.i = _r0.i + 1;
    goto label2;
    label16:;
    return _r1.i;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int charsWidth(char[], int, int)]
}

public override int substringWidth(global::java.lang.String n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int substringWidth(java.lang.String, int, int)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = ((global::java.lang.String) _r2_o).toCharArray();
    _r0.i = ((global::com.codename1.ui.CustomFont) _r1_o).charsWidth((global::org.xmlvm._nArrayAdapter<char>) _r0_o, (int) _r3.i, (int) _r4.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int substringWidth(java.lang.String, int, int)]
}

public override int stringWidth(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int stringWidth(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r1.i = 0;
    if (_r3_o == null) goto label9;
    _r0.i = ((global::java.lang.String) _r3_o).length();
    if (_r0.i != 0) goto label11;
    label9:;
    _r0.i = _r1.i;
    label10:;
    return _r0.i;
    label11:;
    _r0.i = ((global::java.lang.String) _r3_o).length();
    _r0.i = ((global::com.codename1.ui.CustomFont) _r2_o).substringWidth((global::java.lang.String) _r3_o, (int) _r1.i, (int) _r0.i);
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int stringWidth(java.lang.String)]
}

public override int getFace(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int getFace()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int getFace()]
}

public override int getSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int getSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int getSize()]
}

public override int getStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: int getStyle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: int getStyle()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont: boolean equals(java.lang.Object)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8_o = n1;
    _r6.i = 1;
    _r5.i = 0;
    if (_r8_o != _r7_o) goto label6;
    _r3.i = _r6.i;
    label5:;
    return _r3.i!=0;
    label6:;
    if (_r8_o == null) goto label55;
    _r3_o = ((global::java.lang.Object) _r8_o).getClass();
    _r4_o = ((global::java.lang.Object) _r7_o).getClass();
    if (_r3_o != _r4_o) goto label55;
    _r0_o = _r8_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r3_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcharsets;
    _r4_o = ((global::com.codename1.ui.CustomFont) _r1_o)._fcharsets;
    _r3.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r3.i == 0) goto label55;
    _r2.i = 0;
    label33:;
    _r3_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcutOffsets;
    _r3.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r2.i >= _r3.i) goto label53;
    _r3_o = ((global::com.codename1.ui.CustomFont) _r7_o)._fcutOffsets;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r2.i];
    _r4_o = ((global::com.codename1.ui.CustomFont) _r1_o)._fcutOffsets;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r2.i];
    if (_r3.i == _r4.i) goto label50;
    _r3.i = _r5.i;
    goto label5;
    label50:;
    _r2.i = _r2.i + 1;
    goto label33;
    label53:;
    _r3.i = _r6.i;
    goto label5;
    label55:;
    _r3.i = _r5.i;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont: boolean equals(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CustomFont]
//XMLVM_END_WRAPPER[com.codename1.ui.CustomFont]

} // end of class: CustomFont

} // end of namespace: com.codename1.ui
