// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.list {
public class GenericListCellRenderer_2Monitor: global::java.lang.Object,global::com.codename1.ui.events.ActionListener,global::com.codename1.ui.animations.Animation {
private bool _fselectAllChecked;

private int _fselectAllOffset;

public global::com.codename1.ui.list.GenericListCellRenderer _fthis_20;

public void @this(global::com.codename1.ui.list.GenericListCellRenderer n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: void <init>(com.codename1.ui.list.GenericListCellRenderer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r0_o)._fthis_20 = (global::com.codename1.ui.list.GenericListCellRenderer) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: void <init>(com.codename1.ui.list.GenericListCellRenderer)]
}

public virtual bool animate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: boolean animate()]
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
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r10.i = 0;
    _r1.i = 0;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    if (_r8_o == null) goto label259;
    _r5.i = 0;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2100((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    if (_r8_o == null) goto label83;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2100((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r8.i = ((global::java.util.ArrayList) _r8_o).size();
    if (_r8.i <= 0) goto label83;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2100((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r6.i = ((global::java.util.ArrayList) _r8_o).size();
    _r1.i = 1;
    _r3.i = 0;
    label43:;
    if (_r3.i >= _r6.i) goto label72;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2100((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r2_o = ((global::java.util.ArrayList) _r8_o).get((int) _r3.i);
    _r2_o = _r2_o;
    _r8.i = ((global::com.codename1.ui.Image) _r2_o).animate() ? 1 : 0;
    if (_r8.i != 0) goto label65;
    if (_r5.i == 0) goto label70;
    label65:;
    _r8.i = 1;
    _r5.i = _r8.i;
    label67:;
    _r3.i = _r3.i + 1;
    goto label43;
    label70:;
    _r5.i = _r10.i;
    goto label67;
    label72:;
    if (_r5.i == 0) goto label168;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2100((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    ((global::java.util.ArrayList) _r8_o).clear();
    label83:;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r0_o = ((global::com.codename1.ui.Component) _r8_o).getComponentForm();
    if (_r0_o == null) goto label248;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r8.i = ((global::com.codename1.ui.Component) _r8_o).hasFocus() ? 1 : 0;
    if (_r8.i == 0) goto label184;
    _r8_o = global::com.codename1.ui.Display.getInstance();
    _r9_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r9_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r9_o);
    _r8.i = ((global::com.codename1.ui.Display) _r8_o).shouldRenderSelection((global::com.codename1.ui.Component) _r9_o) ? 1 : 0;
    if (_r8.i == 0) goto label184;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r7.i = ((global::org.xmlvm._nIArray) _r8_o).Length;
    _r3.i = 0;
    label131:;
    if (_r3.i >= _r7.i) goto label229;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r8_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r3.i];
    _r8.i = ((_r8_o != null) && (_r8_o is global::com.codename1.ui.Label)) ? 1 : 0;
    if (_r8.i == 0) goto label165;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r3.i];
    _r4_o = _r4_o;
    _r8.i = ((global::com.codename1.ui.Label) _r4_o).isTickerRunning() ? 1 : 0;
    if (_r8.i == 0) goto label165;
    _r5.i = 1;
    ((global::com.codename1.ui.Label) _r4_o).animate();
    label165:;
    _r3.i = _r3.i + 1;
    goto label131;
    label168:;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2100((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r8.i = ((global::java.util.ArrayList) _r8_o).size();
    _r9.i = 20;
    if (_r8.i <= _r9.i) goto label83;
    _r5.i = 1;
    goto label83;
    label184:;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r7.i = ((global::org.xmlvm._nIArray) _r8_o).Length;
    _r3.i = 0;
    label192:;
    if (_r3.i >= _r7.i) goto label229;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r8_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r3.i];
    _r8.i = ((_r8_o != null) && (_r8_o is global::com.codename1.ui.Label)) ? 1 : 0;
    if (_r8.i == 0) goto label226;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r3.i];
    _r4_o = _r4_o;
    _r8.i = ((global::com.codename1.ui.Label) _r4_o).isTickerRunning() ? 1 : 0;
    if (_r8.i == 0) goto label226;
    ((global::com.codename1.ui.Label) _r4_o).stopTicker();
    _r5.i = 1;
    label226:;
    _r3.i = _r3.i + 1;
    goto label192;
    label229:;
    if (_r5.i == 0) goto label242;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    ((global::com.codename1.ui.Component) _r8_o).repaint();
    label240:;
    _r8.i = _r10.i;
    label241:;
    return _r8.i!=0;
    label242:;
    if (_r1.i != 0) goto label240;
    ((global::com.codename1.ui.Form) _r0_o).deregisterAnimated((global::com.codename1.ui.animations.Animation) _r11_o);
    goto label240;
    label248:;
    if (_r5.i == 0) goto label259;
    _r8_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r11_o)._fthis_20;
    _r8_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r8_o);
    ((global::com.codename1.ui.Component) _r8_o).repaint();
    label259:;
    _r8.i = _r10.i;
    goto label241;
//XMLVM_END_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: boolean animate()]
}

public virtual void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: void paint(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: void paint(com.codename1.ui.Graphics)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r15_o = this;
    _r16_o = n1;
    _r12_o = ((global::com.codename1.ui.events.ActionEvent) _r16_o).getComponent();
    _r12.i = ((_r12_o != null) && (_r12_o is global::com.codename1.ui.Button)) ? 1 : 0;
    if (_r12.i == 0) goto label20;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r15_o = ((global::com.codename1.ui.events.ActionEvent) _r16_o).getComponent();
    _r15_o = _r15_o;
    global::com.codename1.ui.list.GenericListCellRenderer.access_2302((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o, (global::com.codename1.ui.Button) _r15_o);
    label19:;
    return;
    label20:;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12.i = ((_r12_o != null) && (_r12_o is global::com.codename1.ui.List)) ? 1 : 0;
    if (_r12.i == 0) goto label19;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r13.i = 1;
    ((global::com.codename1.ui.Component) _r12_o).setHandlesInput(0!=_r13.i);
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r16_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r16_o = _r16_o;
    _r8_o = ((global::com.codename1.ui.List) _r16_o).getSelectedItem();
    _r12.i = ((_r8_o != null) && (_r8_o is global::java.util.Map)) ? 1 : 0;
    if (_r12.i == 0) goto label19;
    _r0_o = _r8_o;
    _r0_o = _r0_o;
    _r3_o = _r0_o;
    // Value=$navigation
    _r12_o = new global::java.lang.String();
    ((global::java.lang.String)_r12_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r1_o = ((global::java.util.Map) _r3_o).get((global::java.lang.Object) _r12_o);
    _r1_o = _r1_o;
    if (_r1_o == null) goto label91;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12_o = ((global::com.codename1.ui.Component) _r12_o).getComponentForm();
    _r13_o = new global::com.codename1.ui.events.ActionEvent();
    _r14_o = global::com.codename1.ui.events.ActionEvent_2Type._fCommand;
    ((global::com.codename1.ui.events.ActionEvent) _r13_o).@this((global::java.lang.Object) _r1_o, (global::com.codename1.ui.events.ActionEvent_2Type) _r14_o);
    ((global::com.codename1.ui.Form) _r12_o).dispatchCommand((global::com.codename1.ui.Command) _r1_o, (global::com.codename1.ui.events.ActionEvent) _r13_o);
    goto label19;
    label91:;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r10.i = ((global::org.xmlvm._nIArray) _r12_o).Length;
    _r4.i = 0;
    label99:;
    if (_r4.i >= _r10.i) goto label19;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r4.i];
    _r12.i = ((_r12_o != null) && (_r12_o is global::com.codename1.ui.CheckBox)) ? 1 : 0;
    if (_r12.i != 0) goto label125;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r4.i];
    _r12.i = ((_r12_o != null) && (_r12_o is global::com.codename1.ui.RadioButton)) ? 1 : 0;
    if (_r12.i == 0) goto label336;
    label125:;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r13_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r13_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r13_o);
    _r13_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r13_o)[_r4.i];
    _r13_o = ((global::com.codename1.ui.Component) _r13_o).getName();
    _r13_o = ((global::java.util.Map) _r3_o).get((global::java.lang.Object) _r13_o);
    _r12.i = global::com.codename1.ui.list.GenericListCellRenderer.access_2400((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o, (global::java.lang.Object) _r13_o) ? 1 : 0;
    if (_r12.i != 0) goto label253;
    _r12.i = 1;
    _r6.i = _r12.i;
    label151:;
    // Value=$$SELECTALL$$
    _r12_o = new global::java.lang.String();
    ((global::java.lang.String)_r12_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 36)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 36)), unchecked((char) unchecked((uint) 36))}));
    _r12_o = ((global::java.util.Map) _r3_o).get((global::java.lang.Object) _r12_o);
    if (_r12_o == null) goto label256;
    ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fselectAllChecked = 0!=_r6.i;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r16_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r16_o = _r16_o;
    _r12.i = ((global::com.codename1.ui.List) _r16_o).getSelectedIndex();
    ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fselectAllOffset = _r12.i;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r16_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r16_o = _r16_o;
    _r12_o = ((global::com.codename1.ui.List) _r16_o).getModel();
    _r2.i = ((global::com.codename1.ui.list.ListModel) _r12_o).getSize();
    _r12_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r12_o).@this();
    // Value=
    _r13_o = new global::java.lang.String();
    ((global::java.lang.String)_r13_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r12_o = ((global::java.lang.StringBuilder) _r12_o).append((global::java.lang.String) _r13_o);
    _r12_o = ((global::java.lang.StringBuilder) _r12_o).append(0!=_r6.i);
    _r9_o = ((global::java.lang.StringBuilder) _r12_o).toString();
    _r11.i = 0;
    label211:;
    if (_r11.i >= _r2.i) goto label19;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r16_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r16_o = _r16_o;
    _r12_o = ((global::com.codename1.ui.List) _r16_o).getModel();
    _r5_o = ((global::com.codename1.ui.list.ListModel) _r12_o).getItemAt((int) _r11.i);
    _r12.i = ((_r5_o != null) && (_r5_o is global::java.util.Map)) ? 1 : 0;
    if (_r12.i == 0) goto label250;
    _r5_o = _r5_o;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r4.i];
    _r12_o = ((global::com.codename1.ui.Component) _r12_o).getName();
    ((global::java.util.Map) _r5_o).put((global::java.lang.Object) _r12_o, (global::java.lang.Object) _r9_o);
    label250:;
    _r11.i = _r11.i + 1;
    goto label211;
    label253:;
    _r12.i = 0;
    _r6.i = _r12.i;
    goto label151;
    label256:;
    _r12.i = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fselectAllChecked ? 1 : 0;
    if (_r12.i == 0) goto label300;
    _r12.i = 0;
    ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fselectAllChecked = 0!=_r12.i;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r16_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2000((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r16_o = _r16_o;
    _r12_o = ((global::com.codename1.ui.List) _r16_o).getModel();
    _r13.i = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fselectAllOffset;
    _r7_o = ((global::com.codename1.ui.list.ListModel) _r12_o).getItemAt((int) _r13.i);
    _r7_o = _r7_o;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r4.i];
    _r12_o = ((global::com.codename1.ui.Component) _r12_o).getName();
    // Value=false
    _r13_o = new global::java.lang.String();
    ((global::java.lang.String)_r13_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.util.Map) _r7_o).put((global::java.lang.Object) _r12_o, (global::java.lang.Object) _r13_o);
    label300:;
    _r12_o = ((global::com.codename1.ui.list.GenericListCellRenderer_2Monitor) _r15_o)._fthis_20;
    _r12_o = global::com.codename1.ui.list.GenericListCellRenderer.access_2200((global::com.codename1.ui.list.GenericListCellRenderer) _r12_o);
    _r12_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r4.i];
    _r12_o = ((global::com.codename1.ui.Component) _r12_o).getName();
    _r13_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r13_o).@this();
    // Value=
    _r14_o = new global::java.lang.String();
    ((global::java.lang.String)_r14_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r13_o = ((global::java.lang.StringBuilder) _r13_o).append((global::java.lang.String) _r14_o);
    _r13_o = ((global::java.lang.StringBuilder) _r13_o).append(0!=_r6.i);
    _r13_o = ((global::java.lang.StringBuilder) _r13_o).toString();
    ((global::java.util.Map) _r3_o).put((global::java.lang.Object) _r12_o, (global::java.lang.Object) _r13_o);
    goto label19;
    label336:;
    _r4.i = _r4.i + 1;
    goto label99;
//XMLVM_END_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor]
//XMLVM_END_WRAPPER[com.codename1.ui.list.GenericListCellRenderer$Monitor]

} // end of class: GenericListCellRenderer_2Monitor

} // end of namespace: com.codename1.ui.list
