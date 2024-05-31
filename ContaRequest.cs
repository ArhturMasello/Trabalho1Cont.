using Microsoft.EntityFrameworkCore.Storage;

public record ContaRequest(string NomeCliente, string Cpf, string Senha, int CategoryId);

public record DepositoRequest(string Cpf, float ValorDeposito, int CategoryId);

public record SaqueRequest(string Cpf, float ValorSaque, int CategoryId);