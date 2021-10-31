
namespace bntu.vsrpp.vmisyakova.lab1
{
    partial class Form1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.countNodes = new System.Windows.Forms.Label();
            this.childNodes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedOperation = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.radioButtonGetMaxLength = new System.Windows.Forms.RadioButton();
            this.radioButtonGetMinLemgth = new System.Windows.Forms.RadioButton();
            this.radioButtonGetAverageLength = new System.Windows.Forms.RadioButton();
            this.radioButtonGetMaxValue = new System.Windows.Forms.RadioButton();
            this.radioButtonGetMinValue = new System.Windows.Forms.RadioButton();
            this.radioButtonGetAverageValue = new System.Windows.Forms.RadioButton();
            this.btnEditFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(126, 29);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // countNodes
            // 
            this.countNodes.AutoSize = true;
            this.countNodes.Location = new System.Drawing.Point(13, 49);
            this.countNodes.Name = "countNodes";
            this.countNodes.Size = new System.Drawing.Size(162, 20);
            this.countNodes.TabIndex = 1;
            this.countNodes.Text = "Количество объектов:";
            // 
            // childNodes
            // 
            this.childNodes.FormattingEnabled = true;
            this.childNodes.Location = new System.Drawing.Point(576, 92);
            this.childNodes.Name = "childNodes";
            this.childNodes.Size = new System.Drawing.Size(133, 28);
            this.childNodes.TabIndex = 2;
            this.childNodes.SelectedIndexChanged += new System.EventHandler(this.childNodes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Операции над строковыми данными";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Операции над числовыми данными";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Доступные параметры";
            // 
            // selectedOperation
            // 
            this.selectedOperation.AutoSize = true;
            this.selectedOperation.Location = new System.Drawing.Point(557, 141);
            this.selectedOperation.Name = "selectedOperation";
            this.selectedOperation.Size = new System.Drawing.Size(165, 20);
            this.selectedOperation.TabIndex = 13;
            this.selectedOperation.Text = "Выбранная операция:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(557, 165);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(78, 20);
            this.result.TabIndex = 14;
            this.result.Text = "Результат:";
            // 
            // radioButtonGetMaxLength
            // 
            this.radioButtonGetMaxLength.AutoSize = true;
            this.radioButtonGetMaxLength.Location = new System.Drawing.Point(36, 96);
            this.radioButtonGetMaxLength.Name = "radioButtonGetMaxLength";
            this.radioButtonGetMaxLength.Size = new System.Drawing.Size(231, 24);
            this.radioButtonGetMaxLength.TabIndex = 15;
            this.radioButtonGetMaxLength.TabStop = true;
            this.radioButtonGetMaxLength.Text = "Максимальная длина строки";
            this.radioButtonGetMaxLength.UseVisualStyleBackColor = true;
            this.radioButtonGetMaxLength.CheckedChanged += new System.EventHandler(this.radioButtonGetMaxLength_CheckedChanged);
            // 
            // radioButtonGetMinLemgth
            // 
            this.radioButtonGetMinLemgth.AutoSize = true;
            this.radioButtonGetMinLemgth.Location = new System.Drawing.Point(36, 127);
            this.radioButtonGetMinLemgth.Name = "radioButtonGetMinLemgth";
            this.radioButtonGetMinLemgth.Size = new System.Drawing.Size(227, 24);
            this.radioButtonGetMinLemgth.TabIndex = 16;
            this.radioButtonGetMinLemgth.TabStop = true;
            this.radioButtonGetMinLemgth.Text = "Минимальная длина строки";
            this.radioButtonGetMinLemgth.UseVisualStyleBackColor = true;
            this.radioButtonGetMinLemgth.CheckedChanged += new System.EventHandler(this.radioButtonGetMinLemgth_CheckedChanged);
            // 
            // radioButtonGetAverageLength
            // 
            this.radioButtonGetAverageLength.AutoSize = true;
            this.radioButtonGetAverageLength.Location = new System.Drawing.Point(36, 158);
            this.radioButtonGetAverageLength.Name = "radioButtonGetAverageLength";
            this.radioButtonGetAverageLength.Size = new System.Drawing.Size(186, 24);
            this.radioButtonGetAverageLength.TabIndex = 17;
            this.radioButtonGetAverageLength.TabStop = true;
            this.radioButtonGetAverageLength.Text = "Средняя длина строки";
            this.radioButtonGetAverageLength.UseVisualStyleBackColor = true;
            this.radioButtonGetAverageLength.CheckedChanged += new System.EventHandler(this.radioButtonGetAverageLength_CheckedChanged);
            // 
            // radioButtonGetMaxValue
            // 
            this.radioButtonGetMaxValue.AutoSize = true;
            this.radioButtonGetMaxValue.Location = new System.Drawing.Point(312, 96);
            this.radioButtonGetMaxValue.Name = "radioButtonGetMaxValue";
            this.radioButtonGetMaxValue.Size = new System.Drawing.Size(205, 24);
            this.radioButtonGetMaxValue.TabIndex = 18;
            this.radioButtonGetMaxValue.TabStop = true;
            this.radioButtonGetMaxValue.Text = "Максимальное значение";
            this.radioButtonGetMaxValue.UseVisualStyleBackColor = true;
            this.radioButtonGetMaxValue.CheckedChanged += new System.EventHandler(this.radioButtonGetMaxValue_CheckedChanged);
            // 
            // radioButtonGetMinValue
            // 
            this.radioButtonGetMinValue.AutoSize = true;
            this.radioButtonGetMinValue.Location = new System.Drawing.Point(312, 127);
            this.radioButtonGetMinValue.Name = "radioButtonGetMinValue";
            this.radioButtonGetMinValue.Size = new System.Drawing.Size(201, 24);
            this.radioButtonGetMinValue.TabIndex = 19;
            this.radioButtonGetMinValue.TabStop = true;
            this.radioButtonGetMinValue.Text = "Минимальное значение";
            this.radioButtonGetMinValue.UseVisualStyleBackColor = true;
            this.radioButtonGetMinValue.CheckedChanged += new System.EventHandler(this.radioButtonGetMinValue_CheckedChanged);
            // 
            // radioButtonGetAverageValue
            // 
            this.radioButtonGetAverageValue.AutoSize = true;
            this.radioButtonGetAverageValue.Location = new System.Drawing.Point(312, 158);
            this.radioButtonGetAverageValue.Name = "radioButtonGetAverageValue";
            this.radioButtonGetAverageValue.Size = new System.Drawing.Size(159, 24);
            this.radioButtonGetAverageValue.TabIndex = 20;
            this.radioButtonGetAverageValue.TabStop = true;
            this.radioButtonGetAverageValue.Text = "Среднее значение";
            this.radioButtonGetAverageValue.UseVisualStyleBackColor = true;
            this.radioButtonGetAverageValue.CheckedChanged += new System.EventHandler(this.radioButtonGetAverageValue_CheckedChanged);
            // 
            // btnEditFile
            // 
            this.btnEditFile.Location = new System.Drawing.Point(13, 188);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(126, 52);
            this.btnEditFile.TabIndex = 21;
            this.btnEditFile.Text = "Отредактировать файл";
            this.btnEditFile.UseVisualStyleBackColor = true;
            this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.btnEditFile);
            this.Controls.Add(this.radioButtonGetAverageValue);
            this.Controls.Add(this.radioButtonGetMinValue);
            this.Controls.Add(this.radioButtonGetMaxValue);
            this.Controls.Add(this.radioButtonGetAverageLength);
            this.Controls.Add(this.radioButtonGetMinLemgth);
            this.Controls.Add(this.radioButtonGetMaxLength);
            this.Controls.Add(this.result);
            this.Controls.Add(this.selectedOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.childNodes);
            this.Controls.Add(this.countNodes);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label countNodes;
        private System.Windows.Forms.ComboBox childNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedOperation;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.RadioButton radioButtonGetMaxLength;
        private System.Windows.Forms.RadioButton radioButtonGetMinLemgth;
        internal System.Windows.Forms.RadioButton radioButtonGetAverageLength;
        private System.Windows.Forms.RadioButton radioButtonGetMaxValue;
        private System.Windows.Forms.RadioButton radioButtonGetMinValue;
        private System.Windows.Forms.RadioButton radioButtonGetAverageValue;
        private System.Windows.Forms.Button btnEditFile;
    }
}

