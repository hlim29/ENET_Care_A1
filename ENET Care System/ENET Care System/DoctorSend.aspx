<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorSend.aspx.cs" Inherits="ENET_Care_System.DoctorSend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <nav>
		<div class="navbar navbar-fixed-top">
			<div class="navbar-inner">
				<div class="container">
					<a class="brand" href="#"><b>ENET</b></a>
					<div class="nav-collapse">
						<ul class="nav">  
                            <!--- Distribute --->
							<li>  
								<a tabindex="-1" href="DoctorDistribute.aspx">
                                    Distribute
								</a>
                            </li>
							<!--- Register --->
							<li>  
								<a tabindex="-1" href="DoctorRegister.aspx">
                                    Register
								</a>
                            </li>
									
						    <!-- Send -->
                            <li>
                                <a href="DistributeSend.aspx">
                                    Send
                                </a>
                            </li>

                            <!-- Receive -->
                            <li>
                                <a href="DistributeReceive.aspx">
                                    Receive
                                </a>
                            </li>
							
							<!--- Stock --->
							<li class="dropdown">
								<a class="dropdown-toggle" href="#" role="button" data-toggle="dropdown">
                                    Stock
								</a>  
                                
								    <ul class="dropdown-menu">  
								
									    <!--- Stocktaking --->
									    <li>
                                              <a href="DistributeStocktaking.aspx">
                                                  Stocktaking
                                              </a>
									    </li>  
									
									    <!--- Discard --->
									    <li>
                                            <a href="DistributeDiscard.aspx">
                                                Discard
                                            </a>
									    </li> 
									
									    <!--- Remove loss --->
									    <li>
                                            <a href="DistributeRemoveLoss.aspx">
                                                Remove Loss
                                            </a>
									    </li> 
									
								    </ul> 
                                     
							</li>  

							<!-- My Information -->
                            <li>
                                <a href="DistributeMyInformation.aspx">
                                    MyInformation
                                </a>
                            </li>

							<!--- Logout --->
							<li>
                                <a href="logout.aspx">
                                    Logout
                                </a>
							</li>
						</ul> 	
					</div>
				</div>
			</div>
		</div>
	</nav>

    <form id="form1" runat="server">
    <div>
       <br />
       <br />
       <br />
        <asp:Label runat="server">
            Destination:
        </asp:Label>
        <asp:DropDownList AppendDataBoundItems="true" runat="server">
            <asp:ListItem Text="Centre 1">
                Centre 1
            </asp:ListItem>
            <asp:ListItem Text="Centre 2">
                Centre 2
            </asp:ListItem>
            <asp:ListItem Text="Centre 3">
                Centre 3
            </asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label runat="server">
            Bar Code:
        </asp:Label>
        <asp:textbox runat="server">

        </asp:textbox>
        <br />
        <asp:Label runat="server">
            Type:
        </asp:Label>
        <asp:TextBox runat="server" Enabled="false">

        </asp:TextBox>
        <br />
        <asp:Label runat="server">
            Expire Date:
        </asp:Label>
        <asp:TextBox runat="server" Enabled="false">

        </asp:TextBox>
        <br />
        <asp:Button runat="server" Text="Send" />
    </div>
    </form>
</body>
</html>
