using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreDiploma;

namespace GUIDiploma
{
    public class NetCtrl
    {

        public void Initialize(NetParams netParams)
        {
            m_net.Initialize(netParams);
        }

        public void DoNextData()
        {
            m_net.NextInput();
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
            Dictionary<string, int> inputData = m_net.GetCurrentInput();
            foreach (var data in inputData)
            {                
                dgw.Rows[0].Cells[data.Key].Value = data.Value;
            }
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
            tbx.Text = stepName;
        }

        // members        
        NetMgr m_net = new NetMgr();
    }
}
