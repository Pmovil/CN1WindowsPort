// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.models {
public class CategorySeries: global::java.lang.Object {
private global::java.lang.String _fmTitle;

private global::java.util.List _fmCategories;

private global::java.util.List _fmValues;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmCategories = (global::java.util.List) _r0_o;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmValues = (global::java.util.List) _r0_o;
    ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmTitle = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: void <init>(java.lang.String)]
}

public virtual global::System.Object getTitle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: java.lang.String getTitle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmTitle;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: java.lang.String getTitle()]
}

public virtual void add(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: void add(double)]
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
    _r2_o = this;
    _r3.d = n1;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::com.codename1.charts.models.CategorySeries) _r2_o)._fmCategories;
    _r1.i = ((global::java.util.List) _r1_o).size();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::com.codename1.charts.models.CategorySeries) _r2_o).add((global::java.lang.String) _r0_o, (double) _r3.d);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label31;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return;
    label31:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: void add(double)]
}

public virtual void add(global::java.lang.String n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: void add(java.lang.String, double)]
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
    _r4.d = n2;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r2_o)._fmCategories;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r3_o);
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r2_o)._fmValues;
    _r1_o = global::java.lang.Double.valueOf((double) _r4.d);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return;
    label17:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: void add(java.lang.String, double)]
}

public virtual void set(int n1, global::java.lang.String n2, double n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: void set(int, java.lang.String, double)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r5.d = n3;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r2_o)._fmCategories;
    ((global::java.util.List) _r0_o).set((int) _r3.i, (global::java.lang.Object) _r4_o);
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r2_o)._fmValues;
    _r1_o = global::java.lang.Double.valueOf((double) _r5.d);
    ((global::java.util.List) _r0_o).set((int) _r3.i, (global::java.lang.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return;
    label17:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: void set(int, java.lang.String, double)]
}

public virtual void remove(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: void remove(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmCategories;
    ((global::java.util.List) _r0_o).remove((int) _r2.i);
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmValues;
    ((global::java.util.List) _r0_o).remove((int) _r2.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label13;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label13:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: void remove(int)]
}

public virtual void clear(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: void clear()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmCategories;
    ((global::java.util.List) _r0_o).clear();
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmValues;
    ((global::java.util.List) _r0_o).clear();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label13;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label13:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: void clear()]
}

public virtual double getValue(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: double getValue(int)]
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
    _r3.i = n1;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r2_o)._fmValues;
    _r0_o = ((global::java.util.List) _r0_o).get((int) _r3.i);
    _r0_o = _r0_o;
    _r0.d = ((global::java.lang.Double) _r0_o).doubleValue();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label15;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return _r0.d;
    label15:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: double getValue(int)]
}

public virtual global::System.Object getCategory(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: java.lang.String getCategory(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmCategories;
    _r0_o = ((global::java.util.List) _r0_o).get((int) _r2.i);
    _r0_o = _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label11;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return (global::java.lang.String) _r0_o;
    label11:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: java.lang.String getCategory(int)]
}

public virtual int getItemCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: int getItemCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.CategorySeries) _r1_o)._fmCategories;
    _r0.i = ((global::java.util.List) _r0_o).size();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label9;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return _r0.i;
    label9:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: int getItemCount()]
}

public virtual global::System.Object toXYSeries(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries: com.codename1.charts.models.XYSeries toXYSeries()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r3_o = new global::com.codename1.charts.models.XYSeries();
    _r4_o = ((global::com.codename1.charts.models.CategorySeries) _r7_o)._fmTitle;
    ((global::com.codename1.charts.models.XYSeries) _r3_o).@this((global::java.lang.String) _r4_o);
    _r0.i = 0;
    _r4_o = ((global::com.codename1.charts.models.CategorySeries) _r7_o)._fmValues;
    _r4_o = ((global::java.util.List) _r4_o).iterator();
    label14:;
    _r5.i = ((global::java.util.Iterator) _r4_o).hasNext() ? 1 : 0;
    if (_r5.i == 0) goto label37;
    _r7_o = ((global::java.util.Iterator) _r4_o).next();
    _r7_o = _r7_o;
    _r1.d = ((global::java.lang.Double) _r7_o).doubleValue();
    _r0.i = _r0.i + 1;
    _r5.d = (double) _r0.i;
    ((global::com.codename1.charts.models.XYSeries) _r3_o).add((double) _r5.d, (double) _r1.d);
    goto label14;
    label37:;
    return (global::com.codename1.charts.models.XYSeries) _r3_o;
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries: com.codename1.charts.models.XYSeries toXYSeries()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.CategorySeries]
//XMLVM_END_WRAPPER[com.codename1.charts.models.CategorySeries]

} // end of class: CategorySeries

} // end of namespace: com.codename1.charts.models
