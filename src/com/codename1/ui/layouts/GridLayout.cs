// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GridLayout: global::com.codename1.ui.layouts.Layout {
private bool _ffillLastRow;

private int _frows;

private int _fcolumns;

private bool _fautoFit;

public void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: void <init>(int, int)]
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
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r0.i = 1;
    ((global::com.codename1.ui.layouts.Layout) _r2_o).@this();
    ((global::com.codename1.ui.layouts.GridLayout) _r2_o)._frows = _r3.i;
    ((global::com.codename1.ui.layouts.GridLayout) _r2_o)._fcolumns = _r4.i;
    if (_r3.i < _r0.i) goto label12;
    if (_r4.i >= _r0.i) goto label20;
    label12:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Rows and columns must be greater than zero
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)82)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label20:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: void <init>(int, int)]
}

private void autoSizeCols(global::com.codename1.ui.Container n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: void autoSizeCols(com.codename1.ui.Container, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9_o = n1;
    _r10.i = n2;
    _r7.i = 1;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r8_o).isAutoFit() ? 1 : 0;
    if (_r5.i == 0) goto label85;
    _r3.i = ((global::com.codename1.ui.Container) _r9_o).getComponentCount();
    _r2.i = 0;
    _r1.i = 0;
    label13:;
    if (_r1.i >= _r3.i) goto label45;
    _r0_o = ((global::com.codename1.ui.Container) _r9_o).getComponentAt((int) _r1.i);
    _r4_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r5.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getMargin((int) _r7.i);
    _r5.i = _r5.i + _r6.i;
    _r6.i = 3;
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getMargin((int) _r6.i);
    _r5.i = _r5.i + _r6.i;
    _r2.i = global::java.lang.Math.max((int) _r5.i, (int) _r2.i);
    _r1.i = _r1.i + 1;
    goto label13;
    label45:;
    if (_r10.i >= _r2.i) goto label55;
    _r5_o = global::com.codename1.ui.Display.getInstance();
    _r10.i = ((global::com.codename1.ui.Display) _r5_o).getDisplayWidth();
    label55:;
    if (_r2.i > 0) goto label86;
    ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._fcolumns = _r7.i;
    label59:;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._fcolumns;
    _r5.i = _r3.i / _r5.i;
    _r5.i = global::java.lang.Math.max((int) _r7.i, (int) _r5.i);
    ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._frows = _r5.i;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._fcolumns;
    _r5.i = _r3.i % _r5.i;
    if (_r5.i <= 0) goto label85;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._fcolumns;
    if (_r3.i <= _r5.i) goto label85;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._frows;
    _r5.i = _r5.i + 1;
    ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._frows = _r5.i;
    label85:;
    return;
    label86:;
    _r5.i = _r10.i / _r2.i;
    _r5.i = global::java.lang.Math.max((int) _r5.i, (int) _r7.i);
    ((global::com.codename1.ui.layouts.GridLayout) _r8_o)._fcolumns = _r5.i;
    goto label59;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: void autoSizeCols(com.codename1.ui.Container, int)]
}

