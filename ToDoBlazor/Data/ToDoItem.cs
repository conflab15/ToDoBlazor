using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoBlazor.Data
{
    public class ToDoItem
    {
        [Key]
        public int Key { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        public string Details { get; set; }
        [Required]
        public DateTime Added { get; set; }
        public DateTime DueDate { get; set; }
        public bool isCompleted { get; set; }
    }
}
