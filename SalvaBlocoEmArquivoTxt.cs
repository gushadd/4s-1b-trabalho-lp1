using System.Reflection;

namespace _4s_1b_trabalho_lp1;

public class SalvaBlocoEmArquivoTxt
{
    public static void SalvarBlocoEmArquivoTxt (Bloco bloco)
    {
        string caminho = "blocos.txt"; //cria txt na mesma pasta do executável

        using (StreamWriter sw = new StreamWriter(caminho, true))
        {
            sw.WriteLine(Util.DadosDoBloco(bloco));
        }

        //try
        //{
            
        //}
        //catch ()
        //{

        //}
        //finally
        //{ 
        
        //}


    }
}
