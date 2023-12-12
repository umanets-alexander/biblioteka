﻿namespace biblioteka
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеКатегориямиВыборкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издательстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиотекариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.популярныйАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.популярныйЖанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.популярныеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентыНеПользующиесяУслугойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.управлениеКатегориямиВыборкиToolStripMenuItem,
            this.управлениеДаннымиToolStripMenuItem,
            this.вывестиИнформациюToolStripMenuItem,
            this.бДToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // управлениеКатегориямиВыборкиToolStripMenuItem
            // 
            this.управлениеКатегориямиВыборкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.издательстваToolStripMenuItem,
            this.местаХраненияToolStripMenuItem,
            this.жанрыToolStripMenuItem,
            this.авторыToolStripMenuItem,
            this.переводчикиToolStripMenuItem});
            this.управлениеКатегориямиВыборкиToolStripMenuItem.Name = "управлениеКатегориямиВыборкиToolStripMenuItem";
            this.управлениеКатегориямиВыборкиToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.управлениеКатегориямиВыборкиToolStripMenuItem.Text = "Управление категориями выборки";
            // 
            // издательстваToolStripMenuItem
            // 
            this.издательстваToolStripMenuItem.Name = "издательстваToolStripMenuItem";
            this.издательстваToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.издательстваToolStripMenuItem.Text = "Издательства";
            this.издательстваToolStripMenuItem.Click += new System.EventHandler(this.издательстваToolStripMenuItem_Click);
            // 
            // местаХраненияToolStripMenuItem
            // 
            this.местаХраненияToolStripMenuItem.Name = "местаХраненияToolStripMenuItem";
            this.местаХраненияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.местаХраненияToolStripMenuItem.Text = "Места хранения";
            this.местаХраненияToolStripMenuItem.Click += new System.EventHandler(this.местаХраненияToolStripMenuItem_Click);
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            this.жанрыToolStripMenuItem.Click += new System.EventHandler(this.жанрыToolStripMenuItem_Click);
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.авторыToolStripMenuItem.Text = "Авторы";
            // 
            // переводчикиToolStripMenuItem
            // 
            this.переводчикиToolStripMenuItem.Name = "переводчикиToolStripMenuItem";
            this.переводчикиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.переводчикиToolStripMenuItem.Text = "Переводчики";
            // 
            // управлениеДаннымиToolStripMenuItem
            // 
            this.управлениеДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читателиToolStripMenuItem,
            this.библиотекариToolStripMenuItem});
            this.управлениеДаннымиToolStripMenuItem.Name = "управлениеДаннымиToolStripMenuItem";
            this.управлениеДаннымиToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.управлениеДаннымиToolStripMenuItem.Text = "Управление данными";
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // библиотекариToolStripMenuItem
            // 
            this.библиотекариToolStripMenuItem.Name = "библиотекариToolStripMenuItem";
            this.библиотекариToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.библиотекариToolStripMenuItem.Text = "Библиотекари";
            // 
            // вывестиИнформациюToolStripMenuItem
            // 
            this.вывестиИнформациюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.популярныйАвторToolStripMenuItem,
            this.популярныйЖанрToolStripMenuItem,
            this.популярныеКнигиToolStripMenuItem,
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem,
            this.должникиToolStripMenuItem,
            this.абонентыНеПользующиесяУслугойToolStripMenuItem});
            this.вывестиИнформациюToolStripMenuItem.Name = "вывестиИнформациюToolStripMenuItem";
            this.вывестиИнформациюToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.вывестиИнформациюToolStripMenuItem.Text = "Вывести информацию";
            // 
            // популярныйАвторToolStripMenuItem
            // 
            this.популярныйАвторToolStripMenuItem.Name = "популярныйАвторToolStripMenuItem";
            this.популярныйАвторToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.популярныйАвторToolStripMenuItem.Text = "Популярный автор";
            // 
            // популярныйЖанрToolStripMenuItem
            // 
            this.популярныйЖанрToolStripMenuItem.Name = "популярныйЖанрToolStripMenuItem";
            this.популярныйЖанрToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.популярныйЖанрToolStripMenuItem.Text = "Популярный жанр";
            // 
            // популярныеКнигиToolStripMenuItem
            // 
            this.популярныеКнигиToolStripMenuItem.Name = "популярныеКнигиToolStripMenuItem";
            this.популярныеКнигиToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.популярныеКнигиToolStripMenuItem.Text = "Популярные книги";
            // 
            // книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem
            // 
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem.Name = "книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem";
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem.Text = "Наименее популярные книги";
            // 
            // должникиToolStripMenuItem
            // 
            this.должникиToolStripMenuItem.Name = "должникиToolStripMenuItem";
            this.должникиToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.должникиToolStripMenuItem.Text = "Должники";
            // 
            // абонентыНеПользующиесяУслугойToolStripMenuItem
            // 
            this.абонентыНеПользующиесяУслугойToolStripMenuItem.Name = "абонентыНеПользующиесяУслугойToolStripMenuItem";
            this.абонентыНеПользующиесяУслугойToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.абонентыНеПользующиесяУслугойToolStripMenuItem.Text = "Абоненты не пользующиеся услугой";
            // 
            // бДToolStripMenuItem
            // 
            this.бДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сброситьБДToolStripMenuItem,
            this.удалитьБДToolStripMenuItem});
            this.бДToolStripMenuItem.Name = "бДToolStripMenuItem";
            this.бДToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.бДToolStripMenuItem.Text = "БД";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить БД";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить БД";
            // 
            // сброситьБДToolStripMenuItem
            // 
            this.сброситьБДToolStripMenuItem.Name = "сброситьБДToolStripMenuItem";
            this.сброситьБДToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.сброситьБДToolStripMenuItem.Text = "Сбросить БД";
            // 
            // удалитьБДToolStripMenuItem
            // 
            this.удалитьБДToolStripMenuItem.Name = "удалитьБДToolStripMenuItem";
            this.удалитьБДToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.удалитьБДToolStripMenuItem.Text = "Создать новую БД";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Библиотека";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеКатегориямиВыборкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem издательстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаХраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переводчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem библиотекариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem популярныйАвторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem популярныйЖанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыНеПользующиесяУслугойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem популярныеКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

