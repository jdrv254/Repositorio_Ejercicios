var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Todo> BDMemory = new List<Todo>();

Todo todo = new Todo();
todo.Id = 1;
todo.Nombre = "Sacar al perro";
todo.Completado = true; 

Todo todo2 = new Todo();
todo2.Id = 2;
todo2.Nombre = "Sacar al gato";
todo2.Completado = false; 

BDMemory.Add(todo);
BDMemory.Add(todo2);

app.MapGet("/api/v1/todo", () => { 
    return Results.Ok(BDMemory);
});

app.MapGet("/api/v1/todo/{id}", (int id) => { 
    return Results.Ok(BDMemory.Single(todo => todo.Id == id));
});


app.MapPost("/api/v1/todo", (Todo todo) => {
    BDMemory.Add(todo);
    return Results.Ok(BDMemory);
});

app.MapPut("/api/v1/todo/{id}",(int id, Todo todo) =>{
 Todo TodoUpdate = BDMemory.Single(todo => todo.Id == id);
 TodoUpdate.Completado = todo.Completado;

 return Results.Ok(BDMemory);

});

app.MapDelete("/api/v1/todo/{id}", (int id) => { 
    return Results.Ok(BDMemory.RemoveAll(todo => todo.Id == id));
});




app.Run();

public class Todo
{
    public int Id {get; set;}
    public string Nombre {get; set;}
    public bool Completado {get; set;}
}