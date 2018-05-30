using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    public enum PetriNetStep
    {
        READY,
        INPUT,
        FLUSH,
        WARNING,
        ALERT
    }
    public class NetMgr
    {
        public void Initialize(NetParams netParams)
        {
            // first generators
            m_genMgr = new GeneratorsMgr(netParams.netSize, netParams.modelTime);
            // second net
            m_net = new PetriNet();
            m_net.Initialize(netParams);
            m_net.LoadStartInfo(m_genMgr.MakeStartData());
        }

        // next input
        public void NextInput()
        {
            m_currentInput = m_genMgr.MakeData();
        }

        // next step
        public void NextStep()
        {
            
            switch (m_step)
            {
                case PetriNetStep.READY:
                    NextInput();
                    m_net.LoadInfo(m_currentInput);
                    m_step = PetriNetStep.INPUT;
                    break;
                case PetriNetStep.INPUT:
                    m_net.FlushStep();
                    m_step = PetriNetStep.FLUSH;
                    break;
                case PetriNetStep.FLUSH:
                    m_net.WarningStep();
                    m_step = PetriNetStep.WARNING;
                    break;
                case PetriNetStep.WARNING:
                    if (++m_localFLushReady % 5 == 0)
                    {
                        m_localFLushReady = 0;
                        m_net.LocalFlushStep();
                    }
                    m_net.AlertStep();
                    m_step = PetriNetStep.ALERT;
                    break;
                case PetriNetStep.ALERT:
                    // here we need to get new data, may be set generators' output
                    m_net.CheckStep();
                    m_step = PetriNetStep.READY;
                    break;
            }
        }

        // current input
        public List<Tuple<string, int>> GetCurrentInput()
        {
            return m_currentInput;
        }

        // current net state
        public void GetNetState(out Dictionary<string, PCState> pcStates, out List<int> flushData)
        {
            m_net.GetStateMtx(out pcStates, out flushData);
        }

        public List<string> GetCurrentAlertInfo()
        {
            return m_net.GetCurrentAllertInfo();
        }

        public PetriNetStep GetNetStep()
        {
            return m_step;
        }

        // control functions
        public void SwitchGenerator(int num)
        {
            m_genMgr.SwitchGenerator(num);
        }

        public void Reset()
        {
            // reset net
            m_net.Reset();
            // reset generators
            m_genMgr.Reset();
            // set state to ready
            m_step = PetriNetStep.READY;
        }


        // members
        private int m_localFLushReady;
        private PetriNetStep m_step = PetriNetStep.READY;
        private GeneratorsMgr m_genMgr;
        private PetriNet m_net;
        private List<Tuple<string, int>> m_currentInput; // input for current iteration

    }
}
