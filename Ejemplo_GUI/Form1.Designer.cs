namespace Ejemplo_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPotValue = new System.Windows.Forms.TextBox();
            this.txtEstatusConexion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPWM = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.chartDataSensors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tbPWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor del potenciómetro:";
            // 
            // txtPotValue
            // 
            this.txtPotValue.Location = new System.Drawing.Point(194, 38);
            this.txtPotValue.Name = "txtPotValue";
            this.txtPotValue.Size = new System.Drawing.Size(401, 22);
            this.txtPotValue.TabIndex = 1;
            // 
            // txtEstatusConexion
            // 
            this.txtEstatusConexion.Location = new System.Drawing.Point(194, 73);
            this.txtEstatusConexion.Name = "txtEstatusConexion";
            this.txtEstatusConexion.Size = new System.Drawing.Size(401, 22);
            this.txtEstatusConexion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado de la conexión:";
            // 
            // tbPWM
            // 
            this.tbPWM.Location = new System.Drawing.Point(29, 150);
            this.tbPWM.Maximum = 255;
            this.tbPWM.Name = "tbPWM";
            this.tbPWM.Size = new System.Drawing.Size(566, 56);
            this.tbPWM.TabIndex = 4;
            this.tbPWM.Scroll += new System.EventHandler(this.tbPWM_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brillo del LED:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(29, 212);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(105, 50);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(490, 212);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(105, 50);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // chartDataSensors
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDataSensors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDataSensors.Legends.Add(legend1);
            this.chartDataSensors.Location = new System.Drawing.Point(29, 268);
            this.chartDataSensors.Name = "chartDataSensors";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Pot";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "LED";
            this.chartDataSensors.Series.Add(series1);
            this.chartDataSensors.Series.Add(series2);
            this.chartDataSensors.Size = new System.Drawing.Size(566, 300);
            this.chartDataSensors.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 578);
            this.Controls.Add(this.chartDataSensors);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPWM);
            this.Controls.Add(this.txtEstatusConexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPotValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbPWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSensors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPotValue;
        private System.Windows.Forms.TextBox txtEstatusConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbPWM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataSensors;
    }
}

