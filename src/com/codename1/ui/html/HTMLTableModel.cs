// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLTableModel: global::java.lang.Object,global::com.codename1.ui.table.TableModel {
public global::java.util.Vector _frows;

public global::java.util.Vector _fheaders;

public int _fmaxColumn;

public global::java.util.Vector _fcurrentRow;

public global::java.util.Vector _flastCommittedRow;

public global::java.util.Hashtable _fconstraints;

private global::com.codename1.ui.util.EventDispatcher _fdispatcher;

public global::com.codename1.ui.html.HTMLElement _fcaptionTextTag;

public global::java.util.Vector _fsegmentEnds;

public int _fcurSegmentType;

public int _frowInsretionPos;

public int _fbodyInsertionPos;

public bool _fhasTHead;

public bool _fhasTFoot;

public static int _fSEGMENT_1THEAD = 0;

public static int _fSEGMENT_1TBODY = 1;

public static int _fSEGMENT_1TFOOT = 2;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._frows = (global::java.util.Vector) _r0_o;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fheaders = (global::java.util.Vector) _r0_o;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fcurrentRow = (global::java.util.Vector) _r0_o;
    _r0_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fconstraints = (global::java.util.Hashtable) _r0_o;
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fdispatcher = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0.i = 1;
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fcurSegmentType = _r0.i;
    _r0.i = -1;
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._frowInsretionPos = _r0.i;
    _r0.i = 0;
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fbodyInsertionPos = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void <init>()]
}

public virtual void addCell(global::com.codename1.ui.Component n1, bool n2, global::com.codename1.ui.html.CellConstraint n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void addCell(com.codename1.ui.Component, boolean, com.codename1.ui.html.CellConstraint)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2 ? 1 : 0;
    _r5_o = n3;
    if (_r4.i == 0) goto label7;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fheaders;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r3_o);
    label7:;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fcurrentRow;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r3_o);
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fcurrentRow;
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    _r1.i = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fmaxColumn;
    if (_r0.i <= _r1.i) goto label30;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fcurrentRow;
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fmaxColumn = _r0.i;
    label30:;
    if (_r5_o == null) goto label37;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fconstraints;
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r3_o, (global::java.lang.Object) _r5_o);
    label37:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void addCell(com.codename1.ui.Component, boolean, com.codename1.ui.html.CellConstraint)]
}

public virtual void setAlignToAll(bool n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void setAlignToAll(boolean, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r3_o = this;
    _r4.i = n1 ? 1 : 0;
    _r5.i = n2;
    _r2_o = ((global::com.codename1.ui.html.HTMLTableModel) _r3_o)._fconstraints;
    _r1_o = ((global::java.util.Hashtable) _r2_o).elements();
    label6:;
    _r2.i = ((global::java.util.Enumeration) _r1_o).hasMoreElements() ? 1 : 0;
    if (_r2.i == 0) goto label28;
    _r0_o = ((global::java.util.Enumeration) _r1_o).nextElement();
    if (_r4.i == 0) goto label24;
    ((global::com.codename1.ui.html.CellConstraint) _r0_o).setHorizontalAlign((int) _r5.i);
    goto label6;
    label24:;
    ((global::com.codename1.ui.html.CellConstraint) _r0_o).setVerticalAlign((int) _r5.i);
    goto label6;
    label28:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void setAlignToAll(boolean, int)]
}

public virtual global::System.Object getConstraint(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: com.codename1.ui.html.CellConstraint getConstraint(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fconstraints;
    _r1_o = ((global::java.util.Hashtable) _r0_o).get((global::java.lang.Object) _r2_o);
    return (global::com.codename1.ui.html.CellConstraint) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: com.codename1.ui.html.CellConstraint getConstraint(java.lang.Object)]
}

public virtual bool isHeader(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: boolean isHeader(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fheaders;
    _r0.i = ((global::java.util.Vector) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: boolean isHeader(java.lang.Object)]
}

public virtual void commitRow(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void commitRow()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frowInsretionPos;
    _r1.i = -1;
    if (_r0.i != _r1.i) goto label35;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frows;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurrentRow;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r1_o);
    label12:;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurSegmentType;
    _r1.i = 2;
    if (_r0.i == _r1.i) goto label23;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fbodyInsertionPos;
    _r0.i = _r0.i + 1;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fbodyInsertionPos = _r0.i;
    label23:;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurrentRow;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._flastCommittedRow = (global::java.util.Vector) _r0_o;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurrentRow = (global::java.util.Vector) _r0_o;
    return;
    label35:;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frows;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurrentRow;
    _r2.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frowInsretionPos;
    _r3.i = _r2.i + 1;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frowInsretionPos = _r3.i;
    ((global::java.util.Vector) _r0_o).insertElementAt((global::java.lang.Object) _r1_o, (int) _r2.i);
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void commitRow()]
}

public virtual void commitRowIfNotEmpty(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void commitRowIfNotEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fcurrentRow;
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    if (_r0.i <= 0) goto label11;
    ((global::com.codename1.ui.html.HTMLTableModel) _r1_o).commitRow();
    label11:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void commitRowIfNotEmpty()]
}

