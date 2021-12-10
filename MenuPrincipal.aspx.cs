using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarritoCompra
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String[] foto = new String[4];
        String[] nom = new String[4];
        double[] preu = new double[4];
        int[] quan = new int[4];
        protected void Page_Load(object sender, EventArgs e)
        {
            int productss = 0;
            int o = 1;
            for (int i = 1; i < 6; i++) {
                String si = Server.MapPath("/productes/" + i + ".txt");
                String no = Server.MapPath("/productes/" + i + ".jpg");
                if (File.Exists(si) && File.Exists(no))
                {
                    String Contingut = File.ReadAllText(si);
                    String[] separacio = Contingut.Split(';');

                    if (separacio.Length.Equals(3))
                    {
                        if (separacio[0] != null || separacio[1] != null || separacio[2] != null)
                        {
                            if (o <= 4)
                            {
                                if (o == 1)
                                {
                                    String nao = "/productes/" + i + ".jpg";
                                    Image1.ImageUrl = nao;
                                    Label1.Text = separacio[0] + "<br>" + separacio[1] +"€"+ "<br>" + separacio[2];
                                    nom[0] = separacio[0];
                                    preu[0] = Convert.ToDouble(separacio[1]);
                                    quan[0] = Int32.Parse(DropDownList1.SelectedItem.Text);
                                    foto[0] = nao;
                                    o++;
                                    productss++;
                                } else if (o == 2)
                                {
                                    String nao = "/productes/" + i + ".jpg";
                                    Image2.ImageUrl = nao;
                                    Label2.Text = separacio[0] + "<br>" + separacio[1] +"€"+ "<br>" + separacio[2];
                                    nom[1] = separacio[0];
                                    preu[1] = Convert.ToDouble(separacio[1]);
                                    quan[1] = Int32.Parse(DropDownList2.SelectedItem.Text);
                                    foto[1] = nao;
                                    o++;
                                } else if (o == 3)
                                {
                                    String nao = "/productes/" + i + ".jpg";
                                    Image3.ImageUrl = nao;
                                    Label3.Text = separacio[0] + "<br>" + separacio[1] +"€"+ "<br>" + separacio[2];
                                    nom[2] = separacio[0];
                                    preu[2] = Convert.ToDouble(separacio[1]);
                                    quan[2] = Int32.Parse(DropDownList3.SelectedItem.Text);
                                    foto[2] = nao;
                                    o++;
                                } else if (o == 4)
                                {
                                    String nao = "/productes/" + i + ".jpg";
                                    Image4.ImageUrl = nao;
                                    Label4.Text = separacio[0] + "<br>" + separacio[1] +"€"+ "<br>" + separacio[2];
                                    nom[3] = separacio[0];
                                    preu[3] = Convert.ToDouble(separacio[1]);
                                    quan[3] = Int32.Parse(DropDownList4.SelectedItem.Text);
                                    foto[3] = nao;
                                    o++;
                                }
                            }
                        }
                    }
                }
            }
            Session["MyFoto"] = foto;
            Session["MyNom"] = nom;
            Session["MyPreu"] = preu;
            Session["MyQuan"] = quan;

            if (productss == 0)
            {
                Label5.Text = "No hi ha productes.";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            foto = (String[])Session["MyFoto"];
            nom = (String[])Session["MyNom"];
            preu = (double[])Session["MyPreu"];
            quan = (int[])Session["MyQuan"];

            if(foto != null)
            {
                String[] foto1 = { foto[0], foto[1], foto[2], foto[3] };
                String[] nom1 = { nom[0], nom[1], nom[2], nom[3] };
                double[] preu1 = { preu[0], preu[1], preu[2], preu[3] };
                int[] quan1 = { quan[0], quan[1], quan[2], quan[3] };

                Session["MyFoto1"] = foto1;
                Session["MyNom1"] = nom1;
                Session["MyPreu1"] = preu1;
                Session["MyQuan1"] = quan1;
            }
        }
    }
}