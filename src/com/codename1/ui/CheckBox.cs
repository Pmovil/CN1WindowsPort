// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class CheckBox: global::com.codename1.ui.Button {
private bool _fselected;

private bool _foppositeSide;

private global::com.codename1.ui.util.EventDispatcher _fbindListeners;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    ((global::com.codename1.ui.CheckBox) _r1_o).@this((global::java.lang.String) _r2_o, (global::com.codename1.ui.Image) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void <init>(java.lang.String)]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    ((global::com.codename1.ui.CheckBox) _r1_o).@this((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void <init>()]
}

public void @this(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void <init>(com.codename1.ui.Image)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    ((global::com.codename1.ui.CheckBox) _r1_o).@this((global::java.lang.String) _r0_o, (global::com.codename1.ui.Image) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void <init>(com.codename1.ui.Image)]
}

public void @this(global::java.lang.String n1, global::com.codename1.ui.Image n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void <init>(java.lang.String, com.codename1.ui.Image)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::com.codename1.ui.Button) _r1_o).@this((global::java.lang.String) _r2_o, (global::com.codename1.ui.Image) _r3_o);
    _r0.i = 0;
    ((global::com.codename1.ui.CheckBox) _r1_o)._fselected = 0!=_r0.i;
    _r0_o = null;
    ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    // Value=CheckBox
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120))}));
    ((global::com.codename1.ui.CheckBox) _r1_o).setUIID((global::java.lang.String) _r0_o);
    ((global::com.codename1.ui.CheckBox) _r1_o).updateSide();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void <init>(java.lang.String, com.codename1.ui.Image)]
}

public override bool isSelected(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: boolean isSelected()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.CheckBox) _r1_o)._fselected ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: boolean isSelected()]
}

public virtual void setSelected(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void setSelected(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.CheckBox) _r0_o)._fselected = 0!=_r1.i;
    ((global::com.codename1.ui.CheckBox) _r0_o).repaint();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void setSelected(boolean)]
}

public override void released(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void released(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0.i = ((global::com.codename1.ui.CheckBox) _r1_o).isSelected() ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0.i = 1;
    label7:;
    ((global::com.codename1.ui.CheckBox) _r1_o)._fselected = 0!=_r0.i;
    base.released((int) _r2.i, (int) _r3.i);
    return;
    label13:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void released(int, int)]
}

public override void fireActionEvent(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void fireActionEvent(int, int)]
    global::org.xmlvm._nElement _r0;
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    // Value=selected
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    base.fireActionEvent((int) _r5.i, (int) _r6.i);
    _r0_o = ((global::com.codename1.ui.CheckBox) _r4_o)._fbindListeners;
    if (_r0_o == null) goto label26;
    _r0.i = ((global::com.codename1.ui.CheckBox) _r4_o).isSelected() ? 1 : 0;
    if (_r0.i == 0) goto label27;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r4_o)._fbindListeners;
    // Value=selected
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r1_o = global::java.lang.Boolean._fFALSE;
    _r2_o = global::java.lang.Boolean._fTRUE;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).fireBindTargetChange((global::com.codename1.ui.Component) _r4_o, (global::java.lang.String) _r3_o, (global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    label26:;
    return;
    label27:;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r4_o)._fbindListeners;
    // Value=selected
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r1_o = global::java.lang.Boolean._fTRUE;
    _r2_o = global::java.lang.Boolean._fFALSE;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).fireBindTargetChange((global::com.codename1.ui.Component) _r4_o, (global::java.lang.String) _r3_o, (global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    goto label26;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void fireActionEvent(int, int)]
}

