using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
