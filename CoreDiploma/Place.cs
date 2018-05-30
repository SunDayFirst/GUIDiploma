using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    class Place
    {
        public void AddMarks(int cnt = 1)
        {
            m_markCount += cnt;
        }
        public void RemoveMarks(int cnt = 1)
        {
            m_markCount -= cnt;
            Debug.Assert(m_markCount >= 0);
        }
        public bool IfHasMarks(int cnt)
        {
            return cnt <= m_markCount;
        }
        public int GetCount()
        {
            return m_markCount;
        }
        internal void Reset()
        {
            m_markCount = 0;
        }
        // members
        private int m_markCount;
    }
}
