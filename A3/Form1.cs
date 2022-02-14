using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen myPen = new Pen(Color.Black, 2);
        Pen myPenForPoint = new Pen(Color.Black, 2);

        Curve curve = new Curve();

        public Form1()
        {
            InitializeComponent();

            g = drawingArea.CreateGraphics();


        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();

        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateCurveLenght_Click(object sender, EventArgs e)
        {

            lblCurveLenght.Text = curve.CalculateCurveLenght().ToString();
            
        }

       

        private void drawingArea_MouseClick(object sender, MouseEventArgs e)
        {
            Point selectedPoint = new Point(e.X, e.Y);


            if (e.Button == MouseButtons.Left )
            {
                curve.AddPoint(selectedPoint);

            }
            else 
            {
                if (curve.Contains(e.X, e.Y))
                {
                    curve.RemovePoint(e.X, e.Y);
                }
                else
                {
                    curve.RemovePoint(curve.LastAddedPoint());

                }
            }


            Refresh();

            for (int i = 0; i < curve.getPointList().Count; i++)
            {
                g.DrawEllipse(myPenForPoint, curve.getPointList()[i].XCoordinate, curve.getPointList()[i].YCoordinate, 3, 3);

                if (i != curve.getPointList().Count - 1)
                {
                    g.DrawLine(myPen, curve.getPointList()[i].XCoordinate, curve.getPointList()[i].YCoordinate, curve.getPointList()[i + 1].XCoordinate, curve.getPointList()[i + 1].YCoordinate);

                    
                }
            }

        }

        public void drawingArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics objGraphics = this.CreateGraphics();
            objGraphics.Clear(SystemColors.Control);
            objGraphics.DrawRectangle(Pens.Black,
            drawingArea.Left - 1, drawingArea.Top - 1,
            drawingArea.Width + 1, drawingArea.Height + 1);
            objGraphics.Dispose();
        }

        private void drawingArea_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_LineColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lineIndex = comboBox_LineColor.SelectedIndex;
            switch (lineIndex)
            {
                case 0:
                    myPen.Color = Color.Blue;
                    break;

                case 1:
                    myPen.Color = Color.Black;
                    break;

                case 2:
                    myPen.Color = Color.Red;
                    break;
            }


        }

        private void comboBox_PointColor_SelectedIndexChanged(object sender, EventArgs e)
        {

            int pointIndex = comboBox_PointColor.SelectedIndex;
            switch (pointIndex)
            {
                case 0:
                    myPenForPoint.Color = Color.Blue;
                    break;

                case 1:
                    myPenForPoint.Color = Color.Black;
                    break;

                case 2:
                    myPenForPoint.Color = Color.Red;
                    break;
            }

        }
    }
}
