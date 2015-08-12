// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.spinner {
public class DateTimeRenderer: global::com.codename1.ui.spinner.SpinnerRenderer {

static DateTimeRenderer() {
    @static();
}

public static global::org.xmlvm._nArrayAdapter<global::System.Object> _fMONTHS;

public static global::org.xmlvm._nArrayAdapter<global::System.Object> _fDAYS;

private bool _fmarkToday;

private global::java.lang.String _foriginalUIID;

private bool _fdate;

private int _ftype;

private char _fseparatorChar;

private bool _ftwentyFourHours;

private bool _fshowSeconds;

public virtual void setType(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void setType(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._ftype = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void setType(int)]
}

private void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.ui.spinner.SpinnerRenderer) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void <init>()]
}

public virtual bool isShowSeconds(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: boolean isShowSeconds()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r1_o)._fshowSeconds ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: boolean isShowSeconds()]
}

public virtual void setMarkToday(bool n1, long n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void setMarkToday(boolean, long)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    _r2.l = n2;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fmarkToday = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void setMarkToday(boolean, long)]
}

public static global::System.Object createTimeRenderer(bool n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: com.codename1.ui.spinner.DateTimeRenderer createTimeRenderer(boolean, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r1.i = n1 ? 1 : 0;
    _r2.i = n2 ? 1 : 0;
    _r0_o = new global::com.codename1.ui.spinner.DateTimeRenderer();
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).@this();
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._ftwentyFourHours = 0!=_r1.i;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fshowSeconds = 0!=_r2.i;
    return (global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: com.codename1.ui.spinner.DateTimeRenderer createTimeRenderer(boolean, boolean)]
}

public static global::System.Object createDateRenderer(char n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: com.codename1.ui.spinner.DateTimeRenderer createDateRenderer(char, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r2.i = n1;
    _r3.i = n2;
    _r0_o = new global::com.codename1.ui.spinner.DateTimeRenderer();
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).@this();
    _r1.i = 1;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fdate = 0!=_r1.i;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar = (char) _r2.i;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._ftype = _r3.i;
    return (global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: com.codename1.ui.spinner.DateTimeRenderer createDateRenderer(char, int)]
}

private global::System.Object twoDigits(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: java.lang.String twoDigits(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = 10;
    if (_r3.i >= _r0.i) goto label24;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=0
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r3.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    label23:;
    return (global::java.lang.String) _r0_o;
    label24:;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r3.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label23;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: java.lang.String twoDigits(int)]
}

