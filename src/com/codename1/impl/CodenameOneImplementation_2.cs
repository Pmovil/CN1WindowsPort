// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.impl {
public class CodenameOneImplementation_22: global::com.codename1.components.FileTree {
public global::com.codename1.ui.events.ActionListener _fval_2response;

public global::com.codename1.ui.Dialog _fval_2d;

public global::com.codename1.impl.CodenameOneImplementation _fthis_20;

public void @this(global::com.codename1.impl.CodenameOneImplementation n1, global::com.codename1.components.FileTreeModel n2, global::com.codename1.ui.events.ActionListener n3, global::com.codename1.ui.Dialog n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$2: void <init>(com.codename1.impl.CodenameOneImplementation, com.codename1.components.FileTreeModel, com.codename1.ui.events.ActionListener, com.codename1.ui.Dialog)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4_o = n4;
    ((global::com.codename1.impl.CodenameOneImplementation_22) _r0_o)._fthis_20 = (global::com.codename1.impl.CodenameOneImplementation) _r1_o;
    ((global::com.codename1.impl.CodenameOneImplementation_22) _r0_o)._fval_2response = (global::com.codename1.ui.events.ActionListener) _r3_o;
    ((global::com.codename1.impl.CodenameOneImplementation_22) _r0_o)._fval_2d = (global::com.codename1.ui.Dialog) _r4_o;
    ((global::com.codename1.components.FileTree) _r0_o).@this((global::com.codename1.components.FileTreeModel) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$2: void <init>(com.codename1.impl.CodenameOneImplementation, com.codename1.components.FileTreeModel, com.codename1.ui.events.ActionListener, com.codename1.ui.Dialog)]
}

public override global::System.Object createNodeComponent(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$2: com.codename1.ui.Button createNodeComponent(java.lang.Object, int)]
    global::org.xmlvm._nElement _r0;
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
    global::org.xmlvm._nElement _r10;
    _r8_o = this;
    _r9_o = n1;
    _r10.i = n2;
    if (_r9_o == null) goto label12;
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation_22) _r8_o).getModel();
    _r0.i = ((global::com.codename1.ui.tree.TreeModel) _r0_o).isLeaf((global::java.lang.Object) _r9_o) ? 1 : 0;
    if (_r0.i != 0) goto label17;
    label12:;
    _r0_o = base.createNodeComponent((global::java.lang.Object) _r9_o, (int) _r10.i);
    label16:;
    return (global::com.codename1.ui.Button) _r0_o;
    label17:;
    _r0_o = global::com.codename1.io.Storage.getInstance();
    // Value=thumbnails
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115))}));
    _r6_o = ((global::com.codename1.io.Storage) _r0_o).readObject((global::java.lang.String) _r1_o);
    if (_r6_o != null) goto label36;
    _r6_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r6_o).@this();
    label36:;
    _r2_o = _r6_o;
    _r5_o = base.createNodeComponent((global::java.lang.Object) _r9_o, (int) _r10.i);
    _r0_o = new global::com.codename1.impl.CodenameOneImplementation_22_21();
    ((global::com.codename1.impl.CodenameOneImplementation_22_21) _r0_o).@this((global::com.codename1.impl.CodenameOneImplementation_22) _r8_o, (global::java.lang.Object) _r9_o);
    ((global::com.codename1.ui.Button) _r5_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r0_o);
    _r4_o = global::com.codename1.ui.util.ImageIO.getImageIO();
    if (_r4_o == null) goto label69;
    _r7_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = new global::com.codename1.impl.CodenameOneImplementation_22_22();
    _r1_o = _r8_o;
    _r3_o = _r9_o;
    ((global::com.codename1.impl.CodenameOneImplementation_22_22) _r0_o).@this((global::com.codename1.impl.CodenameOneImplementation_22) _r1_o, (global::java.util.Hashtable) _r2_o, (global::java.lang.Object) _r3_o, (global::com.codename1.ui.util.ImageIO) _r4_o, (global::com.codename1.ui.Button) _r5_o);
    ((global::com.codename1.ui.Display) _r7_o).scheduleBackgroundTask((global::java.lang.Runnable) _r0_o);
    label69:;
    _r0_o = _r5_o;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$2: com.codename1.ui.Button createNodeComponent(java.lang.Object, int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$2]
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$2]

} // end of class: CodenameOneImplementation_22

} // end of namespace: com.codename1.impl
