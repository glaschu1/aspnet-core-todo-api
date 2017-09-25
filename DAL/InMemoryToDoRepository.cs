using System;
using System.Collections.Generic;
using System.Linq;

public class InMemoryToDoRepository : IToDoRepository
{
    private List<ToDoItem> _toDoList { get; set; }

    public InMemoryToDoRepository()
    {
        _toDoList = new List<ToDoItem>();

        _toDoList.Add(new ToDoItem(1, "Learn .NET", true));
        _toDoList.Add(new ToDoItem(2, "Learn Java", false));
        _toDoList.Add(new ToDoItem(3, "Learn JavaScript", false));
        _toDoList.Add(new ToDoItem(4, "Learn Azure", true));
        _toDoList.Add(new ToDoItem(5, "Go Home", true));
    }
    public void CreateToDoItem(ToDoItem toDoItem)
    {
        toDoItem.Id = this.GetNextId();
        _toDoList.Add(toDoItem);
    }

    public void DeleteToDoItem(int id)
    {
        var toDoItem = _toDoList.FirstOrDefault(t => t.Id == id);

        if(toDoItem != null)
            _toDoList.Remove(toDoItem);
    }

    public int GetNextId()
    {
        return _toDoList.Count + 1;
    }

    public ToDoItem GetToDoItemById(int id)
    {
        return _toDoList.FirstOrDefault(t => t.Id == id);
    }

    public List<ToDoItem> GetToDoItems()
    {
        return _toDoList;
    }

    public void UpdateToDoItem(ToDoItem item)
    {
        var toDoItem = _toDoList.FirstOrDefault(t => t.Id == item.Id);

        if(toDoItem != null)
            toDoItem.UpdateToDo(item);
    }
}