public virtual void startSegment(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void startSegment(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r3.i = 2;
    _r2.i = 0;
    _r1.i = 1;
    if (_r5.i != 0) goto label16;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fhasTHead ? 1 : 0;
    if (_r0.i != 0) goto label16;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frowInsretionPos = _r2.i;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fhasTHead = 0!=_r1.i;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurSegmentType = _r2.i;
    label15:;
    return;
    label16:;
    if (_r5.i != _r3.i) goto label30;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fhasTFoot ? 1 : 0;
    if (_r0.i != 0) goto label30;
    _r0.i = -1;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frowInsretionPos = _r0.i;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fhasTFoot = 0!=_r1.i;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurSegmentType = _r3.i;
    goto label15;
    label30:;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fbodyInsertionPos;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._frowInsretionPos = _r0.i;
    ((global::com.codename1.ui.html.HTMLTableModel) _r4_o)._fcurSegmentType = _r1.i;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void startSegment(int)]
}

public virtual void endSegment(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void endSegment()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._flastCommittedRow;
    if (_r0_o == null) goto label22;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fsegmentEnds;
    if (_r0_o != null) goto label15;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fsegmentEnds = (global::java.util.Vector) _r0_o;
    label15:;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fsegmentEnds;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._flastCommittedRow;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r1_o);
    label22:;
    _r0.i = 1;
    ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fcurSegmentType = _r0.i;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fbodyInsertionPos;
    ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._frowInsretionPos = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void endSegment()]
}

public virtual int getRowCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: int getRowCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._frows;
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: int getRowCount()]
}

public virtual int getColumnCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: int getColumnCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fmaxColumn;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: int getColumnCount()]
}

public virtual global::System.Object getColumnName(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: java.lang.String getColumnName(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: java.lang.String getColumnName(int)]
}

public virtual bool isCellEditable(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: boolean isCellEditable(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: boolean isCellEditable(int, int)]
}

public virtual global::System.Object getValueAt(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: java.lang.Object getValueAt(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r3_o = this;
    _r4.i = n1;
    _r5.i = n2;
    _r2_o = null;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r3_o)._frows;
    _r1.i = ((global::java.util.Vector) _r1_o).size();
    if (_r4.i < _r1.i) goto label11;
    _r1_o = _r2_o;
    label10:;
    return (global::java.lang.Object) _r1_o;
    label11:;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r3_o)._frows;
    _r0_o = ((global::java.util.Vector) _r1_o).elementAt((int) _r4.i);
    _r1.i = ((global::java.util.Vector) _r0_o).size();
    if (_r5.i < _r1.i) goto label27;
    _r1_o = _r2_o;
    goto label10;
    label27:;
    _r1_o = ((global::java.util.Vector) _r0_o).elementAt((int) _r5.i);
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: java.lang.Object getValueAt(int, int)]
}

public virtual void setValueAt(int n1, int n2, global::java.lang.Object n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void setValueAt(int, int, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r5_o = n3;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._frows;
    _r0_o = ((global::java.util.Vector) _r1_o).elementAt((int) _r3.i);
    ((global::java.util.Vector) _r0_o).removeElementAt((int) _r4.i);
    ((global::java.util.Vector) _r0_o).setElementAt((global::java.lang.Object) _r5_o, (int) _r4.i);
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fdispatcher;
    ((global::com.codename1.ui.util.EventDispatcher) _r1_o).fireDataChangeEvent((int) _r4.i, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void setValueAt(int, int, java.lang.Object)]
}

public virtual void addDataChangeListener(global::com.codename1.ui.events.DataChangedListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void addDataChangeListener(com.codename1.ui.events.DataChangedListener)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fdispatcher;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).addListener((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void addDataChangeListener(com.codename1.ui.events.DataChangedListener)]
}

public virtual void removeDataChangeListener(global::com.codename1.ui.events.DataChangedListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: void removeDataChangeListener(com.codename1.ui.events.DataChangedListener)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r1_o)._fdispatcher;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).removeListener((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: void removeDataChangeListener(com.codename1.ui.events.DataChangedListener)]
}

public virtual bool isSegmentEnd(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel: boolean isSegmentEnd(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fsegmentEnds;
    if (_r0_o == null) goto label14;
    if (_r3.i < 0) goto label14;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._frows;
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    if (_r3.i < _r0.i) goto label16;
    label14:;
    _r0.i = 0;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._fsegmentEnds;
    _r1_o = ((global::com.codename1.ui.html.HTMLTableModel) _r2_o)._frows;
    _r1_o = ((global::java.util.Vector) _r1_o).elementAt((int) _r3.i);
    _r0.i = ((global::java.util.Vector) _r0_o).contains((global::java.lang.Object) _r1_o) ? 1 : 0;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel: boolean isSegmentEnd(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLTableModel]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLTableModel]

} // end of class: HTMLTableModel

} // end of namespace: com.codename1.ui.html
