// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Math: global::java.lang.Object {












public static double _fE = 2.718281828459045D;

public static double _fPI = 3.141592653589793D;

private static global::java.util.Random _frandom;

new private void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.Math: void <init>()]
}

public static double abs(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double abs(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    _r4.d = n1;
    _r0.l = global::java.lang.Double.doubleToLongBits((double) _r4.d);
    _r2.l = 9223372036854775807L;
    _r0.l = _r0.l & _r2.l;
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Math: double abs(double)]
}

public static float abs(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float abs(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r2.f = n1;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r2.f);
    _r1.i = 2147483647;
    _r0.i = _r0.i & _r1.i;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Math: float abs(float)]
}

public static int abs(int n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: int abs(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    if (_r1.i < 0) goto label4;
    _r0.i = _r1.i;
    label3:;
    return _r0.i;
    label4:;
    _r0.i = -_r1.i;
    goto label3;
//XMLVM_END_WRAPPER[java.lang.Math: int abs(int)]
}

public static long abs(long n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: long abs(long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    _r2.l = n1;
    _r0.l = 0L;
    _r0.i = _r2.l > _r0.l ? 1 : (_r2.l == _r0.l ? 0 : -1);
    if (_r0.i < 0) goto label8;
    _r0.l = _r2.l;
    label7:;
    return _r0.l;
    label8:;
    _r0.l = -_r2.l;
    goto label7;
//XMLVM_END_WRAPPER[java.lang.Math: long abs(long)]
}

public static double acos(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double acos(double)]
    return global::System.Math.Acos(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double acos(double)]
}

public static double asin(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double asin(double)]
    return global::System.Math.Asin(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double asin(double)]
}

public static double atan(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double atan(double)]
    return global::System.Math.Atan(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double atan(double)]
}

public static double atan2(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double atan2(double, double)]
    return global::System.Math.Atan2(n1, n2);
//XMLVM_END_WRAPPER[java.lang.Math: double atan2(double, double)]
}

public static double cbrt(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double cbrt(double)]
    return global::System.Math.Pow(n1, 1.0D/3.0D);
//XMLVM_END_WRAPPER[java.lang.Math: double cbrt(double)]
}

public static double ceil(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double ceil(double)]
    return global::System.Math.Ceiling(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double ceil(double)]
}

public static double cos(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double cos(double)]
    return global::System.Math.Cos(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double cos(double)]
}

public static double cosh(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double cosh(double)]
    return global::System.Math.Cosh(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double cosh(double)]
}

public static double exp(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double exp(double)]
    return global::System.Math.Exp(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double exp(double)]
}

public static double expm1(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double expm1(double)]
    // return global::System.Math.Exp(n1) - 1;
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.Math: double expm1(double)]
}

public static double floor(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double floor(double)]
    return global::System.Math.Floor(n1);
    // also works:
    // return -ceil(-n1);
//XMLVM_END_WRAPPER[java.lang.Math: double floor(double)]
}

public static double hypot(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double hypot(double, double)]
    double x = global::System.Math.Abs(n1);
    double y = global::System.Math.Abs(n2);
    if(y==0D) {
        return x;
    } else if(x<=y) {
        x = x/y;
        return y * global::System.Math.Sqrt(1+x*x);
    } else {
        // at this point 0<y<x
        y = y/x;
        return x * global::System.Math.Sqrt(1+y*y);
    }
//XMLVM_END_WRAPPER[java.lang.Math: double hypot(double, double)]
}

public static double IEEEremainder(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double IEEEremainder(double, double)]
    return global::System.Math.IEEERemainder(n1, n2);
//XMLVM_END_WRAPPER[java.lang.Math: double IEEEremainder(double, double)]
}

public static double log(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double log(double)]
    return global::System.Math.Log(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double log(double)]
}

public static double log10(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double log10(double)]
    return global::System.Math.Log10(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double log10(double)]
}

public static double log1p(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double log1p(double)]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.Math: double log1p(double)]
}

public static double max(double n1, double n2){
    if (n1 > n2) return n1;
    return n2;
}

public static float max(float n1, float n2){
    if (n1 > n2) return n1;
    return n2;
}

public static int max(int n1, int n2){
    if (n1 > n2) return n1;
    return n2;
}

public static long max(long n1, long n2){
    if (n1 > n2) return n1;
    return n2;
}

