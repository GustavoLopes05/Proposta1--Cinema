using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proposta1__Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Box_Título_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_Origem_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Desmarcar todos os checkboxes
            foreach (var control in this.Controls.OfType<CheckBox>())
            {
                control.Checked = false;
            }

            // Desmarcar todos os radiobuttons
            foreach (var control in this.Controls.OfType<RadioButton>())
            {
                control.Checked = false;
            }

            // Limpar a seleção do combobox
            comboBox_Origem.SelectedIndex = -1;

            // Limpar o texto da textBox1
            Box_Título.Clear();

            // Limpar a data
            maskedTextBox1.Clear();

            // Limpar ListBox
            listBox1.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Origem.Items.Add("");
            comboBox_Origem.Items.Add("Português");
            comboBox_Origem.Items.Add("Inglês");
            comboBox_Origem.Items.Add("Angolano");
            comboBox_Origem.Items.Add("Sueco");
            comboBox_Origem.Items.Add("Grego");

            listBox1.Items.Add("");
            listBox1.Items.Add("Músical");
            listBox1.Items.Add("Terror");
            listBox1.Items.Add("Comédia");
            listBox1.Items.Add("Documentário");


        }
    }
}
