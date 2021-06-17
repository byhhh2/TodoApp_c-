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
        DateTime nowTime;
        static public int todoCnt = 1;
        static public int doneCnt = 1;

        static List<Label> TitleList = new List<Label>();
        static List<Button> MemoList = new List<Button>();
        static List<Label> DateList = new List<Label>();
        static List<CheckBox> CbList = new List<CheckBox>();

        public static List<Todo> Todos = new List<Todo>();
        public static List<Done> Dones = new List<Done>();


        public LabelManager(MainForm form)
        {
            _mainForm = form;
            //GridSet();
            LoadTodo();
            LoadDone();
            LoadTimer();
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

        public void LoadTodo()
        {
            string XMLTodo = File.ReadAllText(@"./Todos.xml");
            XElement todosXElement = XElement.Parse(XMLTodo);

           //todoCnt = todosXElement.Descendants("todoNum");

            todoCnt = int.Parse(todosXElement.Element("todoNum").Value);

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
                addTodo(td);
                /*
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
                */
            }
        }


        public void LoadDone()
        {
            string XMLTodo = File.ReadAllText(@"./Dones.xml");
            XElement todosXElement = XElement.Parse(XMLTodo);

            Dones = (from item in todosXElement.Descendants("done")
                     select new Done()
                     {
                         Id = int.Parse(item.Element("id").Value),
                         Title = item.Element("title").Value,
                         DeadLine = DateTime.Parse(item.Element("deadline").Value),
                         Memo = item.Element("memo").Value,
                     }).ToList<Done>();

            foreach (Done done in Dones)
            {
                addDone(done);
            }
        }

        public static void SaveTodo()
        {
            string todo_string = "";
            todo_string += "<todos>\n";
            todo_string += $"<todoNum>{todoCnt}</todoNum>\n";//
            foreach (Todo todo in Todos)
            {
                todo_string += "<todo>\n";
                todo_string += "  <id>" + todo.Id + "</id>\n";
                todo_string += "  <title>" + todo.Title + "</title>\n";
                todo_string += "  <deadline>" + todo.DeadLine.ToLongDateString() + "</deadline>\n";
                todo_string += "  <memo>" + todo.Memo + "</memo>\n";
                todo_string += "</todo>\n";
            }
            todo_string += "</todos>";


            // 저장
            File.WriteAllText(@"./Todos.xml", todo_string);
            //File.AppendAllText
        }

        public static void SaveDone()
        {
            string done_string = "";
            done_string += "<dones>\n";
            foreach (Done done in Dones)
            {
                done_string += "<done>\n";
                done_string += "  <id>" + done.Id + "</id>\n";
                done_string += "  <title>" + done.Title + "</title>\n";
                done_string += "  <deadline>" + done.DeadLine.ToLongDateString() + "</deadline>\n";
                done_string += "  <memo>" + done.Memo + "</memo>\n";
                done_string += "</done>\n";
            }
            done_string += "</dones>";


            // 저장
            File.WriteAllText(@"./Dones.xml", done_string);
        }

        public void addTodo(Todo todo)
        {
   
            String title = todo.Title;
            DateTime date = todo.DeadLine;

            Label new_title = new Label();
            Label new_date = new Label();
            CheckBox new_ck = new CheckBox();
            Button new_btnMemo = new Button();
            Button new_btnDelete = new Button();

            FlowLayoutPanel new_panel = new FlowLayoutPanel();
            new_panel.FlowDirection = FlowDirection.LeftToRight;


            new_panel.Size = new System.Drawing.Size(670, 30);
            new_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            new_panel.Name = $"fp{todo.Id}";

            new_ck.Name = $"ck {todo.Id}";
            new_ck.Click += (s, e) => _mainForm.chk_CheckedChanged(this, new ck_state(new_ck));
            new_ck.Margin = new Padding(20, 2, 20, 0);


            new_title.Text = title;
            new_title.Name = $"title{todo.Id}";
            new_title.Margin = new Padding(20, 5, 20, 0);

            new_date.Text = String.Format("{0:yy/MM/dd(ddd)}", date);
            new_date.Name = $"date{todo.Id}";
            new_date.Margin = new Padding(50, 5, 20, 0);

            new_btnMemo.Click += new System.EventHandler((object sender, EventArgs e) => {
                MessageBox.Show($"{todo.Memo}", "memo", MessageBoxButtons.OK);
            });
            new_btnMemo.Text = "메모";
            new_btnMemo.Name = $"memobtn{todo.Id}";
            new_btnMemo.Margin = new Padding(50, 3, 0, 0);

            new_btnDelete.Text = "삭제";
            new_btnDelete.Name = $"delete {todo.Id}";
            
            //
            new_btnDelete.Click += new System.EventHandler((object sender, EventArgs e) => {
                _mainForm.fPanelTodoList.Controls.Remove(new_panel);
                Todos.Remove(todo);
                SaveTodo();
            });


            //todoCnt++;

            new_panel.Controls.Add(new_ck);
            new_panel.Controls.Add(new_title);
            new_panel.Controls.Add(new_date);
            new_panel.Controls.Add(new_btnMemo);
            new_panel.Controls.Add(new_btnDelete);

            _mainForm.fPanelTodoList.Controls.Add(new_panel);
            
        }

        public void addDone(Done done)
        {
            String title = done.Title;
            DateTime date = done.DeadLine;

            Label new_title = new Label();
            Label new_date = new Label();
            //CheckBox new_ck = new CheckBox();
            Button new_btnMemo = new Button();
            FlowLayoutPanel new_panel = new FlowLayoutPanel();
            new_panel.FlowDirection = FlowDirection.LeftToRight;


            new_panel.Size = new System.Drawing.Size(690, 30);
            new_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            new_panel.Name = $"fp{todoCnt}";

            //new_ck.Name = $"ck {todoCnt}";
            //new_ck.Click += (s, e) => _mainForm.chk_CheckedChanged(this, new ck_state(new_ck));
            //new_ck.Margin = new Padding(20, 2, 20, 0);


            new_title.Text = "✔    " + title;
            new_title.Name = $"title{todoCnt}";
            new_title.Margin = new Padding(20, 5, 80, 0);

            new_date.Text = String.Format("{0:yy/MM/dd(ddd)}", date);
            new_date.Name = $"date{todoCnt}";
            new_date.Margin = new Padding(50, 5, 70, 0);

            new_btnMemo.Click += new System.EventHandler((object sender, EventArgs e) => {
                MessageBox.Show($"{done.Memo}", "memo", MessageBoxButtons.OK);
            });
            new_btnMemo.Text = "메모";
            new_btnMemo.Name = $"memobtn{todoCnt}";
            new_btnMemo.Margin = new Padding(100, 3, 20, 0);

            doneCnt++;

            //new_panel.Controls.Add(new_ck);
            new_panel.Controls.Add(new_title);
            new_panel.Controls.Add(new_date);
            new_panel.Controls.Add(new_btnMemo);

            _mainForm.panelDoneList.Controls.Add(new_panel);
        }

        public class ck_state : EventArgs
        {
            public CheckBox ck;
            public ck_state(CheckBox ck)
            {
                this.ck = ck;
            }
        }

        public void LoadTimer()
        {
            nowTime = System.DateTime.Now;
            LoadAlarm load_alarm = new LoadAlarm();

            foreach (Todo todo in Todos)
            {
                TimeSpan dt = todo.DeadLine - nowTime;

                if (dt.Days < 3)
                {
                    //load_alarm.fPanelLoadAlarm.Controls.Add()


                    Panel new_panel = new Panel();
                    Label new_label = new Label();

                    if (dt.Days >= 0 && dt.Hours >= 0 && dt.Minutes >= 0)
                    {
                        new_label.Text = $"{todo.Title} ✔ 마감까지 {dt.Days}일 {dt.Hours}시간";
                    }
                    else
                    {
                        
                    }
                   
                    new_panel.Size = new System.Drawing.Size(300, 20);
                    new_label.AutoSize = true;

                    new_panel.Controls.Add(new_label);
                    load_alarm.fPanelLoadAlarm.Controls.Add(new_panel);
                }
            }
            load_alarm.Show();
        }

    }
    
}
