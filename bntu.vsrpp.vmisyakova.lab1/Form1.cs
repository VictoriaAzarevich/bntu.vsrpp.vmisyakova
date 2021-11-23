using bntu.vsrpp.vmisyakova.Core;
using System;
using System.Windows.Forms;

namespace bntu.vsrpp.vmisyakova.lab1
{
    public partial class Form1 : Form
    {
        private readonly XMLReader _reader;
        private readonly XMLEditor _editor;
        private string _path;
        private bool flag1;
        private bool flag2;

        public Form1()
        {
            _reader = new XMLReader();
            _editor = new XMLEditor();
            InitializeComponent();
            openFileDialog1.Filter = "XML files(*.xml)|*.xml";
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            countNodes.Text = "Количество объектов:";
            _path = openFileDialog1.FileName;
            _reader.ReadXML(_path);
            countNodes.Text = countNodes.Text + " " + _reader.GetCountNode().ToString();
            MessageBox.Show("Файл открыт.", "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetNumericItem()
        {
            if (flag1 != false || !flag2)
            {
                childNodes.Items.Clear();
                childNodes.Items.AddRange(_reader.GetNumericTypeChildNodes().ToArray());
                childNodes.SelectedItem = childNodes.Items[0];
                flag1 = false;
                flag2 = true;
            }
        }

        private void SetStringItem()
        {
            if (flag1 != true || !flag2)
            {
                childNodes.Items.Clear();
                childNodes.Items.AddRange(_reader.GetStringTypeChildNodes().ToArray());
                childNodes.SelectedItem = childNodes.Items[0];
                flag1 = true;
                flag2 = true;
            }
        }

        private void Set()
        {
            childNodes_SelectedIndexChanged(null, null);
        }

        private void radioButtonGetMaxLength_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMaxLength.Checked != true) return;
            try
            {
                Set();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonGetMinLength_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMinLemgth.Checked != true) return;
            try
            {
                Set();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonGetAverageLength_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetAverageLength.Checked != true) return;
            try
            {
                Set();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonGetMaxValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMaxValue.Checked != true) return;
            try
            {
                Set();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonGetMinValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMinValue.Checked != true) return;
            try
            {
                Set();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonGetAverageValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetAverageValue.Checked != true) return;
            try
            {
                Set();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void childNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOperation.Text = "Выбранная операция:";
            result.Text = "Результат:";
            if (radioButtonGetMaxLength.Checked == true)
            {
                result.Text = result.Text + " " + _reader.GetMaxLength(childNodes.Text);
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMaxLength.Text;
            }
            else if (radioButtonGetMinLemgth.Checked == true)
            {
                result.Text = result.Text + " " + _reader.GetMinLength(childNodes.Text);
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMinLemgth.Text;
            }
            else if (radioButtonGetAverageLength.Checked == true)
            {
                result.Text = result.Text + " " + _reader.GetAverageLength(childNodes.Text).ToString("0.00");
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetAverageLength.Text;
            }
            else if (radioButtonGetMaxValue.Checked == true)
            {
                result.Text = result.Text + " " + _reader.GetMaxValue(childNodes.Text);
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMaxValue.Text;
            }
            else if (radioButtonGetMinValue.Checked == true)
            {
                result.Text = result.Text + " " + _reader.GetMinValue(childNodes.Text);
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMinValue.Text;
            }
            else if (radioButtonGetAverageValue.Checked == true)
            {
                result.Text = result.Text + " " + _reader.GetAverageValue(childNodes.Text).ToString("0.00");
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetAverageValue.Text;
            }
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            try
            {
                _editor.CreateNewXMLDoc(_path);
                MessageBox.Show("Файл отредактирован и сохранен", "Редактирование файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButtonGetMaxValue.Checked = false;
            radioButtonGetMinValue.Checked = false;
            radioButtonGetAverageValue.Checked = false;
            try
            {
                SetStringItem();
            }
            catch (Exception) { }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            radioButtonGetMaxLength.Checked = false;
            radioButtonGetMinLemgth.Checked = false;
            radioButtonGetAverageLength.Checked = false;
            try
            {
                SetNumericItem();
            }
            catch (Exception) { }
        }
    }
}
