// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_21: global::java.lang.Object,global::java.util.Enumeration {
public global::java.util.Iterator _fit;

public void @this(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$1: void <init>(java.util.Collection)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = ((global::java.util.Collection) _r2_o).iterator();
    ((global::java.util.Collections_21) _r1_o)._fit = (global::java.util.Iterator) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$1: void <init>(java.util.Collection)]
}

public virtual bool hasMoreElements(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$1: boolean hasMoreElements()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_21) _r1_o)._fit;
    _r0.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$1: boolean hasMoreElements()]
}

public virtual global::System.Object nextElement(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$1: java.lang.Object nextElement()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_21) _r1_o)._fit;
    _r0_o = ((global::java.util.Iterator) _r0_o).next();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$1: java.lang.Object nextElement()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$1]
//XMLVM_END_WRAPPER[java.util.Collections$1]

} // end of class: Collections_21

} // end of namespace: java.util
