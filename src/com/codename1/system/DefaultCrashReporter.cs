// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.system {
public class DefaultCrashReporter: global::java.lang.Object,global::com.codename1.system.CrashReport {

static DefaultCrashReporter() {
    @static();
}

private bool _fpromptUser;

private static global::java.lang.String _ferrorText;

private static global::java.lang.String _fsendButtonText;

private static global::java.lang.String _fdontSendButtonText;

private static global::java.lang.String _fcheckboxText;

public static global::System.Object getErrorText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getErrorText()]
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.system.DefaultCrashReporter._ferrorText;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getErrorText()]
}

public static void setErrorText(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void setErrorText(java.lang.String)]
    global::System.Object _r0_o = null;
    _r0_o = n1;
    global::com.codename1.system.DefaultCrashReporter._ferrorText = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void setErrorText(java.lang.String)]
}

public static global::System.Object getSendButtonText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getSendButtonText()]
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.system.DefaultCrashReporter._fsendButtonText;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getSendButtonText()]
}

public static void setSendButtonText(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void setSendButtonText(java.lang.String)]
    global::System.Object _r0_o = null;
    _r0_o = n1;
    global::com.codename1.system.DefaultCrashReporter._fsendButtonText = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void setSendButtonText(java.lang.String)]
}

public static global::System.Object getDontSendButtonText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getDontSendButtonText()]
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.system.DefaultCrashReporter._fdontSendButtonText;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getDontSendButtonText()]
}

public static void setDontSendButtonText(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void setDontSendButtonText(java.lang.String)]
    global::System.Object _r0_o = null;
    _r0_o = n1;
    global::com.codename1.system.DefaultCrashReporter._fdontSendButtonText = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void setDontSendButtonText(java.lang.String)]
}

public static global::System.Object getCheckboxText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getCheckboxText()]
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.system.DefaultCrashReporter._fcheckboxText;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: java.lang.String getCheckboxText()]
}

public static void setCheckboxText(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void setCheckboxText(java.lang.String)]
    global::System.Object _r0_o = null;
    _r0_o = n1;
    global::com.codename1.system.DefaultCrashReporter._fcheckboxText = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void setCheckboxText(java.lang.String)]
}

private void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 0;
    ((global::com.codename1.system.DefaultCrashReporter) _r1_o)._fpromptUser = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void <init>()]
}

public static void init(bool n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void init(boolean, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    _r9.i = n1 ? 1 : 0;
    _r10.i = n2;
    _r4.i = 60000;
    _r8.i = 1;
    _r7.i = 0;
    // Value=$CN1_pendingCrash
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104))}));
    // Value=$CN1_crashBlocked
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r1.i = global::com.codename1.io.Preferences.get((global::java.lang.String) _r1_o, 0!=_r7.i) ? 1 : 0;
    if (_r1.i != 0) goto label23;
    _r1.i = global::com.codename1.io.Log.getReportingLevel();
    _r2.i = global::com.codename1.io.Log._fREPORTING_1NONE;
    if (_r1.i != _r2.i) goto label24;
    label23:;
    return;
    label24:;
    // Value=$CN1_pendingCrash
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104))}));
    _r1.i = global::com.codename1.io.Preferences.get((global::java.lang.String) _r3_o, 0!=_r7.i) ? 1 : 0;
    if (_r1.i == 0) goto label40;
    global::com.codename1.io.Log.sendLog();
    // Value=$CN1_pendingCrash
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104))}));
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r3_o, 0!=_r7.i);
    label40:;
    _r1.i = global::com.codename1.io.Log.getReportingLevel();
    _r2.i = global::com.codename1.io.Log._fREPORTING_1DEBUG;
    if (_r1.i != _r2.i) goto label68;
    if (_r10.i <= 0) goto label68;
    _r0_o = new global::java.util.Timer();
    ((global::java.util.Timer) _r0_o).@this();
    _r1_o = new global::com.codename1.system.DefaultCrashReporter_21();
    ((global::com.codename1.system.DefaultCrashReporter_21) _r1_o).@this();
    _r2.i = _r10.i * _r4.i;
    _r2.l = (long) _r2.i;
    _r4.i = _r4.i * _r10.i;
    _r4.l = (long) _r4.i;
    ((global::java.util.Timer) _r0_o).schedule((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l);
    label68:;
    _r6_o = new global::com.codename1.system.DefaultCrashReporter();
    ((global::com.codename1.system.DefaultCrashReporter) _r6_o).@this();
    if (_r9.i == 0) goto label94;
    // Value=$CN1_prompt
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116))}));
    _r1.i = global::com.codename1.io.Preferences.get((global::java.lang.String) _r1_o, 0!=_r8.i) ? 1 : 0;
    if (_r1.i == 0) goto label94;
    _r1.i = _r8.i;
    label84:;
    ((global::com.codename1.system.DefaultCrashReporter) _r6_o)._fpromptUser = 0!=_r1.i;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r1_o).setCrashReporter((global::com.codename1.system.CrashReport) _r6_o);
    goto label23;
    label94:;
    _r1.i = _r7.i;
    goto label84;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void init(boolean, int)]
}

