// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class RSSService_21: global::com.codename1.xml.XMLParser {
private global::java.lang.String _flastTag;

private global::java.util.Hashtable _fcurrent;

private global::java.lang.String _furl;

public global::com.codename1.io.services.RSSService _fthis_20;

public void @this(global::com.codename1.io.services.RSSService n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.RSSService$1: void <init>(com.codename1.io.services.RSSService)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.io.services.RSSService_21) _r0_o)._fthis_20 = (global::com.codename1.io.services.RSSService) _r1_o;
    ((global::com.codename1.xml.XMLParser) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.RSSService$1: void <init>(com.codename1.io.services.RSSService)]
}

public override bool startTag(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.RSSService$1: boolean startTag(java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    // Value=item
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r5_o) ? 1 : 0;
    if (_r0.i != 0) goto label17;
    // Value=entry
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 121))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r5_o) ? 1 : 0;
    if (_r0.i == 0) goto label55;
    label17:;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r4_o)._fthis_20;
    _r0.i = global::com.codename1.io.services.RSSService.access_2000((global::com.codename1.io.services.RSSService) _r0_o);
    if (_r0.i <= 0) goto label27;
    _r0.i = _r3.i;
    label26:;
    return _r0.i!=0;
    label27:;
    _r0_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r0_o).@this();
    ((global::com.codename1.io.services.RSSService_21) _r4_o)._fcurrent = (global::java.util.Hashtable) _r0_o;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r4_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.RSSService.access_2100((global::com.codename1.io.services.RSSService) _r0_o);
    if (_r0_o == null) goto label55;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r4_o)._fcurrent;
    // Value=icon
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r2_o = ((global::com.codename1.io.services.RSSService_21) _r4_o)._fthis_20;
    _r2_o = global::com.codename1.io.services.RSSService.access_2100((global::com.codename1.io.services.RSSService) _r2_o);
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    label55:;
    ((global::com.codename1.io.services.RSSService_21) _r4_o)._flastTag = (global::java.lang.String) _r5_o;
    _r0.i = _r3.i;
    goto label26;
//XMLVM_END_WRAPPER[com.codename1.io.services.RSSService$1: boolean startTag(java.lang.String)]
}

public override void attribute(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.RSSService$1: void attribute(java.lang.String, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5_o = n3;
    // Value=url
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 108))}));
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    if (_r0_o == null) goto label29;
    // Value=media:thumbnail
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label30;
    // Value=url
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 108))}));
    _r0.i = ((global::java.lang.String) _r1_o).equalsIgnoreCase((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label30;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    // Value=thumb
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98))}));
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r5_o);
    label29:;
    return;
    label30:;
    // Value=media:player
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label29;
    // Value=url
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 108))}));
    _r0.i = ((global::java.lang.String) _r1_o).equalsIgnoreCase((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label29;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    // Value=player
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r5_o);
    goto label29;
//XMLVM_END_WRAPPER[com.codename1.io.services.RSSService$1: void attribute(java.lang.String, java.lang.String, java.lang.String)]
}

public override void textElement(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.RSSService$1: void textElement(java.lang.String)]
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
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._flastTag;
    if (_r0_o == null) goto label25;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    if (_r0_o == null) goto label25;
    // Value=summary
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 121))}));
    _r1_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._flastTag;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label26;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    // Value=details
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115))}));
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r3_o);
    label25:;
    return;
    label26:;
    // Value=content
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._flastTag;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label44;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    // Value=description
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r3_o);
    goto label25;
    label44:;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._fcurrent;
    _r1_o = ((global::com.codename1.io.services.RSSService_21) _r2_o)._flastTag;
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r3_o);
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.io.services.RSSService$1: void textElement(java.lang.String)]
}

public override void endTag(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.RSSService$1: void endTag(java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    _r2_o = null;
    // Value=item
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r0.i != 0) goto label17;
    // Value=entry
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 121))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label79;
    label17:;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    _r0.i = global::com.codename1.io.services.RSSService.access_2000((global::com.codename1.io.services.RSSService) _r0_o);
    if (_r0.i <= 0) goto label31;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    global::com.codename1.io.services.RSSService.access_2010((global::com.codename1.io.services.RSSService) _r0_o);
    label30:;
    return;
    label31:;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.RSSService.access_2200((global::com.codename1.io.services.RSSService) _r0_o);
    _r1_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fcurrent;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r1_o);
    ((global::com.codename1.io.services.RSSService_21) _r3_o)._fcurrent = (global::java.util.Hashtable) _r2_o;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    _r0.i = global::com.codename1.io.services.RSSService.access_2300((global::com.codename1.io.services.RSSService) _r0_o);
    _r1.i = -1;
    if (_r0.i <= _r1.i) goto label79;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.RSSService.access_2200((global::com.codename1.io.services.RSSService) _r0_o);
    _r0.i = ((global::java.util.Vector) _r0_o).size();
    _r1_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    _r1.i = global::com.codename1.io.services.RSSService.access_2300((global::com.codename1.io.services.RSSService) _r1_o);
    if (_r0.i < _r1.i) goto label79;
    _r0_o = new global::com.codename1.io.services.RSSService_21FinishParsing();
    _r1_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._fthis_20;
    ((global::com.codename1.io.services.RSSService_21FinishParsing) _r0_o).@this((global::com.codename1.io.services.RSSService) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::com.codename1.io.services.RSSService_21FinishParsing) _r0_o);
    label79:;
    _r0_o = ((global::com.codename1.io.services.RSSService_21) _r3_o)._flastTag;
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label30;
    ((global::com.codename1.io.services.RSSService_21) _r3_o)._flastTag = (global::java.lang.String) _r2_o;
    goto label30;
//XMLVM_END_WRAPPER[com.codename1.io.services.RSSService$1: void endTag(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.RSSService$1]
//XMLVM_END_WRAPPER[com.codename1.io.services.RSSService$1]

} // end of class: RSSService_21

} // end of namespace: com.codename1.io.services
