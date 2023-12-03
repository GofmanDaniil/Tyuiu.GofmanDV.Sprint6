
namespace Tyuiu.GofmanDV.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_GDV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GDV = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_GDV = new System.Windows.Forms.GroupBox();
            this.labelStartStep_GDV = new System.Windows.Forms.Label();
            this.textBoxStartStep_GDV = new System.Windows.Forms.TextBox();
            this.labelStopStep_GDV = new System.Windows.Forms.Label();
            this.textBoxStopStep_GDV = new System.Windows.Forms.TextBox();
            this.buttonHelp_GDV = new System.Windows.Forms.Button();
            this.buttonResult_GDV = new System.Windows.Forms.Button();
            this.groupBoxResult_GDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_GDV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_GDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelOutPutData_GDV = new System.Windows.Forms.Label();
            this.groupBoxTask_GDV.SuspendLayout();
            this.groupBoxInputData_GDV.SuspendLayout();
            this.groupBoxResult_GDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_GDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GDV
            // 
            this.groupBoxTask_GDV.Controls.Add(this.textBoxTask_GDV);
            this.groupBoxTask_GDV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_GDV.Name = "groupBoxTask_GDV";
            this.groupBoxTask_GDV.Size = new System.Drawing.Size(590, 329);
            this.groupBoxTask_GDV.TabIndex = 0;
            this.groupBoxTask_GDV.TabStop = false;
            this.groupBoxTask_GDV.Text = "Условие:";
            // 
            // textBoxTask_GDV
            // 
            this.textBoxTask_GDV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_GDV.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_GDV.Multiline = true;
            this.textBoxTask_GDV.Name = "textBoxTask_GDV";
            this.textBoxTask_GDV.ReadOnly = true;
            this.textBoxTask_GDV.Size = new System.Drawing.Size(577, 55);
            this.textBoxTask_GDV.TabIndex = 0;
            this.textBoxTask_GDV.Text = "Протабулировать функцию f(x) в заданном диапазоне.\r\nРезультат вывести в DataGridV" +
    "iew и построить график функции.";
            // 
            // groupBoxInputData_GDV
            // 
            this.groupBoxInputData_GDV.Controls.Add(this.textBoxStopStep_GDV);
            this.groupBoxInputData_GDV.Controls.Add(this.labelStopStep_GDV);
            this.groupBoxInputData_GDV.Controls.Add(this.textBoxStartStep_GDV);
            this.groupBoxInputData_GDV.Controls.Add(this.labelStartStep_GDV);
            this.groupBoxInputData_GDV.Location = new System.Drawing.Point(13, 349);
            this.groupBoxInputData_GDV.Name = "groupBoxInputData_GDV";
            this.groupBoxInputData_GDV.Size = new System.Drawing.Size(301, 100);
            this.groupBoxInputData_GDV.TabIndex = 1;
            this.groupBoxInputData_GDV.TabStop = false;
            this.groupBoxInputData_GDV.Text = "Ввод данных:";
            // 
            // labelStartStep_GDV
            // 
            this.labelStartStep_GDV.AutoSize = true;
            this.labelStartStep_GDV.Location = new System.Drawing.Point(7, 22);
            this.labelStartStep_GDV.Name = "labelStartStep_GDV";
            this.labelStartStep_GDV.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_GDV.TabIndex = 0;
            this.labelStartStep_GDV.Text = "Старт шага:";
            // 
            // textBoxStartStep_GDV
            // 
            this.textBoxStartStep_GDV.Location = new System.Drawing.Point(7, 43);
            this.textBoxStartStep_GDV.Name = "textBoxStartStep_GDV";
            this.textBoxStartStep_GDV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_GDV.TabIndex = 1;
            // 
            // labelStopStep_GDV
            // 
            this.labelStopStep_GDV.AutoSize = true;
            this.labelStopStep_GDV.Location = new System.Drawing.Point(114, 22);
            this.labelStopStep_GDV.Name = "labelStopStep_GDV";
            this.labelStopStep_GDV.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_GDV.TabIndex = 2;
            this.labelStopStep_GDV.Text = "Конец шага:";
            // 
            // textBoxStopStep_GDV
            // 
            this.textBoxStopStep_GDV.Location = new System.Drawing.Point(117, 43);
            this.textBoxStopStep_GDV.Name = "textBoxStopStep_GDV";
            this.textBoxStopStep_GDV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_GDV.TabIndex = 3;
            // 
            // buttonHelp_GDV
            // 
            this.buttonHelp_GDV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_GDV.Location = new System.Drawing.Point(320, 364);
            this.buttonHelp_GDV.Name = "buttonHelp_GDV";
            this.buttonHelp_GDV.Size = new System.Drawing.Size(110, 72);
            this.buttonHelp_GDV.TabIndex = 2;
            this.buttonHelp_GDV.Text = "Справка";
            this.buttonHelp_GDV.UseVisualStyleBackColor = false;
            this.buttonHelp_GDV.Click += new System.EventHandler(this.buttonHelp_GDV_Click);
            // 
            // buttonResult_GDV
            // 
            this.buttonResult_GDV.BackColor = System.Drawing.Color.Green;
            this.buttonResult_GDV.Location = new System.Drawing.Point(437, 364);
            this.buttonResult_GDV.Name = "buttonResult_GDV";
            this.buttonResult_GDV.Size = new System.Drawing.Size(160, 72);
            this.buttonResult_GDV.TabIndex = 3;
            this.buttonResult_GDV.Text = "Выполнить";
            this.buttonResult_GDV.UseVisualStyleBackColor = false;
            this.buttonResult_GDV.Click += new System.EventHandler(this.buttonResult_GDV_Click);
            this.buttonResult_GDV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_GDV_MouseDown);
            this.buttonResult_GDV.MouseEnter += new System.EventHandler(this.buttonResult_GDV_MouseEnter);
            this.buttonResult_GDV.MouseLeave += new System.EventHandler(this.buttonResult_GDV_MouseLeave);
            // 
            // groupBoxResult_GDV
            // 
            this.groupBoxResult_GDV.Controls.Add(this.labelOutPutData_GDV);
            this.groupBoxResult_GDV.Controls.Add(this.chartFunction_GDV);
            this.groupBoxResult_GDV.Controls.Add(this.dataGridViewFunction_GDV);
            this.groupBoxResult_GDV.Location = new System.Drawing.Point(610, 13);
            this.groupBoxResult_GDV.Name = "groupBoxResult_GDV";
            this.groupBoxResult_GDV.Size = new System.Drawing.Size(725, 436);
            this.groupBoxResult_GDV.TabIndex = 4;
            this.groupBoxResult_GDV.TabStop = false;
            this.groupBoxResult_GDV.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_GDV
            // 
            this.dataGridViewFunction_GDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_GDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_GDV.Location = new System.Drawing.Point(7, 42);
            this.dataGridViewFunction_GDV.Name = "dataGridViewFunction_GDV";
            this.dataGridViewFunction_GDV.ReadOnly = true;
            this.dataGridViewFunction_GDV.RowHeadersVisible = false;
            this.dataGridViewFunction_GDV.RowHeadersWidth = 51;
            this.dataGridViewFunction_GDV.RowTemplate.Height = 24;
            this.dataGridViewFunction_GDV.Size = new System.Drawing.Size(151, 381);
            this.dataGridViewFunction_GDV.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // chartFunction_GDV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GDV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GDV.Legends.Add(legend1);
            this.chartFunction_GDV.Location = new System.Drawing.Point(164, 42);
            this.chartFunction_GDV.Name = "chartFunction_GDV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GDV.Series.Add(series1);
            this.chartFunction_GDV.Size = new System.Drawing.Size(707, 394);
            this.chartFunction_GDV.TabIndex = 1;
            this.chartFunction_GDV.Text = "chart1";
            // 
            // labelOutPutData_GDV
            // 
            this.labelOutPutData_GDV.AutoSize = true;
            this.labelOutPutData_GDV.Location = new System.Drawing.Point(7, 22);
            this.labelOutPutData_GDV.Name = "labelOutPutData_GDV";
            this.labelOutPutData_GDV.Size = new System.Drawing.Size(106, 17);
            this.labelOutPutData_GDV.TabIndex = 2;
            this.labelOutPutData_GDV.Text = "Вывод данных:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 450);
            this.Controls.Add(this.groupBoxResult_GDV);
            this.Controls.Add(this.buttonResult_GDV);
            this.Controls.Add(this.buttonHelp_GDV);
            this.Controls.Add(this.groupBoxInputData_GDV);
            this.Controls.Add(this.groupBoxTask_GDV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 6 | Гофман Д. В.";
            this.groupBoxTask_GDV.ResumeLayout(false);
            this.groupBoxTask_GDV.PerformLayout();
            this.groupBoxInputData_GDV.ResumeLayout(false);
            this.groupBoxInputData_GDV.PerformLayout();
            this.groupBoxResult_GDV.ResumeLayout(false);
            this.groupBoxResult_GDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_GDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GDV;
        private System.Windows.Forms.TextBox textBoxTask_GDV;
        private System.Windows.Forms.GroupBox groupBoxInputData_GDV;
        private System.Windows.Forms.TextBox textBoxStopStep_GDV;
        private System.Windows.Forms.Label labelStopStep_GDV;
        private System.Windows.Forms.TextBox textBoxStartStep_GDV;
        private System.Windows.Forms.Label labelStartStep_GDV;
        private System.Windows.Forms.Button buttonHelp_GDV;
        private System.Windows.Forms.Button buttonResult_GDV;
        private System.Windows.Forms.GroupBox groupBoxResult_GDV;
        private System.Windows.Forms.DataGridView dataGridViewFunction_GDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label labelOutPutData_GDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GDV;
    }
}

