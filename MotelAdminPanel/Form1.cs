using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelAdminPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(185, Color.Black);
            panel3.BackColor = Color.FromArgb(55, Color.Black);
            panel4.BackColor = Color.FromArgb(55, Color.Black);
            panel5.BackColor = Color.FromArgb(55, Color.Black);
            panel6.BackColor = Color.FromArgb(55, Color.Black);
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadChart1()
        {
            var r = new Random();
            var Canvas = new Bunifu.DataViz.WinForms.Canvas();
            var datapoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_bar);
            
            bunifuCharts1.colorSet.Add(Color.FromArgb(149, 48, 93));
            bunifuCharts1.colorSet.Add(Color.FromArgb(225, 155, 45));
            bunifuCharts1.colorSet.Add(Color.FromArgb(75, 146, 108));


#FFFFFF#9D9D3B#9D9D3B#EEEE15#DEDE3A

            Bunifu.DataViz.WinForms.DataPoint point1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            point1.addLabely("MONDAY", "5800");
            point1.addLabely("TUESDAY", "5000");
            point1.addLabely("WEDNESDAY", "4000");
            point1.addLabely("THURSDAY", "8000");
            point1.addLabely("FRIDAY", "4000");
            point1.addLabely("SATURDAY", "5800");
            point1.addLabely("SUNDAY", "5000");
            Canvas.addData(point1);
            bunifuCharts1.Render(Canvas);
           
            Bunifu.DataViz.WinForms.DataPoint point2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_area);
            point2.addLabely("MONDAY", "2800");
            point2.addLabely("TUESDAY", "2500");
            point2.addLabely("WEDNESDAY", "3200");
            point2.addLabely("THURSDAY", "6000");
            point2.addLabely("FRIDAY", "3500");
            point2.addLabely("SATURDAY", "4000");
            point2.addLabely("SUNDAY", "3000");
            Canvas.addData(point2);
            bunifuCharts1.Render(Canvas);

         
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadChart1();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadChart1();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
