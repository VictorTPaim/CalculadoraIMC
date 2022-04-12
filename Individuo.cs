public class Individuo
{
    public String Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double PesoNecessarioGanhar { get => ((Altura * Altura) * 18.5) - Peso; }
    public double PesoNecessarioPerder { get => (Peso - (Altura * Altura) * 24.99); }
    public Individuo(String nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    } 
    public double Imc { get => Peso / (Altura * Altura); }

    public string NivelPeso(){
        if (Imc < 17){
            return "Você está muito abaixo do peso";
        }
        else if(Imc < 18.50){
            return "Você está abaixo do peso";
        }
        else if(Imc < 25){
            return "Você está no peso ideal";
        }
        else if(Imc < 30){
            return "Você está acima do peso";
        }
        else if(Imc < 35){
            return "Você está no nivel 1 de obesidade";
        }
        else if(Imc < 40){
            return "Você está no nível 2 de obesidade (severa)";
        }
        else{
            return "Você está no nível 3 de obesidade (mórbida)";
        }
    }

    public string PesoIdeal()
    {
        if(Imc < 18.5)
        {   
            return "Você precisa engordar "+ PesoNecessarioGanhar +" quilos para chegar ao IMC ideal.";
        }
        if(Imc > 24.99)
        {           
            return "Você precisa emagrecer " + PesoNecessarioPerder +" quilos para chegar ao IMC ideal.";
        }
        else {
            return "Parabéns";
        }
    }
}