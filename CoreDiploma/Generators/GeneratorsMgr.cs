using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    public class GeneratorsMgr
    {
        /// <summary>
        /// Make pool of generators wthi number as PC name
        /// </summary>
        /// <param name="countPC"> number of PC in net </param>
        public GeneratorsMgr(int countPC, int modelTime, Scenario scenario)
        {
            m_modelingTime = modelTime;
            switch (scenario)
            {
                case Scenario.GOOD_WORK:
                    GoodWorkScenario(countPC);
                    break;
                case Scenario.BAD_WORK:
                    GoodWorkWIthTreatScenario(countPC);
                    break;
                case Scenario.GOOD_SERVICE:
                    GoodServiceScenario(countPC);
                    break;
                case Scenario.BAD_SERVICE:
                    GoodServiceWithTreatScenario(countPC);
                    break;
            }
        }


        public void GoodWorkScenario(int countPC)
        {
            GeneratorFactory factory = new GeneratorFactory();            
            for (int i = 0; i < countPC; ++i)
                m_generators.Add(factory.GetScenarioGenerator(m_modelingTime, i.ToString()));
        }

        public void GoodServiceScenario(int countPC)
        {
            GeneratorFactory factory = new GeneratorFactory();
            for (int i = 0; i < countPC; ++i)
                m_generators.Add(new ScenarioGenerator(m_modelingTime, Scenario.BAD_WORK, i.ToString(), 5, 55));
        }

        public void GoodWorkWIthTreatScenario(int countPC)
        {
            GeneratorFactory factory = new GeneratorFactory();
            for (int i = 0; i < countPC; ++i)
            {
                if (i%5 != 0)
                    m_generators.Add(factory.GetScenarioGenerator(m_modelingTime, i.ToString()));
                else
                    m_generators.Add(new ScenarioGenerator(m_modelingTime, Scenario.BAD_WORK, i.ToString(), 5, m_modelingTime));
            }
        }

        public void GoodServiceWithTreatScenario(int countPC)
        {
            GeneratorFactory factory = new GeneratorFactory();
            for (int i = 0; i < countPC; ++i)
            {
                if (i % 5 != 0)
                    m_generators.Add(new ScenarioGenerator(m_modelingTime, Scenario.BAD_WORK, i.ToString(), 5, 55));
                else
                    m_generators.Add(new ScenarioGenerator(m_modelingTime, Scenario.BAD_WORK, i.ToString(), 5, m_modelingTime));
            }
        }

        /// <summary>
        /// Generate start data for all PC
        /// </summary>
        /// <returns>one bad mark for every pc in pool</returns>
        public Dictionary<string, int> MakeStartData()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var gen in m_generators)
            {
                Tuple<string, int> curData = gen.MakeStartData();
                result.Add(curData.Item1, curData.Item2);
            }
            return result;
        }

        /// <summary>
        /// Generate data for all PC
        /// </summary>
        /// <returns>all marks for pc</returns>
        public List<Tuple<string, int>> MakeData()
        {
            List<Tuple<string, int>> result = new List<Tuple<string, int>>();
            foreach (var gen in m_generators)
            {
                Tuple<string,int> curData = gen.MakeData();
                result.Add(curData);
            }
            return result;
        }

        internal void Reset()
        {
            foreach (var gen in m_generators)
                gen.Reset();
        }

        // members
        private List<IGenerator> m_generators = new List<IGenerator>();
        private int m_modelingTime;
    }
}
