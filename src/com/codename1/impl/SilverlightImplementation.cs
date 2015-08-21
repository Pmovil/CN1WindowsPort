
using org.xmlvm;
using System.IO;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Net;
using Windows.Devices.Geolocation;
using System.Diagnostics;
using Microsoft.Graphics.Canvas;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.ApplicationModel;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml.Input;
using Windows.Foundation;
using Windows.UI.Input;
using Windows.Storage;
using Windows.Devices.Sensors;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.Phone.Devices.Notification;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage.Pickers;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.Graphics.Canvas.Text;
using Windows.Storage.Search;
using System.Runtime.InteropServices.WindowsRuntime;
using com.codename1.ui.animations;
using com.codename1.ui;
using com.codename1.ui.geom;
using com.codename1.impl;
using System.Net.Http;
using Windows.UI;
using Microsoft.Graphics.Canvas.UI;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Graphics.Display;
using Windows.UI.Text;
using com.codename1.payment;
using Windows.ApplicationModel.Store;
using System.Collections.Concurrent;


namespace com.codename1.impl
{
    public class SilverlightImplementation : global::com.codename1.impl.CodenameOneImplementation, IFileOpenPickerContinuable
    {
        private LocationManager locationManager;
        private static Object PAINT_LOCK = new Object();
        public static SilverlightImplementation instance;
        public static Canvas cl;
        private int displayWidth = -1, displayHeight = -1;
        private NativeFont defaultFont;
        public com.codename1.ui.TextArea currentlyEditing;
        public static Control textInputInstance;
        public static Page app;
        public static CanvasControl screen;
        public static double scaleFactor = 1;
        public static CoreDispatcher dispatcher;
        public static StorageFolder store;
        private static Windows.UI.Xaml.Controls.Image imagePreveiw = new Windows.UI.Xaml.Controls.Image();
        private static CaptureElement captureElement = new CaptureElement();
        private MediaCapture mediaCapture = new MediaCapture();
        public static IList<PointerPoint> points;
        public static int[] x, y;
       

        public static void setCanvas(Page page, Canvas LayoutRoot)
        {
                    
            store = ApplicationData.Current.LocalFolder;
            dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            cl = LayoutRoot;
            app = page;
            scaleFactor = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            screen = new CanvasControl();
            cl.Children.Add(screen);
            screen.Width = cl.ActualWidth * scaleFactor;
            screen.Height = cl.ActualHeight * scaleFactor;
            screen.ClearColor = Windows.UI.Colors.Black; // Maybe white ?
            Canvas.SetLeft(screen, 0);
            Canvas.SetTop(screen, 0);
            myView = new WindowsAsyncView(screen);
        }
        private void page_BackKeyPress(object sender, BackPressedEventArgs e)
        {
            keyPressed(getBackKeyCode());
            keyReleased(getBackKeyCode());
            e.Handled = true;
        }


new         public void @this()
        {
            base.@this();
            instance = this;
        }

        public override bool shouldWriteUTFAsGetBytes()
        {
            return true;
        }


        public override global::System.Object getResourceAsStream(global::java.lang.Class n1, global::java.lang.String n2)
        {
            try
            {
                String uri = toCSharp(n2);
                if (uri.StartsWith("/"))
                {
                    uri = @"res\" + uri.Substring(1);
                }
                uri.Replace('/', '\\');
                Windows.Storage.StorageFolder installFolder = Package.Current.InstalledLocation;
                Windows.Storage.StorageFile file = installFolder.GetFileAsync(uri).AsTask().GetAwaiter().GetResult();
                Stream strm = Task.Run(() => file.OpenStreamForReadAsync()).GetAwaiter().GetResult();
                byte[] byteArr = new byte[strm.Length];
                strm.Read(byteArr, 0, byteArr.Length);
                java.io.ByteArrayInputStream bi = new java.io.ByteArrayInputStream();
                bi.@this(new _nArrayAdapter<sbyte>(toSByteArray(byteArr)));
                return bi;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public static sbyte[] toSByteArray(byte[] byteArray)
        {
            sbyte[] sbyteArray = null;
            if (byteArray != null)
            {
                sbyteArray = new sbyte[byteArray.Length];
                for (int index = 0; index < byteArray.Length; index++)
                    sbyteArray[index] = (sbyte)byteArray[index];
            }
            return sbyteArray;
        }

        public static java.lang.String toJava(System.String str)
        {
            if (str == null)
            {
                return null;
            }
            global::org.xmlvm._nArrayAdapter<char> n = new global::org.xmlvm._nArrayAdapter<char>(str.ToCharArray());
            java.lang.String s = new java.lang.String();
            s.@this(n);
            return s;
        }

        public static string toCSharp(java.lang.String str)
        {
            global::org.xmlvm._nArrayAdapter<char> n = (global::org.xmlvm._nArrayAdapter<char>)str.toCharArray();
            return new string(n.getCSharpArray());
        }

        public override void init(java.lang.Object n1)
        {
            instance = this;
            dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                HardwareButtons.BackPressed += page_BackKeyPress;
                // Touch is way different
                screen.PointerMoved += new PointerEventHandler(LayoutRoot_PointerMoved);
                screen.PointerPressed += new PointerEventHandler(LayoutRoot_PointerPressed);
                screen.PointerReleased += new PointerEventHandler(LayoutRoot_PointerReleased);
                cl.ManipulationMode = ManipulationModes.All;          
            }).AsTask().GetAwaiter();
            ((com.codename1.ui.Display)com.codename1.ui.Display.getInstance()).setDragStartPercentage(3);
            _sensor = SimpleOrientationSensor.GetDefault();
            _sensor.OrientationChanged += new TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs>(app_OrientationChanged);
            ((com.codename1.ui.Display)com.codename1.ui.Display.getInstance()).setTransitionYield(100);
        }

        void app_OrientationChanged(object sender, SimpleOrientationSensorOrientationChangedEventArgs e)
        {
            displayWidth = -1; displayHeight = -1;
            getDisplayWidth(); getDisplayHeight();
            dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
         {

             switch (e.Orientation)
             {
                 case SimpleOrientation.NotRotated:
                     sizeChanged(displayWidth, displayHeight);
                     break;
                 case SimpleOrientation.Rotated90DegreesCounterclockwise:
                     sizeChanged(displayWidth, displayHeight);
                     break;
                 case SimpleOrientation.Rotated180DegreesCounterclockwise:
                     sizeChanged(displayWidth, displayHeight);
                     break;
                 case SimpleOrientation.Rotated270DegreesCounterclockwise:
                     sizeChanged(displayWidth, displayHeight);
                     break;
                 case SimpleOrientation.Faceup:
                     sizeChanged(displayWidth, displayHeight);
                     break;
                 case SimpleOrientation.Facedown:
                     sizeChanged(displayWidth, displayHeight);
                     break;
                 default:
                     sizeChanged(displayWidth, displayHeight);
                     break;
             }
             repaint2();
         }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

        }

        private void repaint2()
        {
            screen.Height = displayHeight; screen.Width = displayWidth;
            Animation cmp;
            Form f = (Form)getCurrentForm();
            cmp = f;

            if (cmp != null)
            {
                repaint(cmp);
            }
            screen.Height = displayHeight; screen.Width = displayWidth;
        }

        public override bool canForceOrientation()
        {
            return true;
        }

        public override global::System.Object getProperty(global::java.lang.String n1, global::java.lang.String n2)
        {

            string p = toCSharp(n1).ToLower();

            //Debug.WriteLine("!!!!!!!! " + p + " ||||||||   ");
            if (p.Equals("os"))
            {
                return toJava("Windows Phone");
            }
            if (p.Equals("platform"))
            {
                return toJava("" + Windows.ApplicationModel.Package.Current.Id.Version.Build);
            }
            if (p.Equals("osver"))
            {
                return toJava("" + Windows.ApplicationModel.Package.Current.Id.Version.Major + "." + Windows.ApplicationModel.Package.Current.Id.Version.Minor);
            }
            if (p.Equals("user-agent"))
            {
                return toJava("M");
            }

            return base.getProperty(n1, n2);
        }

        public override bool minimizeApplication()
        {
            // not ideal but I couldn't find any other way...
            Application.Current.Exit(); // TODO - suspending handler
            return true;
        }

        public override void exitApplication()
        {
            Application.Current.Exit();
        }

        private async static Task<StorageFile> GetFile(string name)
        {
            var folder = ApplicationData.Current.LocalFolder;
            try
            {
                return await folder.GetFileAsync(name);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        public override global::System.Object createMedia(global::java.io.InputStream n1, global::java.lang.String n2, global::java.lang.Runnable n3)
        {
            object ss = createStorageOutputStream(toJava("CN1TempVideodu73aFljhuiw3yrindo87.mp4"));
            java.io.OutputStream os = (java.io.OutputStream)ss;
            com.codename1.io.Util.copy(n1, os);
            Task<StorageFile> storageTask = GetFile("CN1TempVideodu73aFljhuiw3yrindo87.mp4");
            StorageFile file = storageTask.Result;
            Task<Stream> streamTask = file.OpenStreamForReadAsync();
            Stream s = streamTask.Result;
            return new CN1Media(s, toCSharp(n2), n3, cl);
        }
       
        public override void lockOrientation(bool n1)
        {/*
            System.Windows.Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                if (n1)
                {
                    app.SupportedOrientations = SupportedPageOrientation.Portrait;
                }
                else
                {
                    app.SupportedOrientations = SupportedPageOrientation.Landscape;
                }
            });*/
        }

        public override void unlockOrientation()
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal,() =>
            {
                //app.SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;
                app.UseLayoutRounding = true;
            
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public override bool hasNativeTheme()
        {
            return true;
        }

        public override void installNativeTheme()
        {
            com.codename1.ui.util.Resources r = (com.codename1.ui.util.Resources)com.codename1.ui.util.Resources.open(toJava("/winTheme.res"));
            com.codename1.ui.plaf.UIManager uim = (com.codename1.ui.plaf.UIManager)com.codename1.ui.plaf.UIManager.getInstance();
            global::System.Object[] themeNames = ((_nArrayAdapter<global::System.Object>)r.getThemeResourceNames()).getCSharpArray();
            uim.setThemeProps((java.util.Hashtable)r.getTheme((java.lang.String)themeNames[0]));
            com.codename1.ui.plaf.DefaultLookAndFeel dl = (com.codename1.ui.plaf.DefaultLookAndFeel)uim.getLookAndFeel();
            dl.setDefaultEndsWith3Points(false);
        }

        private void LayoutRoot_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
           
            var point = e.GetCurrentPoint(cl).Position;
            if (point != null)
            {
                if (instance.currentlyEditing != null)
                {
                    com.codename1.ui.Form f = (com.codename1.ui.Form)instance.currentlyEditing.getComponentForm();
                    if (f.getComponentAt(x[0], y[0]) == instance.currentlyEditing)
                    {
                        return;
                    }
                }
                pointerDragged(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor));

            }
            else
            {

                x = new int[points.Count];
                y = new int[x.Length];
                for (int iter = 0; iter < points.Count; iter++)
                {
                    x[iter] = Convert.ToInt32(points[iter].Position.X * scaleFactor);
                    y[iter] = Convert.ToInt32(points[iter].Position.Y * scaleFactor);
                }
                _nArrayAdapter<int> xarr = new _nArrayAdapter<int>(x);
                _nArrayAdapter<int> yarr = new _nArrayAdapter<int>(y);
                pointerDragged(xarr, yarr);
            }
            e.Handled = true;
        }

        private void LayoutRoot_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

            points = e.GetIntermediatePoints(cl);
            x = new int[points.Count];
            y = new int[x.Length];
            for (int iter = 0; iter < points.Count; iter++)
            {
                x[iter] = Convert.ToInt32(points[iter].Position.X * scaleFactor);
                y[iter] = Convert.ToInt32(points[iter].Position.Y * scaleFactor);

            }

            if (points.Count == 1)
            {
                if (instance.currentlyEditing != null)
                {
                    com.codename1.ui.Form f = (com.codename1.ui.Form)instance.currentlyEditing.getComponentForm();
                    if (f.getComponentAt(x[0], y[0]) == instance.currentlyEditing)
                    {
                        return;
                    }
                }
                pointerPressed(x[0], y[0]);
            }
            else
            {
                _nArrayAdapter<int> xarr = new _nArrayAdapter<int>(x);
                _nArrayAdapter<int> yarr = new _nArrayAdapter<int>(y);
                pointerPressed(xarr, yarr);
            }
            e.Handled = true;
        }

