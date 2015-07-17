using com.codename1.ui.geom;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.Graphics.Canvas.Numerics;
using Microsoft.Graphics.Canvas.Text;
using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Foundation;
using Windows.UI;

namespace PumpopNati.src.com.codename1.impl
{
    public class WindowsGraphics
    {
        private CanvasDrawingSession graphics;
        private Color c = Colors.Black;
        private CanvasTextFormat font = new CanvasTextFormat();
        private CanvasActiveLayer layer;

        public WindowsGraphics(CanvasDrawingSession graphics)
        {
            this.graphics = graphics;
            this.graphics.Units = CanvasUnits.Pixels;
        }
        internal void setGraphics(CanvasDrawingSession graphics)
        {
            this.graphics = graphics;
            this.graphics.Units = CanvasUnits.Pixels;
        }
        internal void removeClip()
        {
            if (layer != null)
            {
                layer.Dispose();
                layer = null;
            }
        }

        internal void dispose()
        {
            graphics.Dispose();
        }

        internal virtual void setClip(Rectangle clip)
        {
            if (clip == null)
            {
                return;
            }
            if (clip.getWidth() <= 0)
            {
                System.Diagnostics.Debug.WriteLine("aaaaaaaaaaaaaaaaaaaa width");
                clip.setWidth(1);
            }
            if (clip.getHeight() <= 0)
            {
                System.Diagnostics.Debug.WriteLine("aaaaaaaaaaaaaaaaaaaa height");
                clip.setHeight(1);
            }
            layer = graphics.CreateLayer(1, new Rect(
                clip.getX(),
                clip.getY(),
                clip.getWidth(),
                clip.getHeight()
            ));
        }

        internal virtual void setAlpha(int p)
        {
            c.A = (byte)(p & 0xff);
        }

        internal virtual void setColor(int p)
        {
            c.R = (byte)((p >> 16) & 0xff);
            c.G = (byte)((p >> 8) & 0xff);
            c.B = (byte)(p & 0xff);
        }

        internal virtual void setFont(CanvasTextFormat font)
        {
            this.font = font;
            //font.FontFamily = "Arial";
        }

        internal virtual CanvasTextFormat getFont()
        {
            return font;
        }

        internal virtual int getColor()
        {
            return (c.R << 16) + (c.G << 8) + c.B;
        }

        internal virtual void drawLine(int x1, int y1, int x2, int y2)
        {
            graphics.DrawLine(x1, y1, x2, y2, c);
        }

        internal virtual void fillRect(int x, int y, int w, int h)
        {
            graphics.FillRectangle(x, y, w, h, c);
        }

        internal virtual void drawRect(int x, int y, int w, int h)
        {
            graphics.DrawRectangle(x, y, w, h, c);
        }

        internal virtual void drawRoundRect(int x, int y, int w, int h, int arcW, int arcH)
        {
            graphics.DrawRoundedRectangle(x, y, w, h, arcW, arcH, c);
        }

        internal virtual void fillRoundRect(int x, int y, int w, int h, int arcW, int arcH)
        {
            graphics.FillRoundedRectangle(x, y, w, h, arcW, arcH, c);
        }

        // TODO - In Win2D, complex shapes such as arcs are provided by the CanvasGeometry class. You can add them to a CanvasPathBuilder via the AddArc method
        internal virtual void fillArc(int x, int y, int w, int h, CanvasGeometry arc)
        {
                //graphics.FillEllipse(x + w / 2, y + h / 2, w / 2, h / 2, c);
        }

        // TODO - In Win2D, complex shapes such as arcs are provided by the CanvasGeometry class. You can add them to a CanvasPathBuilder via the AddArc method
        internal virtual void drawArc(int x, int y, int w, int h, CanvasGeometry arc)
        {
                //graphics.DrawEllipse(x + w / 2, y + h / 2, w / 2, h / 2, c);
        }

        internal virtual void drawString(string str, int x, int y)
        {
            graphics.DrawText(str, x, y, c);
        }

        internal virtual void drawImage(CanvasBitmap canvasBitmap, int x, int y)
        {
            graphics.Units = CanvasUnits.Pixels;
            graphics.DrawImage(canvasBitmap, x, y);
        }

        internal virtual void drawImage(CanvasBitmap canvasBitmap, int x, int y, int w, int h)
        {

            ScaleEffect scale = new ScaleEffect()
            {
                Source = canvasBitmap,
                Scale = new Vector2()
                {
                    X = ((float)w) / canvasBitmap.SizeInPixels.Width,
                    Y = ((float)h) / canvasBitmap.SizeInPixels.Height
                }
            };
            graphics.Units = CanvasUnits.Pixels;
            graphics.DrawImage(scale, x, y);
        }

        internal virtual void clear()
        {
            graphics.Clear(c);
        }

        internal virtual int getAlpha()
        {
            return c.A;
        }

    }
}
