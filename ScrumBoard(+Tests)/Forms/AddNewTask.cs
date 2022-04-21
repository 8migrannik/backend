using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ScrumBoardLibrary;
using Task = ScrumBoardLibrary.Task;


namespace ScrumBoard.Forms
{
    public partial class AddNewTask : Form
    {
        private Board _board;

        public AddNewTask(Board board)
        {
            InitializeComponent();
            this._board = board;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var task = new Task(taskNameTextBox.Text, descTextBox.Text, (int)priorUpDown.Value);

            var col = this._board.Columns.Find(c => c.Name.ToLower() == colTextBox.Text.ToLower());
            if (col is null)
            {
                if (colTextBox.Text == "")
                    col = null;
                else col = new Column(colTextBox.Text);
            }
            task.Column = col;
            this._board.AddTask(task);
            
            this.Close();
        }
    }
}