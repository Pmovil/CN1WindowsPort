// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class AbstractMap_21_21: global::java.lang.Object,global::java.util.Iterator {
public global::java.util.Iterator _fsetIterator;

public global::java.util.AbstractMap_21 _fthis_21;

public void @this(global::java.util.AbstractMap_21 n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap$1$1: void <init>(java.util.AbstractMap$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.AbstractMap_21_21) _r1_o)._fthis_21 = (global::java.util.AbstractMap_21) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = global::java.util.AbstractMap_21.access_20((global::java.util.AbstractMap_21) _r2_o);
    _r0_o = ((global::java.util.AbstractMap) _r0_o).entrySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    ((global::java.util.AbstractMap_21_21) _r1_o)._fsetIterator = (global::java.util.Iterator) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.AbstractMap$1$1: void <init>(java.util.AbstractMap$1)]
}

public virtual bool hasNext(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap$1$1: boolean hasNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap_21_21) _r1_o)._fsetIterator;
    _r0.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.AbstractMap$1$1: boolean hasNext()]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap$1$1: java.lang.Object next()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap_21_21) _r1_o)._fsetIterator;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    _r0_o = ((global::java.util.Map_2Entry) _r1_o).getKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.AbstractMap$1$1: java.lang.Object next()]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap$1$1: void remove()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.AbstractMap_21_21) _r1_o)._fsetIterator;
    ((global::java.util.Iterator) _r0_o).remove();
    return;
//XMLVM_END_WRAPPER[java.util.AbstractMap$1$1: void remove()]
}

//XMLVM_BEGIN_WRAPPER[java.util.AbstractMap$1$1]
//XMLVM_END_WRAPPER[java.util.AbstractMap$1$1]

} // end of class: AbstractMap_21_21

} // end of namespace: java.util
