// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GroupLayout_2AutopaddingSpring: global::com.codename1.ui.layouts.GroupLayout_2Spring {
public global::java.util.ArrayList _fsources;

public global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring _fsource;

private global::java.util.ArrayList _fmatches;

public int _fsize;

public int _flastSize;

private int _fpref;

private int _fmax;

private int _ftype;

private bool _fuserCreated;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

private void @this(global::com.codename1.ui.layouts.GroupLayout n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = -2;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r2_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r2_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fpref = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fmax = _r0.i;
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._ftype = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout)]
}

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3.i = n3;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r0_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r1_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r1_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r0_o)._fpref = _r2.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r0_o)._fmax = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, int, int)]
}

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r2_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r2_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._ftype = _r3.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fpref = _r4.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fmax = _r5.i;
    _r0.i = 1;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fuserCreated = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, int, int, int)]
}

public virtual void setSource(global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void setSource(com.codename1.ui.layouts.GroupLayout$ComponentSpring)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r0_o)._fsource = (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void setSource(com.codename1.ui.layouts.GroupLayout$ComponentSpring)]
}

public virtual void setSources(global::java.util.ArrayList n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void setSources(java.util.ArrayList)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_2400((global::java.util.ArrayList) _r2_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fsources = (global::java.util.ArrayList) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void setSources(java.util.ArrayList)]
}

public virtual void setUserCreated(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void setUserCreated(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r0_o)._fuserCreated = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void setUserCreated(boolean)]
}

public virtual bool getUserCreated(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: boolean getUserCreated()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fuserCreated ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: boolean getUserCreated()]
}

public override void unset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void unset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o).getSize();
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._flastSize = _r0.i;
    base.unset();
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fsize = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void unset()]
}

public virtual void reset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void reset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = null;
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fsize = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fsources = (global::java.util.ArrayList) _r1_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fsource = (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fmatches = (global::java.util.ArrayList) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void reset()]
}

public virtual void calculatePadding(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void calculatePadding(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    _r8_o = this;
    _r9.i = n1;
    _r6.i = 1;
    _r7.i = -2147483648;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize = _r7.i;
    _r2.i = -2147483648;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fmatches;
    if (_r5_o == null) goto label65;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fthis_20;
    _r3_o = global::com.codename1.ui.layouts.GroupLayout.access_21000((global::com.codename1.ui.layouts.GroupLayout) _r5_o);
    if (_r9.i != _r6.i) goto label63;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fthis_20;
    _r5.i = global::com.codename1.ui.layouts.GroupLayout.access_21100((global::com.codename1.ui.layouts.GroupLayout) _r5_o) ? 1 : 0;
    if (_r5.i == 0) goto label61;
    _r4.i = 3;
    label28:;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fmatches;
    _r5.i = ((global::java.util.ArrayList) _r5_o).size();
    _r0.i = _r5.i - _r6.i;
    label36:;
    if (_r0.i < 0) goto label65;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fmatches;
    _r1_o = ((global::java.util.ArrayList) _r5_o).get((int) _r0.i);
    _r1_o = _r1_o;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingMatch) _r1_o)._fsource;
    _r6_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingMatch) _r1_o)._ftarget;
    _r5.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o).calculatePadding((global::com.codename1.ui.layouts.LayoutStyle) _r3_o, (int) _r4.i, (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o, (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r6_o);
    _r2.i = global::java.lang.Math.max((int) _r2.i, (int) _r5.i);
    _r0.i = _r0.i + -1;
    goto label36;
    label61:;
    _r4.i = 7;
    goto label28;
    label63:;
    _r4.i = 5;
    goto label28;
    label65:;
    _r5.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize;
    if (_r5.i != _r7.i) goto label72;
    _r5.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize = _r5.i;
    label72:;
    if (_r2.i != _r7.i) goto label75;
    _r2.i = 0;
    label75:;
    _r5.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._flastSize;
    if (_r5.i == _r7.i) goto label90;
    _r5.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize;
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._flastSize;
    _r6.i = global::java.lang.Math.min((int) _r2.i, (int) _r6.i);
    _r5.i = _r5.i + _r6.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize = _r5.i;
    label90:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void calculatePadding(int)]
}

private int calculatePadding(global::com.codename1.ui.layouts.LayoutStyle n1, int n2, global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring n3, global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculatePadding(com.codename1.ui.layouts.LayoutStyle, int, com.codename1.ui.layouts.GroupLayout$ComponentSpring, com.codename1.ui.layouts.GroupLayout$ComponentSpring)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    _r8_o = this;
    _r9_o = n1;
    _r10.i = n2;
    _r11_o = n3;
    _r12_o = n4;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r12_o).getOrigin();
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r11_o).getOrigin();
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r11_o).getSize();
    _r1.i = _r1.i + _r2.i;
    _r6.i = _r0.i - _r1.i;
    if (_r6.i < 0) goto label53;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r11_o).getComponent();
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r12_o).getComponent();
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._ftype;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fthis_20;
    _r5_o = global::com.codename1.ui.layouts.GroupLayout.access_2900((global::com.codename1.ui.layouts.GroupLayout) _r0_o);
    _r0_o = _r9_o;
    _r4.i = _r10.i;
    _r7.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r0_o).getPreferredGap((global::com.codename1.ui.Component) _r1_o, (global::com.codename1.ui.Component) _r2_o, (int) _r3.i, (int) _r4.i, (global::com.codename1.ui.Container) _r5_o);
    if (_r7.i <= _r6.i) goto label51;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize;
    _r1.i = _r7.i - _r6.i;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r8_o)._fsize = _r0.i;
    label51:;
    _r0.i = _r7.i;
    label52:;
    return _r0.i;
    label53:;
    _r0.i = 0;
    goto label52;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculatePadding(com.codename1.ui.layouts.LayoutStyle, int, com.codename1.ui.layouts.GroupLayout$ComponentSpring, com.codename1.ui.layouts.GroupLayout$ComponentSpring)]
}

