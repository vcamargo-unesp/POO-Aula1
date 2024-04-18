using POO_Aula1_2;

double nCorte;
Console.Write("Nota de corte: ");
Double.TryParse(Console.ReadLine(), out nCorte);

Console.Write("Quantidade de alunos: ");
List<Aluno> alunos = new List<Aluno>(
    Int32.Parse(Console.ReadLine())
);

for(int i = 0; i < alunos.Capacity; i++)
{
    Aluno a = new Aluno();
    Console.Write($"Nome do aluno {i + 1}: ");
    a.Nome = Console.ReadLine();
    Console.Write($"Nota de {a.Nome}: ");
    Double.TryParse(Console.ReadLine(), out a.nota);

    alunos.Add(a);
}

List<Aluno> aprovados = new List<Aluno>(alunos.Capacity);
foreach(Aluno a in alunos)
    if(a.Verificar(nCorte))
        aprovados.Add(a);

Console.WriteLine("Quantidade de alunos autorizados: " +
    aprovados.Count);

foreach (Aluno a in aprovados)
    Console.WriteLine(a.Nome);