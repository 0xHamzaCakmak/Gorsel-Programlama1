using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Ücgen Çiziyor
            Graphics g = this.CreateGraphics();
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 80);
            Point p3 = new Point(60, 80);
            Pen pen1 = new Pen(Brushes.Red);
            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p2, p3);
            g.DrawLine(pen1, p3, p1); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Kare çiziyor
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(50,50);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10,10);
            Rectangle r1 = new Rectangle(p1,s1);
            g.DrawRectangle(pen1, r1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //içi boş elips çiziyor 
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(50, 50);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10, 10);
            Rectangle r1 = new Rectangle(p1, s1);
            g.DrawEllipse(pen1, r1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //içi dolu elips çiziyor
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(50, 50);
            Point p1 = new Point(10, 10);
            Rectangle r1 = new Rectangle(p1, s1);
            g.FillEllipse(Brushes.Blue, r1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Kare içinde içi boş ve içi dolu olmak uzere toplam 2 adet elips çiziyor
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(50, 50);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10, 10);
            Rectangle r1 = new Rectangle(p1, s1);         
            g.DrawRectangle(pen1, r1);
            g.DrawEllipse(pen1, r1);
            g.FillEllipse(Brushes.Blue, r1);        
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // iç içe elipsler çiziyor. 10 adet. kuculerek cızılıyor
            Graphics g = this.CreateGraphics();
            int x = 200;
            int y = 200;
            int n1 = 10;
            int n2 = 10;
            for (int i = 0; i <10; i++)
            {
            Size s1 = new Size(x, y);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(n1 , n2);
            Rectangle r1 = new Rectangle(p1, s1);
            g.DrawEllipse(pen1, r1);
            x -=20;
            y -=20;
            n1 += 10;
            n2 += 10;
            }  
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // Dama tahtası yapar. Siyah beyaz 8 e 8 karelerle
            Graphics dama = this.CreateGraphics();
            int a = 0;
            for (int i = 0; i < 400; i = i + 100)
            {
                for (int k = 0; k <8; k++)
                {
                    if (a == 0)
                    {
                       dama.FillRectangle(Brushes.White, i, (k * 50), 50, 50);
                       dama.FillRectangle(Brushes.Black, i + 50, (k * 50), 50, 50);
                        a = 1;
                    }
                    else
                    {
                        dama.FillRectangle(Brushes.Black, i, (k * 50), 50, 50);
                        dama.FillRectangle(Brushes.White, i + 50, (k * 50), 50, 50);
                        a = 0;
                    }
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //8 e 8 dama tahtası yapar. dairelerle 50 ye 50
            Graphics dama = this.CreateGraphics();
            int a = 0;
            for (int i = 0; i < 400; i = i + 100)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (a == 0)
                    {
                        dama.FillEllipse(Brushes.White, i, (k * 50), 50, 50);
                        dama.FillEllipse(Brushes.Black, i + 50, (k * 50), 50, 50);
                        a = 1;
                    }
                    else
                    {
                        dama.FillEllipse(Brushes.Black, i, (k * 50), 50, 50);
                        dama.FillEllipse(Brushes.White, i + 50, (k * 50), 50, 50);
                        a = 0;
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //Dikdörtgeni Dikey olarak ikiye böler
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(100, 50);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10, 10);
            Point p2=new Point(60,10);
            Point p3=new Point(60,60);
            Rectangle r1 = new Rectangle(p1, s1);         
            g.DrawRectangle(pen1, r1);
            g.DrawLine(pen1, p2, p3);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //Dikdörtgeni yatayda 2 ye böler
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(100, 50);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(10, 35);
            Point p3 = new Point(110, 35);
            Rectangle r1 = new Rectangle(p1, s1);
            g.DrawRectangle(pen1, r1);
            g.DrawLine(pen1, p2, p3);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            // diairenin içine ortadan + koyuyor.  4 e bölüyor
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(100, 100);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(10, 60);
            Point p3 = new Point(110, 60);
            Point p4 = new Point(60, 10);
            Point p5= new Point(60, 110);
            Rectangle r1 = new Rectangle(p1, s1);
            g.DrawEllipse(pen1, r1);
            g.DrawLine(pen1, p2, p3);
            g.DrawLine(pen1, p4, p5);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //Dikdörtgenin içine çarpı koyuyor. köşeden koseye cizgi çapraz
            Graphics g = this.CreateGraphics();
            Size s1 = new Size(250, 150);
            Pen pen1 = new Pen(Brushes.Red);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(260, 160);
            Point p3 = new Point(10, 160);
            Point p4 = new Point(260, 10);
            Rectangle r1 = new Rectangle(p1, s1);
            g.DrawRectangle(pen1, r1);
            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
} }
