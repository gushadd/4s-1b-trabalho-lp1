using _4s_1b_trabalho_lp1;

public class Program{
    static List<Bloco> blocos = new();
    public static void Main(String[] args)
    {
        int opcao;
        bool rodarPrograma = true;

        Console.WriteLine("Bem vindo ao Gerenciador de Blocos.\n");

        do
        {
            while (true)
            {
                Console.WriteLine("1 - Cadastrar bloco");
                Console.WriteLine("2 - Listar blocos");
                Console.WriteLine("3 - Buscar bloco por código");
                Console.WriteLine("4 - Listar blocos por pedreira");
                Console.WriteLine("5 - Sair");
                Console.Write("\nSelecione uma opção: ");
                string resposta = Console.ReadLine()!;

                if (int.TryParse(resposta, out opcao) && opcao > 0 && opcao < 6)    //caso a opção seja válida, sai do loop
                {
                    break;
                }

                Console.Write("Opção inválida!");
                Thread.Sleep(1500);
                Console.Clear();
            }

            switch (opcao)
            {
                case 1:
                    blocos.Add(CadastraBloco.CadastrarBloco());
                    Console.WriteLine("Bloco cadastrado com sucesso!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                case 2:
                    ListaBlocos.ListarBlocos(blocos);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    rodarPrograma = false;
                    break;
            }
        }while (rodarPrograma);
    }
}