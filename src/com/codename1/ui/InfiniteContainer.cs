// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public abstract class InfiniteContainer: global::com.codename1.ui.Container {
private int _famount;

private bool _frequestingResults;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    ((global::com.codename1.ui.Container) _r2_o).@this();
    _r0.i = 10;
    ((global::com.codename1.ui.InfiniteContainer) _r2_o)._famount = _r0.i;
    _r0_o = new global::com.codename1.ui.layouts.BoxLayout();
    _r1.i = 2;
    ((global::com.codename1.ui.layouts.BoxLayout) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.ui.InfiniteContainer) _r2_o).setLayout((global::com.codename1.ui.layouts.Layout) _r0_o);
    _r0.i = 1;
    ((global::com.codename1.ui.InfiniteContainer) _r2_o).setScrollableY(0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: void <init>()]
}

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: void <init>(int)]
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
    _r3.i = n1;
    ((global::com.codename1.ui.InfiniteContainer) _r2_o).@this();
    ((global::com.codename1.ui.InfiniteContainer) _r2_o)._famount = _r3.i;
    if (_r3.i > 0) goto label15;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=amount must be greater then zero
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label15:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: void <init>(int)]
}

public override void resetScroll(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: void resetScroll()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: void resetScroll()]
}

public override void initComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: void initComponent()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    base.initComponent();
    ((global::com.codename1.ui.InfiniteContainer) _r1_o).createInfiniteScroll();
    _r0_o = new global::com.codename1.ui.InfiniteContainer_21();
    ((global::com.codename1.ui.InfiniteContainer_21) _r0_o).@this((global::com.codename1.ui.InfiniteContainer) _r1_o);
    ((global::com.codename1.ui.InfiniteContainer) _r1_o).addPullToRefresh((global::java.lang.Runnable) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: void initComponent()]
}

private void createInfiniteScroll(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: void createInfiniteScroll()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::com.codename1.ui.InfiniteContainer_22();
    ((global::com.codename1.ui.InfiniteContainer_22) _r0_o).@this((global::com.codename1.ui.InfiniteContainer) _r1_o);
    global::com.codename1.components.InfiniteScrollAdapter.createInfiniteScroll((global::com.codename1.ui.Container) _r1_o, (global::java.lang.Runnable) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: void createInfiniteScroll()]
}

public abstract global::System.Object fetchComponents(int n1, int n2);

public static bool access_2002(global::com.codename1.ui.InfiniteContainer n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: boolean access$002(com.codename1.ui.InfiniteContainer, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    _r1.i = n2 ? 1 : 0;
    ((global::com.codename1.ui.InfiniteContainer) _r0_o)._frequestingResults = 0!=_r1.i;
    return _r1.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: boolean access$002(com.codename1.ui.InfiniteContainer, boolean)]
}

public static int access_2100(global::com.codename1.ui.InfiniteContainer n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: int access$100(com.codename1.ui.InfiniteContainer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0.i = ((global::com.codename1.ui.InfiniteContainer) _r1_o)._famount;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: int access$100(com.codename1.ui.InfiniteContainer)]
}

public static bool access_2000(global::com.codename1.ui.InfiniteContainer n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer: boolean access$000(com.codename1.ui.InfiniteContainer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0.i = ((global::com.codename1.ui.InfiniteContainer) _r1_o)._frequestingResults ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer: boolean access$000(com.codename1.ui.InfiniteContainer)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer]
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer]

} // end of class: InfiniteContainer

} // end of namespace: com.codename1.ui
