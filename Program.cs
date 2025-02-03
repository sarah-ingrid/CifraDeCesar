// programa para codificar mensagem com cifra de cesar


using System.Text;

string palavra = "", concat = "";
int posicao, op;
string final;

Console.WriteLine("********* CIFRA DE CÉSAR *********\n\n\n");

Console.Write("Escolha uma opção:\n\n\t1 - Codificar\n\t2 - Descodificar\n");
op = Convert.ToInt32(Console.ReadLine());


switch (op)
{
    case 1:
        Console.Write("Digite a palavra para codificar: ");
    // recebendo a palavra e colocando as letras minusculas para manipular melhor o codigo ASCII
        palavra = Console.ReadLine().ToLower(); 


        Console.Write("Digite o pulo: ");
        posicao = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < palavra.Length; i++)
        {
//      Convertendo as letras para o codigo ASCII correspondente e usando a posição/pulo para descodificar:
            int cc = System.Convert.ToInt32(palavra[i]) + posicao;

            if (cc > 122)
                cc = cc - 26;

            //        Console.Write(cc + " ");

            concat += Char.ConvertFromUtf32(cc);


        }
        final = char.ToUpper(concat[0]) + concat.Substring(1); // formatando para a primeira letra ser maiuscula
        Console.WriteLine($"\n\nPalavra descodificada: {final}");
        break;




    case 2:
        Console.Write("Digite a palavra descodificar: ");
        palavra = Console.ReadLine().ToLower();

        Console.Write("Digite o pulo: ");
        posicao = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < palavra.Length; i++)
        {
 //      Convertendo as letras para o codigo ASCII correspondente e usando a posição/pulo para descodificar:
            int cc = System.Convert.ToInt32(palavra[i]) - posicao;

            if (cc < 97)
                cc = cc + 26;

    //        Console.Write(cc + " ");

            concat += Char.ConvertFromUtf32(cc);


        }

        final = char.ToUpper(concat[0]) + concat.Substring(1);

        Console.WriteLine($"\n\nPalavra descodificada: {final}");
        break;

}

Console.ReadKey();  