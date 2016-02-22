
using org.xmlvm;
using System.IO;
using System.Linq;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Net;
using Windows.Devices.Geolocation;
using System.Diagnostics;
using Microsoft.Graphics.Canvas;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml.Input;
using Windows.Foundation;
using Windows.Storage;
using Windows.Devices.Sensors;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.Phone.Devices.Notification;
using Windows.Media.Capture;
using Windows.Storage.Pickers;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.Graphics.Canvas.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using com.codename1.ui.animations;
using com.codename1.ui;
using com.codename1.ui.geom;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Graphics.Display;
using Windows.UI.Text;
using com.codename1.payment;
using System.Collections.Concurrent;
using System.Numerics;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using com.codename1.ui.events;
using System.Collections;
using Windows.Data.Xml.Dom;


namespace com.codename1.impl
{
    public class SilverlightImplementation : global::com.codename1.impl.CodenameOneImplementation, com.codename1.impl.IFileOpenPickerContinuable
    {
        private LocationManager locationManager;
        private static Object PAINT_LOCK = new Object();
        public static SilverlightImplementation instance;
        public static Canvas cl;
        private int displayWidth = -1, displayHeight = -1;
        private CanvasTextFormat defaulFontCanvas;
        private NativeFont defaultFont;
        public com.codename1.ui.TextArea currentlyEditing;
        public static Control textInputInstance;
        public static Page app;
        public static CanvasControl screen;
        public static double scaleFactor = 1;
        public static CoreDispatcher dispatcher;
        public static StorageFolder iDefaultStore;
        private static CoreApplicationView view;
        public FileOpenPickerContinuationEventArgs FilePickerContinuationArgs { get; set; }
        public static Dictionary<string, string> iCN1Settings; // = new Dictionary<string, string>();

        public static void setCanvas(Page page, Canvas LayoutRoot)
        {
            iCN1Settings = loadSettings("/install:/CN1WindowsPort.xml"); // ms-appx:///CN1WindowsPort.xml");
            view = CoreApplication.GetCurrentView();
            var ss = getDictValue(iCN1Settings, "DefaultStorageFolder", "Cache:");
            iDefaultStore = getStore(ss); // storeApplicationData.Current.CacheFolder; // Faster, avoid cloud backup. See https://www.suchan.cz/2014/07/file-io-best-practices-in-windows-and-phone-apps-part-1-available-apis-and-file-exists-checking/
            dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            cl = LayoutRoot;
            app = page;
            scaleFactor = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            rawDpiy = DisplayInformation.GetForCurrentView().RawDpiY;
            rawDpix = DisplayInformation.GetForCurrentView().RawDpiX;
            screen = new CanvasControl();
            screen.Width = cl.ActualWidth * scaleFactor;
            screen.Height = cl.ActualHeight * scaleFactor;
            cl.Children.Add(screen);  
            screen.ClearColor = Windows.UI.Colors.Transparent; // Maybe white ?
            Canvas.SetLeft(screen, 0);
            Canvas.SetTop(screen, 0);
            myView = new WindowsAsyncView(screen);
        }

        private static string getDictValue(Dictionary<string, string> aSettings, string aKey, string aDefaultValue)
        {
            if (aSettings.Keys.Contains(aKey))
                return aSettings[aKey];
            else
                return aDefaultValue;
        }

        private static Dictionary<string, string> loadSettings(string aUrl)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            XmlDocument doc = null; // = new XmlDocument();

            try
            {
                StorageFile file = getFile(aUrl);
                if (file != null) doc = XmlDocument.LoadFromFileAsync(file).AsTask().GetAwaiter().GetResult();
            }
            catch (System.Exception ) { }
            if (doc == null)
                return settings;
            XmlNodeList elemList = doc.GetElementsByTagName("add");
            foreach (var e in elemList)
            {
                var atr = e.Attributes;
                string key = null;
                string value = null;
                foreach (var a in atr)
                {
                    var name = a.NodeName;
                    if (name.Equals("key"))
                        key = (string)a.NodeValue;
                    if (name.Equals("value"))
                        value = (string)a.NodeValue;
                    if (value != null && key != null)
                    {
                        settings.Add(key, value);
                        break;
                    }
                }
            }
            return settings;
        }

        private void page_BackKeyPress(object sender, BackPressedEventArgs e)
        {
            keyPressed(getBackKeyCode());
            keyReleased(getBackKeyCode());
            e.Handled = true;
        }

