using System.Drawing;

namespace GitVisualizer
{
    public class Draw
    {
        private static readonly Pen pen = new Pen(Brushes.Black);
        private static Point point = new Point(50, 140);

        static Draw()
        {
            pen.Width = 4;
        }
        
        public static void Head(Graphics graphics)
        {
            graphics.DrawRectangle(pen, point.X, point.Y - 80, 20, 20);
            String(graphics, "HEAD");
        }
        
        public static void Branch(Graphics graphics, string branch)
        {
            graphics.DrawRectangle(pen, point.X, point.Y - 40, 20, 20);
            String(graphics, branch);
        }

        public static void Commit(Graphics graphics, string commit)
        {
            graphics.DrawEllipse(pen, point.X, point.Y, 20, 20);
            String(graphics, commit);
            Next();
        }

        private static void String(Graphics graphics, string drawString)
        {
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat {FormatFlags = StringFormatFlags.DirectionVertical};
            graphics.DrawString(drawString, drawFont, drawBrush, point.X + 10, point.Y + 10, drawFormat);
        }
        private static void Next()
        {
            point = new Point(point.X + 40,point.Y);
        }
    }
}