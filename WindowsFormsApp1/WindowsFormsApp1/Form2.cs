using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        List<string> deptlist = new List<string>()
        {
            "HR","Admin","Sales","Development","Testing","Marketing"

        };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = deptlist;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txtBsalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs + hra + ta + da) - pf;

            txtHRA.Text=hra.ToString();
            txtTA.Text=ta.ToString();
            txtDA.Text = da.ToString();
            txtPF.Text = pf.ToString();
            txtGsalary.Text = gross.ToString();
            

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg=txtEmpId.Text + "\n" +txtEmpName.Text +"\n" + cmbDepartment.Text +"\n" + txtGsalary.Text;
            lblmsg.Text = msg;
        }
    }
}
