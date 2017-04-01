using System;
using System.Collections.Generic;
using System.Linq;

public class SqlServerToDoRepository : IToDoRepository
{
    private ToDoContext _toDoContext = new ToDoContext();

    public void CreateToDoItem(ToDoItem toDoItem)
    {
        throw new NotImplementedException();
    }

    public void DeleteToDoItem(int id)
    {
        throw new NotImplementedException();
    }

    public int GetNextId()
    {
        throw new NotImplementedException();
    }

    public ToDoItem GetToDoItemById(int id)
    {
        throw new NotImplementedException();
    }

    public List<ToDoItem> GetToDoItems()
    {
        return _toDoContext.ToDoItems.ToList();
    }

    public void UpdateToDoItem(ToDoItem toDoItem)
    {
        throw new NotImplementedException();
    }
}