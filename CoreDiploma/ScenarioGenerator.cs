﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    
    class ScenarioGenerator : IGenerator
    {
        public ScenarioGenerator(int modelTime, GeneratorState state, string name)
        {
            if (modelTime <= 0)
                throw new ArgumentNullException();

            m_pcName = name;
            m_data = new int[modelTime];
            if ( state == GeneratorState.GOOD_WORK)
            {
                int noBadTime = 0;
                for (int i = 0; i < modelTime; ++i)
                {
                    if (noBadTime == 0 && m_rnd.Next(100) > 90)
                    {
                        noBadTime = 5;
                        int badSampleCnt = m_rnd.Next(5);
                        for (int j = 0; j < badSampleCnt && i < modelTime; ++j, ++i)
                        {
                            m_data[i] = 1;
                        }
                    }
                    m_data[i] = 0;
                }
            }
            else if(state == GeneratorState.BAD_WORK)
            {
                for (int i = 0; i < modelTime; ++i)
                {
                    m_data[i] = 1;
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public Tuple<string, int> MakeData()
        {
            ++m_indx;
            m_indx %= m_data.Length - 1;
            return new Tuple<string, int>(m_pcName, m_data[m_indx]);

        }
        public Tuple<string, int> MakeStartData()
        {
            return new Tuple<string, int>(m_pcName, m_data[0]);
        }

        public void Switch(GeneratorState switchTo = GeneratorState.OFF)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            m_indx = 0;
        }

        private int m_indx;
        private string m_pcName;
        private int[] m_data;
        static private Random m_rnd = new Random(); // to use one random
    }
}