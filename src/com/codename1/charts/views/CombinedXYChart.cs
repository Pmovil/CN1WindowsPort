// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class CombinedXYChart: global::com.codename1.charts.views.XYChart {
private global::org.xmlvm._nArrayAdapter<global::System.Object> _fchartDefinitions;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _fmCharts;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _fxyChartTypes;

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2, global::org.xmlvm._nArrayAdapter<global::System.Object> n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer, com.codename1.charts.views.CombinedXYChart$XYCombinedChartDef[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r12_o = n1;
    _r13_o = n2;
    _r14_o = n3;
    ((global::com.codename1.charts.views.XYChart) _r11_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r12_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r13_o);
    _r8.i = 8;
    _r8_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r8.i]);
    _r9.i = 0;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.TimeChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 1;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.LineChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 2;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.CubicLineChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 3;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.BarChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 4;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.BubbleChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 5;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.ScatterChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 6;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.RangeBarChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    _r9.i = 7;
    _r10_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.RangeStackedBarChart));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r9.i] = _r10_o;
    ((global::com.codename1.charts.views.CombinedXYChart) _r11_o)._fxyChartTypes = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o;
    ((global::com.codename1.charts.views.CombinedXYChart) _r11_o)._fchartDefinitions = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r14_o;
    _r4.i = ((global::org.xmlvm._nIArray) _r14_o).Length;
    _r8_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r4.i]);
    ((global::com.codename1.charts.views.CombinedXYChart) _r11_o)._fmCharts = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o;
    _r1.i = 0;
    label57:;
    if (_r1.i >= _r4.i) goto label173;
    try {
    _r8_o = ((global::com.codename1.charts.views.CombinedXYChart) _r11_o)._fmCharts;
    _r9_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r14_o)[_r1.i];
    _r9_o = ((global::com.codename1.charts.views.CombinedXYChart_2XYCombinedChartDef) _r9_o).getType();
    _r9_o = ((global::com.codename1.charts.views.CombinedXYChart) _r11_o).getXYChart((global::java.lang.String) _r9_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r1.i] = _r9_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    label73:;
    _r8_o = ((global::com.codename1.charts.views.CombinedXYChart) _r11_o)._fmCharts;
    _r8_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r1.i];
    if (_r8_o != null) goto label110;
    _r8_o = new global::java.lang.IllegalArgumentException();
    _r9_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r9_o).@this();
    // Value=Unknown chart type 
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32))}));
    _r9_o = ((global::java.lang.StringBuilder) _r9_o).append((global::java.lang.String) _r10_o);
    _r10_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r14_o)[_r1.i];
    _r10_o = ((global::com.codename1.charts.views.CombinedXYChart_2XYCombinedChartDef) _r10_o).getType();
    _r9_o = ((global::java.lang.StringBuilder) _r9_o).append((global::java.lang.String) _r10_o);
    _r9_o = ((global::java.lang.StringBuilder) _r9_o).toString();
    ((global::java.lang.IllegalArgumentException) _r8_o).@this((global::java.lang.String) _r9_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r8_o);
    label110:;
    _r5_o = new global::com.codename1.charts.models.XYMultipleSeriesDataset();
    ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r5_o).@this();
    _r6_o = new global::com.codename1.charts.renderers.XYMultipleSeriesRenderer();
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r6_o).@this();
    _r8_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r14_o)[_r1.i];
    _r0_o = ((global::com.codename1.charts.views.CombinedXYChart_2XYCombinedChartDef) _r8_o).getSeriesIndex();
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = 0;
    label128:;
    if (_r2.i >= _r3.i) goto label149;
    _r7.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r2.i];
    _r8_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r12_o).getSeriesAt((int) _r7.i);
    ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r5_o).addSeries((global::com.codename1.charts.models.XYSeries) _r8_o);
    _r8_o = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r13_o).getSeriesRendererAt((int) _r7.i);
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r6_o).addSeriesRenderer((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r8_o);
    _r2.i = _r2.i + 1;
    goto label128;
    label149:;
    _r8.d = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r13_o).getBarSpacing();
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r6_o).setBarSpacing((double) _r8.d);
    _r8.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r13_o).getPointSize();
    ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r6_o).setPointSize((float) _r8.f);
    _r8_o = ((global::com.codename1.charts.views.CombinedXYChart) _r11_o)._fmCharts;
    _r8_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o)[_r1.i];
    ((global::com.codename1.charts.views.XYChart) _r8_o).setDatasetRenderer((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r5_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r6_o);
    _r1.i = _r1.i + 1;
    goto label57;
    label173:;
    return;
    label174:;
    _r8_o = _ex.getJavaException();
    _ex = null;
    goto label73;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer, com.codename1.charts.views.CombinedXYChart$XYCombinedChartDef[])]
}

