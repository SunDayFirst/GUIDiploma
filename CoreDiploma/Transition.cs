using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    class Transition
    {
        /// <summary>
        /// to do checking and making transition atomic
        /// </summary>
        public void CheckAndMake()
        {
            if (IsPermited())
                MakeIt();
        }

        /// <summary>
        /// Check if transition is permited
        /// </summary>
        /// <returns>true if permited</returns>
        private bool IsPermited()
        {
            foreach (var pair in m_IN)
                if (!pair.Item1.IfHasMarks(pair.Item2))
                    return false;
            return true;
        }

        /// <summary>
        /// Makes transition by removing cost from incoming arc and adding one mark to any outgoing arc
        /// Should be made just after checking if transition is possible
        /// </summary>
        private void MakeIt()
        {
            foreach (var pair in m_IN)
                pair.Item1.RemoveMarks(pair.Item2);
            foreach (var p in m_OUT)
                p.AddMarks(1);
        }

        public int CapasityIn()
        {
            return m_IN.Count;
        }

        public void AddPlaceIn(Place pls, int coast)
        {
            m_IN.Add(new Tuple<Place,int>( pls, coast));
        }

        public void AddPlaceOut(Place pls)
        {
            m_OUT.Add(pls);
        }

        // members
        private List<Tuple<Place, int>> m_IN = new List<Tuple<Place, int>>(); // list of incoming arcs with it's cost
        private List<Place> m_OUT = new List<Place>(); // list of outgoing arcs. prise is alwayse equal to 1

    }
}
