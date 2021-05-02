using System.Drawing;

namespace GitVisualizer
{
    public class Draw
    {
        private static readonly Pen pen = new Pen(Brushes.Black);
        private static Point point = new Point(50, 250);

        static Draw()
        {
            pen.Width = 4;
        }
        
        public static void Head(Graphics graphics)
        {
            Point headPoint = new Point(point.X, point.Y - 200);
            graphics.DrawRectangle(pen, headPoint.X, headPoint.Y, 80, 80);
            String(graphics, headPoint, "HEAD");
        }
        
        public static void Branch(Graphics graphics, string branch)
        {
            Point branchPoint = new Point(point.X, point.Y - 100);
            graphics.DrawRectangle(pen, branchPoint.X, branchPoint.Y, 80, 80);
            String(graphics, branchPoint, branch);
        }

        public static void Commit(Graphics graphics, string commit)
        {
            graphics.DrawEllipse(pen, point.X, point.Y, 80, 80);
            String(graphics, point, commit);
            Next();
        }

        private static void String(Graphics graphics, Point componentPoint, string drawString)
        {
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            graphics.DrawString(drawString, drawFont, drawBrush, componentPoint.X + 15, componentPoint.Y + 30);
        }
        
        private static void Next()
        {
            point = new Point(point.X + 100, point.Y);
        }
    }
}