public override void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void paint(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::com.codename1.ui.CheckBox) _r1_o).isToggle() ? 1 : 0;
    if (_r0.i == 0) goto label18;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o).getUIManager();
    _r0_o = ((global::com.codename1.ui.plaf.UIManager) _r0_o).getLookAndFeel();
    ((global::com.codename1.ui.plaf.LookAndFeel) _r0_o).drawButton((global::com.codename1.ui.Graphics) _r2_o, (global::com.codename1.ui.Button) _r1_o);
    label17:;
    return;
    label18:;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o).getUIManager();
    _r0_o = ((global::com.codename1.ui.plaf.UIManager) _r0_o).getLookAndFeel();
    ((global::com.codename1.ui.plaf.LookAndFeel) _r0_o).drawCheckBox((global::com.codename1.ui.Graphics) _r2_o, (global::com.codename1.ui.Button) _r1_o);
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void paint(com.codename1.ui.Graphics)]
}

public override global::System.Object calcPreferredSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: com.codename1.ui.geom.Dimension calcPreferredSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o).getUIManager();
    _r0_o = ((global::com.codename1.ui.plaf.UIManager) _r0_o).getLookAndFeel();
    _r0_o = ((global::com.codename1.ui.plaf.LookAndFeel) _r0_o).getCheckBoxPreferredSize((global::com.codename1.ui.Button) _r1_o);
    return (global::com.codename1.ui.geom.Dimension) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: com.codename1.ui.geom.Dimension calcPreferredSize()]
}

public override global::System.Object paramString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: java.lang.String paramString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = base.paramString();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value=, selected = 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.ui.CheckBox) _r2_o)._fselected ? 1 : 0;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append(0!=_r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: java.lang.String paramString()]
}

public override void initComponentImpl(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void initComponentImpl()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    base.initComponentImpl();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void initComponentImpl()]
}

private void updateSide(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void updateSide()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r1_o = ((global::com.codename1.ui.CheckBox) _r3_o).getUIManager();
    // Value=checkBoxOppositeSideBool
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108))}));
    _r0_o = ((global::com.codename1.ui.plaf.UIManager) _r1_o).isThemeConstant((global::java.lang.String) _r2_o);
    if (_r0_o == null) goto label18;
    _r1.i = ((global::java.lang.Boolean) _r0_o).booleanValue() ? 1 : 0;
    ((global::com.codename1.ui.CheckBox) _r3_o)._foppositeSide = 0!=_r1.i;
    label18:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void updateSide()]
}

public override void refreshTheme(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void refreshTheme(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    base.refreshTheme(0!=_r1.i);
    ((global::com.codename1.ui.CheckBox) _r0_o).updateSide();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void refreshTheme(boolean)]
}

public override int getAvaliableSpaceForText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: int getAvaliableSpaceForText()]
    global::org.xmlvm._nElement _r0;
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r3.i = ((global::com.codename1.ui.CheckBox) _r6_o).isToggle() ? 1 : 0;
    if (_r3.i == 0) goto label11;
    _r3.i = base.getAvaliableSpaceForText();
    label10:;
    return _r3.i;
    label11:;
    _r3_o = ((global::com.codename1.ui.CheckBox) _r6_o).getUIManager();
    _r1_o = ((global::com.codename1.ui.plaf.UIManager) _r3_o).getLookAndFeel();
    _r3.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.plaf.DefaultLookAndFeel)) ? 1 : 0;
    if (_r3.i == 0) goto label54;
    _r1_o = _r1_o;
    _r2_o = ((global::com.codename1.ui.plaf.DefaultLookAndFeel) _r1_o).getCheckBoxImages();
    if (_r2_o == null) goto label54;
    _r3.i = ((global::com.codename1.ui.CheckBox) _r6_o).isSelected() ? 1 : 0;
    if (_r3.i == 0) goto label51;
    _r3.i = 1;
    _r0.i = _r3.i;
    label39:;
    _r3.i = base.getAvaliableSpaceForText();
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    _r4.i = ((global::com.codename1.ui.Image) _r4_o).getWidth();
    _r3.i = _r3.i - _r4.i;
    goto label10;
    label51:;
    _r3.i = 0;
    _r0.i = _r3.i;
    goto label39;
    label54:;
    _r3.i = base.getAvaliableSpaceForText();
    _r4.i = ((global::com.codename1.ui.CheckBox) _r6_o).getHeight();
    _r5.i = ((global::com.codename1.ui.CheckBox) _r6_o).getGap();
    _r4.i = _r4.i + _r5.i;
    _r3.i = _r3.i - _r4.i;
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: int getAvaliableSpaceForText()]
}

