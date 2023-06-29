using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public class ListData
    {
        public IList<CheckboxData> checkBoxes { get; set; }
    }
    public class CheckboxData
    {
        public string Value { get; set; }
        public bool Checked { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            DateTime sdate = date.Value;
            //File.AppendAllText($"{sdate.Year}-{sdate.Month}-{sdate.Day}.list", $"{textBox1.Text}\n");

            var listdata = new ListData
            {
                checkBoxes = new List<CheckboxData>()
            };
            

            for(int i = 0; i < checkedListBox1.Items.Count; i++) {
                var checkboxdata = new CheckboxData
                {
                    Value = checkedListBox1.Items[i].ToString(),
                    Checked = checkedListBox1.GetItemChecked(i)
                };
                listdata.checkBoxes.Add(checkboxdata);
            };

            
            Console.WriteLine(JsonSerializer.Serialize(listdata));
            File.WriteAllText($"{sdate.Year}-{sdate.Month}-{sdate.Day}.list", JsonSerializer.Serialize(listdata));
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            double perc = checkedListBox1.CheckedIndices.Count / (double)checkedListBox1.Items.Count;

            progressBar1.Value = (int)(100 * perc);

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Task.Run(() =>
            {

                Thread.Sleep(500);
                Invoke(new Action(() => { UpdateProgress(); }));
            });
        }

        private void UpdateProgress()
        {

            double perc = checkedListBox1.CheckedIndices.Count / (double)checkedListBox1.Items.Count;

            progressBar1.Value = (int)(100 * perc);
        }
    }
}
