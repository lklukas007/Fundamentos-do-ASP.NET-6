var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok());

app.MapGet("/name/{nome}", (string nome) => Results.Ok($"Olá {nome}!"));

// app.MapPost("/", (User user) => Results.Ok($"Usuário: {user.Username}| Id: {user.Id}"));
app.MapPost("/", (User user) =>  Results.Ok(user));

app.Run();

public class User {
    public int Id { get; set;}

    public string? Username { get; set;}
}