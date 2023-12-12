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
            //скачивание всех иконок и картинок необходимых для полноценной работы
            ImageFile.DownloadImageGitHub();
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            //заполняем новую форму необходимыми элементами
            Category.Release_form();
            //заполняем необходимыми свойствами форму
            Category.Publisher();
            //запускаем окно просмотра
            Category.Show();
            //выполняем запрос на загрузку данных БД
            SqlQuery.UpdateCategory("Publisher");
        }

        //открываем окно для просмотра списка мест хранения книг
        private void местаХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Storage();
            Category.Show();
            SqlQuery.UpdateCategory("Storage");
        }
    }
}
