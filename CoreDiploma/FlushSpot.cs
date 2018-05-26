using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    class FlushSpot
    {
        public FlushSpot()
        {
            m_incomingT.AddPlaceOut(m_store);
        }
        public void TryFlush()
        {
            m_incomingT.CheckAndMake();
        }
        public void AddPc(Place inputPls, int coast = 1)
        {
            m_incomingT.AddPlaceIn(inputPls, coast);
        }
        public void RemovePC(Computer cmp)
        {

        }

        /// <summary>
        /// Returns current count of active incoming place
        /// </summary>
        /// <returns>current count of active incoming place</returns>
        public int Capacity()
        {
            return m_incomingT.CapasityIn();
        }

        public int MarksCount()
        {
            return m_store.GetCount();
        }

        public void Reset()
        {
            m_store.Reset();
        }

        // members
        private Transition m_incomingT = new Transition();
        private Place m_store = new Place();
        private int m_transitionCoast = 1;


    }
}
