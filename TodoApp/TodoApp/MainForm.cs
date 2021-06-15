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
        public event EventHandler ck_eventHandler;

        public static int cnt = 1;

        public MainForm()
        {
            InitializeComponent();
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

        public void chk_CheckedChanged(object sender, EventArgs e) //영화 
        {
            AddTodoForm form = (AddTodoForm)sender;
            //CheckBox form_ = (CheckBox)sender;
            //ck_state
            //String name = ((AddTodoForm)sender).Name;
            //MessageBox.Show($"{name}");

            CheckBox _ck = (e as AddTodoForm.ck_state).ck;

            change_state_todo(_ck);
        }

        public void change_state_todo(CheckBox cb)
        {
            if (cb.Checked)
            {
                MessageBox.Show($"{cb.Name}");
            }
        }


    }
}
