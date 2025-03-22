namespace MalVaderBank.Models.Funcionario;
using MalVaderBank.Models;

public enum CargoFuncionario
{
    gerente = 1,
    subgerente = 0
}

public class Funcionario : Pessoa
{
    public uint codigo { get; private set; }
    public CargoFuncionario cargo { get; private set; }

    Funcionario()
    {
        cargo = CargoFuncionario.subgerente;
    }
    public void MudarCargoFuncionario(CargoFuncionario NovoCargo)
    {
    }
    public void MudarCodigo(uint NovoCodigo)
    {
    }
}
