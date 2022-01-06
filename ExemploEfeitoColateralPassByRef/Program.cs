// Por ordem de chegada
var filaDeEspera =
    new List<string>() { "Gael", "Olívia", "Alan", "Miguel" };

void MostraPorOrdemAlfabetica(List<string> fila)
{
    Console.WriteLine("Ordem alfabética");
    fila.Sort();
    fila.ForEach(nome => Console.WriteLine(nome));
}

void MostraPorOrdemDeChegada(List<string> fila)
{
    Console.WriteLine("Ordem de chegada");
    fila.ForEach(nome => Console.WriteLine(nome));
}

MostraPorOrdemAlfabetica(filaDeEspera);
MostraPorOrdemDeChegada(filaDeEspera);