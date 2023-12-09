﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    public class ImageFile
    {
        //проверка и загрузка изображений необходимых для полноценной работы с программой
        //изображения находятся в GitHub
        public static void DownloadImageGitHub()
        {
            //создаём папку для хранения изображений и иконок icon
            Directory.CreateDirectory("icon");
            WebClient client = new WebClient();
            //проверяем существование иконки/картинки
            if (Path.GetFullPath(@"icon\message.ico") != null)
            {
                //скачиваем и сохраняем иконку/картинку в папку icon
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/message.ico"), Path.GetFullPath(@"icon\message.ico"));
            }
            if (Path.GetFullPath(@"icon\category.ico") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/category.ico"), Path.GetFullPath(@"icon\category.ico"));
            }
            if (Path.GetFullPath(@"icon\category-add.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/category-add.png"), Path.GetFullPath(@"icon\category-add.png"));
            }
            if (Path.GetFullPath(@"icon\category-add-and-editing.ico") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/category-add-and-editing.ico"), Path.GetFullPath(@"icon\category-add-and-editing.ico"));
            }
            if (Path.GetFullPath(@"icon\category-close.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/category-close.png"), Path.GetFullPath(@"icon\category-close.png"));
            }
            if (Path.GetFullPath(@"icon\category-delete.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/category-delete.png"), Path.GetFullPath(@"icon\category-delete.png"));
            }
            if (Path.GetFullPath(@"icon\category-editing.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/category-editing.png"), Path.GetFullPath(@"icon\category-editing.png"));
            }
            if (Path.GetFullPath(@"icon\message-no.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/message-no.png"), Path.GetFullPath(@"icon\message-no.png"));
            }
            if (Path.GetFullPath(@"icon\message-warning.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/message-warning.png"), Path.GetFullPath(@"icon\message-warning.png"));
            }
            if (Path.GetFullPath(@"icon\message-yes.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/biblioteka/main/icon/message-yes.png"), Path.GetFullPath(@"icon\message-yes.png"));
            }
        }
    }
}
