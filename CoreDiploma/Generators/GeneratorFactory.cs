using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    public class GeneratorFactory
    {
        public IGenerator GetDummyGenerator(string name)
        {
            return new Generator(name);
        }
        //  public List<IGenerator> GetScenarioGenerator(int countPC)
        //  {
        //      List<IGenerator> result = new List<IGenerator>();
        //  }
        public IGenerator GetScenarioGenerator(int modTime, string name, GeneratorState state  = GeneratorState.GOOD_WORK)
        {
            return new ScenarioGenerator(modTime, state, name);
        }
    }
}
