// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class LineChart: global::com.codename1.charts.views.XYChart {

static LineChart() {
    // Value=Line
    _fTYPE = new global::java.lang.String();
    _fTYPE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)76)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
}

public static global::java.lang.String _fTYPE;


private global::com.codename1.charts.views.ScatterChart _fpointsChart;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.charts.views.XYChart) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: void <init>()]
}

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::com.codename1.charts.views.XYChart) _r1_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o);
    _r0_o = new global::com.codename1.charts.views.ScatterChart();
    ((global::com.codename1.charts.views.ScatterChart) _r0_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o);
    ((global::com.codename1.charts.views.LineChart) _r1_o)._fpointsChart = (global::com.codename1.charts.views.ScatterChart) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
}

public override void setDatasetRenderer(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: void setDatasetRenderer(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    base.setDatasetRenderer((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o);
    _r0_o = new global::com.codename1.charts.views.ScatterChart();
    ((global::com.codename1.charts.views.ScatterChart) _r0_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o);
    ((global::com.codename1.charts.views.LineChart) _r1_o)._fpointsChart = (global::com.codename1.charts.views.ScatterChart) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: void setDatasetRenderer(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
}

public override void drawSeries(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::java.util.List n3, global::com.codename1.charts.renderers.XYSeriesRenderer n4, float n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r16;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::org.xmlvm._nElement _r22;
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nElement _r25;
    global::System.Object _r26_o = null;
    global::System.Object _r27_o = null;
    global::System.Object _r28_o = null;
    global::System.Object _r29_o = null;
    global::System.Object _r30_o = null;
    global::org.xmlvm._nElement _r31;
    global::org.xmlvm._nElement _r32;
    global::System.Object _r32_o = null;
    global::org.xmlvm._nElement _r33;
    _r26_o = this;
    _r27_o = n1;
    _r28_o = n2;
    _r29_o = n3;
    _r30_o = n4;
    _r31.f = n5;
    _r32.i = n6;
    _r33.i = n7;
    _r15.f = ((global::com.codename1.charts.compat.Paint) _r28_o).getStrokeWidth();
    _r23.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r30_o).getLineWidth();
    _r0_o = _r28_o;
    _r1.f = _r23.f;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStrokeWidth((float) _r1.f);
    _r9_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r30_o).getFillOutsideLine();
    _r6_o = _r9_o;
    _r13.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r12.i = 0;
    label22:;
    if (_r12.i >= _r13.i) goto label739;
    _r8_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r12.i];
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fNONE;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o == _r1_o) goto label735;
    _r23.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getColor();
    _r0_o = _r28_o;
    _r1.i = _r23.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r10_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r10_o).@this();
    _r18_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getFillRange();
    if (_r18_o != null) goto label376;
    _r0_o = _r10_o;
    _r1_o = _r29_o;
    ((global::java.util.List) _r0_o).addAll((global::java.util.Collection) _r1_o);
    label66:;
    _r20_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r23_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ALL;
    _r0_o = _r20_o;
    _r1_o = _r23_o;
    if (_r0_o == _r1_o) goto label94;
    _r23_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1BELOW;
    _r0_o = _r20_o;
    _r1_o = _r23_o;
    if (_r0_o == _r1_o) goto label94;
    _r23_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ABOVE;
    _r0_o = _r20_o;
    _r1_o = _r23_o;
    if (_r0_o != _r1_o) goto label438;
    label94:;
    _r19.f = _r31.f;
    label96:;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ABOVE;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o == _r1_o) goto label120;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1BELOW;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label568;
    label120:;
    _r7_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r7_o).@this();
    _r5.i = 0;
    _r14.i = ((global::java.util.List) _r10_o).size();
    if (_r14.i <= 0) goto label163;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ABOVE;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label163;
    _r23.i = 1;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r23.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r23.i = _r23.f > _r19.f ? 1 : (_r23.f == _r19.f ? 0 : -1);
    if (_r23.i < 0) goto label194;
    label163:;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1BELOW;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label225;
    _r23.i = 1;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r23.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r23.i = _r23.f > _r19.f ? 1 : (_r23.f == _r19.f ? 0 : -1);
    if (_r23.i <= 0) goto label225;
    label194:;
    _r23.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r23_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23.i = 1;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r23_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r5.i = 1;
    label225:;
    _r11.i = 3;
    label226:;
    if (_r11.i >= _r14.i) goto label562;
    _r23.i = 2;
    _r23.i = _r11.i - _r23.i;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r16.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r32_o = ((global::java.util.List) _r10_o).get((int) _r11.i);
    _r21.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r23.i = _r16.f > _r19.f ? 1 : (_r16.f == _r19.f ? 0 : -1);
    if (_r23.i >= 0) goto label263;
    _r23.i = _r21.f > _r19.f ? 1 : (_r21.f == _r19.f ? 0 : -1);
    if (_r23.i > 0) goto label271;
    label263:;
    _r23.i = _r16.f > _r19.f ? 1 : (_r16.f == _r19.f ? 0 : -1);
    if (_r23.i <= 0) goto label499;
    _r23.i = _r21.f > _r19.f ? 1 : (_r21.f == _r19.f ? 0 : -1);
    if (_r23.i >= 0) goto label499;
    label271:;
    _r23.i = 3;
    _r23.i = _r11.i - _r23.i;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r17.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r23.i = 1;
    _r23.i = _r11.i - _r23.i;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r22.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r23.f = _r22.f - _r17.f;
    _r24.f = _r19.f - _r16.f;
    _r23.f = _r23.f * _r24.f;
    _r24.f = _r21.f - _r16.f;
    _r23.f = _r23.f / _r24.f;
    _r23.f = _r23.f + _r17.f;
    _r23_o = global::java.lang.Float.valueOf((float) _r23.f);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23_o = global::java.lang.Float.valueOf((float) _r19.f);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ABOVE;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label353;
    _r23.i = _r21.f > _r19.f ? 1 : (_r21.f == _r19.f ? 0 : -1);
    if (_r23.i > 0) goto label369;
    label353:;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1BELOW;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label477;
    _r23.i = _r21.f > _r19.f ? 1 : (_r21.f == _r19.f ? 0 : -1);
    if (_r23.i >= 0) goto label477;
    label369:;
    _r11.i = _r11.i + 2;
    _r5.i = 0;
    label372:;
    _r11.i = _r11.i + 2;
    goto label226;
    label376:;
    _r23.i = ((global::java.util.List) _r29_o).size();
    _r24.i = 0;
    _r24.i = ((global::org.xmlvm._nArrayAdapter<int>) _r18_o)[_r24.i];
    _r24.i = _r24.i * 2;
    _r0.i = _r23.i;
    _r1.i = _r24.i;
    if (_r0.i <= _r1.i) goto label66;
    _r23.i = ((global::java.util.List) _r29_o).size();
    _r24.i = 1;
    _r24.i = ((global::org.xmlvm._nArrayAdapter<int>) _r18_o)[_r24.i];
    _r24.i = _r24.i * 2;
    _r0.i = _r23.i;
    _r1.i = _r24.i;
    if (_r0.i <= _r1.i) goto label66;
    _r23.i = 0;
    _r23.i = ((global::org.xmlvm._nArrayAdapter<int>) _r18_o)[_r23.i];
    _r23.i = _r23.i * 2;
    _r24.i = 1;
    _r24.i = ((global::org.xmlvm._nArrayAdapter<int>) _r18_o)[_r24.i];
    _r24.i = _r24.i * 2;
    _r0_o = _r29_o;
    _r1.i = _r23.i;
    _r2.i = _r24.i;
    _r23_o = ((global::java.util.List) _r0_o).subList((int) _r1.i, (int) _r2.i);
    _r0_o = _r10_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).addAll((global::java.util.Collection) _r1_o);
    goto label66;
    label438:;
    _r23_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBELOW;
    _r0_o = _r20_o;
    _r1_o = _r23_o;
    if (_r0_o != _r1_o) goto label457;
    _r23.i = ((global::com.codename1.charts.compat.Canvas) _r27_o).getHeight();
    _r0.i = _r23.i;
    _r0.f = (float) _r0.i;
    _r19.f = _r0.f;
    goto label96;
    label457:;
    _r23_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fABOVE;
    _r0_o = _r20_o;
    _r1_o = _r23_o;
    if (_r0_o != _r1_o) goto label469;
    _r19.f = (float)0.0D;
    goto label96;
    label469:;
    _r23_o = new global::java.lang.RuntimeException();
    // Value=You have added a new type of filling but have not implemented.
    _r24_o = new global::java.lang.String();
    ((global::java.lang.String)_r24_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)89)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 46))}));
    ((global::java.lang.RuntimeException) _r23_o).@this((global::java.lang.String) _r24_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r23_o);
    label477:;
    _r23_o = global::java.lang.Float.valueOf((float) _r22.f);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23_o = global::java.lang.Float.valueOf((float) _r21.f);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r5.i = 1;
    goto label372;
    label499:;
    if (_r5.i != 0) goto label533;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1ABOVE;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label517;
    _r23.i = _r21.f > _r19.f ? 1 : (_r21.f == _r19.f ? 0 : -1);
    if (_r23.i < 0) goto label533;
    label517:;
    _r23_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine) _r8_o).getType();
    _r24_o = global::com.codename1.charts.renderers.XYSeriesRenderer_2FillOutsideLine_2Type._fBOUNDS_1BELOW;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    if (_r0_o != _r1_o) goto label372;
    _r23.i = _r21.f > _r19.f ? 1 : (_r21.f == _r19.f ? 0 : -1);
    if (_r23.i <= 0) goto label372;
    label533:;
    _r23.i = 1;
    _r23.i = _r11.i - _r23.i;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r23_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23_o = global::java.lang.Float.valueOf((float) _r21.f);
    _r0_o = _r7_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    goto label372;
    label562:;
    ((global::java.util.List) _r10_o).clear();
    ((global::java.util.List) _r10_o).addAll((global::java.util.Collection) _r7_o);
    label568:;
    _r14.i = ((global::java.util.List) _r10_o).size();
    if (_r14.i <= 0) goto label735;
    _r23.i = 0;
    _r24.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r24.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r24.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r25.f = (float)1.0D;
    _r24.f = _r24.f + _r25.f;
    _r24_o = global::java.lang.Float.valueOf((float) _r24.f);
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r2_o = _r24_o;
    ((global::java.util.List) _r0_o).set((int) _r1.i, (global::java.lang.Object) _r2_o);
    _r23.i = 2;
    _r23.i = _r14.i - _r23.i;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r23_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r0_o = _r10_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23_o = global::java.lang.Float.valueOf((float) _r19.f);
    _r0_o = _r10_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r23_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r0_o = _r10_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r23.i = _r14.i + 1;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r23_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r0_o = _r10_o;
    _r1_o = _r23_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r11.i = 0;
    label665:;
    _r23.i = _r14.i + 4;
    _r0.i = _r11.i;
    _r1.i = _r23.i;
    if (_r0.i >= _r1.i) goto label712;
    _r23.i = _r11.i + 1;
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r32_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r23.f = ((global::java.lang.Float) _r32_o).floatValue();
    _r24.f = (float)0.0D;
    _r23.i = _r23.f > _r24.f ? 1 : (_r23.f == _r24.f ? 0 : -1);
    if (_r23.i >= 0) goto label709;
    _r23.i = _r11.i + 1;
    _r24.f = (float)0.0D;
    _r24_o = global::java.lang.Float.valueOf((float) _r24.f);
    _r0_o = _r10_o;
    _r1.i = _r23.i;
    _r2_o = _r24_o;
    ((global::java.util.List) _r0_o).set((int) _r1.i, (global::java.lang.Object) _r2_o);
    label709:;
    _r11.i = _r11.i + 2;
    goto label665;
    label712:;
    _r23_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    _r0_o = _r28_o;
    _r1_o = _r23_o;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    _r23.i = 1;
    _r0_o = _r26_o;
    _r1_o = _r27_o;
    _r2_o = _r10_o;
    _r3_o = _r28_o;
    _r4.i = _r23.i;
    ((global::com.codename1.charts.views.LineChart) _r0_o).drawPath((global::com.codename1.charts.compat.Canvas) _r1_o, (global::java.util.List) _r2_o, (global::com.codename1.charts.compat.Paint) _r3_o, 0!=_r4.i);
    label735:;
    _r12.i = _r12.i + 1;
    goto label22;
    label739:;
    _r23.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r30_o).getColor();
    _r0_o = _r28_o;
    _r1.i = _r23.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r23_o = global::com.codename1.charts.compat.Paint_2Style._fSTROKE;
    _r0_o = _r28_o;
    _r1_o = _r23_o;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    _r23.i = 0;
    _r0_o = _r26_o;
    _r1_o = _r27_o;
    _r2_o = _r29_o;
    _r3_o = _r28_o;
    _r4.i = _r23.i;
    ((global::com.codename1.charts.views.LineChart) _r0_o).drawPath((global::com.codename1.charts.compat.Canvas) _r1_o, (global::java.util.List) _r2_o, (global::com.codename1.charts.compat.Paint) _r3_o, 0!=_r4.i);
    _r0_o = _r28_o;
    _r1.f = _r15.f;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStrokeWidth((float) _r1.f);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
}

