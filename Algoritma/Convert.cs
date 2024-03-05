using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Convert
    {
        private string? inputSifrele;
        private string? inputÇözümle;
        char[] sifreler;
        public void Sifrele( char[] alfabe, char[] sifreler)
        {
            Console.WriteLine("Metin girin");
            inputSifrele = Console.ReadLine();
            inputSifrele = inputSifrele.ToLower();
            char[] Karakterler = inputSifrele.ToCharArray();

            for (int j = 0; j < inputSifrele.Length; j++)
            {
                for (int i = 0; i < alfabe.Length; i++)
                {
                    if (Karakterler[j] == alfabe[i])
                    {
                        Karakterler[j] = sifreler[i];
                        break;
                    }
                }
            }

          Console.WriteLine(Karakterler);
        }
        public void Çözümle(char[] alfabe)
        {
            //Tüm mesajların başına 'a' harfi yazılmalı
            Passwords passwords = new Passwords();
            Console.WriteLine("Metin girin");

            inputÇözümle = Console.ReadLine();
            inputÇözümle = inputÇözümle.ToLower();
            char[] Karakterler = inputÇözümle.ToCharArray();

            switch(Karakterler[0])
            { 
                case '1': 
                    sifreler = passwords.SifreÇözümleme(0);
                    break;
                case '2': 
                    sifreler = passwords.SifreÇözümleme(1);
                    break;
                case '3':
                    sifreler = passwords.SifreÇözümleme(2);
                    break;
                case '4':
                    sifreler = passwords.SifreÇözümleme(3);
                    break;
                case '5':
                    sifreler = passwords.SifreÇözümleme(4);
                    break;
                case '6':
                    sifreler = passwords.SifreÇözümleme(5);
                    break;
                case '7':
                    sifreler = passwords.SifreÇözümleme(6);
                    break;
                case '8':
                    sifreler = passwords.SifreÇözümleme(7);
                    break;
            }

            for (int i = 0; i < Karakterler.Length; i++)
            {
                for (int j = 0; j < sifreler.Length; j++)
                {
                    if (Karakterler[i] == sifreler[j])
                    {
                        Karakterler[i] = alfabe[j];
                        break;
                    }
                }
            }
            Console.WriteLine(Karakterler);
        }
    }
}
