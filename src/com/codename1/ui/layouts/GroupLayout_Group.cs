// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public abstract class GroupLayout_2Group: global::com.codename1.ui.layouts.GroupLayout_2Spring {
public global::java.util.ArrayList _fsprings;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

public void @this(global::com.codename1.ui.layouts.GroupLayout n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void <init>(com.codename1.ui.layouts.GroupLayout)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r2_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r2_o);
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o)._fsprings = (global::java.util.ArrayList) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void <init>(com.codename1.ui.layouts.GroupLayout)]
}

public virtual int indexOf(global::com.codename1.ui.layouts.GroupLayout_2Spring n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int indexOf(com.codename1.ui.layouts.GroupLayout$Spring)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o)._fsprings;
    _r0.i = ((global::java.util.ArrayList) _r0_o).indexOf((global::java.lang.Object) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int indexOf(com.codename1.ui.layouts.GroupLayout$Spring)]
}

public virtual global::System.Object addSpring(global::com.codename1.ui.layouts.GroupLayout_2Spring n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: com.codename1.ui.layouts.GroupLayout$Group addSpring(com.codename1.ui.layouts.GroupLayout$Spring)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r2_o)._fsprings;
    ((global::java.util.ArrayList) _r0_o).add((global::java.lang.Object) _r3_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o).setParent((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o);
    _r0.i = ((_r3_o != null) && (_r3_o is global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring)) ? 1 : 0;
    if (_r0.i == 0) goto label20;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r3_o).getUserCreated() ? 1 : 0;
    if (_r0.i != 0) goto label26;
    label20:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r2_o)._fthis_20;
    _r1.i = 1;
    global::com.codename1.ui.layouts.GroupLayout.access_2102((global::com.codename1.ui.layouts.GroupLayout) _r0_o, 0!=_r1.i);
    label26:;
    return (global::com.codename1.ui.layouts.GroupLayout_2Group) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: com.codename1.ui.layouts.GroupLayout$Group addSpring(com.codename1.ui.layouts.GroupLayout$Spring)]
}

public override void setSize(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void setSize(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4.i = n1;
    _r5.i = n2;
    _r6.i = n3;
    base.setSize((int) _r4.i, (int) _r5.i, (int) _r6.i);
    _r1.i = -2147483648;
    if (_r6.i != _r1.i) goto label28;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r3_o)._fsprings;
    _r1.i = ((global::java.util.ArrayList) _r1_o).size();
    _r2.i = 1;
    _r0.i = _r1.i - _r2.i;
    label16:;
    if (_r0.i < 0) goto label31;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r3_o).getSpring((int) _r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).setSize((int) _r4.i, (int) _r5.i, (int) _r6.i);
    _r0.i = _r0.i + -1;
    goto label16;
    label28:;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r3_o).setValidSize((int) _r4.i, (int) _r5.i, (int) _r6.i);
    label31:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void setSize(int, int, int)]
}

public abstract void setValidSize(int n1, int n2, int n3);

public override int calculateMinimumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculateMinimumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 0;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o).calculateSize((int) _r2.i, (int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculateMinimumSize(int)]
}

public override int calculatePreferredSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculatePreferredSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o).calculateSize((int) _r2.i, (int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculatePreferredSize(int)]
}

public override int calculateMaximumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculateMaximumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 2;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o).calculateSize((int) _r2.i, (int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculateMaximumSize(int)]
}

public abstract int @operator(int n1, int n2);

public virtual int calculateSize(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculateSize(int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r6_o = this;
    _r7.i = n1;
    _r8.i = n2;
    _r5.i = 1;
    _r4.i = 0;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o)._fsprings;
    _r0.i = ((global::java.util.ArrayList) _r3_o).size();
    if (_r0.i != 0) goto label12;
    _r3.i = _r4.i;
    label11:;
    return _r3.i;
    label12:;
    if (_r0.i != _r5.i) goto label23;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpring((int) _r4.i);
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpringSize((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o, (int) _r7.i, (int) _r8.i);
    goto label11;
    label23:;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpring((int) _r4.i);
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpringSize((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o, (int) _r7.i, (int) _r8.i);
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpring((int) _r5.i);
    _r4.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpringSize((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r4_o, (int) _r7.i, (int) _r8.i);
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).@operator((int) _r3.i, (int) _r4.i);
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).constrain((int) _r3.i);
    _r1.i = 2;
    label48:;
    if (_r1.i >= _r0.i) goto label69;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpring((int) _r1.i);
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).getSpringSize((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o, (int) _r7.i, (int) _r8.i);
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).@operator((int) _r2.i, (int) _r3.i);
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r6_o).constrain((int) _r3.i);
    _r1.i = _r1.i + 1;
    goto label48;
    label69:;
    _r3.i = _r2.i;
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int calculateSize(int, int)]
}

public virtual global::System.Object getSpring(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: com.codename1.ui.layouts.GroupLayout$Spring getSpring(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o)._fsprings;
    _r1_o = ((global::java.util.ArrayList) _r0_o).get((int) _r2.i);
    return (global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: com.codename1.ui.layouts.GroupLayout$Spring getSpring(int)]
}

