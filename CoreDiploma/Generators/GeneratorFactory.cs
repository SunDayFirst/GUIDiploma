using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    public class GeneratorFactory
    {
        public IGenerator GetScenarioGenerator(int modTime, string name, Scenario scen  = Scenario.GOOD_WORK)
        {
            return new ScenarioGenerator(modTime, scen, name);
        }
    }
}
