using System.ComponentModel;
using Microsoft.VisualBasic;

public class ContaBancarias{
    public int Id { get; set; }
    public string NomeCliente { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; } 
    public float SaldoConda { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }  
}
public class DepositaSaldo{
    public string Cpf { get; set;}
    public float ValorDeposito { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
public class SacaSaldo{
    public string Cpf { get; set; }
    public float ValorSaque { get; set; }
    public int CategoryId { get; set; }
    public Category category { get; set; }
}
public class VisualizaSaldo{
    public string Cpf { get; set; }
    public float SaldoConta { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}