public override global::System.Object getListCellRendererComponent(global::com.codename1.ui.List n1, global::java.lang.Object n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r16;
    global::org.xmlvm._nElement _r17;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r21_o = null;
    global::System.Object _r22_o = null;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nElement _r24;
    global::org.xmlvm._nElement _r25;
    _r21_o = this;
    _r22_o = n1;
    _r23_o = n2;
    _r24.i = n3;
    _r25.i = n4 ? 1 : 0;
    _r0_o = _r23_o;
    _r0.i = ((_r0_o != null) && (_r0_o is global::java.lang.String)) ? 1 : 0;
    _r18.i = _r0.i;
    if (_r18.i == 0) goto label13;
    _r18_o = base.getListCellRendererComponent((global::com.codename1.ui.List) _r22_o, (global::java.lang.Object) _r23_o, (int) _r24.i, 0!=_r25.i);
    label12:;
    return (global::com.codename1.ui.Component) _r18_o;
    label13:;
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fdate ? 1 : 0;
    _r18.i = _r0.i;
    if (_r18.i == 0) goto label682;
    _r0_o = _r23_o;
    _r8_o = _r0_o;
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fmarkToday ? 1 : 0;
    _r18.i = _r0.i;
    if (_r18.i == 0) goto label196;
    _r7_o = global::java.util.Calendar.getInstance();
    _r18_o = new global::java.util.Date();
    ((global::java.util.Date) _r18_o).@this();
    _r0_o = _r7_o;
    _r1_o = _r18_o;
    ((global::java.util.Calendar) _r0_o).setTime((global::java.util.Date) _r1_o);
    _r18.i = 5;
    _r0_o = _r7_o;
    _r1.i = _r18.i;
    _r10.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r18.i = 2;
    _r0_o = _r7_o;
    _r1.i = _r18.i;
    _r12.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r18.i = 1;
    _r0_o = _r7_o;
    _r1.i = _r18.i;
    _r17.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    ((global::java.util.Calendar) _r7_o).setTime((global::java.util.Date) _r8_o);
    _r18.i = 5;
    _r0_o = _r7_o;
    _r1.i = _r18.i;
    _r18.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r0.i = _r10.i;
    _r1.i = _r18.i;
    if (_r0.i != _r1.i) goto label167;
    _r18.i = 1;
    _r0_o = _r7_o;
    _r1.i = _r18.i;
    _r18.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r0.i = _r17.i;
    _r1.i = _r18.i;
    if (_r0.i != _r1.i) goto label167;
    _r18.i = 2;
    _r0_o = _r7_o;
    _r1.i = _r18.i;
    _r18.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r0.i = _r12.i;
    _r1.i = _r18.i;
    if (_r0.i != _r1.i) goto label167;
    _r0_o = _r21_o;
    _r0_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._foriginalUIID;
    _r18_o = _r0_o;
    if (_r18_o != null) goto label196;
    _r18_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r21_o).getUIID();
    _r0_o = _r18_o;
    _r1_o = _r21_o;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r1_o)._foriginalUIID = (global::java.lang.String) _r0_o;
    // Value=TODAY
    _r18_o = new global::java.lang.String();
    ((global::java.lang.String)_r18_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 89))}));
    _r0_o = _r21_o;
    _r1_o = _r18_o;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).setUIID((global::java.lang.String) _r1_o);
    // Value=Today
    _r18_o = new global::java.lang.String();
    ((global::java.lang.String)_r18_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121))}));
    _r0_o = _r21_o;
    _r1_o = _r22_o;
    _r2_o = _r18_o;
    _r3.i = _r24.i;
    _r4.i = _r25.i;
    _r18_o = base.getListCellRendererComponent((global::com.codename1.ui.List) _r1_o, (global::java.lang.Object) _r2_o, (int) _r3.i, 0!=_r4.i);
    goto label12;
    label167:;
    _r0_o = _r21_o;
    _r0_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._foriginalUIID;
    _r18_o = _r0_o;
    if (_r18_o == null) goto label196;
    _r0_o = _r21_o;
    _r0_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._foriginalUIID;
    _r18_o = _r0_o;
    _r0_o = _r21_o;
    _r1_o = _r18_o;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).setUIID((global::java.lang.String) _r1_o);
    _r18_o = null;
    _r0_o = _r18_o;
    _r1_o = _r21_o;
    ((global::com.codename1.ui.spinner.DateTimeRenderer) _r1_o)._foriginalUIID = (global::java.lang.String) _r0_o;
    label196:;
    _r6_o = global::java.util.Calendar.getInstance();
    ((global::java.util.Calendar) _r6_o).setTime((global::java.util.Date) _r8_o);
    _r18.i = 5;
    _r0_o = _r6_o;
    _r1.i = _r18.i;
    _r9.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r18.i = 2;
    _r0_o = _r6_o;
    _r1.i = _r18.i;
    _r18.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r14.i = _r18.i + 1;
    _r18.i = 1;
    _r0_o = _r6_o;
    _r1.i = _r18.i;
    _r17.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._ftype;
    _r18.i = _r0.i;
    switch (_r18.i) {
    case 1: goto label259;
    case 2: goto label319;
    case 11: goto label380;
    case 12: goto label439;
    case 13: goto label498;
    case 14: goto label581;
    }
    label241:;
    _r18_o = _r23_o;
    label243:;
    _r0_o = _r21_o;
    _r1_o = _r22_o;
    _r2_o = _r18_o;
    _r3.i = _r24.i;
    _r4.i = _r25.i;
    _r18_o = base.getListCellRendererComponent((global::com.codename1.ui.List) _r1_o, (global::java.lang.Object) _r2_o, (int) _r3.i, 0!=_r4.i);
    goto label12;
    label259:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r0_o = _r21_o;
    _r1.i = _r9.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r21_o;
    _r1.i = _r14.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r18_o;
    _r1.i = _r17.i;
    _r18_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    goto label241;
    label319:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r0_o = _r21_o;
    _r1.i = _r14.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r21_o;
    _r1.i = _r9.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r18_o;
    _r1.i = _r17.i;
    _r18_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    goto label241;
    label380:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r0_o = _r21_o;
    _r1.i = _r9.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r21_o;
    _r1.i = _r14.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r19.i = _r17.i % 100;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((int) _r19.i);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    goto label241;
    label439:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r0_o = _r21_o;
    _r1.i = _r14.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r21_o;
    _r1.i = _r9.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r19.i = _r17.i % 100;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((int) _r19.i);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    goto label241;
    label498:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r19.i = 7;
    _r0_o = _r6_o;
    _r1.i = _r19.i;
    _r19.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r20.i = 1;
    _r19.i = _r19.i - _r20.i;
    _r0_o = _r21_o;
    _r1.i = _r19.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).getLocalizedDay((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r19.i = 1;
    _r19.i = _r14.i - _r19.i;
    _r0_o = _r21_o;
    _r1.i = _r19.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).getLocalizedMonth((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r21_o;
    _r1.i = _r9.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    goto label241;
    label581:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r19.i = 7;
    _r0_o = _r6_o;
    _r1.i = _r19.i;
    _r19.i = ((global::java.util.Calendar) _r0_o).get((int) _r1.i);
    _r20.i = 1;
    _r19.i = _r19.i - _r20.i;
    _r0_o = _r21_o;
    _r1.i = _r19.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).getLocalizedDay((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r19.i = 1;
    _r19.i = _r14.i - _r19.i;
    _r0_o = _r21_o;
    _r1.i = _r19.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).getLocalizedMonth((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r21_o;
    _r1.i = _r9.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fseparatorChar;
    _r19.i = _r0.i;
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((char) _r19.i);
    _r0_o = _r18_o;
    _r1.i = _r17.i;
    _r18_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    goto label241;
    label682:;
    _r16.i = ((global::java.lang.Integer) _r23_o).intValue();
    _r15.i = _r16.i % 60;
    _r16.i = _r16.i / 60;
    _r13.i = _r16.i % 60;
    _r16.i = _r16.i / 60;
    // Value=
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._ftwentyFourHours ? 1 : 0;
    _r18.i = _r0.i;
    if (_r18.i == 0) goto label781;
    _r11.i = _r16.i % 24;
    label708:;
    _r0_o = _r21_o;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o)._fshowSeconds ? 1 : 0;
    _r18.i = _r0.i;
    if (_r18.i == 0) goto label797;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r0_o = _r21_o;
    _r1.i = _r11.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    // Value=:
    _r19_o = new global::java.lang.String();
    ((global::java.lang.String)_r19_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r1.i = _r13.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    // Value=:
    _r19_o = new global::java.lang.String();
    ((global::java.lang.String)_r19_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r1.i = _r15.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r18_o;
    _r1_o = _r5_o;
    _r18_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    _r18_o = _r23_o;
    goto label243;
    label781:;
    _r11.i = _r16.i % 12;
    _r18.i = 12;
    _r0.i = _r16.i;
    _r1.i = _r18.i;
    if (_r0.i < _r1.i) goto label794;
    // Value=PM
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 77))}));
    goto label708;
    label794:;
    // Value=AM
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 77))}));
    goto label708;
    label797:;
    _r18_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r18_o).@this();
    _r0_o = _r21_o;
    _r1.i = _r11.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    // Value=:
    _r19_o = new global::java.lang.String();
    ((global::java.lang.String)_r19_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r21_o;
    _r1.i = _r13.i;
    _r19_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r0_o).twoDigits((int) _r1.i);
    _r18_o = ((global::java.lang.StringBuilder) _r18_o).append((global::java.lang.String) _r19_o);
    _r0_o = _r18_o;
    _r1_o = _r5_o;
    _r18_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r23_o = ((global::java.lang.StringBuilder) _r18_o).toString();
    _r18_o = _r23_o;
    goto label243;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
}

