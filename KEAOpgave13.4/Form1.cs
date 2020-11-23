using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave13._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // OPGAVE 13.4
            //Box myBox = new Box(); 

            // OPGAVE 13.6
            Box myBox = new Box(Convert.ToDouble(textBoxHeight.Text), Convert.ToDouble(textBoxWidth.Text), Convert.ToDouble(textBoxLength.Text));
            try
            {
                // OPGAVE 13.4
                // Converting input in textboxes to double
                //myBox.Height = Convert.ToDouble(textBoxHeight.Text);
                //myBox.Width = Convert.ToDouble(textBoxWidth.Text);
                //myBox.Length = Convert.ToDouble(textBoxLength.Text);

            }
            catch
            {

                labelError.Text = "Numbers only!";
            }
            textBoxVolume.Text = Convert.ToString(myBox.Volume());
            textBoxSurface.Text = Convert.ToString(myBox.SurfaceArea());

        }

        class Box
        {
            // Fields (are private)
            private double height = -1;
            private double width = -1;
            private double length = -1;


            // Properties (are public)
            public double Height
            {
                get
                {
                    return height;
                }
                set
                {
                    if (value > 0)
                        height = value;
                    else
                        height = 10;
                }
            }
            public double Width
            {
                get
                {
                    return width;
                }
                set
                {
                    if (value > 0)
                        width = value;
                    else
                        width = 10;
                }
            }

            public double Length
            {
                get
                {
                    return length;
                }
                set
                {
                    if (value > 0)
                        length = value;
                    else
                        length = 10;
                }
            }

            // OPGAVE 13.4
            // Constructor - same name as the class
            public Box()
            {
                Volume();
                SurfaceArea();
            }

            // OPGAVE 13.6
            // Constructor with properties
            public Box(double height, double width, double length)
            {
                this.Height = height;
                this.Width = width;
                this.Length = length;
                
                Volume();
                SurfaceArea();

            }
            /// <summary>
            /// Method for calculating the volume of a box
            /// </summary>
            /// <returns>v (volume of box)</returns>
            public double Volume()
            {
                double v = this.height * this.width * this.length;
                return v;
            }

            /// <summary>
            /// Method for calculating the surface area of a box
            /// </summary>
            /// <returns>area</returns>
            public double SurfaceArea()
            {
                double area = 2 * (this.length * this.height + this.height * this.width + this.width * this.length);
                return area;
            }
        }
    }
}
