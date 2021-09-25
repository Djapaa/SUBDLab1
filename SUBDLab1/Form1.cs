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
using Microsoft.Win32;

namespace SUBDLab1
{
    
    public partial class FormLab : Form
    {
         object locker = new object();
        public FormLab()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                lock(locker)
                    {

                    FileStream fs = new FileStream(@"C:\Users\esteb\source\repos\SUBDLab1\file.txt", FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fs);


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
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].SetValues(name, author, ganre, yearOfManufacture, сoverWidth, coverHight,
                       bindingFormat, sourceOfAppearance, dateOfAppearanceInTheLibrary, dateOfReading, rating);
                   
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
                        MessageBox.Show("Ошибка при добавлении из файла!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл занят");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lock(locker)
            {
               

                    try
                    {
                            

                            FileStream fs = new FileStream(@"C:\Users\esteb\source\repos\SUBDLab1\file.txt", FileMode.Create);
                            StreamWriter streamWriter = new StreamWriter(fs);
                            int index = dataGridView1.SelectedCells[0].RowIndex;
                            dataGridView1.Rows.RemoveAt(index);

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
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                }

                }
                
           
        }



        private void отркытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (locker)
            {

                try
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

                catch
                {
                    MessageBox.Show("Файл занят");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (locker)
            {
                try
                {
                    FileStream fs = new FileStream(@"C:\Users\esteb\source\repos\SUBDLab1\file.txt", FileMode.Open);
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

                        MessageBox.Show("Файл успешно сохранен");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении файла!");
                    }
                }
                catch
                {
                    MessageBox.Show("Файл занят");
                }
               
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            lock (locker)
            {
                try
                {

                    FileStream fs = new FileStream(@"C:\Users\esteb\source\repos\SUBDLab1\file.txt", FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fs);


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
                    dataGridView1.Rows.Add(name, author, ganre, yearOfManufacture, сoverWidth, coverHight,
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
                        MessageBox.Show("Ошибка при добавлении из файла!");
                    }
                }

                catch
                {
                    MessageBox.Show("Файл занят");
                }
            }
        }
            
        




        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            lock (locker)
            {
                try
                {

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(FindTextBox.Text))
                                {
                                    dataGridView1.Rows[i].Selected = true;
                                    break;
                                }
                             }
                


                }
                catch
                {
                    MessageBox.Show("Файл занят");
                }
            }
        }

        private void BindingFormatLabel_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    if (dataGridView1.CurrentRow.Cells[1].Value != null)
                    {
                        textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                        maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                        textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    }
                    else
                    {

                    }
                }
            }

            catch
            {
                MessageBox.Show("Строка пустая");
            }
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static void Shuffle(string[] a)
        {
            var rand = new Random();
            for (int i = a.Length - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                string tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }
        }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lock(locker)
            {


            try
            {


                string text = File.ReadAllText(@"C:\Users\esteb\source\repos\SUBDLab1\name.txt");
                string[] author = text.Split(';');

                string text1 = File.ReadAllText(@"C:\Users\esteb\source\repos\SUBDLab1\123.txt");
                string[] nameBook = text1.Split(';');

                string[] ganre = { "драма", "приключения", "семейный", "биография", "история" };
                string[] width = { "155", "105","215", "165" };
                string[] height = { "205", "250", "165", "300" };
                string[] format = { "мягкий", "твердый"};
                string[] soursce = { "покупка","подарок","наследство" };
                string[] rating = { "1", "2","3","4","5" };

                dataGridView1.RowCount = Convert.ToInt32(maskedTextBoxadd.Text);
                dataGridView1.ColumnCount = 11;
                for (int j = 0; j < dataGridView1.RowCount ; j++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {



                        if (k == 0)
                        {
                            Shuffle(nameBook);
                            dataGridView1[k, j].Value = string.Join(";", nameBook.Take(1));
                        }
                        if (k == 1)
                        {
                            Shuffle(author);
                            dataGridView1[k, j].Value = string.Join(";", author.Take(1));
                            
                        }
                        if (k == 2)
                        {
                            Shuffle(ganre);
                            dataGridView1[k, j].Value = string.Join(";", ganre.Take(1));
                        }
                        if (k == 3)
                        {
                            dataGridView1[k, j].Value = RandomDay().ToString("yyyy");
                        }
                        if (k == 4)
                        {
                            Shuffle(width);
                            dataGridView1[k, j].Value = string.Join(";", width.Take(1));
                        }
                        if (k == 5)
                        {
                            Shuffle(height);
                            dataGridView1[k, j].Value = string.Join(";", height.Take(1));
                        }
                        if (k == 6)
                        {
                            Shuffle(format);
                            dataGridView1[k, j].Value = string.Join(";", format.Take(1));
                        }
                        if (k == 7)
                        {
                            Shuffle(soursce);
                            dataGridView1[k, j].Value = string.Join(";", soursce.Take(1));
                        }
                        if (k == 8)
                        {
                            dataGridView1[k, j].Value = RandomDay().ToString("MM.yyyy");
                        }
                        if (k == 9)
                        {
                            dataGridView1[k, j].Value = RandomDay().ToString("MM.yyyy");

                        }
                        if (k == 10)
                        {
                            Shuffle(rating);
                            dataGridView1[k, j].Value = string.Join(";", rating.Take(1));
                        }

                    }
                    FileStream fs = new FileStream(@"C:\Users\esteb\source\repos\SUBDLab1\file.txt", FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fs);

                    try
                    {
                        for (int n = 0; n < dataGridView1.Rows.Count - 1; n++)
                        {
                            for (int i = 0; i < dataGridView1.Rows[n].Cells.Count; i++)
                            {
                                streamWriter.Write(dataGridView1.Rows[n].Cells[i].Value + ";");
                            }
                            streamWriter.WriteLine();

                        }

                        streamWriter.Close();
                        fs.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении файла!");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Файл занят ");
            }


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lock (locker)
            {
                try
            {

                    FileStream fs = new FileStream(@"C:\Users\esteb\source\repos\SUBDLab1\file.txt", FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fs);

                    dataGridView1.Rows.Clear();

                

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
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении из файла!");
                }
            }
            catch
            {
                MessageBox.Show("Файл занят");
            }
           }
        }
    }
}


