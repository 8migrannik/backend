namespace ScrumBoardLibrary
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public Column Column
        {
            get => this._column;
            set { this._column = value; }
        }

        private Column _column;

        public Task(string name, string desc, int prior, Column column = null)
        {
            this.Name = name;
            this.Description = desc;

            if (prior > column?.Tasks.Count)
                if (column.Tasks.Count != 0)
                    this.Priority = column.Tasks.Count;
                else this.Priority = 1;
            else this.Priority = prior;

            this._column = column;
            column?.AddTask(this);
        }
    }
}