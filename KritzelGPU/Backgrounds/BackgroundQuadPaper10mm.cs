﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kritzel.Main.Renderer;

namespace Kritzel.Main.Backgrounds
{
    [BName("Quad 10mm")]
    public class BackgroundQuadPaper10mm : Background
    {
        public override void Draw(BaseRenderer r, PageFormat format, float border, Color mainColor, Color secondaryColor)
        {
            float borderpx = Util.MmToPoint(border);
            for(float x = border; x < format.Width - border; x+= 10)
            {
                float pt = Util.MmToPoint(x);
                r.DrawLine(mainColor, 1, new PointF(pt, borderpx), 
                    new PointF(pt, format.GetPixelSize().Height - borderpx));
            }
            for (float y = border; y < format.Height-border; y += 10)
            {
                float pt = Util.MmToPoint(y);
                r.DrawLine(mainColor, 1, new PointF(borderpx, pt),
                    new PointF(format.GetPixelSize().Width - borderpx, pt));
            }
            SizeF bsize = format.GetPixelSize();
            RectangleF bounds = new RectangleF(borderpx, borderpx, bsize.Width-2*borderpx, bsize.Height-2*borderpx);
            r.DrawRect(secondaryColor, 1, bounds);
        }
    }
}
