namespace AulaPOOCelular
{
    public class celular
    {
        
        // - Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
        // - Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
        // - Só será possível executar tais métodos se o celular estiver ligado.


        public string cor;

        public string modelo;

        public string tamanho;

        public bool ligado;
        
        
        public string Desligar()
        {
            ligado = false;
            return "desligando...";
        }
 
        public string FazerLigacao(){
            return "Digite o número";

        }

        public string EnviarMensagem(){
            return "Enviando";
        }



    }
}