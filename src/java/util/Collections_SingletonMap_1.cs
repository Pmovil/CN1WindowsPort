// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2SingletonMap_21: global::java.util.AbstractSet {
public global::java.util.Collections_2SingletonMap _fthis_21;

public void @this(global::java.util.Collections_2SingletonMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SingletonMap$1: void <init>(java.util.Collections$SingletonMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Collections_2SingletonMap_21) _r0_o)._fthis_21 = (global::java.util.Collections_2SingletonMap) _r1_o;
    ((global::java.util.AbstractSet) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$SingletonMap$1: void <init>(java.util.Collections$SingletonMap)]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SingletonMap$1: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    _r0.i = ((_r4_o != null) && (_r4_o is global::java.util.Map_2Entry)) ? 1 : 0;
    if (_r0.i == 0) goto label35;
    _r0_o = ((global::java.util.Collections_2SingletonMap_21) _r3_o)._fthis_21;
    _r1_o = ((global::java.util.Map_2Entry) _r4_o).getKey();
    _r0.i = ((global::java.util.Collections_2SingletonMap) _r0_o).containsKey((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label33;
    _r0_o = ((global::java.util.Collections_2SingletonMap_21) _r3_o)._fthis_21;
    _r1_o = ((global::java.util.Map_2Entry) _r4_o).getValue();
    _r0.i = ((global::java.util.Collections_2SingletonMap) _r0_o).containsValue((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label33;
    _r0.i = 1;
    label32:;
    return _r0.i!=0;
    label33:;
    _r0.i = _r2.i;
    goto label32;
    label35:;
    _r0.i = _r2.i;
    goto label32;
//XMLVM_END_WRAPPER[java.util.Collections$SingletonMap$1: boolean contains(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SingletonMap$1: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$SingletonMap$1: int size()]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SingletonMap$1: java.util.Iterator iterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.util.Collections_2SingletonMap_21_21();
    ((global::java.util.Collections_2SingletonMap_21_21) _r0_o).@this((global::java.util.Collections_2SingletonMap_21) _r1_o);
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SingletonMap$1: java.util.Iterator iterator()]
}

public static global::System.Object access_20(global::java.util.Collections_2SingletonMap_21 n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SingletonMap$1: java.util.Collections$SingletonMap access$0(java.util.Collections$SingletonMap$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = ((global::java.util.Collections_2SingletonMap_21) _r1_o)._fthis_21;
    return (global::java.util.Collections_2SingletonMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SingletonMap$1: java.util.Collections$SingletonMap access$0(java.util.Collections$SingletonMap$1)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$SingletonMap$1]
//XMLVM_END_WRAPPER[java.util.Collections$SingletonMap$1]

} // end of class: Collections_2SingletonMap_21

} // end of namespace: java.util
