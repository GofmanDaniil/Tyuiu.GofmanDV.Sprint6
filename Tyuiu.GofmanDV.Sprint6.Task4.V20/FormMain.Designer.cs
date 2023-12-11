
namespace Tyuiu.GofmanDV.Sprint6.Task4.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelmiddle = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_GDV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_GDV = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_GDV = new System.Windows.Forms.TextBox();
            this.labelStartStep_GDV = new System.Windows.Forms.Label();
            this.labelStopStep_GDV = new System.Windows.Forms.Label();
            this.textBoxStopStep_GDV = new System.Windows.Forms.TextBox();
            this.buttonDone_GDV = new System.Windows.Forms.Button();
            this.buttonSave_GDV = new System.Windows.Forms.Button();
            this.buttonHelp_GDV = new System.Windows.Forms.Button();
            this.groupBoxResult_GDV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_GDV = new System.Windows.Forms.TextBox();
            this.chartFunction_GDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paneltop.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.panelmiddle.SuspendLayout();
            this.groupBoxTask_GDV.SuspendLayout();
            this.groupBoxOutputData_GDV.SuspendLayout();
            this.groupBoxResult_GDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.buttonHelp_GDV);
            this.paneltop.Controls.Add(this.buttonSave_GDV);
            this.paneltop.Controls.Add(this.buttonDone_GDV);
            this.paneltop.Controls.Add(this.groupBoxOutputData_GDV);
            this.paneltop.Controls.Add(this.groupBoxTask_GDV);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1373, 105);
            this.paneltop.TabIndex = 0;
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.groupBoxResult_GDV);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 105);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(240, 554);
            this.panelleft.TabIndex = 0;
            // 
            // panelmiddle
            // 
            this.panelmiddle.Controls.Add(this.chartFunction_GDV);
            this.panelmiddle.Controls.Add(this.splitter2);
            this.panelmiddle.Controls.Add(this.splitter1);
            this.panelmiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmiddle.Location = new System.Drawing.Point(240, 105);
            this.panelmiddle.Name = "panelmiddle";
            this.panelmiddle.Size = new System.Drawing.Size(1133, 554);
            this.panelmiddle.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 554);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 554);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // groupBoxTask_GDV
            // 
            this.groupBoxTask_GDV.Controls.Add(this.textBox1);
            this.groupBoxTask_GDV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_GDV.Name = "groupBoxTask_GDV";
            this.groupBoxTask_GDV.Size = new System.Drawing.Size(686, 79);
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
            this.textBox1.Size = new System.Drawing.Size(673, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию sin(x) в диапазоне от -5 до 5. Результат вывести в textbo" +
    "x, построить график функции и сохранить файл в OutPutFileTask4.txt по нажатию кн" +
    "опки.";
            // 
            // groupBoxOutputData_GDV
            // 
            this.groupBoxOutputData_GDV.Controls.Add(this.textBoxStopStep_GDV);
            this.groupBoxOutputData_GDV.Controls.Add(this.labelStopStep_GDV);
            this.groupBoxOutputData_GDV.Controls.Add(this.labelStartStep_GDV);
            this.groupBoxOutputData_GDV.Controls.Add(this.textBoxStartStep_GDV);
            this.groupBoxOutputData_GDV.Location = new System.Drawing.Point(706, 13);
            this.groupBoxOutputData_GDV.Name = "groupBoxOutputData_GDV";
            this.groupBoxOutputData_GDV.Size = new System.Drawing.Size(305, 79);
            this.groupBoxOutputData_GDV.TabIndex = 1;
            this.groupBoxOutputData_GDV.TabStop = false;
            this.groupBoxOutputData_GDV.Text = "Ввод данных:";
            // 
            // textBoxStartStep_GDV
            // 
            this.textBoxStartStep_GDV.Location = new System.Drawing.Point(6, 45);
            this.textBoxStartStep_GDV.Name = "textBoxStartStep_GDV";
            this.textBoxStartStep_GDV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_GDV.TabIndex = 0;
            // 
            // labelStartStep_GDV
            // 
            this.labelStartStep_GDV.AutoSize = true;
            this.labelStartStep_GDV.Location = new System.Drawing.Point(6, 25);
            this.labelStartStep_GDV.Name = "labelStartStep_GDV";
            this.labelStartStep_GDV.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_GDV.TabIndex = 1;
            this.labelStartStep_GDV.Text = "Старт шага:";
            // 
            // labelStopStep_GDV
            // 
            this.labelStopStep_GDV.AutoSize = true;
            this.labelStopStep_GDV.Location = new System.Drawing.Point(124, 25);
            this.labelStopStep_GDV.Name = "labelStopStep_GDV";
            this.labelStopStep_GDV.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_GDV.TabIndex = 2;
            this.labelStopStep_GDV.Text = "Конец шага:";
            // 
            // textBoxStopStep_GDV
            // 
            this.textBoxStopStep_GDV.Location = new System.Drawing.Point(127, 44);
            this.textBoxStopStep_GDV.Name = "textBoxStopStep_GDV";
            this.textBoxStopStep_GDV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_GDV.TabIndex = 3;
            // 
            // buttonDone_GDV
            // 
            this.buttonDone_GDV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GDV.Location = new System.Drawing.Point(1018, 13);
            this.buttonDone_GDV.Name = "buttonDone_GDV";
            this.buttonDone_GDV.Size = new System.Drawing.Size(111, 79);
            this.buttonDone_GDV.TabIndex = 2;
            this.buttonDone_GDV.Text = "Выполнить";
            this.buttonDone_GDV.UseVisualStyleBackColor = false;
            this.buttonDone_GDV.Click += new System.EventHandler(this.buttonDone_GDV_Click);
            // 
            // buttonSave_GDV
            // 
            this.buttonSave_GDV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_GDV.Location = new System.Drawing.Point(1135, 13);
            this.buttonSave_GDV.Name = "buttonSave_GDV";
            this.buttonSave_GDV.Size = new System.Drawing.Size(111, 79);
            this.buttonSave_GDV.TabIndex = 2;
            this.buttonSave_GDV.Text = "Сохранить";
            this.buttonSave_GDV.UseVisualStyleBackColor = false;
            this.buttonSave_GDV.Click += new System.EventHandler(this.buttonSave_GDV_Click);
            // 
            // buttonHelp_GDV
            // 
            this.buttonHelp_GDV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_GDV.Location = new System.Drawing.Point(1259, 12);
            this.buttonHelp_GDV.Name = "buttonHelp_GDV";
            this.buttonHelp_GDV.Size = new System.Drawing.Size(111, 80);
            this.buttonHelp_GDV.TabIndex = 2;
            this.buttonHelp_GDV.Text = "Справка";
            this.buttonHelp_GDV.UseVisualStyleBackColor = false;
            this.buttonHelp_GDV.Click += new System.EventHandler(this.buttonHelp_GDV_Click);
            // 
            // groupBoxResult_GDV
            // 
            this.groupBoxResult_GDV.Controls.Add(this.textBoxResult_GDV);
            this.groupBoxResult_GDV.Location = new System.Drawing.Point(12, 7);
            this.groupBoxResult_GDV.Name = "groupBoxResult_GDV";
            this.groupBoxResult_GDV.Size = new System.Drawing.Size(222, 535);
            this.groupBoxResult_GDV.TabIndex = 0;
            this.groupBoxResult_GDV.TabStop = false;
            this.groupBoxResult_GDV.Text = "Вывод данных:";
            // 
            // textBoxResult_GDV
            // 
            this.textBoxResult_GDV.Location = new System.Drawing.Point(7, 22);
            this.textBoxResult_GDV.Multiline = true;
            this.textBoxResult_GDV.Name = "textBoxResult_GDV";
            this.textBoxResult_GDV.ReadOnly = true;
            this.textBoxResult_GDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GDV.Size = new System.Drawing.Size(208, 507);
            this.textBoxResult_GDV.TabIndex = 0;
            // 
            // chartFunction_GDV
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_GDV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_GDV.Legends.Add(legend2);
            this.chartFunction_GDV.Location = new System.Drawing.Point(13, 7);
            this.chartFunction_GDV.Name = "chartFunction_GDV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_GDV.Series.Add(series2);
            this.chartFunction_GDV.Size = new System.Drawing.Size(1108, 535);
            this.chartFunction_GDV.TabIndex = 2;
            this.chartFunction_GDV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 659);
            this.Controls.Add(this.panelmiddle);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 20 | Гофман Д. В.";
            this.paneltop.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.panelmiddle.ResumeLayout(false);
            this.groupBoxTask_GDV.ResumeLayout(false);
            this.groupBoxTask_GDV.PerformLayout();
            this.groupBoxOutputData_GDV.ResumeLayout(false);
            this.groupBoxOutputData_GDV.PerformLayout();
            this.groupBoxResult_GDV.ResumeLayout(false);
            this.groupBoxResult_GDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonHelp_GDV;
        private System.Windows.Forms.Button buttonSave_GDV;
        private System.Windows.Forms.Button buttonDone_GDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_GDV;
        private System.Windows.Forms.TextBox textBoxStopStep_GDV;
        private System.Windows.Forms.Label labelStopStep_GDV;
        private System.Windows.Forms.Label labelStartStep_GDV;
        private System.Windows.Forms.TextBox textBoxStartStep_GDV;
        private System.Windows.Forms.GroupBox groupBoxTask_GDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.GroupBox groupBoxResult_GDV;
        private System.Windows.Forms.TextBox textBoxResult_GDV;
        private System.Windows.Forms.Panel panelmiddle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GDV;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
    }
}

