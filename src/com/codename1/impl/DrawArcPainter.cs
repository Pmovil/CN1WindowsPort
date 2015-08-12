using com.codename1.ui.geom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.codename1.impl
{
    class DrawArcPainter : AsyncOp
    {
        private Rectangle clip;
        private int x;
        private int y;
        private int w;
        private int h;
        private int color;
        private int alpha;
        private Microsoft.Graphics.Canvas.Geometry.CanvasGeometry arc;

        public DrawArcPainter(Rectangle clip, int x, int y, int w, int h, int color, int alpha, Microsoft.Graphics.Canvas.Geometry.CanvasGeometry arc)
            : base(clip)
        {
            this.clip = clip;
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.color = color;
            this.alpha = alpha;
            this.arc = arc;
        }
        public override void execute(WindowsGraphics underlying)
        {
            underlying.setColor(color);
            underlying.setAlpha(alpha);
            underlying.drawArc(x, y, w, h, arc);
        }

      
    }
}
