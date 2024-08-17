namespace Models.Cliente;
using Models;

public class ContaCC : ContaC
{
   public ulong limite {get; set;}
   public Data? vencimento {get;set;}
   public Local? local {get;set;}
   ContaCC()
   {
       this.CPF = 0;
       this.senha = 0;
       this.conta = 0;
   }
}
public class ContaCP: ContaC
{
    public Local? local {get;set;}
   ContaCP()
   {
       this.CPF = 0;
       this.senha = 0;
       this.conta = 0;
   }
}