        private void LayoutRoot_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            points = e.GetIntermediatePoints(cl);
            if (points.Count == 1)
            {
                if (instance.currentlyEditing != null)
                {
                    com.codename1.ui.Form f = (com.codename1.ui.Form)instance.currentlyEditing.getComponentForm();
                    if (f.getComponentAt(x[0], y[0]) == instance.currentlyEditing)
                    {
                        return;
                    }
                    commitEditing();
                }
                pointerReleased(Convert.ToInt32(points[0].Position.X * scaleFactor), Convert.ToInt32(points[0].Position.Y * scaleFactor));
            }
            else
            {
                x = new int[points.Count];
                y = new int[x.Length];
                for (int iter = 0; iter < points.Count; iter++)
                {
                    x[iter] = Convert.ToInt32(points[iter].Position.X * scaleFactor);
                    y[iter] = Convert.ToInt32(points[iter].Position.Y * scaleFactor);

                }
                _nArrayAdapter<int> xarr = new _nArrayAdapter<int>(x);
                _nArrayAdapter<int> yarr = new _nArrayAdapter<int>(y);
                pointerReleased(xarr, yarr);
            }
            e.Handled = true;
        }

        public override int getDisplayWidth()
        {

            if (displayWidth < 0)
            {
                using (AutoResetEvent are = new AutoResetEvent(false))
                {
                    dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {

                        displayWidth = Convert.ToInt32(cl.ActualWidth * scaleFactor);
                        are.Set();

                    }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                    are.WaitOne();
                }
            }
            return displayWidth;
        }

        public override int getDisplayHeight()
        {
            if (displayHeight < 0)
            {
                using (AutoResetEvent are = new AutoResetEvent(false))
                {
                    dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {

                        displayHeight = Convert.ToInt32(cl.ActualHeight * scaleFactor);
                        are.Set();

                    }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                    are.WaitOne();
                }
            }
            return displayHeight;
        }

        public override bool isNativeInputSupported()
        {
            return true;
        }

        public override bool isNativeInputImmediate()
        {
            return true;
        }

        public static void commitEditing()
        {
            instance.currentlyEditing = null;
        }

        private void setConstraint(TextBox tb, InputScopeNameValue v)
        {
            InputScope ins = new InputScope();
            InputScopeName insane = new InputScopeName();
            insane.NameValue = v;
            ins.Names.Add(insane);
            tb.InputScope = ins;
        }

