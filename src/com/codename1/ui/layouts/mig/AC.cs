// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts.mig {
public class AC: global::java.lang.Object {
private global::java.util.ArrayList _fcList;

private int _fcurIx;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    ((global::java.lang.Object) _r2_o).@this();
    _r0_o = new global::java.util.ArrayList();
    _r1.i = 8;
    ((global::java.util.ArrayList) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.AC) _r2_o)._fcList = (global::java.util.ArrayList) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.mig.AC) _r2_o)._fcurIx = _r0.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r2_o)._fcList;
    _r1_o = new global::com.codename1.ui.layouts.mig.DimConstraint();
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r1_o).@this();
    ((global::java.util.ArrayList) _r0_o).add((global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: void <init>()]
}

public virtual global::System.Object getConstaints(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.DimConstraint[] getConstaints()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r2_o)._fcList;
    _r1_o = ((global::com.codename1.ui.layouts.mig.AC) _r2_o)._fcList;
    _r1.i = ((global::java.util.ArrayList) _r1_o).size();
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r2_o = ((global::java.util.ArrayList) _r0_o).toArray((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.DimConstraint[] getConstaints()]
}

public virtual void setConstaints(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: void setConstaints(com.codename1.ui.layouts.mig.DimConstraint[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 1;
    if (_r7_o == null) goto label6;
    _r4.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r4.i >= _r5.i) goto label16;
    label6:;
    _r7_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r5.i]);
    _r4.i = 0;
    _r5_o = new global::com.codename1.ui.layouts.mig.DimConstraint();
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r5_o).@this();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r4.i] = _r5_o;
    label16:;
    _r4_o = ((global::com.codename1.ui.layouts.mig.AC) _r6_o)._fcList;
    ((global::java.util.ArrayList) _r4_o).clear();
    _r4_o = ((global::com.codename1.ui.layouts.mig.AC) _r6_o)._fcList;
    _r5.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    ((global::java.util.ArrayList) _r4_o).ensureCapacity((int) _r5.i);
    _r0_o = _r7_o;
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = 0;
    label30:;
    if (_r2.i >= _r3.i) goto label42;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i];
    _r4_o = ((global::com.codename1.ui.layouts.mig.AC) _r6_o)._fcList;
    ((global::java.util.ArrayList) _r4_o).add((global::java.lang.Object) _r1_o);
    _r2.i = _r2.i + 1;
    goto label30;
    label42:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: void setConstaints(com.codename1.ui.layouts.mig.DimConstraint[])]
}

public virtual int getCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: int getCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r1_o)._fcList;
    _r0.i = ((global::java.util.ArrayList) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: int getCount()]
}

public virtual global::System.Object count(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC count(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.layouts.mig.AC) _r0_o).makeSize((int) _r1.i);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC count(int)]
}

public virtual global::System.Object noGrid(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC noGrid()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).noGrid((global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC noGrid()]
}

public virtual global::System.Object noGrid(global::org.xmlvm._nArrayAdapter<int> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC noGrid(int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    _r2.i = ((global::org.xmlvm._nIArray) _r5_o).Length;
    _r0.i = _r2.i - _r3.i;
    label4:;
    if (_r0.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r0.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r4_o).makeSize((int) _r1.i);
    _r2_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcList;
    _r2_o = ((global::java.util.ArrayList) _r2_o).get((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o).setNoGrid(0!=_r3.i);
    _r0.i = _r0.i + -1;
    goto label4;
    label25:;
    return (global::com.codename1.ui.layouts.mig.AC) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC noGrid(int[])]
}

public virtual global::System.Object index(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC index(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.layouts.mig.AC) _r0_o).makeSize((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.AC) _r0_o)._fcurIx = _r1.i;
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC index(int)]
}

public virtual global::System.Object fill(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC fill()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).fill((global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC fill()]
}

public virtual global::System.Object fill(global::org.xmlvm._nArrayAdapter<int> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC fill(int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    _r2.i = ((global::org.xmlvm._nIArray) _r5_o).Length;
    _r0.i = _r2.i - _r3.i;
    label4:;
    if (_r0.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r0.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r4_o).makeSize((int) _r1.i);
    _r2_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcList;
    _r2_o = ((global::java.util.ArrayList) _r2_o).get((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o).setFill(0!=_r3.i);
    _r0.i = _r0.i + -1;
    goto label4;
    label25:;
    return (global::com.codename1.ui.layouts.mig.AC) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC fill(int[])]
}

public virtual global::System.Object sizeGroup(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC sizeGroup()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r1.i = 1;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r2.i = 0;
    _r3.i = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i] = _r3.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o).sizeGroup((global::java.lang.String) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC sizeGroup()]
}

public virtual global::System.Object sizeGroup(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC sizeGroup(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).sizeGroup((global::java.lang.String) _r4_o, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC sizeGroup(java.lang.String)]
}