private global::System.Object getLocalizedMonth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: java.lang.String getLocalizedMonth(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = this;
    _r7.i = n1;
    _r4_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r6_o).getUIManager();
    _r2_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).getBundle();
    _r4_o = global::com.codename1.ui.spinner.DateTimeRenderer._fMONTHS;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r7.i];
    if (_r2_o == null) goto label43;
    _r4_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r4_o).@this();
    // Value=Calendar.
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46))}));
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r5_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r3_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).toString();
    _r1_o = ((global::java.util.Map) _r2_o).get((global::java.lang.Object) _r4_o);
    if (_r1_o == null) goto label43;
    _r0_o = _r1_o;
    _r3_o = _r0_o;
    label43:;
    return (global::java.lang.String) _r3_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: java.lang.String getLocalizedMonth(int)]
}

private global::System.Object getLocalizedDay(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: java.lang.String getLocalizedDay(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = this;
    _r7.i = n1;
    _r4_o = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r6_o).getUIManager();
    _r2_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).getBundle();
    _r4_o = global::com.codename1.ui.spinner.DateTimeRenderer._fDAYS;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r7.i];
    if (_r2_o == null) goto label43;
    _r4_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r4_o).@this();
    // Value=Calendar.
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46))}));
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r5_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r3_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).toString();
    _r1_o = ((global::java.util.Map) _r2_o).get((global::java.lang.Object) _r4_o);
    if (_r1_o == null) goto label43;
    _r0_o = _r1_o;
    _r3_o = _r0_o;
    label43:;
    return (global::java.lang.String) _r3_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: java.lang.String getLocalizedDay(int)]
}

