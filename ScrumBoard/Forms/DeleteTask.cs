using System;
using System.Windows.Forms;
using ScrumBoardLibrary;

namespace ScrumBoard.Forms
{
    public partial class DeleteTask : Form
    {
        private Board _board;
        public DeleteTask(Board board)
        {
            InitializeComponent();
            this._board = board;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this._board.RemoveTask(_board.Tasks.Find(t 
                => t.Name.ToLower() == taskNameTxt.Text.ToLower() &&
                   t.Column.Name.ToLower() == colTxt.Text.ToLower()));
            Close();
        }
    }
}