public override void layoutContainer(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: void layoutContainer(com.codename1.ui.Container)]
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
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r22_o = this;
    _r23_o = n1;
    _r18.i = ((global::com.codename1.ui.Container) _r23_o).getLayoutWidth();
    _r19.i = ((global::com.codename1.ui.Container) _r23_o).getSideGap();
    _r18.i = _r18.i - _r19.i;
    _r19_o = ((global::com.codename1.ui.Container) _r23_o).getStyle();
    _r20.i = 0;
    _r21.i = 3;
    _r19.i = ((global::com.codename1.ui.plaf.Style) _r19_o).getPadding(0!=_r20.i, (int) _r21.i);
    _r18.i = _r18.i - _r19.i;
    _r19_o = ((global::com.codename1.ui.Container) _r23_o).getStyle();
    _r20.i = 0;
    _r21.i = 1;
    _r19.i = ((global::com.codename1.ui.plaf.Style) _r19_o).getPadding(0!=_r20.i, (int) _r21.i);
    _r15.i = _r18.i - _r19.i;
    _r18.i = ((global::com.codename1.ui.Container) _r23_o).getLayoutHeight();
    _r19.i = ((global::com.codename1.ui.Container) _r23_o).getBottomGap();
    _r18.i = _r18.i - _r19.i;
    _r19_o = ((global::com.codename1.ui.Container) _r23_o).getStyle();
    _r20.i = 0;
    _r21.i = 2;
    _r19.i = ((global::com.codename1.ui.plaf.Style) _r19_o).getPadding(0!=_r20.i, (int) _r21.i);
    _r18.i = _r18.i - _r19.i;
    _r19_o = ((global::com.codename1.ui.Container) _r23_o).getStyle();
    _r20.i = 0;
    _r21.i = 0;
    _r19.i = ((global::com.codename1.ui.plaf.Style) _r19_o).getPadding(0!=_r20.i, (int) _r21.i);
    _r7.i = _r18.i - _r19.i;
    _r12.i = ((global::com.codename1.ui.Container) _r23_o).getComponentCount();
    _r0_o = _r22_o;
    _r1_o = _r23_o;
    _r2.i = _r15.i;
    ((global::com.codename1.ui.layouts.GridLayout) _r0_o).autoSizeCols((global::com.codename1.ui.Container) _r1_o, (int) _r2.i);
    _r18_o = ((global::com.codename1.ui.Container) _r23_o).getStyle();
    _r19.i = ((global::com.codename1.ui.Container) _r23_o).isRTL() ? 1 : 0;
    _r20.i = 1;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r18_o = ((global::com.codename1.ui.Container) _r23_o).getStyle();
    _r19.i = 0;
    _r20.i = 0;
    _r17.i = ((global::com.codename1.ui.plaf.Style) _r18_o).getPadding(0!=_r19.i, (int) _r20.i);
    _r14.i = ((global::com.codename1.ui.Container) _r23_o).isRTL() ? 1 : 0;
    if (_r14.i == 0) goto label126;
    _r18.i = ((global::com.codename1.ui.Container) _r23_o).getSideGap();
    _r16.i = _r16.i + _r18.i;
    label126:;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r9.i = _r0.i;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r18.i = _r0.i;
    _r6.i = _r15.i / _r18.i;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._frows;
    _r18.i = _r0.i;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r19.i = _r0.i;
    _r18.i = _r18.i * _r19.i;
    _r0.i = _r12.i;
    _r1.i = _r18.i;
    if (_r0.i <= _r1.i) goto label369;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r18.i = _r0.i;
    _r18.i = _r12.i / _r18.i;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r19.i = _r0.i;
    _r19.i = _r12.i % _r19.i;
    if (_r19.i != 0) goto label365;
    _r19.i = 0;
    label178:;
    _r18.i = _r18.i + _r19.i;
    _r4.i = _r7.i / _r18.i;
    label182:;
    _r13.i = 0;
    _r8.i = 0;
    label184:;
    if (_r8.i >= _r12.i) goto label394;
    _r0_o = _r23_o;
    _r1.i = _r8.i;
    _r3_o = ((global::com.codename1.ui.Container) _r0_o).getComponentAt((int) _r1.i);
    _r5_o = ((global::com.codename1.ui.Component) _r3_o).getStyle();
    _r18.i = ((global::com.codename1.ui.Container) _r23_o).isRTL() ? 1 : 0;
    _r19.i = 1;
    _r0_o = _r5_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r10.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r18.i = 0;
    _r19.i = 0;
    _r0_o = _r5_o;
    _r1.i = _r18.i;
    _r2.i = _r19.i;
    _r11.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r18.i = _r6.i - _r10.i;
    _r19.i = ((global::com.codename1.ui.Container) _r23_o).isRTL() ? 1 : 0;
    _r20.i = 3;
    _r0_o = _r5_o;
    _r1.i = _r19.i;
    _r2.i = _r20.i;
    _r19.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r18.i = _r18.i - _r19.i;
    _r0_o = _r3_o;
    _r1.i = _r18.i;
    ((global::com.codename1.ui.Component) _r0_o).setWidth((int) _r1.i);
    _r18.i = _r4.i - _r11.i;
    _r19.i = 0;
    _r20.i = 2;
    _r0_o = _r5_o;
    _r1.i = _r19.i;
    _r2.i = _r20.i;
    _r19.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r18.i = _r18.i - _r19.i;
    _r0_o = _r3_o;
    _r1.i = _r18.i;
    ((global::com.codename1.ui.Component) _r0_o).setHeight((int) _r1.i);
    if (_r14.i == 0) goto label379;
    _r18.i = 1;
    _r18.i = _r9.i - _r18.i;
    _r19.i = _r8.i % _r9.i;
    _r18.i = _r18.i - _r19.i;
    _r18.i = _r18.i * _r6.i;
    _r18.i = _r18.i + _r16.i;
    _r18.i = _r18.i + _r10.i;
    _r0_o = _r3_o;
    _r1.i = _r18.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r1.i);
    label295:;
    _r18.i = _r13.i * _r4.i;
    _r18.i = _r18.i + _r17.i;
    _r18.i = _r18.i + _r11.i;
    _r0_o = _r3_o;
    _r1.i = _r18.i;
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r1.i);
    _r18.i = _r8.i + 1;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r19.i = _r0.i;
    _r18.i = _r18.i % _r19.i;
    if (_r18.i != 0) goto label361;
    _r13.i = _r13.i + 1;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._ffillLastRow ? 1 : 0;
    _r18.i = _r0.i;
    if (_r18.i == 0) goto label361;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._frows;
    _r18.i = _r0.i;
    _r19.i = 1;
    _r18.i = _r18.i - _r19.i;
    _r0.i = _r13.i;
    _r1.i = _r18.i;
    if (_r0.i != _r1.i) goto label361;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r18.i = _r0.i;
    _r9.i = _r12.i % _r18.i;
    if (_r9.i != 0) goto label359;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fcolumns;
    _r9.i = _r0.i;
    label359:;
    _r6.i = _r15.i / _r9.i;
    label361:;
    _r8.i = _r8.i + 1;
    goto label184;
    label365:;
    _r19.i = 1;
    goto label178;
    label369:;
    _r0_o = _r22_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._frows;
    _r18.i = _r0.i;
    _r4.i = _r7.i / _r18.i;
    goto label182;
    label379:;
    _r18.i = _r8.i % _r9.i;
    _r18.i = _r18.i * _r6.i;
    _r18.i = _r18.i + _r16.i;
    _r18.i = _r18.i + _r10.i;
    _r0_o = _r3_o;
    _r1.i = _r18.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r1.i);
    goto label295;
    label394:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: void layoutContainer(com.codename1.ui.Container)]
}

