// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.social {
public class FacebookConnect: global::com.codename1.social.Login {
private static global::com.codename1.social.FacebookConnect _finstance;

public static global::java.lang.Class _fimplClass;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _fpermissions;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    ((global::com.codename1.social.Login) _r3_o).@this();
    _r0.i = 3;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=public_profile
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 1;
    // Value=email
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 2;
    // Value=user_friends
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 115))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    ((global::com.codename1.social.FacebookConnect) _r3_o)._fpermissions = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    // Value=https://www.facebook.com/dialog/oauth
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104))}));
    ((global::com.codename1.social.FacebookConnect) _r3_o).setOauth2URL((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void <init>()]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: com.codename1.social.FacebookConnect getInstance()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = global::com.codename1.social.FacebookConnect._finstance;
    if (_r1_o != null) goto label18;
    _r1_o = global::com.codename1.social.FacebookConnect._fimplClass;
    if (_r1_o == null) goto label31;
    try {
    _r1_o = global::com.codename1.social.FacebookConnect._fimplClass;
    _r0_o = ((global::java.lang.Class) _r1_o).newInstance();
    _r0_o = _r0_o;
    global::com.codename1.social.FacebookConnect._finstance = (global::com.codename1.social.FacebookConnect) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label21;
        }
        throw ex;
    } // end catch
    label18:;
    _r1_o = global::com.codename1.social.FacebookConnect._finstance;
    return (global::com.codename1.social.FacebookConnect) _r1_o;
    label21:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r1_o;
    _r1_o = new global::com.codename1.social.FacebookImpl();
    ((global::com.codename1.social.FacebookConnect) _r1_o).@this();
    global::com.codename1.social.FacebookConnect._finstance = (global::com.codename1.social.FacebookConnect) _r1_o;
    goto label18;
    label31:;
    _r1_o = new global::com.codename1.social.FacebookImpl();
    ((global::com.codename1.social.FacebookConnect) _r1_o).@this();
    global::com.codename1.social.FacebookConnect._finstance = (global::com.codename1.social.FacebookConnect) _r1_o;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: com.codename1.social.FacebookConnect getInstance()]
}

public virtual bool isFacebookSDKSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean isFacebookSDKSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean isFacebookSDKSupported()]
}

public virtual void login(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void login()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Native facebook unsupported
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void login()]
}

public override void doLogout(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void doLogout()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    base.doLogout();
    _r0.i = ((global::com.codename1.social.FacebookConnect) _r1_o).isNativeLoginSupported() ? 1 : 0;
    if (_r0.i != 0) goto label12;
    global::com.codename1.facebook.FaceBookAccess.logOut();
    label12:;
    return;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void doLogout()]
}

public override global::System.Object getAccessToken(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: com.codename1.io.AccessToken getAccessToken()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0_o = base.getAccessToken();
    if (_r0_o == null) goto label8;
    _r1_o = _r0_o;
    label7:;
    return (global::com.codename1.io.AccessToken) _r1_o;
    label8:;
    _r1_o = new global::com.codename1.io.AccessToken();
    _r2_o = ((global::com.codename1.social.FacebookConnect) _r4_o).getToken();
    _r3_o = null;
    ((global::com.codename1.io.AccessToken) _r1_o).@this((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: com.codename1.io.AccessToken getAccessToken()]
}

public virtual bool isLoggedIn(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean isLoggedIn()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Native facebook unsupported, if you are running on the Simulator use isUserLoggedIn
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean isLoggedIn()]
}

public virtual global::System.Object getToken(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: java.lang.String getToken()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Native facebook unsupported, if you are running on the Simulator use getAccessToken
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: java.lang.String getToken()]
}

public virtual void logout(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void logout()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Native facebook unsupported, if you are running on the Simulator use doLogout
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void logout()]
}

public virtual void askPublishPermissions(global::com.codename1.social.LoginCallback n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void askPublishPermissions(com.codename1.social.LoginCallback)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Native facebook unsupported
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void askPublishPermissions(com.codename1.social.LoginCallback)]
}