public static double min(double n1, double n2){
    if (n1 < n2) return n1;
    return n2;
}

public static float min(float n1, float n2){
    if (n1 < n2) return n1;
    return n2;
}

public static int min(int n1, int n2){
    if (n1 < n2) return n1;
    return n2;
}

public static long min(long n1, long n2){
    if (n1 < n2) return n1;
    return n2;
}

public static double pow(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double pow(double, double)]
    return global::System.Math.Pow(n1, n2);
//XMLVM_END_WRAPPER[java.lang.Math: double pow(double, double)]
}

public static double rint(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double rint(double)]
    return global::System.Convert.ToInt64(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double rint(double)]
}

public static long round(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: long round(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    _r2.d = n1;
    _r0.i = _r2.d > _r2.d ? 1 : (_r2.d == _r2.d ? 0 : -1);
    if (_r0.i == 0) goto label7;
    _r0.l = 0L;
    label6:;
    return _r0.l;
    label7:;
    _r0.d = 0.5D;
    _r0.d = _r0.d + _r2.d;
    _r0.d = global::java.lang.Math.floor((double) _r0.d);
    _r0.l = (long) _r0.d;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.Math: long round(double)]
}

public static int round(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: int round(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    _r2.f = n1;
    _r0.i = _r2.f > _r2.f ? 1 : (_r2.f == _r2.f ? 0 : -1);
    if (_r0.i == 0) goto label6;
    _r0.i = 0;
    label5:;
    return _r0.i;
    label6:;
    _r0.f = (float)0.5D;
    _r0.f = _r0.f + _r2.f;
    _r0.d = (double) _r0.f;
    _r0.d = global::java.lang.Math.floor((double) _r0.d);
    _r0.i = (int) _r0.d;
    goto label5;
//XMLVM_END_WRAPPER[java.lang.Math: int round(float)]
}

public static double signum(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double signum(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    _r2.d = n1;
    _r0.d = global::java.lang.StrictMath.signum((double) _r2.d);
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Math: double signum(double)]
}

public static float signum(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float signum(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    _r1.f = n1;
    _r0.f = global::java.lang.StrictMath.signum((float) _r1.f);
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Math: float signum(float)]
}

public static double sin(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double sin(double)]
    return global::System.Math.Sin(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double sin(double)]
}

public static double sinh(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double sinh(double)]
    return global::System.Math.Sinh(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double sinh(double)]
}

public static double sqrt(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double sqrt(double)]
    return global::System.Math.Sqrt(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double sqrt(double)]
}

public static double tan(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double tan(double)]
    return global::System.Math.Tan(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double tan(double)]
}

public static double tanh(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double tanh(double)]
    return global::System.Math.Tanh(n1);
//XMLVM_END_WRAPPER[java.lang.Math: double tanh(double)]
}

public static double random(){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double random()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0_o = global::java.lang.Math._frandom;
    if (_r0_o != null) goto label11;
    _r0_o = new global::java.util.Random();
    ((global::java.util.Random) _r0_o).@this();
    global::java.lang.Math._frandom = (global::java.util.Random) _r0_o;
    label11:;
    _r0_o = global::java.lang.Math._frandom;
    _r0.d = ((global::java.util.Random) _r0_o).nextDouble();
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Math: double random()]
}

public static double toRadians(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double toRadians(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    _r4.d = n1;
    _r0.d = 180.0D;
    _r0.d = _r4.d / _r0.d;
    _r2.d = 3.141592653589793D;
    _r0.d = _r0.d * _r2.d;
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Math: double toRadians(double)]
}

public static double toDegrees(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double toDegrees(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    _r4.d = n1;
    _r0.d = 180.0D;
    _r0.d = _r0.d * _r4.d;
    _r2.d = 3.141592653589793D;
    _r0.d = _r0.d / _r2.d;
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Math: double toDegrees(double)]
}

