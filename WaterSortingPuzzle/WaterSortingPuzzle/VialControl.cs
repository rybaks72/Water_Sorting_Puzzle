using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFroms_Lab2
{
    internal class VialControl : UserControl
    {
        private int maxSegments = 4;
        private int initSegmentCount = 1;
        private int currentSegments;
        private int[] colorCount;
        public List<Color> segments;
        bool puzzleSolved = false;
        private static readonly Color[] DefaultColors =
        { Color.Pink, Color.HotPink, Color.DeepPink, Color.Yellow, Color.DarkViolet, Color.Violet, Color.RoyalBlue, Color.DarkBlue, Color.Silver, Color.Lime, Color.DarkSeaGreen, Color.Teal, Color.Aqua, Color.Orange, Color.Yellow, Color.Red, Color.IndianRed, Color.DarkRed, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid, Color.DarkKhaki, Color.Black, Color.LightGoldenrodYellow};
        [Category("Vial")]
        public int MaxSegments
        {
            get => maxSegments;
            set
            {
                maxSegments = Math.Max(1, value);
                Invalidate();
            }
        }
        [Category("Vial")]
        public int InitSegmentCount
        {
            get => initSegmentCount;
            set
            {
                initSegmentCount = Math.Max(0, Math.Min(value, maxSegments));
                CurrentSegments = initSegmentCount;
                Invalidate();
            }
        }
        public int CurrentSegments
        {
            get => currentSegments;
            set
            {
                currentSegments = Math.Clamp(value, 0, maxSegments);
                Invalidate();
            }
        }
        public VialControl(int max, int init, List<Color>? colors, int vialNo, int emptyVialNo, int[] colorCount)
        {
            Size = new Size(80, 200);
            MinimumSize = new Size(20, 50);
            Dock = DockStyle.Fill;
            AllowDrop = true;
            Anchor = AnchorStyles.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            MaxSegments = max;
            initSegmentCount = init;
            currentSegments = initSegmentCount;
            this.colorCount = colorCount;
            if (colors == null)
            {
                segments = new List<Color>();
                Random rand = new Random();
                for (int i = 0; i < currentSegments; i++)
                {
                    int index = rand.Next(vialNo - emptyVialNo);
                    while (colorCount[index] == maxSegments)
                        index = (index + 1) % colorCount.Length;

                    segments.Add(DefaultColors[index]);
                    colorCount[index]++;
                }
            }
            else
                segments = colors;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            float bw = Math.Max(1f, Width * 0.05f);
            float glassW = Width - bw;
            float glassH = Height - bw;
            float glassX = bw / 2;
            float glassY = bw / 2;

            float r = glassW;
            var path = new GraphicsPath();

            path.AddLine(glassX, glassY, glassX, glassY + glassH - r);
            path.AddArc(glassX, glassY + glassH - r,
                        glassW, r,
                        180, -180);
            path.AddLine(glassX + glassW, glassY + glassH - r,
                         glassX + glassW, glassY);

            g.SetClip(path);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int drawCount = Math.Min(currentSegments, segments.Count());

            float segH = glassH / maxSegments;

            for (int i = 0; i < drawCount; i++)
            {
                float y = glassY + glassH - (i + 1) * segH;
                var rect = new RectangleF(
                    glassX,
                    y,
                    glassW,
                    segH);
                using (SolidBrush brush = new SolidBrush(segments[i]))
                {
                    g.FillRectangle(brush, rect);
                }
                //g.DrawRectangle(new Pen(Color.Black), rect);
            }

            g.ResetClip();
            using var pen = new Pen(Color.Black, bw);
            g.DrawPath(pen, path);

            path.Dispose();
        }
    }
}
