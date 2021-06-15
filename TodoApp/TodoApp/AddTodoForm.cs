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
            
            DateTime date = dateTimePicker.Value;

            Label new_title = new Label();
            Label new_date = new Label();
            CheckBox new_ck = new CheckBox();
            Button new_btnMemo = new Button();

            new_ck.Location = new Point(150, todoCnt * 30);
            new_ck.Name = $"ck{todoCnt}";
            new_ck.Click += (s, e) => _mainform.chk_CheckedChanged(this, new ck_state(new_ck));
           

            new_title.Text = title;
            new_title.Location = new Point(250, todoCnt * 30);
            new_title.AutoSize = true;
            new_title.Name = $"title{todoCnt}";

            new_date.Text = String.Format("{0:yy/MM/dd(ddd)}", date);
            new_date.Location = new Point(350, todoCnt * 30);
            new_date.AutoSize = true;
            new_date.Name = $"date{todoCnt}";


            new_btnMemo.Click += new System.EventHandler(this.click_memo);
            new_btnMemo.Text = "메모";
            new_btnMemo.Location = new Point(450, todoCnt * 30);
            new_btnMemo.Name = $"memobtn{todoCnt}";


            todoCnt++;

            _mainform.panelTodoList.Controls.Add(new_ck);
            _mainform.panelTodoList.Controls.Add(new_title);
            _mainform.panelTodoList.Controls.Add(new_date);
            _mainform.panelTodoList.Controls.Add(new_btnMemo);

            this.Close();
        }

        private void click_memo(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtMemo.Text}", "memo", MessageBoxButtons.OK);
        }

        public class ck_state : EventArgs
        {
            public CheckBox ck;
            public ck_state(CheckBox ck)
            {
                this.ck = ck;
            }
        }
    }
}