public virtual void addTarget(global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void addTarget(com.codename1.ui.layouts.GroupLayout$ComponentSpring, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    _r7_o = this;
    _r8_o = n1;
    _r9.i = n2;
    _r5.i = 1;
    if (_r9.i != _r5.i) goto label33;
    _r4.i = 2;
    _r2.i = _r4.i;
    label5:;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fsource;
    if (_r4_o == null) goto label35;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fthis_20;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fsource;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o).getComponent();
    _r6_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r8_o).getComponent();
    _r4.i = global::com.codename1.ui.layouts.GroupLayout.access_21200((global::com.codename1.ui.layouts.GroupLayout) _r4_o, (global::com.codename1.ui.Component) _r5_o, (global::com.codename1.ui.Component) _r6_o, (int) _r2.i) ? 1 : 0;
    if (_r4.i == 0) goto label32;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fsource;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o).addValidTarget((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o, (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r8_o);
    label32:;
    return;
    label33:;
    _r2.i = _r5.i;
    goto label5;
    label35:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r8_o).getComponent();
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fsources;
    _r4.i = ((global::java.util.ArrayList) _r4_o).size();
    _r1.i = _r4.i - _r5.i;
    label47:;
    if (_r1.i < 0) goto label32;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fsources;
    _r3_o = ((global::java.util.ArrayList) _r4_o).get((int) _r1.i);
    _r3_o = _r3_o;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o)._fthis_20;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r3_o).getComponent();
    _r4.i = global::com.codename1.ui.layouts.GroupLayout.access_21200((global::com.codename1.ui.layouts.GroupLayout) _r4_o, (global::com.codename1.ui.Component) _r5_o, (global::com.codename1.ui.Component) _r0_o, (int) _r2.i) ? 1 : 0;
    if (_r4.i == 0) goto label72;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r7_o).addValidTarget((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r3_o, (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r8_o);
    label72:;
    _r1.i = _r1.i + -1;
    goto label47;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void addTarget(com.codename1.ui.layouts.GroupLayout$ComponentSpring, int)]
}

private void addValidTarget(global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring n1, global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void addValidTarget(com.codename1.ui.layouts.GroupLayout$ComponentSpring, com.codename1.ui.layouts.GroupLayout$ComponentSpring)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fmatches;
    if (_r0_o != null) goto label12;
    _r0_o = new global::java.util.ArrayList();
    _r1.i = 1;
    ((global::java.util.ArrayList) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fmatches = (global::java.util.ArrayList) _r0_o;
    label12:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fmatches;
    _r1_o = new global::com.codename1.ui.layouts.GroupLayout_2AutopaddingMatch();
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingMatch) _r1_o).@this((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r3_o, (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o);
    ((global::java.util.ArrayList) _r0_o).add((global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void addValidTarget(com.codename1.ui.layouts.GroupLayout$ComponentSpring, com.codename1.ui.layouts.GroupLayout$ComponentSpring)]
}

public override int calculateMinimumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculateMinimumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fsize;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculateMinimumSize(int)]
}

public override int calculatePreferredSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculatePreferredSize(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fpref;
    _r1.i = -2;
    if (_r0.i == _r1.i) goto label10;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fpref;
    _r1.i = -1;
    if (_r0.i != _r1.i) goto label13;
    label10:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fsize;
    label12:;
    return _r0.i;
    label13:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fsize;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fpref;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculatePreferredSize(int)]
}

public override int calculateMaximumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculateMaximumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fmax;
    if (_r0.i < 0) goto label15;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o).getPreferredSize((int) _r3.i);
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fmax;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    label14:;
    return _r0.i;
    label15:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o)._fsize;
    goto label14;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: int calculateMaximumSize(int)]
}

public virtual global::System.Object getMatchDescription(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: java.lang.String getMatchDescription()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fmatches;
    if (_r0_o != null) goto label7;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label6:;
    return (global::java.lang.String) _r0_o;
    label7:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o)._fmatches;
    _r0_o = ((global::java.util.ArrayList) _r0_o).toString();
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: java.lang.String getMatchDescription()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = base.toString();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o).getMatchDescription();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: java.lang.String toString()]
}

public override bool willHaveZeroSize(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: boolean willHaveZeroSize(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    return _r1.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: boolean willHaveZeroSize(boolean)]
}

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, global::com.codename1.ui.layouts.GroupLayout_21 n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.layouts.GroupLayout$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r0_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.layouts.GroupLayout$1)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$AutopaddingSpring]

} // end of class: GroupLayout_2AutopaddingSpring

} // end of namespace: com.codename1.ui.layouts
