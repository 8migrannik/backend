using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumBoardLibrary;
using Task = ScrumBoardLibrary.Task;


namespace ScrumBoard.Forms
{
    public partial class Form1 : Form
    {
        private Board _board;

        private void initializeBoard()
        {
            var coloumns = new List<Column>
            {
                new Column("Breakfast"),
                new Column("Lunch"),
                new Column("Dinner")
            };

            coloumns[0].AddTask(new Task("Eat Eggs", "You need to eat all these eggs!", 3));
            coloumns[0].AddTask(new Task("Drink Coffee", "You need to drink this taste coffee!", 2));
            coloumns[0].AddTask(new Task("Wash plates", "You need to clean up after yourself", 1));

            coloumns[1].AddTask(new Task("Eat soup", "You need to eat borsch-soup!", 1));
            coloumns[1].AddTask(new Task("Eat fried potatoes", "You need to eat...", 2));
            coloumns[1].AddTask(new Task("Drink tea", "You need to drink this tea!", 3));
            coloumns[1].AddTask(new Task("Wash plates", "You need to clean up after yourself", 4));

            coloumns[2].AddTask(new Task("Eat roast", "You need to eat this  roast", 1));
            coloumns[2].AddTask(new Task("Wash plates", "You need to clean up after yourself", 2));
            coloumns[2].AddTask(new Task("Wash fruits", "You need to eat these fresh fruits", 3));
            
            this._board = new Board("Scrum Board", coloumns);
        }


        private void buildDataGridByBoard()
        {
            foreach (var c in _board.Columns)
                this.dataGridView1.Columns.Add(c.Name, c.Name);

            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
                this.dataGridView1.Columns[i].Width = 100;

            foreach (var c in _board.Columns)
            foreach (var t in c.Tasks)
                this.dataGridView1.Rows.Add();

            for (int k = 0; k < dataGridView1.Rows.Count; k++)
                dataGridView1.Rows[k].Height = 30;

            for (int i = 0; i < _board.Columns.Count; i++)
            for (int j = 0; j < _board.Columns[i].Tasks.Count; j++)
                this.dataGridView1[i, j].Value = _board.Columns[i].Tasks[j].Name
                                                 + "\n" + _board.Columns[i].Tasks[j].Description;
        }

        private void refreshBoard()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            buildDataGridByBoard();
            
        }

        public Form1()
        {
            InitializeComponent();
            initializeBoard();
            buildDataGridByBoard();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            var form = new AddNewTask(this._board);
            form.ShowDialog();
            refreshBoard();
        }

        private void moveTaskBtn_Click(object sender, EventArgs e)
        {
            var form = new MoveTask(this._board);
            form.ShowDialog();
            refreshBoard();
        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {
            var form = new DeleteTask(this._board);
            form.ShowDialog();
            refreshBoard();
        }
    }
}