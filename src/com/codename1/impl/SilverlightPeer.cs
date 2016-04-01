using com.codename1.ui;
using Microsoft.Graphics.Canvas;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace com.codename1.impl
{
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
}
