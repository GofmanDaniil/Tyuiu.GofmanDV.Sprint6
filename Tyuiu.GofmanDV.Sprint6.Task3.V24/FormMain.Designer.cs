
namespace Tyuiu.GofmanDV.Sprint6.Task3.V24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_GDV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GDV = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_GDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_GDV = new System.Windows.Forms.DataGridView();
            this.labelOutputData_GDV = new System.Windows.Forms.Label();
            this.buttonResult_GDV = new System.Windows.Forms.Button();
            this.buttonHelp_GDV = new System.Windows.Forms.Button();
            this.groupBoxTask_GDV.SuspendLayout();
            this.groupBoxOutputData_GDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GDV
            // 
            this.groupBoxTask_GDV.Controls.Add(this.textBoxTask_GDV);
            this.groupBoxTask_GDV.Location = new System.Drawing.Point(4, 13);
            this.groupBoxTask_GDV.Name = "groupBoxTask_GDV";
            this.groupBoxTask_GDV.Size = new System.Drawing.Size(366, 425);
            this.groupBoxTask_GDV.TabIndex = 0;
            this.groupBoxTask_GDV.TabStop = false;
            this.groupBoxTask_GDV.Text = "Условие:";
            // 
            // textBoxTask_GDV
            // 
            this.textBoxTask_GDV.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_GDV.Multiline = true;
            this.textBoxTask_GDV.Name = "textBoxTask_GDV";
            this.textBoxTask_GDV.ReadOnly = true;
            this.textBoxTask_GDV.Size = new System.Drawing.Size(345, 397);
            this.textBoxTask_GDV.TabIndex = 0;
            this.textBoxTask_GDV.Text = resources.GetString("textBoxTask_GDV.Text");
            // 
            // groupBoxOutputData_GDV
            // 
            this.groupBoxOutputData_GDV.Controls.Add(this.labelOutputData_GDV);
            this.groupBoxOutputData_GDV.Controls.Add(this.dataGridViewResult_GDV);
            this.groupBoxOutputData_GDV.Location = new System.Drawing.Point(369, 13);
            this.groupBoxOutputData_GDV.Name = "groupBoxOutputData_GDV";
            this.groupBoxOutputData_GDV.Size = new System.Drawing.Size(419, 380);
            this.groupBoxOutputData_GDV.TabIndex = 1;
            this.groupBoxOutputData_GDV.TabStop = false;
            this.groupBoxOutputData_GDV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_GDV
            // 
            this.dataGridViewResult_GDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_GDV.ColumnHeadersVisible = false;
            this.dataGridViewResult_GDV.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewResult_GDV.Name = "dataGridViewResult_GDV";
            this.dataGridViewResult_GDV.RowHeadersVisible = false;
            this.dataGridViewResult_GDV.RowHeadersWidth = 51;
            this.dataGridViewResult_GDV.RowTemplate.Height = 24;
            this.dataGridViewResult_GDV.Size = new System.Drawing.Size(407, 327);
            this.dataGridViewResult_GDV.TabIndex = 0;
            // 
            // labelOutputData_GDV
            // 
            this.labelOutputData_GDV.AutoSize = true;
            this.labelOutputData_GDV.Location = new System.Drawing.Point(7, 22);
            this.labelOutputData_GDV.Name = "labelOutputData_GDV";
            this.labelOutputData_GDV.Size = new System.Drawing.Size(80, 17);
            this.labelOutputData_GDV.TabIndex = 1;
            this.labelOutputData_GDV.Text = "Результат:";
            // 
            // buttonResult_GDV
            // 
            this.buttonResult_GDV.Location = new System.Drawing.Point(676, 399);
            this.buttonResult_GDV.Name = "buttonResult_GDV";
            this.buttonResult_GDV.Size = new System.Drawing.Size(112, 38);
            this.buttonResult_GDV.TabIndex = 2;
            this.buttonResult_GDV.Text = "Выполнить";
            this.buttonResult_GDV.UseVisualStyleBackColor = true;
            this.buttonResult_GDV.Click += new System.EventHandler(this.buttonResult_GDV_Click);
            // 
            // buttonHelp_GDV
            // 
            this.buttonHelp_GDV.Location = new System.Drawing.Point(627, 399);
            this.buttonHelp_GDV.Name = "buttonHelp_GDV";
            this.buttonHelp_GDV.Size = new System.Drawing.Size(43, 37);
            this.buttonHelp_GDV.TabIndex = 3;
            this.buttonHelp_GDV.Text = "?";
            this.buttonHelp_GDV.UseVisualStyleBackColor = true;
            this.buttonHelp_GDV.Click += new System.EventHandler(this.buttonHelp_GDV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_GDV);
            this.Controls.Add(this.buttonResult_GDV);
            this.Controls.Add(this.groupBoxOutputData_GDV);
            this.Controls.Add(this.groupBoxTask_GDV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 24 | Гофман Д. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_GDV.ResumeLayout(false);
            this.groupBoxTask_GDV.PerformLayout();
            this.groupBoxOutputData_GDV.ResumeLayout(false);
            this.groupBoxOutputData_GDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GDV;
        private System.Windows.Forms.TextBox textBoxTask_GDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_GDV;
        private System.Windows.Forms.Label labelOutputData_GDV;
        private System.Windows.Forms.DataGridView dataGridViewResult_GDV;
        private System.Windows.Forms.Button buttonResult_GDV;
        private System.Windows.Forms.Button buttonHelp_GDV;
    }
}

