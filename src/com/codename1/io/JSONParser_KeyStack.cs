// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io {
public class JSONParser_2KeyStack: global::java.util.Vector {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.JSONParser$KeyStack: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.Vector) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.JSONParser$KeyStack: void <init>()]
}

public virtual global::System.Object peek(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.JSONParser$KeyStack: java.lang.String peek()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    _r1_o = ((global::com.codename1.io.JSONParser_2KeyStack) _r1_o).elementAt((int) _r0.i);
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.io.JSONParser$KeyStack: java.lang.String peek()]
}

public virtual void push(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.JSONParser$KeyStack: void push(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    ((global::com.codename1.io.JSONParser_2KeyStack) _r1_o).insertElementAt((global::java.lang.Object) _r2_o, (int) _r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.JSONParser$KeyStack: void push(java.lang.String)]
}

public virtual global::System.Object pop(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.JSONParser$KeyStack: java.lang.String pop()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = ((global::com.codename1.io.JSONParser_2KeyStack) _r2_o).isEmpty() ? 1 : 0;
    if (_r1.i == 0) goto label8;
    _r1_o = null;
    label7:;
    return (global::java.lang.String) _r1_o;
    label8:;
    _r0_o = ((global::com.codename1.io.JSONParser_2KeyStack) _r2_o).peek();
    _r1.i = 0;
    ((global::com.codename1.io.JSONParser_2KeyStack) _r2_o).removeElementAt((int) _r1.i);
    _r1_o = _r0_o;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.io.JSONParser$KeyStack: java.lang.String pop()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.JSONParser$KeyStack]
//XMLVM_END_WRAPPER[com.codename1.io.JSONParser$KeyStack]

} // end of class: JSONParser_2KeyStack

} // end of namespace: com.codename1.io
