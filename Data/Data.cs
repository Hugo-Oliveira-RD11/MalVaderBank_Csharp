using MalVaderBank.Models.Cliente;
using System.Dynamic;
using System.IO;
using System.Text.Json;


namespace MalVaderBank.Data;

public class arquivinho
{
    public arquivinho()
    {
        Directory.CreateDirectory("database");
        Directory.SetCurrentDirectory("database");
        File.Create("teste.txt").Close();
        File.Create("teste2.txt").Close();
    }

    public void EscreverContaC(ContaC cliente)
    {
        var json = JsonSerializer.Serialize(cliente);
        File.AppendAllText("teste.txt", json);
    }

    // dynamic
    public dynamic LerContac(ContaC cliente)
    {

        using(StreamReader reader = new StreamReader("teste.txt"))
        {
            string jsonfinal = reader.ReadToEnd();
            dynamic test = JsonSerializer.Deserialize<ExpandoObject>(jsonfinal);
            return test;
        }
        return null;
    }

    // jsonDocument
    public dynamic LerContaC(ContaC cliente)
    {


        using(StreamReader reader = new StreamReader("teste.txt"))
        {
            string jsonfinal = reader.ReadToEnd();
            using( JsonDocument json = JsonDocument.Parse(jsonfinal)){
                JsonElement root = json.RootElement;

                dynamic pessoa = new ExpandoObject();

                pessoa.nome = root.GetProperty("Nome").GetString();
                pessoa.conta = root.GetProperty("conta").GetInt32();

                return pessoa;
            }
        }
        return null;
    }

}
