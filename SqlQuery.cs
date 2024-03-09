using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace biblioteka
{
    public class SqlQuery
    {
        //статические данные переменных
        static string filepath = MainForm.filePath; //путь к файлу
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + ";Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        static string BookTable = "table BookTable (id int identity (1,1) not null, " + //таблица "книги"
            "ISBN bigint not null, " + //ISBN — уникальный номер книжного издания, необходимый для распространения книги в торговых сетях и автоматизации работы с изданием.
            "publisher int not null, " + //издательство книги
            "storage int not null, " + //место хранения книги
            "author bigint not null, " + //автор книги
            "name_book nvarchar(50) not null, " + //название книги
            "numb_pages int not null, " + //количество страниц книги
            "genre bigint not null, " + //жанр книги
            "age_book nvarchar(3) not null, " + //возрастное ограничение книги
            "num_stock int not null, " + //количество книг на складе
            "num_issued int default((0)) null, " + //количество книг выданных на текущий момент
            "year_book int not null, " + //год книги
            "release_date int not null, " + //релиз книги в годах 
            "translate_date int not null, " + //год перевода оригинала книги
            "translator int not null, " + //переводчик книги
            "description nvarchar(1000) null, " + //описание книги
            "primary key clustered(id asc))";
        static string PublisherTable = "table PublisherTable (id int identity (1,1) not null, " + //таблица издательства книги
            "name nvarchar(50) not null, " + //наименование издетельства
            "description nvarchar(1000) not null, " + //описание
            "primary key clustered(id asc))";
        static string StorageTable = "table StorageTable (id int identity (1,1) not null, " + //таблица места хранения книги
            "name nvarchar(50) not null, " + //наименование места хранения книги
            "primary key clustered(id asc))";
         static string AuthorTable = "table AuthorTable (id int identity (1,1) not null, " + //таблица авторов книги
            "name nvarchar(100) not null, " + //ФИО писателя
            "primary key clustered(id asc))";
        static string GenreTable = "table GenreTable (id int identity (1,1) not null, " + //таблица жанра книги
            "name nvarchar(50) not null, " + //наименование жанра
            "primary key clustered(id asc))";
        static string TranslatorTable = "table TranslatorTable (id int identity (1,1) not null, " + //таблица переводчика книги
            "name nvarchar(100) not null, " + //наименование переводчика
            "primary key clustered(id asc))";
        static string LibrarianTable = "table LibrarianTable (id int identity (1,1) not null, " + //таблица библиотекарей
            "surname nvarchar(100) not null, " + //фамилия библиотекаря
            "name nvarchar(100) not null, " + //имя библиотекаря
            "patronymic nvarchar(100) null, " + //отчество библиотекаря
            "primary key clustered(id asc))";
        static string SubscriberTable = "table SubscriberTable (id int identity (1,1) not null, " + //таблица читателя
            "surname nvarchar(100) not null, " + //фамилия читателя
            "name nvarchar(100) not null, " + //имя читателя
            "patronymic nvarchar(100) null, " + //отчество читателя
            "date_birthday  nvarchar(50) not null, " + //дата рождения читателя
            "home_address nvarchar(300) null, " + //адрес читателя
            "passport nvarchar(100) null, " + //номер паспорта читателя
            "place_work nvarchar(100) null, " + //место работы читателя
            "telephone nvarchar(20) null, " + //телефон читателя
            "primary key clustered(id asc))";
        static string IssuingTable = "table IssuingTable (id int identity (1,1) not null, " + //таблица выдавших книг читателю
            "librian_issue bigint not null, " + //количество выданных книг
            "librian_return bigint null, " + //количество задолжений книг
            "subscriber bigint not null, " + //читатель
            "ISBN bigint not null, " + //номер ISBN книги
            "date_issue datetime not null, " + //дата взятия книги с библиотеки
            "date_return datetime null, " + //дата возвращения книги в библиотеку
            "primary key clustered(id asc))";

        //запрос создающий все таблицы в БД
        public static void CreateTable()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("create " + BookTable + "; create " + PublisherTable + "; create " + StorageTable +
                "; create " + AuthorTable + "; create " + GenreTable +
                "; create " + TranslatorTable + "; create " + IssuingTable + "; create " + SubscriberTable + "; create " + LibrarianTable + ";", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //запрос загружающий все данные для просмотра записей категорий
        public static void UpdateCategory(string namecategory)
        {
            sqlConnection.Open();
            SqlDataReader sqlReader = null;
            CategoryForm.list_table.Rows.Clear();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("select * from GenreTable order by name", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("select * from StorageTable order by name", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("select * from AuthorTable order by name", sqlConnection);
            else if (namecategory == "Translator")
                cmd = new SqlCommand("select * from TranslatorTable order by name", sqlConnection);
            else if (namecategory == "Publisher")
                cmd = new SqlCommand("select * from PublisherTable order by name", sqlConnection);
            else if (namecategory == "Readers")
                cmd = new SqlCommand("select * from SubscriberTable order by name", sqlConnection);
            try
            {
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (namecategory == "Publisher")
                        CategoryForm.list_table.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["description"]));
                    else
                        CategoryForm.list_table.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            sqlConnection.Close();
        }

        //запрос загружающий все данные для просмотра записей данных
        public static void UpdateInformation(string nameinformation)
        {
            sqlConnection.Open();
            SqlDataReader sqlReader = null;
            InformationForm.list_table.Rows.Clear();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (nameinformation == "Readers")
                cmd = new SqlCommand("select * from SubscriberTable order by surname", sqlConnection);
            else
                cmd = new SqlCommand("select * from StorageTable order by name", sqlConnection);
            try
            {
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (nameinformation == "Readers")
                        InformationForm.list_table.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["surname"]) + " " + Convert.ToString(sqlReader["name"]) + " " + Convert.ToString(sqlReader["patronymic"]), Convert.ToString(sqlReader["date_birthday"]), Convert.ToString(sqlReader["home_address"]), Convert.ToString(sqlReader["passport"]), Convert.ToString(sqlReader["place_work"]), Convert.ToString(sqlReader["telephone"]));
                    else
                        InformationForm.list_table.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            sqlConnection.Close();
        }


        //запрос для добавления новой записи категории
        public static void AddCategory(string namecategory, string textcategory_one, string textcategory_two)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("insert into GenreTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("insert into StorageTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("insert into AuthorTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Translator")
                cmd = new SqlCommand("insert into TranslatorTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Publisher")
                cmd = new SqlCommand("insert into PublisherTable (name, description) values (@name, @description)", sqlConnection);
            if (namecategory == "Publisher")
            {
                cmd.Parameters.AddWithValue("name", textcategory_one);
                cmd.Parameters.AddWithValue("description", textcategory_two);
            }
            else
                cmd.Parameters.AddWithValue("name", textcategory_one);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //запрос для добавления и редактирования записи информации о читателях
        public static void AllSubscriber(string namecategory, string textinformation_one, string textinformation_two, string textinformation_three, string textinformation_four, string textinformation_five, string textinformation_six, string textinformation_seven, string textinformation_eight)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection);
            if (namecategory == "Add")
                cmd = new SqlCommand("insert into SubscriberTable (surname, name, patronymic, date_birthday, home_address, passport, place_work, telephone) values (@surname, @name, @patronymic, @date_birthday, @home_address, @passport, @place_work, @telephone)", sqlConnection);
            else
                cmd = new SqlCommand("update SubscriberTable set surname=@surname, name=@name, patronymic=@patronymic, date_birthday=@date_birthday, home_address=@home_address, passport=@passport, place_work=@place_work, telephone=@telephone where id=@id", sqlConnection);
            cmd.Parameters.AddWithValue("surname", textinformation_one);
            cmd.Parameters.AddWithValue("name", textinformation_two);
            cmd.Parameters.AddWithValue("patronymic", textinformation_three);
            cmd.Parameters.AddWithValue("date_birthday", textinformation_four);
            cmd.Parameters.AddWithValue("home_Address", textinformation_five);
            cmd.Parameters.AddWithValue("passport", textinformation_six);
            cmd.Parameters.AddWithValue("place_work", textinformation_seven);
            cmd.Parameters.AddWithValue("telephone", textinformation_eight);
            cmd.Parameters.AddWithValue("id", InformationForm.list_table[0, InformationForm.list_table.CurrentRow.Index].Value.ToString());
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //запрос на редактирование записи
        public static void EditingCategory(string namecategory, string textcategory_one, string textcategory_two)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("update GenreTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("update StorageTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("update AuthorTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Translator")
                cmd = new SqlCommand("update TranslatorTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Publisher")
                cmd = new SqlCommand("update PublisherTable set name=@name, description=@description where id=@id", sqlConnection);
            if (namecategory == "Publisher")
            {
                cmd.Parameters.AddWithValue("name", textcategory_one);
                cmd.Parameters.AddWithValue("description", textcategory_two);
                cmd.Parameters.AddWithValue("id", CategoryForm.list_table[0, CategoryForm.list_table.CurrentRow.Index].Value.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("name", textcategory_one);
                cmd.Parameters.AddWithValue("id", CategoryForm.list_table[0, CategoryForm.list_table.CurrentRow.Index].Value.ToString());
            }
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //запрос на удаление записи
        public static void DeleteCategory(string namecategory, int key)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("delete from GenreTable where id=@id", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("delete from StorageTable where id=@id", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("delete from AuthorTable where id=@id", sqlConnection);
            else if (namecategory == "Translator")
                cmd = new SqlCommand("delete from TranslatorTable where id=@id", sqlConnection);
            else if (namecategory == "Publisher")
                cmd = new SqlCommand("delete from PublisherTable where id=@id", sqlConnection);
            else if (namecategory == "Readers")
                cmd = new SqlCommand("delete from SubscriberTable where id=@id", sqlConnection);
            cmd.Parameters.AddWithValue("id", key);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //запрос на получение ФИО читателя для окна редактирования
        public static void FIOReaders()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            cmd = new SqlCommand("select surname, name, patronymic from SubscriberTable where id=" + InformationForm.list_table[0, InformationForm.list_table.CurrentRow.Index].Value.ToString(), sqlConnection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                InformationAddEditingForm.textbox_one.Text = sdr["surname"].ToString();
                InformationAddEditingForm.textbox_two.Text = sdr["name"].ToString();
                InformationAddEditingForm.textbox_three.Text = sdr["patronymic"].ToString();
            }
            sqlConnection.Close();
        }

        //запрос на получение списка в combobox
        public static void ListComboBox()
        {
            BookForm BookAddForm;
            BookAddForm = new BookForm();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection);
            cmd = new SqlCommand("select * from AuthorTable order by name", sqlConnection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //BookAddForm.comboBox1.Items.Add(namelist);
                BookAddForm.comboBox1.Items.Add(Convert.ToString(sdr["name"]));
            }
            sqlConnection.Close();
        }
    }
}
