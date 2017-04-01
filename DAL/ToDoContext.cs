using Microsoft.EntityFrameworkCore;

public class ToDoContext : DbContext
{
    public DbSet<ToDoItem> ToDoItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"CONNECTION STRING FOR ADO.NET FROM AZURE");
    }
}