using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pseudoaleatorios
{
    public partial class Form1 : Form
    {
        List<Numero> numbers = new List<Numero>();
        List<uniformidad> pUniformidad= new List<uniformidad>();
        public Form1()
        {
            InitializeComponent();
            cbxAlgoritms.SelectedIndex = 0;

            dgvNumbers.RowHeadersVisible = false;
            dgvUniformidad.RowHeadersVisible = false;

            dgvNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUniformidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (!(int.TryParse(txtAmount.Text, out int amount) && amount > 0))
            {
                MessageBox.Show("La cantidad debe ser un valor entero mayor a 0");
                return;
            }
            if (!(long.TryParse(txtParameter1.Text, out long parm1) && parm1> 0)) {
                MessageBox.Show("La semilla debe ser un valor entero mayor a 0");
                return;
            }
            int indice = cbxAlgoritms.SelectedIndex; // 0=cruadados - 1=productos - 2 =multiplicador
            if (lblParameter2.Visible == true){
                if (!(long.TryParse(txtParameter2.Text, out long parm2) && parm2 > 0 &&
                       parm1.ToString().Length == parm2.ToString().Length)){
                    MessageBox.Show("El segundo valor debe tener los mismos digitos que la semilla");
                    return;

                }

                if (indice == 1)
                {
                    productosMedios(parm1, parm2, amount);
                }
                else { 
                    multiplicadorConstante(parm1, parm2, amount);
                }

            }
            else {
                
                cuadradosMedios(parm1, amount);                
            }
            //MessageBox.Show(numbers.Count + " - " + indice + " - " + numbers[0]);

            dgvNumbers.DataSource = null;
            dgvNumbers.DataSource = numbers;
            dgvNumbers.Columns["Valor"].HeaderText = "Numeros";


            txtMLimInf.Text = "";
            txtMMedia.Text = "";
            txtMMedia.BackColor = Color.White;
            txtMLimSup.Text = "";

            txtVLimInf.Text = "";
            txtVVarianza.Text = "";
            txtVVarianza.BackColor = Color.White;
            txtVLimSup.Text = "";

            dgvUniformidad.DataSource = null;
            txtChiCuad.Text = "";
            txtDecPU.BackColor = Color.White;
            txtValorTab.Text = "";

            //productosMedios(seed, seed2, amount);
        }

        void cuadradosMedios(long semilla, int cantidad)
        {

            numbers.Clear();

            int digitos = semilla.ToString().Length;
            long y, number;
            string sy, num;

            for (int i = 0; i < cantidad; i++)
            {
                y = semilla * semilla;
                sy = y.ToString();
                if (sy.Length < digitos)
                {
                    sy = sy.PadLeft(digitos + 2, '0');
                }
                num = sy.Substring(sy.Length / 2 - digitos / 2, digitos);
                number = long.Parse(num);
                semilla = number;

                numbers.Add(new Numero { Valor = number / 10000.0 });
                //Console.WriteLine(sy + " - " + number);
            }
        }


        void productosMedios(long semilla1, long semilla2, int cantiad)
        {
            numbers.Clear();

            int digitos = semilla1.ToString().Length;
            long y, number;
            string sy, num;

            for (int i = 0; i < cantiad; i++)
            {

                y = semilla1 * semilla2;
                sy = y.ToString();
                if (sy.Length < digitos)
                {
                    sy = sy.PadLeft(digitos + 2, '0');
                }
                num = sy.Substring(sy.Length / 2 - digitos / 2, digitos);
                number = long.Parse(num);
                semilla1 = semilla2;
                semilla2 = number;

                numbers.Add(new Numero { Valor = number / 10000.0 });
                //Console.WriteLine(sy + " - " + number);
            }
          
        }


        void multiplicadorConstante(long semilla, long constante, int cantidad)
        {

            numbers.Clear();

            int digitos = semilla.ToString().Length;
            long y, number;
            string sy, num;


            for (int i = 0; i < cantidad; i++)
            {
                y = semilla * constante;

                sy = y.ToString();
                if (sy.Length < digitos)
                {
                    sy = sy.PadLeft(digitos + 2, '0');
                }
                num = sy.Substring(sy.Length / 2 - digitos / 2, digitos);
                number = long.Parse(num);
                semilla = number;

                numbers.Add(new Numero { Valor = number / 10000.0 });
                //Console.WriteLine(sy + " - " + number);

            }

        }

        private void cbxAlgoritms_SelectedIndexChanged(object sender, EventArgs e){
            int index = cbxAlgoritms.SelectedIndex;
            //Cuadrados medios
            if (index == 0){
                lblParameter2.Visible = false;
                txtParameter2.Visible = false;
            }
            //Productos Medios
            else if (index == 1){
                lblParameter2.Visible = true;
                txtParameter2.Visible = true;

                lblParameter2.Text = "Ingrese semilla 2";
            }
            //Multiplicador constante
            else
            { 
                lblParameter2.Visible = true;
                txtParameter2.Visible = true;

                lblParameter2.Text = "Ingrese constante: ";
            }
        }

        void pruebaDeMedias(int confianza)
        {
            double media = numbers.Average(n => n.Valor);
            double nivelConfianza = confianza / 100.0;
            double alpha = 1 - nivelConfianza;
            double z = Normal.InvCDF(0, 1, nivelConfianza + alpha / 2);

            double limInf = (1 / 2.0) - (z * (1 / Math.Sqrt(12 * numbers.Count)));
            double limSup = (1 / 2.0) + (z * (1 / Math.Sqrt(12 * numbers.Count)));


            txtMLimInf.Text = limInf.ToString();
            txtMMedia.Text = media.ToString();
            txtMLimSup.Text = limSup.ToString();

            if (media >= limInf && media <= limSup)
            {
                txtMMedia.BackColor = Color.Green;
            }
            else {
                txtMMedia.BackColor = Color.Salmon;
            }
            
        }

        void pruebaDeVarianza(int confianza)
        {
            double media = numbers.Average(n => n.Valor);
            double varianza = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                varianza += (numbers[i].Valor - media) * (numbers[i].Valor - media);
            }
            varianza /= (numbers.Count - 1);


            double nivelConfianza = confianza / 100.0;
            double alpha = 1 - nivelConfianza;

            double chiCuadradoInferior = ChiSquared.InvCDF(numbers.Count - 1, alpha / 2) / (12 * (numbers.Count - 1));
            double chiCuadradoSuperior = ChiSquared.InvCDF(numbers.Count - 1, 1 - alpha / 2) / (12 * (numbers.Count - 1));

            txtVLimInf.Text = chiCuadradoInferior.ToString();
            txtVVarianza.Text = varianza.ToString();
            txtVLimSup.Text = chiCuadradoSuperior.ToString();

            if (varianza >= chiCuadradoInferior&& varianza <= chiCuadradoSuperior)
            {
                txtVVarianza.BackColor = Color.Green;
            }
            else
            {
                txtVVarianza.BackColor = Color.Salmon;
            }

        }
        void pruebaDeUniformidad(int confianza) {

            pUniformidad.Clear();

            int numPruebas = numbers.Count;
            int numIntervalos = (int)Math.Ceiling(Math.Sqrt(numPruebas));

            double limInferior = 0;
            for (int i = 0; i < numIntervalos; i++) {

                uniformidad u = new uniformidad();

                u.interInferior = limInferior;

                limInferior += (1.0 / numIntervalos);
                limInferior = Math.Round(limInferior, 2);
                u.interSuperior = limInferior;

                u.valueE = numPruebas / numIntervalos;

                pUniformidad.Add(u);
            }

            for (int i = 0; i < numPruebas; i++) {
                int intervalo = (int)(numbers[i].Valor * numIntervalos);

                pUniformidad[intervalo].valueO++;
            }

            double sum = 0;
            for (int i = 0; i < numIntervalos; i++) {
                double valueO = pUniformidad[i].valueO;
                double valueE = pUniformidad[i].valueE;
                pUniformidad[i].value = ((valueE - valueO) * (valueE - valueO)) / valueE;
                sum += pUniformidad[i].value;
            }

            double nivelConfianza = confianza / 100.0;
            double alpha = 1 - nivelConfianza;

            double valorTabla = ChiSquared.InvCDF(numIntervalos-1, 1 - alpha / 2);
            valorTabla  = Math.Round(valorTabla,2);

            txtChiCuad.Text = sum.ToString();
            txtValorTab.Text = valorTabla.ToString();

            dgvUniformidad.DataSource = null;
            dgvUniformidad.DataSource = pUniformidad;
            dgvUniformidad.Columns["valueO"].HeaderText = "O";
            dgvUniformidad.Columns["valueE"].HeaderText = "E";
            dgvUniformidad.Columns["value"].HeaderText = "((E-O)^2)/E";


            if (valorTabla > sum )
            {
                txtDecPU.BackColor = Color.Green;
            }
            else
            {
                txtDecPU.BackColor = Color.Salmon;
            }


        }

        private void btnUniformidad_Click(object sender, EventArgs e)
        {
            if (numbers.Count <= 0) {
                MessageBox.Show("Primero debe generar numeros pseudoaleatorios");
                return;
            }
            if (!(int.TryParse(txtConfianza.Text, out int confianza) && confianza > 0 && confianza<= 100))
            {
                MessageBox.Show("La confianza deber ser un valor entero entre 1 y 100");
                return;
            }
            pruebaDeUniformidad(confianza);
        }

        private void btnMedias_Click(object sender, EventArgs e)
        {
            if (numbers.Count <= 0)
            {
                MessageBox.Show("Primero debe generar numeros pseudoaleatorios");
                return;
            }

            if(!(int.TryParse(txtConfianza.Text, out int confianza) && confianza > 0 && confianza <= 100))
            {
                MessageBox.Show("La confianza deber ser un valor entero entre 1 y 100");
                return;
            }
            pruebaDeMedias(confianza);
            
        }

        private void btnVarianza_Click(object sender, EventArgs e)
        {
            if (numbers.Count <= 0)
            {
                MessageBox.Show("Primero debe generar numeros pseudoaleatorios");
                return;
            }

            if (!(int.TryParse(txtConfianza.Text, out int confianza) && confianza > 0 && confianza <= 100))
            {
                MessageBox.Show("La confianza deber ser un valor entero entre 1 y 100");
                return;
            }
            pruebaDeVarianza(confianza);
        }
    }
    public class Numero{
        public double Valor { get; set; }
    }
    
    public class uniformidad
    {
        public double interInferior { get; set; }
        public double interSuperior { get; set; }
        public int valueO { get; set; }
        public double valueE { get; set; }
        public double value { get; set; }
    }

}