public static double ulp(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double ulp(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    _r4.d = n1;
    _r2.d = 1.7976931348623157E308D;
    _r0.i = global::java.lang.Double.isInfinite((double) _r4.d) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0.d = global::System.Double.PositiveInfinity;
    label13:;
    return _r0.d;
    label14:;
    _r0.i = _r4.d > _r2.d ? 1 : (_r4.d == _r2.d ? 0 : -1);
    if (_r0.i == 0) goto label27;
    _r0.d = -1.7976931348623157E308D;
    _r0.i = _r4.d > _r0.d ? 1 : (_r4.d == _r0.d ? 0 : -1);
    if (_r0.i != 0) goto label39;
    label27:;
    _r0.d = 2.0D;
    _r2.d = 971.0D;
    _r0.d = global::java.lang.Math.pow((double) _r0.d, (double) _r2.d);
    goto label13;
    label39:;
    _r0.d = global::java.lang.Math.abs((double) _r4.d);
    _r2.d = global::java.lang.Math.nextafter((double) _r0.d, (double) _r2.d);
    _r0.d = _r2.d - _r0.d;
    goto label13;
//XMLVM_END_WRAPPER[java.lang.Math: double ulp(double)]
}

public static float ulp(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float ulp(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    _r4.f = n1;
    _r1.f = (float)3.4028235E38D;
    _r0.i = global::java.lang.Float.isNaN((float) _r4.f) ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0.f = global::System.Single.NaN;
    label11:;
    return _r0.f;
    label12:;
    _r0.i = global::java.lang.Float.isInfinite((float) _r4.f) ? 1 : 0;
    if (_r0.i == 0) goto label21;
    _r0.f = global::System.Single.PositiveInfinity;
    goto label11;
    label21:;
    _r0.i = _r4.f > _r1.f ? 1 : (_r4.f == _r1.f ? 0 : -1);
    if (_r0.i == 0) goto label32;
    _r0.f = (float)-3.4028235E38D;
    _r0.i = _r4.f > _r0.f ? 1 : (_r4.f == _r0.f ? 0 : -1);
    if (_r0.i != 0) goto label42;
    label32:;
    _r0.d = 2.0D;
    _r2.d = 104.0D;
    _r0.d = global::java.lang.Math.pow((double) _r0.d, (double) _r2.d);
    _r0.f = (float) _r0.d;
    goto label11;
    label42:;
    _r0.f = global::java.lang.Math.abs((float) _r4.f);
    _r1.f = global::java.lang.Math.nextafterf((float) _r0.f, (float) _r1.f);
    _r0.f = _r1.f - _r0.f;
    goto label11;
//XMLVM_END_WRAPPER[java.lang.Math: float ulp(float)]
}

private static double nextafter(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double nextafter(double, double)]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.Math: double nextafter(double, double)]
}

private static float nextafterf(float n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float nextafterf(float, float)]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.Math: float nextafterf(float, float)]
}

public static double copySign(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double copySign(double, double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    _r6.d = n1;
    _r8.d = n2;
    _r0.l = global::java.lang.Double.doubleToRawLongBits((double) _r6.d);
    _r2.l = global::java.lang.Double.doubleToRawLongBits((double) _r8.d);
    _r4.l = 9223372036854775807L;
    _r0.l = _r0.l & _r4.l;
    _r4.l = -9223372036854775808L;
    _r2.l = _r2.l & _r4.l;
    _r0.l = _r0.l | _r2.l;
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Math: double copySign(double, double)]
}

public static float copySign(float n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float copySign(float, float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r3.f = n1;
    _r4.f = n2;
    _r0.i = global::java.lang.Float.floatToRawIntBits((float) _r3.f);
    _r1.i = global::java.lang.Float.floatToRawIntBits((float) _r4.f);
    _r2.i = 2147483647;
    _r0.i = _r0.i & _r2.i;
    _r2.i = -2147483648;
    _r1.i = _r1.i & _r2.i;
    _r0.i = _r0.i | _r1.i;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Math: float copySign(float, float)]
}

public static int getExponent(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: int getExponent(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r2.f = n1;
    _r0.i = global::java.lang.Float.floatToRawIntBits((float) _r2.f);
    _r1.i = 2139095040;
    _r0.i = _r0.i & _r1.i;
    _r0.i = _r0.i >> (0x1f & 23);
    _r1.i = 127;
    _r0.i = _r0.i - _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Math: int getExponent(float)]
}

public static int getExponent(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: int getExponent(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    _r4.d = n1;
    _r0.l = global::java.lang.Double.doubleToRawLongBits((double) _r4.d);
    _r2.l = 9218868437227405312L;
    _r0.l = _r0.l & _r2.l;
    _r2.i = 52;
    _r0.l = _r0.l >> (0x3f & _r2.i);
    _r0.i = (int) _r0.l;
    _r1.i = 1023;
    _r0.i = _r0.i - _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Math: int getExponent(double)]
}

