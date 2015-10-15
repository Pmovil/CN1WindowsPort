using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.codename1.impl
{
    class WindowsMutableGraphics : WindowsGraphics
    {
        private Microsoft.Graphics.Canvas.CanvasRenderTarget canvas;

        public WindowsMutableGraphics(Microsoft.Graphics.Canvas.CanvasRenderTarget canvas)
            : base(canvas.CreateDrawingSession())
        {
            this.canvas = canvas;
            dispose();
        }

        internal override void setClip(ui.geom.Rectangle clip)
        {
            //base.setClip(clip); // TODO
        }

        internal override void fillRect(int x, int y, int w, int h)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.fillRect(x, y, w, h);
            dispose();
        }

        internal override void fillArc(int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.fillArc(x, y, w, h, startAngle, arcAngle);
            dispose();
        }

        internal override void drawImage(Microsoft.Graphics.Canvas.CanvasBitmap canvasBitmap, int x, int y)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawImage(canvasBitmap, x, y);
            dispose();
        }

        internal override void drawImage(Microsoft.Graphics.Canvas.CanvasBitmap canvasBitmap, int x, int y, int w, int h)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawImage(canvasBitmap, x, y, w, h);
            dispose();
        }

        internal override void drawLine(int x1, int y1, int x2, int y2)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawLine(x1, y1, x2, y2);
            dispose();
        }

        internal override void drawString(string str, int x, int y)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawString(str, x, y);
            dispose();
        }

        internal override void tileImage(Microsoft.Graphics.Canvas.CanvasBitmap canvasBitmap, int x, int y, int w, int h)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.tileImage(canvasBitmap, x, y, w, h);
            dispose();
        }

        internal override void clear()
        {
            setGraphics(canvas.CreateDrawingSession());
            base.clear();
            dispose();
        }
        internal override void fillPolygon(int[] p1, int[] p2)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.fillPolygon(p1, p2);
            dispose();
        }
        internal override void drawArc(int x, int y, int w, int h, int startAngle, int arcAngle)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawArc(x, y, w, h, startAngle, arcAngle);
            dispose();
        }
        internal override void drawRect(int x, int y, int w, int h, int stroke)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawRect(x, y, w, h, stroke);
            dispose();
        }
        internal override void drawRoundRect(int x, int y, int w, int h, int arcW, int arcH)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.drawRoundRect(x, y, w, h, arcW, arcH);
            dispose();
        }
        internal override void fillRoundRect(int x, int y, int w, int h, int arcW, int arcH)
        {
            setGraphics(canvas.CreateDrawingSession());
            base.fillRoundRect(x, y, w, h, arcW, arcH);
            dispose();
        }
        //internal override int getAlpha()
        //{
        //    setGraphics(canvas.CreateDrawingSession());
        //    return base.getAlpha();  
        //}

        //internal override int getColor()
        //{
        //    setGraphics(canvas.CreateDrawingSession());
        //    return base.getColor();
        //}

        //internal override Microsoft.Graphics.Canvas.Text.CanvasTextFormat getFont()
        //{
        //    setGraphics(canvas.CreateDrawingSession());
        //    return base.getFont();
           
        //}

        //internal override void setAlpha(int p)
        //{
        //    setGraphics(canvas.CreateDrawingSession());
        //    base.setAlpha(p);
        //    dispose();
        //}

        //internal override void setColor(int p)
        //{
        //    setGraphics(canvas.CreateDrawingSession());
        //    base.setColor(p);
        //    dispose();
        //}

        //internal override void setFont(Microsoft.Graphics.Canvas.Text.CanvasTextFormat font)
        //{
        //    setGraphics(canvas.CreateDrawingSession());
        //    base.setFont(font);
        //    dispose();
        //}
    }
}
