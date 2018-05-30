using System;
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
            NetCtrl.StatsControls statCtrls = new NetCtrl.StatsControls();
            statCtrls.m_netState = dataGW;
            statCtrls.m_currentModelTime = currentModelTime_lbl;
            statCtrls.m_currentNetStep = step_lbl;
            statCtrls.m_inform = infor_lbl;
            m_netCtrl.SetStatControls(statCtrls);
        }

        // members
        NetCtrl m_netCtrl = new NetCtrl();

        private void OnLoad()
        {
            netSize_tbx.Text = Convert.ToString(15);
            cellSize_tbx.Text = Convert.ToString(5);
            wCoast_tbx.Text = Convert.ToString(2);
            aCoast_tbx.Text = Convert.ToString(3);
            modelTime_tbx.Text = Convert.ToString(60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get parameters
            NetParams netParams = new NetParams();
            netParams.netSize = int.Parse(netSize_tbx.Text);
            netParams.cellSize = int.Parse(cellSize_tbx.Text);
            netParams.wCoast = int.Parse(wCoast_tbx.Text);
            netParams.aCoast = int.Parse(aCoast_tbx.Text);
            netParams.modelTime = int.Parse(modelTime_tbx.Text);

            //clear
            dataGW.Columns.Clear();

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

        private void start_btn_Click(object sender, EventArgs e)
        {
            m_netCtrl.Start();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            m_netCtrl.Stop();
        }
    }
}
