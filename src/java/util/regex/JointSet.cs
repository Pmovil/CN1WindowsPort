// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class JointSet: global::java.util.regex.AbstractSet {
public global::java.util.ArrayList _fchildren;

public global::java.util.regex.AbstractSet _ffSet;

public int _fgroupIndex;

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.regex.AbstractSet) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: void <init>()]
}

public void @this(global::java.util.ArrayList n1, global::java.util.regex.FSet n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: void <init>(java.util.ArrayList, java.util.regex.FSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::java.util.regex.AbstractSet) _r1_o).@this();
    ((global::java.util.regex.JointSet) _r1_o)._fchildren = (global::java.util.ArrayList) _r2_o;
    ((global::java.util.regex.JointSet) _r1_o)._ffSet = (global::java.util.regex.AbstractSet) _r3_o;
    _r0.i = ((global::java.util.regex.FSet) _r3_o).getGroupIndex();
    ((global::java.util.regex.JointSet) _r1_o)._fgroupIndex = _r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: void <init>(java.util.ArrayList, java.util.regex.FSet)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r5_o = this;
    _r6.i = n1;
    _r7_o = n2;
    _r8_o = n3;
    _r4.i = -1;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    if (_r0_o != null) goto label7;
    _r0.i = _r4.i;
    label6:;
    return _r0.i;
    label7:;
    _r0.i = ((global::java.util.regex.JointSet) _r5_o)._fgroupIndex;
    _r1.i = ((global::java.util.regex.MatchResultImpl) _r8_o).getStart((int) _r0.i);
    _r0.i = ((global::java.util.regex.JointSet) _r5_o)._fgroupIndex;
    ((global::java.util.regex.MatchResultImpl) _r8_o).setStart((int) _r0.i, (int) _r6.i);
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    _r2.i = ((global::java.util.ArrayList) _r0_o).size();
    _r0.i = 0;
    _r3.i = _r0.i;
    label26:;
    if (_r3.i < _r2.i) goto label35;
    _r0.i = ((global::java.util.regex.JointSet) _r5_o)._fgroupIndex;
    ((global::java.util.regex.MatchResultImpl) _r8_o).setStart((int) _r0.i, (int) _r1.i);
    _r0.i = _r4.i;
    goto label6;
    label35:;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    _r0_o = ((global::java.util.ArrayList) _r0_o).get((int) _r3.i);
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r6.i, (global::java.lang.CharSequence) _r7_o, (global::java.util.regex.MatchResultImpl) _r8_o);
    if (_r0.i >= 0) goto label6;
    _r0.i = _r3.i + 1;
    _r3.i = _r0.i;
    goto label26;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: void setNext(java.util.regex.AbstractSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.regex.JointSet) _r1_o)._ffSet;
    ((global::java.util.regex.AbstractSet) _r0_o).setNext((global::java.util.regex.AbstractSet) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: void setNext(java.util.regex.AbstractSet)]
}

public override global::System.Object getNext(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: java.util.regex.AbstractSet getNext()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.regex.JointSet) _r1_o)._ffSet;
    _r0_o = ((global::java.util.regex.AbstractSet) _r0_o).getNext();
    return (global::java.util.regex.AbstractSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: java.util.regex.AbstractSet getNext()]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=JointSet
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)74)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: java.lang.String getName()]
}

public virtual int getGroup(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: int getGroup()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.regex.JointSet) _r1_o)._fgroupIndex;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: int getGroup()]
}

public override bool first(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: boolean first(java.util.regex.AbstractSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.util.regex.JointSet) _r2_o)._fchildren;
    if (_r0_o == null) goto label16;
    _r0_o = ((global::java.util.regex.JointSet) _r2_o)._fchildren;
    _r0_o = ((global::java.util.ArrayList) _r0_o).iterator();
    label10:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label18;
    label16:;
    _r0.i = 0;
    label17:;
    return _r0.i!=0;
    label18:;
    _r2_o = ((global::java.util.Iterator) _r0_o).next();
    _r1.i = ((global::java.util.regex.AbstractSet) _r2_o).first((global::java.util.regex.AbstractSet) _r3_o) ? 1 : 0;
    if (_r1.i == 0) goto label10;
    _r0.i = 1;
    goto label17;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: boolean first(java.util.regex.AbstractSet)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.util.regex.JointSet) _r2_o)._fgroupIndex;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r3_o).getEnd((int) _r0.i);
    if (_r0.i < 0) goto label24;
    _r0.i = ((global::java.util.regex.JointSet) _r2_o)._fgroupIndex;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r3_o).getStart((int) _r0.i);
    _r1.i = ((global::java.util.regex.JointSet) _r2_o)._fgroupIndex;
    _r1.i = ((global::java.util.regex.MatchResultImpl) _r3_o).getEnd((int) _r1.i);
    if (_r0.i != _r1.i) goto label24;
    _r0.i = 0;
    label23:;
    return _r0.i!=0;
    label24:;
    _r0.i = 1;
    goto label23;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

public override void processSecondPass(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet: void processSecondPass()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r4.i = 1;
    ((global::java.util.regex.JointSet) _r5_o)._fisSecondPassVisited = 0!=_r4.i;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._ffSet;
    if (_r0_o == null) goto label18;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._ffSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o)._fisSecondPassVisited ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._ffSet;
    ((global::java.util.regex.AbstractSet) _r0_o).processSecondPass();
    label18:;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    if (_r0_o == null) goto label32;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    _r1.i = ((global::java.util.ArrayList) _r0_o).size();
    _r0.i = 0;
    _r2.i = _r0.i;
    label30:;
    if (_r2.i < _r1.i) goto label40;
    label32:;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fnext;
    if (_r0_o == null) goto label39;
    base.processSecondPass();
    label39:;
    return;
    label40:;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    _r0_o = ((global::java.util.ArrayList) _r0_o).get((int) _r2.i);
    _r3_o = ((global::java.util.regex.AbstractSet) _r0_o).processBackRefReplacement();
    if (_r3_o == null) goto label67;
    ((global::java.util.regex.AbstractSet) _r0_o)._fisSecondPassVisited = 0!=_r4.i;
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    ((global::java.util.ArrayList) _r0_o).remove((int) _r2.i);
    _r0_o = ((global::java.util.regex.JointSet) _r5_o)._fchildren;
    ((global::java.util.ArrayList) _r0_o).add((int) _r2.i, (global::java.lang.Object) _r3_o);
    _r0_o = _r3_o;
    label67:;
    _r3.i = ((global::java.util.regex.AbstractSet) _r0_o)._fisSecondPassVisited ? 1 : 0;
    if (_r3.i != 0) goto label74;
    ((global::java.util.regex.AbstractSet) _r0_o).processSecondPass();
    label74:;
    _r0.i = _r2.i + 1;
    _r2.i = _r0.i;
    goto label30;
//XMLVM_END_WRAPPER[java.util.regex.JointSet: void processSecondPass()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.JointSet]
//XMLVM_END_WRAPPER[java.util.regex.JointSet]

} // end of class: JointSet

} // end of namespace: java.util.regex
