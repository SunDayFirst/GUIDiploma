namespace GUIDiploma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGW = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.step_lbl = new System.Windows.Forms.Label();
            this.Controls_gb = new System.Windows.Forms.GroupBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.params_gb = new System.Windows.Forms.GroupBox();
            this.modelTime_tbx = new System.Windows.Forms.TextBox();
            this.modelTime_lbl = new System.Windows.Forms.Label();
            this.aCoast_tbx = new System.Windows.Forms.TextBox();
            this.aCoast_lbl = new System.Windows.Forms.Label();
            this.wCoast_tbx = new System.Windows.Forms.TextBox();
            this.wCoast_lbl = new System.Windows.Forms.Label();
            this.cellSize_tbx = new System.Windows.Forms.TextBox();
            this.cellSize_lbl = new System.Windows.Forms.Label();
            this.netSize_tbx = new System.Windows.Forms.TextBox();
            this.netSize_lbl = new System.Windows.Forms.Label();
            this.curModelTimeTitle_lbl = new System.Windows.Forms.Label();
            this.curentStepTitle_lbl = new System.Windows.Forms.Label();
            this.currentModelTime_lbl = new System.Windows.Forms.Label();
            this.stat_gbx = new System.Windows.Forms.GroupBox();
            this.infor_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).BeginInit();
            this.Controls_gb.SuspendLayout();
            this.params_gb.SuspendLayout();
            this.stat_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGW
            // 
            this.dataGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGW.Location = new System.Drawing.Point(79, 65);
            this.dataGW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGW.Name = "dataGW";
            this.dataGW.RowTemplate.Height = 24;
            this.dataGW.Size = new System.Drawing.Size(736, 197);
            this.dataGW.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Initialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // step_lbl
            // 
            this.step_lbl.AutoSize = true;
            this.step_lbl.Location = new System.Drawing.Point(111, 418);
            this.step_lbl.Name = "step_lbl";
            this.step_lbl.Size = new System.Drawing.Size(58, 17);
            this.step_lbl.TabIndex = 10;
            this.step_lbl.Text = "Initialize";
            // 
            // Controls_gb
            // 
            this.Controls_gb.Controls.Add(this.stop_btn);
            this.Controls_gb.Controls.Add(this.start_btn);
            this.Controls_gb.Location = new System.Drawing.Point(79, 518);
            this.Controls_gb.Margin = new System.Windows.Forms.Padding(4);
            this.Controls_gb.Name = "Controls_gb";
            this.Controls_gb.Padding = new System.Windows.Forms.Padding(4);
            this.Controls_gb.Size = new System.Drawing.Size(736, 167);
            this.Controls_gb.TabIndex = 11;
            this.Controls_gb.TabStop = false;
            this.Controls_gb.Text = "Controls";
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(143, 41);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(4);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(100, 28);
            this.stop_btn.TabIndex = 6;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(21, 41);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(100, 28);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // params_gb
            // 
            this.params_gb.Controls.Add(this.modelTime_tbx);
            this.params_gb.Controls.Add(this.modelTime_lbl);
            this.params_gb.Controls.Add(this.aCoast_tbx);
            this.params_gb.Controls.Add(this.button1);
            this.params_gb.Controls.Add(this.aCoast_lbl);
            this.params_gb.Controls.Add(this.wCoast_tbx);
            this.params_gb.Controls.Add(this.wCoast_lbl);
            this.params_gb.Controls.Add(this.cellSize_tbx);
            this.params_gb.Controls.Add(this.cellSize_lbl);
            this.params_gb.Controls.Add(this.netSize_tbx);
            this.params_gb.Controls.Add(this.netSize_lbl);
            this.params_gb.Location = new System.Drawing.Point(884, 65);
            this.params_gb.Margin = new System.Windows.Forms.Padding(4);
            this.params_gb.Name = "params_gb";
            this.params_gb.Padding = new System.Windows.Forms.Padding(4);
            this.params_gb.Size = new System.Drawing.Size(267, 620);
            this.params_gb.TabIndex = 12;
            this.params_gb.TabStop = false;
            this.params_gb.Text = "Parameters";
            // 
            // modelTime_tbx
            // 
            this.modelTime_tbx.Location = new System.Drawing.Point(76, 380);
            this.modelTime_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.modelTime_tbx.Name = "modelTime_tbx";
            this.modelTime_tbx.Size = new System.Drawing.Size(132, 22);
            this.modelTime_tbx.TabIndex = 9;
            // 
            // modelTime_lbl
            // 
            this.modelTime_lbl.AutoSize = true;
            this.modelTime_lbl.Location = new System.Drawing.Point(17, 359);
            this.modelTime_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelTime_lbl.Name = "modelTime_lbl";
            this.modelTime_lbl.Size = new System.Drawing.Size(158, 17);
            this.modelTime_lbl.TabIndex = 8;
            this.modelTime_lbl.Text = "Время моделирования";
            // 
            // aCoast_tbx
            // 
            this.aCoast_tbx.Location = new System.Drawing.Point(73, 288);
            this.aCoast_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.aCoast_tbx.Name = "aCoast_tbx";
            this.aCoast_tbx.Size = new System.Drawing.Size(132, 22);
            this.aCoast_tbx.TabIndex = 7;
            // 
            // aCoast_lbl
            // 
            this.aCoast_lbl.AutoSize = true;
            this.aCoast_lbl.Location = new System.Drawing.Point(13, 266);
            this.aCoast_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aCoast_lbl.Name = "aCoast_lbl";
            this.aCoast_lbl.Size = new System.Drawing.Size(188, 17);
            this.aCoast_lbl.TabIndex = 6;
            this.aCoast_lbl.Text = "Стоимость перехода в Alert";
            // 
            // wCoast_tbx
            // 
            this.wCoast_tbx.Location = new System.Drawing.Point(73, 213);
            this.wCoast_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.wCoast_tbx.Name = "wCoast_tbx";
            this.wCoast_tbx.Size = new System.Drawing.Size(132, 22);
            this.wCoast_tbx.TabIndex = 5;
            // 
            // wCoast_lbl
            // 
            this.wCoast_lbl.AutoSize = true;
            this.wCoast_lbl.Location = new System.Drawing.Point(13, 191);
            this.wCoast_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wCoast_lbl.Name = "wCoast_lbl";
            this.wCoast_lbl.Size = new System.Drawing.Size(212, 17);
            this.wCoast_lbl.TabIndex = 4;
            this.wCoast_lbl.Text = "Стоимость перехода в Warning";
            // 
            // cellSize_tbx
            // 
            this.cellSize_tbx.Location = new System.Drawing.Point(75, 138);
            this.cellSize_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.cellSize_tbx.Name = "cellSize_tbx";
            this.cellSize_tbx.Size = new System.Drawing.Size(132, 22);
            this.cellSize_tbx.TabIndex = 3;
            // 
            // cellSize_lbl
            // 
            this.cellSize_lbl.AutoSize = true;
            this.cellSize_lbl.Location = new System.Drawing.Point(13, 116);
            this.cellSize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cellSize_lbl.Name = "cellSize_lbl";
            this.cellSize_lbl.Size = new System.Drawing.Size(108, 17);
            this.cellSize_lbl.TabIndex = 2;
            this.cellSize_lbl.Text = "Размер ячейки";
            // 
            // netSize_tbx
            // 
            this.netSize_tbx.Location = new System.Drawing.Point(76, 63);
            this.netSize_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.netSize_tbx.Name = "netSize_tbx";
            this.netSize_tbx.Size = new System.Drawing.Size(132, 22);
            this.netSize_tbx.TabIndex = 1;
            // 
            // netSize_lbl
            // 
            this.netSize_lbl.AutoSize = true;
            this.netSize_lbl.Location = new System.Drawing.Point(13, 41);
            this.netSize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.netSize_lbl.Name = "netSize_lbl";
            this.netSize_lbl.Size = new System.Drawing.Size(179, 17);
            this.netSize_lbl.TabIndex = 0;
            this.netSize_lbl.Text = "Количество машин в сети";
            // 
            // curModelTimeTitle_lbl
            // 
            this.curModelTimeTitle_lbl.AutoSize = true;
            this.curModelTimeTitle_lbl.Location = new System.Drawing.Point(103, 340);
            this.curModelTimeTitle_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curModelTimeTitle_lbl.Name = "curModelTimeTitle_lbl";
            this.curModelTimeTitle_lbl.Size = new System.Drawing.Size(222, 17);
            this.curModelTimeTitle_lbl.TabIndex = 13;
            this.curModelTimeTitle_lbl.Text = "Текущее время моделирования:";
            // 
            // curentStepTitle_lbl
            // 
            this.curentStepTitle_lbl.AutoSize = true;
            this.curentStepTitle_lbl.Location = new System.Drawing.Point(103, 396);
            this.curentStepTitle_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curentStepTitle_lbl.Name = "curentStepTitle_lbl";
            this.curentStepTitle_lbl.Size = new System.Drawing.Size(132, 17);
            this.curentStepTitle_lbl.TabIndex = 14;
            this.curentStepTitle_lbl.Text = "Текуший шаг сети:";
            // 
            // currentModelTime_lbl
            // 
            this.currentModelTime_lbl.AutoSize = true;
            this.currentModelTime_lbl.Location = new System.Drawing.Point(111, 362);
            this.currentModelTime_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentModelTime_lbl.Name = "currentModelTime_lbl";
            this.currentModelTime_lbl.Size = new System.Drawing.Size(16, 17);
            this.currentModelTime_lbl.TabIndex = 15;
            this.currentModelTime_lbl.Text = "0";
            // 
            // stat_gbx
            // 
            this.stat_gbx.Controls.Add(this.infor_lbl);
            this.stat_gbx.Location = new System.Drawing.Point(79, 300);
            this.stat_gbx.Margin = new System.Windows.Forms.Padding(4);
            this.stat_gbx.Name = "stat_gbx";
            this.stat_gbx.Padding = new System.Windows.Forms.Padding(4);
            this.stat_gbx.Size = new System.Drawing.Size(736, 193);
            this.stat_gbx.TabIndex = 16;
            this.stat_gbx.TabStop = false;
            this.stat_gbx.Text = "Stats";
            // 
            // infor_lbl
            // 
            this.infor_lbl.AutoSize = true;
            this.infor_lbl.Location = new System.Drawing.Point(380, 40);
            this.infor_lbl.Name = "infor_lbl";
            this.infor_lbl.Size = new System.Drawing.Size(0, 17);
            this.infor_lbl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 738);
            this.Controls.Add(this.currentModelTime_lbl);
            this.Controls.Add(this.curentStepTitle_lbl);
            this.Controls.Add(this.curModelTimeTitle_lbl);
            this.Controls.Add(this.Controls_gb);
            this.Controls.Add(this.step_lbl);
            this.Controls.Add(this.dataGW);
            this.Controls.Add(this.params_gb);
            this.Controls.Add(this.stat_gbx);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).EndInit();
            this.Controls_gb.ResumeLayout(false);
            this.params_gb.ResumeLayout(false);
            this.params_gb.PerformLayout();
            this.stat_gbx.ResumeLayout(false);
            this.stat_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label step_lbl;
        private System.Windows.Forms.GroupBox Controls_gb;
        private System.Windows.Forms.GroupBox params_gb;
        private System.Windows.Forms.TextBox aCoast_tbx;
        private System.Windows.Forms.Label aCoast_lbl;
        private System.Windows.Forms.TextBox wCoast_tbx;
        private System.Windows.Forms.Label wCoast_lbl;
        private System.Windows.Forms.TextBox cellSize_tbx;
        private System.Windows.Forms.Label cellSize_lbl;
        private System.Windows.Forms.TextBox netSize_tbx;
        private System.Windows.Forms.Label netSize_lbl;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox modelTime_tbx;
        private System.Windows.Forms.Label modelTime_lbl;
        private System.Windows.Forms.Label curModelTimeTitle_lbl;
        private System.Windows.Forms.Label curentStepTitle_lbl;
        private System.Windows.Forms.Label currentModelTime_lbl;
        private System.Windows.Forms.GroupBox stat_gbx;
        private System.Windows.Forms.Label infor_lbl;
    }
}

