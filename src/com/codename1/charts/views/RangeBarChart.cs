// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class RangeBarChart: global::com.codename1.charts.views.BarChart {

static RangeBarChart() {
    // Value=RangeBar
    _fTYPE = new global::java.lang.String();
    _fTYPE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)82)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114))}));
}

public static global::java.lang.String _fTYPE;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::com.codename1.charts.views.BarChart) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: void <init>()]
}

public void @this(global::com.codename1.charts.views.BarChart_2Type n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: void <init>(com.codename1.charts.views.BarChart$Type)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.views.BarChart) _r0_o).@this((global::com.codename1.charts.views.BarChart_2Type) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: void <init>(com.codename1.charts.views.BarChart$Type)]
}

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2, global::com.codename1.charts.views.BarChart_2Type n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer, com.codename1.charts.views.BarChart$Type)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.charts.views.BarChart) _r0_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r2_o, (global::com.codename1.charts.views.BarChart_2Type) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer, com.codename1.charts.views.BarChart$Type)]
}

public override void drawSeries(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::java.util.List n3, global::com.codename1.charts.renderers.XYSeriesRenderer n4, float n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
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
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r17_o = this;
    _r18_o = n1;
    _r19_o = n2;
    _r20_o = n3;
    _r21_o = n4;
    _r22.f = n5;
    _r23.i = n6;
    _r24.i = n7;
    _r0_o = _r17_o;
    _r0_o = ((global::com.codename1.charts.views.RangeBarChart) _r0_o)._fmDataset;
    _r4_o = _r0_o;
    _r11.i = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r4_o).getSeriesCount();
    _r15.i = ((global::java.util.List) _r20_o).size();
    _r4.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r21_o).getColor();
    _r0_o = _r19_o;
    _r1.i = _r4.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r4_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    _r0_o = _r19_o;
    _r1_o = _r4_o;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    _r0_o = _r17_o;
    _r1_o = _r20_o;
    _r2.i = _r15.i;
    _r3.i = _r11.i;
    _r10.f = ((global::com.codename1.charts.views.RangeBarChart) _r0_o).getHalfDiffX((global::java.util.List) _r1_o, (int) _r2.i, (int) _r3.i);
    _r16.i = 0;
    if (_r24.i <= 0) goto label47;
    _r16.i = 2;
    label47:;
    _r14.i = _r16.i;
    label49:;
    if (_r14.i >= _r15.i) goto label131;
    _r4.i = ((global::java.util.List) _r20_o).size();
    _r5.i = _r14.i + 3;
    if (_r4.i <= _r5.i) goto label128;
    _r0_o = _r20_o;
    _r1.i = _r14.i;
    _r22_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r22_o = _r22_o;
    _r6.f = ((global::java.lang.Float) _r22_o).floatValue();
    _r4.i = _r14.i + 1;
    _r0_o = _r20_o;
    _r1.i = _r4.i;
    _r22_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r22_o = _r22_o;
    _r7.f = ((global::java.lang.Float) _r22_o).floatValue();
    _r4.i = _r14.i + 2;
    _r0_o = _r20_o;
    _r1.i = _r4.i;
    _r22_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r22_o = _r22_o;
    _r8.f = ((global::java.lang.Float) _r22_o).floatValue();
    _r4.i = _r14.i + 3;
    _r0_o = _r20_o;
    _r1.i = _r4.i;
    _r22_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r22_o = _r22_o;
    _r9.f = ((global::java.lang.Float) _r22_o).floatValue();
    _r4_o = _r17_o;
    _r5_o = _r18_o;
    _r12.i = _r23.i;
    _r13_o = _r19_o;
    ((global::com.codename1.charts.views.RangeBarChart) _r4_o).drawBar((global::com.codename1.charts.compat.Canvas) _r5_o, (float) _r6.f, (float) _r7.f, (float) _r8.f, (float) _r9.f, (float) _r10.f, (int) _r11.i, (int) _r12.i, (global::com.codename1.charts.compat.Paint) _r13_o);
    label128:;
    _r14.i = _r14.i + 4;
    goto label49;
    label131:;
    _r4.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r21_o).getColor();
    _r0_o = _r19_o;
    _r1.i = _r4.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
}

