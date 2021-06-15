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
            //txtTitle.Text
            String title = txtTitle.Text;
            String memo = txtMemo.Text;
            //dateTimePicker.Value
            DateTime date = dateTimePicker.Value;


            MessageBox.Show(
                        $"{title + memo + date}", "hello", MessageBoxButtons.OK);

            //mainform.panelTodoList.Controls.Add(new Label());
            //panelTodoList
        }
    }
}
