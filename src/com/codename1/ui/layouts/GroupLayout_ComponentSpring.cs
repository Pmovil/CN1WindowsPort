// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GroupLayout_2ComponentSpring: global::com.codename1.ui.layouts.GroupLayout_2Spring {
private global::com.codename1.ui.Component _fcomponent;

private int _forigin;

private int _fmin;

private int _fpref;

private int _fmax;

private int _fbaseline;

private bool _finstalled;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

private void @this(global::com.codename1.ui.layouts.GroupLayout n1, global::com.codename1.ui.Component n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component, int, int, int)]
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
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5.i = n3;
    _r6.i = n4;
    _r7.i = n5;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r3_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r3_o);
    _r0.i = -1;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fbaseline = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fcomponent = (global::com.codename1.ui.Component) _r4_o;
    if (_r4_o != null) goto label20;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Component must be non-null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label20:;
    _r0.i = 1;
    global::com.codename1.ui.layouts.GroupLayout.access_2700((int) _r5.i, (int) _r6.i, (int) _r7.i, 0!=_r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmin = _r5.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmax = _r7.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fpref = _r6.i;
    global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r3_o, (global::com.codename1.ui.Component) _r4_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component, int, int, int)]
}

public override int calculateMinimumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateMinimumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).isLinked((int) _r2.i) ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0.i = 0;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).getLinkSize((int) _r2.i, (int) _r0.i);
    label11:;
    return _r0.i;
    label12:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).calculateNonlinkedMinimumSize((int) _r2.i);
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateMinimumSize(int)]
}

public override int calculatePreferredSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculatePreferredSize(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).isLinked((int) _r5.i) ? 1 : 0;
    if (_r3.i == 0) goto label12;
    _r3.i = 1;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getLinkSize((int) _r5.i, (int) _r3.i);
    label11:;
    return _r3.i;
    label12:;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getMinimumSize((int) _r5.i);
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).calculateNonlinkedPreferredSize((int) _r5.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r4_o).getMaximumSize((int) _r5.i);
    _r3.i = global::java.lang.Math.max((int) _r1.i, (int) _r2.i);
    _r3.i = global::java.lang.Math.min((int) _r0.i, (int) _r3.i);
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculatePreferredSize(int)]
}

public override int calculateMaximumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateMaximumSize(int)]
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
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).isLinked((int) _r3.i) ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0.i = 2;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).getLinkSize((int) _r3.i, (int) _r0.i);
    label11:;
    return _r0.i;
    label12:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).getMinimumSize((int) _r3.i);
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).calculateNonlinkedMaximumSize((int) _r3.i);
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateMaximumSize(int)]
}

public virtual bool isVisible(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: boolean isVisible()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).getComponent();
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o).isVisible() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: boolean isVisible()]
}

public virtual int calculateNonlinkedMinimumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateNonlinkedMinimumSize(int)]
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
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).isVisible() ? 1 : 0;
    if (_r0.i != 0) goto label8;
    _r0.i = 0;
    label7:;
    return _r0.i;
    label8:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmin;
    if (_r0.i < 0) goto label15;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmin;
    goto label7;
    label15:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmin;
    _r1.i = -2;
    if (_r0.i != _r1.i) goto label25;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).calculateNonlinkedPreferredSize((int) _r3.i);
    goto label7;
    label25:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fcomponent;
    _r0_o = ((global::com.codename1.ui.Component) _r0_o).getPreferredSize();
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).getSizeAlongAxis((int) _r3.i, (global::com.codename1.ui.geom.Dimension) _r0_o);
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateNonlinkedMinimumSize(int)]
}

public virtual int calculateNonlinkedPreferredSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateNonlinkedPreferredSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).isVisible() ? 1 : 0;
    if (_r0.i != 0) goto label8;
    _r0.i = 0;
    label7:;
    return _r0.i;
    label8:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._fpref;
    if (_r0.i < 0) goto label15;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._fpref;
    goto label7;
    label15:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._fcomponent;
    _r0_o = ((global::com.codename1.ui.Component) _r0_o).getPreferredSize();
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).getSizeAlongAxis((int) _r2.i, (global::com.codename1.ui.geom.Dimension) _r0_o);
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateNonlinkedPreferredSize(int)]
}

public virtual int calculateNonlinkedMaximumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateNonlinkedMaximumSize(int)]
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
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).isVisible() ? 1 : 0;
    if (_r0.i != 0) goto label8;
    _r0.i = 0;
    label7:;
    return _r0.i;
    label8:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmax;
    if (_r0.i < 0) goto label15;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmax;
    goto label7;
    label15:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fmax;
    _r1.i = -2;
    if (_r0.i != _r1.i) goto label25;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).calculateNonlinkedPreferredSize((int) _r3.i);
    goto label7;
    label25:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fcomponent;
    _r0_o = ((global::com.codename1.ui.Component) _r0_o).getPreferredSize();
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o).getSizeAlongAxis((int) _r3.i, (global::com.codename1.ui.geom.Dimension) _r0_o);
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int calculateNonlinkedMaximumSize(int)]
}

