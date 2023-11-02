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
using System.Data;
using System.Xml.Linq;


namespace ProductCURD
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
                List<Category> list = new List<Category>();
                string qry = "select * from Category";// query to select data from Dept1 table
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category();
                        cat.Cid = Convert.ToInt32(reader["Cid"]);
                        cat.Cat_name = reader["Cat_name"].ToString();
                        list.Add(cat);
                    }
                }
                // display dname & on selection of dname we need did
                cmbCategory.DataSource = list;
                cmbCategory.DisplayMember = "Cat_name";
                cmbCategory.ValueMember = "Cid";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Product3 values(@Pname,@Price,@Cid)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Pname", txtPname.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Cid", Convert.ToInt32(cmbCategory.SelectedValue));
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
                string qry = "select p.*, c.Cat_name from Product3 p inner join Category c on c.Cid = p.Cid where p.Pid=@Pid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Pid", Convert.ToInt32(txtPId.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        txtPname.Text = reader["PName"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        
                        cmbCategory.Text = reader["Cat_name"].ToString();
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
                string qry = "update Product3 set Pname=@Pname,Price=@Price,Cid=@Cid where PId=@PId";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@Pname", txtPname.Text);
                
                cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txtPrice.Text));
                
                cmd.Parameters.AddWithValue("@Cid", Convert.ToInt32(cmbCategory.SelectedValue));
                cmd.Parameters.AddWithValue("@Pid", Convert.ToInt32(txtPId.Text));
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
                string qry = "delete from Product3 where PId=@PId";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Pid", Convert.ToInt32(txtPId.Text));
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
              
            }
            finally
            {
                con.Close();
            }
        }
        private void GetAllProd()
        {
            string qry = "select p.*, c.Cat_name from Product3 p inner join Category c on c.CId = p.CId";
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
            txtPId.Clear();
            txtPname.Clear();
            txtPrice.Clear();
            cmbCategory.Refresh();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllProd();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
