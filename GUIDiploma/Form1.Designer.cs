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
            this.netSize_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nextStep = new System.Windows.Forms.Button();
            this.nextData_btn = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.step_lbl = new System.Windows.Forms.Label();
            this.Controls_gb = new System.Windows.Forms.GroupBox();
            this.params_gb = new System.Windows.Forms.GroupBox();
            this.netSize_lbl = new System.Windows.Forms.Label();
            this.netSize_tbx = new System.Windows.Forms.TextBox();
            this.cellSize_lbl = new System.Windows.Forms.Label();
            this.cellSize_tbx = new System.Windows.Forms.TextBox();
            this.wCoast_lbl = new System.Windows.Forms.Label();
            this.wCoast_tbx = new System.Windows.Forms.TextBox();
            this.aCoast_lbl = new System.Windows.Forms.Label();
            this.aCoast_tbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).BeginInit();
            this.Controls_gb.SuspendLayout();
            this.params_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGW
            // 
            this.dataGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGW.Location = new System.Drawing.Point(59, 53);
            this.dataGW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGW.Name = "dataGW";
            this.dataGW.RowTemplate.Height = 24;
            this.dataGW.Size = new System.Drawing.Size(552, 160);
            this.dataGW.TabIndex = 0;
            // 
            // netSize_tb
            // 
            this.netSize_tb.Location = new System.Drawing.Point(782, 53);
            this.netSize_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.netSize_tb.Name = "netSize_tb";
            this.netSize_tb.Size = new System.Drawing.Size(76, 20);
            this.netSize_tb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Initialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextStep
            // 
            this.nextStep.Location = new System.Drawing.Point(83, 77);
            this.nextStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextStep.Name = "nextStep";
            this.nextStep.Size = new System.Drawing.Size(56, 44);
            this.nextStep.TabIndex = 3;
            this.nextStep.Text = "next step";
            this.nextStep.UseVisualStyleBackColor = true;
            this.nextStep.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextData_btn
            // 
            this.nextData_btn.Location = new System.Drawing.Point(16, 77);
            this.nextData_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextData_btn.Name = "nextData_btn";
            this.nextData_btn.Size = new System.Drawing.Size(56, 44);
            this.nextData_btn.TabIndex = 4;
            this.nextData_btn.Text = "next data";
            this.nextData_btn.UseVisualStyleBackColor = true;
            this.nextData_btn.Click += new System.EventHandler(this.nextData_btn_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(159, 29);
            this.b0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(17, 19);
            this.b0.TabIndex = 5;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(181, 29);
            this.b1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(17, 19);
            this.b1.TabIndex = 6;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(202, 29);
            this.b2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(17, 19);
            this.b2.TabIndex = 7;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(224, 29);
            this.b3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(17, 19);
            this.b3.TabIndex = 8;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(246, 29);
            this.b4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(17, 19);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // step_lbl
            // 
            this.step_lbl.AutoSize = true;
            this.step_lbl.Location = new System.Drawing.Point(779, 138);
            this.step_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.step_lbl.Name = "step_lbl";
            this.step_lbl.Size = new System.Drawing.Size(19, 13);
            this.step_lbl.TabIndex = 10;
            this.step_lbl.Text = "***";
            // 
            // Controls_gb
            // 
            this.Controls_gb.Controls.Add(this.nextData_btn);
            this.Controls_gb.Controls.Add(this.nextStep);
            this.Controls_gb.Location = new System.Drawing.Point(59, 421);
            this.Controls_gb.Name = "Controls_gb";
            this.Controls_gb.Size = new System.Drawing.Size(552, 136);
            this.Controls_gb.TabIndex = 11;
            this.Controls_gb.TabStop = false;
            this.Controls_gb.Text = "Controls";
            // 
            // params_gb
            // 
            this.params_gb.Controls.Add(this.aCoast_tbx);
            this.params_gb.Controls.Add(this.button1);
            this.params_gb.Controls.Add(this.aCoast_lbl);
            this.params_gb.Controls.Add(this.wCoast_tbx);
            this.params_gb.Controls.Add(this.wCoast_lbl);
            this.params_gb.Controls.Add(this.cellSize_tbx);
            this.params_gb.Controls.Add(this.cellSize_lbl);
            this.params_gb.Controls.Add(this.netSize_tbx);
            this.params_gb.Controls.Add(this.netSize_lbl);
            this.params_gb.Location = new System.Drawing.Point(663, 53);
            this.params_gb.Name = "params_gb";
            this.params_gb.Size = new System.Drawing.Size(200, 504);
            this.params_gb.TabIndex = 12;
            this.params_gb.TabStop = false;
            this.params_gb.Text = "Parameters";
            // 
            // netSize_lbl
            // 
            this.netSize_lbl.AutoSize = true;
            this.netSize_lbl.Location = new System.Drawing.Point(10, 33);
            this.netSize_lbl.Name = "netSize_lbl";
            this.netSize_lbl.Size = new System.Drawing.Size(138, 13);
            this.netSize_lbl.TabIndex = 0;
            this.netSize_lbl.Text = "Количество машин в сети";
            // 
            // netSize_tbx
            // 
            this.netSize_tbx.Location = new System.Drawing.Point(57, 51);
            this.netSize_tbx.Name = "netSize_tbx";
            this.netSize_tbx.Size = new System.Drawing.Size(100, 20);
            this.netSize_tbx.TabIndex = 1;
            // 
            // cellSize_lbl
            // 
            this.cellSize_lbl.AutoSize = true;
            this.cellSize_lbl.Location = new System.Drawing.Point(10, 94);
            this.cellSize_lbl.Name = "cellSize_lbl";
            this.cellSize_lbl.Size = new System.Drawing.Size(84, 13);
            this.cellSize_lbl.TabIndex = 2;
            this.cellSize_lbl.Text = "Размер ячейки";
            // 
            // cellSize_tbx
            // 
            this.cellSize_tbx.Location = new System.Drawing.Point(56, 112);
            this.cellSize_tbx.Name = "cellSize_tbx";
            this.cellSize_tbx.Size = new System.Drawing.Size(100, 20);
            this.cellSize_tbx.TabIndex = 3;
            // 
            // wCoast_lbl
            // 
            this.wCoast_lbl.AutoSize = true;
            this.wCoast_lbl.Location = new System.Drawing.Point(10, 155);
            this.wCoast_lbl.Name = "wCoast_lbl";
            this.wCoast_lbl.Size = new System.Drawing.Size(164, 13);
            this.wCoast_lbl.TabIndex = 4;
            this.wCoast_lbl.Text = "Стоимость перехода в Warning";
            // 
            // wCoast_tbx
            // 
            this.wCoast_tbx.Location = new System.Drawing.Point(55, 173);
            this.wCoast_tbx.Name = "wCoast_tbx";
            this.wCoast_tbx.Size = new System.Drawing.Size(100, 20);
            this.wCoast_tbx.TabIndex = 5;
            // 
            // aCoast_lbl
            // 
            this.aCoast_lbl.AutoSize = true;
            this.aCoast_lbl.Location = new System.Drawing.Point(10, 216);
            this.aCoast_lbl.Name = "aCoast_lbl";
            this.aCoast_lbl.Size = new System.Drawing.Size(145, 13);
            this.aCoast_lbl.TabIndex = 6;
            this.aCoast_lbl.Text = "Стоимость перехода в Alert";
            // 
            // aCoast_tbx
            // 
            this.aCoast_tbx.Location = new System.Drawing.Point(55, 234);
            this.aCoast_tbx.Name = "aCoast_tbx";
            this.aCoast_tbx.Size = new System.Drawing.Size(100, 20);
            this.aCoast_tbx.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 600);
            this.Controls.Add(this.params_gb);
            this.Controls.Add(this.Controls_gb);
            this.Controls.Add(this.step_lbl);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.netSize_tb);
            this.Controls.Add(this.dataGW);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).EndInit();
            this.Controls_gb.ResumeLayout(false);
            this.params_gb.ResumeLayout(false);
            this.params_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGW;
        private System.Windows.Forms.TextBox netSize_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextStep;
        private System.Windows.Forms.Button nextData_btn;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
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
    }
}

