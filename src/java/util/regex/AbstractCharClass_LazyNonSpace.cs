// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class AbstractCharClass_2LazyNonSpace: global::java.util.regex.AbstractCharClass_2LazySpace {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyNonSpace: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.regex.AbstractCharClass_2LazySpace) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyNonSpace: void <init>()]
}

public override global::System.Object computeValue(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyNonSpace: java.util.regex.AbstractCharClass computeValue()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 1;
    _r0_o = base.computeValue();
    _r0_o = ((global::java.util.regex.AbstractCharClass) _r0_o).setNegative(0!=_r1.i);
    ((global::java.util.regex.AbstractCharClass) _r0_o)._fmayContainSupplCodepoints = 0!=_r1.i;
    return (global::java.util.regex.AbstractCharClass) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyNonSpace: java.util.regex.AbstractCharClass computeValue()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyNonSpace]
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyNonSpace]

} // end of class: AbstractCharClass_2LazyNonSpace

} // end of namespace: java.util.regex
