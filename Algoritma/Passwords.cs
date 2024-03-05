using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Passwords
    {
        private int SifreIndex;
        private string[] Sifreler = new string[10];
        private Random random = new();
       
       public char[] SifreSifreleme()
        {
            SifreIndex =random.Next(0,10);

            //tüm karakterler birbirinden farklı olacak ve 33 karakterli olacak şekilde yeniden düzenle
            //her biri farklı bir karakter ile başlasın

            Sifreler[0] = "1=x) şl+po!w:ğ/jıu'bv*qy?fc-re;a";
            Sifreler[1] = "2^z*ğo~k>mö$ş'l+ğ!ç=p-q,v|ö~r%üd";
            Sifreler[2] = "3%l?+üa'f)o:ş/=qıö|>hvgw;u*kyx#f";
            Sifreler[3] = "4üy/o-p^r:j$g'e+äıdöšhkýfcñl#f";
            Sifreler[4] = "5=x: šl+po!ğ/jıu'bv*qy?fc-re;üa";
            Sifreler[5] = "6v(wğ$a`m+fp:eö=öh#ıq%7:cznl1v";
            Sifreler[6] = "7/oğpçü+ı!ü3=da.6;v#zıfh&mçff";
            Sifreler[7] = "8xs-hızçq'mp.döeağvt:wj;*nu#l";
            Sifreler[8] = "9uıo;+x.qeyhp9jkszfbdm^lçtcv/a";
            Sifreler[9] = "0uw/o+p.ryh(çtjksxfzvdbe^lçc";


            char[] sifreler = Sifreler[SifreIndex].ToCharArray();
            return sifreler;
        }

        public char[] SifreÇözümleme(int x)
        {
            //tüm karakterler birbirinden farklı olacak ve 33 karakterli olacak şekilde yeniden düzenle
            //her biri farklı bir karakter ile başlasın

            Sifreler[0] = "1=x) şl+po!w:ğ/jıu'bv*qy?fc-re;a";
            Sifreler[1] = "2^z*ğo~k>mö$ş'l+ğ!ç=p-q,v|ö~r%üd";
            Sifreler[2] = "3%l?+üa'f)o:ş/=qıö|>hvgw;u*kyx#f";
            Sifreler[3] = "4üy/o-p^r:j$g'e+äıdöšhkýfcñl#f";
            Sifreler[4] = "5=x: šl+po!ğ/jıu'bv*qy?fc-re;üa";
            Sifreler[5] = "6v(wğ$a`m+fp:eö=öh#ıq%7:cznl1v";
            Sifreler[6] = "7/oğpçü+ı!ü3=da.6;v#zıfh&mçff";
            Sifreler[7] = "8xs-hızçq'mp.döeağvt:wj;*nu#l";
            Sifreler[8] = "9uıo;+x.qeyhp9jkszfbdm^lçtcv/a";
            Sifreler[9] = "0uw/o+p.ryh(çtjksxfzvdbe^lçc";


            char[] sifreler = Sifreler[x].ToCharArray();
            return sifreler;
        }

    }
}
