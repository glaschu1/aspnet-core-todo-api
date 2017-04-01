using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[Route("api/todo")]
public class ToDoController : Controller
{
    private static IToDoRepository _toDoRepository = new InMemoryToDoRepository();

    [HttpGet("/api/todo")]
    public List<ToDoItem> GetAll()
    {
       return _toDoRepository.GetToDoItems();
    }

    [HttpGet("/api/todo/{id}")]
    public ToDoItem GetById(int id)
    {
        return _toDoRepository.GetToDoItemById(id);
    }
}