public virtual bool isTwentyFourHours(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: boolean isTwentyFourHours()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.spinner.DateTimeRenderer) _r1_o)._ftwentyFourHours ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: boolean isTwentyFourHours()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r7.i = 4;
    _r6.i = 3;
    _r5.i = 2;
    _r4.i = 1;
    _r3.i = 0;
    _r0.i = 12;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    // Value=Jan
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)74)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i] = _r1_o;
    // Value=Feb
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r4.i] = _r1_o;
    // Value=Mar
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r5.i] = _r1_o;
    // Value=Apr
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r6.i] = _r1_o;
    // Value=May
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r7.i] = _r1_o;
    _r1.i = 5;
    // Value=Jun
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)74)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 6;
    // Value=Jul
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)74)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 7;
    // Value=Aug
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 103))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 8;
    // Value=Sep
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 9;
    // Value=Oct
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)79)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 10;
    // Value=Nov
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 118))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 11;
    // Value=Dec
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    global::com.codename1.ui.spinner.DateTimeRenderer._fMONTHS = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.i = 7;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    // Value=Sun
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i] = _r1_o;
    // Value=Mon
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r4.i] = _r1_o;
    // Value=Tue
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r5.i] = _r1_o;
    // Value=Wed
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)87)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r6.i] = _r1_o;
    // Value=Thu
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 117))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r7.i] = _r1_o;
    _r1.i = 5;
    // Value=Fri
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 6;
    // Value=Sat
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    global::com.codename1.ui.spinner.DateTimeRenderer._fDAYS = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer]
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateTimeRenderer]

} // end of class: DateTimeRenderer

} // end of namespace: com.codename1.ui.spinner
