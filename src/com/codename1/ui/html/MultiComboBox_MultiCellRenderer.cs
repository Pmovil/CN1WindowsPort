// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class MultiComboBox_2MultiCellRenderer: global::com.codename1.ui.list.DefaultListCellRenderer {
private global::com.codename1.ui.html.MultiComboBox_2MultiListModel _fmodel;

private bool _foptgroup;

private int _fbgColor;

private int _ffgColor;

public global::com.codename1.ui.html.MultiComboBox _fthis_20;

public void @this(global::com.codename1.ui.html.MultiComboBox n1, global::com.codename1.ui.html.MultiComboBox_2MultiListModel n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: void <init>(com.codename1.ui.html.MultiComboBox, com.codename1.ui.html.MultiComboBox$MultiListModel)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r1.i = -1;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r2_o)._fthis_20 = (global::com.codename1.ui.html.MultiComboBox) _r3_o;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListCellRenderer) _r2_o).@this(0!=_r0.i);
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r2_o)._fbgColor = _r1.i;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r2_o)._ffgColor = _r1.i;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r2_o)._fmodel = (global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r4_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: void <init>(com.codename1.ui.html.MultiComboBox, com.codename1.ui.html.MultiComboBox$MultiListModel)]
}

public virtual void setOptgroup(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: void setOptgroup(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r0_o)._foptgroup = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: void setOptgroup(boolean)]
}

public override global::System.Object getListCellRendererComponent(global::com.codename1.ui.List n1, global::java.lang.Object n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3;
    _r7.i = n4 ? 1 : 0;
    _r2.i = -1;
    _r0_o = base.getListCellRendererComponent((global::com.codename1.ui.List) _r4_o, (global::java.lang.Object) _r5_o, (int) _r6.i, 0!=_r7.i);
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._fmodel;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiListModel) _r1_o).isSelected((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r1.i == 0) goto label74;
    // Value=HTMLMultiComboBoxItem
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).setUIID((global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).getUnselectedStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getFgColor();
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._ffgColor = _r1.i;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).getUnselectedStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getBgColor();
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._fbgColor = _r1.i;
    label38:;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._foptgroup ? 1 : 0;
    if (_r1.i == 0) goto label51;
    _r1.i = ((_r5_o != null) && (_r5_o is global::java.lang.String)) ? 1 : 0;
    if (_r1.i == 0) goto label84;
    // Value=HTMLOptgroup
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112))}));
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).setUIID((global::java.lang.String) _r1_o);
    label51:;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._ffgColor;
    if (_r1.i == _r2.i) goto label73;
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).getSelectedStyle();
    _r2.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._ffgColor;
    ((global::com.codename1.ui.plaf.Style) _r1_o).setFgColor((int) _r2.i);
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).getUnselectedStyle();
    _r2.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._ffgColor;
    ((global::com.codename1.ui.plaf.Style) _r1_o).setFgColor((int) _r2.i);
    label73:;
    return (global::com.codename1.ui.Component) _r0_o;
    label74:;
    // Value=ComboBoxItem
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).setUIID((global::java.lang.String) _r1_o);
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._fbgColor = _r2.i;
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o)._ffgColor = _r2.i;
    goto label38;
    label84:;
    // Value=HTMLOptgroupItem
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r3_o).setUIID((global::java.lang.String) _r1_o);
    goto label51;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
}

public override void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: void paint(com.codename1.ui.Graphics)]
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
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r4.i = 1;
    _r5.i = 0;
    _r0.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).hasFocus() ? 1 : 0;
    if (_r0.i == 0) goto label43;
    _r0_o = null;
    _r0_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getListFocusComponent((global::com.codename1.ui.List) _r0_o);
    _r0_o = ((global::com.codename1.ui.Component) _r0_o).getSelectedStyle();
    _r0.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getBgColor();
    ((global::com.codename1.ui.Graphics) _r7_o).setColor((int) _r0.i);
    _r0.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getX();
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getY();
    _r2.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getWidth();
    _r3.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getHeight();
    ((global::com.codename1.ui.Graphics) _r7_o).fillRect((int) _r0.i, (int) _r1.i, (int) _r2.i, (int) _r3.i);
    label43:;
    _r0.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o)._fbgColor;
    _r1.i = -1;
    if (_r0.i == _r1.i) goto label128;
    _r0.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o)._fbgColor;
    ((global::com.codename1.ui.Graphics) _r7_o).setColor((int) _r0.i);
    _r0.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getX();
    _r1_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getPadding((int) _r4.i);
    _r0.i = _r0.i + _r1.i;
    _r1.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getY();
    _r2_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getStyle();
    _r2.i = ((global::com.codename1.ui.plaf.Style) _r2_o).getPadding((int) _r5.i);
    _r1.i = _r1.i + _r2.i;
    _r2.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getWidth();
    _r3_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getStyle();
    _r3.i = ((global::com.codename1.ui.plaf.Style) _r3_o).getPadding((int) _r4.i);
    _r2.i = _r2.i - _r3.i;
    _r3_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getStyle();
    _r4.i = 3;
    _r3.i = ((global::com.codename1.ui.plaf.Style) _r3_o).getPadding((int) _r4.i);
    _r2.i = _r2.i - _r3.i;
    _r3.i = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getHeight();
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getStyle();
    _r4.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getPadding((int) _r5.i);
    _r3.i = _r3.i - _r4.i;
    _r4_o = ((global::com.codename1.ui.html.MultiComboBox_2MultiCellRenderer) _r6_o).getStyle();
    _r5.i = 2;
    _r4.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getPadding((int) _r5.i);
    _r3.i = _r3.i - _r4.i;
    ((global::com.codename1.ui.Graphics) _r7_o).fillRect((int) _r0.i, (int) _r1.i, (int) _r2.i, (int) _r3.i);
    label128:;
    base.paint((global::com.codename1.ui.Graphics) _r7_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer: void paint(com.codename1.ui.Graphics)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer]
//XMLVM_END_WRAPPER[com.codename1.ui.html.MultiComboBox$MultiCellRenderer]

} // end of class: MultiComboBox_2MultiCellRenderer

} // end of namespace: com.codename1.ui.html
