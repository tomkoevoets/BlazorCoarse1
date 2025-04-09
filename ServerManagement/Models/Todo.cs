

namespace ServerManagement.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public bool _IsCompleted { get; set; }
        public bool IsCompleted 
        { 
            get => _IsCompleted;
            set
            {
                _IsCompleted = value;
                if (value)
                {
                    DateCompleted = DateTime.Now;
                }
            }
        }

        public DateTime DateCompleted { get; set; }
    }
}
