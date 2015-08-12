// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.renderers {
public class XYSeriesRenderer: global::com.codename1.charts.renderers.SimpleSeriesRenderer {
private bool _fmFillPoints;

private global::java.util.List _fmFillBelowLine;

private global::com.codename1.charts.views.PointStyle _fmPointStyle;

private float _fmPointStrokeWidth;

private float _fmLineWidth;

private bool _fmDisplayChartValues;

private int _fmDisplayChartValuesDistance;

private float _fmChartValuesTextSize;

private int _fmChartValuesTextAlign;

private float _fmChartValuesSpacing;

private float _fmAnnotationsTextSize;

private int _fmAnnotationsTextAlign;

private int _fmAnnotationsColor;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 4;
    _r2.f = (float)10.0D;
    _r1.f = (float)1.0D;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r4_o).@this();
    _r0.i = 0;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmFillPoints = 0!=_r0.i;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmFillBelowLine = (global::java.util.List) _r0_o;
    _r0_o = global::com.codename1.charts.views.PointStyle._fPOINT;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmPointStyle = (global::com.codename1.charts.views.PointStyle) _r0_o;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmPointStrokeWidth = _r1.f;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmLineWidth = _r1.f;
    _r0.i = 100;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmDisplayChartValuesDistance = _r0.i;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmChartValuesTextSize = _r2.f;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmChartValuesTextAlign = _r3.i;
    _r0.f = (float)5.0D;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmChartValuesSpacing = _r0.f;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmAnnotationsTextSize = _r2.f;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmAnnotationsTextAlign = _r3.i;
    _r0.i = 15395562;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o)._fmAnnotationsColor = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void <init>()]
}

public virtual bool isFillBelowLine(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: boolean isFillBelowLine()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmFillBelowLine;
    _r0.i = ((global::java.util.List) _r0_o).size();
    if (_r0.i <= 0) goto label10;
    _r0.i = 1;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: boolean isFillBelowLine()]
}

public virtual void setFillBelowLine(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setFillBelowLine(boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1 ? 1 : 0;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r3_o)._fmFillBelowLine;
    ((global::java.util.List) _r0_o).clear();
    if (_r4.i == 0) goto label20;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r3_o)._fmFillBelowLine;
    _r1_o = new global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine();
    _r2_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ALL;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r1_o).@this((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type) _r2_o);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    label19:;
    return;
    label20:;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r3_o)._fmFillBelowLine;
    _r1_o = new global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine();
    _r2_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fNONE;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r1_o).@this((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type) _r2_o);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setFillBelowLine(boolean)]
}

public virtual global::System.Object getFillOutsideLine(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: com.codename1.charts.renderers.XYSeriesRenderer$FillOutsideLine[] getFillOutsideLine()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r2_o)._fmFillBelowLine;
    _r1.i = ((global::java.util.List) _r1_o).size();
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r1_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r2_o)._fmFillBelowLine;
    _r2_o = ((global::java.util.List) _r1_o).toArray((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    _r2_o = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: com.codename1.charts.renderers.XYSeriesRenderer$FillOutsideLine[] getFillOutsideLine()]
}

public virtual void addFillOutsideLine(global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void addFillOutsideLine(com.codename1.charts.renderers.XYSeriesRenderer$FillOutsideLine)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmFillBelowLine;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void addFillOutsideLine(com.codename1.charts.renderers.XYSeriesRenderer$FillOutsideLine)]
}

public virtual bool isFillPoints(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: boolean isFillPoints()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmFillPoints ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: boolean isFillPoints()]
}

public virtual void setFillPoints(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setFillPoints(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmFillPoints = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setFillPoints(boolean)]
}

public virtual void setFillBelowLineColor(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setFillBelowLineColor(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r2_o)._fmFillBelowLine;
    _r0.i = ((global::java.util.List) _r0_o).size();
    if (_r0.i <= 0) goto label20;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r2_o)._fmFillBelowLine;
    _r1.i = 0;
    _r2_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r2_o = _r2_o;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r2_o).setColor((int) _r3.i);
    label20:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setFillBelowLineColor(int)]
}

