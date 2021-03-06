﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiploma
{
    class Computer
    {
        /// <summary>
        /// C-tor with comp name
        /// </summary>
        /// <param name="name"></param>
        public Computer(string name, NetParams netParams)
        {
            m_name = name;
            m_warningCoast = netParams.wCoast;
            m_alertCoast = netParams.aCoast;

            m_warningAnalyzer.AddPlaceIn(m_input, m_warningCoast);
            m_warningAnalyzer.AddPlaceOut(m_warning);
            m_alertAnalyzer.AddPlaceIn(m_warning, m_alertCoast);
            m_alertAnalyzer.AddPlaceOut(m_alert);
            m_localFlushAnalyzer.AddPlaceIn(m_warning, 1);
            m_localFlushAnalyzer.AddPlaceOut(m_localFlush);
        }

        public void Reset()
        {
            // reset all places
            m_input.Reset();
            m_warning.Reset();
            m_alert.Reset();
            m_localFlush.Reset();
        }

        /// <summary>
        /// Check if mark count in alert place more then critical value
        /// </summary>
        /// <returns>True if no alerts</returns>
        public bool CheckAlert()
        {
            if (m_alert.GetCount() == 1) // hack to keep first time alert
            {
                return false;
            }
            return true;
        }

        public void TryWarning()
        {
            m_warningAnalyzer.CheckAndMake();
        }
        public void TryAlert()
        {
            m_alertAnalyzer.CheckAndMake();
        }
        public void TryLocalFlush()
        {
            m_localFlushAnalyzer.CheckAndMake();
        }

        public void AddInput(int mark)
        {
            m_input.AddMarks(mark);
        }


        /// <summary>
        /// Remove itself from previous flush
        /// and set to new flush
        /// </summary>
        public void ResetFlush(FlushSpot flush = null)
        {
            m_flush?.RemovePC(this);
            flush?.AddPc(this.m_input);
            m_flush = flush;
        }
         public PCState GetState()
        {
            PCState curState = new PCState();
            curState.inputPlace = m_input.GetCount();
            curState.warningPlace = m_warning.GetCount();
            curState.alertPlace = m_alert.GetCount();
            return curState;
        }

        private string m_name;
        private Place m_input = new Place();
        private Transition m_warningAnalyzer = new Transition();
        private Place m_warning = new Place();
        private FlushSpot m_flush;
        private Transition m_alertAnalyzer = new Transition();
        private Place m_alert = new Place();
        private Transition m_localFlushAnalyzer = new Transition();
        private Place m_localFlush = new Place();
        private int m_warningCoast = 2;
        private int m_alertCoast = 3;
    }
}
