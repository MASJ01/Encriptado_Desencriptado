using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int llave, numero_renglones;

        string textofinal; 

        private void RDB_ENCRIPTAR_CheckedChanged(object sender, EventArgs e)
        {
            BTN_ACCION.Text = "Encriptar"; 
        }

        private void RDB_DESENCRIPTAR_CheckedChanged(object sender, EventArgs e)
        {
            BTN_ACCION.Text = "Desencriptar"; 
        }

        private void BTN_ENTRAR_Click(object sender, EventArgs e)
        {
            if (RDB_ENCRIPTAR.Checked == true || RDB_DESENCRIPTAR.Checked == true)
            {
                groupBox2.Visible = true;
                BTN_ABRIR1.Visible = true;
                BTN_GUARDAR.Visible = true;
                BTN_NUEVO.Visible = true;
                groupBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("NO SELECCIONO ACCIÓN", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BTN_ACCION_Click(object sender, EventArgs e)
        {
            if (RDB_ENCRIPTAR.Checked == true)
            {
                encriptar();
            }

            else
            {
                desencriptar(); 
            }

        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BTN_ABRIR1_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void encriptar()
        {
            llave = int.Parse(NUD_LLAVE.Value.ToString());
            numero_renglones = RTF_ORIGINAL.Lines.Length; // Cuenta cuantas lineas se tiene 
            textofinal = null;  // Se inicializan las variables en estas lineas de codigo 

            for (int linea = 0; linea < numero_renglones; linea++)
            {
                string texto_linea = RTF_ORIGINAL.Lines[linea].ToString(); // Se extrae el texto de las lineas y se guarda en texto_linea
                string texto2 = null; // Se guarda el texto encriptado

                for (int caracter = 0; caracter < texto_linea.Length; caracter++)
                {
                    int caracter_ascii = Convert.ToInt32(Convert.ToChar(texto_linea[caracter].ToString())); // Paso 1
                    int nuevo_valor = caracter_ascii + llave; // Paso 2
                    char nueva_letra = Convert.ToChar(nuevo_valor);
                    texto2 += nueva_letra.ToString(); // Se guarda lo que se va extrayendo
                } // Cuando termina, cambia de linea

                textofinal += texto2 + "\n"; // Diagonal n es para dar un enter (Si son 10 renglones, vuelven a quedar 10 renglones)
            }
            RTF_MODIFICADO.Text = textofinal; 
        }

        private void desencriptar() 
        {
            llave = int.Parse(NUD_LLAVE.Value.ToString());
            numero_renglones = RTF_ORIGINAL.Lines.Length; // Cuenta cuantas lineas se tiene 
            textofinal = null;  // Se inicializan las variables en estas lineas de codigo 

            for (int linea = 0; linea < numero_renglones; linea++)
            {
                string texto_linea = RTF_ORIGINAL.Lines[linea].ToString(); // Se extrae el texto de las lineas y se guarda en texto_linea
                string texto2 = null; // Se guarda el texto encriptado

                for (int caracter = 0; caracter < texto_linea.Length; caracter++)
                {
                    int caracter_ascii = Convert.ToInt32(Convert.ToChar(texto_linea[caracter].ToString())); // Paso 1
                    int nuevo_valor = caracter_ascii - llave; // Paso 2
                    char nueva_letra = Convert.ToChar(nuevo_valor);
                    texto2 += nueva_letra.ToString(); // Se guarda lo que se va extrayendo
                } // Cuando termina, cambia de linea

                textofinal += texto2 + "\n"; // Diagonal n es para dar un enter (Si son 10 renglones, vuelven a quedar 10 renglones)
            }
            RTF_MODIFICADO.Text = textofinal; 
        }

        private void nuevo()
        {
          
            if (RDB_ENCRIPTAR.Checked == true || RDB_DESENCRIPTAR.Checked == true)
            {
                groupBox2.Visible = false;
                BTN_ABRIR1.Visible = false;
                BTN_GUARDAR.Visible = false;
                BTN_NUEVO.Visible = false;
                groupBox1.Enabled = true;

                RTF_ORIGINAL.Clear();
                RTF_MODIFICADO.Clear();

            }
            else
            {
                MessageBox.Show("NO SELECCIONO ACCIÓN", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }


        private void guardar()
        {
            cuadro_guardar = new SaveFileDialog();
            if (cuadro_guardar.ShowDialog() == DialogResult.OK) // ShowDialogo nos permite ver algo en el proyecto, otra ventana. Para saber a que le di click, por ejemplo, cuando le das cerrar a un programa y te pregunta si deseas guardar antes de salir.
            {
                if (cuadro_guardar.FileName != "") // File name compara el nombre que inserta el usuario 
                {
                   RTF_MODIFICADO.SaveFile(cuadro_guardar.FileName);
                }
            }
        }

        private void abrir()
        {
            cuadro_abrir = new OpenFileDialog();
            if (cuadro_abrir.ShowDialog() == DialogResult.OK)
            {
                RTF_ORIGINAL.LoadFile(cuadro_abrir.FileName);
            } 
        }

        
    }
}
