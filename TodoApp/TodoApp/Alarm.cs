﻿using System;
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
    public partial class Alarm : Form
    {
        MainForm _mainForm;
        DateTime dateTime;
        public Alarm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            LoadAlarm();
        }

        public void LoadAlarm()
        {
            //dateTime = new DateTime();
            dateTime = System.DateTime.Now;

            //MessageBox.Show($"{dateTime}");

            foreach (Todo todo in LabelManager.Todos)
            {
                //this.tabControl.Size = new System.Drawing.Size(700, 400);

                TimeSpan dt = todo.DeadLine - dateTime;

                Panel new_panel = new Panel();
                Label new_label = new Label();

                if (dt.Days >= 0 && dt.Hours >= 0 && dt.Minutes >= 0) 
                {
                    new_label.Text = $"{todo.Title}이(가) 마감까지 {dt.Days}일 {dt.Hours}시간 남았습니다.";
                }
                else
                {
                    new_label.Text = $"{todo.Title}의 마감 기한이 초과 됐습니다!";
                    //new_label.Color
                }
                //new_label.Text = $"{todo.Title}이(가) 마감까지 {dt.Days}일 {dt.Hours}시간 남았습니다.";
                new_panel.Size = new System.Drawing.Size(400, 20);
                new_label.AutoSize = true;

                new_panel.Controls.Add(new_label);
                panelAlarm.Controls.Add(new_panel);

            }
        }
    }
}
