using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Get the current graphics object.
            Graphics g = e.Graphics;
            Pen RedPen = new Pen(Color.Red, 1 / g.DpiX); // Drawing the initial line to separate graph and text box.
            g.DrawLine(RedPen, 5, 50, 1920, 50);

            bool isNumericbox1 = double.TryParse(fromvalue.Text, out double n1);//checking if degree value is present
            bool isNumericbox2 = double.TryParse(tovalue.Text, out double n2);//checking if degree value is present.

            if (isNumericbox1 && isNumericbox2)//if both text boxes have data input.
            {

                graphPoints(n1,n2, g);
            }

            

        }

        void graphPoints(double n1, double n2, Graphics g)
        {
            // Clear the form space.
            g.Clear(this.BackColor);
           
            // Determine the size of the area in which we will draw.
            Size size = this.ClientSize;

            // Get the max and min x and y values.
            // Get the max and min x and y values.
            double maxX = (n2/180.0); // maximum degree value of range
            double maxY = 1.0;  // max possible value of sin(angles)
            double minX =(n1/180.0);// start value of the angle range
            double minY = -1.0;// min possible value of sin(angle)
            double[] valuesx = new double[1920]; // creating 1920 random points for the graph
            double[] valuesy = new double[1920];

            
            for (int value = 0; value < 1920; value = value + 1)
            {
                 valuesx[value] = (n1/180.0)+(value*(n2-n1)) / (180.0*1920.0);  //creating x values for all the points of graph
                 valuesy[value] =  Math.Sin((valuesx[value] * 180) * (Math.PI) / (180.0)); // creating y values for all the points of graph.
            }
            

            double[] px = new double[1920];  // Array of pixels
            double[] py = new double[1920];

            // Scale the points to pixels.
            for (int ip = 0; ip < valuesx.Length; ip++)
            {
                    px[ip] = (valuesx[ip] - minX) / (maxX - minX) * size.Width;
                    py[ip] = 100+((size.Height-120) - (valuesy[ip] - minY) / (maxY - minY) * (size.Height-120));// 100+ for gap of text boxes
                // -120 to make sure 20 pixels are left below the graph.

            }
            Pen myPen = new Pen(Color.Red) ;
            g.DrawLine(myPen, 5, 50, 1920, 50);
            myPen.Color = System.Drawing.Color.Blue;
            for (int ip = 1; ip < px.Length; ip++)
            {
                    // Why the casting???
                    g.DrawLine(myPen, (float)px[ip - 1], (float)py[ip - 1], (float)px[ip], (float)py[ip]);
            }
            
        }
       


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Invalidate(); }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(  e.KeyCode == Keys.Enter) { Invalidate(); }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