private global::System.Object getXYChart(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: com.codename1.charts.views.XYChart getXYChart(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r0_o = null;
    _r4_o = ((global::com.codename1.charts.views.CombinedXYChart) _r5_o)._fxyChartTypes;
    _r2.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r1.i = 0;
    label5:;
    if (_r1.i >= _r2.i) goto label33;
    if (_r0_o != null) goto label33;
    _r4_o = ((global::com.codename1.charts.views.CombinedXYChart) _r5_o)._fxyChartTypes;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r1.i];
    _r3_o = ((global::java.lang.Class) _r4_o).newInstance();
    _r4_o = ((global::com.codename1.charts.views.XYChart) _r3_o).getChartType();
    _r4.i = ((global::java.lang.String) _r6_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label30;
    _r0_o = _r3_o;
    label30:;
    _r1.i = _r1.i + 1;
    goto label5;
    label33:;
    return (global::com.codename1.charts.views.XYChart) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: com.codename1.charts.views.XYChart getXYChart(java.lang.String)]
}

public override void drawSeries(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::java.util.List n3, global::com.codename1.charts.renderers.XYSeriesRenderer n4, float n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    _r8_o = this;
    _r9_o = n1;
    _r10_o = n2;
    _r11_o = n3;
    _r12_o = n4;
    _r13.f = n5;
    _r14.i = n6;
    _r15.i = n7;
    _r0_o = ((global::com.codename1.charts.views.CombinedXYChart) _r8_o).getXYChart((int) _r14.i);
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r8_o).getScreenR();
    ((global::com.codename1.charts.views.XYChart) _r0_o).setScreenR((global::com.codename1.ui.geom.Rectangle) _r1_o);
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r8_o)._fmDataset;
    _r1_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o).getSeriesAt((int) _r14.i);
    _r1.i = ((global::com.codename1.charts.models.XYSeries) _r1_o).getScaleNumber();
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r8_o).getCalcRange((int) _r1.i);
    _r2.i = 0;
    ((global::com.codename1.charts.views.XYChart) _r0_o).setCalcRange((global::org.xmlvm._nArrayAdapter<double>) _r1_o, (int) _r2.i);
    _r6.i = ((global::com.codename1.charts.views.CombinedXYChart) _r8_o).getChartSeriesIndex((int) _r14.i);
    _r1_o = _r9_o;
    _r2_o = _r10_o;
    _r3_o = _r11_o;
    _r4_o = _r12_o;
    _r5.f = _r13.f;
    _r7.i = _r15.i;
    ((global::com.codename1.charts.views.XYChart) _r0_o).drawSeries((global::com.codename1.charts.compat.Canvas) _r1_o, (global::com.codename1.charts.compat.Paint) _r2_o, (global::java.util.List) _r3_o, (global::com.codename1.charts.renderers.XYSeriesRenderer) _r4_o, (float) _r5.f, (int) _r6.i, (int) _r7.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
}

public override global::System.Object clickableAreasForPoints(global::java.util.List n1, global::java.util.List n2, float n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9.f = n3;
    _r10.i = n4;
    _r11.i = n5;
    _r0_o = ((global::com.codename1.charts.views.CombinedXYChart) _r6_o).getXYChart((int) _r10.i);
    _r4.i = ((global::com.codename1.charts.views.CombinedXYChart) _r6_o).getChartSeriesIndex((int) _r10.i);
    _r1_o = _r7_o;
    _r2_o = _r8_o;
    _r3.f = _r9.f;
    _r5.i = _r11.i;
    _r1_o = ((global::com.codename1.charts.views.XYChart) _r0_o).clickableAreasForPoints((global::java.util.List) _r1_o, (global::java.util.List) _r2_o, (float) _r3.f, (int) _r4.i, (int) _r5.i);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
}

