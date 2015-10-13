// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util.regex {
public class RECharacter: global::java.lang.Object {

static RECharacter() {
    @static();
}

public static sbyte _fUNASSIGNED = 0;

public static sbyte _fUPPERCASE_1LETTER = 1;

public static sbyte _fLOWERCASE_1LETTER = 2;

public static sbyte _fTITLECASE_1LETTER = 3;

public static sbyte _fMODIFIER_1LETTER = 4;

public static sbyte _fOTHER_1LETTER = 5;

public static sbyte _fNON_1SPACING_1MARK = 6;

public static sbyte _fENCLOSING_1MARK = 7;

public static sbyte _fCOMBINING_1SPACING_1MARK = 8;

public static sbyte _fDECIMAL_1DIGIT_1NUMBER = 9;

public static sbyte _fLETTER_1NUMBER = 10;

public static sbyte _fOTHER_1NUMBER = 11;

public static sbyte _fSPACE_1SEPARATOR = 12;

public static sbyte _fLINE_1SEPARATOR = 13;

public static sbyte _fPARAGRAPH_1SEPARATOR = 14;

public static sbyte _fCONTROL = 15;

public static sbyte _fFORMAT = 16;

public static sbyte _fPRIVATE_1USE = 18;

public static sbyte _fSURROGATE = 19;

public static sbyte _fDASH_1PUNCTUATION = 20;

public static sbyte _fSTART_1PUNCTUATION = 21;

public static sbyte _fEND_1PUNCTUATION = 22;

public static sbyte _fCONNECTOR_1PUNCTUATION = 23;

public static sbyte _fOTHER_1PUNCTUATION = 24;

public static sbyte _fMATH_1SYMBOL = 25;

public static sbyte _fCURRENCY_1SYMBOL = 26;

public static sbyte _fMODIFIER_1SYMBOL = 27;

public static sbyte _fOTHER_1SYMBOL = 28;

public static global::org.xmlvm._nArrayAdapter<sbyte> _fCHAR_1CLASSES;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: void <init>()]
}

public static char toLowerCase(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: char toLowerCase(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = n1;
    _r0.i = global::java.lang.Character.toLowerCase((char) _r1.i);
    return (char) _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: char toLowerCase(char)]
}

public static char toUpperCase(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: char toUpperCase(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = n1;
    _r0.i = global::java.lang.Character.toUpperCase((char) _r1.i);
    return (char) _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: char toUpperCase(char)]
}

public static bool isWhitespace(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isWhitespace(char)]
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
    _r5.i = n1;
    _r4.i = 13;
    _r3.i = 12;
    _r2.i = 9;
    _r0.i = global::com.codename1.util.regex.RECharacter.getType((char) _r5.i);
    if (_r0.i == _r3.i) goto label18;
    if (_r0.i == _r4.i) goto label18;
    _r1.i = 14;
    if (_r0.i != _r1.i) goto label30;
    label18:;
    _r1.i = 160;
    if (_r5.i == _r1.i) goto label30;
    _r1.i = 8199;
    if (_r5.i == _r1.i) goto label30;
    _r1.i = 8239;
    if (_r5.i != _r1.i) goto label62;
    label30:;
    if (_r5.i == _r2.i) goto label62;
    _r1.i = 10;
    if (_r5.i == _r1.i) goto label62;
    _r1.i = 11;
    if (_r5.i == _r1.i) goto label62;
    if (_r5.i == _r3.i) goto label62;
    if (_r5.i == _r4.i) goto label62;
    if (_r5.i == _r2.i) goto label62;
    _r1.i = 28;
    if (_r5.i == _r1.i) goto label62;
    _r1.i = 29;
    if (_r5.i == _r1.i) goto label62;
    _r1.i = 30;
    if (_r5.i == _r1.i) goto label62;
    _r1.i = 31;
    if (_r5.i != _r1.i) goto label64;
    label62:;
    _r1.i = 1;
    label63:;
    return _r1.i!=0;
    label64:;
    _r1.i = 0;
    goto label63;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isWhitespace(char)]
}

