using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms.DataVisualization.Charting;

namespace CRM_Principal.Administracion.Graficacion
{
    public partial class Graficas_mostradas : Form
    {
        public String fecha;
        public Graficas_mostradas()
        {
            InitializeComponent();
            DateTime ahora = DateTime.Now;
            fecha = ahora.ToString("yyyy");
            ingresos();
            Gastos();
            Utilidad_bruta();


        }
        
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        //ingreso de meses
        public void ingresos()
        {
            Enero_ingreso();
            febrero_ingreso();
            Marzo_ingreso();
            Abril_ingreso();
            Mayo_ingreso();
            Junio_ingreso();
            Juio_ingreso();
            Agosto_ingreso();
            Septiembre_ingreso();
            Octubre_ingreso();
            Noviembre_ingreso();
            Diciembre_ingreso();
        }
        public void Enero_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%01-"+fecha+ "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox1.Text = cotizacion["Total"].ToString();
                
                conectar.Close();
            }
            
        }
        public void febrero_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%02-" + fecha + "%'AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox2.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Marzo_ingreso()
  
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%03-" + fecha + "%'AND cotizar='Ingresos'");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox3.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Abril_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%04-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox4.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Mayo_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%05-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox5.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Junio_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%06-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox6.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Juio_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%07-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox7.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Agosto_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%08-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox8.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Septiembre_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%09-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox9.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Octubre_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%10-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox10.Text = cotizacion["Total"].ToString();
                
                conectar.Close();
            }

        }
        public void Noviembre_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%11-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox11.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Diciembre_ingreso()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%12-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox12.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        //Gastos del mes
        public void Gastos()
        {
            Enero_Gastos();
            febrero_Gastos();
            Marzo_Gastos();
            Abril_Gastos();
            Mayo_Gastos();
            Junio_Gastos();
            Juio_Gastos();
            Agosto_Gastos();
            Septiembre_Gastos();
            Octubre_Gastos();
            Noviembre_Gastos();
            Diciembre_Gastos();
        }
        public void Enero_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%01-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox24.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void febrero_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%02-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox23.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Marzo_Gastos()

        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%03-" + fecha + "%' AND cotizar='Gastos'");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox22.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Abril_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%04-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox21.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Mayo_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%05-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox20.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Junio_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%06-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox19.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Juio_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%07-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox18.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Agosto_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%08-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox17.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Septiembre_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%09-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox16.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Octubre_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%10-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox15.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Noviembre_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%11-" + fecha + "%' AND cotizar='Ingresos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox14.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }
        public void Diciembre_Gastos()
        {
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("Select ISNULL(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(CAST(REPLACE(cost,',','')as float))AS MONEY), 1)),0)as Total from Cotizacion where fech_hora like '%12-" + fecha + "%' AND cotizar='Gastos';");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                textBox13.Text = cotizacion["Total"].ToString();
                conectar.Close();
            }

        }

        public void Utilidad_bruta()
        { //enero
            double LOLI1;
            double LOLI2;
            double LOLI3;
            double LOLI4;
            double LOLI5;
            double LOLI6;
            double LOLI7;
            double LOLI8;
            double LOLI9;
            double LOLI10;
            double LOLI11;
            double LOLI12;
            
            if (textBox1.Text == "0") {
                LOLI1 = 0;
            }
            else
            {
                string cadena1 = textBox1.Text;
                string resultado1 = cadena1.Replace(",", "");
                string nro1 = resultado1;
                string converido1 = nro1.Substring(0, nro1.Length - 2);
                LOLI1 = Convert.ToDouble(converido1);
                
            }
            //febrero
           
            
            if (textBox2.Text == "0")
            {
                LOLI2 = 0;
            }
            else
            {
                string cadena2 = textBox2.Text;
                string resultado2 = cadena2.Replace(",", "");
                string nro2 = resultado2;
                string converido2 = nro2.Substring(0, nro2.Length - 2);
                LOLI2 = Convert.ToDouble(converido2);

            }
            //marzo
            if (textBox3.Text == "0")
            {
                LOLI3 = 0;
            }
            else
            {
                string cadena3 = textBox3.Text;
                string resultado3 = cadena3.Replace(",", "");
                string nro3 = resultado3;
                string converido3 = nro3.Substring(0, nro3.Length - 2);
                LOLI3 = Convert.ToDouble(converido3);

            }
            //abril
            
            if (textBox4.Text == "0")
            {
                LOLI4 = 0;
            }
            else
            {
                string cadena4 = textBox4.Text;
                string resultado4 = cadena4.Replace(",", "");
                string nro4 = resultado4;
                string converido4 = nro4.Substring(0, nro4.Length - 2);
                LOLI4 = Convert.ToDouble(converido4);

            }
            //Mayo
           
            
            if (textBox5.Text == "0")
            {
                LOLI5 = 0;
            }
            else
            {
                string cadena5 = textBox5.Text;
                string resultado5 = cadena5.Replace(",", "");
                string nro5 = resultado5;
                string converido5 = nro5.Substring(0, nro5.Length - 2);
                LOLI5 = Convert.ToDouble(converido5);

            }
            //junio
            if (textBox6.Text == "0")
            {
                LOLI6 = 0;
            }
            else
            {
                string cadena6 = textBox6.Text;
                string resultado6 = cadena6.Replace(",", "");
                string nro6 = resultado6;
                string converido6 = nro6.Substring(0, nro6.Length - 2);
                LOLI6 = Convert.ToDouble(converido6);

            }
            //julio
         
           
            if (textBox7.Text == "0")
            {
                LOLI7 = 0;
            }
            else
            {
                string cadena7 = textBox7.Text;
                string resultado7 = cadena7.Replace(",", "");
                string nro7 = resultado7;
                string converido7 = nro7.Substring(0, nro7.Length - 2);
                LOLI7 = Convert.ToDouble(converido7);

            }
            //agosto
           
           
            if (textBox8.Text == "0")
            {
                LOLI8 = 0;
            }
            else
            {
                string cadena8 = textBox8.Text;
                string resultado8 = cadena8.Replace(",", "");
                string nro8 = resultado8;
                string converido8 = nro8.Substring(0, nro8.Length - 2);
                LOLI8 = Convert.ToDouble(converido8);

            }
            //septiemnre
            
            
            if (textBox9.Text == "0")
            {
                LOLI9 = 0;
            }
            else
            {
                string cadena9 = textBox9.Text;
                string resultado9 = cadena9.Replace(",", "");
                string nro9 = resultado9;
                string converido9 = nro9.Substring(0, nro9.Length - 2);
                LOLI9 = Convert.ToDouble(converido9);

            }
            //octubre
           
            
            if (textBox10.Text== "0")
            {
                LOLI10 = 0;
            }
            else
            {
                string cadena10 = textBox10.Text;
                string resultado10 = cadena10.Replace(",", "");
                string nro10 = resultado10;
                string converido10 = nro10.Substring(0, nro10.Length - 2);
                LOLI10 = Convert.ToDouble(converido10);

            }//Noviembre
           
            
            if (textBox11.Text== "0")
            {
                LOLI11 = 0;
            }
            else
            {
                string cadena11 = textBox11.Text;
                string resultado11 = cadena11.Replace(",", "");
                string nro11 = resultado11;
                string converido11 = nro11.Substring(0, nro11.Length - 2);
                LOLI11 = Convert.ToDouble(converido11);

            }
            //Diciembre
           
            
            if (textBox12.Text == "0")
            {
                LOLI12 = 0;
            }
            else
            {
                string cadena12 = textBox12.Text;
                string resultado12 = cadena12.Replace(",", "");
                string nro12 = resultado12;
                string converido12 = nro12.Substring(0, nro12.Length - 2);
                LOLI12 = Convert.ToDouble(converido12);

            }

            //graficacion
            string[] series = { "Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiebre","Octubre","Noviembre","Diciembre" };
            double[] puntos = { LOLI1,LOLI2,LOLI3,LOLI4,LOLI5,LOLI6,LOLI7,LOLI8,LOLI9,LOLI10,LOLI11,LOLI12};

            chart1.Palette = ChartColorPalette.Pastel;
            
            chart1.Titles.Add("GRAFICACION POR MES ");
            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

    }


}
