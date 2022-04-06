public class Individuo
{
    public String Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public Individuo(String nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }
    public double Imc { get => Peso / (Altura * Altura); }

    public string NivelPeso(Double imc){
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
    }

}