public virtual int getSpringSize(global::com.codename1.ui.layouts.GroupLayout_2Spring n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int getSpringSize(com.codename1.ui.layouts.GroupLayout$Spring, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    switch (_r4.i) {
    case 0: goto label5;
    case 1: goto label10;
    case 2: goto label15;
    }
    _r0.i = 0;
    label4:;
    return _r0.i;
    label5:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).getMinimumSize((int) _r3.i);
    goto label4;
    label10:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).getPreferredSize((int) _r3.i);
    goto label4;
    label15:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).getMaximumSize((int) _r3.i);
    goto label4;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: int getSpringSize(com.codename1.ui.layouts.GroupLayout$Spring, int, int)]
}

public abstract void insertAutopadding(int n1, global::java.util.ArrayList n2, global::java.util.ArrayList n3, global::java.util.ArrayList n4, global::java.util.ArrayList n5, bool n6);

public virtual void removeAutopadding(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void removeAutopadding()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r5_o).unset();
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r5_o)._fsprings;
    _r3.i = ((global::java.util.ArrayList) _r3_o).size();
    _r4.i = 1;
    _r1.i = _r3.i - _r4.i;
    label12:;
    if (_r1.i < 0) goto label60;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r5_o)._fsprings;
    _r2_o = ((global::java.util.ArrayList) _r3_o).get((int) _r1.i);
    _r3.i = ((_r2_o != null) && (_r2_o is global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring)) ? 1 : 0;
    if (_r3.i == 0) goto label50;
    _r0_o = _r2_o;
    _r3_o = _r0_o;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r3_o).getUserCreated() ? 1 : 0;
    if (_r3.i == 0) goto label44;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r2_o).reset();
    label41:;
    _r1.i = _r1.i + -1;
    goto label12;
    label44:;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r5_o)._fsprings;
    ((global::java.util.ArrayList) _r3_o).remove((int) _r1.i);
    goto label41;
    label50:;
    _r3.i = ((_r2_o != null) && (_r2_o is global::com.codename1.ui.layouts.GroupLayout_2Group)) ? 1 : 0;
    if (_r3.i == 0) goto label41;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r2_o).removeAutopadding();
    goto label41;
    label60:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void removeAutopadding()]
}

public virtual void unsetAutopadding(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void unsetAutopadding()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o).unset();
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o)._fsprings;
    _r2.i = ((global::java.util.ArrayList) _r2_o).size();
    _r3.i = 1;
    _r0.i = _r2.i - _r3.i;
    label12:;
    if (_r0.i < 0) goto label44;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o)._fsprings;
    _r1_o = ((global::java.util.ArrayList) _r2_o).get((int) _r0.i);
    _r2.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring)) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o).unset();
    label31:;
    _r0.i = _r0.i + -1;
    goto label12;
    label34:;
    _r2.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.layouts.GroupLayout_2Group)) ? 1 : 0;
    if (_r2.i == 0) goto label31;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o).unsetAutopadding();
    goto label31;
    label44:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void unsetAutopadding()]
}

public virtual void calculateAutopadding(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void calculateAutopadding(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o)._fsprings;
    _r2.i = ((global::java.util.ArrayList) _r2_o).size();
    _r3.i = 1;
    _r0.i = _r2.i - _r3.i;
    label9:;
    if (_r0.i < 0) goto label44;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o)._fsprings;
    _r1_o = ((global::java.util.ArrayList) _r2_o).get((int) _r0.i);
    _r2.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring)) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).unset();
    ((global::com.codename1.ui.layouts.GroupLayout_2AutopaddingSpring) _r1_o).calculatePadding((int) _r5.i);
    label31:;
    _r0.i = _r0.i + -1;
    goto label9;
    label34:;
    _r2.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.layouts.GroupLayout_2Group)) ? 1 : 0;
    if (_r2.i == 0) goto label31;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r1_o).calculateAutopadding((int) _r5.i);
    goto label31;
    label44:;
    ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o).unset();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: void calculateAutopadding(int)]
}

public override bool willHaveZeroSize(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: boolean willHaveZeroSize(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1 ? 1 : 0;
    _r3.i = 1;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o)._fsprings;
    _r2.i = ((global::java.util.ArrayList) _r2_o).size();
    _r0.i = _r2.i - _r3.i;
    label9:;
    if (_r0.i < 0) goto label30;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2Group) _r4_o)._fsprings;
    _r1_o = ((global::java.util.ArrayList) _r2_o).get((int) _r0.i);
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).willHaveZeroSize(0!=_r5.i) ? 1 : 0;
    if (_r2.i != 0) goto label27;
    _r2.i = 0;
    label26:;
    return _r2.i!=0;
    label27:;
    _r0.i = _r0.i + -1;
    goto label9;
    label30:;
    _r2.i = _r3.i;
    goto label26;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group: boolean willHaveZeroSize(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Group]

} // end of class: GroupLayout_2Group

} // end of namespace: com.codename1.ui.layouts
