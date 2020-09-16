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
using SimpleGraphicMathf;

namespace SimpleGraphic
{
    public partial class Form1 : Form
    {
        int a=0;
        Triangle t;
        float4x4 m_scale;
        float4x4 m_rotation_y;
        float4x4 m_rotation_z;
        float4x4 m_rotation_x;
        float4x4 m_view;
        float4x4 m_projection;
        Cube cube;
        bool lineOpen;

        public Form1()
        {
            InitializeComponent();

            #region 矩阵定义
            //mvp矩阵定义
            m_scale = new float4x4();
            m_view = new float4x4();
            m_projection = new float4x4();

            //定义旋转矩阵
            m_rotation_y = new float4x4();
            m_rotation_x = new float4x4();
            m_rotation_z = new float4x4();
           
            //m矩阵
            m_scale[1, 1] = 250;
            m_scale[2, 2] = 250;
            m_scale[3, 3] = 250;
            m_scale[4, 4] = 1;

            //v矩阵
            m_view[1, 1] = 1;
            m_view[2, 2] = 1;
            m_view[3, 3] = 1;
            m_view[4, 3] = 250;
            m_view[4, 4] = 1;

            //p矩阵
            m_projection[1, 1] = 1;
            m_projection[2, 2] = 1;
            m_projection[3, 3] = 1;
            m_projection[3, 4] = (float)1/250;
            // m_projection[4, 4] = 1;

            #endregion

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //float4 a = new float4(-0.5f, 0.5f, 0.5f, 1f);
            //float4 b = new float4(-0.5f, -0.5f, -0.5f, 1f);
            //float4 c = new float4(-0.5f, -0.5f, 0.5f, 1f);
            //t = new Triangle(a, b, c);

             cube = new Cube();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //t.OnDraw(e.Graphics);
            cube.Draw(e.Graphics,lineOpen);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 计算角度
            if (a == 720)
                a = 0;

            a += 5;
            double angle = a/360.0*Math.PI ;
            #endregion

            #region 旋转矩阵赋值
            m_rotation_y[1, 1] = (float)Math.Cos(angle);
            m_rotation_y[1, 3] = (float)Math.Sin(angle);
            m_rotation_y[2, 2] = 1;
            m_rotation_y[3, 1] = -(float)Math.Sin(angle);
            m_rotation_y[3, 3] =(float) Math.Cos(angle);
            m_rotation_y[4, 4] = 1;


            m_rotation_x[1, 1] = 1;
            m_rotation_x[2, 2] = (float)Math.Cos(angle);
            m_rotation_x[2, 3] = (float)Math.Sin(angle);
            m_rotation_x[3, 2] = -(float)Math.Sin(angle);
            m_rotation_x[3, 3] = (float)Math.Cos(angle);
            m_rotation_x[4, 4] = 1;

            m_rotation_z[1,1]= (float)Math.Cos(angle);
            m_rotation_z[1, 2] = (float)Math.Sin(angle);
            m_rotation_z[2, 1] = -(float)Math.Sin(angle);
            m_rotation_z[2, 2] = (float)Math.Cos(angle);
            m_rotation_z[3, 3] = 1;
            m_rotation_z[4, 4] = 1;

            #endregion

            #region 开启旋转按钮和线框按钮
            if (this.cbX.Checked)
            {
                float4x4 tx = m_rotation_x.Transpose();
                m_rotation_x= m_rotation_x.Mul(tx);
            }
            if (this.cbY.Checked)
            {
                float4x4 ty = m_rotation_y.Transpose();
                m_rotation_y= m_rotation_y.Mul(ty);
            }
            if (this.cbZ.Checked)
            {
                float4x4 tz = m_rotation_z.Transpose();
                m_rotation_z= m_rotation_z.Mul(tz);
            }
            if (cbLine.Checked) {
                lineOpen = true;
            }
            else
            {
                lineOpen = false;
            }
            #endregion

            #region 各轴旋转矩阵
            float4x4 m_rotation = new float4x4();
            m_rotation = m_rotation_x.Mul(m_rotation_y.Mul(m_rotation_z));
            #endregion

            #region 定义mvp
            float4x4 m = m_scale.Mul(m_rotation);
            float4x4 mv = m.Mul(m_view);
            float4x4 mvp = mv.Mul(m_projection);
            #endregion

            #region 三角形计算光照
            //t.CalculateLighting(m, new float4(-1, 1, -1, 0));
            // t.Transform(mvp);
            #endregion

            cube.CalculateLighting(m_scale, new float4(-1, 1, -1, 0));
            cube.Transform(mvp);

            //无效//强制重绘
            this.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            m_view[4, 3] = (sender as TrackBar).Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
