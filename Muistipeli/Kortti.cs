using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _120_Muistipeli
{
    public class Kortti
    {
      public Random random = new Random();
      public int ranNum = 0;

       public List<string> kuviot = new List<string>()
        {
            "!","!","¤","¤","U","U","Q","Q",
            "f","f","l","l","i","i","N","N"
        };
    }
}
