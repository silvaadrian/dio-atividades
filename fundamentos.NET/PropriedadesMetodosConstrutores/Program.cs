using PropriedadesMetodosConstrutores.Models;
using System.Globalization;
using Newtonsoft.Json;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br"); //Formata todo sistema

// Pessoa p = new Pessoa();
// p.Nome = "Teste";
// p.Sobrenome = "jaca";

// Pessoa p2 = new Pessoa("Testando", 23, "Jacare");
// // p2.Nome = "Testando";
// // p2.Sobrenome = "jacare";

// Curso curso = new Curso();
// curso.Nome = "Ingles";
// curso.Alunos = new List<Pessoa>();

// curso.AdicionarAluno(p);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();
// p2.Apresentar();

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //Outra forma de formatar a linguagem do sistema monetario

// double porcentagem = .3421;
// int numero = 123456;

// Console.WriteLine(porcentagem.ToString("P"));
// Console.WriteLine(numero.ToString("##-##-##"));

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta não encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
//     // throw;
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }

// new ExemploExcecao().Metodo1();

// (int, string, string) tupla = (1, "teste", "tupla");

// Console.WriteLine(tupla.Item2);

// Pessoa p = new Pessoa(); //Construindo
// p.Nome = "Teste"; 
// p.Sobrenome = "jaca";

// (string nome, string sobrenome) = p; //Desconstruindo

// Console.WriteLine($"{nome} + {sobrenome}");

Venda v1 = new Venda(1, "Material de Escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 1000.00M);

List<Venda> listaVendas = new List<Venda>();

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/venda.json", serializado);

Console.WriteLine(serializado);