public static bool isDigit(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isDigit(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2.i = n1;
    _r0.i = global::com.codename1.util.regex.RECharacter.getType((char) _r2.i);
    _r1.i = 9;
    if (_r0.i != _r1.i) goto label10;
    _r1.i = 1;
    label9:;
    return _r1.i!=0;
    label10:;
    _r1.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isDigit(char)]
}

public static bool isLetter(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isLetter(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3.i = n1;
    _r2.i = 1;
    _r0.i = global::com.codename1.util.regex.RECharacter.getType((char) _r3.i);
    _r1.i = 2;
    if (_r0.i == _r1.i) goto label16;
    if (_r0.i == _r2.i) goto label16;
    _r1.i = 3;
    if (_r0.i == _r1.i) goto label16;
    _r1.i = 5;
    if (_r0.i != _r1.i) goto label18;
    label16:;
    _r1.i = _r2.i;
    label17:;
    return _r1.i!=0;
    label18:;
    _r1.i = 0;
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isLetter(char)]
}

public static bool isLetterOrDigit(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isLetterOrDigit(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = n1;
    _r0.i = global::com.codename1.util.regex.RECharacter.isDigit((char) _r1.i) ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0.i = global::com.codename1.util.regex.RECharacter.isLetter((char) _r1.i) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    label12:;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isLetterOrDigit(char)]
}

public static bool isSpaceChar(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isSpaceChar(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2.i = n1;
    _r0.i = global::com.codename1.util.regex.RECharacter.getType((char) _r2.i);
    _r1.i = 12;
    if (_r0.i == _r1.i) goto label16;
    _r1.i = 13;
    if (_r0.i == _r1.i) goto label16;
    _r1.i = 14;
    if (_r0.i != _r1.i) goto label18;
    label16:;
    _r1.i = 1;
    label17:;
    return _r1.i!=0;
    label18:;
    _r1.i = 0;
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isSpaceChar(char)]
}

public static bool isJavaIdentifierStart(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isJavaIdentifierStart(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2.i = n1;
    _r0.i = global::com.codename1.util.regex.RECharacter.getType((char) _r2.i);
    _r1.i = global::com.codename1.util.regex.RECharacter.isLetter((char) _r2.i) ? 1 : 0;
    if (_r1.i != 0) goto label22;
    _r1.i = 10;
    if (_r0.i == _r1.i) goto label22;
    _r1.i = 36;
    if (_r2.i == _r1.i) goto label22;
    _r1.i = 95;
    if (_r2.i != _r1.i) goto label24;
    label22:;
    _r1.i = 1;
    label23:;
    return _r1.i!=0;
    label24:;
    _r1.i = 0;
    goto label23;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isJavaIdentifierStart(char)]
}

public static bool isJavaIdentifierPart(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: boolean isJavaIdentifierPart(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = n1;
    _r0.i = global::com.codename1.util.regex.RECharacter.isJavaIdentifierStart((char) _r1.i) ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0.i = global::java.lang.Character.isDigit((char) _r1.i) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    label12:;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: boolean isJavaIdentifierPart(char)]
}

public static sbyte getType(char n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: byte getType(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = n1;
    _r0_o = global::com.codename1.util.regex.RECharacter._fCHAR_1CLASSES;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r1.i >= _r0.i) goto label10;
    _r0_o = global::com.codename1.util.regex.RECharacter._fCHAR_1CLASSES;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    label9:;
    return (sbyte) _r0.i;
    label10:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: byte getType(char)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0.i = 256;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[]{15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 12, 23, 23, 23, 25, 23, 23, 23, 20, 21, 23, 24, 23, 19, 23, 23, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 23, 23, 24, 24, 24, 23, 23, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, 23, 21, 26, 22, 26, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 20, 24, 21, 24, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 12, 23, 25, 25, 25, 25, 27, 27, 26, 27, 2, 28, 24, 16, 27, 26, 27, 24, 11, 11, 26, 2, 27, 23, 26, 11, 2, 29, 11, 11, 11, 23, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 24, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 24, 2, 2, 2, 2, 2, 2, 2, 2});
    global::com.codename1.util.regex.RECharacter._fCHAR_1CLASSES = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    return;
    label10:;
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.RECharacter]
//XMLVM_END_WRAPPER[com.codename1.util.regex.RECharacter]

} // end of class: RECharacter

} // end of namespace: com.codename1.util.regex
