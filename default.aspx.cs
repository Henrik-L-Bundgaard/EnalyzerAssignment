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
        /// <summary>
        /// Handles button input and add the text to the field that contains the amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Button to open previus view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Button to calculate the number of different notes and coins, Opens view 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder html = new StringBuilder();//Create stringbuilder to hold HTML containing the result
                int[] notes = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };//Array to hold the different notes and coins
                int restAmount = 0;
                if (selectedAmountLiteral.Text != "")
                {
                    restAmount = int.Parse(selectedAmountLiteral.Text);
                    if (restAmount > 0) {
                        html.AppendLine("<div class=\"container  text-center\">");
                        foreach (int note in notes) 
                        {
                            Tuple<int, int> res = SplitAmount(restAmount, note);//Call function to calculate amount. Returns a Tuple of 2 ints
                            if(res.Item2>0)//If restvalue is larger than zero
                            {
                                html.AppendLine("<div class=\"row border\">");
                                if (note>=200)// if note
                                {
                                    html.AppendLine("<div class=\"col-sm-3 col-md-3 col-lg-3 text-left\"><i class=\"fa fa-money fa-3x\" style=\"color:white;\"></i></div><div class=\"col-sm-9 col-md-9 col-lg-9 text-left\"><span class=\"txt40\">" + res.Item2 + " X " + note + "</span></div>");
                                }
                                else//if coin
                                {
                                    html.AppendLine("<div class=\"col-sm-3 col-md-3 col-lg-3 text-left\"><i class=\"fa fa-circle fa-3x\" style=\"color:white;\"></i></div><div class=\"col-sm-9 col-md-9 col-lg-9 text-left\"><span class=\"txt40\">" + res.Item2 + " X " + note + "</span></div>");
                                }
                                html.AppendLine("</div>");
                            }
                            restAmount= res.Item1;
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
                    
                }
                
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
        }
        /// <summary>
        /// Function to make a calculation of how many the different notes and coins are used in the amount thats left
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="noteOrCoins"></param>
        /// <returns></returns>
        private static Tuple<int,int> SplitAmount(int amount,int noteOrCoins)
        {
            
            int count = amount / noteOrCoins;
            int restAmount = amount - (count*noteOrCoins) ;
            return Tuple.Create(restAmount, count);
        }
        /// <summary>
        /// Function to open next view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// function to show message on masterpage
        /// </summary>
        /// <param name="mes"></param>
        public void showMessage(string mes)
        {
            Literal info = (Literal)Master.FindControl("messageLiteral");
            info.Text = mes;
        }
        /// <summary>
        /// Function to open previus view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void previusLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                MultiView1.ActiveViewIndex = 1;
                selectedAmountLiteral.Text = "";
            }
            catch (Exception)
            {
                showMessage("An error occurred");
            }
        }
    }
    
}