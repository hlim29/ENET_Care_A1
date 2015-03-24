﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgentDiscard.aspx.cs" Inherits="ENET_Care_System.AgentDiscard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../bootstrap.css" rel="stylesheet" type="text/css" />
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
								<a tabindex="-1" href="register.aspx">
                                    Register
								</a>
                            </li>
									
						    <!-- Send -->
                            <li>
                                <a href="send.aspx">
                                    Send
                                </a>
                            </li>

                            <!-- Receive -->
                            <li>
                                <a href="receive.aspx">
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

    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
       <asp:Button runat="server" text="Discard" />
    </div>
    </form>
</body>
</html>