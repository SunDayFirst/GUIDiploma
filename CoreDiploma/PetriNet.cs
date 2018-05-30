using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    public class PCState
    {
        public int inputPlace;
        public int warningPlace;
        public int alertPlace;
    }

    public class NetParams
    {
        public int netSize;
        public int cellSize;
        public int wCoast;
        public int aCoast;
        public int modelTime;
    }

    public class PetriNet
    {
        /// <summary>
        /// Creat all pc by name in dictionary
        /// Ignore values
        /// </summary>
        /// <param name="data">input pool of pc</param>
        public void LoadStartInfo(Dictionary<string, int> data)
        {
            foreach (var d in data)
            {
                AddPC(d.Key, m_netParams);
            }
        }

        /// <summary>
        /// Load marks to PC's input by PC's name
        /// If storage contains no name, PC will be created and added to net
        /// </summary>
        /// <param name="data">marks assosiated with PC's name</param>
        public void LoadInfo(List<Tuple<string, int>> data)
        {
            foreach(var d in data)
            {
                if (m_pcStorage.ContainsKey(d.Item1))
                    m_pcStorage[d.Item1].AddInput(d.Item2);
                else // add new pc
                {
                    AddPC(d.Item1, m_netParams);
                    m_pcStorage[d.Item1].AddInput(d.Item2);
                }
            }
        }

        public bool AddPC(string name, NetParams netParams)
        {
            if (m_pcStorage.ContainsKey(name))
                return false;
            Computer newPc = new Computer(name, netParams);
            SetFlushToPC(newPc);
            m_pcStorage.Add(name, newPc);
            return true;
        }


        private void SetFlushToPC(Computer pc)
        {
            // find avaliable flushSpot
            bool find = false;
            foreach (var fl in m_flushes)
                if (fl.Capacity() < m_cellSize)
                {
                    pc.ResetFlush(fl);
                    find = true;
                }
            if (!find)
            { // create new fluch
                var newFlush = new FlushSpot();
                pc.ResetFlush(newFlush);
                m_flushes.Add(newFlush);
            }            
        }

        /// <summary>
        /// Make flush transition if permitted
        /// </summary>
        public void FlushStep()
        {
            foreach (var fl in m_flushes)
                fl.TryFlush();
        }

        /// <summary>
        /// Make warning transition if permited
        /// </summary>
        public void WarningStep()
        {
            foreach (var pc in m_pcStorage)
                pc.Value.TryWarning();
        }

        /// <summary>
        /// Make alert transition if permited
        /// </summary>
        public void AlertStep()
        {
            foreach (var pc in m_pcStorage)
                pc.Value.TryAlert();
        }
        public void LocalFlushStep()
        {
            foreach (var pc in m_pcStorage)
                pc.Value.TryLocalFlush();
        }

        /// <summary>
        /// Check every PC
        /// If failed, remove from flush
        /// </summary>
        public void CheckStep()
        {
            m_currentAlertInform.Clear();
            foreach (var pc in m_pcStorage)
                if (!pc.Value.CheckAlert())
                {
                    m_currentAlertInform.Add(pc.Key);
                    //   pc.Value.ResetFlush();
                }
        }

        public void Reset()
        {
            // reset all PC
            foreach (var pc in m_pcStorage)
                pc.Value.Reset();
            // reset all FlushSpots
            foreach (var flush in m_flushes)
                flush.Reset();
        }

        // view i-face
        public void GetStateMtx(out Dictionary<string, PCState> pcStates, out List<int> flushData)
        {
            pcStates = new Dictionary<string, PCState>();
            foreach (var pc in m_pcStorage)
            {
                string curName = pc.Key;
                PCState curState = pc.Value.GetState();
                pcStates.Add(curName, curState);
            }
            flushData = new List<int>();
            foreach (var fl in m_flushes)
                flushData.Add(fl.MarksCount());
        }

        public List<string> GetCurrentAllertInfo()
        {
            return m_currentAlertInform;
        }

        // properties
        /// <summary>
        /// returns number of computer in net
        /// </summary>
        /// <returns>number of computer in net</returns>
        public int GetSize()
        {
            return m_pcStorage.Count;
        }

        public void Initialize(NetParams netParams)
        {
            m_netParams = netParams;
        }

        // members
        private Dictionary<string, Computer> m_pcStorage = new Dictionary<string, Computer>();
        private List<FlushSpot> m_flushes = new List<FlushSpot>();
        private int m_cellSize = 5;
        private NetParams m_netParams = new NetParams();
        private List<string> m_currentAlertInform= new List<string>();
    }
}
