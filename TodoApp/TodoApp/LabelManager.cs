using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace TodoApp
{
    class LabelManager
    {
        MainForm _mainForm;
        static public int todoCnt = 1;

        static List<Label> TitleList = new List<Label>();
        static List<Button> MemoList = new List<Button>();
        static List<Label> DateList = new List<Label>();
        static List<CheckBox> CbList = new List<CheckBox>();

        public static List<Todo> Todos = new List<Todo>();


        public LabelManager(MainForm form)
        {
            _mainForm = form;
            GridSet();
            Load();
        }


        public void GridSet()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            _mainForm.gridTodoList.ColumnCount = 4;

            //_mainForm.gridTodoList.Columns.Add(chk);
            //chk.HeaderText = "Check Data";
            //chk.Name = "chk";
            _mainForm.gridTodoList.Columns[0].Name = "check";
            _mainForm.gridTodoList.Columns[1].Name = "title";
            _mainForm.gridTodoList.Columns[2].Name = "deadline";
            _mainForm.gridTodoList.Columns[3].Name = "memo";


            //dataGridView1.Rows[2].Cells[3].Value = true;
        }

        public void Load()
        {
            string XMLTodo = File.ReadAllText(@"./Todos.xml");
            XElement todosXElement = XElement.Parse(XMLTodo);

            Todos = (from item in todosXElement.Descendants("todo")
                     select new Todo()
                     {
                         Id = int.Parse(item.Element("id").Value),
                         Title = item.Element("title").Value,
                         DeadLine = DateTime.Parse(item.Element("deadline").Value),
                         Memo = item.Element("memo").Value,
                     }).ToList<Todo>();

            foreach (Todo td in Todos)
            {
                CheckBox new_ck = new CheckBox();
                Button new_btnMemo = new Button();
             

                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();

                
                new_ck.Name = $"ck{todoCnt}";
                new_ck.Click += (s, e) => _mainForm.chk_CheckedChanged(this, new ck_state(new_ck));

                //checkBoxCell.Name = "chk";
                //_mainForm.gridTodoList.Rows.Add(checkBoxCell);
                _mainForm.gridTodoList.Rows[0].Cells[0] = checkBoxCell;
                _mainForm.gridTodoList.Rows.Add("", td.Title, td.DeadLine, td.Memo);


                todoCnt++;
            }
        }

        static public void addList(Label title, Button memo, Label date, CheckBox cb)
        {
            TitleList.Add(title);
            MemoList.Add(memo);

        }
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
