using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarritoCompra
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        String[] nomPr = new String[4];
        Double[] preuPr = new Double[4];
        Double[] PreuFinal1 = new Double[4];
        int[] quantitat = new int[4]; 
        String[] dropDown = new String[4];
        protected void Button1_Click(object sender, EventArgs e)
        {
            nomPr = (String[])Session["nomPr1"];
            preuPr = (Double[])Session["preuPr1"];
            quantitat = (int[])Session["quantitat1"];
            dropDown = (String[])Session["QuantCompr2"];
            PreuFinal1 = (double[])Session["PreuFinal"];

            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {
                int x1, x2, x3;
                if(int.TryParse(TextBox3.Text, out x3))
                {
                    if(TextBox3.Text.Length == 9) 
                    {
                        if (!(int.TryParse(TextBox1.Text, out x1) && int.TryParse(TextBox2.Text, out x2)))
                        {
                            double sumaTot = PreuFinal1[0] + PreuFinal1[1] + PreuFinal1[2] + PreuFinal1[3];
                            String NomPers = TextBox1.Text;
                            StreamWriter sw = new StreamWriter(Server.MapPath(".") + "/compres/" + NomPers + ".txt");
                            sw.WriteLine("       gracias por su compra.");
                            sw.WriteLine("------------------------------------");
                            sw.WriteLine("            TuConsola.");
                            sw.WriteLine("------------------------------------");
                            sw.WriteLine("");
                            for (int i = 0; i < 4; i++)
                            {
                                if (nomPr[i] != null && preuPr[i] != 0 && quantitat[i] != 0)
                                {
                                    if (dropDown[i] == "0")
                                    {
                                        sw.WriteLine("Producte: " + nomPr[i] + "  Quantitat: " + quantitat[i] + "  Preu: " + preuPr[i]);
                                        sw.WriteLine("");
                                        sw.WriteLine("Preu Final: " + PreuFinal1[i]);
                                        sw.WriteLine("");
                                        sw.WriteLine("");
                                    }
                                    else
                                    {
                                        sw.WriteLine("Producte: " + nomPr[i] + "  Quantitat: " + dropDown[i] + "  Preu: " + preuPr[i]);
                                        sw.WriteLine("");
                                        sw.WriteLine("Preu Final: " + PreuFinal1[i]);
                                        sw.WriteLine("");
                                        sw.WriteLine("");
                                    }
                                }
                            }
                            sw.WriteLine("Total:   " + sumaTot);
                            sw.Close();
                        }
                        else
                        {
                            Label1.Text = "Informació Incorrecta";
                        }
                    }
                    else
                    {
                        Label1.Text = "Informació Incorrecta";
                    }
                }
            }
        }
    }
}