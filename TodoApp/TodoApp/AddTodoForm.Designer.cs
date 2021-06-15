
namespace TodoApp
{
    partial class AddTodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.explain = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explain
            // 
            this.explain.AutoSize = true;
            this.explain.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.explain.Location = new System.Drawing.Point(43, 34);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(196, 25);
            this.explain.TabIndex = 0;
            this.explain.Text = "✔ 할 일 등록하기 ✔";
            this.explain.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(58, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "이름";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(58, 160);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(55, 15);
            this.lblDeadline.TabIndex = 2;
            this.lblDeadline.Text = "마감일자";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(58, 204);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(31, 15);
            this.lblMemo.TabIndex = 3;
            this.lblMemo.Text = "메모";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(153, 111);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(224, 23);
            this.txtTitle.TabIndex = 4;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(153, 204);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(224, 181);
            this.txtMemo.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(153, 160);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 23);
            this.dateTimePicker.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.submit_todo);
            // 
            // AddTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 477);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.explain);
            this.Name = "AddTodoForm";
            this.Text = "Add Todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdd;
    }
}