// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.impl {
public class ImplementationFactory: global::java.lang.Object {

static ImplementationFactory() {
    @static();
}

private static global::com.codename1.impl.ImplementationFactory _finstance;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.ImplementationFactory: void <init>()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.ImplementationFactory: void <init>()]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.ImplementationFactory: com.codename1.impl.ImplementationFactory getInstance()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.impl.ImplementationFactory._finstance;
    return (global::com.codename1.impl.ImplementationFactory) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.impl.ImplementationFactory: com.codename1.impl.ImplementationFactory getInstance()]
}

public static void setInstance(global::com.codename1.impl.ImplementationFactory n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.ImplementationFactory: void setInstance(com.codename1.impl.ImplementationFactory)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    _r0_o = n1;
    global::com.codename1.impl.ImplementationFactory._finstance = (global::com.codename1.impl.ImplementationFactory) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.ImplementationFactory: void setInstance(com.codename1.impl.ImplementationFactory)]
}

public virtual global::System.Object createImplementation(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.ImplementationFactory: java.lang.Object createImplementation()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::com.codename1.impl.SilverlightImplementation();
    ((global::com.codename1.impl.SilverlightImplementation) _r0_o).@this();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.impl.ImplementationFactory: java.lang.Object createImplementation()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.ImplementationFactory: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    _r0_o = new global::com.codename1.impl.ImplementationFactory();
    ((global::com.codename1.impl.ImplementationFactory) _r0_o).@this();
    global::com.codename1.impl.ImplementationFactory._finstance = (global::com.codename1.impl.ImplementationFactory) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.ImplementationFactory: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.impl.ImplementationFactory]
//XMLVM_END_WRAPPER[com.codename1.impl.ImplementationFactory]

} // end of class: ImplementationFactory

} // end of namespace: com.codename1.impl
