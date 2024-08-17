namespace Models.Funcionario;
using Models;

public class Funcionario:Pessoa{
    public enum CargoFuncionario{gerente=1, subgerente=0}
    protected uint codigo {get;set;}
    public CargoFuncionario cargo;
    Funcionario()
    {
        cargo = CargoFuncionario.subgerente;
    }
}