public override void drawSeries(global::com.codename1.charts.models.XYSeries n1, global::com.codename1.charts.compat.Canvas n2, global::com.codename1.charts.compat.Paint n3, global::java.util.List n4, global::com.codename1.charts.renderers.XYSeriesRenderer n5, float n6, int n7, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation n8, int n9){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: void drawSeries(com.codename1.charts.models.XYSeries, com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::System.Object _r15_o = null;
    global::System.Object _r16_o = null;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    _r12_o = this;
    _r13_o = n1;
    _r14_o = n2;
    _r15_o = n3;
    _r16_o = n4;
    _r17_o = n5;
    _r18.f = n6;
    _r19.i = n7;
    _r20_o = n8;
    _r21.i = n9;
    _r0_o = _r12_o;
    _r1.i = _r19.i;
    _r2_o = ((global::com.codename1.charts.views.CombinedXYChart) _r0_o).getXYChart((int) _r1.i);
    _r3_o = ((global::com.codename1.charts.views.CombinedXYChart) _r12_o).getScreenR();
    ((global::com.codename1.charts.views.XYChart) _r2_o).setScreenR((global::com.codename1.ui.geom.Rectangle) _r3_o);
    _r3_o = ((global::com.codename1.charts.views.CombinedXYChart) _r12_o)._fmDataset;
    _r0_o = _r3_o;
    _r1.i = _r19.i;
    _r3_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r0_o).getSeriesAt((int) _r1.i);
    _r3.i = ((global::com.codename1.charts.models.XYSeries) _r3_o).getScaleNumber();
    _r3_o = ((global::com.codename1.charts.views.CombinedXYChart) _r12_o).getCalcRange((int) _r3.i);
    _r4.i = 0;
    ((global::com.codename1.charts.views.XYChart) _r2_o).setCalcRange((global::org.xmlvm._nArrayAdapter<double>) _r3_o, (int) _r4.i);
    _r0_o = _r12_o;
    _r1.i = _r19.i;
    _r9.i = ((global::com.codename1.charts.views.CombinedXYChart) _r0_o).getChartSeriesIndex((int) _r1.i);
    _r3_o = _r13_o;
    _r4_o = _r14_o;
    _r5_o = _r15_o;
    _r6_o = _r16_o;
    _r7_o = _r17_o;
    _r8.f = _r18.f;
    _r10_o = _r20_o;
    _r11.i = _r21.i;
    ((global::com.codename1.charts.views.XYChart) _r2_o).drawSeries((global::com.codename1.charts.models.XYSeries) _r3_o, (global::com.codename1.charts.compat.Canvas) _r4_o, (global::com.codename1.charts.compat.Paint) _r5_o, (global::java.util.List) _r6_o, (global::com.codename1.charts.renderers.XYSeriesRenderer) _r7_o, (float) _r8.f, (int) _r9.i, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer_2Orientation) _r10_o, (int) _r11.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: void drawSeries(com.codename1.charts.models.XYSeries, com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, com.codename1.charts.renderers.XYMultipleSeriesRenderer$Orientation, int)]
}

public override int getLegendShapeWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: int getLegendShapeWidth(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = ((global::com.codename1.charts.views.CombinedXYChart) _r2_o).getXYChart((int) _r3.i);
    _r1.i = ((global::com.codename1.charts.views.CombinedXYChart) _r2_o).getChartSeriesIndex((int) _r3.i);
    _r1.i = ((global::com.codename1.charts.views.XYChart) _r0_o).getLegendShapeWidth((int) _r1.i);
    return _r1.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: int getLegendShapeWidth(int)]
}

public override void drawLegendShape(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.renderers.SimpleSeriesRenderer n2, float n3, float n4, int n5, global::com.codename1.charts.compat.Paint n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
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
    _r0_o = ((global::com.codename1.charts.views.CombinedXYChart) _r7_o).getXYChart((int) _r12.i);
    _r5.i = ((global::com.codename1.charts.views.CombinedXYChart) _r7_o).getChartSeriesIndex((int) _r12.i);
    _r1_o = _r8_o;
    _r2_o = _r9_o;
    _r3.f = _r10.f;
    _r4.f = _r11.f;
    _r6_o = _r13_o;
    ((global::com.codename1.charts.views.XYChart) _r0_o).drawLegendShape((global::com.codename1.charts.compat.Canvas) _r1_o, (global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o, (float) _r3.f, (float) _r4.f, (int) _r5.i, (global::com.codename1.charts.compat.Paint) _r6_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: java.lang.String getChartType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=Combined
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: java.lang.String getChartType()]
}

private global::System.Object getXYChart(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: com.codename1.charts.views.XYChart getXYChart(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r0.i = 0;
    label1:;
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r4_o)._fchartDefinitions;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label24;
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r4_o)._fchartDefinitions;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    _r1.i = ((global::com.codename1.charts.views.CombinedXYChart_2XYCombinedChartDef) _r1_o).containsSeries((int) _r5.i) ? 1 : 0;
    if (_r1.i == 0) goto label21;
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r4_o)._fmCharts;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    return (global::com.codename1.charts.views.XYChart) _r1_o;
    label21:;
    _r0.i = _r0.i + 1;
    goto label1;
    label24:;
    _r1_o = new global::java.lang.IllegalArgumentException();
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=Unknown series with index 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((int) _r5.i);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: com.codename1.charts.views.XYChart getXYChart(int)]
}

private int getChartSeriesIndex(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart: int getChartSeriesIndex(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r0.i = 0;
    label1:;
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r4_o)._fchartDefinitions;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label28;
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r4_o)._fchartDefinitions;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    _r1.i = ((global::com.codename1.charts.views.CombinedXYChart_2XYCombinedChartDef) _r1_o).containsSeries((int) _r5.i) ? 1 : 0;
    if (_r1.i == 0) goto label25;
    _r1_o = ((global::com.codename1.charts.views.CombinedXYChart) _r4_o)._fchartDefinitions;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    _r1.i = ((global::com.codename1.charts.views.CombinedXYChart_2XYCombinedChartDef) _r1_o).getChartSeriesIndex((int) _r5.i);
    return _r1.i;
    label25:;
    _r0.i = _r0.i + 1;
    goto label1;
    label28:;
    _r1_o = new global::java.lang.IllegalArgumentException();
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=Unknown series with index 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((int) _r5.i);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart: int getChartSeriesIndex(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CombinedXYChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.CombinedXYChart]

} // end of class: CombinedXYChart

} // end of namespace: com.codename1.charts.views
