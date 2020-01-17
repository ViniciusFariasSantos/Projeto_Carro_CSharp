using System;

namespace Veiculo_2
{
    class Program
    {

        public string cor = "Azul";
        public string Marca;
        public string Modelo;
        public string placa;

        public double km;
        public bool isLigado;
        public int combustiveis = 100;
        public int velocidade = 20;
        public double preco;




        public void ligar()
        {
            isLigado = true;
            Console.WriteLine("O Carro esta ligado e andando a  " +  velocidade +" km/h");

        }





        public void acelerar(int quantidade)
        {
            if (isLigado)
            {
                velocidade += quantidade;
                combustiveis--;
                Console.WriteLine("Você acelerou, seu veiculos está  a   " + velocidade + " km/h ");
            }
            else
            {
                Console.WriteLine("O Carro esta desligado");
            }
        }
        
        
        
        
        
        
        public void frear(int quantidade)
        {
            if ((isLigado == true)&&(velocidade != 0))
            {
                velocidade -= quantidade;

                Console.WriteLine("Você freou, seu veiculo está a  " + velocidade + " km/h ");
            }
            else
            {

                Console.WriteLine("O Carro esta desligado");
            }
        }

        public void abastecer(int qtdLitros)
        {
            
            if (combustiveis < 100)
            {
                if (isLigado == false)
                {

                    combustiveis = combustiveis + qtdLitros;

                    if (combustiveis > 100)
                    {
                        int x = combustiveis - 100;
                        combustiveis = combustiveis - x;

                        Console.WriteLine("seu limite de abastecer excedeu, limitamos  até " + combustiveis + "  litros  para evitar acidente.");


                    }

                    Console.WriteLine("seu tanque está  " + combustiveis + "  litros");

                }
                else
                {


                    Console.WriteLine("Seu carro esta em movimento, você não pode abastecer");


                }
                
            }
        }
        
        
        
        
        
        public void desligado() {

           

            if (velocidade == 0) {

                isLigado = false;

                Console.WriteLine("Seu carro está desligado");

            }
            else {
                Console.WriteLine("Você precisa Frear o carro, para poder desligar  ");
            }
        
        }



        void pintar(String novCor)
        {
            Console.WriteLine("Sua cor atual é  " + cor);
            Console.WriteLine("Escolhe uma cor ");
            cor = novCor;
            Console.WriteLine("Sua nova cor é " + cor);
        }



    }

}

