// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class HashMap_22: global::java.util.AbstractCollection {
public global::java.util.HashMap _fthis_20;

public void @this(global::java.util.HashMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$2: void <init>(java.util.HashMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.HashMap_22) _r0_o)._fthis_20 = (global::java.util.HashMap) _r1_o;
    ((global::java.util.AbstractCollection) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$2: void <init>(java.util.HashMap)]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$2: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.HashMap_22) _r1_o)._fthis_20;
    _r0.i = ((global::java.util.HashMap) _r0_o).containsValue((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.HashMap$2: boolean contains(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$2: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.HashMap_22) _r1_o)._fthis_20;
    _r0.i = ((global::java.util.HashMap) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.HashMap$2: int size()]
}

public override void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$2: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.HashMap_22) _r1_o)._fthis_20;
    ((global::java.util.HashMap) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$2: void clear()]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$2: java.util.Iterator iterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.util.HashMap_2ValueIterator();
    _r1_o = ((global::java.util.HashMap_22) _r2_o)._fthis_20;
    ((global::java.util.HashMap_2ValueIterator) _r0_o).@this((global::java.util.HashMap) _r1_o);
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.HashMap$2: java.util.Iterator iterator()]
}

//XMLVM_BEGIN_WRAPPER[java.util.HashMap$2]
//XMLVM_END_WRAPPER[java.util.HashMap$2]

} // end of class: HashMap_22

} // end of namespace: java.util
