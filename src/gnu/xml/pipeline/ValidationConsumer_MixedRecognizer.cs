// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.pipeline {
public class ValidationConsumer_2MixedRecognizer: global::gnu.xml.pipeline.ValidationConsumer_2Recognizer {
private global::org.xmlvm._nArrayAdapter<global::System.Object> _fpermitted;

public void @this(global::gnu.xml.pipeline.ValidationConsumer_2ElementInfo n1, global::gnu.xml.pipeline.ValidationConsumer n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.ValidationConsumer$MixedRecognizer: void <init>(gnu.xml.pipeline.ValidationConsumer$ElementInfo, gnu.xml.pipeline.ValidationConsumer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    ((global::gnu.xml.pipeline.ValidationConsumer_2Recognizer) _r5_o).@this((global::gnu.xml.pipeline.ValidationConsumer_2ElementInfo) _r6_o);
    _r0_o = new global::java.util.StringTokenizer();
    _r1_o = ((global::gnu.xml.pipeline.ValidationConsumer_2ElementInfo) _r6_o)._fmodel;
    _r2.i = 8;
    _r3_o = ((global::gnu.xml.pipeline.ValidationConsumer_2ElementInfo) _r6_o)._fmodel;
    _r4.i = 41;
    _r3.i = ((global::java.lang.String) _r3_o).lastIndexOf((int) _r4.i);
    _r1_o = ((global::java.lang.String) _r1_o).substring((int) _r2.i, (int) _r3.i);
    // Value=\174
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)124))}));
    ((global::java.util.StringTokenizer) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    _r1_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r1_o).@this();
    label31:;
    _r2.i = ((global::java.util.StringTokenizer) _r0_o).hasMoreTokens() ? 1 : 0;
    if (_r2.i != 0) goto label53;
    _r0.i = ((global::java.util.Vector) _r1_o).size();
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    ((global::gnu.xml.pipeline.ValidationConsumer_2MixedRecognizer) _r5_o)._fpermitted = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.i = 0;
    _r2.i = _r0.i;
    label47:;
    _r0_o = ((global::gnu.xml.pipeline.ValidationConsumer_2MixedRecognizer) _r5_o)._fpermitted;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r2.i < _r0.i) goto label102;
    return;
    label53:;
    _r2_o = ((global::java.util.StringTokenizer) _r0_o).nextToken();
    _r3.i = ((global::java.util.Vector) _r1_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r3.i == 0) goto label94;
    _r3_o = new global::java.lang.StringBuilder();
    // Value=element 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r3_o).@this((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    // Value= is repeated in mixed content model: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r3_o = ((global::gnu.xml.pipeline.ValidationConsumer_2ElementInfo) _r6_o)._fmodel;
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    global::gnu.xml.pipeline.ValidationConsumer.access_21((global::gnu.xml.pipeline.ValidationConsumer) _r7_o, (global::java.lang.String) _r2_o);
    goto label31;
    label94:;
    _r2_o = ((global::java.lang.String) _r2_o).intern();
    ((global::java.util.Vector) _r1_o).addElement((global::java.lang.Object) _r2_o);
    goto label31;
    label102:;
    _r3_o = ((global::gnu.xml.pipeline.ValidationConsumer_2MixedRecognizer) _r5_o)._fpermitted;
    _r0_o = ((global::java.util.Vector) _r1_o).elementAt((int) _r2.i);
    _r0_o = _r0_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r2.i] = _r0_o;
    _r0.i = _r2.i + 1;
    _r2.i = _r0.i;
    goto label47;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.ValidationConsumer$MixedRecognizer: void <init>(gnu.xml.pipeline.ValidationConsumer$ElementInfo, gnu.xml.pipeline.ValidationConsumer)]
}

public override global::System.Object acceptElement(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.ValidationConsumer$MixedRecognizer: gnu.xml.pipeline.ValidationConsumer$Recognizer acceptElement(java.lang.String)]
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
    _r3.i = 0;
    _r0_o = ((global::gnu.xml.pipeline.ValidationConsumer_2MixedRecognizer) _r4_o)._fpermitted;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = _r3.i;
    label5:;
    if (_r1.i < _r0.i) goto label12;
    _r1.i = _r3.i;
    label8:;
    if (_r1.i < _r0.i) goto label23;
    _r0_o = null;
    label11:;
    return (global::gnu.xml.pipeline.ValidationConsumer_2Recognizer) _r0_o;
    label12:;
    _r2_o = ((global::gnu.xml.pipeline.ValidationConsumer_2MixedRecognizer) _r4_o)._fpermitted;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    if (_r2_o != _r5_o) goto label20;
    _r0_o = _r4_o;
    goto label11;
    label20:;
    _r1.i = _r1.i + 1;
    goto label5;
    label23:;
    _r2_o = ((global::gnu.xml.pipeline.ValidationConsumer_2MixedRecognizer) _r4_o)._fpermitted;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label35;
    _r0_o = _r4_o;
    goto label11;
    label35:;
    _r1.i = _r1.i + 1;
    goto label8;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.ValidationConsumer$MixedRecognizer: gnu.xml.pipeline.ValidationConsumer$Recognizer acceptElement(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.ValidationConsumer$MixedRecognizer]
//XMLVM_END_WRAPPER[gnu.xml.pipeline.ValidationConsumer$MixedRecognizer]

} // end of class: ValidationConsumer_2MixedRecognizer

} // end of namespace: gnu.xml.pipeline
