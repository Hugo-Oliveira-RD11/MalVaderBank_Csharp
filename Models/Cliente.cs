using Models;
public class ContaCC : ContaC
{
   public ulong limite {get; set;}
   public Data? vencimento {get;set;}
   public Local? local {get;set;}
   ContaCC()
   {
   }
}
public class ContaCP: ContaC
{
    public Local? local {get;set;}
   ContaCP()
   {
   }
}

public class Funcionario:Pessoa{
    public enum CargoFuncionario{gerente=1, subgerente=0}
    protected uint codigo {get;set;}
    public CargoFuncionario cargo;
    Funcionario()
    {
        cargo = CargoFuncionario.subgerente;
    }
}
