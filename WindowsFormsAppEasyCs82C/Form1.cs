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

namespace WindowsFormsAppEasyCs82C
{
    public partial class Form1 : Form
    {
        private Image img;
        
        public Form1()
        {
            InitializeComponent();
            img = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs82C\\WindowsFormsAppEasyCs82C\\img\\sample.jpg");
            this.Text = "Graphic Cliping";
            this.ClientSize = new Size(400, 300);
            this.BackColor = Color.Black;

            this.Paint += new PaintEventHandler(FormPaint);
        }

        public void FormPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            
            gp.AddEllipse(new Rectangle(0, 0, 400, 300)); // The Picture appeared in the Circle
            Region rg = new Region(gp);
            g.Clip = rg;
            
            g.DrawImage(img, 0, 0, 400, 300);
        }
    }
}