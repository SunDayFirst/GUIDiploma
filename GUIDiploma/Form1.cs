﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreDiploma;

namespace GUIDiploma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OnLoad();
        }

        // members
        NetCtrl m_netCtrl = new NetCtrl();

        private void OnLoad()
        {
            netSize_tbx.Text = Convert.ToString(15);
            cellSize_tbx.Text = Convert.ToString(5);
            wCoast_tbx.Text = Convert.ToString(2);
            aCoast_tbx.Text = Convert.ToString(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get parameters
            NetParams netParams = new NetParams();
            netParams.netSize = int.Parse(netSize_tbx.Text);
            netParams.cellSize = int.Parse(cellSize_tbx.Text);
            netParams.wCoast = int.Parse(wCoast_tbx.Text);
            netParams.aCoast = int.Parse(aCoast_tbx.Text);

            // initialize
            for (int i = 0; i < netParams.netSize; ++i)
            {
                var column1 = new DataGridViewColumn();
                column1.HeaderText = i.ToString(); //текст в шапке
                column1.Width = 20; //ширина колонки
                column1.ReadOnly = true; //значение в этой колонке нельзя править
                column1.Name = i.ToString(); //текстовое имя колонки, его можно использовать вместо обращений по индексу
                column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                dataGW.Columns.Add(column1);
            }
            dataGW.RowCount = 5;
            // set
            dataGW.Rows[0].HeaderCell.Value = "Generator";
            dataGW.Rows[1].HeaderCell.Value = "Input";
            dataGW.Rows[2].HeaderCell.Value = "Warning";
            dataGW.Rows[3].HeaderCell.Value = "Alert";
            dataGW.Rows[4].HeaderCell.Value = "Flush";
            dataGW.RowHeadersWidth = 100;
            // initialixe petri net
            m_netCtrl.Initialize(netParams);            
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            // do next step
            m_netCtrl.DoNextStep();
            // load 
            m_netCtrl.SetNetState(dataGW);
            m_netCtrl.SetNetStep(step_lbl);
        }

        private void nextData_btn_Click(object sender, EventArgs e)
        {
            // generate next data
            m_netCtrl.DoNextData();
                      
            // clear previous data
            for (int i = 0; i < dataGW.Columns.Count; ++i)
            {
                dataGW[i, 0].Value = null;
            }
            
            // show next data
            m_netCtrl.SetInputData(dataGW);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            m_netCtrl.SwitchGenerator(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            m_netCtrl.SwitchGenerator(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            m_netCtrl.SwitchGenerator(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            m_netCtrl.SwitchGenerator(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            m_netCtrl.SwitchGenerator(4);
        }

    }
}