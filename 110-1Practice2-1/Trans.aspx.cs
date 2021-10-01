using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_1
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double d_Value = 66;
            double d_Value2 = 0;
            d_Value2 = 5.0 * (d_Value - 32.0) / 9.0;
            Response.Write("d_Value" + "=66F" + "=解答" + d_Value2);

        }
    }
}