using bntu.vsrpp.vmisyakova.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bntu.vsrpp.vmisyakova.lab1
{
    public partial class Form1 : Form
    {
        private readonly XMLReader reader;
        private readonly XMLEditor editor;
        private string path;

        public Form1()
        {
            reader = new XMLReader();
            editor = new XMLEditor();
            InitializeComponent();
            openFileDialog1.Filter = "XML files(*.xml)|*.xml";
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            countNodes.Text = "Количество объектов:";
            path = openFileDialog1.FileName;
            reader.ReadXML(path);
            countNodes.Text = countNodes.Text + " " + reader.GetCountNode().ToString();
            MessageBox.Show("Файл открыт.","Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetNumericItem()
        {
            childNodes.Items.Clear();
            childNodes.Items.AddRange(reader.GetNumericTypeChildNodes().ToArray());
            childNodes.SelectedItem = childNodes.Items[0];
        }

        private void SetStringItem()
        {
            childNodes.Items.Clear();
            childNodes.Items.AddRange(reader.GetStringTypeChildNodes().ToArray());
            childNodes.SelectedItem = childNodes.Items[0];
        }

        private void radioButtonGetMaxLength_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMaxLength.Checked == true)
            {
                try
                {
                    SetStringItem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButtonGetMinLemgth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMinLemgth.Checked == true)
            {
                try
                {
                    SetStringItem();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButtonGetAverageLength_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetAverageLength.Checked == true)
            {
                try
                {
                    SetStringItem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButtonGetMaxValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMaxValue.Checked == true)
            {
                try
                {
                    SetNumericItem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButtonGetMinValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetMinValue.Checked == true)
            {
                try
                {
                    SetNumericItem();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButtonGetAverageValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGetAverageValue.Checked == true)
            {
                try
                {
                    SetNumericItem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void childNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOperation.Text = "Выбранная операция:";
            result.Text = "Результат:";
            if (radioButtonGetMaxLength.Checked == true)
            {
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMaxLength.Text;
                result.Text = result.Text + " " + reader.GetMaxLength(childNodes.Text);
            } else if(radioButtonGetMinLemgth.Checked == true)
            {
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMinLemgth.Text;
                result.Text = result.Text + " " + reader.GetMinLength(childNodes.Text);
            } else if(radioButtonGetAverageLength.Checked == true)
            {
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetAverageLength.Text;
                result.Text = result.Text + " " + reader.GetAverageLength(childNodes.Text);
            } else if(radioButtonGetMaxValue.Checked == true)
            {
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMaxValue.Text;
                result.Text = result.Text + " " + reader.GetMaxValue(childNodes.Text);
            } else if(radioButtonGetMinValue.Checked == true)
            {
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetMinValue.Text;
                result.Text = result.Text + " " + reader.GetMinValue(childNodes.Text);
            }else if(radioButtonGetAverageValue.Checked == true)
            {
                selectedOperation.Text = selectedOperation.Text + " " + radioButtonGetAverageValue.Text;
                result.Text = result.Text + " " + reader.GetAverageValue(childNodes.Text);
            }
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            try
            {
                editor.CreateNewXMLDoc(path);
                MessageBox.Show("Файл отредактирован и сохранен", "Редактирование файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "" +
                    "!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
