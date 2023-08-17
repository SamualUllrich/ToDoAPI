using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
    public class ToDo
    {
        //The Key attribute is used to denote the property that uniquely identifies
        //an entity (the EntityKey ), and which is mapped to the Primary Key field
        //in a database: 
        [Key]
        public int Id { get; set; }

        public string ToDoName { get; set; }
    }
}
