// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class HashMap_2HashMapEntrySet: global::java.util.AbstractSet {
private global::java.util.HashMap _fassociatedMap;

public void @this(global::java.util.HashMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: void <init>(java.util.HashMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.AbstractSet) _r0_o).@this();
    ((global::java.util.HashMap_2HashMapEntrySet) _r0_o)._fassociatedMap = (global::java.util.HashMap) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: void <init>(java.util.HashMap)]
}

public virtual global::System.Object hashMap(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: java.util.HashMap hashMap()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.HashMap_2HashMapEntrySet) _r1_o)._fassociatedMap;
    return (global::java.util.HashMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: java.util.HashMap hashMap()]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.HashMap_2HashMapEntrySet) _r1_o)._fassociatedMap;
    _r0.i = ((global::java.util.HashMap) _r0_o)._felementCount;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: int size()]
}

public override void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.HashMap_2HashMapEntrySet) _r1_o)._fassociatedMap;
    ((global::java.util.HashMap) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: void clear()]
}

public override bool remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: boolean remove(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.Map_2Entry)) ? 1 : 0;
    if (_r0.i == 0) goto label29;
    _r0_o = ((global::java.util.HashMap_2HashMapEntrySet) _r2_o)._fassociatedMap;
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getKey();
    _r0_o = ((global::java.util.HashMap) _r0_o).getEntry((global::java.lang.Object) _r1_o);
    _r1.i = global::java.util.HashMap_2HashMapEntrySet.valuesEq((global::java.util.HashMap_2Entry) _r0_o, (global::java.util.Map_2Entry) _r3_o) ? 1 : 0;
    if (_r1.i == 0) goto label29;
    _r1_o = ((global::java.util.HashMap_2HashMapEntrySet) _r2_o)._fassociatedMap;
    ((global::java.util.HashMap) _r1_o).removeEntry((global::java.util.HashMap_2Entry) _r0_o);
    _r0.i = 1;
    label28:;
    return _r0.i!=0;
    label29:;
    _r0.i = 0;
    goto label28;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: boolean remove(java.lang.Object)]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.Map_2Entry)) ? 1 : 0;
    if (_r0.i == 0) goto label21;
    _r0_o = ((global::java.util.HashMap_2HashMapEntrySet) _r2_o)._fassociatedMap;
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getKey();
    _r0_o = ((global::java.util.HashMap) _r0_o).getEntry((global::java.lang.Object) _r1_o);
    _r0.i = global::java.util.HashMap_2HashMapEntrySet.valuesEq((global::java.util.HashMap_2Entry) _r0_o, (global::java.util.Map_2Entry) _r3_o) ? 1 : 0;
    label20:;
    return _r0.i!=0;
    label21:;
    _r0.i = 0;
    goto label20;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: boolean contains(java.lang.Object)]
}

private static bool valuesEq(global::java.util.HashMap_2Entry n1, global::java.util.Map_2Entry n2){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: boolean valuesEq(java.util.HashMap$Entry, java.util.Map$Entry)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = n1;
    _r3_o = n2;
    if (_r2_o == null) goto label26;
    _r0_o = ((global::java.util.HashMap_2Entry) _r2_o)._fvalue;
    if (_r0_o != null) goto label14;
    _r0_o = ((global::java.util.Map_2Entry) _r3_o).getValue();
    if (_r0_o != null) goto label26;
    label12:;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0_o = ((global::java.util.HashMap_2Entry) _r2_o)._fvalue;
    _r1_o = ((global::java.util.Map_2Entry) _r3_o).getValue();
    _r0.i = global::java.util.HashMap.areEqualValues((global::java.lang.Object) _r0_o, (global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label12;
    label26:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: boolean valuesEq(java.util.HashMap$Entry, java.util.Map$Entry)]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet: java.util.Iterator iterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.util.HashMap_2EntryIterator();
    _r1_o = ((global::java.util.HashMap_2HashMapEntrySet) _r2_o)._fassociatedMap;
    ((global::java.util.HashMap_2EntryIterator) _r0_o).@this((global::java.util.HashMap) _r1_o);
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet: java.util.Iterator iterator()]
}

//XMLVM_BEGIN_WRAPPER[java.util.HashMap$HashMapEntrySet]
//XMLVM_END_WRAPPER[java.util.HashMap$HashMapEntrySet]

} // end of class: HashMap_2HashMapEntrySet

} // end of namespace: java.util
