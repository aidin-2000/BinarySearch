using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            try
            {
                Element result = new Element();
                BinarySearchClass BS = new BinarySearchClass();
                result=BS.main(dataSetInput, valueForSearchInput.Text);
                resultOutput.Text = result.id.ToString() + ". " + result.value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valueForSearchInput.Text = "";
            dataSetInput.Clear();
            resultOutput.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataSetInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
