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
    public partial class MainForm : Form
    {
        LabelManager manager;

        public static int cnt = 1;

        public MainForm()
        {
            InitializeComponent();
            manager = new LabelManager(this); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new AddTodoForm(this).ShowDialog();
        }

        public void chk_CheckedChanged(object sender, EventArgs e) 
        {
            CheckBox _ck = null;

            if (sender is TodoApp.AddTodoForm)
            {
                _ck = (e as AddTodoForm.ck_state).ck;
            }
            else if (sender is TodoApp.LabelManager)
            {
                _ck = (e as LabelManager.ck_state).ck;
            }
            
            change_state_todo(_ck);
        }


        public void change_state_todo(CheckBox cb)
        {
            if (cb.Checked)
            {
                string[] NameString = cb.Name.Split('\x020');
                int todoNum = int.Parse(NameString[1]);

                Control c = GetControlByName($"fp{todoNum}");

                if (c != null) 
                {
                    fPanelTodoList.Controls.Remove(c);
                }
                else
                {
                    MessageBox.Show($"{todoNum}");
                }


                Todo todo = null;
                Done new_done = new Done();


                new_done.Id = LabelManager.doneCnt;


                foreach (Todo td in LabelManager.Todos)
                {
                    
                    if (td.Id == todoNum)
                    {
                        todo = td;
                    }
                }

                new_done.Title = todo.Title;
                new_done.Memo = todo.Memo;
                new_done.DeadLine = todo.DeadLine;

                LabelManager.doneCnt++;

                LabelManager.Todos.Remove(todo);
                LabelManager.Dones.Add(new_done);

                LabelManager.SaveDone();
                LabelManager.SaveTodo();

                manager.addDone(new_done);
            }
        }

        public Control GetControlByName(string Name)
        {
            foreach (Control c in this.fPanelTodoList.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }

        private void click_alarm(object sender, EventArgs e)
        {
            new Alarm(this).Show();
        }
    }
}
