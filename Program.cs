using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu nome?");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual sua altura em metros? Ex.: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual seu peso em Kg? Ex.: 65,5");
            float peso = Convert.ToSingle(Console.ReadLine());

            Individuo i1 = new Individuo(nome, altura, peso);

            Console.WriteLine("{0}, sua altura é: {1} e seu peso é: {2}", nome, altura, peso);

            Console.WriteLine("Seu IMC é {0}", imc);

            if (imc < 17){
                Console.WriteLine("Você está muito abaixo do peso");
            }
            else if(imc < 18.50){
                Console.WriteLine("Você está abaixo do peso");
            }
            else if(imc < 25){
                Console.WriteLine("Você está no peso ideal");
            }
            else if(imc < 30){
                Console.WriteLine("Você está acima do peso");
            }
            else if(imc < 35){
                Console.WriteLine("Você está no nivel 1 de obesidade");
            }
            else if(imc < 40){
                Console.WriteLine("Você está no nível 2 de obesidade (severa)");
            }
            else{
                Console.WriteLine("Você está no nível 3 de obesidade (mórbida)");
            }

            if(imc < 18.5){
                double pesoNecessario = ((altura * altura) * 18.5) - peso;
                Console.WriteLine("Você precisa engordar {0} quilos para chegar ao IMC ideal.", pesoNecessario);
            }
            if(imc > 24.99){
                double pesoNecessario = peso - ((altura * altura) * 24.99);
                Console.WriteLine("Você precisa emagrecer {0} quilos para chegar ao IMC ideal.", pesoNecessario);
            }
        }
    }
}
