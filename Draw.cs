using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GitVisualizer
{
    public class Draw
    {
        private static readonly Pen pen = new Pen(Brushes.Black);
        public static Point point = new Point(50, 250);
        public static Panel panel = null;

        static Draw()
        {
            pen.Width = 4;
        }
        
        public static void Head(Graphics graphics)
        {
            Point headPoint = new Point(point.X - panel.HorizontalScroll.Value, point.Y - 200);
            graphics.DrawRectangle(pen, headPoint.X, headPoint.Y, 80, 80);
            String(graphics, headPoint, "HEAD", true);
        }
        
        public static void Branch(Graphics graphics, string branch)
        {
            Point branchPoint = new Point(point.X - panel.HorizontalScroll.Value, point.Y - 100);
            graphics.DrawRectangle(pen, branchPoint.X, branchPoint.Y, 80, 80);
            String(graphics, branchPoint, branch, true);
        }

        public static void Commit(Graphics graphics, string commit)
        {
            graphics.DrawEllipse(pen, point.X - panel.HorizontalScroll.Value, point.Y, 80, 80);
            String(graphics, point, commit, false);
            Next();
        }

        public static void reset()
        {
            point = new Point(50, 250);
        }

        private static void String(Graphics graphics, Point componentPoint, string drawString, bool masterOrHead)
        {
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            if (masterOrHead)
            {
                graphics.DrawString(drawString, drawFont, drawBrush, componentPoint.X + 15, componentPoint.Y + 30);
            }
            else
            {
                graphics.DrawString(drawString, drawFont, drawBrush, componentPoint.X + 15 - panel.HorizontalScroll.Value, componentPoint.Y + 30);
            }
        }
        
        private static void Next()
        {
            point = new Point(point.X + 100, point.Y);
        }
    }
}