using System.ComponentModel;

namespace ScrumBoard.Forms
{
    partial class AddNewTask
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
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.colNameLabel = new System.Windows.Forms.Label();
            this.priorUpDown = new System.Windows.Forms.NumericUpDown();
            this.priorLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priorUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(37, 40);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(217, 22);
            this.taskNameTextBox.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.Location = new System.Drawing.Point(42, 17);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(86, 20);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Task Name";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(37, 113);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(217, 92);
            this.descTextBox.TabIndex = 2;
            // 
            // descLabel
            // 
            this.descLabel.Location = new System.Drawing.Point(42, 87);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(86, 23);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Description";
            // 
            // colTextBox
            // 
            this.colTextBox.Location = new System.Drawing.Point(37, 253);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(217, 22);
            this.colTextBox.TabIndex = 4;
            // 
            // colNameLabel
            // 
            this.colNameLabel.Location = new System.Drawing.Point(37, 227);
            this.colNameLabel.Name = "colNameLabel";
            this.colNameLabel.Size = new System.Drawing.Size(105, 23);
            this.colNameLabel.TabIndex = 5;
            this.colNameLabel.Text = "Column Name";
            // 
            // priorUpDown
            // 
            this.priorUpDown.Location = new System.Drawing.Point(41, 326);
            this.priorUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.priorUpDown.Name = "priorUpDown";
            this.priorUpDown.Size = new System.Drawing.Size(44, 22);
            this.priorUpDown.TabIndex = 6;
            this.priorUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // priorLabel
            // 
            this.priorLabel.Location = new System.Drawing.Point(37, 300);
            this.priorLabel.Name = "priorLabel";
            this.priorLabel.Size = new System.Drawing.Size(60, 23);
            this.priorLabel.TabIndex = 7;
            this.priorLabel.Text = "Priority";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(38, 419);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(69, 24);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AddNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.priorLabel);
            this.Controls.Add(this.priorUpDown);
            this.Controls.Add(this.colNameLabel);
            this.Controls.Add(this.colTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.taskNameTextBox);
            this.Name = "AddNewTask";
            this.Text = "AddNewTask";
            ((System.ComponentModel.ISupportInitialize)(this.priorUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button submitBtn;

        private System.Windows.Forms.Label priorLabel;

        private System.Windows.Forms.TextBox colTextBox;
        private System.Windows.Forms.Label colNameLabel;
        private System.Windows.Forms.NumericUpDown priorUpDown;

        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descLabel;

        private System.Windows.Forms.Label taskNameLabel;

        private System.Windows.Forms.TextBox taskNameTextBox;

        #endregion
    }
}