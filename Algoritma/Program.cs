using Algoritma;
internal class Program
{
    private static void Main(string[] args)
    {
        #region Değişkenler

        string Alfabe = "abcçdefgğhıijklmnoöp rstuüvyzqwx";
        char[] alfabe = Alfabe.ToCharArray();

        Algoritma.Convert convert = new();
        Passwords sifre = new();

        #endregion

        convert.Sifrele(alfabe, sifre.SifreSifreleme());

        convert.Çözümle(alfabe);

        

    }
}