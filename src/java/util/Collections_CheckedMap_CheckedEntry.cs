// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2CheckedMap_2CheckedEntry: global::java.lang.Object,global::java.util.Map_2Entry {
public global::java.util.Map_2Entry _fe;

public global::java.lang.Class _fvalueType;

public void @this(global::java.util.Map_2Entry n1, global::java.lang.Class n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: void <init>(java.util.Map$Entry, java.lang.Class)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::java.lang.Object) _r1_o).@this();
    if (_r2_o != null) goto label11;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label11:;
    ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r1_o)._fe = (global::java.util.Map_2Entry) _r2_o;
    ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r1_o)._fvalueType = (global::java.lang.Class) _r3_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: void <init>(java.util.Map$Entry, java.lang.Class)]
}

public virtual global::System.Object getKey(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: java.lang.Object getKey()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r1_o)._fe;
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).getKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: java.lang.Object getKey()]
}

public virtual global::System.Object getValue(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: java.lang.Object getValue()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r1_o)._fe;
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).getValue();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: java.lang.Object getValue()]
}

public virtual global::System.Object setValue(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: java.lang.Object setValue(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r2_o)._fe;
    _r1_o = ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r2_o)._fvalueType;
    _r1_o = global::java.util.Collections.checkType((global::java.lang.Object) _r3_o, (global::java.lang.Class) _r1_o);
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).setValue((global::java.lang.Object) _r1_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: java.lang.Object setValue(java.lang.Object)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r1_o)._fe;
    _r0.i = ((global::java.util.Map_2Entry) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedMap_2CheckedEntry) _r1_o)._fe;
    _r0.i = ((global::java.util.Map_2Entry) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry: int hashCode()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry]
//XMLVM_END_WRAPPER[java.util.Collections$CheckedMap$CheckedEntry]

} // end of class: Collections_2CheckedMap_2CheckedEntry

} // end of namespace: java.util
