
namespace bntu.vsrpp.vmisyakova.lab2
{
    partial class GraphBuilder
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.cbCurrencies = new System.Windows.Forms.ComboBox();
            this.btnBuildGraph = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(239, 16);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(474, 16);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // cbCurrencies
            // 
            this.cbCurrencies.FormattingEnabled = true;
            this.cbCurrencies.Location = new System.Drawing.Point(14, 16);
            this.cbCurrencies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCurrencies.Name = "cbCurrencies";
            this.cbCurrencies.Size = new System.Drawing.Size(218, 28);
            this.cbCurrencies.TabIndex = 2;
            // 
            // btnBuildGraph
            // 
            this.btnBuildGraph.Location = new System.Drawing.Point(708, 16);
            this.btnBuildGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuildGraph.Name = "btnBuildGraph";
            this.btnBuildGraph.Size = new System.Drawing.Size(102, 28);
            this.btnBuildGraph.TabIndex = 3;
            this.btnBuildGraph.Text = "Построить";
            this.btnBuildGraph.UseVisualStyleBackColor = true;
            this.btnBuildGraph.Click += new System.EventHandler(this.btnBuildGraph_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(14, 524);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(44, 20);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min=";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(379, 524);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(47, 20);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Max=";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(196, 524);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(45, 20);
            this.lblAvg.TabIndex = 6;
            this.lblAvg.Text = "Avg=";
            // 
            // plotView
            // 
            this.plotView.Location = new System.Drawing.Point(14, 52);
            this.plotView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(799, 468);
            this.plotView.TabIndex = 7;
            this.plotView.Text = "plotView1";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // GraphBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnBuildGraph);
            this.Controls.Add(this.cbCurrencies);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GraphBuilder";
            this.Text = "График курса валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox cbCurrencies;
        private System.Windows.Forms.Button btnBuildGraph;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblAvg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private OxyPlot.WindowsForms.PlotView plotView;
    }
}