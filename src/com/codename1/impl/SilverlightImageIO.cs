using Microsoft.Graphics.Canvas;
using org.xmlvm;
using System;
using Windows.Storage.Streams;

namespace com.codename1.impl
{
    public class SilverlightImageIO : ui.util.ImageIO
    {
        public SilverlightImageIO()
        {
            @this();
        }

        public override bool isFormatSupported(java.lang.String n1)
        {
            return _fFORMAT_1JPEG.equals(n1) || _fFORMAT_1PNG.equals(n1);
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
            DataReader dr = new DataReader(ms);
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
            DataReader dr = new DataReader(ms);
            dr.LoadAsync((uint)ms.Size).AsTask().ConfigureAwait(false).GetAwaiter().GetResult(); ;
            dr.ReadBytes(buf);
            response.write(new _nArrayAdapter<sbyte>(SilverlightImplementation.toSByteArray(buf)));
        }

    }
}
