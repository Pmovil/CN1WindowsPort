// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomNode_2ListenerRecord: global::java.lang.Object {
public global::java.lang.String _ftype;

public global::org.w3c.dom.events.EventListener _flistener;

public bool _fuseCapture;

public void @this(global::java.lang.String n1, global::org.w3c.dom.events.EventListener n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord: void <init>(java.lang.String, org.w3c.dom.events.EventListener, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3 ? 1 : 0;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = ((global::java.lang.String) _r2_o).intern();
    ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r1_o)._ftype = (global::java.lang.String) _r0_o;
    ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r1_o)._flistener = (global::org.w3c.dom.events.EventListener) _r3_o;
    ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r1_o)._fuseCapture = 0!=_r4.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord: void <init>(java.lang.String, org.w3c.dom.events.EventListener, boolean)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r2_o)._flistener;
    _r1_o = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r3_o)._flistener;
    if (_r0_o != _r1_o) goto label22;
    _r0.i = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r2_o)._fuseCapture ? 1 : 0;
    _r1.i = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r3_o)._fuseCapture ? 1 : 0;
    if (_r0.i != _r1.i) goto label22;
    _r0_o = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r2_o)._ftype;
    _r1_o = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r3_o)._ftype;
    if (_r0_o != _r1_o) goto label22;
    _r0.i = 1;
    label21:;
    return _r0.i!=0;
    label22:;
    _r0.i = 0;
    goto label21;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r2_o)._flistener;
    _r0.i = ((global::java.lang.Object) _r0_o).hashCode();
    _r1_o = ((global::gnu.xml.dom.DomNode_2ListenerRecord) _r2_o)._ftype;
    _r1.i = ((global::java.lang.String) _r1_o).hashCode();
    _r0.i = _r0.i ^ _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord: int hashCode()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomNode$ListenerRecord]

} // end of class: DomNode_2ListenerRecord

} // end of namespace: gnu.xml.dom