public virtual global::System.Object sizeGroup(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC sizeGroup(java.lang.String, int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r3.i = 1;
    _r0.i = _r2.i - _r3.i;
    label4:;
    if (_r0.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r4_o).makeSize((int) _r1.i);
    _r2_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcList;
    _r2_o = ((global::java.util.ArrayList) _r2_o).get((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o).setSizeGroup((global::java.lang.String) _r5_o);
    _r0.i = _r0.i + -1;
    goto label4;
    label25:;
    return (global::com.codename1.ui.layouts.mig.AC) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC sizeGroup(java.lang.String, int[])]
}

public virtual global::System.Object size(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC size(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).size((global::java.lang.String) _r4_o, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC size(java.lang.String)]
}

public virtual global::System.Object size(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC size(java.lang.String, int[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r4.i = 1;
    _r3.i = 0;
    _r0_o = global::com.codename1.ui.layouts.mig.ConstraintParser.parseBoundSize((global::java.lang.String) _r6_o, 0!=_r3.i, 0!=_r4.i);
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r1.i = _r3.i - _r4.i;
    label9:;
    if (_r1.i < 0) goto label30;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r1.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r5_o).makeSize((int) _r2.i);
    _r3_o = ((global::com.codename1.ui.layouts.mig.AC) _r5_o)._fcList;
    _r3_o = ((global::java.util.ArrayList) _r3_o).get((int) _r2.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r3_o).setSize((global::com.codename1.ui.layouts.mig.BoundSize) _r0_o);
    _r1.i = _r1.i + -1;
    goto label9;
    label30:;
    return (global::com.codename1.ui.layouts.mig.AC) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC size(java.lang.String, int[])]
}

public virtual global::System.Object gap(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC gap()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.mig.AC) _r1_o)._fcurIx;
    _r0.i = _r0.i + 1;
    ((global::com.codename1.ui.layouts.mig.AC) _r1_o)._fcurIx = _r0.i;
    return (global::com.codename1.ui.layouts.mig.AC) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC gap()]
}

public virtual global::System.Object gap(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC gap(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcurIx;
    _r3.i = _r2.i + 1;
    ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcurIx = _r3.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o).gap((global::java.lang.String) _r5_o, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC gap(java.lang.String)]
}

public virtual global::System.Object gap(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC gap(java.lang.String, int[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r4.i = 1;
    if (_r6_o == null) goto label34;
    _r3_o = global::com.codename1.ui.layouts.mig.ConstraintParser.parseBoundSize((global::java.lang.String) _r6_o, 0!=_r4.i, 0!=_r4.i);
    _r0_o = _r3_o;
    label8:;
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r1.i = _r3.i - _r4.i;
    label11:;
    if (_r1.i < 0) goto label37;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r1.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r5_o).makeSize((int) _r2.i);
    if (_r0_o == null) goto label31;
    _r3_o = ((global::com.codename1.ui.layouts.mig.AC) _r5_o)._fcList;
    _r3_o = ((global::java.util.ArrayList) _r3_o).get((int) _r2.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r3_o).setGapAfter((global::com.codename1.ui.layouts.mig.BoundSize) _r0_o);
    label31:;
    _r1.i = _r1.i + -1;
    goto label11;
    label34:;
    _r3_o = null;
    _r0_o = _r3_o;
    goto label8;
    label37:;
    return (global::com.codename1.ui.layouts.mig.AC) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC gap(java.lang.String, int[])]
}

public virtual global::System.Object align(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC align(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).align((global::java.lang.String) _r4_o, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC align(java.lang.String)]
}

public virtual global::System.Object align(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC align(java.lang.String, int[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r4.i = 1;
    _r0_o = global::com.codename1.ui.layouts.mig.ConstraintParser.parseAlignKeywords((global::java.lang.String) _r6_o, 0!=_r4.i);
    if (_r0_o != null) goto label12;
    _r3.i = 0;
    _r0_o = global::com.codename1.ui.layouts.mig.ConstraintParser.parseAlignKeywords((global::java.lang.String) _r6_o, 0!=_r3.i);
    label12:;
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r1.i = _r3.i - _r4.i;
    label15:;
    if (_r1.i < 0) goto label36;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r1.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r5_o).makeSize((int) _r2.i);
    _r3_o = ((global::com.codename1.ui.layouts.mig.AC) _r5_o)._fcList;
    _r3_o = ((global::java.util.ArrayList) _r3_o).get((int) _r2.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r3_o).setAlign((global::com.codename1.ui.layouts.mig.UnitValue) _r0_o);
    _r1.i = _r1.i + -1;
    goto label15;
    label36:;
    return (global::com.codename1.ui.layouts.mig.AC) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC align(java.lang.String, int[])]
}

public virtual global::System.Object growPrio(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC growPrio(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).growPrio((int) _r4.i, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC growPrio(int)]
}

public virtual global::System.Object growPrio(int n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC growPrio(int, int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5.i = n1;
    _r6_o = n2;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r3.i = 1;
    _r0.i = _r2.i - _r3.i;
    label4:;
    if (_r0.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r4_o).makeSize((int) _r1.i);
    _r2_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcList;
    _r2_o = ((global::java.util.ArrayList) _r2_o).get((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o).setGrowPriority((int) _r5.i);
    _r0.i = _r0.i + -1;
    goto label4;
    label25:;
    return (global::com.codename1.ui.layouts.mig.AC) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC growPrio(int, int[])]
}

public virtual global::System.Object grow(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC grow()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.f = (float)1.0D;
    _r1.i = 1;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r2.i = 0;
    _r3.i = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i] = _r3.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o).grow((float) _r0.f, (global::org.xmlvm._nArrayAdapter<int>) _r1_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC grow()]
}

