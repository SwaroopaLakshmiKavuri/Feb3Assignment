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

namespace WinLinqToSql
{
    public partial class Form1 : Form
    {
        
        EmployeeDataContextDataContext dbml = new EmployeeDataContextDataContext();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
        SqlCommand cm = null;
        SqlDataAdapter da = null;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowEmployee()
        {
            var emptab = from e1 in dbml.EmployeeTabs
                         select e1;
            dataGridView1.DataSource = emptab;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployee();
            //var emptab = dbml.EmployeeTabs.Where(e1 => e1.EmpName.StartsWith("P") && e1.Salary > 2000).
            //    GroupBy(e1=>e1.DeptNo).
            //    OrderByDescending(e1 => e1.EmpName);
        }


        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            var empDetails = dbml.sp_ShowEmpDetails(Convert.ToInt32(txtEmpId.Text));
            dataGridView1.DataSource = empDetails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? count = 0;
            var empCount = dbml.sp_WithOutPutParameter(ref count);
            lblCount.Text += ":" + count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delEmp = dbml.EmployeeTabs.Single(p => p.EmpId == Convert.ToInt32(txtEmpId.Text));
            dbml.EmployeeTabs.DeleteOnSubmit(delEmp);
            dbml.SubmitChanges();
            ShowEmployee();

        }

        private void btnSpInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("sp_InsertEmp", cn);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@ename", SqlDbType.VarChar, 20).Value = txtempname.Text;
                cm.Parameters.Add("@sal", SqlDbType.Float).Value = txtSalary.Text;
                cm.Parameters.Add("@dno", SqlDbType.Int).Value = txtdeptno.Text;
                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                ShowEmployee();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("sp_UpdateEmp", cn);
                cn.Open();
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@empid", SqlDbType.VarChar, 20).Value = txtEmpId.Text;

                cm.Parameters.Add("@ename", SqlDbType.VarChar, 20).Value = txtempname.Text;
                cm.Parameters.Add("@sal", SqlDbType.Float).Value = txtSalary.Text;
                cm.Parameters.Add("@dno", SqlDbType.Int).Value = txtdeptno.Text;


                cm.ExecuteNonQuery();
                MessageBox.Show("Rcord updated");
                ShowEmployee();
                txtEmpId.Text = "";
                lblempname.Text = "";
                lblSalary.Text = "";


                cn.Open();
               
                cm.ExecuteNonQuery();

                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                ShowEmployee();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           
            
        }

        private void btnDeleteSp_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("sp_DeleteEmp", cn);

                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@empid", txtEmpId.Text);


               
                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                ShowEmployee();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

