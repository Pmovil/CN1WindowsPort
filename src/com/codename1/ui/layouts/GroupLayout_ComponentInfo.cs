// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GroupLayout_2ComponentInfo: global::java.lang.Object {
private global::com.codename1.ui.Component _fcomponent;

public global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring _fhorizontalSpring;

public global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring _fverticalSpring;

private global::com.codename1.ui.layouts.GroupLayout_2LinkInfo _fhorizontalMaster;

private global::com.codename1.ui.layouts.GroupLayout_2LinkInfo _fverticalMaster;

private bool _fvisible;

private global::java.lang.Boolean _fhonorsVisibility;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, global::com.codename1.ui.Component n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o)._fcomponent = (global::com.codename1.ui.Component) _r2_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o).updateVisibility();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component)]
}

public virtual void dispose(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void dispose()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = null;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fhorizontalSpring;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o).removeSpring((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fhorizontalSpring = (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fverticalSpring;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o).removeSpring((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fverticalSpring = (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fhorizontalMaster;
    if (_r0_o == null) goto label24;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fhorizontalMaster;
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).remove((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o);
    label24:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fverticalMaster;
    if (_r0_o == null) goto label33;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fverticalMaster;
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).remove((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o);
    label33:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void dispose()]
}

public virtual void setHonorsVisibility(global::java.lang.Boolean n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setHonorsVisibility(java.lang.Boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o)._fhonorsVisibility = (global::java.lang.Boolean) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setHonorsVisibility(java.lang.Boolean)]
}

private void removeSpring(global::com.codename1.ui.layouts.GroupLayout_2Spring n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void removeSpring(com.codename1.ui.layouts.GroupLayout$Spring)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    if (_r2_o == null) goto label13;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).getParent();
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o)._fsprings;
    ((global::java.util.ArrayList) _r0_o).remove((global::java.lang.Object) _r2_o);
    label13:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void removeSpring(com.codename1.ui.layouts.GroupLayout$Spring)]
}

public virtual bool isVisible(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: boolean isVisible()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fvisible ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: boolean isVisible()]
}

public virtual bool updateVisibility(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: boolean updateVisibility()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 1;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r4_o)._fhonorsVisibility;
    if (_r2_o != null) goto label28;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r4_o)._fthis_20;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout) _r2_o).getHonorsVisibility() ? 1 : 0;
    label11:;
    if (_r0.i == 0) goto label35;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r4_o)._fcomponent;
    _r2.i = ((global::com.codename1.ui.Component) _r2_o).isVisible() ? 1 : 0;
    _r1.i = _r2.i;
    label20:;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r4_o)._fvisible ? 1 : 0;
    if (_r2.i == _r1.i) goto label37;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r4_o)._fvisible = 0!=_r1.i;
    _r2.i = _r3.i;
    label27:;
    return _r2.i!=0;
    label28:;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r4_o)._fhonorsVisibility;
    _r0.i = ((global::java.lang.Boolean) _r2_o).booleanValue() ? 1 : 0;
    goto label11;
    label35:;
    _r1.i = _r3.i;
    goto label20;
    label37:;
    _r2.i = 0;
    goto label27;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: boolean updateVisibility()]
}

public virtual void setBounds(int n1, int n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setBounds(int, int, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    _r6_o = this;
    _r7.i = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r10.i = n4 ? 1 : 0;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fhorizontalSpring;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getOrigin();
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fhorizontalSpring;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getSize();
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fverticalSpring;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getOrigin();
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fverticalSpring;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getSize();
    if (_r10.i != 0) goto label30;
    _r4.i = _r9.i - _r2.i;
    _r2.i = _r4.i - _r1.i;
    label30:;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fcomponent;
    _r5.i = _r2.i + _r7.i;
    ((global::com.codename1.ui.Component) _r4_o).setX((int) _r5.i);
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fcomponent;
    _r5.i = _r3.i + _r8.i;
    ((global::com.codename1.ui.Component) _r4_o).setY((int) _r5.i);
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fcomponent;
    ((global::com.codename1.ui.Component) _r4_o).setWidth((int) _r1.i);
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r6_o)._fcomponent;
    ((global::com.codename1.ui.Component) _r4_o).setHeight((int) _r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setBounds(int, int, int, boolean)]
}

public virtual void setComponent(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setComponent(com.codename1.ui.Component)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fcomponent = (global::com.codename1.ui.Component) _r2_o;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fhorizontalSpring;
    if (_r0_o == null) goto label11;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fhorizontalSpring;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r0_o).setComponent((global::com.codename1.ui.Component) _r2_o);
    label11:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fverticalSpring;
    if (_r0_o == null) goto label20;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fverticalSpring;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r0_o).setComponent((global::com.codename1.ui.Component) _r2_o);
    label20:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setComponent(com.codename1.ui.Component)]
}

