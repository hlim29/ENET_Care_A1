<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgentMyInformation.aspx.cs" Inherits="ENET_Care.Presentation.AgentMyInformation" %>

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
							<!--- Register --->
							<li>  
								<a tabindex="-1" href="AgentRegister.aspx">
                                    Register
								</a>
                            </li>
									
						    <!-- Send -->
                            <li>
                                <a href="AgentSend.aspx">
                                    Send
                                </a>
                            </li>

                            <!-- Receive -->
                            <li>
                                <a href="AgentReceive.aspx">
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
                                              <a href="AgentStocktaking.aspx">
                                                  Stocktaking
                                              </a>
									    </li>  
									
									    <!--- Discard --->
									    <li>
                                            <a href="AgentDiscard.aspx">
                                                Discard
                                            </a>
									    </li> 
									
									    <!--- Remove loss --->
									    <li>
                                            <a href="AgentRemoveLoss.aspx">
                                                Remove Loss
                                            </a>
									    </li> 
									
								    </ul> 
                                     
							</li>  

							<!-- My Information -->
                            <li>
                                <a href="AgentMyInformation.aspx">
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

    <form id="form2" runat="server">
    <div>
       <br />
       <br />
       <br />
        <asp:Label runat="server">
            Name:
        </asp:Label>
        <asp:textbox runat="server">

        </asp:textbox>
        <br />
        <asp:Label runat="server">
            Email:
        </asp:Label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
        <asp:Label runat="server">
            Password:
        </asp:Label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <asp:Button runat="server" text="Change" />
        <br />
        <asp:Label runat="server">
            Dist. Centre:
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
        <asp:button runat="server" Text="Cancel" />
        <asp:Button runat="server" Text="Save" />
    </div>
    </form>
</body>
</html>
