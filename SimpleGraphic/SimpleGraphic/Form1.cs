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

namespace SimpleGraphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float4 a = new float4(0, 0, 0, 1);
            float4 b = new float4(1, 0, 0, 1);
            float4 c = new float4(0, 1, 0, 1);
            Triangle tri = new Triangle(a, b, c);
            Graphics g = this.CreateGraphics();
            tri.OnDraw(g);

            //Pen pen = new Pen(Color.Red,4) ;
            //g.DrawLine(pen,new PointF(10,80),new PointF(250,80));
           


        }

    }
}
