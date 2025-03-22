namespace MalVaderBank.Models.Cliente;
using MalVaderBank.Models;

public class ContaC : Conta
{
    public ulong limite { get; set; }
    public DateOnly? vencimento { get; set; }
    public Local? local { get; set; }
    public ContaC()
    {
        this.Senha = 0;
        this.conta = 0;
    }

    public override void MudarAgencia() { }
    public override void MudarSenha() { }
    public override void MudarConta() { }

    public string? RetornaCPF()
    {
        return this.Nome;
    }
}
public class ContaP : Conta
{
    public Local? local { get; set; }
    public ContaP()
    {
        this.Senha = 0;
        this.conta = 0;
    }

    public override void MudarAgencia() { }
    public override void MudarSenha() { }
    public override void MudarConta() { }
}