private int getSizeAlongAxis(int n1, global::com.codename1.ui.geom.Dimension n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getSizeAlongAxis(int, com.codename1.ui.geom.Dimension)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0.i = 1;
    if (_r2.i != _r0.i) goto label8;
    _r0.i = ((global::com.codename1.ui.geom.Dimension) _r3_o).getWidth();
    label7:;
    return _r0.i;
    label8:;
    _r0.i = ((global::com.codename1.ui.geom.Dimension) _r3_o).getHeight();
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getSizeAlongAxis(int, com.codename1.ui.geom.Dimension)]
}

private int getLinkSize(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getLinkSize(int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4.i = n1;
    _r5.i = n2;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r3_o).isVisible() ? 1 : 0;
    if (_r1.i != 0) goto label8;
    _r1.i = 0;
    label7:;
    return _r1.i;
    label8:;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r3_o)._fthis_20;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r3_o)._fcomponent;
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r1_o, (global::com.codename1.ui.Component) _r2_o);
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o).getLinkSize((int) _r4.i, (int) _r5.i);
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getLinkSize(int, int)]
}

public override void setSize(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void setSize(int, int, int)]
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
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    base.setSize((int) _r2.i, (int) _r3.i, (int) _r4.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._forigin = _r3.i;
    _r0.i = -2147483648;
    if (_r4.i != _r0.i) goto label12;
    _r0.i = -1;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._fbaseline = _r0.i;
    label12:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void setSize(int, int, int)]
}

public virtual int getOrigin(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getOrigin()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._forigin;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getOrigin()]
}

public virtual void setComponent(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void setComponent(com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r0_o)._fcomponent = (global::com.codename1.ui.Component) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void setComponent(com.codename1.ui.Component)]
}

public virtual global::System.Object getComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: com.codename1.ui.Component getComponent()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o)._fcomponent;
    return (global::com.codename1.ui.Component) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: com.codename1.ui.Component getComponent()]
}

public override int getBaseline(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getBaseline()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o)._fbaseline;
    _r4.i = -1;
    if (_r3.i != _r4.i) goto label37;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o)._fcomponent;
    _r3_o = global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r3_o, (global::com.codename1.ui.Component) _r4_o);
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r3_o)._fhorizontalSpring;
    _r3.i = 1;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).getPreferredSize((int) _r3.i);
    _r3.i = 2;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o).getPreferredSize((int) _r3.i);
    if (_r2.i <= 0) goto label37;
    if (_r0.i <= 0) goto label37;
    _r3_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o)._fcomponent;
    _r3.i = ((global::com.codename1.ui.Component) _r3_o).getBaseline((int) _r2.i, (int) _r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o)._fbaseline = _r3.i;
    label37:;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r5_o)._fbaseline;
    return _r3.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getBaseline()]
}

public override int getBaselineResizeBehavior(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getBaselineResizeBehavior()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).getComponent();
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getBaselineResizeBehavior();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: int getBaselineResizeBehavior()]
}

private bool isLinked(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: boolean isLinked(int)]
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
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fcomponent;
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o).isLinked((int) _r3.i) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: boolean isLinked(int)]
}

public virtual void installIfNecessary(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void installIfNecessary(int)]
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
    _r1.i = 1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._finstalled ? 1 : 0;
    if (_r0.i != 0) goto label19;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._finstalled = 0!=_r1.i;
    if (_r3.i != _r1.i) goto label20;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fcomponent;
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o)._fhorizontalSpring = (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o;
    label19:;
    return;
    label20:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o)._fcomponent;
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_2800((global::com.codename1.ui.layouts.GroupLayout) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentInfo) _r0_o)._fverticalSpring = (global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r2_o;
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void installIfNecessary(int)]
}

public override bool willHaveZeroSize(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: boolean willHaveZeroSize(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r1_o).isVisible() ? 1 : 0;
    if (_r0.i != 0) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: boolean willHaveZeroSize(boolean)]
}

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, global::com.codename1.ui.Component n2, int n3, int n4, int n5, global::com.codename1.ui.layouts.GroupLayout_21 n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component, int, int, int, com.codename1.ui.layouts.GroupLayout$1)]
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
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    _r4.i = n4;
    _r5.i = n5;
    _r6_o = n6;
    ((global::com.codename1.ui.layouts.GroupLayout_2ComponentSpring) _r0_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r1_o, (global::com.codename1.ui.Component) _r2_o, (int) _r3.i, (int) _r4.i, (int) _r5.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component, int, int, int, com.codename1.ui.layouts.GroupLayout$1)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$ComponentSpring]

} // end of class: GroupLayout_2ComponentSpring

} // end of namespace: com.codename1.ui.layouts
