<%@ Page Title="" Language="C#" MasterPageFile="~/Enalyzer.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="EnalyzerAssignment._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <%--  .btn-bd-primary {
  --bs-btn-font-weight: 600;
  --bs-btn-color: var(--bs-white);
  --bs-btn-bg: var(--bd-violet-bg);
  --bs-btn-border-color: var(--bd-violet-bg);
  --bs-btn-hover-color: var(--bs-white);
  --bs-btn-hover-bg: #{shade-color($bd-violet, 10%)};
  --bs-btn-hover-border-color: #{shade-color($bd-violet, 10%)};
  --bs-btn-focus-shadow-rgb: var(--bd-violet-rgb);
  --bs-btn-active-color: var(--bs-btn-hover-color);
  --bs-btn-active-bg: #{shade-color($bd-violet, 20%)};
  --bs-btn-active-border-color: #{shade-color($bd-violet, 20%)};
}--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="frontView" runat="server">
            <div class="row">
                <div class="col-sm-12 col-md-12 col-lg-12">
                    <p class="txt40 text-center mt-3">
                        <asp:Button ID="nextButton" runat="server" Text="Start widtdrawal" OnClick="nextButton_Click" CssClass="btn btn-info btn-rounded" />
                    </p>
                </div>
            </div>
        </asp:View>
        <asp:View ID="widtDrawalView" runat="server">
            <div class="row">
                <div class="col-sm-12 col-md-12 col-lg-12">
                    <p class="txt40 text-center">
                        Select Amount
                    </p>
                    <p class="txt40 text-center">£ <asp:Literal ID="selectedAmountLiteral" runat="server"></asp:Literal></p>
                    
                    
                    <p class="text-center">
                        <asp:Button ID="Btn1" runat="server" Text="1" CssClass="btn btn-info btn-lg btn-circle" OnClick="Btn_Click"/>
                        <asp:Button ID="Btn2" runat="server" Text="2" CssClass="btn btn-info btn-lg btn-circle" OnClick="Btn_Click"/>
                        <asp:Button ID="Btn3" runat="server" Text="3" CssClass="btn btn-info btn-lg btn-circle" OnClick="Btn_Click"/>
                    </p>
                    <p class="text-center">
                        <asp:Button ID="Btn4" runat="server" Text="4" CssClass="btn btn-info btn-lg btn-circle"  OnClick="Btn_Click"/>
                        <asp:Button ID="Btn5" runat="server" Text="5" CssClass="btn btn-info btn-lg btn-circle"  OnClick="Btn_Click"/>
                        <asp:Button ID="Btn6" runat="server" Text="6" CssClass="btn btn-info btn-lg btn-circle"  OnClick="Btn_Click"/>
                    </p>
                     <p class="text-center">
                        <asp:Button ID="Btn7" runat="server" Text="7" CssClass="btn btn-info btn-lg btn-circle"  OnClick="Btn_Click"/>
                        <asp:Button ID="Btn8" runat="server" Text="8" CssClass="btn btn-info btn-lg btn-circle"  OnClick="Btn_Click"/>
                        <asp:Button ID="Btn9" runat="server" Text="9" CssClass="btn btn-info btn-lg btn-circle"  OnClick="Btn_Click"/>
                     </p>
                    <p class="text-center">
                        
                        <asp:LinkButton ID="backButtonLinkButton" runat="server" CssClass="btn btn-info btn-rounded ml-1" OnClick="backButtonLinkButton_Click"><i class="fa fa-long-arrow-left"></i></asp:LinkButton>
                        <asp:Button ID="Btn0" runat="server" Text="0" CssClass="btn btn-info btn-lg btn-circle mr-5"  OnClick="Btn_Click"/>
                    </p>
                    <p class="text-center">
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" CssClass="btn btn-info" OnClick="BtnSubmit_Click" Enabled="false" />
                    </p>
                <br />
                 
                </div>
            </div>
        </asp:View>
        <asp:View ID="resultView" runat="server">
            <div class="row">
                <div class="col-sm-3 col-md-3 col-lg-3">
                    <button class="btn btn-info btn-lg btn-circle" ID="previusLinkButton" runat="server" onclick="previusLinkButton_Click"><i class="fa fa-long-arrow-left"></i></button>
                    
                </div>
                 <div class="col-sm-6 col-md-6 col-lg-6 text-center">
                    <p class="txt40">Withdrawal</p>
                    <p class="txt40 text-center">£ <asp:Literal ID="withDrawalAmountLiteral" runat="server"></asp:Literal></p>
                     
                    <asp:Literal ID="widtDrawalLiteral" runat="server"></asp:Literal>
                    <p class="txt40 text-center">Thank you for using<br />Enalyzer ATM</p>
                </div>
                 <div class="col-sm-3 col-md-3 col-lg-3">
                    
                     
                </div>
             </div>
             
        </asp:View>
    </asp:MultiView>
    
        
    
    
</asp:Content>
