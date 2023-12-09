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
    public partial class InformationForm : Form
    {
        //добавляем компоненты кнопок добавление/редактирование/удаление/закрытие
        Button btn_add = new Button();
        Button btn_editing = new Button();
        Button btn_delete = new Button();
        Button btn_close = new Button();
        public static DataGridView list_table = new DataGridView();

        public InformationForm()
        {
            InitializeComponent();
            //задаём иконку окна и свойства окна
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(663, 438);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
