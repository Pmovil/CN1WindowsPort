// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class HashMap_2AbstractMapIterator: global::java.lang.Object {
private int _fposition;

public int _fexpectedModCount;

public global::java.util.HashMap_2Entry _ffutureEntry;

public global::java.util.HashMap_2Entry _fcurrentEntry;

public global::java.util.HashMap_2Entry _fprevEntry;

public global::java.util.HashMap _fassociatedMap;

public void @this(global::java.util.HashMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$AbstractMapIterator: void <init>(java.util.HashMap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 0;
    ((global::java.util.HashMap_2AbstractMapIterator) _r1_o)._fposition = _r0.i;
    ((global::java.util.HashMap_2AbstractMapIterator) _r1_o)._fassociatedMap = (global::java.util.HashMap) _r2_o;
    _r0.i = ((global::java.util.HashMap) _r2_o)._fmodCount;
    ((global::java.util.HashMap_2AbstractMapIterator) _r1_o)._fexpectedModCount = _r0.i;
    _r0_o = null;
    ((global::java.util.HashMap_2AbstractMapIterator) _r1_o)._ffutureEntry = (global::java.util.HashMap_2Entry) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$AbstractMapIterator: void <init>(java.util.HashMap)]
}

public virtual bool hasNext(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$AbstractMapIterator: boolean hasNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.i = 1;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._ffutureEntry;
    if (_r0_o == null) goto label23;
    _r0.i = _r2.i;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fassociatedMap;
    _r0_o = ((global::java.util.HashMap) _r0_o)._felementData;
    _r1.i = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fposition;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    if (_r0_o != null) goto label34;
    _r0.i = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fposition;
    _r0.i = _r0.i + 1;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fposition = _r0.i;
    label23:;
    _r0.i = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fposition;
    _r1_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fassociatedMap;
    _r1_o = ((global::java.util.HashMap) _r1_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i < _r1.i) goto label7;
    _r0.i = 0;
    goto label6;
    label34:;
    _r0.i = _r2.i;
    goto label6;
//XMLVM_END_WRAPPER[java.util.HashMap$AbstractMapIterator: boolean hasNext()]
}

public virtual void checkConcurrentMod(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$AbstractMapIterator: void checkConcurrentMod()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.util.HashMap_2AbstractMapIterator) _r2_o)._fexpectedModCount;
    _r1_o = ((global::java.util.HashMap_2AbstractMapIterator) _r2_o)._fassociatedMap;
    _r1.i = ((global::java.util.HashMap) _r1_o)._fmodCount;
    if (_r0.i == _r1.i) goto label14;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
    label14:;
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$AbstractMapIterator: void checkConcurrentMod()]
}

public virtual void makeNext(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$AbstractMapIterator: void makeNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o).checkConcurrentMod();
    _r0.i = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o).hasNext() ? 1 : 0;
    if (_r0.i != 0) goto label15;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
    label15:;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._ffutureEntry;
    if (_r0_o != null) goto label43;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fassociatedMap;
    _r0_o = ((global::java.util.HashMap) _r0_o)._felementData;
    _r1.i = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fposition;
    _r2.i = _r1.i + 1;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fposition = _r2.i;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fcurrentEntry = (global::java.util.HashMap_2Entry) _r0_o;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fcurrentEntry;
    _r0_o = ((global::java.util.HashMap_2Entry) _r0_o)._fnext;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._ffutureEntry = (global::java.util.HashMap_2Entry) _r0_o;
    _r0_o = null;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fprevEntry = (global::java.util.HashMap_2Entry) _r0_o;
    label42:;
    return;
    label43:;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fcurrentEntry;
    if (_r0_o == null) goto label51;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fcurrentEntry;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fprevEntry = (global::java.util.HashMap_2Entry) _r0_o;
    label51:;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._ffutureEntry;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._fcurrentEntry = (global::java.util.HashMap_2Entry) _r0_o;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._ffutureEntry;
    _r0_o = ((global::java.util.HashMap_2Entry) _r0_o)._fnext;
    ((global::java.util.HashMap_2AbstractMapIterator) _r3_o)._ffutureEntry = (global::java.util.HashMap_2Entry) _r0_o;
    goto label42;
//XMLVM_END_WRAPPER[java.util.HashMap$AbstractMapIterator: void makeNext()]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$AbstractMapIterator: void remove()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 1;
    ((global::java.util.HashMap_2AbstractMapIterator) _r4_o).checkConcurrentMod();
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fcurrentEntry;
    if (_r0_o != null) goto label14;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label14:;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fprevEntry;
    if (_r0_o != null) goto label68;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fcurrentEntry;
    _r0.i = ((global::java.util.HashMap_2Entry) _r0_o)._forigKeyHash;
    _r1_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fassociatedMap;
    _r1_o = ((global::java.util.HashMap) _r1_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r1.i = _r1.i - _r3.i;
    _r0.i = _r0.i & _r1.i;
    _r1_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fassociatedMap;
    _r1_o = ((global::java.util.HashMap) _r1_o)._felementData;
    _r2_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fassociatedMap;
    _r2_o = ((global::java.util.HashMap) _r2_o)._felementData;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    _r2_o = ((global::java.util.HashMap_2Entry) _r2_o)._fnext;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i] = _r2_o;
    label43:;
    _r0_o = null;
    ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fcurrentEntry = (global::java.util.HashMap_2Entry) _r0_o;
    _r0.i = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fexpectedModCount;
    _r0.i = _r0.i + 1;
    ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fexpectedModCount = _r0.i;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fassociatedMap;
    _r1.i = ((global::java.util.HashMap) _r0_o)._fmodCount;
    _r1.i = _r1.i + 1;
    ((global::java.util.HashMap) _r0_o)._fmodCount = _r1.i;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fassociatedMap;
    _r1.i = ((global::java.util.HashMap) _r0_o)._felementCount;
    _r1.i = _r1.i - _r3.i;
    ((global::java.util.HashMap) _r0_o)._felementCount = _r1.i;
    return;
    label68:;
    _r0_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fprevEntry;
    _r1_o = ((global::java.util.HashMap_2AbstractMapIterator) _r4_o)._fcurrentEntry;
    _r1_o = ((global::java.util.HashMap_2Entry) _r1_o)._fnext;
    ((global::java.util.HashMap_2Entry) _r0_o)._fnext = (global::java.util.HashMap_2Entry) _r1_o;
    goto label43;
//XMLVM_END_WRAPPER[java.util.HashMap$AbstractMapIterator: void remove()]
}

//XMLVM_BEGIN_WRAPPER[java.util.HashMap$AbstractMapIterator]
//XMLVM_END_WRAPPER[java.util.HashMap$AbstractMapIterator]

} // end of class: HashMap_2AbstractMapIterator

} // end of namespace: java.util
