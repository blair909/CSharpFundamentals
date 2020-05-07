using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{

    public class SCCalcRepository
    {
        protected readonly List<SCCalc> _contentDirectory = new List<SCCalc>();

        public bool AddContentToDirectory(SCCalc content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
            //_contentDirectory.Add(content);
        }

        public List<SCCalc> GetContent()
        {
            return _contentDirectory;
        }

        public int IntProduct(int product01, int product02)
        {
            return product01 * product02;
        }
        public double DoubleProduct(double product01, double product02)
        {
            return product01 * product02;
        }
    }
}
