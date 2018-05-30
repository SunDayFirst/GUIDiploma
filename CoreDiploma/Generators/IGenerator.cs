using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    public enum GeneratorState
    {
        ON,
        OFF,
        GOOD_WORK,
        BAD_WORK,
        GOOD_SERVICE
    }

    public interface IGenerator
    {
        void Reset();
        Tuple<string, int> MakeData();
        Tuple<string, int> MakeStartData();
        void Switch(GeneratorState switchTo = GeneratorState.OFF);
    }
}
