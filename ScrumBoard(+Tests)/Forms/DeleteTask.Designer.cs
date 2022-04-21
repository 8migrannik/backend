using System.ComponentModel;

namespace ScrumBoard.Forms
{
    partial class DeleteTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.submitBtn = new System.Windows.Forms.Button();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameTxt = new System.Windows.Forms.TextBox();
            this.colLabel = new System.Windows.Forms.Label();
            this.colTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(52, 113);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(107, 29);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.Location = new System.Drawing.Point(15, 28);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(80, 26);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Task name";
            // 
            // taskNameTxt
            // 
            this.taskNameTxt.Location = new System.Drawing.Point(15, 57);
            this.taskNameTxt.Name = "taskNameTxt";
            this.taskNameTxt.Size = new System.Drawing.Size(81, 22);
            this.taskNameTxt.TabIndex = 2;
            // 
            // colLabel
            // 
            this.colLabel.Location = new System.Drawing.Point(113, 28);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(80, 26);
            this.colLabel.TabIndex = 3;
            this.colLabel.Text = "Column";
            // 
            // colTxt
            // 
            this.colTxt.Location = new System.Drawing.Point(113, 57);
            this.colTxt.Name = "colTxt";
            this.colTxt.Size = new System.Drawing.Size(81, 22);
            this.colTxt.TabIndex = 4;
            // 
            // DeleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 204);
            this.Controls.Add(this.colTxt);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.taskNameTxt);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.submitBtn);
            this.Name = "DeleteTask";
            this.Text = "DeleteTask";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskNameTxt;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.TextBox colTxt;

        private System.Windows.Forms.Button submitBtn;

        #endregion
    }
}