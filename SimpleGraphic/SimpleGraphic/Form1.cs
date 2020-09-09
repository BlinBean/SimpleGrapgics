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
        Triangle t;
        float4x4 m_scale;
        public Form1()
        {
            InitializeComponent();
            m_scale = new float4x4();
            m_scale[1, 1] = 250;
            m_scale[2, 2] = 250;
            m_scale[3, 3] = 250;
            m_scale[4, 4] = 1;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            float4 a = new float4(0, -0.5f, 0, 1);
            float4 b = new float4(0.5f, 0.5f, 0, 1);
            float4 c = new float4(-0.5f, 0.5f, 0, 1);
            t = new Triangle(a, b, c);
           



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.OnDraw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t.Transform(m_scale);
            //无效//强制重绘
            this.Invalidate();
        }
    }
}
