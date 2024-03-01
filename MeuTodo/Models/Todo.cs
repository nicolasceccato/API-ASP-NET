using System;

namespace MeuTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public bool Done { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}