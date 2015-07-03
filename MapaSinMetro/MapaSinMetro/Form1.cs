using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSinMetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder queryinicio = new StringBuilder();
            queryinicio.Append("https://www.google.com.do/maps/place/Rep%C3%BAblica+Dominicana/@18.8232809,-71.1661454,7z/data=!4m2!3m1!1s0x8eaf8838def1b6f5:0xa6020f24060df7e0?hl=es");

            webBrowser1.Navigate(queryinicio.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calle = txtbxCalle.Text;
            string ciudad = txtbxCiudad.Text;
            string municipio = txtbxMunicipio.Text;
            string pais = txtbxPais.Text;
            try
            {
                StringBuilder querydireccion = new StringBuilder();
                querydireccion.Append("http://maps.google.com/maps?q=");

                if (calle != string.Empty)
                {
                    querydireccion.Append(calle + "," + "+");
                }
                if (ciudad != string.Empty)
                {
                    querydireccion.Append(ciudad + "," + "+");
                }
                if (municipio != string.Empty)
                {
                    querydireccion.Append(municipio + "," + "+");
                }
                if (pais != string.Empty)
                {
                    querydireccion.Append(pais + "," + "+");
                }

                webBrowser1.Navigate(querydireccion.ToString());

            }//final try
            catch (Exception ex)
            {
                //MetroMessageBox.Show(this, ex.Message.ToString(), "Error", 220);
                MessageBox.Show(ex.Message.ToString() );
            }
        }
    
    
    
    
    }
}
