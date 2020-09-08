using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphic
{
    static class Program
    {

       
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            float4 a = new float4(0,0,0,0);
            float4 b = new float4(1,0,0,0);
            float4 c = new float4(0, 1, 0, 0);

            Triangle tri=new Triangle(a,b,c);


            //Graphics g = Graphics.CreateGraphics();
            Pen pen = new Pen(Color.Red,3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
