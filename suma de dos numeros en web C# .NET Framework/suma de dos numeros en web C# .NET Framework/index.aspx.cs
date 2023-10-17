using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace suma_de_dos_numeros_en_web_C_.NET_Framework
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, suma;
                num1 = Convert.ToInt16(TextBox1.Text);
                num2 = Convert.ToInt16(TextBox2.Text);
                suma = num1 + num2;
                TextBox3.Text = Convert.ToString(suma);
            }
            catch (FormatException)
            {
                
                TextBox3.Text = "Falta agregar números a los campos.";
            }
        }
    }
}