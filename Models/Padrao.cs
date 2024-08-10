namespace Models;

public  class Local{
    protected ulong CEP{get; set;}
    protected uint numCasa{get; set;}
    protected string? Bairro{get; set;}
    protected string? Cidade{get; set;}
    protected string? Estado{get; set;}
}
public abstract class Pessoa{
    protected ulong CPF{get; set;}
    protected string? nome{get; set;}
    protected Data? nascimento {get;set;}
    protected uint telefone{get; set;}
}

public abstract class ContaC:Pessoa
{
    protected ulong agencia{get; set;}
    protected uint senha{get; set;}
}

public class Data{
    public uint Dia{get;set;}
    public uint Mes{get;set;}
    public uint Ano{get;set;}
}
