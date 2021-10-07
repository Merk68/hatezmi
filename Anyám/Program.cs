using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anyám
{
  class Program
  {
    public static void Main()
    {
      int decn, wah, decnum = 0, i, j;
      int dik;
      int s;
      Console.Write("Decimálisból -> Hexadecimálisba");
      Console.Write("\n......................................\n");
      Console.Write("");

      Console.Write("Adj meg egy Decimális számot!: ");
      decn = Convert.ToInt32(Console.ReadLine());
      wah = decn;
      for (i = wah; i > 0; i = i / 16)
      {
        dik = i % 16;
        if (dik < 10)
        {

          dik = dik + 48;
        }
        else
        {
          dik = dik + 55;
          
        }
        decnum = decnum * 100 + dik;
      }
      Console.Write("Az ezzel egyenértékű Hexadecimális szám: ");
      for (j = decnum; j > 0; j = j / 100)
      {
        s = j % 100;
        Console.Write("{0}", (char)s);
      }
      Console.Write("\n......................................\n");
      Console.WriteLine("Szeretnél újabb értéket megadni?");
      Console.ReadKey();
    }
  }

}
