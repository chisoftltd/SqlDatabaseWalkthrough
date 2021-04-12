using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrough
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingSource binder = new BindingSource();

        public string conString { get; private set; }
        public int studentIdValue { get; private set; }
        public SqlCommand cmd { get; private set; }
        public SqlDataAdapter adapter { get; private set; }
        public DataTable dataTable { get; private set; }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            conString = Properties.Settings.Default.SDB;
            using (SqlConnection con = new SqlConnection(conString))
            {
                cmd = new SqlCommand("NamesAndCourses", con);

                adapter = new SqlDataAdapter(cmd);

                dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = binder;

                binder.DataSource = dataTable;

                //MessageBox.Show("All OK");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conString = Properties.Settings.Default.SDB;
            
            using (SqlConnection con = new SqlConnection(conString))
            {
                cmd = new SqlCommand("GetStudentByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("GetStudentID", studentIdValue));

                adapter = new SqlDataAdapter(cmd);

                dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = binder;

                binder.DataSource = dataTable;

            }
        }

        private void txtStudentID_Validated(object sender, EventArgs e)
        {
            if (int.Parse(txtStudentID.Text) == 0 || int.Parse(txtStudentID.Text).ToString() == null)
            {
                MessageBox.Show("Enter Student ID");
            }
            else
            {
                btnSearch.Enabled = true;
                studentIdValue = int.Parse(txtStudentID.Text);
            }
        }
    }
}
