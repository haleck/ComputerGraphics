using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Computer_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private float gridSize = 20;

        private float[,] figurePoints = 
            {
                { -3, 3, 1},
                { 3, 3, 1},
                { 1, -3, 1},
                { 1, -1, 1},
                { -1, -1, 1},
                { -1, -3, 1} 
            };

        private void Multiplication(float[,] a, float[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            float[,] r = new float[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            Array.Copy(r, a, r.Length);
        }

        private void TranslateXY(float x, float y)
        {
            float[,] tranlateMatrix =
                {
                    {1,0,0},
                    {0,1,0},
                    {x,y,1}
                };
            Multiplication(figurePoints, tranlateMatrix);
        }

        private void Rotate(float angle)
        {
                float[,] transferMatrix =
                {
                { (float)Math.Cos(angle), (float)Math.Sin(angle), 0 },
                { -(float)Math.Sin(angle), (float)Math.Cos(angle), 0 },
                { 0, -1 ,1 },
                };

                Multiplication(figurePoints, transferMatrix);
        }

        private void ScaleXY(float x, float y)
        {
            float[,] ScaleMatrix =
                {
                    {x,0,0},
                    {0,y,0},
                    {0,0,1}
                };
            Multiplication(figurePoints, ScaleMatrix);
        }

        private void DrawCoordinates()
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            blackPen.Width = 1;

            g.DrawLine(blackPen, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
            g.DrawLine(blackPen, 0, ClientSize.Height / 2, ClientSize.Width, ClientSize.Height / 2);
        }

        private void DrawGreed()
        {
            Graphics g = this.CreateGraphics();
            float h = ClientSize.Height;
            float w = ClientSize.Width;

            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.HighQuality;

            Pen pen = new Pen(Color.DarkGray, 1);

            for (float i = w / 2 + gridSize; i < w; i += gridSize)
                g.DrawLine(pen, i, 0, i, h);
            for (float i = w / 2 - gridSize; i > 0; i -= gridSize)
                g.DrawLine(pen, i, 0, i, h);

            for (float i = h / 2 + gridSize; i < h; i += gridSize)
                g.DrawLine(pen, 0, i, w, i);
            for (float i = h / 2 - gridSize; i > 0; i -= gridSize)
                g.DrawLine(pen, 0, i, w, i);
        }

        private void DrawFigure()
        {
            int figurePointsLenth = figurePoints.GetLength(0);
            float h = ClientSize.Height;
            float w = ClientSize.Width;

            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            blackPen.Width = 1;

            for (int i = 1; i < figurePoints.GetLength(0); i++)
                g.DrawLine(blackPen, figurePoints[i - 1, 0] * gridSize + w / 2, figurePoints[i - 1, 1] * -gridSize + h / 2, figurePoints[i, 0] * gridSize + w / 2, figurePoints[i, 1] * -gridSize + h / 2);
            g.DrawLine(blackPen, figurePoints[figurePointsLenth - 1, 0] * gridSize + w / 2, figurePoints[figurePointsLenth - 1, 1] * -gridSize + h / 2, figurePoints[0, 0] * gridSize + w / 2, figurePoints[0, 1] * -gridSize + h / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGreed();
            DrawFigure();
            DrawCoordinates();
        }

        private void Render()
        {
            DrawGreed();
            DrawFigure();
            DrawCoordinates();
        }

        //private void Form1_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    if (e.Delta > 0 && scrollMultiplicator < 3)
        //    {
        //        scrollMultiplicator += (float)0.1;
        //        gridSize = 40;
        //        gridSize *= scrollMultiplicator;
        //    }

        //    if (e.Delta < 0 && scrollMultiplicator > 0.1)
        //    {
        //        scrollMultiplicator -= (float)0.1;
        //        gridSize = 40;
        //        gridSize *= scrollMultiplicator;
        //    }

        //    Console.WriteLine(scrollMultiplicator);

        //    button1_Click(sender, e);
        //}

        private void MoveRightBtn_Click(object sender, EventArgs e)
        {
            TranslateXY(1, 0);
            Render();
        }

        private void MoveLeftBtn_Click(object sender, EventArgs e)
        {
            TranslateXY(-1, 0);
            Render();
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            TranslateXY(0, 1);
            Render();
        }

        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            TranslateXY(0, -1);
            Render();
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            if (RotateValue.Text != "")
            {
                float fi = float.Parse(RotateValue.Text, CultureInfo.InvariantCulture);
                float angle = (float)(Math.PI * fi / 180.0);

                Rotate(angle);
                Render();

                RotateValue.Text = "";
            }
        }

        private void ScaleBtnX_Click(object sender, EventArgs e)
        {
            if (ScaleValueX.Text != "")
            {
                float value = float.Parse(ScaleValueX.Text, CultureInfo.InvariantCulture);

                ScaleXY(value, 1);
                Render();

                ScaleValueX.Text = "";
            }
        }

        private void ScaleBtnY_Click(object sender, EventArgs e)
        {
            if (ScaleValueY.Text != "")
            {
                float value = float.Parse(ScaleValueY.Text, CultureInfo.InvariantCulture);

                ScaleXY(1, value);
                Render();

                ScaleValueY.Text = "";
            }
        }

        private void ReflectionBtnY_Click(object sender, EventArgs e)
        {
            ScaleXY(-1, 1);
            Render();
        }

        private void ReflectionBtnX_Click(object sender, EventArgs e)
        {
            ScaleXY(1, -1);
            Render();
        }
    }
}