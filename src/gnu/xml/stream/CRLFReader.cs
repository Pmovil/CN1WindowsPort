// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.stream {
public class CRLFReader: global::java.io.Reader {
public static int _fCR = 13;

public static int _fLF = 10;

private bool _fdoReset;

public global::java.io.Reader _fin;

public void @this(global::java.io.Reader n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: void <init>(java.io.Reader)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.io.Reader) _r1_o).@this();
    _r0.i = ((global::java.io.Reader) _r2_o).markSupported() ? 1 : 0;
    if (_r0.i != 0) goto label17;
    _r0_o = new global::java.io.BufferedReader();
    ((global::java.io.BufferedReader) _r0_o).@this((global::java.io.Reader) _r2_o);
    label14:;
    ((global::gnu.xml.stream.CRLFReader) _r1_o)._fin = (global::java.io.Reader) _r0_o;
    return;
    label17:;
    _r0_o = _r2_o;
    goto label14;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: void <init>(java.io.Reader)]
}

public override int read(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: int read()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r0.i = ((global::java.io.Reader) _r0_o).read();
    _r1.i = 13;
    if (_r0.i != _r1.i) goto label27;
    _r1_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r2.i = 1;
    ((global::java.io.Reader) _r1_o).mark((int) _r2.i);
    _r1_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r1.i = ((global::java.io.Reader) _r1_o).read();
    _r2.i = 10;
    if (_r1.i != _r2.i) goto label28;
    _r0.i = _r1.i;
    label27:;
    return _r0.i;
    label28:;
    _r1_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    ((global::java.io.Reader) _r1_o).reset();
    goto label27;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: int read()]
}

public override int read(global::org.xmlvm._nArrayAdapter<char> n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: int read(char[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = ((global::gnu.xml.stream.CRLFReader) _r2_o).read((global::org.xmlvm._nArrayAdapter<char>) _r3_o, (int) _r0.i, (int) _r1.i);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: int read(char[])]
}

public override int read(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: int read(char[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r1.i = _r6.i + 1;
    ((global::java.io.Reader) _r0_o).mark((int) _r1.i);
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r0.i = ((global::java.io.Reader) _r0_o).read((global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (int) _r6.i);
    if (_r0.i <= 0) goto label49;
    _r1.i = ((global::gnu.xml.stream.CRLFReader) _r3_o).indexOfCRLF((global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (int) _r0.i);
    _r2.i = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fdoReset ? 1 : 0;
    if (_r2.i == 0) goto label49;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    ((global::java.io.Reader) _r0_o).reset();
    _r0.i = -1;
    if (_r1.i == _r0.i) goto label50;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r2.i = _r1.i + 1;
    _r2.i = _r2.i - _r5.i;
    _r0.i = ((global::java.io.Reader) _r0_o).read((global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (int) _r2.i);
    _r2_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    ((global::java.io.Reader) _r2_o).read();
    _r2.i = 10;
    ((global::org.xmlvm._nArrayAdapter<char>) _r4_o)[_r1.i] = (char)_r2.i;
    label49:;
    return _r0.i;
    label50:;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r3_o)._fin;
    _r0.i = ((global::java.io.Reader) _r0_o).read((global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (int) _r6.i);
    goto label49;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: int read(char[], int, int)]
}

public override bool markSupported(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: boolean markSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r1_o)._fin;
    _r0.i = ((global::java.io.Reader) _r0_o).markSupported() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: boolean markSupported()]
}

public override void mark(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: void mark(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r1_o)._fin;
    ((global::java.io.Reader) _r0_o).mark((int) _r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: void mark(int)]
}

public override void reset(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: void reset()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r1_o)._fin;
    ((global::java.io.Reader) _r0_o).reset();
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: void reset()]
}

public override long skip(long n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: long skip(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.l = n1;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r2_o)._fin;
    _r0.l = ((global::java.io.Reader) _r0_o).skip((long) _r3.l);
    return _r0.l;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: long skip(long)]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: void close()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.stream.CRLFReader) _r1_o)._fin;
    ((global::java.io.Reader) _r0_o).close();
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: void close()]
}

private int indexOfCRLF(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader: int indexOfCRLF(char[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r5.i = 1;
    _r0.i = 0;
    ((global::gnu.xml.stream.CRLFReader) _r6_o)._fdoReset = 0!=_r0.i;
    _r0.i = _r8.i + _r9.i;
    _r1.i = _r0.i - _r5.i;
    _r2.i = _r8.i;
    label9:;
    if (_r2.i < _r0.i) goto label13;
    _r0.i = -1;
    label12:;
    return _r0.i;
    label13:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r7_o)[_r2.i];
    _r4.i = 13;
    if (_r3.i != _r4.i) goto label42;
    if (_r2.i != _r1.i) goto label37;
    _r3_o = ((global::gnu.xml.stream.CRLFReader) _r6_o)._fin;
    _r3.i = ((global::java.io.Reader) _r3_o).read();
    ((global::gnu.xml.stream.CRLFReader) _r6_o)._fdoReset = 0!=_r5.i;
    label29:;
    _r4.i = 10;
    if (_r3.i != _r4.i) goto label42;
    ((global::gnu.xml.stream.CRLFReader) _r6_o)._fdoReset = 0!=_r5.i;
    _r0.i = _r2.i;
    goto label12;
    label37:;
    _r3.i = _r2.i + 1;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r7_o)[_r3.i];
    goto label29;
    label42:;
    _r2.i = _r2.i + 1;
    goto label9;
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader: int indexOfCRLF(char[], int, int)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.CRLFReader]
//XMLVM_END_WRAPPER[gnu.xml.stream.CRLFReader]

} // end of class: CRLFReader

} // end of namespace: gnu.xml.stream
