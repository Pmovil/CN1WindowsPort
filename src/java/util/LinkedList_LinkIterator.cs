// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class LinkedList_2LinkIterator: global::java.lang.Object,global::java.util.ListIterator {
public int _fpos;

public int _fexpectedModCount;

public global::java.util.LinkedList _flist;

public global::java.util.LinkedList_2Link _flink;

public global::java.util.LinkedList_2Link _flastLink;

public void @this(global::java.util.LinkedList n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: void <init>(java.util.LinkedList, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    ((global::java.lang.Object) _r2_o).@this();
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist = (global::java.util.LinkedList) _r3_o;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r0.i = ((global::java.util.LinkedList) _r0_o)._fmodCount;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fexpectedModCount = _r0.i;
    if (_r4.i < 0) goto label79;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r0.i = ((global::java.util.LinkedList) _r0_o)._fsize;
    if (_r4.i > _r0.i) goto label79;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r0_o = ((global::java.util.LinkedList) _r0_o)._fvoidLink;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r0.i = ((global::java.util.LinkedList) _r0_o)._fsize;
    _r0.i = _r0.i / 2;
    if (_r4.i >= _r0.i) goto label56;
    _r0.i = -1;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos = _r0.i;
    label36:;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos;
    _r0.i = _r0.i + 1;
    if (_r0.i < _r4.i) goto label43;
    label42:;
    return;
    label43:;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fnext;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos;
    _r0.i = _r0.i + 1;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos = _r0.i;
    goto label36;
    label56:;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r0.i = ((global::java.util.LinkedList) _r0_o)._fsize;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos = _r0.i;
    label62:;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos;
    if (_r0.i < _r4.i) goto label42;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fprevious;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos;
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos = _r0.i;
    goto label62;
    label79:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: void <init>(java.util.LinkedList, int)]
}

public virtual void add(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: void add(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._fexpectedModCount;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r1_o)._fmodCount;
    if (_r0.i != _r1.i) goto label59;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fnext;
    _r1_o = new global::java.util.LinkedList_2Link();
    _r2_o = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flink;
    ((global::java.util.LinkedList_2Link) _r1_o).@this((global::java.lang.Object) _r4_o, (global::java.util.LinkedList_2Link) _r2_o, (global::java.util.LinkedList_2Link) _r0_o);
    _r2_o = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flink;
    ((global::java.util.LinkedList_2Link) _r2_o)._fnext = (global::java.util.LinkedList_2Link) _r1_o;
    ((global::java.util.LinkedList_2Link) _r0_o)._fprevious = (global::java.util.LinkedList_2Link) _r1_o;
    ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flink = (global::java.util.LinkedList_2Link) _r1_o;
    _r0_o = null;
    ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flastLink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._fpos;
    _r0.i = _r0.i + 1;
    ((global::java.util.LinkedList_2LinkIterator) _r3_o)._fpos = _r0.i;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._fexpectedModCount;
    _r0.i = _r0.i + 1;
    ((global::java.util.LinkedList_2LinkIterator) _r3_o)._fexpectedModCount = _r0.i;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r0_o)._fsize;
    _r1.i = _r1.i + 1;
    ((global::java.util.LinkedList) _r0_o)._fsize = _r1.i;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r3_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r0_o)._fmodCount;
    _r1.i = _r1.i + 1;
    ((global::java.util.LinkedList) _r0_o)._fmodCount = _r1.i;
    return;
    label59:;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: void add(java.lang.Object)]
}

public virtual bool hasNext(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: boolean hasNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fnext;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1_o = ((global::java.util.LinkedList) _r1_o)._fvoidLink;
    if (_r0_o == _r1_o) goto label12;
    _r0.i = 1;
    label11:;
    return _r0.i!=0;
    label12:;
    _r0.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: boolean hasNext()]
}

