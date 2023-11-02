using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedDemo
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;
       
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Dept1";
                da = new SqlDataAdapter(qry, con);
                ds = new DataSet();
                da.Fill(ds, "Dept1");
                cmbDepartment.DataSource = ds.Tables["Dept1"];
                cmbDepartment.DisplayMember = "dname";
                cmbDepartment.ValueMember = "did1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet GetEmployees()
        {
            string qry = "select * from Employee1";
            // assign the query
            da = new SqlDataAdapter(qry, con);
            // when app load the in DataSet, we need to manage the PK also
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // SCB will track the DataSet & update quries to the DataAdapter
            builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Employee1");// this name given to the DataSet table
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                // create new row to add recrod
                DataRow row = ds.Tables["Employee1"].NewRow();
                // assign value to the row
                row["name"] = txtName.Text;
                row["email"] = txtEmail.Text;
                row["age"] = txtAge.Text;
                row["salary"] = txtSalary.Text;
                row["did1"] = cmbDepartment.SelectedValue;
                // attach this row in DataSet table
                ds.Tables["Employee1"].Rows.Add(row);
                // update the changes from DataSet to DB
                int result = da.Update(ds.Tables["Employee1"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                // find the row
                DataRow row = ds.Tables["Employee1"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["email"] = txtEmail.Text;
                    row["age"] = txtAge.Text;
                    row["salary"] = txtSalary.Text;
                    row["did1"] = cmbDepartment.SelectedValue;
                    // update the changes from DataSet to DB
                    int result = da.Update(ds.Tables["Employee1"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                // find the row
                DataRow row = ds.Tables["Employee1"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    // delete the current row from DataSet table
                    row.Delete();
                    // update the changes from DataSet to DB
                    int result = da.Update(ds.Tables["Employee1"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                dataGridView1.DataSource = ds.Tables["Employee1"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string qry = "select e.*, d.dname from Employee1 e inner join dept1 d on d.did1 = e.did1 ";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet();
            da.Fill(ds, "emp");
            //find method can only seach the data if PK is applied in the DataSet table
            DataRow row = ds.Tables["emp"].Rows.Find(txtId.Text);
            if (row != null)
            {
                txtName.Text = row["name"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtAge.Text = row["age"].ToString();
                txtSalary.Text = row["salary"].ToString();
                cmbDepartment.Text = row["dname"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }

        }
    }
}