public virtual void exception(global::java.lang.Throwable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void exception(java.lang.Throwable)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    _r12_o = this;
    _r13_o = n1;
    // Value=$CN1_pendingCrash
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104))}));
    _r10.i = 1;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r9_o, 0!=_r10.i);
    _r9.i = ((global::com.codename1.system.DefaultCrashReporter) _r12_o)._fpromptUser ? 1 : 0;
    if (_r9.i == 0) goto label145;
    _r3_o = new global::com.codename1.ui.Dialog();
    // Value=Error
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.ui.Dialog) _r3_o).@this((global::java.lang.String) _r9_o);
    _r9_o = new global::com.codename1.ui.layouts.BoxLayout();
    _r10.i = 2;
    ((global::com.codename1.ui.layouts.BoxLayout) _r9_o).@this((int) _r10.i);
    ((global::com.codename1.ui.Dialog) _r3_o).setLayout((global::com.codename1.ui.layouts.Layout) _r9_o);
    _r8_o = new global::com.codename1.ui.TextArea();
    _r9_o = global::com.codename1.system.DefaultCrashReporter._ferrorText;
    ((global::com.codename1.ui.TextArea) _r8_o).@this((global::java.lang.String) _r9_o);
    _r9.i = 0;
    ((global::com.codename1.ui.TextArea) _r8_o).setEditable(0!=_r9.i);
    // Value=DialogBody
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 121))}));
    ((global::com.codename1.ui.TextArea) _r8_o).setUIID((global::java.lang.String) _r9_o);
    ((global::com.codename1.ui.Dialog) _r3_o).addComponent((global::com.codename1.ui.Component) _r8_o);
    _r0_o = new global::com.codename1.ui.CheckBox();
    _r9_o = global::com.codename1.system.DefaultCrashReporter._fcheckboxText;
    ((global::com.codename1.ui.CheckBox) _r0_o).@this((global::java.lang.String) _r9_o);
    // Value=DialogBody
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 121))}));
    ((global::com.codename1.ui.CheckBox) _r0_o).setUIID((global::java.lang.String) _r9_o);
    ((global::com.codename1.ui.Dialog) _r3_o).addComponent((global::com.codename1.ui.Component) _r0_o);
    _r4_o = new global::com.codename1.ui.Container();
    _r9_o = new global::com.codename1.ui.layouts.GridLayout();
    _r10.i = 1;
    _r11.i = 2;
    ((global::com.codename1.ui.layouts.GridLayout) _r9_o).@this((int) _r10.i, (int) _r11.i);
    ((global::com.codename1.ui.Container) _r4_o).@this((global::com.codename1.ui.layouts.Layout) _r9_o);
    ((global::com.codename1.ui.Dialog) _r3_o).addComponent((global::com.codename1.ui.Component) _r4_o);
    _r5_o = new global::com.codename1.ui.Command();
    _r9_o = global::com.codename1.system.DefaultCrashReporter._fsendButtonText;
    ((global::com.codename1.ui.Command) _r5_o).@this((global::java.lang.String) _r9_o);
    _r1_o = new global::com.codename1.ui.Command();
    _r9_o = global::com.codename1.system.DefaultCrashReporter._fdontSendButtonText;
    ((global::com.codename1.ui.Command) _r1_o).@this((global::java.lang.String) _r9_o);
    _r7_o = new global::com.codename1.ui.Button();
    ((global::com.codename1.ui.Button) _r7_o).@this((global::com.codename1.ui.Command) _r5_o);
    _r2_o = new global::com.codename1.ui.Button();
    ((global::com.codename1.ui.Button) _r2_o).@this((global::com.codename1.ui.Command) _r1_o);
    ((global::com.codename1.ui.Container) _r4_o).addComponent((global::com.codename1.ui.Component) _r7_o);
    ((global::com.codename1.ui.Container) _r4_o).addComponent((global::com.codename1.ui.Component) _r2_o);
    // Value=Center
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r10.i = 1;
    _r6_o = ((global::com.codename1.ui.Dialog) _r3_o).showPacked((global::java.lang.String) _r9_o, 0!=_r10.i);
    if (_r6_o != _r1_o) goto label133;
    _r9.i = ((global::com.codename1.ui.CheckBox) _r0_o).isSelected() ? 1 : 0;
    if (_r9.i == 0) goto label126;
    // Value=$CN1_crashBlocked
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r10.i = 1;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r9_o, 0!=_r10.i);
    label126:;
    // Value=$CN1_pendingCrash
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104))}));
    _r10.i = 0;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r9_o, 0!=_r10.i);
    label132:;
    return;
    label133:;
    _r9.i = ((global::com.codename1.ui.CheckBox) _r0_o).isSelected() ? 1 : 0;
    if (_r9.i == 0) goto label145;
    // Value=$CN1_prompt
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116))}));
    _r10.i = 0;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r9_o, 0!=_r10.i);
    label145:;
    global::com.codename1.io.Log.sendLog();
    // Value=$CN1_pendingCrash
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104))}));
    _r10.i = 0;
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r9_o, 0!=_r10.i);
    goto label132;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void exception(java.lang.Throwable)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter: void <clinit>()]
    global::System.Object _r0_o = null;
    // Value=The application encountered an error, do you wish to report it?
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 63))}));
    global::com.codename1.system.DefaultCrashReporter._ferrorText = (global::java.lang.String) _r0_o;
    // Value=Send
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100))}));
    global::com.codename1.system.DefaultCrashReporter._fsendButtonText = (global::java.lang.String) _r0_o;
    // Value=Don't Send
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100))}));
    global::com.codename1.system.DefaultCrashReporter._fdontSendButtonText = (global::java.lang.String) _r0_o;
    // Value=Don't show this dialog again
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110))}));
    global::com.codename1.system.DefaultCrashReporter._fcheckboxText = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.system.DefaultCrashReporter]
//XMLVM_END_WRAPPER[com.codename1.system.DefaultCrashReporter]

} // end of class: DefaultCrashReporter

} // end of namespace: com.codename1.system
