using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
//using System.NewtonSoft.Json;

namespace SerializationDemo
{
    public partial class Serialization : Form
    {
        public Serialization()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);

                FileStream fs = new FileStream(@"D:\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - read data from file
                FileStream fs = new FileStream(@"D:\emp.dat", FileMode.Open, FileAccess.Read);
                // step2- deserialized
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Employee employee = new Employee();
                employee = (Employee)binaryFormatter.Deserialize(fs);
                // step3- display
                txtId.Text = employee.Id.ToString();
                txtName.Text = employee.Name;
                txtSalary.Text = employee.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);

                FileStream fs = new FileStream(@"D:\emp.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - read data from file
                FileStream fs = new FileStream(@"D:\emp.xml", FileMode.Open, FileAccess.Read);
                // step2- deserialized
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                Employee employee = new Employee();
                employee = (Employee)xmlSerializer.Deserialize(fs);
                // step3- display
                txtId.Text = employee.Id.ToString();
                txtName.Text = employee.Name;
                txtSalary.Text = employee.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);

                FileStream fs = new FileStream(@"D:\emp.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - read data from file
                FileStream fs = new FileStream(@"D:\emp.soap", FileMode.Open, FileAccess.Read);
                // step2- deserialized
                SoapFormatter soap = new SoapFormatter();
                Employee employee = new Employee();
                employee = (Employee)soap.Deserialize(fs);
                // step3- display
                txtId.Text = employee.Id.ToString();
                txtName.Text = employee.Name;
                txtSalary.Text = employee.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
