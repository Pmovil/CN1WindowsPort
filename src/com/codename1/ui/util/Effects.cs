// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public class Effects: global::java.lang.Object {
private void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects: void <init>()]
}

public static global::System.Object reflectionImage(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image reflectionImage(com.codename1.ui.Image)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0.f = (float)0.5D;
    _r1.i = 120;
    _r0_o = global::com.codename1.ui.util.Effects.reflectionImage((global::com.codename1.ui.Image) _r2_o, (float) _r0.f, (int) _r1.i);
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image reflectionImage(com.codename1.ui.Image)]
}

public static global::System.Object reflectionImage(global::com.codename1.ui.Image n1, float n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image reflectionImage(com.codename1.ui.Image, float, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2.f = n2;
    _r3.i = n3;
    _r0.i = 0;
    _r0_o = global::com.codename1.ui.util.Effects.reflectionImage((global::com.codename1.ui.Image) _r1_o, (float) _r2.f, (int) _r3.i, (int) _r0.i);
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image reflectionImage(com.codename1.ui.Image, float, int)]
}

public static global::System.Object reflectionImage(global::com.codename1.ui.Image n1, float n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image reflectionImage(com.codename1.ui.Image, float, int, int)]
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
    _r9_o = n1;
    _r10.f = n2;
    _r11.i = n3;
    _r12.i = n4;
    _r6.i = ((global::com.codename1.ui.Image) _r9_o).getWidth();
    _r7.i = ((global::com.codename1.ui.Image) _r9_o).getHeight();
    _r0.f = (float) _r7.i;
    _r0.f = _r0.f * _r10.f;
    _r0.i = (int) _r0.f;
    _r8.i = _r0.i * _r6.i;
    _r1_o = new global::com.codename1.ui.RGBImage();
    _r0.i = _r7.i + _r12.i;
    _r0.i = _r0.i * _r6.i;
    _r0.i = _r0.i + _r8.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r2.f = (float) _r7.i;
    _r10.f = _r10.f * _r2.f;
    _r10.i = (int) _r10.f;
    _r10.i = _r10.i + _r12.i;
    _r10.i = _r10.i + _r7.i;
    ((global::com.codename1.ui.RGBImage) _r1_o).@this((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r6.i, (int) _r10.i);
    _r2.i = 0;
    _r3.i = 0;
    _r4.i = 0;
    _r5.i = 0;
    _r0_o = _r9_o;
    ((global::com.codename1.ui.Image) _r0_o).toRGB((global::com.codename1.ui.RGBImage) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i, (int) _r7.i);
    _r10_o = ((global::com.codename1.ui.RGBImage) _r1_o).getRGB();
    _r9.i = 0;
    _r0.i = _r9.i;
    label43:;
    if (_r0.i >= _r8.i) goto label102;
    _r9.i = _r6.i * _r7.i;
    _r9.i = _r9.i - _r0.i;
    _r2.i = 1;
    _r3.i = _r9.i - _r2.i;
    _r9.i = _r0.i % _r6.i;
    _r2.i = _r6.i - _r9.i;
    _r2.i = _r2.i + _r0.i;
    _r9.i = _r2.i - _r9.i;
    _r2.i = ((global::org.xmlvm._nIArray) _r10_o).Length;
    _r9.i = _r8.i - _r9.i;
    _r9.i = _r2.i - _r9.i;
    _r2.i = _r12.i * _r6.i;
    _r2.i = _r2.i + _r9.i;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r3.i];
    _r4.i = -16777216;
    _r9.i = _r9.i & _r4.i;
    if (_r9.i == 0) goto label98;
    _r9.i = ((global::org.xmlvm._nIArray) _r10_o).Length;
    if (_r2.i >= _r9.i) goto label98;
    _r9.f = (float) _r11.i;
    _r4.f = (float) _r8.i;
    _r5.f = (float) _r0.i;
    _r4.f = _r4.f - _r5.f;
    _r9.f = _r9.f * _r4.f;
    _r4.f = (float) _r8.i;
    _r9.f = _r9.f / _r4.f;
    _r9.i = (int) _r9.f;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r3.i];
    _r4.i = 16777215;
    _r3.i = _r3.i & _r4.i;
    _r9.i = _r9.i << (0x1f & 24);
    _r4.i = -16777216;
    _r9.i = _r9.i & _r4.i;
    _r9.i = _r9.i | _r3.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r9.i;
    label98:;
    _r9.i = _r0.i + 1;
    _r0.i = _r9.i;
    goto label43;
    label102:;
    return (global::com.codename1.ui.Image) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image reflectionImage(com.codename1.ui.Image, float, int, int)]
}

