// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeMap_2BoundedValueIterator: global::java.util.TreeMap_2BoundedMapIterator,global::java.util.Iterator {
public void @this(global::java.util.TreeMap_2Node n1, int n2, global::java.util.TreeMap n3, global::java.util.TreeMap_2Node n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$BoundedValueIterator: void <init>(java.util.TreeMap$Node, int, java.util.TreeMap, java.util.TreeMap$Node, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3_o = n3;
    _r4_o = n4;
    _r5.i = n5;
    ((global::java.util.TreeMap_2BoundedMapIterator) _r0_o).@this((global::java.util.TreeMap_2Node) _r1_o, (int) _r2.i, (global::java.util.TreeMap) _r3_o, (global::java.util.TreeMap_2Node) _r4_o, (int) _r5.i);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$BoundedValueIterator: void <init>(java.util.TreeMap$Node, int, java.util.TreeMap, java.util.TreeMap$Node, int)]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$BoundedValueIterator: java.lang.Object next()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.util.TreeMap_2BoundedValueIterator) _r2_o).hasNext() ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
    label12:;
    ((global::java.util.TreeMap_2BoundedValueIterator) _r2_o).makeBoundedNext();
    _r0_o = ((global::java.util.TreeMap_2BoundedValueIterator) _r2_o)._flastNode;
    _r0_o = ((global::java.util.TreeMap_2Node) _r0_o)._fvalues;
    _r1.i = ((global::java.util.TreeMap_2BoundedValueIterator) _r2_o)._flastOffset;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$BoundedValueIterator: java.lang.Object next()]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$BoundedValueIterator]
//XMLVM_END_WRAPPER[java.util.TreeMap$BoundedValueIterator]

} // end of class: TreeMap_2BoundedValueIterator

} // end of namespace: java.util
