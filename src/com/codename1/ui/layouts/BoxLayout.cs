// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class BoxLayout: global::com.codename1.ui.layouts.Layout {
public static int _fX_1AXIS = 1;

public static int _fY_1AXIS = 2;

public static int _fX_1AXIS_1NO_1GROW = 3;

private int _faxis;

private global::com.codename1.ui.geom.Dimension _fdim;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: void <init>(int)]
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
    _r1.i = 0;
    ((global::com.codename1.ui.layouts.Layout) _r2_o).@this();
    _r0_o = new global::com.codename1.ui.geom.Dimension();
    ((global::com.codename1.ui.geom.Dimension) _r0_o).@this((int) _r1.i, (int) _r1.i);
    ((global::com.codename1.ui.layouts.BoxLayout) _r2_o)._fdim = (global::com.codename1.ui.geom.Dimension) _r0_o;
    ((global::com.codename1.ui.layouts.BoxLayout) _r2_o)._faxis = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: void <init>(int)]
}

public override void layoutContainer(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: void layoutContainer(com.codename1.ui.Container)]
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
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r21_o = this;
    _r22_o = n1;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).getLayoutWidth();
    _r18.i = ((global::com.codename1.ui.Container) _r22_o).getSideGap();
    _r17.i = _r17.i - _r18.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 3;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r17.i = _r17.i - _r18.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 1;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r14.i = _r17.i - _r18.i;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).getLayoutHeight();
    _r18.i = ((global::com.codename1.ui.Container) _r22_o).getBottomGap();
    _r17.i = _r17.i - _r18.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 2;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r17.i = _r17.i - _r18.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 0;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r8.i = _r17.i - _r18.i;
    _r17_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r18.i = ((global::com.codename1.ui.Container) _r22_o).isRTL() ? 1 : 0;
    _r19.i = 1;
    _r15.i = ((global::com.codename1.ui.plaf.Style) _r17_o).getPadding(0!=_r18.i, (int) _r19.i);
    _r17_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r18.i = 0;
    _r19.i = 0;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r17_o).getPadding(0!=_r18.i, (int) _r19.i);
    _r11.i = ((global::com.codename1.ui.Container) _r22_o).getComponentCount();
    _r12.i = ((global::com.codename1.ui.Container) _r22_o).isRTL() ? 1 : 0;
    if (_r12.i == 0) goto label118;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).getSideGap();
    _r15.i = _r15.i + _r17.i;
    label118:;
    _r10.i = _r15.i;
    _r9.i = 0;
    label120:;
    if (_r9.i >= _r11.i) goto label676;
    _r0_o = _r22_o;
    _r1.i = _r9.i;
    _r3_o = ((global::com.codename1.ui.Container) _r0_o).getComponentAt((int) _r1.i);
    _r13_o = ((global::com.codename1.ui.Component) _r3_o).getStyle();
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.layouts.BoxLayout) _r0_o)._faxis;
    _r17.i = _r0.i;
    switch (_r17.i) {
    case 2: goto label272;
    case 3: goto label444;
    }
    _r6.i = _r14.i;
    _r7.i = ((global::com.codename1.ui.Component) _r3_o).getPreferredW();
    _r17.i = 0;
    _r18.i = 1;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r15.i = _r15.i + _r17.i;
    if (_r15.i < _r6.i) goto label631;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).isScrollableX() ? 1 : 0;
    if (_r17.i != 0) goto label631;
    _r7.i = 0;
    label171:;
    ((global::com.codename1.ui.Component) _r3_o).setWidth((int) _r7.i);
    _r17.i = 0;
    _r18.i = 0;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r8.i - _r17.i;
    _r18.i = 0;
    _r19.i = 2;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i - _r18.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setHeight((int) _r1.i);
    if (_r12.i == 0) goto label671;
    _r17.i = _r14.i + _r10.i;
    _r18.i = _r15.i - _r10.i;
    _r17.i = _r17.i - _r18.i;
    _r17.i = _r17.i - _r7.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r1.i);
    label226:;
    _r17.i = 0;
    _r18.i = 0;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i + _r16.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r1.i);
    _r17.i = ((global::com.codename1.ui.Component) _r3_o).getWidth();
    _r18.i = 0;
    _r19.i = 3;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i + _r18.i;
    _r15.i = _r15.i + _r17.i;
    label268:;
    _r9.i = _r9.i + 1;
    goto label120;
    label272:;
    _r4.i = _r8.i;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).isRTL() ? 1 : 0;
    _r18.i = 1;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r14.i - _r17.i;
    _r18.i = ((global::com.codename1.ui.Container) _r22_o).isRTL() ? 1 : 0;
    _r19.i = 3;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i - _r18.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setWidth((int) _r1.i);
    _r5.i = ((global::com.codename1.ui.Component) _r3_o).getPreferredH();
    _r17.i = 0;
    _r18.i = 0;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r16.i = _r16.i + _r17.i;
    _r0.i = _r16.i;
    _r1.i = _r4.i;
    if (_r0.i < _r1.i) goto label399;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).isScrollableY() ? 1 : 0;
    if (_r17.i != 0) goto label399;
    _r5.i = 0;
    label344:;
    ((global::com.codename1.ui.Component) _r3_o).setHeight((int) _r5.i);
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).isRTL() ? 1 : 0;
    _r18.i = 1;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i + _r15.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r1.i);
    _r0_o = _r3_o;
    _r1.i = _r16.i;
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r1.i);
    _r17.i = ((global::com.codename1.ui.Component) _r3_o).getHeight();
    _r18.i = 0;
    _r19.i = 2;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i + _r18.i;
    _r16.i = _r16.i + _r17.i;
    goto label268;
    label399:;
    _r17.i = _r16.i + _r5.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 0;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r17.i = _r17.i - _r18.i;
    _r0.i = _r17.i;
    _r1.i = _r4.i;
    if (_r0.i <= _r1.i) goto label344;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).isScrollableY() ? 1 : 0;
    if (_r17.i != 0) goto label344;
    _r17.i = _r4.i - _r16.i;
    _r18.i = 0;
    _r19.i = 2;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r5.i = _r17.i - _r18.i;
    goto label344;
    label444:;
    _r6.i = _r14.i;
    _r17_o = ((global::com.codename1.ui.layouts.BoxLayout) _r21_o).getPreferredSize((global::com.codename1.ui.Container) _r22_o);
    _r17.i = ((global::com.codename1.ui.geom.Dimension) _r17_o).getHeight();
    _r0.i = _r17.i;
    _r1.i = _r8.i;
    _r8.i = global::java.lang.Math.min((int) _r0.i, (int) _r1.i);
    _r7.i = ((global::com.codename1.ui.Component) _r3_o).getPreferredW();
    _r17.i = 0;
    _r18.i = 1;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r15.i = _r15.i + _r17.i;
    if (_r15.i < _r6.i) goto label587;
    _r17.i = ((global::com.codename1.ui.Container) _r22_o).isScrollableX() ? 1 : 0;
    if (_r17.i != 0) goto label587;
    _r7.i = 0;
    label488:;
    ((global::com.codename1.ui.Component) _r3_o).setWidth((int) _r7.i);
    _r17.i = 0;
    _r18.i = 0;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r8.i - _r17.i;
    _r18.i = 0;
    _r19.i = 2;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i - _r18.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setHeight((int) _r1.i);
    if (_r12.i == 0) goto label627;
    _r17.i = _r14.i + _r10.i;
    _r18.i = _r15.i - _r10.i;
    _r17.i = _r17.i - _r18.i;
    _r17.i = _r17.i - _r7.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r1.i);
    label543:;
    _r17.i = 0;
    _r18.i = 0;
    _r0_o = _r13_o;
    _r1.i = _r17.i;
    _r2.i = _r18.i;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i + _r16.i;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r1.i);
    _r17.i = ((global::com.codename1.ui.Component) _r3_o).getWidth();
    _r18.i = 0;
    _r19.i = 3;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r17.i = _r17.i + _r18.i;
    _r15.i = _r15.i + _r17.i;
    goto label268;
    label587:;
    _r17.i = _r15.i + _r7.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 1;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r17.i = _r17.i - _r18.i;
    _r0.i = _r17.i;
    _r1.i = _r6.i;
    if (_r0.i <= _r1.i) goto label488;
    _r17.i = _r6.i - _r15.i;
    _r18.i = 0;
    _r19.i = 3;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r7.i = _r17.i - _r18.i;
    goto label488;
    label627:;
    ((global::com.codename1.ui.Component) _r3_o).setX((int) _r15.i);
    goto label543;
    label631:;
    _r17.i = _r15.i + _r7.i;
    _r18_o = ((global::com.codename1.ui.Container) _r22_o).getStyle();
    _r19.i = 0;
    _r20.i = 1;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r17.i = _r17.i - _r18.i;
    _r0.i = _r17.i;
    _r1.i = _r6.i;
    if (_r0.i <= _r1.i) goto label171;
    _r17.i = _r6.i - _r15.i;
    _r18.i = 0;
    _r19.i = 3;
    _r0_o = _r13_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r18.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r7.i = _r17.i - _r18.i;
    goto label171;
    label671:;
    ((global::com.codename1.ui.Component) _r3_o).setX((int) _r15.i);
    goto label226;
    label676:;
    return;
    label678:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: void layoutContainer(com.codename1.ui.Container)]
}

