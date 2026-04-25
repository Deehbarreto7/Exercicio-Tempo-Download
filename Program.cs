double tamanhoArquivo, velocidadeConexao;
double tempoEstimado;

Console.WriteLine ("--- Tempo de Download ---");

Console.WriteLine ("Tamanho do arquivo em MB........: ");
tamanhoArquivo = Convert.ToDouble (Console.ReadLine())*8;

Console.WriteLine("Velocidade da conexão em Mbps...:");
velocidadeConexao = Convert.ToDouble (Console.ReadLine());

tempoEstimado = tamanhoArquivo / velocidadeConexao /60;

Console.Write($"\ntempoEstimado: {tempoEstimado:N2} minutos");
