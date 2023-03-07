using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> listInt = new List<int>();
        List<Double> listDouble = new List<Double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.userInput.Text, out int i))
            {
                int data = int.Parse(this.userInput.Text);
                this.searchResult.Text = Search(listInt, data).ToString();
            } 
            else if(Double.TryParse(this.userInput.Text, out Double d))
            {
                Double data = Double.Parse(this.userInput.Text);
                this.searchResult.Text = Search(listDouble, data).ToString();
            }
            else
            {
                this.searchResult.Text = "Invalid Input";
            }

            

           
        }

        private void generateIntButton_Click(object sender, EventArgs e)
        {
            listInt.Clear();
            listDouble.Clear();
            string str = "[";
            Random r = new Random();
            for (int i = 0; i <= 4; i++)
            {
                int auxInt = r.Next(0, 100);
                listInt.Add(auxInt);
                str += auxInt.ToString() + "  ";
                
            }
            str += "]";
            this.arrayList.Text = str; 
            
        }

        private void generateDoubleButton_Click(object sender, EventArgs e)
        {
            listDouble.Clear();
            listInt.Clear();
            string str = "[";
            Random r = new Random();
            for (int i = 0; i <= 4; i++)
            {
                Double auxDouble = r.NextDouble() * 100 ;
                listDouble.Add( Math.Round(auxDouble, 2) );
                str += Math.Round(auxDouble, 2).ToString() + "  ";

            }
            str += "]";
            this.arrayList.Text = str;
        }

        private static int Search(List<int> list, int data)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (data == list[i]) return i;
            }
            return -1;
        }
        private static int Search(List<Double> list, Double data)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (data == list[i]) return i;
            }
            return -1;
        }

    }
}