public override global::System.Object getPreferredSize(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r14_o = this;
    _r15_o = n1;
    _r13.i = 3;
    _r10.i = 1;
    _r12.i = 2;
    _r11.i = 0;
    _r7.i = 0;
    _r3.i = 0;
    _r5.i = ((global::com.codename1.ui.Container) _r15_o).getComponentCount();
    _r4.i = 0;
    label11:;
    if (_r4.i >= _r5.i) goto label97;
    _r0_o = ((global::com.codename1.ui.Container) _r15_o).getComponentAt((int) _r4.i);
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r8.i = ((global::com.codename1.ui.layouts.BoxLayout) _r14_o)._faxis;
    if (_r8.i != _r12.i) goto label62;
    _r8.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r11.i);
    _r8.i = _r8.i + _r9.i;
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r12.i);
    _r1.i = _r8.i + _r9.i;
    _r3.i = _r3.i + _r1.i;
    _r8.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r10.i);
    _r8.i = _r8.i + _r9.i;
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r13.i);
    _r8.i = _r8.i + _r9.i;
    _r7.i = global::java.lang.Math.max((int) _r7.i, (int) _r8.i);
    label59:;
    _r4.i = _r4.i + 1;
    goto label11;
    label62:;
    _r8.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r10.i);
    _r8.i = _r8.i + _r9.i;
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r13.i);
    _r2.i = _r8.i + _r9.i;
    _r7.i = _r7.i + _r2.i;
    _r8.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r11.i);
    _r8.i = _r8.i + _r9.i;
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r11.i, (int) _r12.i);
    _r8.i = _r8.i + _r9.i;
    _r3.i = global::java.lang.Math.max((int) _r3.i, (int) _r8.i);
    goto label59;
    label97:;
    _r8_o = ((global::com.codename1.ui.layouts.BoxLayout) _r14_o)._fdim;
    _r9_o = ((global::com.codename1.ui.Container) _r15_o).getStyle();
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r9_o).getPadding(0!=_r11.i, (int) _r10.i);
    _r9.i = _r9.i + _r7.i;
    _r10_o = ((global::com.codename1.ui.Container) _r15_o).getStyle();
    _r10.i = ((global::com.codename1.ui.plaf.Style) _r10_o).getPadding(0!=_r11.i, (int) _r13.i);
    _r9.i = _r9.i + _r10.i;
    ((global::com.codename1.ui.geom.Dimension) _r8_o).setWidth((int) _r9.i);
    _r8_o = ((global::com.codename1.ui.layouts.BoxLayout) _r14_o)._fdim;
    _r9_o = ((global::com.codename1.ui.Container) _r15_o).getStyle();
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r9_o).getPadding(0!=_r11.i, (int) _r11.i);
    _r9.i = _r9.i + _r3.i;
    _r10_o = ((global::com.codename1.ui.Container) _r15_o).getStyle();
    _r10.i = ((global::com.codename1.ui.plaf.Style) _r10_o).getPadding(0!=_r11.i, (int) _r12.i);
    _r9.i = _r9.i + _r10.i;
    ((global::com.codename1.ui.geom.Dimension) _r8_o).setHeight((int) _r9.i);
    _r8_o = ((global::com.codename1.ui.layouts.BoxLayout) _r14_o)._fdim;
    return (global::com.codename1.ui.geom.Dimension) _r8_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
}