public override global::System.Object clickableAreasForPoints(global::java.util.List n1, global::java.util.List n2, float n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r15_o = null;
    global::System.Object _r16_o = null;
    global::System.Object _r17_o = null;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::org.xmlvm._nElement _r21;
    _r16_o = this;
    _r17_o = n1;
    _r18_o = n2;
    _r19.f = n3;
    _r20.i = n4;
    _r21.i = n5;
    _r11.i = ((global::java.util.List) _r17_o).size();
    _r2.i = _r11.i / 2;
    _r12_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r2.i]);
    _r10.i = 0;
    label9:;
    if (_r10.i >= _r11.i) goto label133;
    _r0_o = _r16_o;
    _r0_o = ((global::com.codename1.charts.views.LineChart) _r0_o)._fmRenderer;
    _r2_o = _r0_o;
    _r13.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r2_o).getSelectableBuffer();
    _r14.i = _r10.i / 2;
    _r15_o = new global::com.codename1.charts.views.ClickableArea();
    _r0_o = _r17_o;
    _r1.i = _r10.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r2.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r3.f = (float) _r13.i;
    _r2.f = _r2.f - _r3.f;
    _r2.d = (double) _r2.f;
    _r4.i = _r10.i + 1;
    _r0_o = _r17_o;
    _r1.i = _r4.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r4.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r5.f = (float) _r13.i;
    _r4.f = _r4.f - _r5.f;
    _r4.d = (double) _r4.f;
    _r0_o = _r17_o;
    _r1.i = _r10.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r6.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r7.f = (float) _r13.i;
    _r6.f = _r6.f + _r7.f;
    _r6.d = (double) _r6.f;
    _r8.i = _r10.i + 1;
    _r0_o = _r17_o;
    _r1.i = _r8.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r8.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r9.f = (float) _r13.i;
    _r8.f = _r8.f + _r9.f;
    _r8.d = (double) _r8.f;
    _r3_o = global::com.codename1.charts.views.PkgUtils.makeRect((double) _r2.d, (double) _r4.d, (double) _r6.d, (double) _r8.d);
    _r0_o = _r18_o;
    _r1.i = _r10.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r4.d = ((global::java.lang.Double) _r19_o).doubleValue();
    _r2.i = _r10.i + 1;
    _r0_o = _r18_o;
    _r1.i = _r2.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r6.d = ((global::java.lang.Double) _r19_o).doubleValue();
    _r2_o = _r15_o;
    ((global::com.codename1.charts.views.ClickableArea) _r2_o).@this((global::com.codename1.ui.geom.Rectangle2D) _r3_o, (double) _r4.d, (double) _r6.d);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r14.i] = _r15_o;
    _r10.i = _r10.i + 2;
    goto label9;
    label133:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
}

