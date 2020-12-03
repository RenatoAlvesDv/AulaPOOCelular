using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular note20 = new celular();
            Console.WriteLine(note20.cor = "Cor : white");
            Console.WriteLine(note20.modelo = "Modelo: Note 20 Ultra 256GB");
            Console.WriteLine(note20.tamanho = "Dimensões: 164.8 x 77.2 x 8.1 mm");
            

            Console.WriteLine("O celular está ligado?: s/n");
            string resposta = Console.ReadLine();
            if(resposta == "s"){
                note20.ligado = true;
            }else{
               note20.ligado = false;
            }               



            int opcao = 0;
           do
           {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[0] - Desligar");
                Console.WriteLine("[1] - Fazer Ligacão");
                Console.WriteLine("[2] - Enviar mensagem");

                opcao =int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                    Console.WriteLine(note20.Desligar());
                    break;
                    
                    case 1:
                    Console.WriteLine(note20.FazerLigacao());
                    break;
                    
                    case 2:
                    Console.WriteLine(note20.EnviarMensagem());
                    break;

                    default:
                    Console.WriteLine("Opção Inválida");
                    break;


                }
           
           
            } while (opcao !=0);


        }
    }
}
