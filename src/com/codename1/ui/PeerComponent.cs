// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class PeerComponent: global::com.codename1.ui.Component {
private global::java.lang.Object _fnativePeer;

private global::com.codename1.ui.geom.Rectangle _flastPos;

private global::com.codename1.ui.Image _fpeerImage;

public void @this(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void <init>(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r1.i = -1;
    ((global::com.codename1.ui.Component) _r2_o).@this();
    _r0_o = new global::com.codename1.ui.geom.Rectangle();
    ((global::com.codename1.ui.geom.Rectangle) _r0_o).@this((int) _r1.i, (int) _r1.i, (int) _r1.i, (int) _r1.i);
    ((global::com.codename1.ui.PeerComponent) _r2_o)._flastPos = (global::com.codename1.ui.geom.Rectangle) _r0_o;
    ((global::com.codename1.ui.PeerComponent) _r2_o)._fnativePeer = (global::java.lang.Object) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void <init>(java.lang.Object)]
}

public virtual global::System.Object getPeerImage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.Image getPeerImage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.PeerComponent) _r1_o)._fpeerImage;
    if (_r0_o != null) goto label10;
    _r0_o = ((global::com.codename1.ui.PeerComponent) _r1_o).generatePeerImage();
    ((global::com.codename1.ui.PeerComponent) _r1_o)._fpeerImage = (global::com.codename1.ui.Image) _r0_o;
    label10:;
    _r0_o = ((global::com.codename1.ui.PeerComponent) _r1_o)._fpeerImage;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.Image getPeerImage()]
}

public virtual global::System.Object generatePeerImage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.Image generatePeerImage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = null;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.Image generatePeerImage()]
}

public virtual void setPeerImage(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void setPeerImage(com.codename1.ui.Image)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.PeerComponent) _r0_o)._fpeerImage = (global::com.codename1.ui.Image) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void setPeerImage(com.codename1.ui.Image)]
}

public virtual bool shouldRenderPeerImage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: boolean shouldRenderPeerImage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: boolean shouldRenderPeerImage()]
}

public static global::System.Object create(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.PeerComponent create(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    if (_r1_o != null) goto label4;
    _r0_o = null;
    label3:;
    return (global::com.codename1.ui.PeerComponent) _r0_o;
    label4:;
    _r0_o = global::com.codename1.ui.Display._fimpl;
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).createNativePeer((global::java.lang.Object) _r1_o);
    goto label3;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.PeerComponent create(java.lang.Object)]
}

public virtual global::System.Object getNativePeer(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: java.lang.Object getNativePeer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.PeerComponent) _r1_o)._fnativePeer;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: java.lang.Object getNativePeer()]
}

public virtual void setNativePeer(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void setNativePeer(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.PeerComponent) _r0_o)._fnativePeer = (global::java.lang.Object) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void setNativePeer(java.lang.Object)]
}

public override bool animate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: boolean animate()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: boolean animate()]
}

public override global::System.Object calcPreferredSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.geom.Dimension calcPreferredSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = base.calcPreferredSize();
    return (global::com.codename1.ui.geom.Dimension) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.geom.Dimension calcPreferredSize()]
}

public override global::System.Object calcScrollSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.geom.Dimension calcScrollSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = base.calcScrollSize();
    return (global::com.codename1.ui.geom.Dimension) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: com.codename1.ui.geom.Dimension calcScrollSize()]
}

public override void deinitialize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void deinitialize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = global::com.codename1.ui.Form._factivePeerCount;
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    global::com.codename1.ui.Form._factivePeerCount = _r0.i;
    base.deinitialize();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void deinitialize()]
}

public override void fireClicked(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void fireClicked()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void fireClicked()]
}

public override void focusGained(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void focusGained()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    base.focusGained();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void focusGained()]
}

public override void focusLost(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void focusLost()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    base.focusLost();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void focusLost()]
}

public override bool handlesInput(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: boolean handlesInput()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = base.handlesInput() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: boolean handlesInput()]
}

public override void initComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void initComponent()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = global::com.codename1.ui.Form._factivePeerCount;
    _r0.i = _r0.i + 1;
    global::com.codename1.ui.Form._factivePeerCount = _r0.i;
    base.initComponent();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void initComponent()]
}

public override void keyPressed(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void keyPressed(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void keyPressed(int)]
}

public override void keyReleased(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void keyReleased(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void keyReleased(int)]
}

public override void keyRepeated(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void keyRepeated(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void keyRepeated(int)]
}

public override void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paint(com.codename1.ui.Graphics)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    ((global::com.codename1.ui.PeerComponent) _r6_o).onPositionSizeChangeImpl();
    _r0.i = ((global::com.codename1.ui.PeerComponent) _r6_o).shouldRenderPeerImage() ? 1 : 0;
    if (_r0.i == 0) goto label48;
    _r0.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getWidth();
    if (_r0.i <= 0) goto label48;
    _r0.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getHeight();
    if (_r0.i <= 0) goto label48;
    _r1_o = ((global::com.codename1.ui.PeerComponent) _r6_o).getPeerImage();
    if (_r1_o == null) goto label47;
    _r2.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getX();
    _r3.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getY();
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getWidth();
    _r5.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getHeight();
    _r0_o = _r7_o;
    ((global::com.codename1.ui.Graphics) _r0_o).drawImage((global::com.codename1.ui.Image) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i);
    label47:;
    return;
    label48:;
    base.paint((global::com.codename1.ui.Graphics) _r7_o);
    goto label47;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paint(com.codename1.ui.Graphics)]
}

