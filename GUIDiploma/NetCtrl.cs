using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreDiploma;

namespace GUIDiploma
{


    public class NetCtrl
    {
        public class StatsControls
        {
            public DataGridView m_netState;
            public Label m_currentModelTime;
            public Label m_currentNetStep;
        }

        public void Initialize(NetParams netParams)
        {
            m_net.Initialize(netParams);
            m_modelTime = netParams.modelTime;
            TimerCallback tm = new TimerCallback(OnTimer);
            m_timer = new System.Threading.Timer(tm, 0,Timeout.Infinite, 1000);
        }

        public void DoNextData()
        {
            m_net.NextInput();
        }

        public void SetStatControls(NetCtrl.StatsControls statCtrls)
        {
            m_statCtrl = statCtrls;
        }

        public void DoNextStep()
        {
            m_net.NextStep();
        }

        public void SwitchGenerator(int num)
        {
            m_net.SwitchGenerator(num);
        }

        // current incoming data
        public void SetInputData(DataGridView dgw)
        {
            // clear previous data
            for (int i = 0; i < dgw.Columns.Count; ++i)
                dgw[i, 0].Value = null;

            // set new data
            List<Tuple<string, int>> inputData = m_net.GetCurrentInput();
            foreach (var data in inputData)      
                dgw.Rows[0].Cells[data.Item1].Value = data.Item2;

        }
        // current petri state
        public void SetNetState(DataGridView dgw)
        {
            // clean previous data
            for (int i = 0; i < dgw.Columns.Count; ++i)
            {
                for (int j = 1; j < dgw.RowCount; ++j)
                    dgw[i, j].Value = null;
            }
            Dictionary<string, PCState> pcStates;
            List<int> flushData;
            m_net.GetNetState(out pcStates, out flushData);

            // place new data
            foreach (var pcData in pcStates)
            {
                if (pcData.Value.inputPlace > 0)
                    dgw.Rows[1].Cells[pcData.Key].Value = pcData.Value.inputPlace;
                if (pcData.Value.warningPlace > 0)
                    dgw.Rows[2].Cells[pcData.Key].Value = pcData.Value.warningPlace;
                if (pcData.Value.alertPlace > 0)
                    dgw.Rows[3].Cells[pcData.Key].Value = pcData.Value.alertPlace;
            }

            int fkCnt = 0;
            foreach (var fl in flushData)
            {
                if (fl > 0)
                    dgw.Rows[4].Cells[fkCnt++].Value = fl; 
            }
        }
        // current petri step 
        public void SetNetStep(Label tbx)
        {
            string stepName = "";
            switch (m_net.GetNetStep())
            {
                case PetriNetStep.READY:
                    stepName = "Ready";
                    break;
                case PetriNetStep.INPUT:
                    stepName = "Input";
                    break;
                case PetriNetStep.FLUSH:
                    stepName = "Flush";
                    break;
                case PetriNetStep.WARNING:
                    stepName = "Warning";
                    break;
                case PetriNetStep.ALERT:
                    stepName = "Alert";
                    break;
            }

            Action action = () =>
            {
                tbx.Text = stepName;
            };
            if (tbx.InvokeRequired)
            {
                tbx.Invoke(action);
            }
        }

        public void Start()
        {
            Reset();
            m_timer.Change(0, 1000);
        }

        public void OnTimer(object target)
        {
            if ( m_curModelTime < m_modelTime)
            {
                ++m_curModelTime;
                m_net.NextStep();
                SetNetState(m_statCtrl.m_netState);
                SetNetStep(m_statCtrl.m_currentNetStep);
                SetInputData(m_statCtrl.m_netState);
                Action action = () =>
                {
                    m_statCtrl.m_currentModelTime.Text = m_curModelTime.ToString(); 
                };
                m_statCtrl.m_currentModelTime.Invoke(action);

            }
            else
            {
                // stop this
                m_timer.Change(0, Timeout.Infinite);
            }
        }

        internal void Stop()
        {
            m_timer.Change(0, Timeout.Infinite);
            Reset();
        }

        public void Reset()
        {
            m_curModelTime = 0;
            m_net.Reset();
            // reset all controls
            for (int i = 0; i < m_statCtrl.m_netState.Columns.Count; ++i)
            {
                for (int j = 0; j < m_statCtrl.m_netState.Rows.Count; ++j)
                    m_statCtrl.m_netState[i, j].Value = null;
            }
            m_statCtrl.m_currentModelTime.ResetText();
            m_statCtrl.m_currentNetStep.ResetText();
        }

        // member
        int m_modelTime; 
        int m_curModelTime;
        NetMgr m_net = new NetMgr();
        StatsControls m_statCtrl;
        private System.Threading.Timer m_timer;
    }
}
