// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.media {
public class MediaManager: global::java.lang.Object {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: void <init>()]
}

public static global::System.Object createMedia(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.lang.String, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    _r0_o = null;
    _r0_o = global::com.codename1.media.MediaManager.createMedia((global::java.lang.String) _r1_o, 0!=_r2.i, (global::java.lang.Runnable) _r0_o);
    return (global::com.codename1.media.Media) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.lang.String, boolean)]
}

public static global::System.Object createMedia(global::java.io.InputStream n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.io.InputStream, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2_o = n2;
    _r0_o = null;
    _r0_o = global::com.codename1.media.MediaManager.createMedia((global::java.io.InputStream) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.Runnable) _r0_o);
    return (global::com.codename1.media.Media) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.io.InputStream, java.lang.String)]
}

public static global::System.Object createMedia(global::java.lang.String n1, bool n2, global::java.lang.Runnable n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.lang.String, boolean, java.lang.Runnable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    _r3_o = n3;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).createMedia((global::java.lang.String) _r1_o, 0!=_r2.i, (global::java.lang.Runnable) _r3_o);
    return (global::com.codename1.media.Media) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.lang.String, boolean, java.lang.Runnable)]
}

public static global::System.Object createMedia(global::java.io.InputStream n1, global::java.lang.String n2, global::java.lang.Runnable n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.io.InputStream, java.lang.String, java.lang.Runnable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).createMedia((global::java.io.InputStream) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.Runnable) _r3_o);
    return (global::com.codename1.media.Media) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMedia(java.io.InputStream, java.lang.String, java.lang.Runnable)]
}

public static global::System.Object createMediaRecorder(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMediaRecorder(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0_o = global::com.codename1.media.MediaManager.getAvailableRecordingMimeTypes();
    _r1.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    _r0_o = global::com.codename1.media.MediaManager.createMediaRecorder((global::java.lang.String) _r2_o, (global::java.lang.String) _r0_o);
    return (global::com.codename1.media.Media) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMediaRecorder(java.lang.String)]
}

public static global::System.Object getMediaRecorderingMimeType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: java.lang.String getMediaRecorderingMimeType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getMediaRecorderingMimeType();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: java.lang.String getMediaRecorderingMimeType()]
}

public static global::System.Object getAvailableRecordingMimeTypes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: java.lang.String[] getAvailableRecordingMimeTypes()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getAvailableRecordingMimeTypes();
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: java.lang.String[] getAvailableRecordingMimeTypes()]
}

public static global::System.Object createMediaRecorder(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMediaRecorder(java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = n1;
    _r8_o = n2;
    _r3.i = 0;
    _r2_o = global::com.codename1.media.MediaManager.getAvailableRecordingMimeTypes();
    _r0.i = 0;
    label6:;
    _r4.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r0.i >= _r4.i) goto label18;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    _r4.i = ((global::java.lang.String) _r1_o).equals((global::java.lang.Object) _r8_o) ? 1 : 0;
    if (_r4.i == 0) goto label57;
    _r3.i = 1;
    label18:;
    if (_r3.i != 0) goto label60;
    _r4_o = new global::java.lang.IllegalArgumentException();
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=Mime type 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r8_o);
    // Value= is not supported on this platform use 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    // Value=getAvailableRecordingMimeTypes()
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    ((global::java.lang.IllegalArgumentException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r4_o);
    label57:;
    _r0.i = _r0.i + 1;
    goto label6;
    label60:;
    _r4_o = global::com.codename1.ui.Display.getInstance();
    _r4_o = ((global::com.codename1.ui.Display) _r4_o).createMediaRecorder((global::java.lang.String) _r7_o, (global::java.lang.String) _r8_o);
    return (global::com.codename1.media.Media) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager: com.codename1.media.Media createMediaRecorder(java.lang.String, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.media.MediaManager]
//XMLVM_END_WRAPPER[com.codename1.media.MediaManager]

} // end of class: MediaManager

} // end of namespace: com.codename1.media
