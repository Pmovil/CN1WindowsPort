// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class MultiComboBox: global::com.codename1.ui.List {
private bool _fmultiple;

private global::com.codename1.ui.html.MultiComboBox_2MultiListModel _fmodel;

public void @this(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void <init>(boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0_o = null;
    ((global::com.codename1.ui.html.MultiComboBox) _r1_o).@this((global::com.codename1.ui.list.ListModel) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void <init>(boolean)]
}

public void @this(global::com.codename1.ui.list.ListModel n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void <init>(com.codename1.ui.list.ListModel, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2 ? 1 : 0;
    _r5.i = 1;
    ((global::com.codename1.ui.List) _r6_o).@this();
    // Value=ComboBox
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120))}));
    ((global::com.codename1.ui.html.MultiComboBox) _r6_o).setUIID((global::java.lang.String) _r4_o);
    ((global::com.codename1.ui.html.MultiComboBox) _r6_o)._fmultiple = 0!=_r8.i;
    if (_r8.i != 0) goto label108;
    _r4.i = _r5.i;
    label14:;
    ((global::com.codename1.ui.html.MultiComboBox) _r6_o).setScrollToSelected(0!=_r4.i);
    _r4_o = new global::com.codename1.ui.html.MultiComboBox_2MultiListModel();
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).@this((global::com.codename1.ui.html.MultiComboBox) _r6_o, (global::com.codename1.ui.list.ListModel) _r7_o, 0!=_r8.i);
    ((global::com.codename1.ui.html.MultiComboBox) _r6_o)._fmodel = (global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r6_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox) _r6_o).setModel((global::com.codename1.ui.list.ListModel) _r4_o);
    _r2_o = new global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer();
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r6_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r2_o).@this((global::com.codename1.ui.html.MultiComboBox) _r6_o, (global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o);
    ((global::com.codename1.ui.html.MultiComboBox) _r6_o).setRenderer((global::com.codename1.ui.list.ListCellRenderer) _r2_o);
    if (_r7_o == null) goto label59;
    _r1.i = 0;
    label42:;
    _r4.i = ((global::com.codename1.ui.list.ListModel) _r7_o).getSize();
    if (_r1.i >= _r4.i) goto label59;
    _r4_o = ((global::com.codename1.ui.list.ListModel) _r7_o).getItemAt((int) _r1.i);
    _r4.i = ((_r4_o != null) && (_r4_o is global::java.lang.String)) ? 1 : 0;
    if (_r4.i == 0) goto label110;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r2_o).setOptgroup(0!=_r5.i);
    label59:;
    _r3_o = ((global::com.codename1.ui.html.MultiComboBox) _r6_o).getRenderer();
    _r4.i = ((_r3_o != null) && (_r3_o is global::com.codename1.ui.Component)) ? 1 : 0;
    if (_r4.i == 0) goto label92;
    _r0_o = ((global::com.codename1.ui.html.MultiComboBox) _r6_o).getRenderer();
    _r0_o = _r0_o;
    // Value=ComboBoxItem
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    ((global::com.codename1.ui.Component) _r0_o).setUIID((global::java.lang.String) _r4_o);
    _r4_o = ((global::com.codename1.ui.Component) _r0_o).getSelectedStyle();
    ((global::com.codename1.ui.plaf.Style) _r4_o).setPadding((int) _r5.i, (int) _r5.i, (int) _r5.i, (int) _r5.i);
    _r4_o = ((global::com.codename1.ui.Component) _r0_o).getUnselectedStyle();
    ((global::com.codename1.ui.plaf.Style) _r4_o).setPadding((int) _r5.i, (int) _r5.i, (int) _r5.i, (int) _r5.i);
    label92:;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r6_o).getRenderer();
    _r0_o = ((global::com.codename1.ui.list.ListCellRenderer) _r4_o).getListFocusComponent((global::com.codename1.ui.List) _r6_o);
    if (_r0_o == null) goto label107;
    // Value=ComboBoxFocus
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115))}));
    ((global::com.codename1.ui.Component) _r0_o).setUIID((global::java.lang.String) _r4_o);
    label107:;
    return;
    label108:;
    _r4.i = 0;
    goto label14;
    label110:;
    _r1.i = _r1.i + 1;
    goto label42;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void <init>(com.codename1.ui.list.ListModel, boolean)]
}

public virtual global::System.Object getSelected(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: java.util.Vector getSelected()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox) _r2_o)._fmultiple ? 1 : 0;
    if (_r1.i == 0) goto label13;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox) _r2_o)._fmodel;
    if (_r1_o == null) goto label33;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox) _r2_o)._fmodel;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r1_o)._fselected;
    label12:;
    return (global::java.util.Vector) _r1_o;
    label13:;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox) _r2_o).getSelectedItem();
    if (_r1_o == null) goto label33;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox) _r2_o).getSelectedItem();
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r1_o);
    _r1_o = _r0_o;
    goto label12;
    label33:;
    _r1_o = null;
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: java.util.Vector getSelected()]
}

public override void addItem(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void addItem(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    base.addItem((global::java.lang.Object) _r2_o);
    _r0.i = ((_r2_o != null) && (_r2_o is global::java.lang.String)) ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox) _r1_o).getRenderer();
    _r1_o = _r1_o;
    _r0.i = 1;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r1_o).setOptgroup(0!=_r0.i);
    label17:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void addItem(java.lang.Object)]
}