public override int getLegendShapeWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: int getLegendShapeWidth(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 30;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: int getLegendShapeWidth(int)]
}

public override void drawLegendShape(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.renderers.SimpleSeriesRenderer n2, float n3, float n4, int n5, global::com.codename1.charts.compat.Paint n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10.f = n3;
    _r11.f = n4;
    _r12.i = n5;
    _r13_o = n6;
    _r0.f = (float)30.0D;
    _r3.f = _r10.f + _r0.f;
    _r0_o = _r8_o;
    _r1.f = _r10.f;
    _r2.f = _r11.f;
    _r4.f = _r11.f;
    _r5_o = _r13_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawLine((float) _r1.f, (float) _r2.f, (float) _r3.f, (float) _r4.f, (global::com.codename1.charts.compat.Paint) _r5_o);
    _r0.i = ((global::com.codename1.charts.views.LineChart) _r7_o).isRenderPoints((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r9_o) ? 1 : 0;
    if (_r0.i == 0) goto label32;
    _r0_o = ((global::com.codename1.charts.views.LineChart) _r7_o)._fpointsChart;
    _r1.f = (float)5.0D;
    _r3.f = _r10.f + _r1.f;
    _r1_o = _r8_o;
    _r2_o = _r9_o;
    _r4.f = _r11.f;
    _r5.i = _r12.i;
    _r6_o = _r13_o;
    ((global::com.codename1.charts.views.ScatterChart) _r0_o).drawLegendShape((global::com.codename1.charts.compat.Canvas) _r1_o, (global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o, (float) _r3.f, (float) _r4.f, (int) _r5.i, (global::com.codename1.charts.compat.Paint) _r6_o);
    label32:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
}

public override bool isRenderPoints(global::com.codename1.charts.renderers.SimpleSeriesRenderer n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: boolean isRenderPoints(com.codename1.charts.renderers.SimpleSeriesRenderer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r3_o).getPointStyle();
    _r1_o = global::com.codename1.charts.views.PointStyle._fPOINT;
    if (_r0_o == _r1_o) goto label12;
    _r0.i = 1;
    label11:;
    return _r0.i!=0;
    label12:;
    _r0.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: boolean isRenderPoints(com.codename1.charts.renderers.SimpleSeriesRenderer)]
}

public override global::System.Object getPointsChart(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: com.codename1.charts.views.ScatterChart getPointsChart()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.views.LineChart) _r1_o)._fpointsChart;
    return (global::com.codename1.charts.views.ScatterChart) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: com.codename1.charts.views.ScatterChart getPointsChart()]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart: java.lang.String getChartType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=Line
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)76)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart: java.lang.String getChartType()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.LineChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.LineChart]

} // end of class: LineChart

} // end of namespace: com.codename1.charts.views
