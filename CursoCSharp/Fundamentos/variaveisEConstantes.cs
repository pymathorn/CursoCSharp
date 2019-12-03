using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class variaveisEConstantes
    {
        public static void Executar() 
        {
            //Calculo da area de uma circunferência 
            const double pi = 3.14159265358979;
            double raio = 0;
            double cir = 0;
            double area = 0;

            raio = 4.5;
            cir = (2 * raio) * pi;
            area = pi * (raio * raio);


            Console.WriteLine("A circunfêrencia é " + cir);
            Console.WriteLine("A Área é igual a " + (area + 100));

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? \n" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("A idade é " + idade);

            sbyte min = sbyte.MinValue;
            sbyte max = sbyte.MaxValue;
            Console.WriteLine("O valor minímo é " + min);
            Console.WriteLine("O valor máximo é " + max);

            short sal = short.MaxValue;
            short sal1 = short.MinValue;
            Console.WriteLine("O salário é de R$ " + sal);
            Console.WriteLine("O salário é de R$ " + sal1);

            int menorValInt = int.MinValue;
            int maiorValInt = int.MaxValue;
            Console.WriteLine("O maior e o menor valor de int são, respetivamente, " + maiorValInt + " e " + menorValInt);

            uint popBra = 400_000_000;
            Console.WriteLine("A população brasileira é de " + popBra + " pessoas");

            popBra = uint.MaxValue;
            Console.WriteLine("O valor máximo de um uint é de " + popBra);

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("O maior e o menor valor de long são " + maxLong + " e " + minLong);

            ulong popMun = 7_747_893_000;
            Console.WriteLine("A população mundial atual é de " + popMun + " pessoas" );

            float preçoComp = 1234.234f;
            Console.WriteLine("O preço do computador é " + preçoComp);

            double valordeMercadodaApple = 1_000_000_000_000.5623;
            Console.WriteLine("O valor de mercado da Apple é " + valordeMercadodaApple);

            decimal distEstrlas = decimal.MaxValue;
            decimal distEstrlas1 = decimal.MinValue;
            decimal distEstrlas2 = decimal.Zero;
            decimal distEstrlas3 = decimal.One;
            Console.WriteLine("A distância entre duas estrelas distantes é de " + distEstrlas);
            Console.WriteLine("A distância entre duas estrelas distantes é de " + distEstrlas1);
            Console.WriteLine("O zero é " + distEstrlas2);
            Console.WriteLine("O um é " + distEstrlas3);

            char letra = 'j';
            Console.WriteLine("Letra: " + letra);

            string str = "Seja bem vindo ao curso de C#!!!";
            Console.WriteLine(str);
        
        }
    }
}
