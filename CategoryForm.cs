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
    public partial class CategoryForm : Form
    {
        //добавляем компоненты кнопок добавление/редактирование/удаление/закрытие
        Button btn_add = new Button();
        Button btn_editing = new Button();
        Button btn_delete = new Button();
        Button btn_close = new Button();
        public static DataGridView list_table = new DataGridView();
        CategoryAddEditingForm CategoryAddEditing;
        MessageForm MessageWarning;

        public CategoryForm()
        {
            InitializeComponent();
            //задаём иконку окна и свойства окна
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(452, 477);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //релиз формы, а именно её создание всех элементов окна, кнопок и их иконки
        public void Release_form()
        {
            btn_add.Size = btn_editing.Size = btn_delete.Size = btn_close.Size = new Size(40, 40);
            btn_add.Text = btn_editing.Text = btn_delete.Text = btn_close.Text = "";
            btn_add.Location = new Point(247, 388);
            btn_editing.Location = new Point(293, 388);
            btn_delete.Location = new Point(339, 388);
            btn_close.Location = new Point(385, 388);
            list_table.Size = new Size(413, 370);
            list_table.Location = new Point(12, 12);
            list_table.RowHeadersVisible = false;
            list_table.AllowUserToAddRows = false;
            list_table.AllowUserToDeleteRows = false;
            list_table.ReadOnly = false;
            this.Controls.Add(btn_add);
            this.Controls.Add(btn_editing);
            this.Controls.Add(btn_delete);
            this.Controls.Add(btn_close);
            btn_close.Click += (object senders, EventArgs se) =>
            {
                this.Close();
            };
        }

        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
