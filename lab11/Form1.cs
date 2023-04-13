using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab11
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
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Aquamarine);
            g.DrawEllipse(Pens.Black, 400, 20, 300,200);
            g.DrawRectangle(Pens.Black, 410, 150, 100, 250);
            g.DrawLine(Pens.Black, 600, 600, 700, 300);
            
            
            g.FillRectangle(Brushes.Purple, 350, 100, 100, 200);
            g.FillEllipse(Brushes.Black, 500, 180, 400, 100);


            Brush blueBrush = new SolidBrush(Color.Blue);

            // Create points that define polygon.
            Point points1 = new Point(100, 100);
            Point points2 = new Point(200, 50);
            Point points3 = new Point(200, 5);
            Point points4 = new Point(250, 50);
            Point points5 = new Point(300, 100);
            Point points6 = new Point(350, 200);
            Point points7 = new Point(350, 350);
            Point[] curvePoints = { 
                points1,
                points2, 
                points3, 
                points4, 
                points5, 
                points6, 
                points7 
            };

            

            // Draw polygon to screen.
            e.Graphics.FillPolygon(blueBrush, curvePoints);



            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(350, 200);
            Point[] points=
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7

            };
            Pen pen =new Pen(Color.Gold, 3);
            g.DrawPolygon(pen,points);

            Pen pen1 = new Pen(Color.Blue, 3);
            pen1.DashStyle = DashStyle.Dash;
            g.DrawLine(pen1, 300, 200, 600, 400);
            pen1.DashStyle = DashStyle.DashDotDot;
            g.DrawEllipse(pen1, 15, 15, 50, 50);
            pen1.DashStyle = DashStyle.Dot;
            g.DrawPie(pen1, 580, 250, 400, 350, 320, 250);
            g.DrawPolygon(pen, new Point[]
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7
            });
            






        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            g = CreateGraphics();
            switch (e.KeyCode)
            {
                case Keys.A:
                    g.DrawEllipse(Pens.Yellow, 400, 200, 300, 100);
                    break;
                case Keys.B:
                    g.DrawRectangle(Pens.Yellow, 400, 200, 300, 200);
                    break;
                case Keys.Delete:
                    g.Clear(Color.Silver);
                    break;

            }
        }
    }
}
