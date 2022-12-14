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

namespace AbrirModificarArchivoTipoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog dialogo = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "buscar archivo de texto";
            openFileDialog1.ShowDialog();
            string texto = openFileDialog1.FileName;
            if (File.Exists(openFileDialog1.FileName))
            {
                TextReader leer = new StreamReader(texto);
                richTextBox1.Text = leer.ReadToEnd();
                leer.Close();
            }
            textBox1.Text = texto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {
                    string texto = saveFileDialog1.FileName;
                    StreamWriter textoguardar = File.CreateText(texto);
                    textoguardar.Write(richTextBox1.Text);
                    textoguardar.Close();
                    textoguardar.Flush();
                    textBox1.Text = texto;
                }
                else
                {
                    string texto = saveFileDialog1.FileName;
                    StreamWriter textoguardar = File.CreateText(texto);
                    textoguardar.Write(richTextBox1.Text);
                    textoguardar.Close();
                    textoguardar.Flush();
                    textBox1.Text = texto;
                }
            }
        }
    }
}