public static double nextAfter(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double nextAfter(double, double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    _r3.d = n1;
    _r5.d = n2;
    _r1.d = 0.0D;
    _r0.i = _r1.d > _r3.d ? 1 : (_r1.d == _r3.d ? 0 : -1);
    if (_r0.i != 0) goto label12;
    _r0.i = _r1.d > _r5.d ? 1 : (_r1.d == _r5.d ? 0 : -1);
    if (_r0.i != 0) goto label12;
    _r0.d = _r5.d;
    label11:;
    return _r0.d;
    label12:;
    _r0.d = global::java.lang.Math.nextafter((double) _r3.d, (double) _r5.d);
    goto label11;
//XMLVM_END_WRAPPER[java.lang.Math: double nextAfter(double, double)]
}

public static float nextAfter(float n1, double n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float nextAfter(float, double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r7.f = n1;
    _r8.d = n2;
    _r6.f = (float)3.4028235E38D;
    _r5.f = (float)1.4E-45D;
    _r4.f = (float)-3.4028235E38D;
    _r3.f = (float)-1.4E-45D;
    _r2.f = (float)0.0D;
    _r0.i = global::java.lang.Float.isNaN((float) _r7.f) ? 1 : 0;
    if (_r0.i != 0) goto label23;
    _r0.i = global::java.lang.Double.isNaN((double) _r8.d) ? 1 : 0;
    if (_r0.i == 0) goto label26;
    label23:;
    _r0.f = global::System.Single.NaN;
    label25:;
    return _r0.f;
    label26:;
    _r0.i = _r2.f > _r7.f ? 1 : (_r2.f == _r7.f ? 0 : -1);
    if (_r0.i != 0) goto label46;
    _r0.d = 0.0D;
    _r0.i = _r0.d > _r8.d ? 1 : (_r0.d == _r8.d ? 0 : -1);
    if (_r0.i != 0) goto label46;
    _r0_o = new global::java.lang.Float();
    ((global::java.lang.Float) _r0_o).@this((double) _r8.d);
    _r0.f = ((global::java.lang.Float) _r0_o).floatValue();
    goto label25;
    label46:;
    _r0.i = _r7.f > _r5.f ? 1 : (_r7.f == _r5.f ? 0 : -1);
    if (_r0.i != 0) goto label55;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i < 0) goto label64;
    label55:;
    _r0.i = _r7.f > _r3.f ? 1 : (_r7.f == _r3.f ? 0 : -1);
    if (_r0.i != 0) goto label73;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i <= 0) goto label73;
    label64:;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i <= 0) goto label70;
    _r0.f = _r2.f;
    goto label25;
    label70:;
    _r0.f = (float)-0.0D;
    goto label25;
    label73:;
    _r0.i = global::java.lang.Float.isInfinite((float) _r7.f) ? 1 : 0;
    if (_r0.i == 0) goto label92;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i == 0) goto label92;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i <= 0) goto label90;
    _r0.f = _r6.f;
    goto label25;
    label90:;
    _r0.f = _r4.f;
    goto label25;
    label92:;
    _r0.i = _r7.f > _r6.f ? 1 : (_r7.f == _r6.f ? 0 : -1);
    if (_r0.i != 0) goto label101;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i > 0) goto label110;
    label101:;
    _r0.i = _r7.f > _r4.f ? 1 : (_r7.f == _r4.f ? 0 : -1);
    if (_r0.i != 0) goto label120;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i >= 0) goto label120;
    label110:;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i <= 0) goto label117;
    _r0.f = global::System.Single.PositiveInfinity;
    goto label25;
    label117:;
    _r0.f = global::System.Single.NegativeInfinity;
    goto label25;
    label120:;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i <= 0) goto label159;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i <= 0) goto label140;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r7.f);
    _r0.i = _r0.i + 1;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label25;
    label140:;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i >= 0) goto label156;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r7.f);
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label25;
    label156:;
    _r0.f = _r5.f;
    goto label25;
    label159:;
    _r0.d = (double) _r7.f;
    _r0.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r0.i >= 0) goto label199;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i <= 0) goto label180;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r7.f);
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label25;
    label180:;
    _r0.i = _r7.f > _r2.f ? 1 : (_r7.f == _r2.f ? 0 : -1);
    if (_r0.i >= 0) goto label196;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r7.f);
    _r0.i = _r0.i + 1;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label25;
    label196:;
    _r0.f = _r3.f;
    goto label25;
    label199:;
    _r0_o = new global::java.lang.Float();
    ((global::java.lang.Float) _r0_o).@this((double) _r8.d);
    _r0.f = ((global::java.lang.Float) _r0_o).floatValue();
    goto label25;
