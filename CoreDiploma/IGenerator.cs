using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    interface IGenerator
    {
        Tuple<string, int> MakeData();
        Tuple<string, int> MakeStartData();
        void Switch();
    }
}
