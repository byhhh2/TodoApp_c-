using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class AddTodoForm : Form
    {
        public static int todoCnt = 1;

        MainForm _mainform;

        public AddTodoForm()
        {
            InitializeComponent();
        }

        public AddTodoForm(MainForm form)
        {
            InitializeComponent();
            _mainform = form; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void submit_todo(object sender, EventArgs e)
        {
            String title = txtTitle.Text;
            String memo = txtMemo.Text;
            DateTime date = dateTimePicker.Value;

            Label new_title = new Label();
            Label new_date = new Label();
            CheckBox new_ck = new CheckBox();


            new_ck.Location = new Point(0, todoCnt * 20);

            new_title.Text = title;
            new_title.Location = new Point(100, todoCnt * 20);
            new_title.AutoSize = true;

            new_date.Text = String.Format("{0:yy/MM/dd(ddd)}", date);
            new_date.Location = new Point(200, todoCnt * 20);
            new_date.AutoSize = true;

            todoCnt++;

            _mainform.panelTodoList.Controls.Add(new_ck);
            _mainform.panelTodoList.Controls.Add(new_title);
            _mainform.panelTodoList.Controls.Add(new_date);

            this.Close();
            //panelTodoList
        }
    }
}