public override global::System.Object getPreferredSize(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
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
    _r11_o = this;
    _r12_o = n1;
    _r8.i = 3;
    _r10.i = 2;
    _r7.i = 1;
    _r9.i = 0;
    _r4.i = 0;
    _r1.i = 0;
    _r3.i = ((global::com.codename1.ui.Container) _r12_o).getComponentCount();
    _r2.i = 0;
    label11:;
    if (_r2.i >= _r3.i) goto label72;
    _r0_o = ((global::com.codename1.ui.Container) _r12_o).getComponentAt((int) _r2.i);
    _r5.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r9.i, (int) _r7.i);
    _r5.i = _r5.i + _r6.i;
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r9.i, (int) _r8.i);
    _r5.i = _r5.i + _r6.i;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r5.i);
    _r5.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r9.i, (int) _r9.i);
    _r5.i = _r5.i + _r6.i;
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin(0!=_r9.i, (int) _r10.i);
    _r5.i = _r5.i + _r6.i;
    _r1.i = global::java.lang.Math.max((int) _r1.i, (int) _r5.i);
    _r2.i = _r2.i + 1;
    goto label11;
    label72:;
    _r5.i = ((global::com.codename1.ui.Container) _r12_o).getWidth();
    ((global::com.codename1.ui.layouts.GridLayout) _r11_o).autoSizeCols((global::com.codename1.ui.Container) _r12_o, (int) _r5.i);
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._fcolumns;
    if (_r5.i <= _r7.i) goto label86;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._fcolumns;
    _r4.i = _r4.i * _r5.i;
    label86:;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._frows;
    if (_r5.i <= _r7.i) goto label110;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._frows;
    _r6.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._fcolumns;
    _r5.i = _r5.i * _r6.i;
    if (_r3.i <= _r5.i) goto label154;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._fcolumns;
    _r5.i = _r3.i / _r5.i;
    _r6.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._fcolumns;
    _r6.i = _r3.i % _r6.i;
    if (_r6.i != 0) goto label152;
    _r6.i = _r9.i;
    label108:;
    _r5.i = _r5.i + _r6.i;
    _r1.i = _r1.i * _r5.i;
    label110:;
    _r5_o = new global::com.codename1.ui.geom.Dimension();
    _r6_o = ((global::com.codename1.ui.Container) _r12_o).getStyle();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getPadding(0!=_r9.i, (int) _r7.i);
    _r6.i = _r6.i + _r4.i;
    _r7_o = ((global::com.codename1.ui.Container) _r12_o).getStyle();
    _r7.i = ((global::com.codename1.ui.plaf.Style) _r7_o).getPadding(0!=_r9.i, (int) _r8.i);
    _r6.i = _r6.i + _r7.i;
    _r7_o = ((global::com.codename1.ui.Container) _r12_o).getStyle();
    _r7.i = ((global::com.codename1.ui.plaf.Style) _r7_o).getPadding(0!=_r9.i, (int) _r9.i);
    _r7.i = _r7.i + _r1.i;
    _r8_o = ((global::com.codename1.ui.Container) _r12_o).getStyle();
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r8_o).getPadding(0!=_r9.i, (int) _r10.i);
    _r7.i = _r7.i + _r8.i;
    ((global::com.codename1.ui.geom.Dimension) _r5_o).@this((int) _r6.i, (int) _r7.i);
    return (global::com.codename1.ui.geom.Dimension) _r5_o;
    label152:;
    _r6.i = _r7.i;
    goto label108;
    label154:;
    _r5.i = ((global::com.codename1.ui.layouts.GridLayout) _r11_o)._frows;
    _r1.i = _r1.i * _r5.i;
    goto label110;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=GridLayout
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)71)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: java.lang.String toString()]
}

