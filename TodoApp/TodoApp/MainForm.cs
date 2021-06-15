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
            //new AddTodoForm().ShowDialog();
            new AddTodoForm(this).ShowDialog();
            //AddTodoForm addTodoForm = new AddTodoForm(this);


        }

        private void add_test(object sender, EventArgs e)
        {
            Label lbl_test = new Label();
            CheckBox ck_test = new CheckBox(); 

            lbl_test.Text = String.Format("testtest{0}", cnt);
            //lbl_test.Name = String.Format("lbl{0}", cnt);
            ck_test.Location = new Point(0, cnt * 20);
            lbl_test.Location = new Point(100, cnt * 20);

            cnt++;

            this.panelTodoList.Controls.Add(ck_test);
            this.panelTodoList.Controls.Add(lbl_test);


            //this.panelTodoList.Controls.Add(new Label().Text = "test");

        }

        
    }
}