        private bool lockEditing;
        public override void editString(global::com.codename1.ui.Component n1, int n2, int n3, global::java.lang.String n4, int n5)
        {
            com.codename1.ui.Display d = (com.codename1.ui.Display)com.codename1.ui.Display.getInstance();
            if (textInputInstance != null)
            {
                commitEditing();
                d.callSerially(new EditString(n1, n2, n3, n4, n5));
                return;
            }
            if (lockEditing)
            {
                d.callSerially(new EditString(n1, n2, n3, n4, n5));
                return;
            }
            lockEditing = true;
            currentlyEditing = (com.codename1.ui.TextArea)n1;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   int constraints = currentlyEditing.getConstraint();
                   bool isPassword = (constraints & com.codename1.ui.TextArea._fPASSWORD) == com.codename1.ui.TextArea._fPASSWORD;
                   if (n1.getClientProperty(toJava("disableWinPassword")) != null)
                   {
                       isPassword = false;
                   }
                   if (isPassword)
                   {
                       textInputInstance = new PasswordBox();
                       ((PasswordBox)textInputInstance).PasswordChanged += textChangedEvent;
                       ((PasswordBox)textInputInstance).Password = toCSharp(n4);
                       ((PasswordBox)textInputInstance).MaxLength = n2;
                   }
                   else
                   {
                       textInputInstance = new TextBox();
                       ((TextBox)textInputInstance).IsTextPredictionEnabled = true;
                       ((TextBox)textInputInstance).TextChanged += textChangedEvent;
                       ((TextBox)textInputInstance).Text = toCSharp(n4);
                       ((TextBox)textInputInstance).AcceptsReturn = !currentlyEditing.isSingleLineTextArea();
                       ((TextBox)textInputInstance).MaxLength = n2;
    
                       if ((constraints & com.codename1.ui.TextArea._fNON_1PREDICTIVE) == com.codename1.ui.TextArea._fNON_1PREDICTIVE)
                       {
                           ((TextBox)textInputInstance).InputScope = new InputScope();
                       }

                       if ((constraints & com.codename1.ui.TextArea._fNUMERIC) == com.codename1.ui.TextArea._fNUMERIC)
                       {
                           setConstraint((TextBox)textInputInstance, InputScopeNameValue.NumberFullWidth);
                       }
                       else
                       {
                           if ((constraints & com.codename1.ui.TextArea._fDECIMAL) == com.codename1.ui.TextArea._fDECIMAL)
                           {
                               setConstraint((TextBox)textInputInstance, InputScopeNameValue.Number);
                           }
                           else
                           {
                               if ((constraints & com.codename1.ui.TextArea._fEMAILADDR) == com.codename1.ui.TextArea._fEMAILADDR)
                               {
                                   setConstraint((TextBox)textInputInstance, InputScopeNameValue.EmailSmtpAddress);
                               }
                               else
                               {
                                   if ((constraints & com.codename1.ui.TextArea._fURL) == com.codename1.ui.TextArea._fURL)
                                   {
                                       setConstraint((TextBox)textInputInstance, InputScopeNameValue.Url);
                                   }
                                   else
                                   {
                                       if ((constraints & com.codename1.ui.TextArea._fPHONENUMBER) == com.codename1.ui.TextArea._fPHONENUMBER)
                                       {
                                           setConstraint((TextBox)textInputInstance, InputScopeNameValue.TelephoneNumber);
                                       }
                                   }
                               }
                           }
                       }
                   }
                   cl.Children.Add(textInputInstance);
                   Canvas.SetZIndex(textInputInstance, 50000);
                   textInputInstance.IsEnabled = true;
                   com.codename1.ui.Font fnt = (com.codename1.ui.Font)((com.codename1.ui.plaf.Style)currentlyEditing.getStyle()).getFont();

                   object x = f((java.lang.Object)fnt.getNativeFont());
                   NativeFont font = (NativeFont)x;
                   // workaround forsome weird unspecified margin that appears around the text box
                   Canvas.SetTop(textInputInstance, (currentlyEditing.getAbsoluteY() / scaleFactor));
                   Canvas.SetLeft(textInputInstance, (currentlyEditing.getAbsoluteX() / scaleFactor));
                   textInputInstance.Height = (currentlyEditing.getHeight() / scaleFactor);
                   textInputInstance.Width = (currentlyEditing.getWidth() / scaleFactor);
                   textInputInstance.BorderThickness = new Thickness();
                   textInputInstance.FontSize = (font.font.FontSize / scaleFactor);
                   int h = Convert.ToInt32((textInputInstance.Height - textInputInstance.FontSize) / 3);
                   textInputInstance.Margin = new Thickness();
                   textInputInstance.Padding = new Thickness(10,h,0,0);
                   textInputInstance.Clip = null;
                   textInputInstance.Focus(FocusState.Programmatic);
                   are.Set();
               }).AsTask().GetAwaiter();
                are.WaitOne();
            }
            d.invokeAndBlock(new WaitForEdit());
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   cl.Children.Remove(textInputInstance);
                   textInputInstance = null;
                   // cl.Focus;
               }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
            lockEditing = false;
        }

        void textChangedEvent(object sender, RoutedEventArgs e)
        {
            com.codename1.ui.Display disp = (com.codename1.ui.Display)com.codename1.ui.Display.getInstance();
            Tchange t = new Tchange();
            t.currentlyEditing = currentlyEditing;
            if (textInputInstance is TextBox)
            {
                t.text = toJava(((TextBox)textInputInstance).Text);
            }
            else
            {
                t.text = toJava(((PasswordBox)textInputInstance).Password);
            }
            disp.callSerially(t);
        }

        class Tchange : java.lang.Object, java.lang.Runnable
        {
            public com.codename1.ui.TextArea currentlyEditing;
            public java.lang.String text;
            public virtual void run()
            {
                if (currentlyEditing != null)
                {
                    currentlyEditing.setText(text);
                }
            }
        }

        public override void confirmControlView()
        {
            //screen.Visibility = Visibility.Visible;
        }

        //public override void paintDirty()
        //{
        //    base.paintDirty();
        //    dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
        //    {
        //        screen.Visibility = Visibility.Visible;
        //    }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        //}

        public override bool hasPendingPaints()
        {
            //if the view is not visible make sure the edt won't wait.
            //if (screen.Visibility.Equals(Visibility.Collapsed)) {
            //    return true;
            //} else {
            return base.hasPendingPaints();
            //}
        }
        public override void repaint(Animation cmp)
        {
            if (myView != null)
            {
                if (cmp is Component)
                {
                    Component c = (Component)cmp;
                    c.setDirtyRegion(null);
                    if (c.getParent() != null)
                    {
                        cmp = (Form)c.getComponentForm();
                    }
                    else
                    {
                        Form f = (Form)getCurrentForm();
                        if (f != null)
                        {
                            cmp = f;
                        }
                    }
                }
                else
                {
                    // make sure the form is repainted for standalone anims e.g. in the case
                    // of replace animation
                    Form f = (Form)getCurrentForm();
                    if (f != null)
                    {
                        base.repaint(f);
                    }
                }
            }
            cmp.animate();
            base.repaint(cmp);
        }

        public override void flushGraphics(int x, int y, int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                return;
            }
            //using (AutoResetEvent are = new AutoResetEvent(false))
            //{
            //    dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            //    {
                    Rectangle rect = new Rectangle();
                    rect.@this(x, y, width, height);
                    myView.flushGraphics(rect);
                    //screen.Invalidate();
            //        are.Set();
            //    }).AsTask().GetAwaiter().GetResult();
            //    are.WaitOne();
            //}
        }

        public override void flushGraphics()
        {
            //using (AutoResetEvent are = new AutoResetEvent(false))
            //{
            //    dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            //    {
                    myView.flushGraphics();
            //        are.Set();
            //    }).AsTask().GetAwaiter().GetResult();
            //    are.WaitOne();
            //}
        }

        public override void systemOut(global::java.lang.String n1)
        {
            System.Diagnostics.Debug.WriteLine(toCSharp(n1));
        }
     
        public override void getRGB(java.lang.Object n1, _nArrayAdapter<int> n2, int n3, int n4, int n5, int n6, int n7)
        {
            CodenameOneImage cn = (CodenameOneImage)n1;
            // TODO - verify access violation. Wrong thread ?
            byte[] buffer = cn.image.GetPixelBytes();

            int[] p = new int[buffer.Length / 4];
            for (int pos = 0; pos < p.Length; pos++)
            {
                // BGRA - VERIFICAR
                p[pos] = buffer[4 * pos] + (buffer[4 * pos + 1] << 8) + (buffer[4 * pos + 2] << 16) + (buffer[4 * pos + 3] << 24);
            }
            int t = n3 + n5 * cn.getImageWidth() + n4;
            int l = t + n6 * n7;
            for (int iter = t; iter < l; iter++)
            {
                n2.getCSharpArray()[iter - t] = p[iter];
            }
        }

        public override void setImageName(global::java.lang.Object n1, global::java.lang.String n2)
        {
            if (n2 != null)
            {
                ((CodenameOneImage)n1).name = toCSharp(n2);
            }
        }

        public override object createImage(_nArrayAdapter<int> n1, int n2, int n3)
        {
            CodenameOneImage ci = new CodenameOneImage();
            ci.@this();
            byte[] buf = new byte[n1.Length * 4];
            for (int pos = 0; pos < n1.Length; pos++)
            {
                buf[4 * pos] = (byte)(n1[pos] & 0xff);
                buf[4 * pos + 1] = (byte)((n1[pos] >> 8) & 0xff);
                buf[4 * pos + 2] = (byte)((n1[pos] >> 16) & 0xff);
                buf[4 * pos + 3] = (byte)(0xff); // no alpha
                //                buf[4 * pos + 3] = (byte)((n1[pos] >> 24) & 0xff);
            }
            // TODO - verify if pixelFormat below is the correct one
            CanvasBitmap cb = CanvasBitmap.CreateFromBytes(screen, buf, n2, n3, pixelFormat);
            CanvasRenderTarget cr = new CanvasRenderTarget(screen, (float)cb.Size.Width, (float)cb.Size.Height, cb.Dpi);
            using (var ds = cr.CreateDrawingSession())
            {
                ds.Clear(Colors.White);
                // ds.DrawImage();
            }
            ci.image = cr;
            ci.graphics.destination.drawImage(cb, 0, 0);

            return ci;
        }

        public override object createImage(java.lang.String n1)
        {
            if (n1.startsWith(toJava("file:")))
            {
                return createImage((java.io.InputStream)openFileInputStream(n1));
            }
            global::java.io.InputStream s = (global::java.io.InputStream)getResourceAsStream(null, n1);
            return createImage(s);
        }

        public override object createImage(java.io.InputStream n1)
        {
            global::org.xmlvm._nArrayAdapter<sbyte> b = (global::org.xmlvm._nArrayAdapter<sbyte>)com.codename1.io.Util.readInputStream(n1);
            return createImage(b, 0, b.Length);
        }

        public static byte[] toByteArray(sbyte[] byteArray)
        {
            byte[] sbyteArray = null;
            if (byteArray != null)
            {
                sbyteArray = new byte[byteArray.Length];
                for (int index = 0; index < byteArray.Length; index++)
                    sbyteArray[index] = (byte)byteArray[index];
            }
            return sbyteArray;
        }

        const int maxCacheSize = 100;
        private static ConcurrentDictionary<int, CodenameOneImage> imageCache = new ConcurrentDictionary<int, CodenameOneImage>();

        public override global::System.Object createImage(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3)
        {
            if (imageCache.ContainsKey(n1.hashCode())) {
                CodenameOneImage cached;
                imageCache.TryGetValue(n1.hashCode(), out cached);
                return cached;
            }
            CodenameOneImage ci = null;

            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    IRandomAccessStream s;
                    if (n1.Length != n3 || n2 != 0)
                    {
                        // TODO
                        s = new MemoryStream(toByteArray(n1.getCSharpArray())).AsRandomAccessStream();
                    }
                    else
                    {
                        s = new MemoryStream(toByteArray(n1.getCSharpArray())).AsRandomAccessStream();
                    }
                    try
                    {
                        CanvasBitmap canvasbitmap = CanvasBitmap.LoadAsync(screen, s).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                        CodenameOneImage cim = new CodenameOneImage();
                        cim.@this();
                        CanvasRenderTarget cr = new CanvasRenderTarget(screen, float.Parse(canvasbitmap.Size.Width.ToString()), float.Parse(canvasbitmap.Size.Height.ToString()), canvasbitmap.Dpi);
                        cim.image = cr;
                        cim.graphics.destination.drawImage(canvasbitmap, 0, 0);
                        cim.graphics.destination.dispose();
                        ci = cim;
                        dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
                        {
                            imageCache.TryAdd(n1.hashCode(), ci);
                            if (imageCache.Count > maxCacheSize)
                            {
                                int key = imageCache.GetEnumerator().Current.Key;
                                CodenameOneImage ignored;
                                imageCache.TryRemove(key, out ignored);
                            }
//                            Debug.WriteLine("Image cached " + n1.hashCode());
                        }).AsTask();
//                        Debug.WriteLine("Image created " + n1.hashCode());
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("Failed to create image " + n1.hashCode());
                    }
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
            return ci;
        }
        public static bool exitLock;
        private global::com.codename1.ui.events.ActionListener pendingCaptureCallback;

        public override void capturePhoto(global::com.codename1.ui.events.ActionListener n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                exitLock = true;
                pendingCaptureCallback = n1;
                try
                {
                    mediaCapture.InitializeAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                    mediaCapture.SetPreviewRotation(VideoRotation.Clockwise90Degrees);
                    VideoRotation previewRotation = mediaCapture.GetPreviewRotation();
                    captureElement.HorizontalAlignment = HorizontalAlignment.Left;
                    captureElement.VerticalAlignment = VerticalAlignment.Top;
                    captureElement.Stretch = Stretch.UniformToFill;
                    captureElement.Source = mediaCapture;
                    cl.Children.Add(captureElement);
                    mediaCapture.StartPreviewAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

                    mediaCapture.PhotoConfirmationCaptured += mediaCapture_PhotoConfirmationCaptured;
                }
                catch (UnauthorizedAccessException)
                {

                    throw;
                }


            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        void mediaCapture_PhotoConfirmationCaptured(MediaCapture sender, PhotoConfirmationCapturedEventArgs e)
        {
            if (e.CaptureTimeOffset != null)
            {
                ImageEncodingProperties imgFormat = ImageEncodingProperties.CreateJpeg();
                var file = KnownFolders.CameraRoll.CreateFileAsync("foto.jpeg", CreationCollisionOption.GenerateUniqueName).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                sender.CapturePhotoToStorageFileAsync(imgFormat, file).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

                com.codename1.ui.events.ActionEvent ac = new com.codename1.ui.events.ActionEvent();
                ac.@this(toJava("file:/" + file));
                fireCapture(ac);
            }
            else
            {
                fireCapture(null);
            }
        }

        private void fireCapture(com.codename1.ui.events.ActionEvent ev)
        {
            com.codename1.ui.util.EventDispatcher ed = new com.codename1.ui.util.EventDispatcher();
            ed.@this();
            ed.addListener((java.lang.Object)pendingCaptureCallback);
            ed.fireActionEvent(ev);
            pendingCaptureCallback = null;
            exitLock = false;
        }



        public override void openImageGallery(ui.events.ActionListener n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                exitLock = true;
                pendingCaptureCallback = n1;
                FileOpenPicker openPicker = new FileOpenPicker();
                openPicker.ViewMode = PickerViewMode.Thumbnail;
                openPicker.SuggestedStartLocation = PickerLocationId.VideosLibrary;
                openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
                openPicker.FileTypeFilter.Add(".jpg");
                openPicker.FileTypeFilter.Add(".jpeg");
                openPicker.FileTypeFilter.Add(".png");
                // Launch file open picker and caller app is suspended and may be terminated if required 
                openPicker.PickSingleFileAndContinue();
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public void ContinueFileOpenPicker(Windows.ApplicationModel.Activation.FileOpenPickerContinuationEventArgs args)
        {

            if (args.Files.Count > 0)
            {

                var stream = args.Files[0].OpenAsync(FileAccessMode.Read).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                var bitmapImage = new BitmapImage();
                bitmapImage.SetSourceAsync(stream).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                imagePreveiw.Source = bitmapImage;

            }
            else
            {


            }
        }
        public override object getCodeScanner()
        {
            ZxingCN1 z = new ZxingCN1();
            return z;
        }

        class ZxingCN1 : com.codename1.codescan.CodeScanner
        {

            private WindowsPhone8Demo.Extensions.AsyncPictureDecoderExtension asyncPictureDecoder;
            private codescan.ScanResult result;
            public override void scanBarCode(codescan.ScanResult n1)
            {
                result = n1;
                MediaCapture capture = new MediaCapture();
                capture.PhotoConfirmationCaptured += captureTask_Completed;

            }

            private void captureTask_Completed(MediaCapture sender, PhotoConfirmationCapturedEventArgs e)
            {
                asyncPictureDecoder = new WindowsPhone8Demo.Extensions.AsyncPictureDecoderExtension(result, e);
            }
            public override void scanQRCode(codescan.ScanResult n1)
            {
                scanBarCode(n1);
            }
        }

        public override bool isNativeBrowserComponentSupported()
        {
            return true;
        }

        com.codename1.ui.BrowserComponent currentBrowser;

        public override global::System.Object createBrowserComponent(global::java.lang.Object n1)
        {
            SilverlightPeer sp = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    WebView webview = new WebView();
                    currentBrowser = (com.codename1.ui.BrowserComponent)n1;
                    webview.NavigationStarting += wb_Navigating;
                    webview.ContentLoading += webview_ContentLoading;
                    webview.IsTapEnabled = true;
                    webview.NavigationCompleted += wb_NavigationCompleted;
                    sp = new SilverlightPeer(webview);
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return sp;
        }


        void wb_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs e)
        {
            if (e.IsSuccess == true)
            {
                Debug.WriteLine((toJava(e.Uri.OriginalString)));
            }
            else
            {
                com.codename1.ui.events.BrowserNavigationCallback bn = (com.codename1.ui.events.BrowserNavigationCallback)currentBrowser.getBrowserNavigationCallback();
                com.codename1.ui.events.ActionEvent ev = new com.codename1.ui.events.ActionEvent();
                ev.@this(toJava(e.Uri.OriginalString));
                currentBrowser.fireWebEvent(toJava("onError"), ev);
            }
        }
        void webview_ContentLoading(WebView sender, WebViewContentLoadingEventArgs e)
        {
            com.codename1.ui.events.BrowserNavigationCallback bn = (com.codename1.ui.events.BrowserNavigationCallback)currentBrowser.getBrowserNavigationCallback();
            com.codename1.ui.events.ActionEvent ev = new com.codename1.ui.events.ActionEvent();
            ev.@this(toJava(e.Uri.OriginalString));
            currentBrowser.fireWebEvent(toJava("onLoad"), ev);
        }
        void wb_Navigating(WebView sender, WebViewNavigationStartingEventArgs e)
        {
            com.codename1.ui.events.BrowserNavigationCallback bn = (com.codename1.ui.events.BrowserNavigationCallback)currentBrowser.getBrowserNavigationCallback();
            if (!bn.shouldNavigate(toJava(e.Uri.ToString())))
            {
                e.Cancel = true;
            }
            com.codename1.ui.events.ActionEvent ev = new com.codename1.ui.events.ActionEvent();
            ev.@this(toJava(e.Uri.OriginalString));
            currentBrowser.fireWebEvent(toJava("onStart"), ev);
        }

        public override global::System.Object getBrowserTitle(global::com.codename1.ui.PeerComponent n1)
        {
            string[] args = { "document.title.toString()" };
            string st = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    WebView s = (WebView)((SilverlightPeer)n1).element;
                    st = s.InvokeScriptAsync("eval", args).ToString();
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return toJava(st);
        }

        private Purchase pur;
        private WindowsPurchase windPur;
       
       
        public override object getInAppPurchase()
        {
           
            windPur = new WindowsPurchase(screen);
            try
            {
                pur = windPur;
                return pur;
            }
            catch (Exception)
            {

                return base.getInAppPurchase();
            }
        }
       
       

        public override global::System.Object getBrowserURL(global::com.codename1.ui.PeerComponent n1)
        {
            WebView s = (WebView)((SilverlightPeer)n1).element;
            return toJava(s.Source.OriginalString);
        }

        public override void setBrowserURL(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
           {
               WebView s = (WebView)((SilverlightPeer)n1).element;
               string uri = toCSharp(n2);
               if (uri.StartsWith("jar:/"))
               {
                   uri = uri.Substring(5);
                   while (uri[0] == '/')
                   {
                       uri = uri.Substring(1);
                   }
                   uri = "res/" + uri;
                   s.Source = new Uri(uri, UriKind.Relative);
                   return;
               }
               s.Source = new Uri(uri);
           }).AsTask().GetAwaiter();
        }

        public override void browserReload(global::com.codename1.ui.PeerComponent n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                WebView s = (WebView)((SilverlightPeer)n1).element;
                s.Source = s.Source;
            }).AsTask().GetAwaiter();
        }

        public override bool browserHasBack(global::com.codename1.ui.PeerComponent n1)
        {
            bool ret = false;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   WebView s = (WebView)((SilverlightPeer)n1).element;
                   ret = s.CanGoBack;
                   are.Set();
               }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return ret;
        }

        public override bool browserHasForward(global::com.codename1.ui.PeerComponent n1)
        {
            bool ret = false;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                 {
                     WebView s = (WebView)((SilverlightPeer)n1).element;
                     ret = s.CanGoForward;
                     are.Set();
                 }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return ret;
        }

        public override void browserBack(global::com.codename1.ui.PeerComponent n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                WebView s = (WebView)((SilverlightPeer)n1).element;
                s.GoBack();
            }).AsTask().GetAwaiter().GetResult();
        }

        public override void browserStop(global::com.codename1.ui.PeerComponent n1)
        {
        }

        public override void browserDestroy(global::com.codename1.ui.PeerComponent n1)
        {
        }

        public override void browserForward(global::com.codename1.ui.PeerComponent n1)
        {
            WebView s = (WebView)((SilverlightPeer)n1).element;
            s.GoForward();
        }

        public override void browserClearHistory(global::com.codename1.ui.PeerComponent n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                WebView s = (WebView)((SilverlightPeer)n1).element;
                //s.ClearCookiesAsync();
                //s.ClearInternetCacheAsync();

            }).AsTask().GetAwaiter().GetResult();
        }

        public override void setBrowserPage(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2, global::java.lang.String n3)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
           {
               WebView s = (WebView)((SilverlightPeer)n1).element;
               s.NavigateToString(toCSharp(n2));
           }).AsTask().GetAwaiter();
        }

        public override void sendMessage(_nArrayAdapter<object> n1, java.lang.String n2, messaging.Message n3)
        {

            string subject = toCSharp(n2);
            var contactPicker = new Windows.ApplicationModel.Contacts.ContactPicker();
            contactPicker.DesiredFieldsWithContactFieldType.Add(ContactFieldType.Email);

            Contact recipient = contactPicker.PickContactAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

            if (recipient != null)
            {
                IList<ContactEmail> fields = recipient.Emails;

                if (fields.Count > 0)
                {

                    if (fields[0].GetType() == typeof(ContactEmail))
                    {
                        foreach (ContactEmail email in fields as IList<ContactEmail>)
                        {

                            EmailMessage emailMessage = new EmailMessage();
                            emailMessage.Body = toCSharp((java.lang.String)n3.getContent()); ;
                            emailMessage.Subject = subject;
                            var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient(email.Address);
                            emailMessage.To.Add(emailRecipient);
                            EmailManager.ShowComposeNewEmailAsync(emailMessage).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                            break;
                        }

                    }
                }
                else
                {
                    //OutputTextBlock.Text = "No recipient emailid Contact found";
                }
            }
            else
            {
                // OutputTextBlock.Text = "No recipient emailid Contact found";
            }

        }

        public override void sendSMS(java.lang.String n1, java.lang.String n2, bool n)
        {
            var chatMessage = new Windows.ApplicationModel.Chat.ChatMessage();
            chatMessage.Body = toCSharp(n2);
            chatMessage.Recipients.Add(toCSharp(n1));
            Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(chatMessage).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

        }

        public override void execute(global::java.lang.String n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                WebView t = new WebView();
                t.Source = new Uri(toCSharp(n1), UriKind.RelativeOrAbsolute);
                //t.Show();
            }).AsTask().GetAwaiter();
        }

        public override void browserExecute(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2)
        {
            String[] args = { "document.title.toString()" };
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                WebView s = (WebView)((SilverlightPeer)n1).element;
                s.InvokeScriptAsync(toCSharp(n2), args).ToString();
            }).AsTask().GetAwaiter();
        }

        public override global::System.Object browserExecuteAndReturnString(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2)
        {
            String[] args = { "document.title.toString()" };
            string st = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    WebView s = (WebView)((SilverlightPeer)n1).element;
                    st = s.InvokeScriptAsync(toCSharp(n2), args).ToString();
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return toJava(st);
        }

        public override object createMutableImage(int width, int height, int color)
        {
            CodenameOneImage ci = new CodenameOneImage();
            ci.@this();
            ci.setSize(width, height);
            CanvasRenderTarget cr = new CanvasRenderTarget(screen, screen.ConvertPixelsToDips(width), screen.ConvertPixelsToDips(height), screen.Dpi);
            ci.image = cr;
            ci.graphics.destination.setAlpha(0xff);
            ci.graphics.destination.setColor(color);
            ci.graphics.destination.clear();
            return ci;
        }

        public override int getImageWidth(java.lang.Object n1)
        {
            return ((CodenameOneImage)n1).getImageWidth();
        }

        public override int getImageHeight(java.lang.Object n1)
        {
            return ((CodenameOneImage)n1).getImageHeight();
        }

        public override object scale(java.lang.Object sourceImage, int width, int height)
        {
            CodenameOneImage image = (CodenameOneImage)sourceImage;

            int srcWidth = image.getImageWidth();
            int srcHeight = image.getImageHeight();

            // no need to scale
            if (srcWidth == width && srcHeight == height)
            {
                return image;
            }

            CodenameOneImage ci = new CodenameOneImage();
            ci.@this();
            CanvasRenderTarget cr = new CanvasRenderTarget(image.image.Device, image.image.ConvertPixelsToDips(width), image.image.ConvertPixelsToDips(height), image.image.Dpi);
            ci.image = cr;
            ci.graphics.destination.drawImage(image.image, 0, 0, width, height);
            ci.graphics.destination.dispose();
            return ci;
        }

        public override int getSoftkeyCount()
        {
            return 0;
        }

        public override object getSoftkeyCode(int n1)
        {
            return null;
        }

        public override int getClearKeyCode()
        {
            return 0;
        }

        public override int getBackspaceKeyCode()
        {
            return 0;
        }

        public override int getBackKeyCode()
        {
            return -20;
        }

        public override int getGameAction(int n1)
        {
            return 0;
        }

        public override int getKeyCode(int n1)
        {
            return 0;
        }

        public override bool isTouchDevice()
        {
            return true;
        }

        public override int getColor(java.lang.Object graphics)
        {
            return ((NativeGraphics)graphics).destination.getColor();
        }

        public override void setColor(java.lang.Object graphics, int RGB)
        {
            // Debug.WriteLine("setColor " + RGB);
            try
            {

                ((NativeGraphics)graphics).destination.setColor(RGB);
            }
            catch (Exception)
            {

                ((NativeGraphics)graphics).destination.setColor((int)(getColor(graphics) & 0xff000000) | RGB);
            }

        }

        public override void setAlpha(java.lang.Object graphics, int alpha)
        {
            // Debug.WriteLine("setAlpha " + alpha);
            ((NativeGraphics)graphics).destination.setAlpha(alpha);
            ((NativeGraphics)graphics).destination.setColor(getColor(graphics) | (alpha << 24));
        }

        public override int getAlpha(java.lang.Object graphics)
        {
            return ((NativeGraphics)graphics).destination.getAlpha();
        }

        public override void setNativeFont(java.lang.Object graphics, java.lang.Object font)
        {
            NativeFont f;
            if (font == null)
            {
                f = (NativeFont)getDefaultFont();
            }
            else
            {
                f = (NativeFont)font;
            }
            ((NativeGraphics)graphics).font = f;
        }

        public override int getClipX(java.lang.Object graphics)
        {
            return ((NativeGraphics)graphics).getClipX();
        }

        public override int getClipY(java.lang.Object graphics)
        {
            return ((NativeGraphics)graphics).getClipY();
        }

        public override int getClipWidth(java.lang.Object graphics)
        {
            return ((NativeGraphics)graphics).getClipW();
        }

        public override int getClipHeight(java.lang.Object graphics)
        {
            return ((NativeGraphics)graphics).getClipH();
        }

        public override void setClip(java.lang.Object graphics, int clipX, int clipY, int clipW, int clipH)
        {
            NativeGraphics ng = (NativeGraphics)graphics;
            Rectangle clip = new Rectangle();
            clip.@this(clipX, clipY, clipW, clipH);
            ng.clip = clip;
            //Debug.WriteLine("setClip " + clipX + " " + clipY + " " + clipW + " " + clipH);
        }

        public override void clipRect(java.lang.Object graphics, int x, int y, int w, int h)
        {

            NativeGraphics ng = (NativeGraphics)graphics;
            Rectangle clip = new Rectangle();
            clip.@this(x, y, w, h);
            if (ng.clip != null)
            {
                ng.clip = (Rectangle)clip.intersection(ng.clip);
            }
            else
            {
                Debug.WriteLine("clipRect nulo " + ng.destination);
                ng.clip = clip;
            }
            //Debug.WriteLine("clipRect " + x + " " + y + " " + w + " " + h);
        }

        //Line drawLineLineInstance;
        public override void drawLine(java.lang.Object graphics, int x1, int y1, int x2, int y2)
        {

            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawLine(x1, y1, x2, y2);
            //// Debug.WriteLine("drawLine " + x1 + " " + y1 + " " + x2 + " " + y2);
        }

        //Rectangle fillDrawRectInstance;
        public override void fillRect(java.lang.Object graphics, int x, int y, int w, int h)
        {

            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.fillRect(x, y, w, h);
            // Debug.WriteLine("fillRect " + x + " " + y + " " + w + " " + h);
        }

        public override void drawRect(java.lang.Object graphics, int x, int y, int w, int h)
        {

            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawRect(x, y, w, h);
            // Debug.WriteLine("drawRect " + x + " " + y + " " + w + " " + h);
        }

        public override void drawRoundRect(java.lang.Object graphics, int x, int y, int w, int h, int arcW, int arcH)
        {
            //  Debug.WriteLine("drawRoundRect " + x + " " + y + " " + w + " " + h + " " + arcW + " " + arcH);
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawRoundRect(x, y, w, h, arcW, arcH);
        }

        public override void fillRoundRect(java.lang.Object graphics, int x, int y, int w, int h, int arcW, int arcH)
        {
            //  Debug.WriteLine("fillRoundRect " + x + " " + y + " " + w + " " + h + " " + arcW + " " + arcH);
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.fillRoundRect(x, y, w, h, arcW, arcH);
        }

        public override void fillArc(java.lang.Object graphics, int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            // Debug.WriteLine("fillArc " + x + " " + y + " " + w + " " + h + " " + startAngle + " " + arcAngle);
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.fillArc(x, y, w, h, null); // TODO
        }

        public override void drawArc(java.lang.Object graphics, int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            //Debug.WriteLine("drawArc " + x + " " + y + " " + w + " " + h + " " + startAngle + " " + arcAngle);
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawArc(x, y, w, h, null); // TODO
        }

        public override void drawString(java.lang.Object graphics, java.lang.String str, int x, int y)
        {
            // Debug.WriteLine("drawString " + x + " " + y);
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawString(toCSharp(str), x, y);
        }

        public override void drawImage(java.lang.Object graphics, java.lang.Object n2, int x, int y)
        {
            // Debug.WriteLine("drawImage " + x + " " + y);
            CodenameOneImage img = (CodenameOneImage)n2;
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawImage(img.image, x, y);
        }

        public override bool areMutableImagesFast()
        {
            return false; // async painter
        }

        public override void drawImage(java.lang.Object graphics, java.lang.Object n2, int x, int y, int w, int h)
        {
            // Debug.WriteLine("drawImage " + x + " " + y + " " + w + " " + h);
            CodenameOneImage img = (CodenameOneImage)n2;
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.drawImage(img.image, x, y, w, h);
        }

        public override void drawRGB(java.lang.Object graphics, _nArrayAdapter<int> rgb, int offset, int x, int y, int w, int h, bool n8)
        {
            // Debug.WriteLine("drawRGB " + x + " " + y + " " + w + " " + h);
            CodenameOneImage ci = (CodenameOneImage)createImage(rgb, w, h);
            ci.@this();
            drawImage(graphics, ci, x, y);
        }

        public override object getNativeGraphics()
        {
            if (globalGraphics == null)
            {
                globalGraphics = myView.getGraphics();
            }
            return globalGraphics;
        }

        public override object getNativeGraphics(java.lang.Object img)
        {
            CodenameOneImage image = (CodenameOneImage)img;
            if (image.graphics == null)
            {
                image.image = new CanvasRenderTarget(screen, image.getImageWidth(), image.getImageHeight(), screen.Dpi);
            }
            setClip(image.graphics, 0, 0, image.getImageWidth(), image.getImageHeight());
            return image.graphics;
        }


        public override int charsWidth(java.lang.Object n1, _nArrayAdapter<char> n2, int n3, int n4)
        {
            global::java.lang.String s = new global::java.lang.String();
            s.@this(n2, n3, n4);
            return stringWidth(n1, s);
        }

        public override int stringWidth(java.lang.Object n1, java.lang.String n2)
        {
            NativeFont font = f(n1);
            return font.getStringWidth(toCSharp(n2));
        }

        public override int charWidth(java.lang.Object n1, char n2)
        {
            return stringWidth(n1, toJava("" + n2));
        }

        public override int getFace(global::java.lang.Object n1)
        {
            object x = f(n1);
            NativeFont s = (NativeFont)x;
            return s.face;
            // return f(n1).face;
        }

        public override int getSize(global::java.lang.Object n1)
        {
            object x = f(n1);
            NativeFont s = (NativeFont)x;
            return s.size;
            //  return f(n1).size;
        }

        public override int getStyle(global::java.lang.Object n1)
        {
            object x = f(n1);
            NativeFont s = (NativeFont)x;
            return s.style;
            // return f(n1).style;
        }

        public override int getHeight(java.lang.Object n1)
        {
            object x = f(n1);
            NativeFont s = (NativeFont)x;
            return s.height;
            //return f(n1).actualHeight;
        }

        public override bool isLookupFontSupported()
        {
            return true;
        }

        public override object loadNativeFont(java.lang.String lookupStr)
        {
            string lookup = toCSharp(lookupStr);
            string[] fonts = lookup.Split(new Char[] { ';' });
            foreach (string f in fonts)
            {
                try
                {
                    string[] split = f.Split(new Char[] { '-' });
                    String familyName = split[0];
                    String style = split[1];
                    String size = split[2];

                    NativeFont nf = new NativeFont(0, 0, 0, new CanvasTextFormat());
                    using (AutoResetEvent are = new AutoResetEvent(false))
                    {
                        dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            nf.font.FontFamily = familyName;

                            if (style.Equals("bolditalic"))
                            {
                                nf.font.FontWeight = FontWeights.Bold;
                                nf.font.FontStyle = FontStyle.Italic;
                                nf.style = 2 & 1;
                            }
                            else if (style.Equals("italic"))
                            {
                                nf.font.FontStyle = FontStyle.Italic;
                                nf.style = 2;
                            }
                            else if (style.Equals("bold"))
                            {
                                nf.font.FontWeight = FontWeights.Bold;
                                nf.style = 1;
                            }
                            nf.font.FontSize = Convert.ToInt32(size);
                            nf.font.WordWrapping = CanvasWordWrapping.NoWrap;
                            are.Set();
                        }).AsTask().GetAwaiter().GetResult();
                        are.WaitOne();
                    }

                    return nf;
                }
                catch (Exception )
                {
                    Debug.WriteLine("loadNativeFont failed");
                }
            }
            return null;
        }

        public override bool isTrueTypeSupported()
        {
            return true;
        }

        public override object loadTrueTypeFont(java.lang.String fontName, java.lang.String fileName)
        {

            NativeFont nf = new NativeFont(0, 0, 0, new CanvasTextFormat());
            string file = toCSharp(fileName);
            string family = toCSharp(fontName);
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    nf.font.FontFamily = @"res\" + file + "#" + family;
                    nf.font.WordWrapping = CanvasWordWrapping.NoWrap;
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return nf;
        }

        public override object deriveTrueTypeFont(java.lang.Object font, float size, int weight)
        {
            NativeFont fnt = (NativeFont)font;
            NativeFont n = new NativeFont(0, 0, 0, new CanvasTextFormat());
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    n.font.FontFamily = fnt.font.FontFamily;
                    n.font.FontSize = size;
                    if ((weight & 1) != 0) // bold
                    {
                        n.font.FontWeight = FontWeights.Bold;
                    }
                    if ((weight & 2) != 0) // italic
                    {
                        n.font.FontStyle = FontStyle.Italic;
                    }
                    n.font.WordWrapping = CanvasWordWrapping.NoWrap;
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return n;
        }

        public override object getDefaultFont()
        {
            if (defaultFont == null)
            {
                object defaul = createFont(com.codename1.ui.Font._fFACE_1SYSTEM, com.codename1.ui.Font._fSTYLE_1PLAIN, com.codename1.ui.Font._fSIZE_1MEDIUM);
                defaultFont = (NativeFont)defaul;
            }
            return defaultFont;
        }

        public override object createFont(int face, int style, int size)
        {
            NativeFont nf = new NativeFont(face, style, size, new CanvasTextFormat());
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   switch (size)
                   {
                       case 8: //com.codename1.ui.Font._fSIZE_1SMALL:
                           nf.font.FontSize = nf.font.FontSize * 2 / 3;
                           break;
                       case 16: //com.codename1.ui.Font._fSIZE_1LARGE:
                           nf.font.FontSize = nf.font.FontSize * 4 / 3;
                           break;
                   }
                   //Debug.WriteLine("height 1: " + nf.height);
                   if ((style & 2) != 0) // com.codename1.ui.Font._fSTYLE_1ITALIC
                   {
                       nf.font.FontStyle = FontStyle.Italic;
                   }
                   if ((style & 1) != 0) // com.codename1.ui.Font._fSTYLE_1BOLD
                   {
                       nf.font.FontWeight = FontWeights.Bold;
                   }
                   nf.font.WordWrapping = CanvasWordWrapping.NoWrap;
                   //Debug.WriteLine("height 2: " + nf.height);
                   // _fSTYLE_1UNDERLINED = 4;
                   // nf.font.FontFamily = "zzz";
                   are.Set();
               }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return nf;
        }


        public virtual NativeFont f(java.lang.Object fnt)
        {
            object getDefaul = getDefaultFont();
            if (fnt == null) return (NativeFont)getDefaul;
            return (NativeFont)fnt;
        }

        public override bool isScaledImageDrawingSupported()
        {
            return true;
        }


        public override global::System.Object createSoftWeakRef(global::java.lang.Object n1)
        {
            return new SoftRef(n1);
        }

        public override global::System.Object extractHardRef(global::java.lang.Object n1)
        {
            if (n1 != null)
            {
                return ((SoftRef)n1).get();
            }
            return null;
        }

        public override global::System.Object connect(global::java.lang.String n1, bool read, bool write)
        {

            NetworkOperation n = new NetworkOperation();
            string s = toCSharp(n1);
            n.request = (HttpWebRequest)WebRequest.Create(new Uri(s));
            return n;
        }

        public override void setHeader(global::java.lang.Object n1, global::java.lang.String n2, global::java.lang.String n3)
        {
            NetworkOperation n = (NetworkOperation)n1;
            string key = toCSharp(n2);
            string value = toCSharp(n3);
            if (key.ToLower().Equals("accept"))
            {
                n.request.Accept = value;
                return;
            }
            if (key.ToLower().Equals("connection") || key.ToLower().Equals("keepalive") ||
                key.ToLower().Equals("expect") || key.ToLower().Equals("date") || key.ToLower().Equals("host") ||
                key.ToLower().Equals("if-modified-since") || key.ToLower().Equals("range") ||
                key.ToLower().Equals("referer") || key.ToLower().Equals("transfer-encoding") ||
                key.ToLower().Equals("user-agent"))
            {
                return;
            }
            if (key.ToLower().Equals("content-length"))
            {
                //   n.request.ContentLength = Int32.Parse(value);
                return;
            }
            if (key.ToLower().Equals("content-type"))
            {
                if (n.request.Method.ToLower().Equals("get"))
                {
                    // if content type is set on a get request silverlight throws an exception, correct but a
                    // common bug!
                    return;
                }
                n.request.ContentType = value;
                return;
            }
            n.request.Headers[key] = value;
        }

        public override int getContentLength(global::java.lang.Object n1)
        {
            NetworkOperation n = (NetworkOperation)n1;
            return Convert.ToInt32(n.response.ContentLength);
        }

        public override global::System.Object openOutputStream(global::java.lang.Object connection)
        {
            if (connection is java.lang.String)
            {
                StorageFolder store = ApplicationData.Current.LocalFolder;
                Stream s = Task.Run(() => store.OpenStreamForReadAsync(nativePath((java.lang.String)connection))).GetAwaiter().GetResult();
                return new OutputStreamProxy(s);
            }
            NetworkOperation n = (NetworkOperation)connection;
            com.codename1.io.BufferedOutputStream bo = new com.codename1.io.BufferedOutputStream();
            bo.@this(new OutputStreamProxy(n.requestStream));
            return bo;
        }
        public override global::System.Object openOutputStream(global::java.lang.Object connection, int offset)
        {

            if (connection is java.lang.String)
            {
                StorageFolder store = ApplicationData.Current.LocalFolder;
                Stream stream = Task.Run(() => store.OpenStreamForReadAsync(nativePath((java.lang.String)connection))).ConfigureAwait(false).GetAwaiter().GetResult();
                stream.Seek(offset, SeekOrigin.Current);
                return new OutputStreamProxy(stream);
            }
            return null;
        }

        public override global::System.Object openInputStream(global::java.lang.Object connection)
        {
            if (connection is java.lang.String)
            {
                StorageFolder store = ApplicationData.Current.LocalFolder;
                string file = nativePath((java.lang.String)connection);
                Stream stream = Task.Run(() => store.OpenStreamForReadAsync(file)).ConfigureAwait(false).GetAwaiter().GetResult();

                return new InputStreamProxy(stream);
            }
            NetworkOperation n = (NetworkOperation)connection;
            com.codename1.io.BufferedInputStream bo = new com.codename1.io.BufferedInputStream();
            bo.@this(new InputStreamProxy(n.response.GetResponseStream()));
            return bo;
        }
        public override void setPostRequest(global::java.lang.Object n1, bool n2)
        {
            NetworkOperation n = (NetworkOperation)n1;
            if (n2)
            {
                n.request.Method = "POST";
            }
            else
            {
                n.request.Method = "GET";
            }
        }
        public override int getResponseCode(global::java.lang.Object n1)
        {
            NetworkOperation n = (NetworkOperation)n1;
            int i = 0;
            HttpWebResponse res = n.response;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    i = Convert.ToInt32(res.StatusCode);
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
            return i;
        }
        public override global::System.Object getResponseMessage(global::java.lang.Object n1)
        {
            return null;
        }
        public override void vibrate(int n1)
        {
            VibrationDevice vc = VibrationDevice.GetDefault();
            vc.Vibrate(TimeSpan.FromMilliseconds(n1));
        }
        public override global::System.Object getHeaderField(global::java.lang.String n1, global::java.lang.Object n2)
        {
            NetworkOperation n = (NetworkOperation)n2;
            return toJava(n.response.Headers[toCSharp(n1)]);
        }
        public override global::System.Object getHeaderFieldNames(global::java.lang.Object n1)
        {
            NetworkOperation n = (NetworkOperation)n1;
            int i = n.response.Headers.Count;
            java.lang.String[] arr = new java.lang.String[i];
            _nArrayAdapter<global::System.Object> r = new _nArrayAdapter<global::System.Object>(arr);
            string[] keys = n.response.Headers.AllKeys;
            for (int iter = 0; iter < i; iter++)
            {
                arr[iter] = toJava(keys[iter]);
            }
            return r;
        }
        public override global::System.Object getHeaderFields(global::java.lang.String n1, global::java.lang.Object n2)
        {
            NetworkOperation n = (NetworkOperation)n2;
            String s = n.response.Headers[toCSharp(n1)];
            if (s == null)
            {
                return null;
            }
            return new _nArrayAdapter<global::System.Object>(new java.lang.String[] { toJava(s) });
        }
        public override int getCommandBehavior()
        {
            // COMMAND_BEHAVIOR_BUTTON_BAR
            return 4;
        }
        public override void deleteStorageFile(global::java.lang.String name)
        {
            try
            {
                var ss = store.GetFileAsync(toCSharp(name)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                ss.DeleteAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (System.Exception err)
            {
                //ignore file deletion errors 
                err.ToJavaException().printStackTrace();
            }
        }

        public override int getStorageEntrySize(java.lang.String name)
        {
            StorageFolder store = ApplicationData.Current.LocalFolder;
            var s = store.GetFileAsync(toCSharp(name)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult(); ;
            if (s.Name != toCSharp(name))
            {
                return 0;
            }
            Stream st = Task.Run(() => s.OpenStreamForReadAsync()).ConfigureAwait(false).GetAwaiter().GetResult();
            long size = st.Length;
            st.Dispose();
            return Convert.ToInt32(size);
        }
        public override global::System.Object createStorageOutputStream(global::java.lang.String name)
        {
            var file = store.CreateFileAsync(toCSharp(name), CreationCollisionOption.OpenIfExists).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            return new OutputStreamProxy(Task.Run(() => file.OpenStreamForWriteAsync()).ConfigureAwait(false).GetAwaiter().GetResult());
        }

        public override global::System.Object createStorageInputStream(global::java.lang.String name)
        {
            var file = store.CreateFileAsync(toCSharp(name), CreationCollisionOption.OpenIfExists).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            return new InputStreamProxy(Task.Run(() => file.OpenStreamForReadAsync()).ConfigureAwait(false).GetAwaiter().GetResult());
        }
        public override bool storageFileExists(global::java.lang.String name)
        {
            bool fileExists;
            try
            {
                string uri = toCSharp(name);
                if (uri.StartsWith("/"))
                {
                    uri = @"res\" + uri.Substring(1);
                }
                uri.Replace('/', '\\');
                StorageFile file = store.GetFileAsync(uri).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                fileExists = file != null;
            }
            catch (Exception)
            {
                fileExists = false;
            }
            return fileExists;
        }
        private object convertArray(string[] arr)
        {
            java.lang.String[] resp = new java.lang.String[arr.Length];
            for (int iter = 0; iter < resp.Length; iter++)
            {
                resp[iter] = toJava(arr[iter]);
            }
            return new _nArrayAdapter<global::System.Object>(resp);
        }
        public override global::System.Object listStorageEntries()
        {
            IReadOnlyList<StorageFile> file = store.GetFilesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            string[] ss = null;
            for (int i = 0; i < file.Count; i++)
            {
                ss[i] = file.ToString();
            }
            return convertArray(ss);
        }
        public override global::System.Object getAppHomePath()
        {
            return toJava("file:/");
        }
        public override object listFilesystemRoots()
        {
            return new _nArrayAdapter<global::System.Object>(new java.lang.String[] { toJava("file:/") });
        }
        private string nativePath(java.lang.String s)
        {
            string ss = toCSharp(s);
            if (ss.StartsWith("file:/"))
            {
                ss = ss.Substring(6).Replace('/', '\\');
            }
            return ss;
        }
        private string[] prependFile(string[] arr)
        {
            for (int iter = 0; iter < arr.Length; iter++)
            {
                if (!arr[iter].StartsWith("file:/"))
                {
                    arr[iter] = "file:/" + arr[iter];
                }
            }
            return arr;
        }
        public override object listFiles(java.lang.String directory)
        {
            string[] dirnames = null;
            IReadOnlyList<StorageFolder> directoryNames = store.GetFoldersAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

            for (int i = 0; i < directoryNames.Count; i++)
            {
                dirnames[i] = directoryNames.ToString();
            }
            for (int N = dirnames.Length, i = 0; i < N; i++)
            {
                if (!dirnames[i].EndsWith("/"))
                {
                    dirnames[i] = dirnames[i] + "/";
                }
            }
            //string[] filenames = await store.GetFileNames(nativePath(directory) + "\\*.*");
            string[] filenames = null;
            IReadOnlyList<StorageFile> fileNames = store.GetFilesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            for (int i = 0; i < fileNames.Count; i++)
            {
                filenames[i] = fileNames.ToString();
            }
            string[] all = new string[dirnames.Length + filenames.Length];
            dirnames.CopyTo(all, 0);
            filenames.CopyTo(all, dirnames.Length);
            return convertArray(all);
        }
        public override long getRootSizeBytes(java.lang.String root)
        {
            return 0;
        }
        public override long getRootAvailableSpace(java.lang.String root)
        {
            var ss = store.GetBasicPropertiesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            return (long)ss.Size;
        }

        public override void mkdir(java.lang.String directory)
        {
            store.CreateFolderAsync(nativePath(directory)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public override void deleteFile(java.lang.String file)
        {
            try
            {
                var file1 = store.GetFileAsync(toCSharp(file)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                file1.DeleteAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (System.Exception err)
            {
                //ignore file deletion errors 
                err.ToJavaException().printStackTrace();
            }
        }
        public override bool isHidden(java.lang.String n1)
        {
            return false;
        }
        public override void setHidden(java.lang.String n1, bool n2)
        {
        }
        public override long getFileLength(java.lang.String file)
        {
            var f = store.GetFileAsync(toCSharp(file)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            var fsc = Task.Run(() => f.OpenStreamForReadAsync()).ConfigureAwait(false).GetAwaiter().GetResult();
            long l = fsc.Length;
            fsc.Dispose();
            return l;
        }

        public override bool isDirectory(java.lang.String file)
        {
            var ss = store.GetFolderAsync(nativePath(file)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            return ss.Name.Equals(nativePath(file));
        }

        public override bool exists(java.lang.String file)
        {
            CommonFolderQuery commfolder = CommonFolderQuery.DefaultQuery;
            commfolder.Equals(nativePath(file));
            CommonFileQuery commFile = CommonFileQuery.OrderByName;
            commFile.Equals(nativePath(file));
            return store.IsCommonFileQuerySupported(commFile) || store.IsCommonFolderQuerySupported(commfolder);

        }

        public async override void rename(java.lang.String file, java.lang.String newName)
        {
            await store.RenameAsync(nativePath(newName), NameCollisionOption.ReplaceExisting);
        }

        public override char getFileSystemSeparator()
        {
            return '\\';
        }

        public override object getPlatformName()
        {
            return toJava("win");
        }

        public override global::System.Object getLocalizationManager()
        {
            //XMLVM_BEGIN_WRAPPER[com.codename1.impl.SilverlightImplementation: com.codename1.l10n.L10NManager getLocalizationManager()]
            global::org.xmlvm._nElement _r0;
            _r0.i = 0;
            _r0.l = 0;
            _r0.f = 0;
            _r0.d = 0;
            global::System.Object _r0_o = null;
            global::org.xmlvm._nElement _r1;
            _r1.i = 0;
            _r1.l = 0;
            _r1.f = 0;
            _r1.d = 0;
            global::System.Object _r1_o = null;
            // global::org.xmlvm._nExceptionAdapter _ex = null;
            _r1_o = this;
            _r0_o = new global::com.codename1.impl.SilverlightImplementation_2L10NManagerImpl();
            ((global::com.codename1.impl.SilverlightImplementation_2L10NManagerImpl)_r0_o).@this();
            return (global::com.codename1.l10n.L10NManager)_r0_o;
            //XMLVM_END_WRAPPER[com.codename1.impl.SilverlightImplementation: com.codename1.l10n.L10NManager getLocalizationManager()]
        }

        public override object getLocationManager()
        {
           
            if (locationManager == null)
            {
                locationManager = new LocationManager();
            }
            return locationManager;
        }

        private SilverlightImageIO imageIO;
        private SimpleOrientationSensor _sensor;
        private static WindowsAsyncView myView;
        public static Microsoft.Graphics.Canvas.DirectX.DirectXPixelFormat pixelFormat = Microsoft.Graphics.Canvas.DirectX.DirectXPixelFormat.B8G8R8A8UIntNormalized;
        private NativeGraphics globalGraphics;

        public override object getImageIO()
        {
            if (imageIO == null)
            {
                imageIO = new SilverlightImageIO();
            }
            return imageIO;
        }

        public override bool instanceofObjArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<global::System.Object>;
        }

        public override bool instanceofByteArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<sbyte>;
        }

        public override bool instanceofShortArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<short>;
        }

        public override bool instanceofLongArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<long>;
        }

        public override bool instanceofIntArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<int>;
        }

        public override bool instanceofFloatArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<float>;
        }

        public override bool instanceofDoubleArray(global::java.lang.Object n1)
        {
            return n1 is global::org.xmlvm._nArrayAdapter<double>;
        }
    }

    public class NativeGraphics : global::java.lang.Object
    {
        public WindowsGraphics destination;
        private int clipX, clipY, clipW, clipH;
        private Rectangle actualClip;
        public Rectangle clip
        {
            set
            {
                actualClip = value;
                destination.setClip(value);
                clipX = actualClip.getX();
                clipY = actualClip.getY();
                clipW = actualClip.getWidth();
                clipH = actualClip.getHeight();
            }
            get { return actualClip; }
        }
        private NativeFont actualFont;
        public NativeFont font
        {
            set
            {
                actualFont = value;
                destination.setFont(value.font);
            }
            get { return actualFont; }
        }

        public void resetClip()
        {
            Rectangle r = new Rectangle();
            r.@this(0, 0, Convert.ToInt32(SilverlightImplementation.screen.ActualWidth), Convert.ToInt32(SilverlightImplementation.screen.ActualHeight));
            clip = r;
        }

        public int getClipX() { return clipX; }
        public int getClipY() { return clipY; }
        public int getClipW() { return clipW; }
        public int getClipH() { return clipH; }
    }

    public class DrawStringCache
    {
        public string str;
        public int color;
        public NativeFont font;
        public long lastAccess;

        public override bool Equals(object obj)
        {
            DrawStringCache d = (DrawStringCache)obj;
            return str.Equals(d.str) && color == d.color && font == d.font;
        }

        public override int GetHashCode()
        {
            return str.GetHashCode() + color;
        }
    }

    public class CodenameOneImage : java.lang.Object
    {

        public string name;
        private CanvasRenderTarget actualImage;
        public CanvasRenderTarget image
        {
            set
            {

                actualImage = value;
                width = Convert.ToInt32(Math.Ceiling((double)value.SizeInPixels.Width));
                height = Convert.ToInt32(Math.Ceiling((double)value.SizeInPixels.Height));
                graphics.destination = new WindowsGraphics(value.CreateDrawingSession());

            }

            get { return actualImage; }
        }
        private int width = -1;
        private int height = -1;
        public NativeGraphics graphics = new NativeGraphics();

new         public void @this()
        {
            base.@this();
        }

        public void setSize(int w, int h)
        {
            width = Convert.ToInt32(Math.Ceiling((double)w));
            height = Convert.ToInt32(Math.Ceiling((double)h));
        }

        public int getImageWidth()
        {
            return width;
        }

        public int getImageHeight()
        {
            return height;
        }
    }


    public class NativeFont : global::java.lang.Object
    {
        public int face;
        public int style;
        public int size;
        public CanvasTextFormat font = new CanvasTextFormat();
        string fileName;
        private int actualHeight = -1;
        public int height
        {
            get
            {
                if (actualHeight < 0)
                {
                    //CanvasTextLayout fontLayout = new CanvasTextLayout(SilverlightImplementation.screen, "Mg", font, 0.0f, 0.0f);
                    //actualHeight = SilverlightImplementation.screen.ConvertDipsToPixels((float)Math.Ceiling(fontLayout.DrawBounds.Height));
                    //Debug.WriteLine("height (dips): " + fontLayout.DrawBounds.Height);
                    //Debug.WriteLine("height (pixels): " + actualHeight);

                    using (AutoResetEvent are = new AutoResetEvent(false))
                    {
                        SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            TextBlock tb = new TextBlock();
                            tb.FontSize = font.FontSize;
                            tb.Text = "Mg";
                            tb.Measure(new Size(1000000, 1000000));
                            actualHeight = Convert.ToInt32(Math.Ceiling(tb.ActualHeight));
                            //Debug.WriteLine("height (tb): " + tb.ActualHeight);
                            are.Set();
                        }).AsTask().ConfigureAwait(false).GetAwaiter();
                        are.WaitOne();
                    }
                }
                return actualHeight;
            }
            set
            {
                actualHeight = value;
            }
        }
        public bool bold;
        public bool italic;
        int weight;

        public NativeFont(int face, int style, int size, CanvasTextFormat font, String fileName, int height, int weight)
            : this(face, style, size, font)
        {
            this.fileName = fileName;
            this.height = height;
            this.weight = weight;
        }

        public NativeFont(int face, int style, int size, CanvasTextFormat font)
        {
            this.face = face;
            this.style = style;
            this.size = size;
            this.font = font;
        }

        public override bool Equals(object o)
        {
            NativeFont f = (NativeFont)o;
            return f.height == height && f.face == face && f.size == size && f.style == style;
        }

        public override int GetHashCode()
        {
            return face | style | size;
        }

        internal int getStringWidth(string str)
        {
            CanvasTextLayout fontLayout = new CanvasTextLayout(SilverlightImplementation.screen, str, font, 0.0f, 0.0f);
            return Convert.ToInt32(Math.Ceiling(fontLayout.DrawBounds.Width));
        }
    }

    class WaitForEdit : java.lang.Object, java.lang.Runnable
    {
        public virtual void run()
        {
            while (SilverlightImplementation.instance.currentlyEditing != null)
            {
                Task.Run(() => global::System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(1))).ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }
    }

    class EditString : java.lang.Object, java.lang.Runnable
    {
        private global::com.codename1.ui.Component n1;
        private int n2;
        private int n3;
        private global::java.lang.String n4;
        private int n5;

        public EditString(global::com.codename1.ui.Component n1, int n2, int n3, global::java.lang.String n4, int n5)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.n4 = n4;
            this.n5 = n5;
        }

        public virtual void run()
        {
            com.codename1.ui.Display d = (com.codename1.ui.Display)com.codename1.ui.Display.getInstance();
            d.editString(n1, n2, n3, n4, n5);
            ((com.codename1.ui.Form)n1.getComponentForm()).repaint();
        }
    }

    class WaitForNativeEdit : java.lang.Object, java.lang.Runnable
    {
        public virtual void run()
        {
            while (SilverlightImplementation.textInputInstance != null)
            {
                Task.Run(() => global::System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(1))).ConfigureAwait(false).GetAwaiter().GetResult();

            }
        }
    }

    public class SoftRef : java.lang.Object
    {
        global::System.WeakReference w;
        //java.lang.Object o;

        public SoftRef(java.lang.Object obj)
        {
            w = new WeakReference(obj);
            //o = obj;
        }

        public java.lang.Object get()
        {
            java.lang.Object o = (java.lang.Object)w.Target;
            return o;
            //return o;
        }
    }

    class NetworkOperation : java.lang.Object
    {
        private bool responseCompleted;
        private bool postCompleted;
        public HttpWebRequest request;
        ///public HttpClientHandler handler;

        public Stream requestStream
        {
            get
            {
                if (postData == null)
                {
                    request.BeginGetRequestStream(PostCallback, request);
                    while (!postCompleted)
                    {
                        Task.Run(() => System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(5))).ConfigureAwait(false).GetAwaiter().GetResult();
                    }
                }
                return postData;
            }
        }

        private Stream postData;

        public HttpWebResponse response
        {
            get
            {
                if (resp == null)
                {

                    if (postData != null)
                    {
                        using (AutoResetEvent are = new AutoResetEvent(false))
                        {
                            try
                            {
                                postData.Dispose();
                            }
                            catch (Exception) { }
                            are.Set();

                            are.WaitOne();
                        }
                    }
                    request.BeginGetResponse(ResponseCallback, request);
                    while (!responseCompleted)
                    {
                        Task.Run(() => Task.Delay(TimeSpan.FromMilliseconds(5))).ConfigureAwait(false).GetAwaiter().GetResult();
                    }
                    if (resp == null)
                    {
                        global::java.io.IOException io = new global::java.io.IOException();
                        if (error != null)
                        {
                            io.@this(SilverlightImplementation.toJava(error.Message));
                        }
                        else
                        {
                            io.@this(SilverlightImplementation.toJava("Null response"));
                        }
                        throw new global::org.xmlvm._nExceptionAdapter(io);
                    }
                }
                return resp;
            }
        }
        private HttpWebResponse resp;
        private WebException error;

        private void ResponseCallback(IAsyncResult asyncResult)
        {
            try
            {
                resp = (HttpWebResponse)request.EndGetResponse(asyncResult);
            }
            catch (WebException we)
            {
                error = we;
                if (we.Response != null)
                {
                    resp = (HttpWebResponse)we.Response;
                }
            }
            responseCompleted = true;
        }

        private void PostCallback(IAsyncResult asyncResult)
        {
            postData = request.EndGetRequestStream(asyncResult);
            postCompleted = true;
        }
    }

    class InputStreamProxy : java.io.InputStream
    {
        private Stream internalStream;
        private long markedPosition = 0;

        public InputStreamProxy(Stream internalStream)
        {
            base.@this();
            this.internalStream = internalStream;
        }

        public override int available()
        {
            return 0;
        }

        public override void close()
        {
            internalStream.Dispose();
        }
        public override bool markSupported()
        {
            return internalStream.CanSeek;
        }
        public override void mark(int readlimit)
        {
            markedPosition = internalStream.Position;
        }

        public override int read()
        {
            return internalStream.ReadByte();
        }

        public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1)
        {
            return read(n1, 0, n1.Length);

        }

        public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3)
        {
            sbyte[] sb = n1.getCSharpArray();
            int v = internalStream.Read((byte[])(Array)sb, n2, n3);
            if (v <= 0)
            {
                return -1;

            }
            return v;
        }

        public override void reset()
        {
            internalStream.Seek(markedPosition, SeekOrigin.Begin);
        }

        public override long skip(long n)
        {
            internalStream.Seek(n, SeekOrigin.Current);
            return n;
        }
    }

    class OutputStreamProxy : java.io.OutputStream
    {
        private Stream internalStream;
        public OutputStreamProxy(Stream internalStream)
        {
            base.@this();
            this.internalStream = internalStream;
        }

        public override void close()
        {
            if (internalStream == null)
            {
                return;
            }
            try
            {
                internalStream.Dispose();
            }
            catch (Exception)
            {
                internalStream = null;
            }
        }

        public override void flush()
        {
            if (internalStream == null)
            {
                return;
            }
            try
            {
                internalStream.Flush();
            }
            catch (Exception)
            {
                internalStream = null;
            }
        }

        public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1)
        {
            write(n1, 0, n1.Length);
        }

        public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3)
        {
            internalStream.Write(SilverlightImplementation.toByteArray(n1.getCSharpArray()), n2, n3);
        }

        public override void write(int n1)
        {
            internalStream.WriteByte((byte)n1);
        }

    }

    public class StringFontPair
    {
        public string str;
        public NativeFont font;

        public StringFontPair(string str, NativeFont font)
        {
            this.str = str;
            this.font = font;
        }

        public override bool Equals(Object o)
        {
            StringFontPair sp = (StringFontPair)o;
            return str.Equals(sp.str) && font.Equals(sp.font);
        }

        public override int GetHashCode()
        {
            return str.GetHashCode();
        }
    }

    public class SilverlightPeer : com.codename1.ui.PeerComponent
    {
        public FrameworkElement element;
        private bool lightweightMode;
        public WebView webview;
        private object peerImage;
        public SilverlightPeer(FrameworkElement element)
        {
            this.element = element;
            @this(null);
        }

        public override bool isFocusable()
        {
            return true;
        }

        public override void setFocus(bool n1)
        {
        }

        public override global::System.Object calcPreferredSize()
        {
            int w = 0;
            int h = 0;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    element.Measure(new Size(1000000, 1000000));
                    w = Convert.ToInt32(element.DesiredSize.Width * SilverlightImplementation.scaleFactor);
                    h = Convert.ToInt32(element.DesiredSize.Height * SilverlightImplementation.scaleFactor);
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            com.codename1.ui.geom.Dimension d = new com.codename1.ui.geom.Dimension();
            d.@this(Math.Max(2, w), Math.Max(2, h));
            return d;
        }

        public override void onPositionSizeChange()
        {
            int width = getWidth();
            int height = getHeight();
            int x = getAbsoluteX();
            int y = getAbsoluteY();
            if (width > 0 && height > 0)
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                  {
                      if (SilverlightImplementation.cl.Children.Contains(element))
                      {
                          Canvas.SetLeft(element, x / SilverlightImplementation.scaleFactor);
                          Canvas.SetTop(element, y / SilverlightImplementation.scaleFactor);
                          element.Width = width / SilverlightImplementation.scaleFactor;
                          element.Height = height / SilverlightImplementation.scaleFactor;
                      }
                  }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }

        public override void initComponent()
        {
            int width = getWidth();
            int height = getHeight();
            int x = getAbsoluteX();
            int y = getAbsoluteY();
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (!SilverlightImplementation.cl.Children.Contains(element))
                {
                    SilverlightImplementation.cl.Children.Add(element);
                }
                Canvas.SetLeft(element, x / SilverlightImplementation.scaleFactor);
                Canvas.SetTop(element, y / SilverlightImplementation.scaleFactor);
                element.Width = width / SilverlightImplementation.scaleFactor;
                element.Height = height / SilverlightImplementation.scaleFactor;
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public override void deinitialize()
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (SilverlightImplementation.cl.Children.Contains(element))
                {
                    // peerImage = generatePeerImage();
                    SilverlightImplementation.cl.Children.Remove(element);
                }
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }
        public override void setLightweightMode(bool n1)
        {
            if (lightweightMode != n1)
            {
                lightweightMode = n1;
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (n1)
                    {
                        element.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        element.Visibility = Visibility.Visible;
                    }
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                ((com.codename1.ui.Form)getComponentForm()).repaint();
            }
        }

        private async void loadWebViewToStream(WebView webview, IRandomAccessStream stream)
        {

            await Task.Delay(TimeSpan.FromTicks(2).Duration());
            //await Task.Delay(TimeSpan.FromMilliseconds(20));
            await webview.CapturePreviewToStreamAsync(stream);
            await stream.FlushAsync();
            stream.Seek(0);

        }
        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public override object generatePeerImage()
        {
            int width = getWidth();
            int height = getHeight();
            if (width <= 0 || height <= 0)
            {
                width = getPreferredW();
                height = getPreferredH();
            }
            if (element.Parent == null)
            {
                if (peerImage != null)
                {
                    return peerImage;
                }
                return com.codename1.ui.Image.createImage(width, height);
            }
            CodenameOneImage img = new CodenameOneImage();
            img.@this();
            img.name = "PeerImage: " + element.ToString();
            IRandomAccessStream stream = new InMemoryRandomAccessStream();
            CanvasBitmap cb = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
              {
                  if (element is WebView)
                  {
                      try
                      {
                          Task.Delay(TimeSpan.FromTicks(4).Duration()).ConfigureAwait(false).GetAwaiter().GetResult();
                          ((WebView)element).CapturePreviewToStreamAsync(stream).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                          stream.FlushAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                          stream.Seek(0);
                          Task.Delay(TimeSpan.FromMilliseconds(10)).ConfigureAwait(false).GetAwaiter().GetResult();
                          cb = CanvasBitmap.LoadAsync(SilverlightImplementation.screen, stream).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                      }
                      catch (Exception)
                      {

                          throw;
                      }
                      // https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.media.imaging.rendertargetbitmap.aspx
                      // For Windows Phone Store apps: the contents of a WebView control can't be rendered into a RenderTargetBitmap

                      //  loadWebViewToStream(((WebView)element), stream);
                      //byte[] buf = ReadFully(stream.AsStreamForRead());      

                      //cb = CanvasBitmap.CreateFromBytes(SilverlightImplementation.screen, buf, width, height, SilverlightImplementation.pixelFormat, SilverlightImplementation.screen.Dpi);

                  }
                  else
                  {
                      RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
                      renderTargetBitmap.RenderAsync(element).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                      byte[] buf = renderTargetBitmap.GetPixelsAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult().ToArray();
                      cb = CanvasBitmap.CreateFromBytes(SilverlightImplementation.screen, buf, width, height, SilverlightImplementation.pixelFormat, SilverlightImplementation.screen.Dpi);
                  }
                  img.image = new CanvasRenderTarget(SilverlightImplementation.screen, cb.ConvertPixelsToDips(width), cb.ConvertPixelsToDips(height), cb.Dpi);
                  img.graphics.destination.drawImage(cb, 0, 0);
                  img.graphics.destination.dispose();
                  are.Set();
              }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
            return com.codename1.ui.Image.createImage(img);

            // return com.codename1.ui.Image.createImage(width, height);
        }

        public override bool shouldRenderPeerImage()
        {
            return lightweightMode || !isInitialized();

        }
    }

    public class CN1Media : com.codename1.media.Media
    {
        private MediaElement elem;
        private SilverlightPeer peer;
        private bool video;
        private java.lang.Runnable onComplete;
        private Canvas cl;

        public CN1Media(string uri, bool video, java.lang.Runnable onComplete, Canvas cl)
        {
            this.cl = cl;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    elem = new MediaElement();
                    cl.Children.Add(elem);
                    elem.MediaOpened += elem_MediaOpened;
                    elem.Source = new Uri(uri, UriKind.RelativeOrAbsolute);
                    this.video = video;
                    this.onComplete = onComplete;
                    elem.MediaEnded += elem_MediaEnded;
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
        }

        void elem_MediaOpened(object sender, RoutedEventArgs e)
        {
            //ready = true;
        }

        public CN1Media(Stream s, string mime, java.lang.Runnable onComplete, Canvas cl)
        {
            this.cl = cl;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    elem = new MediaElement();
                    cl.Children.Add(elem);
                    elem.MediaOpened += elem_MediaOpened;
                    elem.SetSource(s.AsRandomAccessStream(), "");
                    video = mime.StartsWith("video");
                    this.onComplete = onComplete;
                    elem.MediaEnded += elem_MediaEnded;
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
        }

        void elem_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (onComplete != null)
            {
                com.codename1.ui.Display disp = (com.codename1.ui.Display)com.codename1.ui.Display.getInstance();
                disp.callSerially(onComplete);
            }
        }

        public virtual void prepare()
        {
        }

        public virtual void play()
        {
            /*while (!ready)
            {
                Thread.Sleep(10);
            }*/
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                elem.Play();
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public virtual void pause()
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                elem.Pause();
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public virtual void cleanup()
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (elem != null)
                {
                    cl.Children.Remove(elem);
                    elem = null;
                }
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public virtual int getTime()
        {
            int v = 0;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    v = Convert.ToInt32(elem.Position.TotalMilliseconds);
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
            return v;
        }

        public virtual void setTime(int n1)
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                elem.Position = TimeSpan.FromMilliseconds(n1);
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public virtual int getDuration()
        {
            int v = 0;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    v = Convert.ToInt32(elem.NaturalDuration.TimeSpan.TotalMilliseconds);
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return v;
        }

        public virtual void setVolume(int n1)
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                elem.Volume = ((double)n1) / 100.0;
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public virtual int getVolume()
        {
            int v = 0;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {

                    v = Convert.ToInt32(elem.Volume * 100.0);
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
            return v;
        }

        public virtual bool isPlaying()
        {
            bool b = false;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    b = elem.CurrentState == MediaElementState.Playing || elem.CurrentState == MediaElementState.Buffering;
                    are.Set();
                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                are.WaitOne();
            }
            return b;
        }
        public virtual global::System.Object getVideoComponent()
        {
            if (peer == null)
            {
                peer = new SilverlightPeer(elem);
            }
            return peer;
        }

        public virtual bool isVideo()
        {
            return video;
        }

        public virtual bool isFullScreen()
        {
            return false;
        }

        public virtual void setFullScreen(bool n1)
        {
        }

        public virtual void setNativePlayerMode(bool n1)
        {
        }

        public virtual bool isNativePlayerMode()
        {
            return false;
        }

        public virtual void setVariable(java.lang.String str, java.lang.Object obj)
        {
        }

        public virtual global::System.Object getVariable(java.lang.String str)
        {
            return null;
        }
    }

    public class LocationManager : com.codename1.location.LocationManager
    {

        private Geolocator watcher;
        private Geoposition lastPosition;

        public LocationManager()
        {
            base.@this();
        }

        public override void bindListener()
        {

            if (watcher == null)
            {
                watcher = new Geolocator();
                this.watcher.DesiredAccuracy = PositionAccuracy.High;
                //watcher.DesiredAccuracyInMeters = 100;
                this.watcher.ReportInterval = (uint)TimeSpan.FromSeconds(10).TotalMilliseconds;
            }

            this.watcher.StatusChanged += new TypedEventHandler<Geolocator, StatusChangedEventArgs>(watcher_StatusChanged);
            this.watcher.PositionChanged += new TypedEventHandler<Geolocator, PositionChangedEventArgs>(watcher_PositionChanged);

        }

        void watcher_StatusChanged(Geolocator sender, StatusChangedEventArgs eventArgs)
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                switch (eventArgs.Status)
                {
                    case PositionStatus.Disabled:
                        setStatus(_fOUT_1OF_1SERVICE);
                        break;
                    case PositionStatus.Initializing:
                    case PositionStatus.NoData:
                        setStatus(_fTEMPORARILY_1UNAVAILABLE);
                        break;
                    case PositionStatus.Ready:
                        setStatus(_fAVAILABLE);
                        break;
                }
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        void watcher_PositionChanged(Geolocator sender, PositionChangedEventArgs e)
        {

            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
        {
            lastPosition = watcher.GetGeopositionAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            if (getLocationListener() != null && lastPosition.Coordinate.AltitudeAccuracy.HasValue)
            {
                ((com.codename1.location.LocationListener)getLocationListener()).locationUpdated(convert(lastPosition));
            }
        }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }
        public override void clearListener()
        {
            if (watcher != null)
            {
                watcher.StatusChanged -= new TypedEventHandler<Geolocator, StatusChangedEventArgs>(watcher_StatusChanged);
                watcher.PositionChanged -= new TypedEventHandler<Geolocator, PositionChangedEventArgs>(watcher_PositionChanged);
                //  watcher.Stop();
            }
        }

        public override object getCurrentLocation()
        {
            if (lastPosition != null)
            {
                return convert(lastPosition);
            }
            return null;
        }

        public override object getLastKnownLocation()
        {
            if (lastPosition != null)
            {
                return convert(lastPosition);
            }
            return null;
        }

        private com.codename1.location.Location convert(Geoposition position)
        {
            com.codename1.location.Location location = new com.codename1.location.Location();
            location.@this();
            location.setTimeStamp(position.Coordinate.Timestamp.UtcTicks / 10000);
            location.setLatitude(position.Coordinate.Point.Position.Latitude);
            location.setLongitude(position.Coordinate.Point.Position.Longitude);
            location.setAltitude((float)position.Coordinate.Point.Position.Altitude);
            location.setDirection((float)position.Coordinate.Heading);
            location.setVelocity((float)position.Coordinate.Speed);
            location.setAccuracy((float)position.Coordinate.AltitudeAccuracy);
            location.setStatus(getStatus());
            //Debug.WriteLine("\nTimeStamp(): " + location.getTimeStamp() + "\nLatitude(): " + location.getLatitude() + "\nLongitude(): " + location.getLongitude() + "\nAltitude(): " + location.getAltitude() + "\nDirection()): " + location.getDirection() + "\nVelocity(): " + location.getVelocity() + "\nAccuracy(): " + location.getAccuracy() + "\nStatus(): " + location.getStatus());
            return location;
        }
    }

    class SilverlightImageIO : com.codename1.ui.util.ImageIO
    {
        public SilverlightImageIO()
        {
            @this();
        }

        public override bool isFormatSupported(java.lang.String n1)
        {
            return com.codename1.ui.util.ImageIO._fFORMAT_1JPEG.equals(n1) || com.codename1.ui.util.ImageIO._fFORMAT_1PNG.equals(n1);
        }

        public override void save(java.io.InputStream image, java.io.OutputStream response, java.lang.String format, int width, int height, float quality)
        {
            CanvasBitmapFileFormat fileFormat = CanvasBitmapFileFormat.Png;
            if (format.equals(_fFORMAT_1JPEG))
            {
                fileFormat = CanvasBitmapFileFormat.Jpeg;
            }
            CodenameOneImage img = (CodenameOneImage)SilverlightImplementation.instance.createImage(image);
            CodenameOneImage scaledImage = (CodenameOneImage)SilverlightImplementation.instance.scale(img, width, height);
            InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream();
            scaledImage.image.SaveAsync(ms, fileFormat, quality).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            ms.Seek(0);
            byte[] buf = new byte[ms.Size];
            var dr = new Windows.Storage.Streams.DataReader(ms);
            dr.LoadAsync((uint)ms.Size).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            dr.ReadBytes(buf);
            response.write(new _nArrayAdapter<sbyte>(SilverlightImplementation.toSByteArray(buf)));
        }

        public override void saveImage(ui.Image image, java.io.OutputStream response, java.lang.String format, float quality)
        {
            CanvasBitmapFileFormat fileFormat = CanvasBitmapFileFormat.Png;
            if (format.equals(_fFORMAT_1JPEG))
            {
                fileFormat = CanvasBitmapFileFormat.Jpeg;
            }
            CodenameOneImage img = (CodenameOneImage)image.getImage();
            CanvasBitmap cb = img.image;
            InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream();
            cb.SaveAsync(ms, fileFormat, quality).AsTask().ConfigureAwait(false).GetAwaiter().GetResult(); ;
            ms.Seek(0);
            byte[] buf = new byte[ms.Size];
            var dr = new Windows.Storage.Streams.DataReader(ms);
            dr.LoadAsync((uint)ms.Size).AsTask().ConfigureAwait(false).GetAwaiter().GetResult(); ;
            dr.ReadBytes(buf);
            response.write(new _nArrayAdapter<sbyte>(SilverlightImplementation.toSByteArray(buf)));
        }

    }
} // end of namespace: com.codename1.impl
