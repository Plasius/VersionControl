using Santa.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color boxColor, Color ribbonColor)
        {
            BoxColor = new SolidBrush(boxColor);
            RibbonColor = new SolidBrush(ribbonColor); 
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width / 3, 0, Width/3, Height);
            g.FillRectangle(RibbonColor, 0, Height/3, Width, Height/3);
        }

    }
}
