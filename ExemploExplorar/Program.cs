using ExemploExplorar.Models;
using System.Globalization;
using Newtonsoft.Json;

//If ternário
//Importante mencionar que o IF ternário é somente usando quando você tem apenas duas condições.
//Caso tenho algum outro IF aninhado, não se deve usar o if ternário.

int numero = 23;
bool par = false;

//Aqui está sendo usado a extensão do MÉTODO (IntExtensions).
par = numero.EhPar();

string mensagem = $"O núemro {numero} é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);

/*
Forma Reduzida
Console.WriteLine($"O número {numero} é: " + (numero.EhPar() ? "Par" : "Ímpar"));
*/
















// //Usando o Array Genérico
// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(10);
// arrayInteiro.AdicionarElementoArray(650);
// Console.WriteLine(arrayInteiro[0]);
// Console.WriteLine(arrayInteiro[1]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");
// arrayString.AdicionarElementoArray("Segundo teste");
// Console.WriteLine(arrayString[0]);
// Console.WriteLine(arrayString[1]);
























// //Como usar uma variável dinâmica
// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// Console.WriteLine();

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// Console.WriteLine();

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");


























// /*Selecionando apenas dois atributos da minha classe Vendas. Lembrando que nessa classe existem cinco atributos diferentes, porém 
// necessito usar apenas alguns atributos.*/
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Vendas> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var item in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {item.Produto}, Preço: {item.Preco}");
// }
























// //Usando um tipo anônimo
// var tipoAnonimo = new { Nome = "Luã Lafayete", Sobrenome = "Salgado", Altura = 1.80 };

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");

























// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

// foreach (var item in listaVendas)
// {
//     Console.WriteLine($"Id: {item.Id}, " +
//                         $"Produto: {item.Produto}, " + 
//                         $"Preço: {item.Preco}, " +
//                         $"Data: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}, " +
//                         $"{(item.Desconto.HasValue ? $"Desconto de: {item.Desconto}" : "")}");
// }
























// //Usando NULL em uma variável Booleana
// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber email.");
// }
// else
// {
//     Console.WriteLine("O usuário não optou por receber email.");
// }



















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaDeVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(1, "Lisença de Software", 110.00M, dataAtual);

// listaDeVendas.Add(v1);
// listaDeVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);















// //Usando o Deconstrutor
// Pessoa p1 = new Pessoa("Luã", "Lafayete");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");























// //Testando a classe LeituraArquivo que tem como método uma tupla
// LeituraArquivo arquivo = new LeituraArquivo();

// //Caso eu não tenha interesse em usar uma das variáveis da Tupla, coloca o "_" e a informação não será usada. Observe o exemplo abaixo
// // var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }























// //Como declarar um tupla
// //Vale lembrar que essa primeira é a mais recomendada.
// (int, string, string, decimal) tupla = (1, "Luã", "Lafayete", 1.80M);

// //Outras formas de declarar tuplas
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Luã", "Lafayete", 1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Luã", "Lafayete", 1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item2}");
// Console.WriteLine($"Altura: {tupla.Item4}");




























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");
// estados.Add("SC", "Santa Catarina");
// estados.Add("PR", "Paraná");
// estados.Add("ES", "Espirito Santo");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} e Estado: {item.Value}");
// }

// Console.WriteLine();

// Console.WriteLine("Removendo Estados");
// estados.Remove("BA");

// //Alterando os valores na chave
// estados["RJ"] = "Rio de Janeiro - Valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} e Estado: {item.Value}");
// }

// Console.WriteLine();

// Console.Write($"Qual Estado voçê mora: ");
// Console.WriteLine(estados["SP"]);

























// //Diferente do QUEUE, a STACK funciona como se fosse uma pilha onde LAST IN FIRST OUT

// Stack<int> Pilha = new Stack<int>();

// Pilha.Push(12);
// Pilha.Push(10);
// Pilha.Push(8);
// Pilha.Push(6);
// Pilha.Push(4);
// Pilha.Push(2);
// Pilha.Push(0);

// foreach (var item in Pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {Pilha.Pop()}");

// Pilha.Push(144);

// foreach (var item in Pilha)
// {
//     Console.WriteLine(item);
// }


























// //O QUEUE (FILA) funciona como se fossse uma lista, porém ele segue o método FIRST IN FIRST OUT
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);
// fila.Enqueue(12);

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(30);

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }



























//new ExemploExcecao().Metodo1();


























// try
// {    
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string item in linhas)
//     {
//         Console.WriteLine(item);
//     }

// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }























// string dataString = "2022-04-170 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }



























// DateTime data = DateTime.Now;
// Console.WriteLine(data); //Informação completa
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Formatado
// Console.WriteLine(data.ToShortDateString()); //Somente com data
// Console.WriteLine(data.ToShortTimeString()); //Somente com horas

// Console.WriteLine();

// DateTime data1 = DateTime.Parse("17/04/2022 18:00");
// Console.WriteLine(data1);


























// //Alterando a localização do código
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal ValorMonetario = 4560.46M;

// Console.WriteLine(ValorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .33514;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));





























// Pessoa p1 = new Pessoa(nome:"Lua", sobrenome:"Lafayete");
// Pessoa p2 = new Pessoa(nome:"Rosane", sobrenome:"Ribas");

// Curso cursoDeInglês = new Curso();
// cursoDeInglês.NomeDoCurso = "Inglês";
// cursoDeInglês.AlunosDoCurso = new List<Pessoa>();

// cursoDeInglês.AdicionarAluno(p1);
// cursoDeInglês.AdicionarAluno(p2);
// cursoDeInglês.ListarAlunos();




























// Pessoa p1 = new Pessoa();

// Console.Write("Digite o nome do usuário: ");
// p1.Nome = Console.ReadLine();

// Console.Write("Digite o sobrenome: ");
// p1.Sobrenome = Console.ReadLine();

// Console.Write("Digite a idade do usuário: ");
// p1.Idade = int.Parse(Console.ReadLine());

// p1.Apresentar();