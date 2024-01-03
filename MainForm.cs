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
            btn_add.Image = Image.FromFile(Path.GetFullPath(@"icon\category-add.png"));
            btn_editing.Image = Image.FromFile(Path.GetFullPath(@"icon\category-editing.png"));
            btn_delete.Image = Image.FromFile(Path.GetFullPath(@"icon\category-delete.png"));
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

        //открываем окно для просмотра списка жанра книг
        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Genre();
            Category.Show();
            SqlQuery.UpdateCategory("Genre");
        }

        //открываем окно для просмотра списка авторов
        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Author();
            Category.Show();
            SqlQuery.UpdateCategory("Author");
        }

        //открываем окно для просмотра списка переводчиков книг
        private void переводчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Translator();
            Category.Show();
            SqlQuery.UpdateCategory("Translator");
        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm Information;
            Information = new InformationForm();
            Information.Release_form();
            Information.Readers();
            Information.Show();
            SqlQuery.UpdateInformation("Readers");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BookForm BookF;
            BookF = new BookForm();
            BookF.Show();
        }
    }
}
