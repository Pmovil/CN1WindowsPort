// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class LinkedHashMap_2LinkedHashMapEntrySet: global::java.util.HashMap_2HashMapEntrySet {
public void @this(global::java.util.LinkedHashMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashMap$LinkedHashMapEntrySet: void <init>(java.util.LinkedHashMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.HashMap_2HashMapEntrySet) _r0_o).@this((global::java.util.HashMap) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.LinkedHashMap$LinkedHashMapEntrySet: void <init>(java.util.LinkedHashMap)]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashMap$LinkedHashMapEntrySet: java.util.Iterator iterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.util.LinkedHashMap_2EntryIterator();
    _r1_o = ((global::java.util.LinkedHashMap_2LinkedHashMapEntrySet) _r1_o).hashMap();
    ((global::java.util.LinkedHashMap_2EntryIterator) _r0_o).@this((global::java.util.LinkedHashMap) _r1_o);
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.LinkedHashMap$LinkedHashMapEntrySet: java.util.Iterator iterator()]
}

//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashMap$LinkedHashMapEntrySet]
//XMLVM_END_WRAPPER[java.util.LinkedHashMap$LinkedHashMapEntrySet]

} // end of class: LinkedHashMap_2LinkedHashMapEntrySet

} // end of namespace: java.util
