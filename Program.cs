// See https://aka.ms/new-console-template for more information
using MalVaderBank.Models.Cliente;
using MalVaderBank.Data;

namespace MalVaderBank;

public class Inicio{
    public static void Main(){
        ContaC hugo = new ContaC();
        hugo.MudarNome("Hugo");

        arquivinho vai = new arquivinho();
        vai.EscreverContaC(hugo);

        var pessoa = vai.LerContaC(hugo);
    Console.WriteLine($"{pessoa.nome}");
    }
}
