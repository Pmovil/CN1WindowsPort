// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_24: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::org.xmlvm._nArrayAdapter<bool> _fval_2hasSideMenus;

public global::com.codename1.ui.SideMenuBar _fthis_20;

public void @this(global::com.codename1.ui.SideMenuBar n1, global::org.xmlvm._nArrayAdapter<bool> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$4: void <init>(com.codename1.ui.SideMenuBar, boolean[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.SideMenuBar_24) _r0_o)._fthis_20 = (global::com.codename1.ui.SideMenuBar) _r1_o;
    ((global::com.codename1.ui.SideMenuBar_24) _r0_o)._fval_2hasSideMenus = (global::org.xmlvm._nArrayAdapter<bool>) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$4: void <init>(com.codename1.ui.SideMenuBar, boolean[])]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$4: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    _r13_o = this;
    _r14_o = n1;
    _r11.i = 10;
    _r10.i = 1;
    _r9.i = 0;
    // Value=sideSwipeSensitiveInt
    _r12_o = new global::java.lang.String();
    ((global::java.lang.String)_r12_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    global::com.codename1.ui.SideMenuBar.access_2302((global::com.codename1.ui.SideMenuBar) _r4_o, 0!=_r9.i);
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    global::com.codename1.ui.SideMenuBar.access_2402((global::com.codename1.ui.SideMenuBar) _r4_o, 0!=_r9.i);
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    ((global::com.codename1.ui.SideMenuBar) _r4_o)._fsideSwipePotential = 0!=_r9.i;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4.i = ((global::com.codename1.ui.SideMenuBar) _r4_o).getCommandCount();
    if (_r4.i != 0) goto label29;
    label28:;
    return;
    label29:;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r4_o);
    _r4.i = ((global::com.codename1.ui.Form) _r4_o).getCommandCount();
    if (_r4.i != _r10.i) goto label63;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r4_o);
    _r4_o = ((global::com.codename1.ui.Form) _r4_o).getCommand((int) _r9.i);
    _r5_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r5_o);
    _r5_o = ((global::com.codename1.ui.Form) _r5_o).getBackCommand();
    if (_r4_o == _r5_o) goto label28;
    label63:;
    _r2.i = 0;
    label64:;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4.i = ((global::com.codename1.ui.SideMenuBar) _r4_o).getCommandCount();
    if (_r2.i >= _r4.i) goto label108;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r0_o = ((global::com.codename1.ui.SideMenuBar) _r4_o).getCommand((int) _r2.i);
    // Value=placement
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r3_o = ((global::com.codename1.ui.Command) _r0_o).getClientProperty((global::java.lang.String) _r4_o);
    if (_r3_o != null) goto label95;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fval_2hasSideMenus;
    ((global::org.xmlvm._nArrayAdapter<bool>) _r4_o)[_r9.i] = 0!=_r10.i;
    label92:;
    _r2.i = _r2.i + 1;
    goto label64;
    label95:;
    // Value=right
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 116))}));
    _r4.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label92;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fval_2hasSideMenus;
    ((global::org.xmlvm._nArrayAdapter<bool>) _r4_o)[_r10.i] = 0!=_r10.i;
    goto label92;
    label108:;
    _r4_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r4_o).getDisplayWidth();
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4_o = global::com.codename1.ui.SideMenuBar.access_2500((global::com.codename1.ui.SideMenuBar) _r4_o);
    if (_r4_o == null) goto label158;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.SideMenuBar) _r5_o)._ftransitionRunning ? 1 : 0;
    if (_r5.i != 0) goto label310;
    _r5.i = ((global::com.codename1.ui.events.ActionEvent) _r14_o).getX();
    _r6_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r6_o = ((global::com.codename1.ui.SideMenuBar) _r6_o).getUIManager();
    // Value=sideSwipeSensitiveInt
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r6.i = ((global::com.codename1.ui.plaf.UIManager) _r6_o).getThemeConstant((global::java.lang.String) _r12_o, (int) _r11.i);
    _r6.i = _r1.i / _r6.i;
    _r6.i = _r1.i - _r6.i;
    if (_r5.i <= _r6.i) goto label310;
    _r5.i = _r10.i;
    label155:;
    global::com.codename1.ui.SideMenuBar.access_2302((global::com.codename1.ui.SideMenuBar) _r4_o, 0!=_r5.i);
    label158:;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.SideMenuBar) _r4_o).getTitleComponent();
    _r4.i = ((_r4_o != null) && (_r4_o is global::com.codename1.ui.Button)) ? 1 : 0;
    if (_r4.i == 0) goto label207;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.SideMenuBar) _r5_o)._ftransitionRunning ? 1 : 0;
    if (_r5.i != 0) goto label313;
    _r5.i = ((global::com.codename1.ui.events.ActionEvent) _r14_o).getY();
    _r6_o = global::com.codename1.ui.Display.getInstance();
    _r6.i = ((global::com.codename1.ui.Display) _r6_o).getDisplayHeight();
    _r7_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r7_o = ((global::com.codename1.ui.SideMenuBar) _r7_o).getUIManager();
    // Value=sideSwipeSensitiveInt
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r7.i = ((global::com.codename1.ui.plaf.UIManager) _r7_o).getThemeConstant((global::java.lang.String) _r12_o, (int) _r11.i);
    _r6.i = _r6.i / _r7.i;
    if (_r5.i >= _r6.i) goto label313;
    _r5.i = _r10.i;
    label204:;
    global::com.codename1.ui.SideMenuBar.access_2402((global::com.codename1.ui.SideMenuBar) _r4_o, 0!=_r5.i);
    label207:;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.SideMenuBar) _r5_o)._ftransitionRunning ? 1 : 0;
    if (_r5.i != 0) goto label315;
    _r5.i = ((global::com.codename1.ui.events.ActionEvent) _r14_o).getX();
    _r6_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r6_o = ((global::com.codename1.ui.SideMenuBar) _r6_o).getUIManager();
    // Value=sideSwipeSensitiveInt
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r6.i = ((global::com.codename1.ui.plaf.UIManager) _r6_o).getThemeConstant((global::java.lang.String) _r12_o, (int) _r11.i);
    _r6.i = _r1.i / _r6.i;
    if (_r5.i >= _r6.i) goto label315;
    _r5.i = _r10.i;
    label236:;
    ((global::com.codename1.ui.SideMenuBar) _r4_o)._fsideSwipePotential = 0!=_r5.i;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.events.ActionEvent) _r14_o).getX();
    ((global::com.codename1.ui.SideMenuBar) _r4_o)._finitialDragX = _r5.i;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.events.ActionEvent) _r14_o).getY();
    ((global::com.codename1.ui.SideMenuBar) _r4_o)._finitialDragY = _r5.i;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4.i = ((global::com.codename1.ui.SideMenuBar) _r4_o)._fsideSwipePotential ? 1 : 0;
    if (_r4.i != 0) goto label276;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4.i = global::com.codename1.ui.SideMenuBar.access_2300((global::com.codename1.ui.SideMenuBar) _r4_o) ? 1 : 0;
    if (_r4.i != 0) goto label276;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r4.i = global::com.codename1.ui.SideMenuBar.access_2400((global::com.codename1.ui.SideMenuBar) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label28;
    label276:;
    _r4_o = global::com.codename1.ui.Display.getInstance();
    _r4_o = ((global::com.codename1.ui.Display) _r4_o).getCurrent();
    _r5_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r5.i = ((global::com.codename1.ui.SideMenuBar) _r5_o)._finitialDragX;
    _r6_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    _r6.i = ((global::com.codename1.ui.SideMenuBar) _r6_o)._finitialDragY;
    _r0_o = ((global::com.codename1.ui.Form) _r4_o).getComponentAt((int) _r5.i, (int) _r6.i);
    if (_r0_o == null) goto label28;
    _r4.i = ((global::com.codename1.ui.Component) _r0_o).shouldBlockSideSwipe() ? 1 : 0;
    if (_r4.i == 0) goto label28;
    _r4_o = ((global::com.codename1.ui.SideMenuBar_24) _r13_o)._fthis_20;
    ((global::com.codename1.ui.SideMenuBar) _r4_o)._fsideSwipePotential = 0!=_r9.i;
    goto label28;
    label310:;
    _r5.i = _r9.i;
    goto label155;
    label313:;
    _r5.i = _r9.i;
    goto label204;
    label315:;
    _r5.i = _r9.i;
    goto label236;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$4: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$4]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$4]

} // end of class: SideMenuBar_24

} // end of namespace: com.codename1.ui
