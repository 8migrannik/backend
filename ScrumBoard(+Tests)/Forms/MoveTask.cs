using System;
using System.Linq;
using System.Windows.Forms;
using ScrumBoardLibrary;

namespace ScrumBoard.Forms
{
    public partial class MoveTask : Form
    {
        private Board _board;

        public MoveTask(Board board)
        {
            InitializeComponent();
            this._board = board;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (this.colFromNameTxt.Text == "")
            {
                MessageBox.Show("Specify the column!");
                return;
            }

            string taskName = this.taskNameTxt.Text.ToLower();
            var colFrom = this._board.Columns.Find(c => c.Name.ToLower() == colFromNameTxt.Text.ToLower());
            var colTo = this._board.Columns.Find(c => c.Name.ToLower() == ColToNameTxt.Text.ToLower());

            int prior;
            if (priorUpDown.Value > colTo.Tasks.Count + 1)
                prior = colTo.Tasks.Count + 1;
            else prior = (int)priorUpDown.Value;

            this._board.MoveTask(taskName, colFrom, colTo, prior);

            this.Close();
        }
    }
}