// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2UnmodifiableMap: global::java.lang.Object,global::java.util.Map,global::java.io.Serializable {
private static long _fserialVersionUID = -1034234728574286014L;

private global::java.util.Map _fm;

public void @this(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: void <init>(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.util.Collections_2UnmodifiableMap) _r0_o)._fm = (global::java.util.Map) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: void <init>(java.util.Map)]
}

public virtual void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: void clear()]
}

public virtual bool containsKey(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: boolean containsKey(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).containsKey((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: boolean containsKey(java.lang.Object)]
}

public virtual bool containsValue(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: boolean containsValue(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).containsValue((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: boolean containsValue(java.lang.Object)]
}

public virtual global::System.Object entrySet(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.util.Set entrySet()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.util.Collections_2UnmodifiableMap_2UnmodifiableEntrySet();
    _r1_o = ((global::java.util.Collections_2UnmodifiableMap) _r2_o)._fm;
    _r1_o = ((global::java.util.Map) _r1_o).entrySet();
    ((global::java.util.Collections_2UnmodifiableMap_2UnmodifiableEntrySet) _r0_o).@this((global::java.util.Set) _r1_o);
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.util.Set entrySet()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: boolean equals(java.lang.Object)]
}

public virtual global::System.Object get(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.Object get(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0_o = ((global::java.util.Map) _r0_o).get((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.Object get(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: int hashCode()]
}

public virtual bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).isEmpty() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: boolean isEmpty()]
}

public virtual global::System.Object keySet(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.util.Set keySet()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.util.Collections_2UnmodifiableSet();
    _r1_o = ((global::java.util.Collections_2UnmodifiableMap) _r2_o)._fm;
    _r1_o = ((global::java.util.Map) _r1_o).keySet();
    ((global::java.util.Collections_2UnmodifiableSet) _r0_o).@this((global::java.util.Set) _r1_o);
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.util.Set keySet()]
}

public virtual global::System.Object put(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.Object put(java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.Object put(java.lang.Object, java.lang.Object)]
}

public virtual void putAll(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: void putAll(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: void putAll(java.util.Map)]
}

public virtual global::System.Object remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.Object remove(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.Object remove(java.lang.Object)]
}

public virtual int size(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: int size()]
}

public virtual global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.util.Collection values()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.util.Collections_2UnmodifiableCollection();
    _r1_o = ((global::java.util.Collections_2UnmodifiableMap) _r2_o)._fm;
    _r1_o = ((global::java.util.Map) _r1_o).values();
    ((global::java.util.Collections_2UnmodifiableCollection) _r0_o).@this((global::java.util.Collection) _r1_o);
    return (global::java.util.Collection) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.util.Collection values()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableMap) _r1_o)._fm;
    _r0_o = ((global::java.lang.Object) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableMap]
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableMap]

} // end of class: Collections_2UnmodifiableMap

} // end of namespace: java.util
