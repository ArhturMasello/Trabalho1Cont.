using System.ComponentModel;
using api.Migrations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlServer<ContaBancaria.ApplicationDbContext>(builder.Configuration["Database:SqlServer"]);
var app = builder.Build();
var configuration = app.Configuration;
ContaRepository.Init(configuration);

 app.MapPost("/contas", (ContaRequest contaRequest, ContaBancaria.ApplicationDbContext context) => {
     var category = context.Categories.Where(c => c.Id == contaRequest.CategoryId).First();
     var conta = new ContaBancarias {
     Cpf = contaRequest.Cpf,
     NomeCliente = contaRequest.NomeCliente,
     Senha = contaRequest.Senha,
     Category = category
    };
    context.ContasBancarias.Add(conta);
    context.SaveChanges();
    return Results.Created($"/contas/{conta.Id}", conta.Id);
 });

app.MapGet("/contas/{cpf}", ([FromRoute] string cpf) => {
    var conta = ContaRepository.GetBy(cpf);
    if(conta != null) {
        Console.WriteLine("Conta encontrada");
        return Results.Ok(conta);
    }

    return Results.NotFound();
});

app.MapPut("/contas", (ContaBancarias conta) => {
    var contaSaved = ContaRepository.GetBy(conta.Cpf);
    contaSaved.Senha = conta.Senha;
});

app.MapDelete("/contas/{cpf}", ([FromRoute] string cpf) => {
    var contaSaved = ContaRepository.GetBy(cpf);
    ContaRepository.Remove(contaSaved);
});

app.MapGet("/configuration/database", (IConfiguration configuration) => {
    return Results.Ok(configuration["database:connection"]);
});




app.Run();