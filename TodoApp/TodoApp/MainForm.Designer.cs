
using System.Diagnostics.Tracing;
using System.Windows.Forms;

namespace TodoApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTodo = new System.Windows.Forms.TabPage();
            this.fPanelTodoList = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDone = new System.Windows.Forms.TabPage();
            this.panelDoneList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTodoList = new System.Windows.Forms.Panel();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.labelFont = new System.Windows.Forms.Label();
            this.btnAlarm = new System.Windows.Forms.Label();
            this.gridTodoList = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabTodo.SuspendLayout();
            this.tabDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTodoList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTodo);
            this.tabControl.Controls.Add(this.tabDone);
            this.tabControl.Location = new System.Drawing.Point(139, 182);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(700, 400);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTodo
            // 
            this.tabTodo.Controls.Add(this.fPanelTodoList);
            this.tabTodo.Location = new System.Drawing.Point(4, 24);
            this.tabTodo.Name = "tabTodo";
            this.tabTodo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodo.Size = new System.Drawing.Size(692, 372);
            this.tabTodo.TabIndex = 0;
            this.tabTodo.Text = "✏ Todo";
            this.tabTodo.UseVisualStyleBackColor = true;
            this.tabTodo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // fPanelTodoList
            // 
            this.fPanelTodoList.Location = new System.Drawing.Point(0, 0);
            this.fPanelTodoList.Name = "fPanelTodoList";
            this.fPanelTodoList.Size = new System.Drawing.Size(680, 370);
            this.fPanelTodoList.TabIndex = 0;
            // 
            // tabDone
            // 
            this.tabDone.Controls.Add(this.panelDoneList);
            this.tabDone.Location = new System.Drawing.Point(4, 24);
            this.tabDone.Name = "tabDone";
            this.tabDone.Padding = new System.Windows.Forms.Padding(3);
            this.tabDone.Size = new System.Drawing.Size(692, 372);
            this.tabDone.TabIndex = 1;
            this.tabDone.Text = "✔ Done";
            this.tabDone.UseVisualStyleBackColor = true;
            // 
            // panelDoneList
            // 
            this.panelDoneList.BackColor = System.Drawing.Color.White;
            this.panelDoneList.Location = new System.Drawing.Point(0, 0);
            this.panelDoneList.Name = "panelDoneList";
            this.panelDoneList.Size = new System.Drawing.Size(690, 370);
            this.panelDoneList.TabIndex = 0;
            // 
            // panelTodoList
            // 
            this.panelTodoList.Location = new System.Drawing.Point(0, 0);
            this.panelTodoList.Name = "panelTodoList";
            this.panelTodoList.Size = new System.Drawing.Size(690, 370);
            this.panelTodoList.TabIndex = 0;
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.BackColor = System.Drawing.Color.White;
            this.btnAddTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddTodo.FlatAppearance.BorderSize = 0;
            this.btnAddTodo.Location = new System.Drawing.Point(145, 108);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(98, 32);
            this.btnAddTodo.TabIndex = 1;
            this.btnAddTodo.Text = "Add Todo";
            this.btnAddTodo.UseVisualStyleBackColor = false;
            this.btnAddTodo.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.labelFont.Location = new System.Drawing.Point(441, 24);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(92, 40);
            this.labelFont.TabIndex = 3;
            this.labelFont.Text = "ToDo";
            // 
            // btnAlarm
            // 
            this.btnAlarm.AutoSize = true;
            this.btnAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAlarm.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarm.Image")));
            this.btnAlarm.Location = new System.Drawing.Point(784, 97);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(51, 54);
            this.btnAlarm.TabIndex = 4;
            this.btnAlarm.Text = "  ";
            this.btnAlarm.Click += new System.EventHandler(this.click_alarm);
            // 
            // gridTodoList
            // 
            this.gridTodoList.Location = new System.Drawing.Point(0, 0);
            this.gridTodoList.Name = "gridTodoList";
            this.gridTodoList.Size = new System.Drawing.Size(690, 370);
            this.gridTodoList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.btnAddTodo);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainForm";
            this.Text = "TodoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTodo.ResumeLayout(false);
            this.tabDone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTodoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTodo;
        private System.Windows.Forms.TabPage tabDone;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label btnAlarm;

        public System.Windows.Forms.Panel panelTodoList; //
        public System.Windows.Forms.FlowLayoutPanel panelDoneList; //
        public System.Windows.Forms.DataGridView gridTodoList;//
        public System.Windows.Forms.FlowLayoutPanel fPanelTodoList;//
    }
}

