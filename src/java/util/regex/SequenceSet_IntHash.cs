// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class SequenceSet_2IntHash: global::java.lang.Object {
public global::org.xmlvm._nArrayAdapter<int> _ftable;

public global::org.xmlvm._nArrayAdapter<int> _fvalues;

public int _fmask;

public int _fsize;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SequenceSet$IntHash: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    ((global::java.lang.Object) _r1_o).@this();
    label3:;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask;
    if (_r2.i >= _r0.i) goto label34;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask;
    _r0.i = _r0.i << (0x1f & 1);
    _r0.i = _r0.i | 1;
    ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask = _r0.i;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask;
    _r0.i = _r0.i + 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._ftable = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask;
    _r0.i = _r0.i + 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fvalues = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fsize = _r2.i;
    return;
    label34:;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask;
    _r0.i = _r0.i << (0x1f & 1);
    _r0.i = _r0.i | 1;
    ((global::java.util.regex.SequenceSet_2IntHash) _r1_o)._fmask = _r0.i;
    goto label3;
//XMLVM_END_WRAPPER[java.util.regex.SequenceSet$IntHash: void <init>(int)]
}

public virtual void put(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SequenceSet$IntHash: void put(int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r0.i = 0;
    _r1.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fmask;
    _r1.i = _r1.i & _r5.i;
    _r3.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r3.i;
    label7:;
    _r2_o = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._ftable;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    if (_r2.i == 0) goto label19;
    _r2_o = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._ftable;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    if (_r2.i != _r5.i) goto label28;
    label19:;
    _r1_o = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._ftable;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i] = _r5.i;
    _r1_o = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fvalues;
    ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r0.i] = _r6.i;
    return;
    label28:;
    _r1.i = _r1.i + 1;
    _r2.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fmask;
    _r1.i = _r1.i & _r2.i;
    _r0.i = _r0.i + _r1.i;
    _r2.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fmask;
    _r0.i = _r0.i & _r2.i;
    goto label7;
//XMLVM_END_WRAPPER[java.util.regex.SequenceSet$IntHash: void put(int, int)]
}

public virtual int get(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SequenceSet$IntHash: int get(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fmask;
    _r0.i = _r0.i & _r5.i;
    _r1.i = 0;
    _r3.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r3.i;
    label7:;
    _r2_o = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._ftable;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    if (_r2.i != 0) goto label16;
    _r0.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fsize;
    label15:;
    return _r0.i;
    label16:;
    if (_r2.i != _r5.i) goto label23;
    _r0_o = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fvalues;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i];
    goto label15;
    label23:;
    _r0.i = _r0.i + 1;
    _r2.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fmask;
    _r0.i = _r0.i & _r2.i;
    _r1.i = _r1.i + _r0.i;
    _r2.i = ((global::java.util.regex.SequenceSet_2IntHash) _r4_o)._fmask;
    _r1.i = _r1.i & _r2.i;
    goto label7;
//XMLVM_END_WRAPPER[java.util.regex.SequenceSet$IntHash: int get(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.SequenceSet$IntHash]
//XMLVM_END_WRAPPER[java.util.regex.SequenceSet$IntHash]

} // end of class: SequenceSet_2IntHash

} // end of namespace: java.util.regex