public override void drawChartValuesText(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.models.XYSeries n2, global::com.codename1.charts.renderers.XYSeriesRenderer n3, global::com.codename1.charts.compat.Paint n4, global::java.util.List n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: void drawChartValuesText(com.codename1.charts.compat.Canvas, com.codename1.charts.models.XYSeries, com.codename1.charts.renderers.XYSeriesRenderer, com.codename1.charts.compat.Paint, java.util.List, int, int)]
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
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r16_o = this;
    _r17_o = n1;
    _r18_o = n2;
    _r19_o = n3;
    _r20_o = n4;
    _r21_o = n5;
    _r22.i = n6;
    _r23.i = n7;
    _r0_o = _r16_o;
    _r0_o = ((global::com.codename1.charts.views.RangeBarChart) _r0_o)._fmDataset;
    _r4_o = _r0_o;
    _r14.i = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r4_o).getSeriesCount();
    _r4.i = ((global::java.util.List) _r21_o).size();
    _r0_o = _r16_o;
    _r1_o = _r21_o;
    _r2.i = _r4.i;
    _r3.i = _r14.i;
    _r11.f = ((global::com.codename1.charts.views.RangeBarChart) _r0_o).getHalfDiffX((global::java.util.List) _r1_o, (int) _r2.i, (int) _r3.i);
    _r15.i = 0;
    if (_r23.i <= 0) goto label27;
    _r15.i = 2;
    label27:;
    _r12.i = _r15.i;
    label28:;
    _r4.i = ((global::java.util.List) _r21_o).size();
    if (_r12.i >= _r4.i) goto label235;
    _r4.i = _r12.i / 2;
    _r13.i = _r23.i + _r4.i;
    _r0_o = _r21_o;
    _r1.i = _r12.i;
    _r4_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r4_o = _r4_o;
    _r7.f = ((global::java.lang.Float) _r4_o).floatValue();
    _r0_o = _r16_o;
    _r0_o = ((global::com.codename1.charts.views.RangeBarChart) _r0_o)._fmType;
    _r4_o = _r0_o;
    _r5_o = global::com.codename1.charts.views.BarChart_2Type._fDEFAULT;
    if (_r4_o != _r5_o) goto label71;
    _r4.i = _r22.i * 2;
    _r4.f = (float) _r4.i;
    _r4.f = _r4.f * _r11.f;
    _r5.f = (float) _r14.i;
    _r6.f = (float)1.5D;
    _r5.f = _r5.f - _r6.f;
    _r5.f = _r5.f * _r11.f;
    _r4.f = _r4.f - _r5.f;
    _r7.f = _r7.f + _r4.f;
    label71:;
    _r4.i = _r13.i + 1;
    _r0_o = _r18_o;
    _r1.i = _r4.i;
    _r4.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getY((int) _r1.i);
    _r0_o = _r16_o;
    _r1.d = _r4.d;
    _r4.i = ((global::com.codename1.charts.views.RangeBarChart) _r0_o).isNullValue((double) _r1.d) ? 1 : 0;
    if (_r4.i != 0) goto label149;
    _r4.i = ((global::java.util.List) _r21_o).size();
    _r5.i = _r12.i + 3;
    if (_r4.i <= _r5.i) goto label149;
    _r4_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r19_o).getChartValuesFormat();
    _r5.i = _r13.i + 1;
    _r0_o = _r18_o;
    _r1.i = _r5.i;
    _r5.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getY((int) _r1.i);
    _r0_o = _r16_o;
    _r1_o = _r4_o;
    _r2.d = _r5.d;
    _r6_o = ((global::com.codename1.charts.views.RangeBarChart) _r0_o).getLabel((global::com.codename1.charts.util.NumberFormat) _r1_o, (double) _r2.d);
    _r4.i = _r12.i + 3;
    _r0_o = _r21_o;
    _r1.i = _r4.i;
    _r4_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r4_o = _r4_o;
    _r4.f = ((global::java.lang.Float) _r4_o).floatValue();
    _r5.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r19_o).getChartValuesSpacing();
    _r8.f = _r4.f - _r5.f;
    _r10.f = (float)0.0D;
    _r4_o = _r16_o;
    _r5_o = _r17_o;
    _r9_o = _r20_o;
    ((global::com.codename1.charts.views.RangeBarChart) _r4_o).drawText((global::com.codename1.charts.compat.Canvas) _r5_o, (global::java.lang.String) _r6_o, (float) _r7.f, (float) _r8.f, (global::com.codename1.charts.compat.Paint) _r9_o, (float) _r10.f);
    label149:;
    _r0_o = _r18_o;
    _r1.i = _r13.i;
    _r4.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getY((int) _r1.i);
    _r0_o = _r16_o;
    _r1.d = _r4.d;
    _r4.i = ((global::com.codename1.charts.views.RangeBarChart) _r0_o).isNullValue((double) _r1.d) ? 1 : 0;
    if (_r4.i != 0) goto label231;
    _r4.i = ((global::java.util.List) _r21_o).size();
    _r5.i = _r12.i + 1;
    if (_r4.i <= _r5.i) goto label231;
    _r4_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r19_o).getChartValuesFormat();
    _r0_o = _r18_o;
    _r1.i = _r13.i;
    _r5.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getY((int) _r1.i);
    _r0_o = _r16_o;
    _r1_o = _r4_o;
    _r2.d = _r5.d;
    _r6_o = ((global::com.codename1.charts.views.RangeBarChart) _r0_o).getLabel((global::com.codename1.charts.util.NumberFormat) _r1_o, (double) _r2.d);
    _r4.i = _r12.i + 1;
    _r0_o = _r21_o;
    _r1.i = _r4.i;
    _r4_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r4_o = _r4_o;
    _r4.f = ((global::java.lang.Float) _r4_o).floatValue();
    _r5.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r19_o).getChartValuesTextSize();
    _r4.f = _r4.f + _r5.f;
    _r5.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r19_o).getChartValuesSpacing();
    _r4.f = _r4.f + _r5.f;
    _r5.f = (float)3.0D;
    _r8.f = _r4.f - _r5.f;
    _r10.f = (float)0.0D;
    _r4_o = _r16_o;
    _r5_o = _r17_o;
    _r9_o = _r20_o;
    ((global::com.codename1.charts.views.RangeBarChart) _r4_o).drawText((global::com.codename1.charts.compat.Canvas) _r5_o, (global::java.lang.String) _r6_o, (float) _r7.f, (float) _r8.f, (global::com.codename1.charts.compat.Paint) _r9_o, (float) _r10.f);
    label231:;
    _r12.i = _r12.i + 4;
    goto label28;
    label235:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: void drawChartValuesText(com.codename1.charts.compat.Canvas, com.codename1.charts.models.XYSeries, com.codename1.charts.renderers.XYSeriesRenderer, com.codename1.charts.compat.Paint, java.util.List, int, int)]
}

public override float getCoeficient(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: float getCoeficient()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.f = (float)0.5D;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: float getCoeficient()]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart: java.lang.String getChartType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=RangeBar
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)82)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart: java.lang.String getChartType()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RangeBarChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.RangeBarChart]

} // end of class: RangeBarChart

} // end of namespace: com.codename1.charts.views
