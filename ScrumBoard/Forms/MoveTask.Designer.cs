using System.ComponentModel;

namespace ScrumBoard.Forms
{
    partial class MoveTask
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
            this.taskNameTxt = new System.Windows.Forms.TextBox();
            this.colToNameLabel = new System.Windows.Forms.Label();
            this.ColToNameTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.priorUpDown = new System.Windows.Forms.NumericUpDown();
            this.taskNameBtn = new System.Windows.Forms.Label();
            this.priorBtn = new System.Windows.Forms.Label();
            this.colFromNameLabel = new System.Windows.Forms.Label();
            this.colFromNameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priorUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // taskNameTxt
            // 
            this.taskNameTxt.Location = new System.Drawing.Point(12, 69);
            this.taskNameTxt.Name = "taskNameTxt";
            this.taskNameTxt.Size = new System.Drawing.Size(87, 22);
            this.taskNameTxt.TabIndex = 1;
            // 
            // colToNameLabel
            // 
            this.colToNameLabel.Location = new System.Drawing.Point(118, 41);
            this.colToNameLabel.Name = "colToNameLabel";
            this.colToNameLabel.Size = new System.Drawing.Size(98, 25);
            this.colToNameLabel.TabIndex = 2;
            this.colToNameLabel.Text = "Column to";
            // 
            // ColToNameTxt
            // 
            this.ColToNameTxt.Location = new System.Drawing.Point(118, 69);
            this.ColToNameTxt.Name = "ColToNameTxt";
            this.ColToNameTxt.Size = new System.Drawing.Size(87, 22);
            this.ColToNameTxt.TabIndex = 3;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(64, 164);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(111, 30);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // priorUpDown
            // 
            this.priorUpDown.Location = new System.Drawing.Point(12, 127);
            this.priorUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.priorUpDown.Name = "priorUpDown";
            this.priorUpDown.Size = new System.Drawing.Size(57, 22);
            this.priorUpDown.TabIndex = 5;
            this.priorUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // taskNameBtn
            // 
            this.taskNameBtn.Location = new System.Drawing.Point(12, 41);
            this.taskNameBtn.Name = "taskNameBtn";
            this.taskNameBtn.Size = new System.Drawing.Size(82, 25);
            this.taskNameBtn.TabIndex = 0;
            this.taskNameBtn.Text = "Task name";
            // 
            // priorBtn
            // 
            this.priorBtn.Location = new System.Drawing.Point(12, 99);
            this.priorBtn.Name = "priorBtn";
            this.priorBtn.Size = new System.Drawing.Size(56, 25);
            this.priorBtn.TabIndex = 6;
            this.priorBtn.Text = "Priority";
            // 
            // colFromNameLabel
            // 
            this.colFromNameLabel.Location = new System.Drawing.Point(118, 99);
            this.colFromNameLabel.Name = "colFromNameLabel";
            this.colFromNameLabel.Size = new System.Drawing.Size(98, 25);
            this.colFromNameLabel.TabIndex = 7;
            this.colFromNameLabel.Text = "Column from";
            // 
            // colFromNameTxt
            // 
            this.colFromNameTxt.Location = new System.Drawing.Point(118, 126);
            this.colFromNameTxt.Name = "colFromNameTxt";
            this.colFromNameTxt.Size = new System.Drawing.Size(87, 22);
            this.colFromNameTxt.TabIndex = 8;
            // 
            // MoveTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 206);
            this.Controls.Add(this.colFromNameTxt);
            this.Controls.Add(this.colFromNameLabel);
            this.Controls.Add(this.priorBtn);
            this.Controls.Add(this.priorUpDown);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.ColToNameTxt);
            this.Controls.Add(this.colToNameLabel);
            this.Controls.Add(this.taskNameTxt);
            this.Controls.Add(this.taskNameBtn);
            this.Name = "MoveTask";
            this.Text = "MoveTask";
            ((System.ComponentModel.ISupportInitialize)(this.priorUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label colFromNameLabel;
        private System.Windows.Forms.TextBox colFromNameTxt;

        private System.Windows.Forms.NumericUpDown priorUpDown;
        private System.Windows.Forms.Label priorBtn;

        private System.Windows.Forms.Button submitBtn;

        private System.Windows.Forms.TextBox taskNameTxt;
        private System.Windows.Forms.Label colToNameLabel;
        private System.Windows.Forms.TextBox ColToNameTxt;

        private System.Windows.Forms.Label taskNameBtn;

        #endregion
    }
}