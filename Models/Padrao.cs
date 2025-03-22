namespace MalVaderBank.Models;

public class Local
{
    public ulong CEP { get; private set; }
    public uint NumCasa { get; set; }
    public string? Bairro { get; private set; }
    public string? Cidade { get; private set; }
    public string? Estado { get; private set; }

    public void MudarCEP() { }
    public void MudarBairro() { }
    public void MudarCidade() { }
    public void MudarEstado() { }
}
public class Pessoa
{
    public ulong CPF { get; private set; }
    public string? Nome { get; private set; }
    public DateOnly? Nascimento { get; private set; }
    public uint? Telefone { get; private set; }

    public Pessoa()
    {
        this.CPF = 0;
        this.Nome = null;
        this.Nascimento = null;
        this.Telefone = null;
    }

    public void MudarCPF() { }
    public void MudarNome(String NovoNome)
        => this.Nome = NovoNome;
    public void MudarTelefone() { }
    public void MudarNascimento() { }
}

public abstract class Conta : Pessoa
{
    public ulong Agencia { get; set; }
    public uint Senha { get; set; }
    public uint conta { get; set; }

    public abstract void MudarAgencia();
    public abstract void MudarSenha();
    public abstract void MudarConta();
}

// public class Data
// {
//     public uint Dia { get; set; }
//     public uint Mes { get; set; }
//     public uint Ano { get; set; }
// }
