// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class AbstractCharClass_2LazyAlnum: global::java.util.regex.AbstractCharClass_2LazyAlpha {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyAlnum: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.regex.AbstractCharClass_2LazyAlpha) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyAlnum: void <init>()]
}

public override global::System.Object computeValue(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyAlnum: java.util.regex.AbstractCharClass computeValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r2_o = base.computeValue();
    _r2_o = _r2_o;
    _r0.i = 48;
    _r1.i = 57;
    _r0_o = ((global::java.util.regex.CharClass) _r2_o).add((int) _r0.i, (int) _r1.i);
    return (global::java.util.regex.AbstractCharClass) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyAlnum: java.util.regex.AbstractCharClass computeValue()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyAlnum]
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyAlnum]

} // end of class: AbstractCharClass_2LazyAlnum

} // end of namespace: java.util.regex