public virtual bool hasPublishPermissions(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean hasPublishPermissions()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=Native facebook unsupported
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean hasPublishPermissions()]
}

public override bool isNativeLoginSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean isNativeLoginSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.social.FacebookConnect) _r1_o).isFacebookSDKSupported() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean isNativeLoginSupported()]
}

public override global::System.Object createOauth2(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: com.codename1.io.Oauth2 createOauth2()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.social.FacebookConnect) _r1_o)._fclientId;
    global::com.codename1.facebook.FaceBookAccess.setClientId((global::java.lang.String) _r0_o);
    _r0_o = ((global::com.codename1.social.FacebookConnect) _r1_o)._fclientSecret;
    global::com.codename1.facebook.FaceBookAccess.setClientSecret((global::java.lang.String) _r0_o);
    _r0_o = ((global::com.codename1.social.FacebookConnect) _r1_o)._fredirectURI;
    global::com.codename1.facebook.FaceBookAccess.setRedirectURI((global::java.lang.String) _r0_o);
    _r0_o = ((global::com.codename1.social.FacebookConnect) _r1_o)._fpermissions;
    global::com.codename1.facebook.FaceBookAccess.setPermissions((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    _r0_o = global::com.codename1.facebook.FaceBookAccess.getInstance();
    _r0_o = ((global::com.codename1.facebook.FaceBookAccess) _r0_o).createOAuth();
    return (global::com.codename1.io.Oauth2) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: com.codename1.io.Oauth2 createOauth2()]
}

public override void nativelogin(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void nativelogin()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.social.FacebookConnect) _r0_o).login();
    return;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void nativelogin()]
}

public override void nativeLogout(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void nativeLogout()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.social.FacebookConnect) _r0_o).logout();
    return;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void nativeLogout()]
}

public override bool nativeIsLoggedIn(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean nativeIsLoggedIn()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.social.FacebookConnect) _r1_o).isLoggedIn() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean nativeIsLoggedIn()]
}

public virtual void inviteFriends(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void inviteFriends(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void inviteFriends(java.lang.String, java.lang.String)]
}

public virtual void inviteFriends(global::java.lang.String n1, global::java.lang.String n2, global::com.codename1.util.Callback n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: void inviteFriends(java.lang.String, java.lang.String, com.codename1.util.Callback)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    return;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: void inviteFriends(java.lang.String, java.lang.String, com.codename1.util.Callback)]
}

public virtual bool isInviteFriendsSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean isInviteFriendsSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean isInviteFriendsSupported()]
}

public override bool validateToken(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect: boolean validateToken(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r2.i = 1;
    _r3.i = 0;
    _r1_o = new global::org.xmlvm._nArrayAdapter<bool>(new bool[_r2.i]);
    ((global::org.xmlvm._nArrayAdapter<bool>) _r1_o)[_r3.i] = 0!=_r2.i;
    _r0_o = new global::com.codename1.social.FacebookConnect_21();
    ((global::com.codename1.social.FacebookConnect_21) _r0_o).@this((global::com.codename1.social.FacebookConnect) _r4_o, (global::org.xmlvm._nArrayAdapter<bool>) _r1_o);
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setPost(0!=_r3.i);
    // Value=https://graph.facebook.com/v2.4/me
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.io.ConnectionRequest) _r0_o).setUrl((global::java.lang.String) _r2_o);
    // Value=access_token
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.io.ConnectionRequest) _r0_o).addArgumentNoEncoding((global::java.lang.String) _r2_o, (global::java.lang.String) _r5_o);
    _r2_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r2_o).addToQueueAndWait((global::com.codename1.io.ConnectionRequest) _r0_o);
    _r2.i = ((global::org.xmlvm._nArrayAdapter<bool>) _r1_o)[_r3.i] ? 1 : 0;
    return _r2.i!=0;
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect: boolean validateToken(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.social.FacebookConnect]
//XMLVM_END_WRAPPER[com.codename1.social.FacebookConnect]

} // end of class: FacebookConnect
} // end of namespace: com.codename1.social
