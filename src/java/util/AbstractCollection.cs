// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public abstract class AbstractCollection: global::java.lang.Object,global::java.util.Collection {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: void <init>()]
}

public virtual bool add(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean add(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean add(java.lang.Object)]
}

public virtual bool addAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean addAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = 0;
    _r1_o = ((global::java.util.Collection) _r4_o).iterator();
    label5:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i != 0) goto label12;
    return _r0.i!=0;
    label12:;
    _r2_o = ((global::java.util.Iterator) _r1_o).next();
    _r2.i = ((global::java.util.AbstractCollection) _r3_o).add((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r2.i == 0) goto label5;
    _r0.i = 1;
    goto label5;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean addAll(java.util.Collection)]
}

public virtual void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: void clear()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.util.AbstractCollection) _r2_o).iterator();
    label4:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label11;
    return;
    label11:;
    ((global::java.util.Iterator) _r0_o).next();
    ((global::java.util.Iterator) _r0_o).remove();
    goto label4;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: void clear()]
}

public virtual bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 1;
    _r0_o = ((global::java.util.AbstractCollection) _r3_o).iterator();
    if (_r4_o == null) goto label35;
    label7:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label15;
    label13:;
    _r0.i = 0;
    label14:;
    return _r0.i!=0;
    label15:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    _r1.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label7;
    _r0.i = _r2.i;
    goto label14;
    label27:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    if (_r1_o != null) goto label35;
    _r0.i = _r2.i;
    goto label14;
    label35:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label27;
    goto label13;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean contains(java.lang.Object)]
}

public virtual bool containsAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean containsAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.util.Collection) _r3_o).iterator();
    label4:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label12;
    _r0.i = 1;
    label11:;
    return _r0.i!=0;
    label12:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    _r1.i = ((global::java.util.AbstractCollection) _r2_o).contains((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i != 0) goto label4;
    _r0.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean containsAll(java.util.Collection)]
}

public virtual bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.AbstractCollection) _r1_o).size();
    if (_r0.i != 0) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean isEmpty()]
}

public abstract global::System.Object iterator();

public virtual bool remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean remove(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 1;
    _r0_o = ((global::java.util.AbstractCollection) _r3_o).iterator();
    if (_r4_o == null) goto label41;
    label7:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label15;
    label13:;
    _r0.i = 0;
    label14:;
    return _r0.i!=0;
    label15:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    _r1.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label7;
    ((global::java.util.Iterator) _r0_o).remove();
    _r0.i = _r2.i;
    goto label14;
    label30:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    if (_r1_o != null) goto label41;
    ((global::java.util.Iterator) _r0_o).remove();
    _r0.i = _r2.i;
    goto label14;
    label41:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label30;
    goto label13;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean remove(java.lang.Object)]
}

public virtual bool removeAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean removeAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = 0;
    _r1_o = ((global::java.util.AbstractCollection) _r3_o).iterator();
    label5:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i != 0) goto label12;
    return _r0.i!=0;
    label12:;
    _r2_o = ((global::java.util.Iterator) _r1_o).next();
    _r2.i = ((global::java.util.Collection) _r4_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r2.i == 0) goto label5;
    ((global::java.util.Iterator) _r1_o).remove();
    _r0.i = 1;
    goto label5;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean removeAll(java.util.Collection)]
}

public virtual bool retainAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: boolean retainAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0.i = 0;
    _r1_o = ((global::java.util.AbstractCollection) _r3_o).iterator();
    label5:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i != 0) goto label12;
    return _r0.i!=0;
    label12:;
    _r2_o = ((global::java.util.Iterator) _r1_o).next();
    _r2.i = ((global::java.util.Collection) _r4_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r2.i != 0) goto label5;
    ((global::java.util.Iterator) _r1_o).remove();
    _r0.i = 1;
    goto label5;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: boolean retainAll(java.util.Collection)]
}

public abstract int size();

public virtual global::System.Object toArray(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: java.lang.Object[] toArray()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r0.i = ((global::java.util.AbstractCollection) _r6_o).size();
    _r1.i = 0;
    _r2_o = ((global::java.util.AbstractCollection) _r6_o).iterator();
    _r3_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    label11:;
    if (_r1.i < _r0.i) goto label14;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o;
    label14:;
    _r4.i = _r1.i + 1;
    _r5_o = ((global::java.util.Iterator) _r2_o).next();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r1.i] = _r5_o;
    _r1.i = _r4.i;
    goto label11;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: java.lang.Object[] toArray()]
}

public virtual global::System.Object toArray(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: java.lang.Object[] toArray(java.lang.Object[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.i = ((global::java.util.AbstractCollection) _r4_o).size();
    _r1.i = 0;
    _r2.i = ((global::org.xmlvm._nIArray) _r5_o).Length;
    if (_r0.i <= _r2.i) goto label51;
    _r2_o = ((global::java.lang.Object) _r5_o).getClass();
    _r2_o = ((global::java.lang.Class) _r2_o).getComponentType();
    _r0_o = global::java.lang.reflect.Array.newInstance((global::java.lang.Class) _r2_o, (int) _r0.i);
    label22:;
    _r2_o = ((global::java.util.AbstractCollection) _r4_o).iterator();
    label26:;
    _r3.i = ((global::java.util.Iterator) _r2_o).hasNext() ? 1 : 0;
    if (_r3.i != 0) goto label39;
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r1.i >= _r2.i) goto label38;
    _r2_o = null;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    label38:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    label39:;
    _r4_o = ((global::java.util.Iterator) _r2_o).next();
    _r3.i = _r1.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    _r1.i = _r3.i;
    goto label26;
    label51:;
    _r0_o = _r5_o;
    goto label22;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: java.lang.Object[] toArray(java.lang.Object[])]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = ((global::java.util.AbstractCollection) _r3_o).isEmpty() ? 1 : 0;
    if (_r0.i == 0) goto label9;
    // Value=[]
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91)), unchecked((char) unchecked((uint) 93))}));
    label8:;
    return (global::java.lang.String) _r0_o;
    label9:;
    _r0_o = new global::java.lang.StringBuilder();
    _r1.i = ((global::java.util.AbstractCollection) _r3_o).size();
    _r1.i = _r1.i * 16;
    ((global::java.lang.StringBuilder) _r0_o).@this((int) _r1.i);
    _r1.i = 91;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.util.AbstractCollection) _r3_o).iterator();
    label29:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i != 0) goto label45;
    _r1.i = 93;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label8;
    label45:;
    _r2_o = ((global::java.util.Iterator) _r1_o).next();
    if (_r2_o == _r3_o) goto label66;
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r2_o);
    label54:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i == 0) goto label29;
    // Value=, 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    goto label29;
    label66:;
    // Value=(this Collection)
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 41))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    goto label54;
//XMLVM_END_WRAPPER[java.util.AbstractCollection: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[java.util.AbstractCollection]
//XMLVM_END_WRAPPER[java.util.AbstractCollection]

} // end of class: AbstractCollection

} // end of namespace: java.util