private void onPositionSizeChangeImpl(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void onPositionSizeChangeImpl()]
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
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).isInitialized() ? 1 : 0;
    if (_r4.i == 0) goto label125;
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getWidth();
    if (_r4.i <= 0) goto label125;
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getHeight();
    if (_r4.i <= 0) goto label125;
    _r0.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getScrollX();
    _r1.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getScrollY();
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getAbsoluteX();
    _r2.i = _r4.i + _r0.i;
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getAbsoluteY();
    _r3.i = _r4.i + _r1.i;
    _r4_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    _r4.i = ((global::com.codename1.ui.geom.Rectangle) _r4_o).getX();
    if (_r2.i != _r4.i) goto label86;
    _r4_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    _r4.i = ((global::com.codename1.ui.geom.Rectangle) _r4_o).getY();
    if (_r3.i != _r4.i) goto label86;
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getWidth();
    _r5_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    _r5_o = ((global::com.codename1.ui.geom.Rectangle) _r5_o).getSize();
    _r5.i = ((global::com.codename1.ui.geom.Dimension) _r5_o).getWidth();
    if (_r4.i != _r5.i) goto label86;
    _r4.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getHeight();
    _r5_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    _r5_o = ((global::com.codename1.ui.geom.Rectangle) _r5_o).getSize();
    _r5.i = ((global::com.codename1.ui.geom.Dimension) _r5_o).getHeight();
    if (_r4.i == _r5.i) goto label125;
    label86:;
    _r4_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    ((global::com.codename1.ui.geom.Rectangle) _r4_o).setX((int) _r2.i);
    _r4_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    ((global::com.codename1.ui.geom.Rectangle) _r4_o).setY((int) _r3.i);
    _r4_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    _r4_o = ((global::com.codename1.ui.geom.Rectangle) _r4_o).getSize();
    _r5.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getWidth();
    ((global::com.codename1.ui.geom.Dimension) _r4_o).setWidth((int) _r5.i);
    _r4_o = ((global::com.codename1.ui.PeerComponent) _r6_o)._flastPos;
    _r4_o = ((global::com.codename1.ui.geom.Rectangle) _r4_o).getSize();
    _r5.i = ((global::com.codename1.ui.PeerComponent) _r6_o).getHeight();
    ((global::com.codename1.ui.geom.Dimension) _r4_o).setHeight((int) _r5.i);
    ((global::com.codename1.ui.PeerComponent) _r6_o).onPositionSizeChange();
    label125:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void onPositionSizeChangeImpl()]
}

public override void onParentPositionChange(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void onParentPositionChange()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::com.codename1.ui.PeerComponent) _r0_o).onPositionSizeChangeImpl();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void onParentPositionChange()]
}

public override void paintBackground(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paintBackground(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paintBackground(com.codename1.ui.Graphics)]
}

public override void paintBackgrounds(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paintBackgrounds(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paintBackgrounds(com.codename1.ui.Graphics)]
}

public override void paintBorder(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paintBorder(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paintBorder(com.codename1.ui.Graphics)]
}

public override void paintScrollbarX(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paintScrollbarX(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paintScrollbarX(com.codename1.ui.Graphics)]
}

public override void paintScrollbarY(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paintScrollbarY(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paintScrollbarY(com.codename1.ui.Graphics)]
}

public override void paintScrollbars(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void paintScrollbars(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void paintScrollbars(com.codename1.ui.Graphics)]
}

public override void pointerDragged(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerDragged(int[], int[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerDragged(int[], int[])]
}

public override void pointerDragged(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerDragged(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerDragged(int, int)]
}

public override void pointerHover(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerHover(int[], int[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerHover(int[], int[])]
}

public override void pointerHoverReleased(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerHoverReleased(int[], int[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerHoverReleased(int[], int[])]
}

public override void pointerPressed(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerPressed(int[], int[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerPressed(int[], int[])]
}

public override void pointerPressed(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerPressed(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerPressed(int, int)]
}

public override void pointerReleased(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerReleased(int[], int[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerReleased(int[], int[])]
}

public override void pointerReleased(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void pointerReleased(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void pointerReleased(int, int)]
}

public virtual void invalidate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void invalidate()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 1;
    ((global::com.codename1.ui.PeerComponent) _r1_o).setShouldCalcPreferredSize(0!=_r0.i);
    _r0_o = ((global::com.codename1.ui.PeerComponent) _r1_o).getComponentForm();
    ((global::com.codename1.ui.Form) _r0_o).revalidate();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void invalidate()]
}

public virtual void onPositionSizeChange(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void onPositionSizeChange()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void onPositionSizeChange()]
}

public override void setLightweightMode(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent: void setLightweightMode(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent: void setLightweightMode(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.PeerComponent]
//XMLVM_END_WRAPPER[com.codename1.ui.PeerComponent]

} // end of class: PeerComponent

} // end of namespace: com.codename1.ui
