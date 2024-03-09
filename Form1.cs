using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;

namespace Seleccionar_Pais_12_24_2_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbo_Paises.Items.AddRange(new string[] { "Mexico", "Argentina", "Estados Unidos", "Panama", "Republica Dominicana", "Francia", "Haiti", "Canada", "Venezuela", "Ecuador" });
        }

        private void cbo_Paises_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbo_Paises.Text)

            {
                case "Mexico":
                    txt_Presidente.Text=" Andr�s Manuel L�pez Obrador";
                    txt_Continente.Text="Am�rica del Norte";
                    txt_Capital.Text="Ciudad de M�xico";
                    txt_Idioma.Text="Espa�ol";
                    txt_Poblacion.Text="130 millones de habitantes";
                    txt_Gobierno.Text="Rep�blica Federal Presidencialista";
                    txt_Moneda.Text="Peso mexicano (MXN)";
                    txt_Religion.Text="Predominantemente cat�lica";
                    break;




                case "Argentina":

                    txt_Presidente.Text="Alberto Fern�ndez";
                    txt_Continente.Text="Am�rica del Sur";
                    txt_Capital.Text="Buenos Aires";
                    txt_Idioma.Text="Espa�ol";
                    txt_Poblacion.Text=" 45 millones de Habitantes";
                    txt_Gobierno.Text="Rep�blica Federal Presidencialista";
                    txt_Moneda.Text="Peso argentino (ARS)";
                    txt_Religion.Text=" Predominantemente cat�lica";
                    break;






                case "Estados Unidos":

                    txt_Presidente.Text="Joe Biden";
                    txt_Continente.Text="Am�rica del Norte";
                    txt_Capital.Text="Washington D.C.";
                    txt_Idioma.Text="Ingl�s";
                    txt_Poblacion.Text="331 millones de habitantes";
                    txt_Gobierno.Text="Rep�blica Federal Presidencialista";
                    txt_Moneda.Text="D�lar estadounidense (USD)";
                    txt_Religion.Text="Diversidad religiosa, predominancia del cristianismo";
                    break;


                case "Panama":

                    txt_Presidente.Text="Laurentino Cortizo ";
                    txt_Continente.Text="Am�rica Central";
                    txt_Capital.Text="Ciudad de Panam�";
                    txt_Idioma.Text="Espa�ol";
                    txt_Poblacion.Text="4.5 millones de habitantes";
                    txt_Gobierno.Text="Rep�blica Presidencialista";
                    txt_Moneda.Text="Balboa paname�o (PAB) y d�lar estadounidense (USD)";
                    txt_Religion.Text="Predominantemente cat�lica";
                    break;


                case "Republica Dominicana":

                    txt_Presidente.Text="Luis Abinader";
                    txt_Continente.Text="Am�rica del Norte";
                    txt_Capital.Text="Santo Domingo";
                    txt_Idioma.Text="Espa�ol";
                    txt_Poblacion.Text="10.8 millones de habitantes";
                    txt_Gobierno.Text="Rep�blica Presidencialista";
                    txt_Moneda.Text="Peso dominicano (DOP)";
                    txt_Religion.Text="Predominantemente cat�lica";
                    break;

                case "Francia":

                    txt_Presidente.Text="Emmanuel Macron";
                    txt_Continente.Text="Europa";
                    txt_Capital.Text="Par�s";
                    txt_Idioma.Text="Franc�s";
                    txt_Poblacion.Text="67 millones de habitantes";
                    txt_Gobierno.Text="Rep�blica Semipresidencialista";
                    txt_Moneda.Text="Euro (EUR)";
                    txt_Religion.Text="Laicismo, diversidad religiosa";
                    break;


                case "Haiti":

                    txt_Presidente.Text="No tienen lo fusilan";
                    txt_Continente.Text="Am�rica Central";
                    txt_Capital.Text="Puerto Pr�ncipe";
                    txt_Idioma.Text="Franc�s y criollo haitiano";
                    txt_Poblacion.Text=" 11 millones de habitantes";
                    txt_Gobierno.Text="Rep�blica Semipresidencialista";
                    txt_Moneda.Text="Gourde haitiano (HTG)";
                    txt_Religion.Text="Predominantemente cristiana";
                    break;


                case "Canada":

                    txt_Presidente.Text=" Carlos III y Justin Trudeau";
                    txt_Continente.Text="Am�rica del Norte";
                    txt_Capital.Text="Ottawa";
                    txt_Idioma.Text="Ingl�s y franc�s";
                    txt_Poblacion.Text="38 millones de habitantes";
                    txt_Gobierno.Text="Monarqu�a Parlamentaria";
                    txt_Moneda.Text="D�lar canadiense (CAD)";
                    txt_Religion.Text="Diversidad religiosa, predominancia del cristianismo";
                    break;


                case "Venezuela":

                    txt_Presidente.Text="";
                    txt_Continente.Text="Am�rica del Sur";
                    txt_Capital.Text="Caracas";
                    txt_Idioma.Text="Espa�ol";
                    txt_Poblacion.Text="28 millones de habitantes";
                    txt_Gobierno.Text="Socialista";
                    txt_Moneda.Text="Bol�var venezolano (VES)";
                    txt_Religion.Text="Predominantemente cat�lica";
                    break;

                case "Ecuador":

                    txt_Presidente.Text="Guillermo Lasso";
                    txt_Continente.Text="Am�rica del Sur";
                    txt_Capital.Text="Quito";
                    txt_Idioma.Text="Espa�ol";
                    txt_Poblacion.Text="17.5 millones de habitantes";
                    txt_Gobierno.Text="Republica Presidencialista";
                    txt_Moneda.Text="D�lar estadounidense(USD)";
                    txt_Religion.Text="Predominantemente cat�lica";
                    break;

            }
        }




        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Presidente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Presidente.Clear();
            txt_Continente.Clear();
            txt_Capital.Clear();
            txt_Idioma.Clear();
            txt_Poblacion.Clear();
            txt_Gobierno.Clear();
            txt_Moneda.Clear();
            txt_Religion.Clear();
            cbo_Paises.Items.Clear();



        }
    }
}