public override void setSelectedItem(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void setSelectedItem(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    base.setSelectedItem((global::java.lang.Object) _r2_o);
    _r0_o = ((global::com.codename1.ui.html.MultiComboBox) _r1_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r0_o).toggleSelected((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void setSelectedItem(java.lang.Object)]
}

public override void fireActionEvent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void fireActionEvent()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox) _r2_o)._fmultiple ? 1 : 0;
    if (_r1.i == 0) goto label14;
    _r0_o = ((global::com.codename1.ui.html.MultiComboBox) _r2_o).getSelectedItem();
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox) _r2_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r1_o).toggleSelected((global::java.lang.Object) _r0_o);
    label13:;
    return;
    label14:;
    base.fireActionEvent();
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void fireActionEvent()]
}

public override void keyReleased(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void keyReleased(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r2_o).getGameAction((int) _r4.i);
    _r2.i = ((global::com.codename1.ui.html.MultiComboBox) _r3_o)._fmultiple ? 1 : 0;
    if (_r2.i == 0) goto label29;
    _r2.i = 8;
    if (_r0.i != _r2.i) goto label29;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox) _r3_o).handlesInput() ? 1 : 0;
    if (_r1.i == 0) goto label25;
    ((global::com.codename1.ui.html.MultiComboBox) _r3_o).fireActionEvent();
    label25:;
    ((global::com.codename1.ui.html.MultiComboBox) _r3_o).repaint();
    label28:;
    return;
    label29:;
    base.keyReleased((int) _r4.i);
    goto label28;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void keyReleased(int)]
}

public override void fireClicked(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void fireClicked()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::com.codename1.ui.html.MultiComboBox) _r2_o).handlesInput() ? 1 : 0;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox) _r2_o)._fmultiple ? 1 : 0;
    if (_r1.i != 0) goto label14;
    if (_r0.i != 0) goto label23;
    _r1.i = 1;
    label11:;
    ((global::com.codename1.ui.html.MultiComboBox) _r2_o).setHandlesInput(0!=_r1.i);
    label14:;
    if (_r0.i == 0) goto label19;
    ((global::com.codename1.ui.html.MultiComboBox) _r2_o).fireActionEvent();
    label19:;
    ((global::com.codename1.ui.html.MultiComboBox) _r2_o).repaint();
    return;
    label23:;
    _r1.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void fireClicked()]
}

public override void keyPressed(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox: void keyPressed(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    _r9_o = this;
    _r10.i = n1;
    _r8.i = 2;
    _r7.i = 0;
    _r6.i = 1;
    _r4.i = ((global::com.codename1.ui.html.MultiComboBox) _r9_o).handlesInput() ? 1 : 0;
    if (_r4.i != 0) goto label10;
    label9:;
    return;
    label10:;
    _r4_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r4_o).getGameAction((int) _r10.i);
    _r4.i = ((global::com.codename1.ui.html.MultiComboBox) _r9_o).getOrientation();
    if (_r4.i == _r6.i) goto label80;
    _r2.i = 6;
    _r1.i = 1;
    if (_r0.i == _r8.i) goto label31;
    _r4.i = 5;
    if (_r0.i != _r4.i) goto label34;
    label31:;
    ((global::com.codename1.ui.html.MultiComboBox) _r9_o).setHandlesInput(0!=_r7.i);
    label34:;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    _r3.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).getSelectedIndex();
    if (_r0.i != _r1.i) goto label100;
    if (_r3.i <= 0) goto label71;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    _r5.i = _r3.i - _r6.i;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).getItemAt((int) _r5.i);
    _r4.i = ((_r4_o != null) && (_r4_o is global::java.lang.String)) ? 1 : 0;
    if (_r4.i == 0) goto label71;
    if (_r3.i == _r6.i) goto label9;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    _r5.i = -1;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).setDirection((int) _r5.i);
    _r3.i = _r3.i + -1;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).setSelectedIndex((int) _r3.i);
    label71:;
    base.keyPressed((int) _r10.i);
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).setDirection((int) _r7.i);
    goto label9;
    label80:;
    _r4.i = ((global::com.codename1.ui.html.MultiComboBox) _r9_o).isRTL() ? 1 : 0;
    if (_r4.i == 0) goto label97;
    _r2.i = 2;
    _r1.i = 5;
    label88:;
    _r4.i = 6;
    if (_r0.i == _r4.i) goto label93;
    if (_r0.i != _r6.i) goto label34;
    label93:;
    ((global::com.codename1.ui.html.MultiComboBox) _r9_o).setHandlesInput(0!=_r7.i);
    goto label34;
    label97:;
    _r2.i = 5;
    _r1.i = 2;
    goto label88;
    label100:;
    if (_r0.i != _r2.i) goto label71;
    _r4.i = ((global::com.codename1.ui.html.MultiComboBox) _r9_o).size();
    _r4.i = _r4.i - _r6.i;
    if (_r3.i >= _r4.i) goto label71;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    _r5.i = _r3.i + 1;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).getItemAt((int) _r5.i);
    _r4.i = ((_r4_o != null) && (_r4_o is global::java.lang.String)) ? 1 : 0;
    if (_r4.i == 0) goto label71;
    _r4.i = ((global::com.codename1.ui.html.MultiComboBox) _r9_o).size();
    _r4.i = _r4.i - _r8.i;
    if (_r3.i == _r4.i) goto label9;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).setDirection((int) _r6.i);
    _r3.i = _r3.i + 1;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox) _r9_o)._fmodel;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o).setSelectedIndex((int) _r3.i);
    goto label71;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox: void keyPressed(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox]
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox]

} // end of class: MultiComboBox

} // end of namespace: com.codename1.ui.html
