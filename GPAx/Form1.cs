using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPAx
{
    public partial class Form1 : Form
    {
        GPACalculator gPACalculator;

        public Form1()
        {
            InitializeComponent();

            gPACalculator = new GPACalculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(this.tbInputGPA.Text);
                gPACalculator.setGPA(input);
                UpdateUI();

                this.tbGPAx.Text = gPACalculator.getGPAX().ToString();
                this.tbMaxGPA.Text = gPACalculator.getMaxGPA().ToString();
                this.tbMinGPA.Text = gPACalculator.getMinGPA().ToString();




                this.tbInputGPA.Text = string.Empty;
            }

            catch (Exception)
            {
                MessageBox.Show("ใส่ตัวเลขให้ถูก!!!!!!");
                this.tbInputGPA.Text = string.Empty;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbInputGPA.Text = string.Empty;
            this.tbGPAx.Text = string.Empty;
            this.tbMaxGPA.Text = string.Empty;
            this.tbMinGPA.Text = string.Empty;
            UpdateUI();
        }
        private void UpdateUI()
        {
            this.tbGPAx.Text = gPACalculator.getGPAX().ToString("F2");
            this.tbMaxGPA.Text = gPACalculator.getMaxGPA().ToString("F2");
            this.tbMinGPA.Text = gPACalculator.getMinGPA().ToString("F2");
            this.tbStudentCount.Text = gPACalculator.getStudentCount().ToString();
        }
    }
}
