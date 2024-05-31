public static class ContaRepository {
    public static List<ContaBancarias> Contas { get; set; } = Contas = new List<ContaBancarias>();

    public static void Init(IConfiguration configuration) {
        var contas = configuration.GetSection("Contas").Get<List<ContaBancarias>>();
    }

    public static void Add(ContaBancarias conta) {
        Contas.Add(conta);
    }

    public static ContaBancarias GetBy(string cpf) {
        return Contas.First(p => p.Cpf == cpf);
    }

    public static void Remove(ContaBancarias conta) {
        Contas.Remove(conta);
    }
}