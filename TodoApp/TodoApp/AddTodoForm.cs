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

        //public static int todoCnt = 1;

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
            Button new_btnDelete = new Button();
            //Panel new_panel = new Panel();
            FlowLayoutPanel new_panel = new FlowLayoutPanel();
            new_panel.FlowDirection = FlowDirection.LeftToRight;

            LabelManager.todoCnt++;

            new_panel.Size = new System.Drawing.Size(670, 30);
            new_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            new_panel.Name = $"fp{LabelManager.todoCnt}";

            new_ck.Name = $"ck {LabelManager.todoCnt}";
            new_ck.Click += (s, e) => _mainform.chk_CheckedChanged(this, new ck_state(new_ck));
            new_ck.Margin = new Padding(20,2,20,0);
            

            new_title.Text = title;
            //new_title.AutoSize = true;
            new_title.Name = $"title{LabelManager.todoCnt}";
            new_title.Margin = new Padding(20, 5, 20, 0);

            new_date.Text = String.Format("{0:yy/MM/dd(ddd)}", date);
            //new_date.AutoSize = true;
            new_date.Name = $"date{LabelManager.todoCnt}";
            new_date.Margin = new Padding(50, 5, 20, 0);

            new_btnMemo.Click += new System.EventHandler(this.click_memo);
            new_btnMemo.Text = "메모";
            new_btnMemo.Name = $"memobtn{LabelManager.todoCnt}";
            new_btnMemo.Margin = new Padding(50, 3, 0, 0);

            new_btnDelete.Text = "삭제";
            new_btnDelete.Name = $"delete {LabelManager.todoCnt}";

            Todo new_todo = new Todo();

            new_todo.Id = LabelManager.todoCnt;
            new_todo.Title = title;
            new_todo.DeadLine = date;
            new_todo.Memo = txtMemo.Text;

            LabelManager.Todos.Add(new_todo);
            LabelManager.SaveTodo();

            new_btnDelete.Click += new System.EventHandler((object sender, EventArgs e) => {
                _mainform.fPanelTodoList.Controls.Remove(new_panel);
                LabelManager.Todos.Remove(new_todo);
                LabelManager.SaveTodo();
            });

            new_panel.Controls.Add(new_ck);
            new_panel.Controls.Add(new_title);
            new_panel.Controls.Add(new_date);
            new_panel.Controls.Add(new_btnMemo);
            new_panel.Controls.Add(new_btnDelete);

            _mainform.fPanelTodoList.Controls.Add(new_panel);

            

            

            this.Close();

            /*
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
            */
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
