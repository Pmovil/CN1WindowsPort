// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public class EventDispatcher_2CallbackClass: global::java.lang.Object,global::java.lang.Runnable {
private global::org.xmlvm._nArrayAdapter<global::System.Object> _fiPending;

private global::java.lang.Object _fiPendingEvent;

public global::com.codename1.ui.util.EventDispatcher _fthis_20;

public void @this(global::com.codename1.ui.util.EventDispatcher n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, global::java.lang.Object n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.EventDispatcher$CallbackClass: void <init>(com.codename1.ui.util.EventDispatcher, java.lang.Object[], java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r0_o)._fthis_20 = (global::com.codename1.ui.util.EventDispatcher) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r0_o)._fiPending = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
    ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r0_o)._fiPendingEvent = (global::java.lang.Object) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.EventDispatcher$CallbackClass: void <init>(com.codename1.ui.util.EventDispatcher, java.lang.Object[], java.lang.Object)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.EventDispatcher$CallbackClass: void run()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    _r10_o = this;
    _r9.i = 3;
    _r6.i = 2;
    _r5.i = 1;
    _r4.i = 0;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).isEdt() ? 1 : 0;
    if (_r1.i != 0) goto label22;
    _r1_o = new global::java.lang.IllegalStateException();
    // Value=This method should not be invoked by external code!
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 33))}));
    ((global::java.lang.IllegalStateException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r1_o);
    label22:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._fstyleListenerArray ? 1 : 0;
    if (_r1.i == 0) goto label56;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r1_o = _r1_o;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r8_o = _r0_o;
    _r3_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r10_o = _r10_o;
    _r10_o = _r10_o;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r4.i];
    _r1_o = _r1_o;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r5.i];
    _r2_o = _r2_o;
    global::com.codename1.ui.util.EventDispatcher.access_2000((global::com.codename1.ui.util.EventDispatcher) _r3_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r10_o, (global::java.lang.String) _r1_o, (global::com.codename1.ui.plaf.Style) _r2_o);
    label55:;
    return;
    label56:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._factionListenerArray ? 1 : 0;
    if (_r1.i == 0) goto label78;
    _r2_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r1_o = _r1_o;
    _r1_o = _r1_o;
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r10_o = _r10_o;
    global::com.codename1.ui.util.EventDispatcher.access_2100((global::com.codename1.ui.util.EventDispatcher) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::com.codename1.ui.events.ActionEvent) _r10_o);
    goto label55;
    label78:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._ffocusListenerArray ? 1 : 0;
    if (_r1.i == 0) goto label100;
    _r2_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r1_o = _r1_o;
    _r1_o = _r1_o;
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r10_o = _r10_o;
    global::com.codename1.ui.util.EventDispatcher.access_2200((global::com.codename1.ui.util.EventDispatcher) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::com.codename1.ui.Component) _r10_o);
    goto label55;
    label100:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._fdataChangeListenerArray ? 1 : 0;
    if (_r1.i == 0) goto label134;
    _r3_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r1_o = _r1_o;
    _r1_o = _r1_o;
    _r2_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r2_o = _r2_o;
    _r2_o = _r2_o;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r4.i];
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r10_o = _r10_o;
    _r10_o = _r10_o;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r5.i];
    global::com.codename1.ui.util.EventDispatcher.access_2300((global::com.codename1.ui.util.EventDispatcher) _r3_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (int) _r2.i, (int) _r4.i);
    goto label55;
    label134:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._fselectionListenerArray ? 1 : 0;
    if (_r1.i == 0) goto label168;
    _r3_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r1_o = _r1_o;
    _r1_o = _r1_o;
    _r2_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r2_o = _r2_o;
    _r2_o = _r2_o;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r4.i];
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r10_o = _r10_o;
    _r10_o = _r10_o;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r5.i];
    global::com.codename1.ui.util.EventDispatcher.access_2400((global::com.codename1.ui.util.EventDispatcher) _r3_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (int) _r2.i, (int) _r4.i);
    goto label55;
    label168:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._fscrollListenerArray ? 1 : 0;
    if (_r1.i == 0) goto label219;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r2_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r2_o = _r2_o;
    _r2_o = _r2_o;
    _r3_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r3_o = _r3_o;
    _r3_o = _r3_o;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r4.i];
    _r4_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r4_o = _r4_o;
    _r4_o = _r4_o;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r5.i];
    _r5_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r5_o = _r5_o;
    _r5_o = _r5_o;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r6.i];
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r10_o = _r10_o;
    _r10_o = _r10_o;
    _r6.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r9.i];
    global::com.codename1.ui.util.EventDispatcher.access_2500((global::com.codename1.ui.util.EventDispatcher) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    goto label55;
    label219:;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.util.EventDispatcher) _r1_o)._fbindTargetArray ? 1 : 0;
    if (_r1.i == 0) goto label55;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPendingEvent;
    _r1_o = _r1_o;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r7_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fthis_20;
    _r10_o = ((global::com.codename1.ui.util.EventDispatcher_2CallbackClass) _r10_o)._fiPending;
    _r10_o = _r10_o;
    _r0_o = _r10_o;
    _r0_o = _r0_o;
    _r2_o = _r0_o;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r4.i];
    _r3_o = _r3_o;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r5.i];
    _r4_o = _r4_o;
    _r5_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r6.i];
    _r6_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r9.i];
    global::com.codename1.ui.util.EventDispatcher.access_2600((global::com.codename1.ui.util.EventDispatcher) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::com.codename1.ui.Component) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.Object) _r5_o, (global::java.lang.Object) _r6_o);
    goto label55;
//XMLVM_END_WRAPPER[com.codename1.ui.util.EventDispatcher$CallbackClass: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.EventDispatcher$CallbackClass]
//XMLVM_END_WRAPPER[com.codename1.ui.util.EventDispatcher$CallbackClass]

} // end of class: EventDispatcher_2CallbackClass

} // end of namespace: com.codename1.ui.util