        public void @this()
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
                string uri = toCSharp(n2);
                if (uri.StartsWith("/"))
                {
                    uri = @"res\" + uri.Substring(1);
                }
                uri = uri.Replace('/', '\\');
                StorageFolder installFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = installFolder.GetFileAsync(uri).AsTask().GetAwaiter().GetResult();
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
                System.Buffer.BlockCopy(byteArray, 0, sbyteArray, 0, byteArray.Length);
            }
            return sbyteArray;
        }

        public static java.lang.String toJava(System.String str)
        {
            if (str == null) return null;
            global::org.xmlvm._nArrayAdapter<char> n = new global::org.xmlvm._nArrayAdapter<char>(str.ToCharArray());
            java.lang.String s = new java.lang.String();
            s.@this(n);
            return s;
        }

        public static java.lang.String toJava(char str)
        {
            if (str.ToString() == null)
            {
                return null;
            }
            global::org.xmlvm._nArrayAdapter<char> n = new global::org.xmlvm._nArrayAdapter<char>(str.ToString().ToCharArray());
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
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
          {
              HardwareButtons.BackPressed += page_BackKeyPress;
              cl.ManipulationMode = ManipulationModes.All;
              screen.ManipulationMode = ManipulationModes.All;
              screen.PointerPressed += new PointerEventHandler(LayoutRoot_PointerPressed);
              screen.PointerReleased += new PointerEventHandler(LayoutRoot_PointerReleased);
              screen.PointerMoved += new PointerEventHandler(LayoutRoot_PointerMoved);
          }).AsTask().GetAwaiter();
            ((com.codename1.ui.Display)com.codename1.ui.Display.getInstance()).getDragSpeed(true);
            _sensor = SimpleOrientationSensor.GetDefault();
            _sensor.OrientationChanged += new TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs>(app_OrientationChanged);
            ((com.codename1.ui.Display)com.codename1.ui.Display.getInstance()).setTransitionYield(0);
            setDragStartPercentage(3);
        }

        async void app_OrientationChanged(object sender, SimpleOrientationSensorOrientationChangedEventArgs e)
        {
            displayHeight = -1;
            displayWidth = -1;
            e.Timestamp.Add(new TimeSpan(1));
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                screen.Height = displayHeight = Convert.ToInt32(cl.ActualHeight * scaleFactor);
                screen.Width = displayWidth = Convert.ToInt32(cl.ActualWidth * scaleFactor);
                sizeChanged(displayWidth, displayHeight);
                Form f = (Form)getCurrentForm();
                if (f != null)
                {
                    base.repaint(f);
                }
            });
        }
      
        public override bool canForceOrientation()
        {
            return true;
        }
 
        public override global::System.Object getProperty(global::java.lang.String n1, global::java.lang.String n2)
        {
            string p = toCSharp(n1).ToLower();

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
        /// <summary>
        ///  not ideal but I couldn't find any other way...
        ///  Application.Current.Exit(); // TODO - suspending handler
        ///  if back command is not defined the minimizeApplication is called so better is to do nothing
        /// </summary>
        /// <returns></returns>
        public override bool minimizeApplication()
        {
            return true;
        }

        public override void exitApplication()
        {
            Application.Current.Exit();
        }

        public override global::System.Object createMedia(global::java.io.InputStream n1, global::java.lang.String n2, global::java.lang.Runnable n3)
        {
            object ss = createStorageOutputStream(toJava("CN1TempVideodu73aFljhuiw3yrindo87.mp4"));
            java.io.OutputStream os = (java.io.OutputStream)ss;
            com.codename1.io.Util.copy(n1, os);
            StorageFile storageTask = getFile("CN1TempVideodu73aFljhuiw3yrindo87.mp4");
            StorageFile file = storageTask;
            Task<Stream> streamTask = file.OpenStreamForReadAsync();
            Stream s = streamTask.Result;
            return new CN1Media(s, toCSharp(n2), n3, cl);
        }

        public override void lockOrientation(bool portrait)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (portrait)
                {
                    DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;
                }
                else
                {
                    DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape;
                }

            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public override void unlockOrientation()
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                DisplayInformation.AutoRotationPreferences = DisplayOrientations.None;
                screen.UseLayoutRounding = true;
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

        public override bool isMultiTouch()
        {
            return true;
        }

        private void LayoutRoot_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            var pointerId = e.Pointer;
            point = e.GetCurrentPoint(cl).Position;
            var BB = e.GetIntermediatePoints(cl);
            if (pointerId.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Touch)
            {
                Windows.UI.Input.PointerPoint ptrPt = e.GetCurrentPoint(screen);
                if (ptrPt.Properties.IsLeftButtonPressed)
                {
                    pointerDragged(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor));
                }
                if (ptrPt.Properties.IsMiddleButtonPressed)
                {
                    pointerDragged(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor));
                }
                if (ptrPt.Properties.IsRightButtonPressed)
                {
                    pointerDragged(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor));
                }
            }
            e.Handled = true;
        }

        private void LayoutRoot_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            point = e.GetCurrentPoint(cl).Position;
            if (instance.currentlyEditing != null)
            {
                com.codename1.ui.Form f = (com.codename1.ui.Form)instance.currentlyEditing.getComponentForm();
                if (f.getComponentAt(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor)) == instance.currentlyEditing)
                {
                    return;
                }
            }
            pointerPressed(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor));
            screen.CapturePointer(e.Pointer);
            e.Handled = true;
        }

        private void LayoutRoot_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            point = e.GetCurrentPoint(cl).Position;
            if (instance.currentlyEditing != null)
            {
                com.codename1.ui.Form f = (com.codename1.ui.Form)instance.currentlyEditing.getComponentForm();
                if (f.getComponentAt(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor)) != instance.currentlyEditing)
                {
                    commitEditing();
                }
            }
            pointerReleased(Convert.ToInt32(point.X * scaleFactor), Convert.ToInt32(point.Y * scaleFactor));
            e.Handled = true;
            return;
        }

        public override int getDragAutoActivationThreshold()
        {
            return 1000000;
        }

        public override int getDisplayWidth()
        {
            if (displayWidth < 0)
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    displayWidth = Convert.ToInt32(cl.ActualWidth * scaleFactor);

                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
            return displayWidth;
        }

        public override int getDisplayHeight()
        {
            if (displayHeight < 0)
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    displayHeight = Convert.ToInt32(cl.ActualHeight * scaleFactor);

                }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

            }
            return displayHeight;
        }

        public override int getActualDisplayHeight()
        {
            return getDisplayHeight();
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
                   NativeFont font = f((java.lang.Object)fnt.getNativeFont());
                   // workaround forsome weird unspecified margin that appears around the text box
                   Canvas.SetTop(textInputInstance, (currentlyEditing.getAbsoluteY() / scaleFactor));
                   Canvas.SetLeft(textInputInstance, (currentlyEditing.getAbsoluteX() / scaleFactor));
                   textInputInstance.Height = (currentlyEditing.getHeight() / scaleFactor);
                   textInputInstance.Width = (currentlyEditing.getWidth() / scaleFactor);
                   textInputInstance.BorderThickness = new Thickness();
                   textInputInstance.FontSize = (font.font.FontSize / scaleFactor);
                   int h = Convert.ToInt32((textInputInstance.Height - textInputInstance.FontSize) / 3);
                   textInputInstance.Margin = new Thickness();
                   textInputInstance.Padding = new Thickness(10, h, 0, 0);
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
                   //wait for textChangedEvent
                   Task.Run(() => global::System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(100))).ConfigureAwait(false).GetAwaiter().GetResult();
                   textInputInstance = null;
                   // cl.Focus;
               }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
            lockEditing = false;
        }

        void textChangedEvent(object sender, RoutedEventArgs e)
        {
            if (textInputInstance == null)
            {
                System.Diagnostics.Debug.WriteLine("[textChangeEvent] textInput is null. Shoud not happen!!");
                return;
            }
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

        public override bool hasPendingPaints()
        {
            //if the view is not visible make sure the edt won't wait.
            return base.hasPendingPaints();
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

        public override void setCurrentForm(Form n1)
        {
            if (getCurrentForm() == null)
            {
                flushGraphics();
            }
            base.setCurrentForm(n1);
        }

        public override void flushGraphics(int x, int y, int width, int height)
        {
            if (width <= 0 || height <= 0) return;
            Rectangle rect = new Rectangle();
            rect.@this(x, y, width, height);
            myView.flushGraphics(rect);
        }

        public override void flushGraphics()
        {
            myView.flushGraphics();
        }

        public override void systemOut(global::java.lang.String n1)
        {
            System.Diagnostics.Debug.WriteLine(toCSharp(n1));
        }

        public override bool isOpaque(ui.Image n1, java.lang.Object n2)
        {
            return ((CodenameOneImage)n1.getImage()).opaque;
        }

        public override void getRGB(java.lang.Object img, _nArrayAdapter<int> arr, int offset, int x, int y, int w, int h)
        {
            CodenameOneImage cn = (CodenameOneImage)img;
            byte[] buffer = cn.image.GetPixelBytes(x, y, w, h);
            System.Buffer.BlockCopy(buffer, 0, arr.getCSharpArray(), 0, buffer.Length);
        }

        public override void setImageName(global::java.lang.Object n1, global::java.lang.String n2)
        {
            if (n2 != null)
            {
                ((CodenameOneImage)n1).name = toCSharp(n2);
            }
        }

        public override void clipRect(java.lang.Object graphics, Rectangle rect)
        {
            base.clipRect(graphics, rect);
        }

        public override object rotate(java.lang.Object img, int degrees)
        {
            CodenameOneImage cn = (CodenameOneImage)img;

            CanvasRenderTarget cr = new CanvasRenderTarget(screen, (float)cn.image.Size.Width, (float)cn.image.Size.Height, cn.image.Dpi);
            using (var ds = cr.CreateDrawingSession())
            {
                float angle = (float)Math.PI * degrees / 180;
                ds.Transform = Matrix3x2.CreateRotation(angle, new Vector2(cr.SizeInPixels.Width / 2, cr.SizeInPixels.Height / 2));
                ds.DrawImage(cn.image);
                ds.Dispose();
            }
            CodenameOneImage ci = new CodenameOneImage();
            ci.@this();
            ci.image = cr;
            return ci;
        }

        public override bool cacheLinearGradients()
        {
            return false;
        }

        public override bool cacheRadialGradients()
        {
            return false;
        }

        public override void fillLinearGradient(java.lang.Object graphics, int startColor, int endColor, int x, int y, int width, int height, bool horizontal)
        {
            ((NativeGraphics)graphics).destination.fillLinearGradient(startColor, endColor, x, y, width, height, horizontal);
        }

        public override void fillRadialGradient(java.lang.Object graphics, int startColor, int endColor, int x, int y, int width, int height)
        {
            ((NativeGraphics)graphics).destination.fillRadialGradient(endColor, startColor, x, y, width, height); // win2d start and end color are inverted
        }

        public override void drawImageArea(java.lang.Object nativeGraphics, java.lang.Object img, int x, int y, int imageX, int imageY, int imageWidth, int imageHeight)
        {  
          base.drawImageArea(nativeGraphics, img, x, y, imageX, imageY, imageWidth, imageHeight);
        }

        public override void fillRectRadialGradient(java.lang.Object graphics, int startColor, int endColor, int x, int y, int width, int height, float relativeX, float relativeY, float relativeSize)
        {
            int centerX = (int)(width * (1 - relativeX));
            int centerY = (int)(height * (1 - relativeY));
            int size = (int)(Math.Min(width, height) * relativeSize);
            int x2 = (int)(width / 2 - (size * relativeX));
            int y2 = (int)(height / 2 - (size * relativeY));
            ((NativeGraphics)graphics).destination.fillRadialGradient(endColor, startColor, x + x2, y + y2, size, size); // win2d start and end color are inverted
        }

        public override void releaseImage(java.lang.Object n1)
        {
            ((CodenameOneImage)n1).image.Dispose();
        }
      
        public override int convertToPixels(int mm, bool horizontal)
        {
            // 55.5mm ~ 400dip
            // return screen.ConvertDipsToPixels(mm * 7.207f, CanvasDpiRounding.Round);
            if (horizontal != true) return Convert.ToInt32((mm * rawDpiy) / 25.4);
            return Convert.ToInt32((mm * rawDpix) / 25.4);
        }

        public override void fillTriangle(java.lang.Object graphics, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            ((NativeGraphics)graphics).destination.fillPolygon(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        }

        public override void fillPolygon(java.lang.Object graphics, _nArrayAdapter<int> xPoints, _nArrayAdapter<int> yPoints, int nPoints)
        {
            ((NativeGraphics)graphics).destination.fillPolygon(xPoints.getCSharpArray(), yPoints.getCSharpArray());
        }

        public override object flipImageHorizontally(ui.Image image, bool maintainOpacity)
        {
            return base.flipImageHorizontally(image, maintainOpacity);
        }

        public override object flipImageVertically(ui.Image image, bool maintainOpacity)
        {
            return base.flipImageVertically(image, maintainOpacity);
        }

        public override bool isTransformSupported()
        {
            return base.isTransformSupported();  
        }

        public override bool isTransformSupported(java.lang.Object n1)
        {
            return base.isTransformSupported(n1);
        }

        public override bool isTranslationSupported()
        {
            return base.isTranslationSupported();
        }

        public override void rotate(java.lang.Object nativeGraphics, float angle)
        {
            base.rotate(nativeGraphics, angle);
        }

        public override void rotate(java.lang.Object nativeGraphics, float angle, int x, int y)
        {
            base.rotate(nativeGraphics, angle, x, y);
        }

        public override object rotate180Degrees(ui.Image image, bool maintainOpacity)
        {
            return base.rotate180Degrees(image, maintainOpacity);
        }

        public override object rotate270Degrees(ui.Image image, bool maintainOpacity)
        {
            return base.rotate270Degrees(image, maintainOpacity);
        }

        public override object rotate90Degrees(ui.Image image, bool maintainOpacity)
        {
            return base.rotate90Degrees(image, maintainOpacity);
        }

        public override void scale(java.lang.Object nativeGraphics, float x, float y)
        {
           base.scale(nativeGraphics, x, y);
        }

        public override void setTransform(java.lang.Object n1, ui.Transform n2)
        {
            base.setTransform(n1, n2);
        }

        public override void translate(java.lang.Object n1, int n2, int n3)
        {
            base.translate(n1, n2, n3);
        }

        public override bool isRotationDrawingSupported()
        {
            return false;
        }
       
        public override object createImage(_nArrayAdapter<int> n1, int n2, int n3)
        {
            CodenameOneImage ci = (CodenameOneImage)createMutableImage(n2, n3, 0);
            byte[] buf = new byte[n1.Length * 4];
            System.Buffer.BlockCopy(n1.getCSharpArray(), 0, buf, 0, buf.Length);
            CanvasBitmap cb = CanvasBitmap.CreateFromBytes(screen, buf, n2, n3, pixelFormat);
            ci.graphics.destination.drawImage(cb, 0, 0);
            return ci;
        }

        public override object createImage(java.lang.String path)
        {
            if (path.startsWith(toJava("file:")))
            {
                return createImage((java.io.InputStream)openFileInputStream(path));
            }
            global::java.io.InputStream s = (global::java.io.InputStream)getResourceAsStream(null, path);
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
                System.Buffer.BlockCopy(byteArray, 0, sbyteArray, 0, byteArray.Length);
            }
            return sbyteArray;
        }

        const int maxCacheSize = 50;
        private static ConcurrentDictionary<int, CodenameOneImage> imageCache = new ConcurrentDictionary<int, CodenameOneImage>();

        public override global::System.Object createImage(global::org.xmlvm._nArrayAdapter<sbyte> bytes, int offset, int len)
        {

            if (imageCache.ContainsKey(bytes.hashCode()))
            {
                CodenameOneImage cached;
                imageCache.TryGetValue(bytes.hashCode(), out cached);
                cached.lastAccess = System.DateTime.Now.Ticks;
                return cached;
            }
            if (bytes.Length == 0)
            {
                // workaround for empty images
                return createMutableImage(1, 1, 0xffffff);
            }
            CodenameOneImage ci = null;
            string contentType;
            CanvasBitmap canvasbitmap;
            byte[] imageArray = toByteArray(bytes.getCSharpArray());
            contentType = ImageHelper.GetContentType(imageArray);
            using (InMemoryRandomAccessStream s = new InMemoryRandomAccessStream())
            {              
                using (DataWriter writer = new DataWriter(s.GetOutputStreamAt((ulong)offset)))
                {
                    writer.WriteBytes(imageArray);
                    writer.StoreAsync().AsTask().GetAwaiter().GetResult();
                    writer.FlushAsync().AsTask().GetAwaiter().GetResult();
                    writer.DetachStream().AsStreamForWrite();                 
                    canvasbitmap = CanvasBitmap.LoadAsync(screen, s).AsTask().GetAwaiter().GetResult();    
                }
            }
        
            try
            {
                CodenameOneImage cim = new CodenameOneImage();
                cim.@this();
                if (contentType.Equals("image/jpeg") || contentType.Equals("image/x-ms-bmp"))
                {
                    cim.opaque = true;
                }
                CanvasRenderTarget cr = new CanvasRenderTarget(screen, float.Parse(canvasbitmap.Size.Width.ToString()), float.Parse(canvasbitmap.Size.Height.ToString()), canvasbitmap.Dpi);
                cim.image = cr;
                cim.graphics.destination.drawImage(canvasbitmap, 0, 0);
                cim.graphics.destination.dispose();
                ci = cim;
                canvasbitmap.Dispose();
                dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
                {
                    imageCache.TryAdd(bytes.hashCode(), ci);
                    while (imageCache.Count > maxCacheSize)
                    {
                        int toRemove = imageCache.OrderBy(m => m.Value.lastAccess).First().Key;
                        CodenameOneImage ignored;
                        imageCache.TryRemove(toRemove, out ignored);
                    }
                }).AsTask();
            }
            catch (Exception)
            {
                Debug.WriteLine("\n Failed to create image " + bytes.hashCode() + "\n Position: " + offset + "\n Size: " + len);
            }

            return ci;
        }

        public override void tileImage(java.lang.Object graphics, java.lang.Object image, int x, int y, int w, int h)
        {
            CodenameOneImage img = (CodenameOneImage)image;
            img.lastAccess = System.DateTime.Now.Ticks;
            NativeGraphics ng = (NativeGraphics)graphics;
            ng.destination.tileImage(img.image, x, y, w, h);
        }

        public static bool exitLock;
        private global::com.codename1.ui.events.ActionListener pendingCaptureCallback;

        public override void capturePhoto(ActionListener response)
        {
            exitLock = true;
            pendingCaptureCallback = response;
            // Windows.ApplicationModel.CameraApplicationManager.ShowInstalledApplicationsUI(); 
            openGaleriaCamera();
            
        }
    
        public override void openImageGallery(ActionListener response)
        {
            exitLock = true;
            pendingCaptureCallback = response;
            openGaleriaCamera();
        }
      
        private void openGaleriaCamera()
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                FileOpenPicker openPicker = new FileOpenPicker();
                openPicker.ViewMode = PickerViewMode.Thumbnail;
                openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
                openPicker.FileTypeFilter.Add(".jpg");
                openPicker.FileTypeFilter.Add(".jpeg");
                openPicker.FileTypeFilter.Add(".png");
                // Launch file open picker and caller app is suspended and may be terminated if required 
                openPicker.PickSingleFileAndContinue();
                var e = PhotoCaptureSource.Photo;
                view.Activated += view_Activated;
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
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

        void view_Activated(CoreApplicationView sender, IActivatedEventArgs args)
        {
            var filePickerContinuationArgs = args as FileOpenPickerContinuationEventArgs;
            if (filePickerContinuationArgs != null)
            {
                this.FilePickerContinuationArgs = filePickerContinuationArgs;
                this.ContinueFileOpenPicker(FilePickerContinuationArgs);
            }
            else
            {
                return;
            }

        }

        public void ContinueFileOpenPicker(FileOpenPickerContinuationEventArgs args)
        {
            if (args != null)
            {
                if (args.Files.Count == 0) return;
                view.Activated -= view_Activated;
                fileName = args.Files[0].Name;
                com.codename1.ui.events.ActionEvent ac = new com.codename1.ui.events.ActionEvent();
                ac.@this(toJava("cameraroll:/" + fileName));
                fireCapture(ac);
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
        public WebView webView;
        public override global::System.Object createBrowserComponent(global::java.lang.Object n1)
        {
            SilverlightPeer sp = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    webView = new WebView();
                    currentBrowser = (com.codename1.ui.BrowserComponent)n1;
                    webView.DOMContentLoaded += webview_DOMContentLoaded;
                    webView.NavigationStarting += webview_Navigating;
                    webView.ContentLoading += webview_ContentLoading;
                    webView.IsTapEnabled = true;
                    webView.NavigationCompleted += webview_NavigationCompleted;
                    sp = new SilverlightPeer(webView);
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return sp;
        }

        void webview_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs e)
        {
            //string html = sender.InvokeScriptAsync("eval", new string[] { "[].map.call(document.getElementsByTagName('a'), function(node){ return node.href; }).join('||');" }).AsTask().GetAwaiter().GetResult();
            com.codename1.ui.events.BrowserNavigationCallback bn = (com.codename1.ui.events.BrowserNavigationCallback)currentBrowser.getBrowserNavigationCallback();
            com.codename1.ui.events.ActionEvent ev = new com.codename1.ui.events.ActionEvent();
            ev.@this(toJava(e.Uri.OriginalString));
            currentBrowser.fireWebEvent(toJava("onLoadResource"), ev);

        }

        void webview_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs e)
        {
            com.codename1.ui.events.BrowserNavigationCallback bn = (com.codename1.ui.events.BrowserNavigationCallback)currentBrowser.getBrowserNavigationCallback();
            com.codename1.ui.events.ActionEvent ev = new com.codename1.ui.events.ActionEvent();
            if (e.IsSuccess == false)
            {
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

        void webview_Navigating(WebView sender, WebViewNavigationStartingEventArgs e)
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
            string st = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
                {
                    webView = (WebView)((SilverlightPeer)n1).element;
                    st = await webView.InvokeScriptAsync("eval", new string[] { "document.title.toString()" });
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return toJava(st);
        }

        public override global::System.Object getBrowserURL(global::com.codename1.ui.PeerComponent n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
           {
            webView = (WebView)((SilverlightPeer)n1).element;
           
           }).AsTask().GetAwaiter().GetResult();
            return toJava(webView.Source.OriginalString);
        }

        public override void setBrowserURL(global::com.codename1.ui.PeerComponent browserPeer, global::java.lang.String url)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
           {
               webView = (WebView)((SilverlightPeer)browserPeer).element;
               string uri = toCSharp(url);
               if (uri.StartsWith("jar:/"))
               {
                   uri = uri.Substring(5);
                   while (uri[0] == '/')
                   {
                       uri = uri.Substring(1);
                   }
                   uri = "res/" + uri;
                   webView.Source = new Uri(uri, UriKind.Relative);
                   return;
               }
               webView.Source = new Uri(uri);
           }).AsTask().GetAwaiter().GetResult();
        }
 
        public override void browserReload(global::com.codename1.ui.PeerComponent n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                webView = (WebView)((SilverlightPeer)n1).element;
                webView.Source = webView.Source;
            }).AsTask().GetAwaiter().GetResult();
        }

        public override bool browserHasBack(global::com.codename1.ui.PeerComponent n1)
        {
            bool ret = false;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   webView = (WebView)((SilverlightPeer)n1).element;
                   ret = webView.CanGoBack;
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
                     webView = (WebView)((SilverlightPeer)n1).element;
                     ret = webView.CanGoForward;
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
                webView = (WebView)((SilverlightPeer)n1).element;
                webView.GoBack();
            }).AsTask().GetAwaiter().GetResult();
        }

        public override void browserStop(global::com.codename1.ui.PeerComponent n1)
        {
          dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
         {
             webView = (WebView)((SilverlightPeer)n1).element;
             webView.Stop();
         }).AsTask().GetAwaiter().GetResult();
        }

        public override void browserForward(global::com.codename1.ui.PeerComponent n1)
        {
              dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
         {
            webView = (WebView)((SilverlightPeer)n1).element;
            webView.GoForward();
         }).AsTask().GetAwaiter().GetResult();
        }

        public override void setBrowserPage(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2, global::java.lang.String n3)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
           {
               webView = (WebView)((SilverlightPeer)n1).element;
               webView.NavigateToString(toCSharp(n2));
           }).AsTask().GetAwaiter();
        }

        public override void browserDestroy(PeerComponent n1)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                webView = (WebView)((SilverlightPeer)n1).element;
                webView.Visibility = Visibility.Collapsed;
            }).AsTask().GetAwaiter();
        }

        public override void execute(global::java.lang.String n1)
        {
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    webView = new WebView();
                    webView.Source = new Uri(toCSharp(n1), UriKind.RelativeOrAbsolute);
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
        }

        public override void browserExecute(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2)
        {
            dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
            {
                webView = (WebView)((SilverlightPeer)n1).element;
                await webView.InvokeScriptAsync(toCSharp(n2), new string[] { "document.title.toString()" });
            }).AsTask().GetAwaiter();
        }

        public override global::System.Object browserExecuteAndReturnString(global::com.codename1.ui.PeerComponent n1, global::java.lang.String n2)
        {
            string st = null;
            using (AutoResetEvent are = new AutoResetEvent(false))
            {
                dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
                {
                    webView = (WebView)((SilverlightPeer)n1).element;
                    st = await webView.InvokeScriptAsync(toCSharp(n2), new string[] { "document.title.toString()" });
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
                    Debug.WriteLine("No recipient emailid Contact found");
                }
            }
            else
            {
                Debug.WriteLine("No recipient emailid Contact found");
            }
        }

        public override void sendSMS(java.lang.String n1, java.lang.String n2, bool n)
        {
            var chatMessage = new Windows.ApplicationModel.Chat.ChatMessage();
            chatMessage.Body = toCSharp(n2);
            chatMessage.Recipients.Add(toCSharp(n1));
            Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(chatMessage).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public override object createMutableImage(int width, int height, int color)
        {
            CodenameOneImage ci = new CodenameOneImage();
            ci.@this();
            ci.mutable = true;
            ci.image = new CanvasRenderTarget(screen, screen.ConvertPixelsToDips(width), screen.ConvertPixelsToDips(height));
            ci.graphics.destination.setColor(color);
            ci.graphics.destination.setAlpha((color >> 24) & 0xff);
            //ci.graphics.destination.clear();
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

        public override bool isAlphaMutableImageSupported()
        {
            return false;
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
            ci.opaque = image.opaque;
            if (width > 0 && height < 0)
            {
                height = srcHeight * width / srcWidth;
            }
            if (width < 0 && height > 0)
            {
                width = srcWidth * height / srcHeight;
            }

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

        public override bool isBaselineTextSupported()
        {
            return true;
        }

        public override int getFontAscent(java.lang.Object nativeFont)
        {
            CanvasTextFormat font = (nativeFont == null ? this.defaulFontCanvas : (CanvasTextFormat)((NativeFont)nativeFont).font);
            return (int)-Math.Round(font.FontSize);
        }

        public override int getFontDescent(java.lang.Object nativeFont)
        {
            CanvasTextFormat font = (nativeFont == null ? this.defaulFontCanvas : (CanvasTextFormat)((NativeFont)nativeFont).font);
            return (int)Math.Abs(Math.Round(font.FontSize));
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
            Rectangle clip = new Rectangle();
            clip.@this(clipX, clipY, clipW, clipH);
            ((NativeGraphics)graphics).clip = clip;
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
        }
        //Line drawLineLineInstance;
        public override void drawLine(java.lang.Object graphics, int x1, int y1, int x2, int y2)
        {
            ((NativeGraphics)graphics).destination.drawLine(x1, y1, x2, y2);
        }
        //Rectangle fillDrawRectInstance;
        public override void fillRect(java.lang.Object graphics, int x, int y, int w, int h)
        {
            ((NativeGraphics)graphics).destination.fillRect(x, y, w, h);
        }

        public override void drawRect(java.lang.Object graphics, int x, int y, int w, int h)
        {
            drawRect(graphics, x, y, w, h, 1);
        }

        public override void drawRect(java.lang.Object graphics, int x, int y, int w, int h, int stroke)
        {
            ((NativeGraphics)graphics).destination.drawRect(x, y, w, h, stroke);
        }

        public override void drawRoundRect(java.lang.Object graphics, int x, int y, int w, int h, int arcW, int arcH)
        {
            ((NativeGraphics)graphics).destination.drawRoundRect(x, y, w, h, arcW, arcH);
        }

        public override void fillRoundRect(java.lang.Object graphics, int x, int y, int w, int h, int arcW, int arcH)
        {
            ((NativeGraphics)graphics).destination.fillRoundRect(x, y, w, h, arcW, arcH);
        }

        public override void fillArc(java.lang.Object graphics, int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            ((NativeGraphics)graphics).destination.fillArc(x, y, w, h, startAngle, arcAngle);
        }

        public override void drawArc(java.lang.Object graphics, int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            ((NativeGraphics)graphics).destination.drawArc(x, y, w, h, startAngle, arcAngle);
        }

        public override void drawString(java.lang.Object graphics, java.lang.String str, int x, int y)
        {
            ((NativeGraphics)graphics).destination.drawString(toCSharp(str), x, y);
        }

        public override void drawImage(java.lang.Object graphics, java.lang.Object img, int x, int y)
        {
            CodenameOneImage ci = (CodenameOneImage)img;
            ci.lastAccess = System.DateTime.Now.Ticks;
            if (ci.image != null)
            {
                ((NativeGraphics)graphics).destination.drawImage(ci.image, x, y);
            }
            else
            {
                Debug.WriteLine("SilverlightImplementatio.drawImage:" + " ci.image generated null");
            }
          
        }

        public override bool areMutableImagesFast()
        {
            return false; // async painter
        }

        public override void drawImage(java.lang.Object graphics, java.lang.Object img, int x, int y, int w, int h)
        {
            CodenameOneImage ci = (CodenameOneImage)img;
            ci.lastAccess = System.DateTime.Now.Ticks;
            if(ci.image != null){
                ((NativeGraphics)graphics).destination.drawImage(ci.image, x, y, w, h);
            }
            else
            {
                Debug.WriteLine("SilverlightImplementatio.drawImage:" + " ci.image generated null");
            }
        }

        public override void drawRGB(java.lang.Object graphics, _nArrayAdapter<int> rgb, int offset, int x, int y, int w, int h, bool n8)
        {
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
            if (image.graphics == null || image.graphics.destination.isDisposed())
            {
                image.initGraphics(); //// image = new CanvasRenderTarget(screen, image.getImageWidth(), image.getImageHeight(), 96.0f); //to use with pixel DPI=96!!! not screen.Dpi);
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

        private static readonly Dictionary<StringFontPair, Int32> stringWidthCache = new Dictionary<StringFontPair, Int32>();

        public override int stringWidth(java.lang.Object n1, java.lang.String n2)
        {
            int result = f(n1).getStringWidth(toCSharp(n2));
            StringFontPair sfp = new StringFontPair(toCSharp(n2), f(n1));
            if (!stringWidthCache.ContainsKey(sfp))
            {
                stringWidthCache.Add(sfp, result);
            }
            return stringWidthCache[sfp];
        }

        public override int charWidth(java.lang.Object n1, char n2)
        {
            return stringWidth(n1, toJava(n2));
        }

        public override int getFace(global::java.lang.Object n1)
        {
            return f(n1).face;
        }

        public override int getSize(global::java.lang.Object n1)
        {
            return f(n1).size;
        }

        public override int getStyle(global::java.lang.Object n1)
        {
            return f(n1).style;
        }

        public override int getHeight(java.lang.Object n1)
        {
            return f(n1).height;
        }

        public override bool isLookupFontSupported()
        {
            return true;
        }

        public override object loadNativeFont(java.lang.String lookupStr)
        {
            string lookup = nativePath(lookupStr);
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
                catch (Exception)
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
            string file = nativePath(fileName);
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
                    int a = Convert.ToInt32((nf.font.FontSize - 5) * (float)scaleFactor);
                    if (scaleFactor == 1.2f) a = (int)nf.font.FontSize;
                    switch (size)
                    {
                        case 8: //com.codename1.ui.Font._fSIZE_1SMALL:
                            a = Convert.ToInt32(nf.font.FontSize * (float)1.8 / 3 * (float)scaleFactor);
                            break;
                        case 16: //com.codename1.ui.Font._fSIZE_1LARGE:
                            a = Convert.ToInt32(nf.font.FontSize * (float)3.5 / 3 * (float)scaleFactor);
                            break;
                    }
                    nf.font.FontSize = a;
                    if ((style & 2) != 0) // com.codename1.ui.Font._fSTYLE_1ITALIC
                    {
                        nf.font.FontStyle = FontStyle.Italic;
                    }
                    if ((style & 1) != 0) // com.codename1.ui.Font._fSTYLE_1BOLD
                    {
                        nf.font.FontWeight = FontWeights.Bold;
                    }
                    nf.font.WordWrapping = CanvasWordWrapping.NoWrap;
                    are.Set();
                }).AsTask().GetAwaiter().GetResult();
                are.WaitOne();
            }
            return nf;
        }

        public virtual NativeFont f(java.lang.Object fnt)
        {
            if (fnt == null) return (NativeFont)getDefaultFont();
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
            Uri uri = new Uri(nativePath(n1));
            n.request = (HttpWebRequest)WebRequest.Create(uri);
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
            return Convert.ToInt32(((NetworkOperation)n1).response.ContentLength);
        }

        public override global::System.Object openOutputStream(global::java.lang.Object connection)
        {
            if (connection is java.lang.String)
            {
                StorageFolder store = getStore((java.lang.String)connection);
                try
                {
                    Stream s = Task.Run(() => store.OpenStreamForWriteAsync(nativePathStore((java.lang.String)connection), CreationCollisionOption.OpenIfExists)).GetAwaiter().GetResult();
                    return new OutputStreamProxy(s);
                }
                catch (Exception e)
                {
                    java.io.FileNotFoundException ex = new global::java.io.FileNotFoundException();
                    ex.@this(toJava("FileNotFoundException - " + e.Message));
                    throw new global::org.xmlvm._nExceptionAdapter(ex);
                }
            }
            com.codename1.io.BufferedOutputStream bo = new com.codename1.io.BufferedOutputStream();
            bo.@this(new OutputStreamProxy(((NetworkOperation)connection).requestStream));
            return bo;
        }

        public override global::System.Object openOutputStream(global::java.lang.Object connection, int offset)
        {
            if (connection is java.lang.String)
            {
                try
                {
                    StorageFolder store = getStore((java.lang.String)connection);
                    Stream stream = Task.Run(() => store.OpenStreamForWriteAsync(nativePathStore((java.lang.String)connection), CreationCollisionOption.OpenIfExists)).ConfigureAwait(false).GetAwaiter().GetResult();
                    stream.Seek(offset, SeekOrigin.Current);
                    return new OutputStreamProxy(stream);
                }
                catch (Exception e)
                {
                    java.io.FileNotFoundException ex = new global::java.io.FileNotFoundException();
                    ex.@this(toJava("FileNotFoundException - " + e.Message));
                    throw new global::org.xmlvm._nExceptionAdapter(ex);
                }
            }
            return null;
        }

        public override global::System.Object openInputStream(global::java.lang.Object connection)
        {
            if (connection is java.lang.String)
            {
                try
                {
                    StorageFolder store = getStore((java.lang.String)connection); //KnownFolders.CameraRoll
                    string file = nativePathStore((java.lang.String)connection);
                    Stream stream = Task.Run(() => store.OpenStreamForReadAsync(file)).ConfigureAwait(false).GetAwaiter().GetResult();
                    return new InputStreamProxy(stream);
                }
                catch (Exception e)
                {
                    java.io.FileNotFoundException ex = new global::java.io.FileNotFoundException();
                    ex.@this(toJava("FileNotFoundException - " + e.Message));
                    throw new global::org.xmlvm._nExceptionAdapter(ex);
                }
            }
            com.codename1.io.BufferedInputStream bo = new com.codename1.io.BufferedInputStream();
            bo.@this(new InputStreamProxy(((NetworkOperation)connection).response.GetResponseStream()));
            return bo;
        }

        public override void setPostRequest(global::java.lang.Object n1, bool n2)
        {
            if (n2)
            {
                ((NetworkOperation)n1).request.Method = "POST";
            }
            else
            {
                ((NetworkOperation)n1).request.Method = "GET";
            }
        }

        public override int getResponseCode(global::java.lang.Object n1)
        {
            return Convert.ToInt32(((NetworkOperation)n1).response.StatusCode);
        }

        public override global::System.Object getResponseMessage(global::java.lang.Object n1)
        {
            return toJava(((NetworkOperation)n1).response.StatusDescription);
        }

        public override void vibrate(int n1)
        {
            VibrationDevice vc = VibrationDevice.GetDefault();
            vc.Vibrate(TimeSpan.FromMilliseconds(n1));
        }

        public override global::System.Object getHeaderField(global::java.lang.String n1, global::java.lang.Object n2)
        {
            return toJava(((NetworkOperation)n2).response.Headers[toCSharp(n1)]);
        }

        public override global::System.Object getHeaderFieldNames(global::java.lang.Object n1)
        {
            int i = ((NetworkOperation)n1).response.Headers.Count;
            java.lang.String[] arr = new java.lang.String[i];
            _nArrayAdapter<global::System.Object> r = new _nArrayAdapter<global::System.Object>(arr);
            string[] keys = ((NetworkOperation)n1).response.Headers.AllKeys;
            for (int iter = 0; iter < i; iter++)
            {
                arr[iter] = toJava(keys[iter]);
            }
            return r;
        }

        public override global::System.Object getHeaderFields(global::java.lang.String n1, global::java.lang.Object n2)
        {
            String s = ((NetworkOperation)n2).response.Headers[toCSharp(n1)];
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
            deleteFile(iDefaultStore, nativePath(name));
        }

        public override int getStorageEntrySize(java.lang.String name)
        {
            string f = nativePath(name);
            StorageFile file = iDefaultStore.GetFileAsync(f).AsTask().ConfigureAwait(false).GetAwaiter().GetResult(); ;
            if (file == null) return 0; //.Name != nativePath(name))
            Stream st = Task.Run(() => file.OpenStreamForReadAsync()).ConfigureAwait(false).GetAwaiter().GetResult();
            long size = st.Length;
            st.Dispose();
            return Convert.ToInt32(size);
        }

        public override global::System.Object createStorageOutputStream(global::java.lang.String name)
        {
            try
            {
                StorageFile file = iDefaultStore.CreateFileAsync(nativePath(name), CreationCollisionOption.OpenIfExists).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                return new OutputStreamProxy(Task.Run(() => file.OpenStreamForWriteAsync()).ConfigureAwait(false).GetAwaiter().GetResult());
            }
            catch (Exception e)
            {
                java.io.FileNotFoundException ex = new global::java.io.FileNotFoundException();
                ex.@this(toJava("FileNotFoundException - " + e.Message));
                throw new global::org.xmlvm._nExceptionAdapter(ex);
            }
        }

        public override global::System.Object createStorageInputStream(global::java.lang.String name)
        {
            try
            {
                StorageFile file = iDefaultStore.CreateFileAsync(nativePath(name), CreationCollisionOption.OpenIfExists).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                return new InputStreamProxy(Task.Run(() => file.OpenStreamForReadAsync()).GetAwaiter().GetResult());
            }
            catch (Exception)
            {
                try
                {
                    StorageFile file = iDefaultStore.CreateFileAsync(nativePath(name), CreationCollisionOption.GenerateUniqueName).AsTask().GetAwaiter().GetResult();
                    return new InputStreamProxy(file.OpenReadAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult().AsStream());
                }
                catch (Exception e)
                {
                    java.io.FileNotFoundException ex = new global::java.io.FileNotFoundException();
                    ex.@this(toJava("FileNotFoundException - " + e.Message));
                    throw new global::org.xmlvm._nExceptionAdapter(ex);
                }
            }
        }

        public override bool storageFileExists(global::java.lang.String name)
        {
            string uri = nativePath(name);
            if (uri.StartsWith("/"))
            {
                uri = @"res\" + uri.Substring(1);
            }
            uri = uri.Replace('/', '\\');
            return exists(iDefaultStore, uri);
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
            IReadOnlyList<StorageFile> filesInFolder = iDefaultStore.GetFilesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

            string[] ss = new string[filesInFolder.Count];
            for (int i = 0; i < filesInFolder.Count; i++)
            {
                ss[i] = filesInFolder.ElementAt(i).Name;
            }
            return convertArray(ss);
        }

        public override global::System.Object getAppHomePath()
        {
            return toJava("file:///" + getDictValue(iCN1Settings, "DefaultStorageFolder", "Cache:"));
        }

        public override object listFilesystemRoots()
        {
            var roots = new List<java.lang.String>();
            roots.Add(toJava("local:"));
            var sdcards = KnownFolders.RemovableDevices;
            if (sdcards != null)
            {
                roots.Add(toJava("removable:"));
                //var storageAssets = (sdcards.GetFoldersAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult()).FirstOrDefault();

                //foreach (StorageFolder f in storageAssets)
                //{
                //    roots.Add(toJava(f.DisplayName));
                //}
            }
            roots.Add(toJava("install:"));
            roots.Add(toJava("roaming:"));
            roots.Add(toJava("cache:"));
            roots.Add(toJava("temp:"));
            roots.Add(toJava("CameraRoll:"));
            roots.Add(toJava("SDCard:"));

            var rootsAll = new _nArrayAdapter<global::System.Object>(roots.ToArray());
            return rootsAll;
        }

        private static StorageFolder getStore(java.lang.String url)
        {
            String ss = toCSharp(url);
            return getStore(ss);
        }

        private static StorageFolder getStore(string ss)
        {
            try
            {
                if (ss != null) // && (ss[0] == '/' || ss[0] == '\\'))
                {
                    if (ss.StartsWith("file:/"))
                    {
                        ss = ss.Substring(6);

                        while (ss.Length > 0 && ss[0] == '/')
                        {
                            ss = ss.Substring(1);
                        }

                    }
                    if (ss.Length > 0 && (ss[0] == '/' || ss[0] == '\\'))
                        ss = ss.Substring(1);
                    var pos = ss.IndexOfAny(new char[] { ':', '/', '\\' }, 0);
                    if (pos > 0 && ss[pos] == ':')
                    {
                        ss = ss.Substring(0, pos);
                        ss = ss.ToLower();
                        //    else
                        //        ss = ss.Substring(1);
                        if (ss.Equals("local"))
                            return ApplicationData.Current.LocalFolder;
                        else if (ss.Equals("cache"))
                            return ApplicationData.Current.LocalCacheFolder;
                        else if (ss.Equals("roaming"))
                            return ApplicationData.Current.RoamingFolder;
                        else if (ss.Equals("install"))
                            return Windows.ApplicationModel.Package.Current.InstalledLocation;
                        else if (ss.Equals("temp"))
                            return ApplicationData.Current.TemporaryFolder;
                        else if (ss.Equals("cameraroll"))
                            return KnownFolders.CameraRoll;
                        else if (ss.Equals("removable"))
                            return KnownFolders.RemovableDevices;
                        else if (ss.Equals("sdcard"))
                        {
                            StorageFolder s = KnownFolders.RemovableDevices; //get first D://
                            var folders = s.GetFoldersAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                            StorageFolder s1 = folders.FirstOrDefault();
                            return s1;
                        }
                    }
                }
                if (iDefaultStore == null)
                    return ApplicationData.Current.LocalCacheFolder;
                else
                    return iDefaultStore;
            }
            catch (Exception )
            {
            }
            return null;
        }

        private static StorageFile getFile(string aUrl)
        {
            try
            {
                StorageFolder folder = getStore(aUrl);
                int pos = 0; //remove root name ex. intall: from /intall:/test.txt
                if (aUrl[0] == '/' || aUrl[0] == '\\') pos++;
                pos = aUrl.IndexOfAny(new char[] { ':', '/', '\\' }, pos);
                if (pos > 0 && aUrl[pos] == ':')
                    aUrl = aUrl.Substring(pos + 2);
                return folder.GetFileAsync(aUrl).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (FileNotFoundException )
            {
            }
            return null;
        }
        /// <summary>
        /// Use only for storage not for filesystem
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string nativePath(java.lang.String s)
        {
            string ss = toCSharp(s);
            if (ss.StartsWith("file:/"))
            {
                ss = ss.Substring(6);
                while (ss[0] == '/')
                {
                    ss = ss.Substring(1);
                }
                ss = ss.Replace('/', '\\');
            }
            return ss;
        }
        /// <summary>
        /// Translate Java uri to C# and remove root name part ex. file:///intall:/t.png -> t.png
        /// do not use for http url or storage
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string nativePathStore(java.lang.String s)
        {
            string ss = toCSharp(s);
            if (ss.StartsWith("file:/"))
            {
                ss = ss.Substring(6);

                while (ss.Length > 0 && ss[0] == '/')
                {
                    ss = ss.Substring(1);
                }

            }
            if (ss.Length == 0) return ss;
            ss = ss.Replace('/', '\\');
            int pos = 0; //remove root name ex. intall: from /intall:/test.txt
            if (ss[0] == '/' || ss[0] == '\\') pos++;
            pos = ss.IndexOfAny(new char[] { ':', '/', '\\' }, pos);
            if (pos > 0 && ss[pos] == ':')
            {
                pos++;
                if (ss.Length > pos) pos++;
                ss = ss.Substring(pos);
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
            StorageFolder store = getStore(directory);
            var f = nativePathStore(directory);
            if (f.Length == 0)
                folder = store;
            else
                folder = store.GetFolderAsync(f).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            IReadOnlyList<StorageFolder> directoryNames = folder.GetFoldersAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            string[] dirnames = new string[directoryNames.Count];
            for (int i = 0; i < directoryNames.Count; i++)
            {
                var s = directoryNames.ElementAt(i).Name;
                s = s.Replace('\\', '/');
                if (!s.EndsWith("/"))
                    s = s + "/";
                dirnames[i] = s;
            }
            //for (int N = dirnames.Length, i = 0; i < N; i++)
            //{
            //    if (!dirnames[i].EndsWith("/"))
            //    {
            //        dirnames[i] = dirnames[i] + "/";
            //    }
            //}
            //string[] filenames = await store.GetFileNames(nativePath(directory) + "\\*.*");

            IReadOnlyList<StorageFile> fileNames = folder.GetFilesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            string[] filenames = new string[fileNames.Count];
            for (int i = 0; i < fileNames.Count; i++)
            {
                filenames[i] = fileNames.ElementAt(i).Name;
            }
            string[] all = new string[dirnames.Length + filenames.Length];
            dirnames.CopyTo(all, 0);
            filenames.CopyTo(all, dirnames.Length);
            return convertArray(all);
        }

        public override long getRootSizeBytes(java.lang.String root)
        {
            return 0;
             //StorageFolder s = getStore(root);
            //if (s == null) return 0;
            //var properties = s.GetBasicPropertiesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            //var filteredProperties = properties.RetrievePropertiesAsync(new[] { "System.Size" }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            //var free = filteredProperties["System.Size"];
            //return Convert.ToInt64(free);
        }

        public override long getRootAvailableSpace(java.lang.String root)
        {

            StorageFolder s = getStore(root);
            if (s == null) 
                return 0;
            var properties = s.GetBasicPropertiesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            var filteredProperties = properties.RetrievePropertiesAsync(new[] { "System.FreeSpace" }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            var free = filteredProperties["System.FreeSpace"];
            return Convert.ToInt64(free);
            ///return (long)store.GetBasicPropertiesAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult().Size;
        }

        public override void mkdir(java.lang.String directory)
        {
            StorageFolder store = getStore(directory);
            String f = nativePathStore(directory);
            store.CreateFolderAsync(f).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public override void deleteFile(java.lang.String file1) //or Folder
        {
            StorageFolder store = getStore(file1);
            string f = nativePathStore(file1);
            deleteFile(store, f);
        }

        private void deleteFile(StorageFolder store, string f) //or Folder
        {
            try
            {
                if (f.Length == 0 || (f.Length == 1 && f[0] == '\\'))
                    return; //root folder
                var item = store.GetItemAsync(f).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                item.DeleteAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
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
            StorageFolder store = getStore(n1);
        }

        public override long getFileLength(java.lang.String aFile)
        {
            StorageFolder store = getStore(aFile);
            StorageFile file = store.GetFileAsync(nativePathStore(aFile)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            Stream stream = file.OpenReadAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult().AsStream();
            long l1 = stream.Length;
            stream.Dispose();
            return l1;
        }

        public override bool isDirectory(java.lang.String file)
        {
            StorageFolder store = getStore(file);
            var f = nativePathStore(file);
            try
            {
                if (f.Length == 0 || (f.Length == 1 && f[0] == '\\'))
                    return true; //root folder
                var item = store.GetItemAsync(f).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                return item.IsOfType(StorageItemTypes.Folder);
                //   folder = store.GetFolderAsync(nativePathStore(file)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                //   return folder != null; //.Name.Equals(nativePath(file));
            }
            catch (Exception )
            {
                return false;

            }
        }

        public override bool exists(java.lang.String file)
        {
            StorageFolder store = getStore(file);
            String f = nativePathStore(file);
            return exists(store, f);
        }

        private bool exists(StorageFolder aStore, string aFile)
        {  
            // not supported on win rt phone
            //CommonFileQuery commFile = CommonFileQuery.DefaultQuery;
            //commFile.Equals(aFile);
            //if (aStore.IsCommonFileQuerySupported(commFile)) { 
            //    var files = aStore.GetFilesAsync(commFile).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            //    if (files.Count > 0)
            //        return true;
            //    else {
            //        CommonFolderQuery commfolder = CommonFolderQuery.DefaultQuery;
            //        commfolder.Equals(aFile);
            //        if (aStore.IsCommonFolderQuerySupported(commfolder)) {
            //            var folders = aStore.GetFoldersAsync(commfolder).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            //            if (folders.Count > 0)
            //                return true;
            //            else {
            //                return false;
            //            }
            //        }
            //    }
            //}

            bool fileExists;
            try
            {
                StorageFile file = aStore.GetFileAsync(aFile).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                fileExists = file != null;
            }
            catch (Exception)
            {
                fileExists = false;
            }
            return fileExists;
        }

        public override void rename(java.lang.String file, java.lang.String newName)
        {
            StorageFolder store = getStore(file);
            store.RenameAsync(nativePathStore(newName), NameCollisionOption.ReplaceExisting).AsTask().GetAwaiter().GetResult();
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
        private Windows.Foundation.Point point;
        private static float rawDpiy;
        private StorageFolder folder;
        private string fileName;
        private static float rawDpix;

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
        public long lastAccess = System.DateTime.Now.Ticks;
        public string name;
        public bool opaque = false;
        public bool mutable = false;
        private CanvasRenderTarget actualImage;
        public CanvasRenderTarget image
        {
            set
            {
                actualImage = value;
                width = Convert.ToInt32(Math.Ceiling((double)actualImage.SizeInPixels.Width));
                height = Convert.ToInt32(Math.Ceiling((double)actualImage.SizeInPixels.Height));
                initGraphics(); ///
            }
            get { return actualImage; }
        }
        private int width = -1;
        private int height = -1;
        public NativeGraphics graphics = new NativeGraphics();

        new public void @this()
        {
            base.@this();
        }

        public void initGraphics() ///
        {
            if (mutable)
            {
                graphics.destination = new WindowsMutableGraphics(image);
            }
            else
            {
                graphics.destination = new WindowsGraphics(image.CreateDrawingSession());
            }
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
                    CanvasTextLayout fontLayout = new CanvasTextLayout(SilverlightImplementation.screen, "Mg", font, 0.0f, 0.0f);
                    actualHeight = Convert.ToInt32(Math.Ceiling(fontLayout.LayoutBounds.Height));
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
            this.font.FontSize = this.font.FontSize;// *1.2f; /// (float)SilverlightImplementation.scaleFactor; 
            /// default fonts are to small for phone screen
        }

        public override bool Equals(object o)
        {
            NativeFont f = (NativeFont)o;
            return f.height == height && f.face == face && f.size == size && f.style == style;
        }

        public override int GetHashCode()
        {
            return face | style | size ;
        }
     
        internal int getStringWidth(string str)
        {
            String aux = str.Trim();
            if (aux.Length < str.Length)
            {
                // WIN2D does not take space size into account
                int spaceSize = getStringWidth("_ _") - getStringWidth("__");
                CanvasTextLayout fontLayout = new CanvasTextLayout(SilverlightImplementation.screen, aux, font, 0.0f, 0.0f);
                return Convert.ToInt32(Math.Ceiling(fontLayout.LayoutBounds.Width)) + spaceSize * (str.Length - aux.Length);
            }
            else
            {
                CanvasTextLayout fontLayout = new CanvasTextLayout(SilverlightImplementation.screen, str, font, 0.0f, 0.0f);
                return Convert.ToInt32(Math.Ceiling(fontLayout.LayoutBounds.Width));
            }
        }
    }

    class WaitForEdit : java.lang.Object, java.lang.Runnable
    {
        public virtual void run()
        {
            while (SilverlightImplementation.instance.currentlyEditing != null)
            {
                Task.Run(() => global::System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(1))).GetAwaiter().GetResult();
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
                Task.Run(() => global::System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(1))).GetAwaiter().GetResult();
            }
        }
    }

    public class SoftRef : java.lang.Object
    {
        global::System.WeakReference w;

        public SoftRef(java.lang.Object obj)
        {
            w = new WeakReference(obj);
        }

        public java.lang.Object get()
        {
            java.lang.Object o = (java.lang.Object)w.Target;
            return o;
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
                        Task.Run(() => System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(5))).GetAwaiter().GetResult();
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
                        postData.Dispose();
                    }
                    request.BeginGetResponse(ResponseCallback, request);

                    while (!responseCompleted)
                    {
                        Task.Run(() => Task.Delay(TimeSpan.FromMilliseconds(5))).GetAwaiter().GetResult();
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
                lock (internalStream)
                    internalStream.Dispose();
            }
            catch (Exception)
            {
                //internalStream = null;
            }
            internalStream = null;
        }

        public override void flush()
        {
            if (internalStream == null)
            {
                return;
            }
            try
            {
                lock (internalStream)
                    internalStream.Flush();
            }
            catch (Exception)
            {
                // internalStream = null;
            }
        }

        public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1)
        {
            write(n1, 0, n1.Length);
        }

        public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3)
        {
            if (internalStream != null)
                lock (internalStream)
                    internalStream.Write(SilverlightImplementation.toByteArray(n1.getCSharpArray()), n2, n3);
        }

        public override void write(int n1)
        {
            if (internalStream != null)
                lock (internalStream)
                    internalStream.WriteByte((byte)n1);

        }

    }

    public class StringFontPair
    {
        public String str;
        public NativeFont font;

        public StringFontPair(String str, NativeFont font)
        {
            this.str = str;
            this.font = font;
        }

        public override bool Equals(Object stfpo)
        {
            StringFontPair stfp = (StringFontPair)stfpo;
            return str.Equals(stfp.str) && font.Equals(stfp.font);
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
        private object peerImage = null;

        public SilverlightPeer(FrameworkElement element)
        {
            this.element = element;
            @this(null);
        }

        public override bool isFocusable()
        {
            return true;
        }

        public override global::System.Object calcPreferredSize()
        {
            int w = 0;
            int h = 0;
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                element.Measure(new Size(1000000, 1000000));
                w = SilverlightImplementation.screen.ConvertDipsToPixels((float)(element.DesiredSize.Width * SilverlightImplementation.scaleFactor), CanvasDpiRounding.Round);
                h = SilverlightImplementation.screen.ConvertDipsToPixels((float)(element.DesiredSize.Height * SilverlightImplementation.scaleFactor), CanvasDpiRounding.Round);

            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            com.codename1.ui.geom.Dimension d = new com.codename1.ui.geom.Dimension();
            d.@this(Math.Max(2, w), Math.Max(2, h));
            return d;
        }

        public override void onPositionSizeChange()
        {
            Display dis = new Display();
            Form cmp = (Form)getComponentForm();
            if (cmp == null && dis.getCurrent() == cmp)
            {
                return;
            }
            layoutPeer();
        }

        public void layoutPeer()
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
                }).AsTask();
            }
        }

        public override void initComponent()
        {
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (!SilverlightImplementation.cl.Children.Contains(element))
                {
                    SilverlightImplementation.cl.Children.Add(element);
                }
            }).AsTask();
            layoutPeer();
            setPeerImage(null);
        }

        public override void deinitialize()
        {

            peerImage = generatePeerImage();
            setPeerImage((ui.Image)peerImage);
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (SilverlightImplementation.cl.Children.Contains(element))
                {
                    SilverlightImplementation.cl.Children.Remove(element);
                }
            }).AsTask();
        }

        public override void setLightweightMode(bool l)
        {
            if (lightweightMode != l)
            {
                lightweightMode = l;
                SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (l)
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

        public override object generatePeerImage()
        {
            int width = getWidth();
            int height = getHeight();
            if (width <= 0 || height <= 0)
            {
                width = getPreferredW();
                height = getPreferredH();
            }
            CodenameOneImage img = new CodenameOneImage();
            img.@this();
            img.name = "PeerImage: " + element.ToString();
            IRandomAccessStream stream = new InMemoryRandomAccessStream();
            CanvasBitmap cb = null;
            SilverlightImplementation.dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
            {
                if (element is WebView)
                {
                    await ((WebView)element).CapturePreviewToStreamAsync(stream);
                    await stream.FlushAsync();
                    stream.Seek(0);
                    cb = await CanvasBitmap.LoadAsync(SilverlightImplementation.screen, stream);
                }
                else
                {
                    RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
                    await renderTargetBitmap.RenderAsync(element);
                    byte[] buf = renderTargetBitmap.GetPixelsAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult().ToArray();
                    cb = CanvasBitmap.CreateFromBytes(SilverlightImplementation.screen, buf, width, height,
                    SilverlightImplementation.pixelFormat, SilverlightImplementation.screen.Dpi);
                }
                img.image = new CanvasRenderTarget(SilverlightImplementation.screen, cb.SizeInPixels.Width, cb.SizeInPixels.Height, cb.Dpi);
                img.graphics.destination.drawImage(cb, 0, 0);
                img.graphics.destination.dispose();

            }).AsTask().GetAwaiter().GetResult();
            return ui.Image.createImage(img);
        }

        public override bool shouldRenderPeerImage()
        {
            return lightweightMode || !isInitialized();
        }
    }

    public class CN1Media : java.lang.Object, com.codename1.media.Media
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

        public virtual void setNativePlayerMode(bool nativePlayer)
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
                watcher = new Geolocator()
                {
                    MovementThreshold = 1,
                    DesiredAccuracy = PositionAccuracy.High,
                    ReportInterval = (uint)TimeSpan.FromSeconds(1).TotalMilliseconds,  ///FA 1s is used in track/navi apps
                };
            }
            this.watcher.StatusChanged += new TypedEventHandler<Geolocator, StatusChangedEventArgs>(watcher_StatusChanged);
            this.watcher.PositionChanged += new TypedEventHandler<Geolocator, PositionChangedEventArgs>(watcher_PositionChanged);
        }

        void watcher_StatusChanged(Geolocator sender, StatusChangedEventArgs eventArgs)
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
        }

        async void watcher_PositionChanged(Geolocator sender, PositionChangedEventArgs e)
        {
            lastPosition = await sender.GetGeopositionAsync();
            if (lastPosition != null && lastPosition.Coordinate.AltitudeAccuracy.HasValue)
            {
                ((com.codename1.location.LocationListener)getLocationListener()).locationUpdated(convert(lastPosition));
            }
        }

        public override void clearListener()
        {
            if (watcher != null)
            {
                watcher.StatusChanged -= new TypedEventHandler<Geolocator, StatusChangedEventArgs>(watcher_StatusChanged);
                watcher.PositionChanged -= new TypedEventHandler<Geolocator, PositionChangedEventArgs>(watcher_PositionChanged);
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
            location.setAccuracy((float)position.Coordinate.Accuracy); ///FA vertical is more usufull AltitudeAccuracy);
            location.setStatus(getStatus());
            return location;
        }
    }

    public class SilverlightImageIO : com.codename1.ui.util.ImageIO
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

    public class ImageHelper
    {
        public static string GetContentType(byte[] imageBytes)
        {
            imageFormatDecoders.Keys.OrderByDescending(x => x.Length);
            foreach (var kvPair in imageFormatDecoders)
            {
                if (IsMatch(imageBytes, kvPair.Key))
                {
                    return kvPair.Value;
                }
            }
            return "unknown";
        }

        static bool IsMatch(byte[] array, byte[] candidate)
        {
            if (candidate.Length > (array.Length))
                return false;

            for (int i = 0; i < candidate.Length; i++)
                if (array[i] != candidate[i])
                    return false;

            return true;
        }

        private static Dictionary<byte[], string> imageFormatDecoders = new Dictionary<byte[], string>()
        {
            { new byte[]{ 0x42, 0x4D }, "image/x-ms-bmp"},
            { new byte[]{ 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 }, "image/gif" },
            { new byte[]{ 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 }, "image/gif" },
            { new byte[]{ 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }, "image/png" },
            { new byte[]{ 0xff, 0xd8 }, "image/jpeg" },
        };
    }
}// end of namespace: com.codename1.impl