public static void growShrink(global::com.codename1.ui.Component n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects: void growShrink(com.codename1.ui.Component, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    _r1.i = n2;
    ((global::com.codename1.ui.Component) _r0_o).growShrink((int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects: void growShrink(com.codename1.ui.Component, int)]
}

public static global::System.Object verticalPerspective(global::com.codename1.ui.Image n1, float n2, float n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image verticalPerspective(com.codename1.ui.Image, float, float, float)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r17_o = n1;
    _r18.f = n2;
    _r19.f = n3;
    _r20.f = n4;
    _r6_o = ((global::com.codename1.ui.Image) _r17_o).getRGB();
    _r10.i = ((global::com.codename1.ui.Image) _r17_o).getWidth();
    _r9.i = ((global::com.codename1.ui.Image) _r17_o).getHeight();
    _r17.f = global::java.lang.Math.max((float) _r18.f, (float) _r19.f);
    _r3.f = (float) _r10.i;
    _r17.f = _r17.f * _r3.f;
    _r0.f = _r17.f;
    _r0.i = (int) _r0.f;
    _r4.i = _r0.i;
    _r0.i = _r9.i;
    _r0.f = (float) _r0.i;
    _r17.f = _r0.f;
    _r17.f = _r17.f * _r20.f;
    _r0.f = _r17.f;
    _r0.i = (int) _r0.f;
    _r3.i = _r0.i;
    _r17.i = _r4.i * _r3.i;
    _r0.i = _r17.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r20_o = _r0_o;
    _r17.i = _r19.f > _r18.f ? 1 : (_r19.f == _r18.f ? 0 : -1);
    if (_r17.i >= 0) goto label135;
    _r5.f = _r19.f;
    _r17.f = _r18.f;
    _r17.f = _r5.f - _r17.f;
    _r5.f = _r17.f;
    label53:;
    if (_r4.i <= _r10.i) goto label160;
    _r17.i = 0;
    _r14.i = _r17.i;
    label59:;
    if (_r14.i >= _r3.i) goto label149;
    _r0.i = _r14.i;
    _r0.f = (float) _r0.i;
    _r17.f = _r0.f;
    _r7.f = (float) _r3.i;
    _r8.f = (float)1.0D;
    _r7.f = _r7.f - _r8.f;
    _r17.f = _r17.f / _r7.f;
    _r7.i = 1;
    _r7.i = _r9.i - _r7.i;
    _r7.f = (float) _r7.i;
    _r7.f = _r7.f * _r17.f;
    _r12.i = (int) _r7.f;
    _r17.f = _r17.f * _r5.f;
    _r17.f = _r17.f + _r18.f;
    _r17.f = _r17.f / _r19.f;
    _r7.f = (float) _r4.i;
    _r8.f = (float)1.0D;
    _r17.f = _r8.f - _r17.f;
    _r17.f = _r17.f * _r7.f;
    _r0.f = _r17.f;
    _r0.i = (int) _r0.f;
    _r8.i = _r0.i;
    _r7.i = _r4.i - _r8.i;
    _r17.i = _r7.i - _r8.i;
    _r0.i = _r17.i;
    _r0.f = (float) _r0.i;
    _r17.f = _r0.f;
    _r11.i = _r8.i;
    _r13.i = _r11.i;
    label106:;
    if (_r13.i >= _r7.i) goto label144;
    _r11.f = (float) _r10.i;
    _r15.f = (float) _r13.i;
    _r0.i = _r8.i;
    _r0.f = (float) _r0.i;
    _r16.f = _r0.f;
    _r15.f = _r15.f - _r16.f;
    _r15.f = _r15.f / _r17.f;
    _r11.f = _r11.f * _r15.f;
    _r11.i = (int) _r11.f;
    _r15.i = _r14.i * _r4.i;
    _r15.i = _r15.i + _r13.i;
    _r16.i = _r12.i * _r10.i;
    _r11.i = _r11.i + _r16.i;
    _r11.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r11.i];
    ((global::org.xmlvm._nArrayAdapter<int>) _r20_o)[_r15.i] = _r11.i;
    _r11.i = _r13.i + 1;
    _r13.i = _r11.i;
    goto label106;
    label135:;
    _r17.f = _r19.f;
    _r5.f = _r18.f;
    _r17.f = _r17.f - _r5.f;
    _r5.f = _r17.f;
    goto label53;
    label144:;
    _r17.i = _r14.i + 1;
    _r14.i = _r17.i;
    goto label59;
    label149:;
    _r17.i = _r14.i;
    label151:;
    _r0_o = _r20_o;
    _r1.i = _r4.i;
    _r2.i = _r3.i;
    _r17_o = global::com.codename1.ui.Image.createImage((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r1.i, (int) _r2.i);
    return (global::com.codename1.ui.Image) _r17_o;
    label160:;
    _r17.i = 0;
    _r13.i = _r17.i;
    label164:;
    if (_r13.i >= _r3.i) goto label247;
    _r0.i = _r13.i;
    _r0.f = (float) _r0.i;
    _r17.f = _r0.f;
    _r0.i = _r3.i;
    _r0.f = (float) _r0.i;
    _r19.f = _r0.f;
    _r17.f = _r17.f / _r19.f;
    _r0.i = _r9.i;
    _r0.f = (float) _r0.i;
    _r19.f = _r0.f;
    _r19.f = _r19.f * _r17.f;
    _r0.f = _r19.f;
    _r0.i = (int) _r0.f;
    _r11.i = _r0.i;
    _r17.f = _r17.f * _r5.f;
    _r17.f = _r17.f + _r18.f;
    _r0.i = _r4.i;
    _r0.f = (float) _r0.i;
    _r19.f = _r0.f;
    _r7.f = (float)1.0D;
    _r17.f = _r7.f - _r17.f;
    _r17.f = _r17.f * _r19.f;
    _r0.f = _r17.f;
    _r0.i = (int) _r0.f;
    _r7.i = _r0.i;
    _r19.i = _r4.i - _r7.i;
    _r17.i = _r19.i - _r7.i;
    _r0.i = _r17.i;
    _r0.f = (float) _r0.i;
    _r17.f = _r0.f;
    _r8.i = _r7.i;
    _r12.i = _r8.i;
    label215:;
    _r0.i = _r12.i;
    _r1.i = _r19.i;
    if (_r0.i >= _r1.i) goto label242;
    _r8.f = (float) _r10.i;
    _r14.f = (float) _r12.i;
    _r15.f = (float) _r7.i;
    _r14.f = _r14.f - _r15.f;
    _r14.f = _r14.f / _r17.f;
    _r8.f = _r8.f * _r14.f;
    _r8.i = (int) _r8.f;
    _r14.i = _r13.i * _r4.i;
    _r14.i = _r14.i + _r12.i;
    _r15.i = _r11.i * _r10.i;
    _r8.i = _r8.i + _r15.i;
    _r8.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r8.i];
    ((global::org.xmlvm._nArrayAdapter<int>) _r20_o)[_r14.i] = _r8.i;
    _r8.i = _r12.i + 1;
    _r12.i = _r8.i;
    goto label215;
    label242:;
    _r17.i = _r13.i + 1;
    _r13.i = _r17.i;
    goto label164;
    label247:;
    _r17.i = _r13.i;
    goto label151;
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects: com.codename1.ui.Image verticalPerspective(com.codename1.ui.Image, float, float, float)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.Effects]
//XMLVM_END_WRAPPER[com.codename1.ui.util.Effects]

} // end of class: Effects

} // end of namespace: com.codename1.ui.util
