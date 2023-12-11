
namespace Tyuiu.GofmanDV.Sprint6.Task5.V11
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelmiddle = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_GDV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDone_GDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_GDV = new System.Windows.Forms.Button();
            this.buttonHelp_GDV = new System.Windows.Forms.Button();
            this.groupBoxResult_GDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_GDV = new System.Windows.Forms.DataGridView();
            this.chartDigit_GDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paneltop.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.panelmiddle.SuspendLayout();
            this.groupBoxTask_GDV.SuspendLayout();
            this.groupBoxResult_GDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDigit_GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.buttonHelp_GDV);
            this.paneltop.Controls.Add(this.buttonOpenFile_GDV);
            this.paneltop.Controls.Add(this.buttonDone_GDV);
            this.paneltop.Controls.Add(this.groupBoxTask_GDV);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1374, 90);
            this.paneltop.TabIndex = 0;
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.groupBoxResult_GDV);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 90);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(253, 534);
            this.panelleft.TabIndex = 0;
            // 
            // panelmiddle
            // 
            this.panelmiddle.Controls.Add(this.chartDigit_GDV);
            this.panelmiddle.Controls.Add(this.splitter1);
            this.panelmiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmiddle.Location = new System.Drawing.Point(253, 90);
            this.panelmiddle.Name = "panelmiddle";
            this.panelmiddle.Size = new System.Drawing.Size(1121, 534);
            this.panelmiddle.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 534);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTask_GDV
            // 
            this.groupBoxTask_GDV.Controls.Add(this.textBox1);
            this.groupBoxTask_GDV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_GDV.Name = "groupBoxTask_GDV";
            this.groupBoxTask_GDV.Size = new System.Drawing.Size(873, 63);
            this.groupBoxTask_GDV.TabIndex = 0;
            this.groupBoxTask_GDV.TabStop = false;
            this.groupBoxTask_GDV.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(858, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView числа кратны" +
    "е 5 и построить диаграмму по этим значениям.";
            // 
            // buttonDone_GDV
            // 
            this.buttonDone_GDV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GDV.Location = new System.Drawing.Point(893, 13);
            this.buttonDone_GDV.Name = "buttonDone_GDV";
            this.buttonDone_GDV.Size = new System.Drawing.Size(111, 68);
            this.buttonDone_GDV.TabIndex = 1;
            this.buttonDone_GDV.Text = "Выполнить";
            this.buttonDone_GDV.UseVisualStyleBackColor = false;
            this.buttonDone_GDV.Click += new System.EventHandler(this.buttonDone_GDV_Click);
            // 
            // buttonOpenFile_GDV
            // 
            this.buttonOpenFile_GDV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenFile_GDV.Location = new System.Drawing.Point(1010, 13);
            this.buttonOpenFile_GDV.Name = "buttonOpenFile_GDV";
            this.buttonOpenFile_GDV.Size = new System.Drawing.Size(111, 68);
            this.buttonOpenFile_GDV.TabIndex = 1;
            this.buttonOpenFile_GDV.Text = "Открыть файл";
            this.buttonOpenFile_GDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GDV.Click += new System.EventHandler(this.buttonOpenFile_GDV_Click);
            // 
            // buttonHelp_GDV
            // 
            this.buttonHelp_GDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GDV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_GDV.Location = new System.Drawing.Point(1251, 12);
            this.buttonHelp_GDV.Name = "buttonHelp_GDV";
            this.buttonHelp_GDV.Size = new System.Drawing.Size(111, 68);
            this.buttonHelp_GDV.TabIndex = 1;
            this.buttonHelp_GDV.Text = "Справка";
            this.buttonHelp_GDV.UseVisualStyleBackColor = false;
            this.buttonHelp_GDV.Click += new System.EventHandler(this.buttonHelp_GDV_Click);
            // 
            // groupBoxResult_GDV
            // 
            this.groupBoxResult_GDV.Controls.Add(this.dataGridViewResult_GDV);
            this.groupBoxResult_GDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_GDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_GDV.Name = "groupBoxResult_GDV";
            this.groupBoxResult_GDV.Size = new System.Drawing.Size(253, 534);
            this.groupBoxResult_GDV.TabIndex = 0;
            this.groupBoxResult_GDV.TabStop = false;
            this.groupBoxResult_GDV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_GDV
            // 
            this.dataGridViewResult_GDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_GDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_GDV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResult_GDV.Name = "dataGridViewResult_GDV";
            this.dataGridViewResult_GDV.ReadOnly = true;
            this.dataGridViewResult_GDV.RowHeadersWidth = 51;
            this.dataGridViewResult_GDV.RowTemplate.Height = 24;
            this.dataGridViewResult_GDV.Size = new System.Drawing.Size(247, 513);
            this.dataGridViewResult_GDV.TabIndex = 0;
            // 
            // chartDigit_GDV
            // 
            chartArea7.Name = "ChartArea1";
            this.chartDigit_GDV.ChartAreas.Add(chartArea7);
            this.chartDigit_GDV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chartDigit_GDV.Legends.Add(legend7);
            this.chartDigit_GDV.Location = new System.Drawing.Point(3, 0);
            this.chartDigit_GDV.Name = "chartDigit_GDV";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartDigit_GDV.Series.Add(series7);
            this.chartDigit_GDV.Size = new System.Drawing.Size(1118, 534);
            this.chartDigit_GDV.TabIndex = 1;
            this.chartDigit_GDV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 624);
            this.Controls.Add(this.panelmiddle);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.MinimumSize = new System.Drawing.Size(1392, 671);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 11 | Гофман Д. В.";
            this.paneltop.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.panelmiddle.ResumeLayout(false);
            this.groupBoxTask_GDV.ResumeLayout(false);
            this.groupBoxTask_GDV.PerformLayout();
            this.groupBoxResult_GDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDigit_GDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonHelp_GDV;
        private System.Windows.Forms.Button buttonOpenFile_GDV;
        private System.Windows.Forms.Button buttonDone_GDV;
        private System.Windows.Forms.GroupBox groupBoxTask_GDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.GroupBox groupBoxResult_GDV;
        private System.Windows.Forms.DataGridView dataGridViewResult_GDV;
        private System.Windows.Forms.Panel panelmiddle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDigit_GDV;
        private System.Windows.Forms.Splitter splitter1;
    }
}

