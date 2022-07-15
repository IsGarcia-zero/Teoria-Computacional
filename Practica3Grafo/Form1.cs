namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Gray);
            g.DrawLine(pen, new PointF(0, 100), new PointF(50, 100));
            g.FillEllipse(brush, 50, 50, 100, 100);
            g.FillEllipse(brush, 250, 50, 100, 100);
            g.FillEllipse(brush, 500, 50, 100, 100);
            g.FillEllipse(brush, 475, 250, 75, 75);
            g.FillEllipse(brush, 475, 400, 75, 75);
            g.FillEllipse(brush, 350, 250, 75, 75);
            g.FillEllipse(brush, 350, 400, 75, 75);
            g.DrawLine(pen, new PointF(150, 100), new PointF(250, 100));
            g.DrawLine(pen, new PointF(350, 100), new PointF(500, 100));
            g.DrawLine(pen, new PointF(550, 150), new PointF(515, 250));
            //automata
            g.DrawLine(pen, new PointF(530, 320), new PointF(530, 410));
            g.DrawLine(pen, new PointF(500, 320), new PointF(500, 410));
            //automata
            g.DrawLine(pen, new PointF(370, 320), new PointF(370, 410));
            g.DrawLine(pen, new PointF(400, 320), new PointF(400, 410));
            //automata
            g.DrawLine(pen, new PointF(420, 270), new PointF(480, 270));
            g.DrawLine(pen, new PointF(420, 290), new PointF(480, 290));
            //automata
            g.DrawLine(pen, new PointF(420, 420), new PointF(480, 420));
            g.DrawLine(pen, new PointF(420, 440), new PointF(480, 440));
            //protocolo
            g.DrawLine(pen, new PointF(380, 250), new PointF(300, 150));
            //esperar
            g.DrawLine(pen, new PointF(550, 50), new PointF(570, 0));
            g.DrawLine(pen, new PointF(570, 0), new PointF(580, 75));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}