public virtual int getAxis(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: int getAxis()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.BoxLayout) _r1_o)._faxis;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: int getAxis()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.BoxLayout) _r2_o)._faxis;
    _r1.i = 1;
    if (_r0.i != _r1.i) goto label8;
    // Value=BoxLayout X
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 88))}));
    label7:;
    return (global::java.lang.String) _r0_o;
    label8:;
    // Value=BoxLayout Y
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 89))}));
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: java.lang.String toString()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: boolean equals(java.lang.Object)]
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
    _r0.i = base.equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label16;
    _r0.i = ((global::com.codename1.ui.layouts.BoxLayout) _r2_o)._faxis;
    _r3_o = _r3_o;
    _r1.i = ((global::com.codename1.ui.layouts.BoxLayout) _r3_o)._faxis;
    if (_r0.i != _r1.i) goto label16;
    _r0.i = 1;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0.i = 0;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: boolean equals(java.lang.Object)]
}

public static global::System.Object encloseY(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: com.codename1.ui.Container encloseY(com.codename1.ui.Component[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0_o = new global::com.codename1.ui.layouts.BoxLayout();
    _r1.i = 2;
    ((global::com.codename1.ui.layouts.BoxLayout) _r0_o).@this((int) _r1.i);
    _r0_o = global::com.codename1.ui.Container.encloseIn((global::com.codename1.ui.layouts.Layout) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    return (global::com.codename1.ui.Container) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: com.codename1.ui.Container encloseY(com.codename1.ui.Component[])]
}

public static global::System.Object encloseX(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout: com.codename1.ui.Container encloseX(com.codename1.ui.Component[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0_o = new global::com.codename1.ui.layouts.BoxLayout();
    _r1.i = 1;
    ((global::com.codename1.ui.layouts.BoxLayout) _r0_o).@this((int) _r1.i);
    _r0_o = global::com.codename1.ui.Container.encloseIn((global::com.codename1.ui.layouts.Layout) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    return (global::com.codename1.ui.Container) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout: com.codename1.ui.Container encloseX(com.codename1.ui.Component[])]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.BoxLayout]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.BoxLayout]

} // end of class: BoxLayout

} // end of namespace: com.codename1.ui.layouts
