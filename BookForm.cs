using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        public void SQL_Select(string names)
        {
            string filepath = MainForm.filePath; //путь к файлу
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + ";Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select id, name from " + names + "  order by name", sqlConnection);
            DataSet dt = new DataSet();
            dt.Clear();
            cmd.Fill(dt, names);
            if (names == "AuthorTable")
            {
                comboBox1.DataSource = dt.Tables[0].DefaultView;
                comboBox1.DisplayMember = dt.Tables[0].Columns["name"].ToString();
                comboBox1.ValueMember = dt.Tables[0].Columns["id"].ToString();
                comboBox1.SelectedItem = "";
                comboBox1.Refresh();
            }
            else if (names == "GenreTable")
            {
                comboBox2.DataSource = dt.Tables[0].DefaultView;
                comboBox2.DisplayMember = dt.Tables[0].Columns["name"].ToString();
                comboBox2.ValueMember = dt.Tables[0].Columns["id"].ToString();
                comboBox2.SelectedItem = "";
                comboBox2.Refresh();
            }
            else if (names == "StorageTable")
            {
                comboBox4.DataSource = dt.Tables[0].DefaultView;
                comboBox4.DisplayMember = dt.Tables[0].Columns["name"].ToString();
                comboBox4.ValueMember = dt.Tables[0].Columns["id"].ToString();
                comboBox4.SelectedItem = "";
                comboBox4.Refresh();
            }
            else if (names == "PublisherTable")
            {
                comboBox5.DataSource = dt.Tables[0].DefaultView;
                comboBox5.DisplayMember = dt.Tables[0].Columns["name"].ToString();
                comboBox5.ValueMember = dt.Tables[0].Columns["id"].ToString();
                comboBox5.SelectedItem = "";
                comboBox5.Refresh();
            }
            else if (names == "TranslatorTable")
            {
                comboBox6.DataSource = dt.Tables[0].DefaultView;
                comboBox6.DisplayMember = dt.Tables[0].Columns["name"].ToString();
                comboBox6.ValueMember = dt.Tables[0].Columns["id"].ToString();
                comboBox6.SelectedItem = "";
                comboBox6.Refresh();
            }
            sqlConnection.Close();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            SQL_Select("AuthorTable");
            SQL_Select("GenreTable");
            SQL_Select("StorageTable");
            SQL_Select("PublisherTable");
            SQL_Select("TranslatorTable");
        }
    }
}
