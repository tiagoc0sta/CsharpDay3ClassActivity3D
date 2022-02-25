using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpDay3ClassActivity3D
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public string bmiStyle = "alert alert-primary";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Calculate_bmi(object sender, System.EventArgs e)
        {
            double index = 0;
            

            if (height.Text!="" && weight.Text != "")
            {
                double h = Convert.ToInt32(height.Text);
                double w = Convert.ToInt32(weight.Text);
                index = Math.Round(w / (h * h) * 703, 2);
            }

            if (index < 18.5)
            {
                result.Text = "underweight - BMI : " + index;
                bmiStyle = "alert alert-secondary";
            }
            else if (index < 25)
            {
                result.Text = "normal - BMI : " + index;
                bmiStyle = "alert alert-success";
            }
            else if (index < 30)
            {
                result.Text = "overweight - BMI : " + index;
                bmiStyle = "alert alert-warning";
            }
            else
            {
                result.Text = "obese - BMI : " + index;
                bmiStyle = "alert alert-danger";
            }

        }
    }
}