using static System.Console;

string[] nomes = {"Pedro", "Maria"};
WriteLine("O tamanho do array nomes é " + nomes.Length);
Array.Sort(nomes);
foreach(string item in nomes)
{
    WriteLine(item);
}
string novonome = "";
WriteLine("DIgite um nome:");
novonome = ReadLine();
List<string> adiciona = new List<string>(nomes.ToList());
adiciona.Add(novonome);
nomes = adiciona.ToArray();
WriteLine("Agora o tamanho do array é " + nomes.Length);
foreach(string item2 in nomes)
{
    WriteLine(item2);
}
WriteLine(nomes[0]);


