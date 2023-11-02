using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;




namespace ConnectedDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Dept1> list = new List<Dept1>();
                string qry = "select * from Dept1";// query to select data from Dept1 table
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dept1 dept = new Dept1();
                        dept.Did = Convert.ToInt32(reader["did1"]);
                        dept.Dname = reader["dname"].ToString();
                        list.Add(dept);
                    }
                }
                // display dname & on selection of dname we need did
                cmbDepartment.DataSource = list;
                cmbDepartment.DisplayMember = "Dname";
                cmbDepartment.ValueMember = "Did";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee1 values(@name,@email,@age,@salary,@did1)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                cmd.Parameters.AddWithValue("@did1", Convert.ToInt32(cmbDepartment.SelectedValue));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select e.*, d.dname from Employee1 e inner join dept1 d on d.did1 = e.did1 where e.id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        txtName.Text = reader["name"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtAge.Text = reader["age"].ToString();
                        txtSalary.Text = reader["salary"].ToString();
                        cmbDepartment.Text = reader["dname"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Employee1 set name=@name,email=@email,age=@age,salary=@salary,did1=@did1 where id=@id";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                cmd.Parameters.AddWithValue("@did1", Convert.ToInt32(cmbDepartment.SelectedValue));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Employee1 where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearFields();
            }
            finally
            {
                con.Close();
            }
        }

        private void GetAllEmps()
        {
            string qry = "select e.*, d.dname from Employee1 e inner join dept1 d on d.did1 = e.did1";
            cmd = new SqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtAge.Clear();
            txtSalary.Clear();
            cmbDepartment.Refresh();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllEmps();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


