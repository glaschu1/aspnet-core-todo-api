using System.Collections.Generic;

public interface IToDoRepository
{
    int GetNextId();
    List<ToDoItem> GetToDoItems();
    ToDoItem GetToDoItemById(int id);
    void CreateToDoItem(ToDoItem toDoItem);
    void DeleteToDoItem(int id);
    void UpdateToDoItem(ToDoItem toDoItem);
}