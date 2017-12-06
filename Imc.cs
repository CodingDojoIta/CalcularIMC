namespace ConsoleApplication
{
    public class Imc
    {
        public float calculoImc(float peso, float altura)
        {
            return peso / (altura * altura); // calcula IMC
        }

        public string classificacao(float imc)
        {
            if (imc <= 18.5)
                return "Abaixo do peso";

            else if ((imc > 18.5) && (imc < 25))
                return "Peso ideal (Parabéns)";

            else if ((imc >= 25) && (imc < 30))
                return "Levemente acima do peso";

            else if ((imc >= 30) && (imc < 35))
                return "Obesidade grau I";

            else if ((imc >= 35) && (imc < 40))
                return "Obesidade grau II (severa)";

            else if (imc >= 40)
                return "Obesidade Grau III (mórbida)";

            return string.Empty; // Esse return está aqui pois é necessário, mas ele nunca irá chegar aqui.
        }
        
    }
}
