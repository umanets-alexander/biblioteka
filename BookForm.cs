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

        public void SQL_Select(string names, int i)
        {
            string filepath = MainForm.filePath; //путь к файлу
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + ";Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select id, name from " + names + "  order by name", sqlConnection);
            DataSet dt = new DataSet();
            dt.Clear();
            ComboBox[] boxes = this.Controls.OfType<ComboBox>().ToArray();
            boxes[i].DataSource = null;
            cmd.Fill(dt, names);
            boxes[i].DataSource = dt.Tables[0].DefaultView;
            boxes[i].DisplayMember = dt.Tables[0].Columns["name"].ToString();
            boxes[i].ValueMember = dt.Tables[0].Columns["id"].ToString();
            boxes[i].SelectedItem = "";
            boxes[i].Refresh();
            sqlConnection.Close();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            SQL_Select("AuthorTable",0);
            SQL_Select("GenreTable", 5);
            SQL_Select("StorageTable", 3);
            SQL_Select("PublisherTable", 2);
            SQL_Select("TranslatorTable", 1);
        }
    }
}