public virtual global::System.Object getPointStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: com.codename1.charts.views.PointStyle getPointStyle()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmPointStyle;
    return (global::com.codename1.charts.views.PointStyle) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: com.codename1.charts.views.PointStyle getPointStyle()]
}

public virtual void setPointStyle(global::com.codename1.charts.views.PointStyle n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setPointStyle(com.codename1.charts.views.PointStyle)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmPointStyle = (global::com.codename1.charts.views.PointStyle) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setPointStyle(com.codename1.charts.views.PointStyle)]
}

public virtual float getPointStrokeWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getPointStrokeWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmPointStrokeWidth;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getPointStrokeWidth()]
}

public virtual void setPointStrokeWidth(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setPointStrokeWidth(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmPointStrokeWidth = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setPointStrokeWidth(float)]
}

public virtual float getLineWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getLineWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmLineWidth;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getLineWidth()]
}

public virtual void setLineWidth(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setLineWidth(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmLineWidth = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setLineWidth(float)]
}

public virtual bool isDisplayChartValues(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: boolean isDisplayChartValues()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmDisplayChartValues ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: boolean isDisplayChartValues()]
}

public virtual void setDisplayChartValues(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setDisplayChartValues(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmDisplayChartValues = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setDisplayChartValues(boolean)]
}

public virtual int getDisplayChartValuesDistance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getDisplayChartValuesDistance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmDisplayChartValuesDistance;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getDisplayChartValuesDistance()]
}

public virtual void setDisplayChartValuesDistance(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setDisplayChartValuesDistance(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmDisplayChartValuesDistance = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setDisplayChartValuesDistance(int)]
}

public virtual float getChartValuesTextSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getChartValuesTextSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmChartValuesTextSize;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getChartValuesTextSize()]
}

public virtual void setChartValuesTextSize(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesTextSize(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmChartValuesTextSize = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesTextSize(float)]
}

public virtual void setChartValuesTextFont(global::com.codename1.ui.Font n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesTextFont(com.codename1.ui.Font)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::com.codename1.ui.Font) _r2_o).getHeight();
    _r0.f = (float) _r0.i;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o).setChartValuesTextSize((float) _r0.f);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesTextFont(com.codename1.ui.Font)]
}

public virtual int getChartValuesTextAlign(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getChartValuesTextAlign()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmChartValuesTextAlign;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getChartValuesTextAlign()]
}

public virtual void setChartValuesTextAlign(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesTextAlign(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmChartValuesTextAlign = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesTextAlign(int)]
}

public virtual float getChartValuesSpacing(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getChartValuesSpacing()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmChartValuesSpacing;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getChartValuesSpacing()]
}

public virtual void setChartValuesSpacing(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesSpacing(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmChartValuesSpacing = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setChartValuesSpacing(float)]
}

public virtual float getAnnotationsTextSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getAnnotationsTextSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmAnnotationsTextSize;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: float getAnnotationsTextSize()]
}

public virtual void setAnnotationsTextSize(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsTextSize(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmAnnotationsTextSize = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsTextSize(float)]
}

public virtual void setAnnotationsTextFont(global::com.codename1.ui.Font n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsTextFont(com.codename1.ui.Font)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::com.codename1.ui.Font) _r2_o).getHeight();
    _r0.f = (float) _r0.i;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o).setAnnotationsTextSize((float) _r0.f);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsTextFont(com.codename1.ui.Font)]
}

public virtual int getAnnotationsTextAlign(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getAnnotationsTextAlign()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmAnnotationsTextAlign;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getAnnotationsTextAlign()]
}

public virtual void setAnnotationsTextAlign(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsTextAlign(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmAnnotationsTextAlign = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsTextAlign(int)]
}

public virtual int getAnnotationsColor(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getAnnotationsColor()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o)._fmAnnotationsColor;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: int getAnnotationsColor()]
}

public virtual void setAnnotationsColor(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsColor(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r0_o)._fmAnnotationsColor = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer: void setAnnotationsColor(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer]
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.XYSeriesRenderer]

} // end of class: XYSeriesRenderer

} // end of namespace: com.codename1.charts.renderers