public virtual bool hasPrevious(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: boolean hasPrevious()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1_o = ((global::java.util.LinkedList) _r1_o)._fvoidLink;
    if (_r0_o == _r1_o) goto label10;
    _r0.i = 1;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: boolean hasPrevious()]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: java.lang.Object next()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fexpectedModCount;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r1_o)._fmodCount;
    if (_r0.i != _r1.i) goto label39;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fnext;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1_o = ((global::java.util.LinkedList) _r1_o)._fvoidLink;
    if (_r0_o == _r1_o) goto label33;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink = (global::java.util.LinkedList_2Link) _r0_o;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flastLink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos;
    _r0.i = _r0.i + 1;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos = _r0.i;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fdata;
    return (global::java.lang.Object) _r0_o;
    label33:;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
    label39:;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: java.lang.Object next()]
}

public virtual int nextIndex(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: int nextIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r1_o)._fpos;
    _r0.i = _r0.i + 1;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: int nextIndex()]
}

public virtual global::System.Object previous(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: java.lang.Object previous()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fexpectedModCount;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r1_o)._fmodCount;
    if (_r0.i != _r1.i) goto label43;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1_o = ((global::java.util.LinkedList) _r1_o)._fvoidLink;
    if (_r0_o == _r1_o) goto label37;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flastLink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fprevious;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos;
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fpos = _r0.i;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flastLink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fdata;
    return (global::java.lang.Object) _r0_o;
    label37:;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
    label43:;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: java.lang.Object previous()]
}

public virtual int previousIndex(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: int previousIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r1_o)._fpos;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: int previousIndex()]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: void remove()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 1;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._fexpectedModCount;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r1_o)._fmodCount;
    if (_r0.i != _r1.i) goto label69;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flastLink;
    if (_r0_o == null) goto label63;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flastLink;
    _r0_o = ((global::java.util.LinkedList_2Link) _r0_o)._fnext;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flastLink;
    _r1_o = ((global::java.util.LinkedList_2Link) _r1_o)._fprevious;
    ((global::java.util.LinkedList_2Link) _r0_o)._fprevious = (global::java.util.LinkedList_2Link) _r1_o;
    ((global::java.util.LinkedList_2Link) _r1_o)._fnext = (global::java.util.LinkedList_2Link) _r0_o;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flastLink;
    _r2_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flink;
    if (_r0_o != _r2_o) goto label36;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._fpos;
    _r0.i = _r0.i - _r3.i;
    ((global::java.util.LinkedList_2LinkIterator) _r4_o)._fpos = _r0.i;
    label36:;
    ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flink = (global::java.util.LinkedList_2Link) _r1_o;
    _r0_o = null;
    ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flastLink = (global::java.util.LinkedList_2Link) _r0_o;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._fexpectedModCount;
    _r0.i = _r0.i + 1;
    ((global::java.util.LinkedList_2LinkIterator) _r4_o)._fexpectedModCount = _r0.i;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r0_o)._fsize;
    _r1.i = _r1.i - _r3.i;
    ((global::java.util.LinkedList) _r0_o)._fsize = _r1.i;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r4_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r0_o)._fmodCount;
    _r1.i = _r1.i + 1;
    ((global::java.util.LinkedList) _r0_o)._fmodCount = _r1.i;
    return;
    label63:;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label69:;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: void remove()]
}

public virtual void set(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator: void set(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._fexpectedModCount;
    _r1_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flist;
    _r1.i = ((global::java.util.LinkedList) _r1_o)._fmodCount;
    if (_r0.i != _r1.i) goto label23;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flastLink;
    if (_r0_o == null) goto label17;
    _r0_o = ((global::java.util.LinkedList_2LinkIterator) _r2_o)._flastLink;
    ((global::java.util.LinkedList_2Link) _r0_o)._fdata = (global::java.lang.Object) _r3_o;
    return;
    label17:;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label23:;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator: void set(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.util.LinkedList$LinkIterator]
//XMLVM_END_WRAPPER[java.util.LinkedList$LinkIterator]

} // end of class: LinkedList_2LinkIterator

} // end of namespace: java.util
