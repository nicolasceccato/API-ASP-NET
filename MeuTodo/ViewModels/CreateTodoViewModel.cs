using System;
using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public String Title { get; set; }
    }
}