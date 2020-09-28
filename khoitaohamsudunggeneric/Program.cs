using System;

namespace khoitaohamsudunggeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> ge = new Generic<int>();
            ge.SoSanh<int>(2, 2);
            ge.SoSanh<int>(2, 4);
            ge.SoSanh<string>("hai", "bon");
            ge.SoSanh<string>("hai", "hai");

        }
    }
}
