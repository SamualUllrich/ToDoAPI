using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));



var app = builder.Build();



//app.UseHttpsRedirection();

app.MapGet("api/todo", async (AppDbContext context) =>
    {
        var items = await context.ToDos.ToListAsync();

        return Results.Ok(items);
    });

app.MapPost("api/todo", async (AppDbContext context, ToDo toDo) =>
{
    await context.ToDos.AddAsync(toDo);

    await context.SaveChangesAsync();

    return Results.Created($"api/todo/{toDo.Id}", toDo);
});

app.Run();