//XMLVM_END_WRAPPER[java.lang.Math: float nextAfter(float, double)]
}

public static double nextUp(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double nextUp(double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    _r7.d = n1;
    _r5.l = 1L;
    _r3.d = global::System.Double.PositiveInfinity;
    _r1.d = 0.0D;
    _r0.i = global::java.lang.Double.isNaN((double) _r7.d) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r0.d = global::System.Double.NaN;
    label14:;
    return _r0.d;
    label15:;
    _r0.i = _r7.d > _r3.d ? 1 : (_r7.d == _r3.d ? 0 : -1);
    if (_r0.i != 0) goto label21;
    _r0.d = _r3.d;
    goto label14;
    label21:;
    _r0.i = _r1.d > _r7.d ? 1 : (_r1.d == _r7.d ? 0 : -1);
    if (_r0.i != 0) goto label28;
    _r0.d = 4.9E-324D;
    goto label14;
    label28:;
    _r0.i = _r1.d > _r7.d ? 1 : (_r1.d == _r7.d ? 0 : -1);
    if (_r0.i >= 0) goto label42;
    _r0.l = global::java.lang.Double.doubleToLongBits((double) _r7.d);
    _r0.l = _r0.l + _r5.l;
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    goto label14;
    label42:;
    _r0.l = global::java.lang.Double.doubleToLongBits((double) _r7.d);
    _r0.l = _r0.l - _r5.l;
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    goto label14;
//XMLVM_END_WRAPPER[java.lang.Math: double nextUp(double)]
}

public static float nextUp(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float nextUp(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r3.f = n1;
    _r2.f = global::System.Single.PositiveInfinity;
    _r1.f = (float)0.0D;
    _r0.i = global::java.lang.Float.isNaN((float) _r3.f) ? 1 : 0;
    if (_r0.i == 0) goto label12;
    _r0.f = global::System.Single.NaN;
    label11:;
    return _r0.f;
    label12:;
    _r0.i = _r3.f > _r2.f ? 1 : (_r3.f == _r2.f ? 0 : -1);
    if (_r0.i != 0) goto label18;
    _r0.f = _r2.f;
    goto label11;
    label18:;
    _r0.i = _r1.f > _r3.f ? 1 : (_r1.f == _r3.f ? 0 : -1);
    if (_r0.i != 0) goto label24;
    _r0.f = (float)1.4E-45D;
    goto label11;
    label24:;
    _r0.i = _r1.f > _r3.f ? 1 : (_r1.f == _r3.f ? 0 : -1);
    if (_r0.i >= 0) goto label39;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r3.f);
    _r0.i = _r0.i + 1;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label11;
    label39:;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r3.f);
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label11;
//XMLVM_END_WRAPPER[java.lang.Math: float nextUp(float)]
}