public virtual global::System.Object grow(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC grow(float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.f = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).grow((float) _r4.f, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC grow(float)]
}

public virtual global::System.Object grow(float n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC grow(float, int[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6.f = n1;
    _r7_o = n2;
    _r0_o = new global::java.lang.Float();
    ((global::java.lang.Float) _r0_o).@this((float) _r6.f);
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r4.i = 1;
    _r1.i = _r3.i - _r4.i;
    label9:;
    if (_r1.i < 0) goto label30;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r1.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r5_o).makeSize((int) _r2.i);
    _r3_o = ((global::com.codename1.ui.layouts.mig.AC) _r5_o)._fcList;
    _r3_o = ((global::java.util.ArrayList) _r3_o).get((int) _r2.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r3_o).setGrow((global::java.lang.Float) _r0_o);
    _r1.i = _r1.i + -1;
    goto label9;
    label30:;
    return (global::com.codename1.ui.layouts.mig.AC) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC grow(float, int[])]
}

public virtual global::System.Object shrinkPrio(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkPrio(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).shrinkPrio((int) _r4.i, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkPrio(int)]
}

public virtual global::System.Object shrinkPrio(int n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkPrio(int, int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5.i = n1;
    _r6_o = n2;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r3.i = 1;
    _r0.i = _r2.i - _r3.i;
    label4:;
    if (_r0.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r4_o).makeSize((int) _r1.i);
    _r2_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcList;
    _r2_o = ((global::java.util.ArrayList) _r2_o).get((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o).setShrinkPriority((int) _r5.i);
    _r0.i = _r0.i + -1;
    goto label4;
    label25:;
    return (global::com.codename1.ui.layouts.mig.AC) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkPrio(int, int[])]
}

public virtual global::System.Object shrink(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrink()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.f = (float)100.0D;
    _r1.i = 1;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r2.i = 0;
    _r3.i = ((global::com.codename1.ui.layouts.mig.AC) _r4_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i] = _r3.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r4_o).shrink((float) _r0.f, (global::org.xmlvm._nArrayAdapter<int>) _r1_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrink()]
}

public virtual global::System.Object shrink(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrink(float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.f = n1;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r1.i = 0;
    _r2.i = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcurIx;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o).shrink((float) _r4.f, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrink(float)]
}

public virtual global::System.Object shrink(float n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrink(float, int[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6.f = n1;
    _r7_o = n2;
    _r2_o = new global::java.lang.Float();
    ((global::java.lang.Float) _r2_o).@this((float) _r6.f);
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r4.i = 1;
    _r0.i = _r3.i - _r4.i;
    label9:;
    if (_r0.i < 0) goto label30;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r0.i];
    ((global::com.codename1.ui.layouts.mig.AC) _r5_o).makeSize((int) _r1.i);
    _r3_o = ((global::com.codename1.ui.layouts.mig.AC) _r5_o)._fcList;
    _r3_o = ((global::java.util.ArrayList) _r3_o).get((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r3_o).setShrink((global::java.lang.Float) _r2_o);
    _r0.i = _r0.i + -1;
    goto label9;
    label30:;
    return (global::com.codename1.ui.layouts.mig.AC) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrink(float, int[])]
}

public virtual global::System.Object shrinkWeight(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkWeight(float)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.f = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r1_o).shrink((float) _r2.f);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkWeight(float)]
}

public virtual global::System.Object shrinkWeight(float n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkWeight(float, int[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2.f = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.ui.layouts.mig.AC) _r1_o).shrink((float) _r2.f, (global::org.xmlvm._nArrayAdapter<int>) _r3_o);
    return (global::com.codename1.ui.layouts.mig.AC) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: com.codename1.ui.layouts.mig.AC shrinkWeight(float, int[])]
}

private void makeSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC: void makeSize(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r1_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcList;
    _r1.i = ((global::java.util.ArrayList) _r1_o).size();
    if (_r1.i > _r4.i) goto label34;
    _r1_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcList;
    ((global::java.util.ArrayList) _r1_o).ensureCapacity((int) _r4.i);
    _r1_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcList;
    _r0.i = ((global::java.util.ArrayList) _r1_o).size();
    label19:;
    if (_r0.i > _r4.i) goto label34;
    _r1_o = ((global::com.codename1.ui.layouts.mig.AC) _r3_o)._fcList;
    _r2_o = new global::com.codename1.ui.layouts.mig.DimConstraint();
    ((global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o).@this();
    ((global::java.util.ArrayList) _r1_o).add((global::java.lang.Object) _r2_o);
    _r0.i = _r0.i + 1;
    goto label19;
    label34:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC: void makeSize(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.AC]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.AC]

} // end of class: AC

} // end of namespace: com.codename1.ui.layouts.mig
