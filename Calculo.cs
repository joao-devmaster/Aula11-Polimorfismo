namespace Aula11POO
{
    public class Calculo
    {
        public string calcularVelocidade(){
            return "Não houve nenhum calculo a ser aplicado";
        
        }
        public string calcularVelocidade(int velocidade){
            return "A Velocidade do jogador é "+ velocidade;
        }

        public string calcularVelocidade(int velocidade, int nitro){
            return "A Velocidade do Jogador é "+( velocidade +nitro);

   

           
            


        }


    }
}