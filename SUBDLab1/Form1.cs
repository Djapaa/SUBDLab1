using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SUBDLab1
{
    public partial class FormLab : Form
    {
        public FormLab()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string author = textBox2.Text;
            string ganre = textBox3.Text;
            string yearOfManufacture = textBox4.Text;
            string сoverWidth = textBox5.Text;
            string coverHight = textBox7.Text;
            string bindingFormat = comboBox1.Text;
            string sourceOfAppearance = comboBox2.Text;
            string dateOfAppearanceInTheLibrary = maskedTextBox1.Text;
            string dateOfReading = maskedTextBox2.Text;
            string rating = textBox10.Text;
            dataGridView1.Rows.Add(name, author, ganre,yearOfManufacture, сoverWidth, coverHight,
                bindingFormat, sourceOfAppearance, dateOfAppearanceInTheLibrary, dateOfReading, rating);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox10.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(index);

                FileStream fs = new FileStream(@"C:\Users\esteb\Desktop\file.txt", FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fs);

                try
                {
                    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    {
                        for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                        {
                            streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + ";");
                        }

                        streamWriter.WriteLine();
                    }

                    streamWriter.Close();
                    fs.Close();  
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении из файла!");
                }
            }
            catch
            {
                MessageBox.Show("Пустая строка");
            }
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отркытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split(';');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch
                                {

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { myread.Close(); }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\esteb\Desktop\file.txt", FileMode.Open);
            StreamWriter streamWriter = new StreamWriter(fs);

            try
            {
                for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + ";");
                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }

        }

        private void BindingFormatLabel_Click(object sender, EventArgs e)
        {

        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            string str = File.ReadAllText(@"C:\Users\esteb\Desktop\file.txt");

            string[] words = str.Split(';');

            foreach(string r in words)
            {
                if(r==FindTextBox.Text)
                {
                    listBox1.Items.Add(r);
                }
            }


        }

        private void RatingLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormLab_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