public virtual int getRows(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: int getRows()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r1_o)._frows;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: int getRows()]
}

public virtual int getColumns(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: int getColumns()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r1_o)._fcolumns;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: int getColumns()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean equals(java.lang.Object)]
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
    _r3_o = this;
    _r4_o = n1;
    _r1.i = base.equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r1.i == 0) goto label44;
    _r0_o = _r4_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1.i = ((global::com.codename1.ui.layouts.GridLayout) _r1_o).getRows();
    _r2.i = ((global::com.codename1.ui.layouts.GridLayout) _r3_o).getRows();
    if (_r1.i != _r2.i) goto label44;
    _r0_o = _r4_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1.i = ((global::com.codename1.ui.layouts.GridLayout) _r1_o).getColumns();
    _r2.i = ((global::com.codename1.ui.layouts.GridLayout) _r3_o).getColumns();
    if (_r1.i != _r2.i) goto label44;
    _r4_o = _r4_o;
    _r1.i = ((global::com.codename1.ui.layouts.GridLayout) _r4_o)._fautoFit ? 1 : 0;
    _r2.i = ((global::com.codename1.ui.layouts.GridLayout) _r3_o)._fautoFit ? 1 : 0;
    if (_r1.i != _r2.i) goto label44;
    _r1.i = 1;
    label43:;
    return _r1.i!=0;
    label44:;
    _r1.i = 0;
    goto label43;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean equals(java.lang.Object)]
}

public virtual bool isFillLastRow(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean isFillLastRow()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r1_o)._ffillLastRow ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean isFillLastRow()]
}

public virtual void setFillLastRow(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: void setFillLastRow(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._ffillLastRow = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: void setFillLastRow(boolean)]
}

public virtual bool isAutoFit(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean isAutoFit()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r1_o)._fautoFit ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean isAutoFit()]
}

public virtual void setAutoFit(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: void setAutoFit(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.layouts.GridLayout) _r0_o)._fautoFit = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: void setAutoFit(boolean)]
}

public override bool obscuresPotential(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean obscuresPotential(com.codename1.ui.Container)]
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
    _r3_o = this;
    _r4_o = n1;
    _r0.i = ((global::com.codename1.ui.Container) _r4_o).getComponentCount();
    _r1.i = ((global::com.codename1.ui.layouts.GridLayout) _r3_o)._frows;
    _r2.i = ((global::com.codename1.ui.layouts.GridLayout) _r3_o)._fcolumns;
    _r1.i = _r1.i * _r2.i;
    if (_r0.i == _r1.i) goto label15;
    _r0.i = ((global::com.codename1.ui.layouts.GridLayout) _r3_o)._fautoFit ? 1 : 0;
    if (_r0.i == 0) goto label17;
    label15:;
    _r0.i = 1;
    label16:;
    return _r0.i!=0;
    label17:;
    _r0.i = 0;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout: boolean obscuresPotential(com.codename1.ui.Container)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridLayout]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridLayout]

} // end of class: GridLayout

} // end of namespace: com.codename1.ui.layouts
