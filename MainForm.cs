using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class MainForm : Form
    {
        //файл БД хранитс в папке database
        public static string filePath = Path.GetFullPath(@"database\biblioteka.mdf");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //проверяем существует ли файл БД
            if (File.Exists(filePath) == false)
            {
                //создаём директорию database
                Directory.CreateDirectory("database");
                string fullPath = Path.GetFullPath(@"database");
                var filename = System.IO.Path.Combine(fullPath, "biblioteka.mdf");
                //создаём файл БД
                DB.CreateDBFile(filename);
                //создаём таблицы в БД
                SqlQuery.CreateTable();
            }
        }
    }
}
