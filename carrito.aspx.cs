using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarritoCompra
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //Arrays con todos los productos
        int o = 1;
        String[] nom1 = new String[4];
        String[] foto1 = new String[4];
        int[] quan1 = new int[4];
        double[] preu1 = new double[4];
        //Arrays con productos comprados
        String[] nomPr = new String[4];
        Double[] preuPr = new Double[4];
        int[] quantitat = new int[4];
        protected void Page_Load(object sender, EventArgs e)
        {
            nom1 = (String[])Session["MyNom1"];
            foto1 = (String[])Session["MyFoto1"];
            quan1 = (int[])Session["MyQuan1"];
            preu1 = (double[])Session["MyPreu1"];
            if (quan1 != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (quan1[i] != 0)
                    {
                        if (o == 1)
                        {
                            Image1.ImageUrl = foto1[i];
                            Label1.Text = nom1[i] + "<br>" + preu1[i] + "€" + "<br>" + quan1[i];
                            //String q = quan1[i].ToString();
                            //DropList1.Text = q;
                            nomPr[0] = nom1[i];
                            preuPr[0] = preu1[i];
                            quantitat[0] = quan1[i];
                            o++;
                        }
                        else if (o == 2)
                        {
                            Image2.ImageUrl = foto1[i];
                            Label2.Text = nom1[i] + "<br>" + preu1[i] + "€" + "<br>" + quan1[i];
                            //String a = quan1[i].ToString();
                            //DropList2.Text = a;
                            nomPr[1] = nom1[i];
                            preuPr[1] = preu1[i];
                            quantitat[1] = quan1[i];
                            o++;
                        }
                        else if (o == 3)
                        {
                            Image3.ImageUrl = foto1[i];
                            Label3.Text = nom1[i] + "<br>" + preu1[i] + "€" + "<br>" + quan1[i]; 
                            //String s = quan1[i].ToString();
                            //DropList3.Text = s;
                            nomPr[2] = nom1[i];
                            preuPr[2] = preu1[i];
                            quantitat[2] = quan1[i];
                            o++;
                        }
                        else if (o == 4)
                        {
                            Image4.ImageUrl = foto1[i];
                            Label4.Text = nom1[i] + "<br>" + preu1[i] + "€" + "<br>" + quan1[i];
                            //String y = quan1[i].ToString();
                            //DropList4.Text = y;
                            nomPr[3] = nom1[i];
                            preuPr[3] = preu1[i];
                            quantitat[3] = quan1[i];
                            o++;
                        }
                    }
                }
                //quantitat de productes comprats
                this.Session["NumCompr"] = o;
                this.Session["QuantCompr"] = quan1;
                //Arrays amb els productes comprats.
                this.Session["nomPr"] = nomPr;
                this.Session["preuPr"] = preuPr;
                this.Session["Quantitat"] = quantitat;
            }
            else
            {
                Response.Redirect("MenuPrincipal.aspx");
            }
        }
        double[] preuFinal = new double[4];
        int prod = 0;
        protected void Button1_Click(object sender, EventArgs e)
        {
            String[] dropDown = new String[4];
            dropDown[0] = (DropList1.SelectedItem.Value);
            dropDown[1] = (DropList2.SelectedItem.Value);
            dropDown[2] = (DropList3.SelectedItem.Value);
            dropDown[3] = (DropList4.SelectedItem.Value);
            int numCom = (int)Session["NumCompr"];
            nomPr = (String[])Session["nomPr"];
            preuPr = (double[])Session["preuPr"];
            quantitat = (int[])Session["Quantitat"];

            for (int i = 1; i < numCom; i++)
            {
                if(i == 1)
                {
                    if(dropDown[0] == "Eliminar")
                    {
                        nomPr[0] = null;
                        preuPr[0] = 0;
                        quantitat[0] = 0;

                    }
                    else if(dropDown[0] == "0")
                    {
                        double preuFinal1 = quantitat[prod] * preu1[prod];
                        preuFinal[prod] = preuFinal1;
                    }
                    else
                    {
                        double preuFinal1 = Int32.Parse(dropDown[prod]) * preu1[prod];
                        preuFinal[prod] = preuFinal1;

                    }
                    prod++;
                }
                else if(i == 2)
                {
                    if(dropDown[1] == "Eliminar")
                    {
                        nomPr[1] = null;
                        preuPr[1] = 0;
                        quantitat[1] = 0;
                    }
                    else if(dropDown[1] == "0")
                    {
                        double preuFinal1 = quantitat[prod] * preu1[prod];
                        preuFinal[prod] = preuFinal1;
                        
                    }
                    else
                    {
                        double preuFina2 = Int32.Parse(dropDown[prod]) * preu1[prod];
                        preuFinal[prod] = preuFina2;
                    }
                    prod++;
                }
                else if (i == 3)
                {
                    if(dropDown[2] == "Eliminar")
                    {
                        nomPr[2] = null;
                        preuPr[2] = 0;
                        quantitat[2] = 0;
                    }
                    else if(dropDown[2] == "0")
                    {
                        double preuFinal1 = quantitat[prod] * preu1[prod];
                        preuFinal[prod] = preuFinal1;
                    }
                    else
                    {
                        double preuFina3 = Int32.Parse(dropDown[prod]) * preu1[prod];
                        preuFinal[prod] = preuFina3;
                    }
                    prod++;
                }
                else if (i == 4)
                {
                    if(dropDown[3] == "Eliminar")
                    {
                        nomPr[3] = null;
                        preuPr[3] = 0;
                        quantitat[3] = 0;
                    }
                    else if (dropDown[3] == "0") 
                    {
                        double preuFinal1 = quantitat[prod] * preu1[prod];
                        preuFinal[prod] = preuFinal1;
                    }
                    else
                    {
                        double preuFina4 = Int32.Parse(dropDown[prod]) * preu1[prod];
                        preuFinal[prod] = preuFina4;
                    }
                    prod++;
                }
            }
            Session["nomPr1"] = nomPr;
            Session["preuPr1"] = preuPr;
            Session["quantitat1"] = quantitat;
            Session["QuantCompr2"] = dropDown;
            Session["PreuFinal"] = preuFinal;

            Response.Redirect("FinalitzarComp.aspx");
        }
    }
}