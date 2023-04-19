using SerieAPI;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Serie handler = new Serie();

app.MapGet("/api/v1/serie", () => { 
    return Results.Ok(handler.All);
});


app.MapPost("/api/v1/serie", (SerieDTO serie) => {
    handler.Add(serie);
    return Results.Ok(handler.All());
});

app.MapPut("/api/v1/serie/{id}", (int id, SerieDTO serie) => {
    handler.Update(id, serie);
    
});

app.MapPut("/api/v1/serie/{id}", (int id) => {
    handler.Delete(id);
    
});

app.Run();