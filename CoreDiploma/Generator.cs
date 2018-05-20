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
        OFF
    }

    class Generator : IGenerator
    {
        public Generator(string pcName)
        {
            m_pcName = pcName;
        }

        /// <summary>
        /// Generate data based on state
        /// </summary>
        /// <returns>pc name + mark count</returns>
        public Tuple<string, int> MakeData()
        {
            if (m_state == GeneratorState.ON)
                return new Tuple<string, int>(m_pcName, 1);
            else
                return new Tuple<string, int>(m_pcName, 0);
        }

        /// <summary>
        /// Make data to start net
        /// </summary>
        /// <returns>pc name + 1 mark</returns>
        public Tuple<string, int> MakeStartData()
        {
            return new Tuple<string, int>(m_pcName, 1);        
        }

        public void Switch() // @AU switch to bool?
        {
            if (m_state == GeneratorState.OFF)
                m_state = GeneratorState.ON;
            else
                m_state = GeneratorState.OFF;
        }

        // members
        private GeneratorState m_state = GeneratorState.ON;
        private string m_pcName;
    }
}
