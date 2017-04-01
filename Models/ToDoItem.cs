    public class ToDoItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsDone { get; set; }

        public ToDoItem()
        {
        }

        public ToDoItem(int id, string text, bool isDone)
        {
            Id = id;
            Text = text;
            IsDone = isDone;
        }

        public void UpdateToDo(ToDoItem item)
        {
            Id = item.Id;
            Text = item.Text;
            IsDone = item.IsDone;
        }
    }