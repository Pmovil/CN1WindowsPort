// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.javascript {
public class JavascriptContext_2ScriptMessageListener: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.javascript.JavascriptContext _fthis_20;

private void @this(global::com.codename1.javascript.JavascriptContext n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener: void <init>(com.codename1.javascript.JavascriptContext)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.javascript.JavascriptContext_2ScriptMessageListener) _r0_o)._fthis_20 = (global::com.codename1.javascript.JavascriptContext) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener: void <init>(com.codename1.javascript.JavascriptContext)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r8_o = this;
    _r9_o = n1;
    _r0_o = _r9_o;
    _r0_o = _r0_o;
    _r2_o = _r0_o;
    _r5_o = ((global::com.codename1.javascript.JavascriptEvent) _r2_o).getSelf();
    _r4_o = ((global::com.codename1.javascript.JavascriptEvent) _r2_o).getMethod();
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    _r7_o = ((global::com.codename1.javascript.JSObject) _r5_o).toJSPointer();
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    // Value=.
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    _r6_o = ((global::com.codename1.javascript.JavascriptContext_2ScriptMessageListener) _r8_o)._fthis_20;
    _r6_o = global::com.codename1.javascript.JavascriptContext.access_2400((global::com.codename1.javascript.JavascriptContext) _r6_o);
    _r1_o = ((global::java.util.Hashtable) _r6_o).get((global::java.lang.Object) _r3_o);
    _r1_o = _r1_o;
    if (_r1_o != null) goto label54;
    label53:;
    return;
    label54:;
    _r6_o = ((global::com.codename1.javascript.JavascriptEvent) _r2_o).getArgs();
    ((global::com.codename1.javascript.JSFunction) _r1_o).apply((global::com.codename1.javascript.JSObject) _r5_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o);
    ((global::com.codename1.ui.events.ActionEvent) _r9_o).consume();
    goto label53;
//XMLVM_END_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

public void @this(global::com.codename1.javascript.JavascriptContext n1, global::com.codename1.javascript.JavascriptContext_21 n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener: void <init>(com.codename1.javascript.JavascriptContext, com.codename1.javascript.JavascriptContext$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.javascript.JavascriptContext_2ScriptMessageListener) _r0_o).@this((global::com.codename1.javascript.JavascriptContext) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener: void <init>(com.codename1.javascript.JavascriptContext, com.codename1.javascript.JavascriptContext$1)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener]
//XMLVM_END_WRAPPER[com.codename1.javascript.JavascriptContext$ScriptMessageListener]

} // end of class: JavascriptContext_2ScriptMessageListener

} // end of namespace: com.codename1.javascript
