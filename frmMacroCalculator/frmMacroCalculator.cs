using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmMacroCalculator.Entities;

namespace frmMacroCalculator
{
    public partial class frmMacroCalculator : Form
    {
        public frmMacroCalculator()
        {
            InitializeComponent();
        }

        public void Calc01()
        {
            //T = client

            Client T = new Client();

            T.Name = txtName.Text;
            T.Height = int.Parse(txtHeight.Text);
            T.Weight = double.Parse(txtWeight.Text);
            T.Age = int.Parse(txtAge.Text);

            if (rbtnMale.Checked)
            {
                T.Gender = true;
            }
            else
            {
                T.Gender = false;
            }

            if (rbtnLose.Checked)
            {
                T.Goal = true;
            }
            else
            {
                T.Goal = false;
            }

            if (cmbActivity.SelectedIndex == 0)
            {
                T.Factor = 1.2;
            }
            if (cmbActivity.SelectedIndex == 1)
            {
                T.Factor = 1.375;
            }
            if (cmbActivity.SelectedIndex == 2)
            {
                T.Factor = 1.55;
            }
            if (cmbActivity.SelectedIndex == 3)
            {
                T.Factor = 1.725;
            }
            if (cmbActivity.SelectedIndex == 4)
            {
                T.Factor = 1.9;
            }

            T.TBM();

            T.Values();

            label10.Text = T.ToString();
        }
        public void Calc02()
        {
            //T = function

            Function T = new Function();

            T.Name = txtName.Text;
            T.Height = int.Parse(txtHeight.Text);
            T.Weight = double.Parse(txtWeight.Text);
            T.Age = int.Parse(txtAge.Text);

            if (rbtnMale.Checked)
            {
                T.Gender = true;
            }
            else
            {
                T.Gender = false;
            }

            if (rbtnLose.Checked)
            {
                T.Goal = true;
            }
            else
            {
                T.Goal = false;
            }

            if (cmbActivity.SelectedIndex == 0)
            {
                T.Factor = 1.2;
            }
            if (cmbActivity.SelectedIndex == 1)
            {
                T.Factor = 1.375;
            }
            if (cmbActivity.SelectedIndex == 2)
            {
                T.Factor = 1.55;
            }
            if (cmbActivity.SelectedIndex == 3)
            {
                T.Factor = 1.725;
            }
            if (cmbActivity.SelectedIndex == 4)
            {
                T.Factor = 1.9;
            }

            T.TBM();

            T.Values02();

            label11.Text = T.ToString();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calc01();

            Calc02();

            label10.Visible = true;

            label11.Visible = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();

            frm.Show();
        }
    }
}
