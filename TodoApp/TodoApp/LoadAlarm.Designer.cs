
namespace TodoApp
{
    partial class LoadAlarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fPanelLoadAlarm = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "얼마 남지 않았어요!";
            // 
            // fPanelLoadAlarm
            // 
            this.fPanelLoadAlarm.Location = new System.Drawing.Point(26, 83);
            this.fPanelLoadAlarm.Name = "fPanelLoadAlarm";
            this.fPanelLoadAlarm.Size = new System.Drawing.Size(314, 149);
            this.fPanelLoadAlarm.TabIndex = 1;
            // 
            // LoadAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 274);
            this.Controls.Add(this.fPanelLoadAlarm);
            this.Controls.Add(this.label1);
            this.Name = "LoadAlarm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel fPanelLoadAlarm;
    }
}