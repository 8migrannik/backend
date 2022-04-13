using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumBoard.Forms;


// Мы должны уметь создавать Доски.
//     Доска имеет Название. После создания доски название доски изменить нельзя. 
//     Каждая доска разделена на колонки. Каждая колонка имеет название. Колонки должны располагаться в заданном порядке. 
//     Максимально разрешено иметь 10 колонок. На доску можно добавлять задачи. Кол-во задач не ограничено. 
//     Каждая задача должна иметь Название, Описание, Приоритет, и должна располагаться в определенной колонке. 
//     По умолчанию задача добавляется в первую колонку. Задачи можно перемещать по колонкам."
    



namespace ScrumBoard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}