public static double scalb(double n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: double scalb(double, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r10;
    _r8.d = n1;
    _r10.i = n2;
    _r0.i = global::java.lang.Double.isNaN((double) _r8.d) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0.i = global::java.lang.Double.isInfinite((double) _r8.d) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0.d = 0.0D;
    _r0.i = _r0.d > _r8.d ? 1 : (_r0.d == _r8.d ? 0 : -1);
    if (_r0.i != 0) goto label19;
    label18:;
    return _r8.d;
    label19:;
    _r0.l = global::java.lang.Double.doubleToLongBits((double) _r8.d);
    _r2.l = -9223372036854775808L;
    _r2.l = _r2.l & _r0.l;
    _r4.l = 9218868437227405312L;
    _r4.l = _r4.l & _r0.l;
    _r6.i = 52;
    _r4.l = _r4.l >> (0x3f & _r6.i);
    _r6.l = 1023L;
    _r4.l = _r4.l - _r6.l;
    _r6.l = (long) _r10.i;
    _r4.l = _r4.l + _r6.l;
    _r6.l = 9223372036854775807L;
    _r6.l = _r6.l & _r0.l;
    _r10.i = global::java.lang.Long.numberOfLeadingZeros((long) _r6.l);
    _r6.i = 12;
    _r10.i = _r10.i - _r6.i;
    if (_r10.i >= 0) goto label68;
    _r10.i = 0;
    label53:;
    _r6.l = 1023L;
    _r6.i = _r4.l > _r6.l ? 1 : (_r4.l == _r6.l ? 0 : -1);
    if (_r6.i <= 0) goto label74;
    _r0.d = 0.0D;
    _r8.i = _r8.d > _r0.d ? 1 : (_r8.d == _r0.d ? 0 : -1);
    if (_r8.i <= 0) goto label71;
    _r8.d = global::System.Double.PositiveInfinity;
    goto label18;
    label68:;
    _r6.l = (long) _r10.i;
    _r4.l = _r4.l - _r6.l;
    goto label53;
    label71:;
    _r8.d = global::System.Double.NegativeInfinity;
    goto label18;
    label74:;
    _r6.l = -1023L;
    _r6.i = _r4.l > _r6.l ? 1 : (_r4.l == _r6.l ? 0 : -1);
    if (_r6.i > 0) goto label129;
    _r6.l = 1023L;
    _r4.l = _r4.l + _r6.l;
    _r6.l = (long) _r10.i;
    _r4.l = _r4.l + _r6.l;
    _r8.d = global::java.lang.Math.abs((double) _r8.d);
    _r6.d = 2.2250738585072014E-308D;
    _r8.i = _r8.d > _r6.d ? 1 : (_r8.d == _r6.d ? 0 : -1);
    if (_r8.i >= 0) goto label111;
    _r8.l = 4503599627370495L;
    _r8.l = _r8.l & _r0.l;
    _r8.l = global::java.lang.Math.shiftLongBits((long) _r8.l, (long) _r4.l);
    label105:;
    _r8.l = _r8.l | _r2.l;
    _r8.d = global::java.lang.Double.longBitsToDouble((long) _r8.l);
    goto label18;
    label111:;
    _r8.l = 4503599627370495L;
    _r8.l = _r8.l & _r0.l;
    _r0.l = 4503599627370496L;
    _r8.l = _r8.l | _r0.l;
    _r0.l = 1L;
    _r0.l = _r4.l - _r0.l;
    _r8.l = global::java.lang.Math.shiftLongBits((long) _r8.l, (long) _r0.l);
    goto label105;
    label129:;
    _r8.d = global::java.lang.Math.abs((double) _r8.d);
    _r6.d = 2.2250738585072014E-308D;
    _r8.i = _r8.d > _r6.d ? 1 : (_r8.d == _r6.d ? 0 : -1);
    if (_r8.i < 0) goto label153;
    _r8.l = 1023L;
    _r8.l = _r8.l + _r4.l;
    _r10.i = 52;
    _r8.l = _r8.l << (0x3f & _r10.i);
    _r4.l = 4503599627370495L;
    _r0.l = _r0.l & _r4.l;
    _r8.l = _r8.l | _r0.l;
    goto label105;
    label153:;
    _r8.l = 1023L;
    _r8.l = _r8.l + _r4.l;
    _r4.i = 52;
    _r8.l = _r8.l << (0x3f & _r4.i);
    _r10.i = _r10.i + 1;
    _r0.l = _r0.l << (0x3f & _r10.i);
    _r4.l = 4503599627370495L;
    _r0.l = _r0.l & _r4.l;
    _r8.l = _r8.l | _r0.l;
    goto label105;
//XMLVM_END_WRAPPER[java.lang.Math: double scalb(double, int)]
}

public static float scalb(float n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: float scalb(float, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    _r10.f = n1;
    _r11.i = n2;
    _r8.i = 127;
    _r7.f = (float)1.17549435E-38D;
    _r6.f = (float)0.0D;
    _r5.i = 8388607;
    _r0.i = global::java.lang.Float.isNaN((float) _r10.f) ? 1 : 0;
    if (_r0.i != 0) goto label24;
    _r0.i = global::java.lang.Float.isInfinite((float) _r10.f) ? 1 : 0;
    if (_r0.i != 0) goto label24;
    _r0.i = _r6.f > _r10.f ? 1 : (_r6.f == _r10.f ? 0 : -1);
    if (_r0.i != 0) goto label26;
    label24:;
    _r0.f = _r10.f;
    label25:;
    return _r0.f;
    label26:;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r10.f);
    _r1.i = -2147483648;
    _r1.i = _r1.i & _r0.i;
    _r2.i = 2139095040;
    _r2.i = _r2.i & _r0.i;
    _r2.i = _r2.i >> (0x1f & 23);
    _r2.i = _r2.i - _r8.i;
    _r2.i = _r2.i + _r11.i;
    _r3.i = 2147483647;
    _r3.i = _r3.i & _r0.i;
    _r3.i = global::java.lang.Integer.numberOfLeadingZeros((int) _r3.i);
    _r4.i = 9;
    _r3.i = _r3.i - _r4.i;
    if (_r3.i >= 0) goto label66;
    _r3.i = 0;
    _r9.i = _r3.i;
    _r3.i = _r2.i;
    _r2.i = _r9.i;
    label57:;
    if (_r3.i <= _r8.i) goto label74;
    _r0.i = _r10.f > _r6.f ? 1 : (_r10.f == _r6.f ? 0 : -1);
    if (_r0.i <= 0) goto label71;
    _r0.f = global::System.Single.PositiveInfinity;
    goto label25;
    label66:;
    _r2.i = _r2.i - _r3.i;
    _r9.i = _r3.i;
    _r3.i = _r2.i;
    _r2.i = _r9.i;
    goto label57;
    label71:;
    _r0.f = global::System.Single.NegativeInfinity;
    goto label25;
    label74:;
    _r4.i = -127;
    if (_r3.i > _r4.i) goto label111;
    _r3.i = _r3.i + 127;
    _r2.i = _r2.i + _r3.i;
    _r3.f = global::java.lang.Math.abs((float) _r10.f);
    _r3.i = _r3.f > _r7.f ? 1 : (_r3.f == _r7.f ? 0 : -1);
    if (_r3.i >= 0) goto label100;
    _r0.i = _r0.i & _r5.i;
    _r0.i = global::java.lang.Math.shiftIntBits((int) _r0.i, (int) _r2.i);
    label94:;
    _r0.i = _r0.i | _r1.i;
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    goto label25;
    label100:;
    _r0.i = _r0.i & _r5.i;
    _r3.i = 8388608;
    _r0.i = _r0.i | _r3.i;
    _r3.i = 1;
    _r2.i = _r2.i - _r3.i;
    _r0.i = global::java.lang.Math.shiftIntBits((int) _r0.i, (int) _r2.i);
    goto label94;
    label111:;
    _r4.f = global::java.lang.Math.abs((float) _r10.f);
    _r4.i = _r4.f > _r7.f ? 1 : (_r4.f == _r7.f ? 0 : -1);
    if (_r4.i < 0) goto label126;
    _r2.i = _r3.i + 127;
    _r2.i = _r2.i << (0x1f & 23);
    _r0.i = _r0.i & _r5.i;
    _r0.i = _r0.i | _r2.i;
    goto label94;
    label126:;
    _r3.i = _r3.i + 127;
    _r3.i = _r3.i << (0x1f & 23);
    _r2.i = _r2.i + 1;
    _r0.i = _r0.i << (0x1f & _r2.i);
    _r0.i = _r0.i & _r5.i;
    _r0.i = _r0.i | _r3.i;
    goto label94;
//XMLVM_END_WRAPPER[java.lang.Math: float scalb(float, int)]
}

private static int shiftIntBits(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: int shiftIntBits(int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r5.i = n1;
    _r6.i = n2;
    _r3.i = 0;
    _r4.i = 1;
    if (_r6.i <= 0) goto label7;
    _r0.i = _r5.i << (0x1f & _r6.i);
    label6:;
    return _r0.i;
    label7:;
    _r0.i = -_r6.i;
    _r1.i = 2147483647;
    _r1.i = _r1.i & _r5.i;
    _r1.i = global::java.lang.Integer.numberOfLeadingZeros((int) _r1.i);
    _r2.i = 32;
    _r2.i = _r2.i - _r0.i;
    if (_r1.i <= _r2.i) goto label23;
    _r0.i = _r3.i;
    goto label6;
    label23:;
    _r1.i = _r5.i >> (0x1f & _r0.i);
    _r2.i = _r0.i - _r4.i;
    _r2.i = _r5.i >> (0x1f & _r2.i);
    _r2.i = _r2.i & 1;
    if (_r2.i != _r4.i) goto label60;
    _r2.i = _r4.i;
    label34:;
    if (_r2.i == 0) goto label62;
    _r2.i = global::java.lang.Integer.numberOfTrailingZeros((int) _r5.i);
    _r3.i = _r0.i - _r4.i;
    if (_r2.i >= _r3.i) goto label46;
    _r1.i = _r1.i + 1;
    label46:;
    _r2.i = global::java.lang.Integer.numberOfTrailingZeros((int) _r5.i);
    _r0.i = _r0.i - _r4.i;
    if (_r2.i != _r0.i) goto label62;
    _r0.i = _r1.i & 1;
    if (_r0.i != _r4.i) goto label62;
    _r0.i = _r1.i + 1;
    goto label6;
    label60:;
    _r2.i = _r3.i;
    goto label34;
    label62:;
    _r0.i = _r1.i;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.Math: int shiftIntBits(int, int)]
}

private static long shiftLongBits(long n1, long n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Math: long shiftLongBits(long, long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r12;
    _r10.l = n1;
    _r12.l = n2;
    _r6.l = 0L;
    _r8.l = 1L;
    _r0.i = _r12.l > _r6.l ? 1 : (_r12.l == _r6.l ? 0 : -1);
    if (_r0.i <= 0) goto label12;
    _r0.i = (int) _r12.l;
    _r0.l = _r10.l << (0x3f & _r0.i);
    label11:;
    return _r0.l;
    label12:;
    _r0.l = -_r12.l;
    _r2.l = 9223372036854775807L;
    _r2.l = _r2.l & _r10.l;
    _r2.i = global::java.lang.Long.numberOfLeadingZeros((long) _r2.l);
    _r2.l = (long) _r2.i;
    _r4.l = 64L;
    _r4.l = _r4.l - _r0.l;
    _r2.i = _r2.l > _r4.l ? 1 : (_r2.l == _r4.l ? 0 : -1);
    if (_r2.i <= 0) goto label33;
    _r0.l = _r6.l;
    goto label11;
    label33:;
    _r2.i = (int) _r0.l;
    _r2.l = _r10.l >> (0x3f & _r2.i);
    _r4.l = _r0.l - _r8.l;
    _r4.i = (int) _r4.l;
    _r4.l = _r10.l >> (0x3f & _r4.i);
    _r4.l = _r4.l & _r8.l;
    _r4.i = _r4.l > _r8.l ? 1 : (_r4.l == _r8.l ? 0 : -1);
    if (_r4.i != 0) goto label80;
    _r4.i = 1;
    label47:;
    if (_r4.i == 0) goto label82;
    _r4.i = global::java.lang.Long.numberOfTrailingZeros((long) _r10.l);
    _r4.l = (long) _r4.i;
    _r6.l = _r0.l - _r8.l;
    _r4.i = _r4.l > _r6.l ? 1 : (_r4.l == _r6.l ? 0 : -1);
    if (_r4.i >= 0) goto label61;
    _r2.l = _r2.l + _r8.l;
    label61:;
    _r4.i = global::java.lang.Long.numberOfTrailingZeros((long) _r10.l);
    _r4.l = (long) _r4.i;
    _r0.l = _r0.l - _r8.l;
    _r0.i = _r4.l > _r0.l ? 1 : (_r4.l == _r0.l ? 0 : -1);
    if (_r0.i != 0) goto label82;
    _r0.l = _r2.l & _r8.l;
    _r0.i = _r0.l > _r8.l ? 1 : (_r0.l == _r8.l ? 0 : -1);
    if (_r0.i != 0) goto label82;
    _r0.l = _r2.l + _r8.l;
    goto label11;
    label80:;
    _r4.i = 0;
    goto label47;
    label82:;
    _r0.l = _r2.l;
    goto label11;
//XMLVM_END_WRAPPER[java.lang.Math: long shiftLongBits(long, long)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Math]
//XMLVM_END_WRAPPER[java.lang.Math]

} // end of class: Math

} // end of namespace: java.lang
