using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges02
{
    public abstract class BaseCookie
    {
        public string Name { get; set; }
        public string Brand()
        {
            return "Oregon Organic Cookie Company";
        }

        public abstract string Ingredients();
    }

    public class PlainCookie : BaseCookie
    {
        public override string Ingredients()
        {
            BaseCookie cookie = new PlainCookie();
            Console.WriteLine(cookie.Ingredients());
            return "2 cups flour, 1/2 cup butter, 1 egg, 1 cup sugar";
        }

    }

    public class ChocoChipCookie : PlainCookie
    {
        public override string Ingredients()
        {
            return base.Ingredients() + ", 1 cup chocolate chips";
        }
    }

}