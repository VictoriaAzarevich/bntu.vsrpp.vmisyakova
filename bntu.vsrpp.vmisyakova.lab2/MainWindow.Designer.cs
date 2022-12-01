
namespace bntu.vsrpp.vmisyakova.lab2
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCurrencyInput = new System.Windows.Forms.ComboBox();
            this.cbCurrencyOutput = new System.Windows.Forms.ComboBox();
            this.tbValueInput = new System.Windows.Forms.TextBox();
            this.tbValueOutput = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnBuildGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCurrencyInput
            // 
            this.cbCurrencyInput.FormattingEnabled = true;
            this.cbCurrencyInput.Location = new System.Drawing.Point(12, 12);
            this.cbCurrencyInput.Name = "cbCurrencyInput";
            this.cbCurrencyInput.Size = new System.Drawing.Size(327, 28);
            this.cbCurrencyInput.Sorted = true;
            this.cbCurrencyInput.TabIndex = 0;
            this.cbCurrencyInput.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyInput_SelectedIndexChanged);
            // 
            // cbCurrencyOutput
            // 
            this.cbCurrencyOutput.FormattingEnabled = true;
            this.cbCurrencyOutput.Location = new System.Drawing.Point(487, 12);
            this.cbCurrencyOutput.Name = "cbCurrencyOutput";
            this.cbCurrencyOutput.Size = new System.Drawing.Size(327, 28);
            this.cbCurrencyOutput.Sorted = true;
            this.cbCurrencyOutput.TabIndex = 1;
            this.cbCurrencyOutput.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyOutput_SelectedIndexChanged);
            // 
            // tbValueInput
            // 
            this.tbValueInput.Location = new System.Drawing.Point(90, 47);
            this.tbValueInput.Name = "tbValueInput";
            this.tbValueInput.Size = new System.Drawing.Size(170, 27);
            this.tbValueInput.TabIndex = 2;
            // 
            // tbValueOutput
            // 
            this.tbValueOutput.Location = new System.Drawing.Point(571, 47);
            this.tbValueOutput.Name = "tbValueOutput";
            this.tbValueOutput.Size = new System.Drawing.Size(170, 27);
            this.tbValueOutput.TabIndex = 3;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(345, 46);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(136, 29);
            this.btnSwap.TabIndex = 4;
            this.btnSwap.Text = "Поменять";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(345, 91);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(136, 29);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnBuildGraph
            // 
            this.btnBuildGraph.Location = new System.Drawing.Point(345, 147);
            this.btnBuildGraph.Name = "btnBuildGraph";
            this.btnBuildGraph.Size = new System.Drawing.Size(136, 49);
            this.btnBuildGraph.TabIndex = 6;
            this.btnBuildGraph.Text = "Построить график";
            this.btnBuildGraph.UseVisualStyleBackColor = true;
            this.btnBuildGraph.Click += new System.EventHandler(this.btnBuildGraph_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 208);
            this.Controls.Add(this.btnBuildGraph);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.tbValueOutput);
            this.Controls.Add(this.tbValueInput);
            this.Controls.Add(this.cbCurrencyOutput);
            this.Controls.Add(this.cbCurrencyInput);
            this.Name = "MainWindow";
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurrencyInput;
        private System.Windows.Forms.ComboBox cbCurrencyOutput;
        private System.Windows.Forms.TextBox tbValueInput;
        private System.Windows.Forms.TextBox tbValueOutput;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnBuildGraph;
    }
}

