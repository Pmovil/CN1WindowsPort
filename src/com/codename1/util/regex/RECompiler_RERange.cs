// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util.regex {
public class RECompiler_2RERange: global::java.lang.Object {
public int _fsize;

public global::org.xmlvm._nArrayAdapter<int> _fminRange;

public global::org.xmlvm._nArrayAdapter<int> _fmaxRange;

public int _fnum;

public global::com.codename1.util.regex.RECompiler _fthis_20;

public void @this(global::com.codename1.util.regex.RECompiler n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void <init>(com.codename1.util.regex.RECompiler)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fthis_20 = (global::com.codename1.util.regex.RECompiler) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 16;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fsize = _r0.i;
    _r0.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fsize;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fminRange = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    _r0.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fsize;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fmaxRange = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r1_o)._fnum = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void <init>(com.codename1.util.regex.RECompiler)]
}

public virtual void delete(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void delete(int)]
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
    _r3.i = 1;
    _r0.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fnum;
    if (_r0.i == 0) goto label9;
    _r0.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fnum;
    if (_r5.i < _r0.i) goto label10;
    label9:;
    return;
    label10:;
    _r5.i = _r5.i + 1;
    _r0.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fnum;
    if (_r5.i >= _r0.i) goto label41;
    _r0.i = _r5.i - _r3.i;
    if (_r0.i < 0) goto label10;
    _r0_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fminRange;
    _r1.i = _r5.i - _r3.i;
    _r2_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fminRange;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r5.i];
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fmaxRange;
    _r1.i = _r5.i - _r3.i;
    _r2_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fmaxRange;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r5.i];
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    goto label10;
    label41:;
    _r0.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fnum;
    _r0.i = _r0.i - _r3.i;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r4_o)._fnum = _r0.i;
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void delete(int)]
}

public virtual void merge(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void merge(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r6_o = this;
    _r7.i = n1;
    _r8.i = n2;
    _r5.i = 0;
    _r0.i = 0;
    label2:;
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    if (_r0.i >= _r3.i) goto label87;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r7.i < _r3.i) goto label19;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r8.i > _r3.i) goto label19;
    label18:;
    return;
    label19:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r7.i > _r3.i) goto label38;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r8.i < _r3.i) goto label38;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o).delete((int) _r0.i);
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o).merge((int) _r7.i, (int) _r8.i);
    goto label18;
    label38:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r7.i < _r3.i) goto label61;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r7.i > _r3.i) goto label61;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r7.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o).delete((int) _r0.i);
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o).merge((int) _r7.i, (int) _r8.i);
    goto label18;
    label61:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r8.i < _r3.i) goto label84;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r8.i > _r3.i) goto label84;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r8.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o).delete((int) _r0.i);
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o).merge((int) _r7.i, (int) _r8.i);
    goto label18;
    label84:;
    _r0.i = _r0.i + 1;
    goto label2;
    label87:;
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    _r4.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fsize;
    if (_r3.i < _r4.i) goto label125;
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fsize;
    _r3.i = _r3.i * 2;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fsize = _r3.i;
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fsize;
    _r2_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fsize;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r4.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r3_o, (int) _r5.i, (global::java.lang.Object) _r2_o, (int) _r5.i, (int) _r4.i);
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r4.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r3_o, (int) _r5.i, (global::java.lang.Object) _r1_o, (int) _r5.i, (int) _r4.i);
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange = (global::org.xmlvm._nArrayAdapter<int>) _r2_o;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange = (global::org.xmlvm._nArrayAdapter<int>) _r1_o;
    label125:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fminRange;
    _r4.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r4.i] = _r7.i;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fmaxRange;
    _r4.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r4.i] = _r8.i;
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum;
    _r3.i = _r3.i + 1;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r6_o)._fnum = _r3.i;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void merge(int, int)]
}

public virtual void remove(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void remove(int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r5_o = this;
    _r6.i = n1;
    _r7.i = n2;
    _r4.i = 1;
    _r0.i = 0;
    label2:;
    _r3.i = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fnum;
    if (_r0.i >= _r3.i) goto label21;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r3.i < _r6.i) goto label22;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r3.i > _r7.i) goto label22;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o).delete((int) _r0.i);
    label21:;
    return;
    label22:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r6.i < _r3.i) goto label60;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r7.i > _r3.i) goto label60;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fminRange;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fmaxRange;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o).delete((int) _r0.i);
    if (_r2.i >= _r6.i) goto label52;
    _r3.i = _r6.i - _r4.i;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o).merge((int) _r2.i, (int) _r3.i);
    label52:;
    if (_r7.i >= _r1.i) goto label21;
    _r3.i = _r7.i + 1;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o).merge((int) _r3.i, (int) _r1.i);
    goto label21;
    label60:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r3.i < _r6.i) goto label79;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fminRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r3.i > _r7.i) goto label79;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fminRange;
    _r4.i = _r7.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i] = _r4.i;
    goto label21;
    label79:;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r3.i < _r6.i) goto label98;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fmaxRange;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    if (_r3.i > _r7.i) goto label98;
    _r3_o = ((global::com.codename1.util.regex.RECompiler_2RERange) _r5_o)._fmaxRange;
    _r4.i = _r6.i - _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i] = _r4.i;
    goto label21;
    label98:;
    _r0.i = _r0.i + 1;
    goto label2;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void remove(int, int)]
}

public virtual void include(int n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void include(int, int, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    _r3.i = n3 ? 1 : 0;
    if (_r3.i == 0) goto label6;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r0_o).merge((int) _r1.i, (int) _r2.i);
    label5:;
    return;
    label6:;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r0_o).remove((int) _r1.i, (int) _r2.i);
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void include(int, int, boolean)]
}

public virtual void include(char n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void include(char, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2 ? 1 : 0;
    ((global::com.codename1.util.regex.RECompiler_2RERange) _r0_o).include((int) _r1.i, (int) _r1.i, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange: void include(char, boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECompiler$RERange]
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECompiler$RERange]

} // end of class: RECompiler_2RERange

} // end of namespace: com.codename1.util.regex
