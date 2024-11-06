using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnalyzerAssignment
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                selectedAmountLiteral.Text =  selectedAmountLiteral.Text+btn.Text;
                if (selectedAmountLiteral.Text != "")
                {
                    BtnSubmit.Enabled = true;
                }
                else
                {
                    BtnSubmit.Enabled=false;
                }
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
            
        }

        protected void backButtonLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAmountLiteral.Text = "";
                showMessage("");
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder html = new StringBuilder();
                int[] notes = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                int restAmount = 0;
                if (selectedAmountLiteral.Text != "")
                {
                    restAmount = int.Parse(selectedAmountLiteral.Text);
                    if (restAmount > 0) {
                        html.AppendLine("<div class=\"container  text-center\">");
                        foreach (int note in notes) 
                        {
                            Tuple<int, int> res = SplitAmount(restAmount, note);
                            if(res.Item2>0)
                            {
                                html.AppendLine("<div class=\"row border\">");
                                if (note>=200)//note
                                {
                                    html.AppendLine("<div class=\"col-sm-3 col-md-3 col-lg-3 text-left\"><i class=\"fa fa-money fa-3x\" style=\"color:white;\"></i></div><div class=\"col-sm-9 col-md-9 col-lg-9 text-left\"><span class=\"txt40\">" + res.Item2 + " X " + note + "</span></div>");
                                }
                                else//coin
                                {
                                    html.AppendLine("<div class=\"col-sm-3 col-md-3 col-lg-3 text-left\"><i class=\"fa fa-circle fa-3x\" style=\"color:white;\"></i></div><div class=\"col-sm-9 col-md-9 col-lg-9 text-left\"><span class=\"txt40\">" + res.Item2 + " X " + note + "</span></div>");
                                }
                                html.AppendLine("</div>");
                            }
                            
                            //selectedAmountLiteral.Text +="<br>" + res.Item1 + ", " + res.Item2;
                            restAmount= res.Item1;
                            //html.AppendLine("<td>(" + restAmount + ") " + note + "</td></tr>");
                            //html.AppendLine("</tr>");
                        }
                        html.AppendLine("</div>");
                        widtDrawalLiteral.Text= html.ToString();
                        withDrawalAmountLiteral.Text= selectedAmountLiteral.Text;
                        MultiView1.ActiveViewIndex = 2;
                    }
                    else
                    {
                        showMessage("Please select amount larger than zero");
                    }
                    //widtDrawalLiteral.Text ="Tilbage" + selectedAmountLiteral.Text;
                }
                
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
        }
        private static Tuple<int,int> SplitAmount(int amount,int noteOrCoins)
        {
            
            int count = amount / noteOrCoins;
            int restAmount = amount - (count*noteOrCoins) ;
            return Tuple.Create(restAmount, count);
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                MultiView1.ActiveViewIndex = 1;
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
        }
        public void showMessage(string mes)
        {
            Literal info = (Literal)Master.FindControl("messageLiteral");
            info.Text = mes;
        }

        protected void previusLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                MultiView1.ActiveViewIndex = 1;
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
        }
    }
    
}