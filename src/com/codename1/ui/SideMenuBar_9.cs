// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_29: global::com.codename1.ui.Command {
public global::com.codename1.ui.SideMenuBar _fthis_20;

public void @this(global::com.codename1.ui.SideMenuBar n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$9: void <init>(com.codename1.ui.SideMenuBar, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.SideMenuBar_29) _r0_o)._fthis_20 = (global::com.codename1.ui.SideMenuBar) _r1_o;
    ((global::com.codename1.ui.Command) _r0_o).@this((global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$9: void <init>(com.codename1.ui.SideMenuBar, java.lang.String)]
}

public override void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$9: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_29) _r1_o)._fthis_20;
    _r0.i = ((global::com.codename1.ui.SideMenuBar) _r0_o)._ftransitionRunning ? 1 : 0;
    if (_r0.i == 0) goto label7;
    label6:;
    return;
    label7:;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_29) _r1_o)._fthis_20;
    ((global::com.codename1.ui.SideMenuBar) _r0_o).closeMenu();
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$9: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$9]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$9]

} // end of class: SideMenuBar_29

} // end of namespace: com.codename1.ui