public virtual global::System.Object getComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.Component getComponent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fcomponent;
    return (global::com.codename1.ui.Component) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.Component getComponent()]
}

public virtual bool isLinked(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: boolean isLinked(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2.i = 0;
    _r1.i = 1;
    if (_r4.i != _r1.i) goto label12;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r3_o)._fhorizontalMaster;
    if (_r0_o == null) goto label10;
    _r0.i = _r1.i;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = _r2.i;
    goto label9;
    label12:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r3_o)._fverticalMaster;
    if (_r0_o == null) goto label18;
    _r0.i = _r1.i;
    goto label9;
    label18:;
    _r0.i = _r2.i;
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: boolean isLinked(int)]
}

private void setLinkInfo(int n1, global::com.codename1.ui.layouts.GroupLayout_2LinkInfo n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setLinkInfo(int, com.codename1.ui.layouts.GroupLayout$LinkInfo)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0.i = 1;
    if (_r2.i != _r0.i) goto label6;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fhorizontalMaster = (global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r3_o;
    label5:;
    return;
    label6:;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fverticalMaster = (global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r3_o;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void setLinkInfo(int, com.codename1.ui.layouts.GroupLayout$LinkInfo)]
}

public virtual global::System.Object getLinkInfo(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.layouts.GroupLayout$LinkInfo getLinkInfo(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o).getLinkInfo((int) _r2.i, 0!=_r0.i);
    return (global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.layouts.GroupLayout$LinkInfo getLinkInfo(int)]
}

private global::System.Object getLinkInfo(int n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.layouts.GroupLayout$LinkInfo getLinkInfo(int, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2 ? 1 : 0;
    _r1.i = 1;
    if (_r3.i != _r1.i) goto label20;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fhorizontalMaster;
    if (_r0_o != null) goto label17;
    if (_r4.i == 0) goto label17;
    _r0_o = new global::com.codename1.ui.layouts.GroupLayout_2LinkInfo();
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).add((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o);
    label17:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fhorizontalMaster;
    label19:;
    return (global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o;
    label20:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fverticalMaster;
    if (_r0_o != null) goto label35;
    if (_r4.i == 0) goto label35;
    _r0_o = new global::com.codename1.ui.layouts.GroupLayout_2LinkInfo();
    _r1.i = 2;
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).add((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o);
    label35:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r2_o)._fverticalMaster;
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.layouts.GroupLayout$LinkInfo getLinkInfo(int, boolean)]
}

public virtual void clearCachedSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void clearCachedSize()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fhorizontalMaster;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fhorizontalMaster;
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).clearCachedSize();
    label9:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fverticalMaster;
    if (_r0_o == null) goto label18;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fverticalMaster;
    ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).clearCachedSize();
    label18:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void clearCachedSize()]
}

public virtual int getLinkSize(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: int getLinkSize(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0.i = 1;
    if (_r2.i != _r0.i) goto label10;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fhorizontalMaster;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).getSize((int) _r2.i);
    label9:;
    return _r0.i;
    label10:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fverticalMaster;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o).getSize((int) _r2.i);
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: int getLinkSize(int, int)]
}

public static global::System.Object access_2000(global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.Component access$000(com.codename1.ui.layouts.GroupLayout$ComponentInfo)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o)._fcomponent;
    return (global::com.codename1.ui.Component) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.Component access$000(com.codename1.ui.layouts.GroupLayout$ComponentInfo)]
}

public static global::System.Object access_21300(global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.layouts.GroupLayout$LinkInfo access$1300(com.codename1.ui.layouts.GroupLayout$ComponentInfo, int, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = n1;
    _r2.i = n2;
    _r3.i = n3 ? 1 : 0;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r1_o).getLinkInfo((int) _r2.i, 0!=_r3.i);
    return (global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: com.codename1.ui.layouts.GroupLayout$LinkInfo access$1300(com.codename1.ui.layouts.GroupLayout$ComponentInfo, int, boolean)]
}

public static void access_21400(global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo n1, int n2, global::com.codename1.ui.layouts.GroupLayout_2LinkInfo n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void access$1400(com.codename1.ui.layouts.GroupLayout$ComponentInfo, int, com.codename1.ui.layouts.GroupLayout$LinkInfo)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r0_o = n1;
    _r1.i = n2;
    _r2_o = n3;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o).setLinkInfo((int) _r1.i, (global::com.codename1.ui.layouts.GroupLayout_2LinkInfo) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo: void access$1400(com.codename1.ui.layouts.GroupLayout$ComponentInfo, int, com.codename1.ui.layouts.GroupLayout$LinkInfo)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentInfo]

} // end of class: GroupLayout_2ComponentInfo

} // end of namespace: com.codename1.ui.layouts