public override bool isOppositeSide(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: boolean isOppositeSide()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.CheckBox) _r1_o)._foppositeSide ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: boolean isOppositeSide()]
}

public virtual void setOppositeSide(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void setOppositeSide(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.CheckBox) _r0_o)._foppositeSide = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void setOppositeSide(boolean)]
}

public override global::System.Object getBindablePropertyNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: java.lang.String[] getBindablePropertyNames()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=selected
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: java.lang.String[] getBindablePropertyNames()]
}

public override global::System.Object getBindablePropertyTypes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: java.lang.Class[] getBindablePropertyTypes()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Boolean));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: java.lang.Class[] getBindablePropertyTypes()]
}

public override void bindProperty(global::java.lang.String n1, global::com.codename1.cloud.BindTarget n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void bindProperty(java.lang.String, com.codename1.cloud.BindTarget)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    // Value=selected
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label25;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners;
    if (_r0_o != null) goto label19;
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    label19:;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).addListener((global::java.lang.Object) _r3_o);
    label24:;
    return;
    label25:;
    base.bindProperty((global::java.lang.String) _r2_o, (global::com.codename1.cloud.BindTarget) _r3_o);
    goto label24;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void bindProperty(java.lang.String, com.codename1.cloud.BindTarget)]
}

public override void unbindProperty(global::java.lang.String n1, global::com.codename1.cloud.BindTarget n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void unbindProperty(java.lang.String, com.codename1.cloud.BindTarget)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    // Value=selected
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label30;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners;
    if (_r0_o != null) goto label13;
    label12:;
    return;
    label13:;
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).removeListener((global::java.lang.Object) _r3_o);
    _r0_o = ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners;
    _r0.i = ((global::com.codename1.ui.util.EventDispatcher) _r0_o).hasListeners() ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0_o = null;
    ((global::com.codename1.ui.CheckBox) _r1_o)._fbindListeners = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    goto label12;
    label30:;
    base.unbindProperty((global::java.lang.String) _r2_o, (global::com.codename1.cloud.BindTarget) _r3_o);
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void unbindProperty(java.lang.String, com.codename1.cloud.BindTarget)]
}

public override global::System.Object getBoundPropertyValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: java.lang.Object getBoundPropertyValue(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=selected
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label20;
    _r0.i = ((global::com.codename1.ui.CheckBox) _r1_o).isSelected() ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r0_o = global::java.lang.Boolean._fTRUE;
    label16:;
    return (global::java.lang.Object) _r0_o;
    label17:;
    _r0_o = global::java.lang.Boolean._fFALSE;
    goto label16;
    label20:;
    _r0_o = base.getBoundPropertyValue((global::java.lang.String) _r2_o);
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: java.lang.Object getBoundPropertyValue(java.lang.String)]
}

public override void setBoundPropertyValue(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox: void setBoundPropertyValue(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    // Value=selected
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label25;
    if (_r3_o == null) goto label23;
    _r3_o = _r3_o;
    _r0.i = ((global::java.lang.Boolean) _r3_o).booleanValue() ? 1 : 0;
    if (_r0.i == 0) goto label23;
    _r0.i = 1;
    label19:;
    ((global::com.codename1.ui.CheckBox) _r1_o).setSelected(0!=_r0.i);
    label22:;
    return;
    label23:;
    _r0.i = 0;
    goto label19;
    label25:;
    base.setBoundPropertyValue((global::java.lang.String) _r2_o, (global::java.lang.Object) _r3_o);
    goto label22;
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox: void setBoundPropertyValue(java.lang.String, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.CheckBox]
//XMLVM_END_WRAPPER[com.codename1.ui.CheckBox]

} // end of class: CheckBox

} // end of namespace: com.codename1.ui
