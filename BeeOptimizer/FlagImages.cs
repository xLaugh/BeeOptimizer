using System.Drawing;

namespace BeeOptimizer
{
    public static class FlagImages
    {
        // Crée une image simple du drapeau français (3 bandes verticales: bleu, blanc, rouge)
        public static Bitmap CreateFrenchFlag(int width = 30, int height = 20)
        {
            Bitmap flag = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(flag))
            {
                // Fond bleu
                using (Brush blueBrush = new SolidBrush(Color.FromArgb(0, 35, 149)))
                {
                    g.FillRectangle(blueBrush, 0, 0, width / 3, height);
                }
                
                // Bande blanche
                using (Brush whiteBrush = new SolidBrush(Color.White))
                {
                    g.FillRectangle(whiteBrush, width / 3, 0, width / 3, height);
                }
                
                // Bande rouge
                using (Brush redBrush = new SolidBrush(Color.FromArgb(237, 41, 57)))
                {
                    g.FillRectangle(redBrush, 2 * width / 3, 0, width / 3, height);
                }
                
                // Bordure
                using (Pen borderPen = new Pen(Color.Gray, 1))
                {
                    g.DrawRectangle(borderPen, 0, 0, width - 1, height - 1);
                }
            }
            return flag;
        }

        // Crée une image simple du drapeau britannique
        public static Bitmap CreateBritishFlag(int width = 30, int height = 20)
        {
            Bitmap flag = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(flag))
            {
                // Fond bleu
                using (Brush blueBrush = new SolidBrush(Color.FromArgb(1, 33, 105)))
                {
                    g.FillRectangle(blueBrush, 0, 0, width, height);
                }
                
                // Croix de Saint-André (diagonales blanches)
                using (Pen whitePen = new Pen(Color.White, 2))
                {
                    g.DrawLine(whitePen, 0, 0, width, height);
                    g.DrawLine(whitePen, 0, height, width, 0);
                }
                
                // Croix de Saint-Georges (croix rouge)
                using (Pen redPen = new Pen(Color.FromArgb(206, 17, 65), 3))
                {
                    g.DrawLine(redPen, width / 2, 0, width / 2, height);
                    g.DrawLine(redPen, 0, height / 2, width, height / 2);
                }
                
                // Bordure
                using (Pen borderPen = new Pen(Color.Gray, 1))
                {
                    g.DrawRectangle(borderPen, 0, 0, width - 1, height - 1);
                }
            }
            return flag;
        }
    }
}
