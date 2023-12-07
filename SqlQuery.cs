using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    public class SqlQuery
    {
        //статические данные переменных
        /*static string filepath = AthenaeumForm.filePath;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + ";Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);*/
        static string BookTable = "table BookTable (id_book int identity (1,1) not null, " + //таблица "книги"
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
            "primary key clustered(id_book asc))";
        static string PublisherTable = "table PublisherTable (id_pusblisher int identity (1,1) not null, " + //таблица издательства книги
            "name nvarchar(50) not null, " + //наименование издетельства
            "description nvarchar(1000) not null, " + //описание
            "primary key clustered(id_pusblisher asc))";
        static string StorageTable = "table StorageTable (id_storage int identity (1,1) not null, " + //таблица места хранения книги
            "name nvarchar(50) not null, " + //наименование места хранения книги
            "primary key clustered(id_storage asc))";
         static string AuthorTable = "table AuthorTable (id_author int identity (1,1) not null, " + //таблица авторов книги
            "name nvarchar(100) not null, " + //ФИО писателя
            "primary key clustered(id_author asc))";
        static string GenreTable = "table GenreTable (id_genre int identity (1,1) not null, " + //таблица жанра книги
            "name nvarchar(50) not null, " + //наименование жанра
            "primary key clustered(id_genre asc))";
        static string TranslatorTable = "table TranslatorTable (id_translator int identity (1,1) not null, " + //таблица переводчика книги
            "name nvarchar(100) not null, " + //наименование переводчика
            "primary key clustered(id_translator asc))";
    }
}
