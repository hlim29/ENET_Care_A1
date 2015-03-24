<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorRegister.aspx.cs" Inherits="ENET_Care.Presentation.DoctorRegister" %>

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
                                <a href="DoctorSend.aspx">
                                    Send
                                </a>
                            </li>

                            <!-- Receive -->
                            <li>
                                <a href="DoctorReceive.aspx">
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
                                              <a href="DoctorStocktaking.aspx">
                                                  Stocktaking
                                              </a>
									    </li>  
									
									    <!--- Discard --->
									    <li>
                                            <a href="DoctorDiscard.aspx">
                                                Discard
                                            </a>
									    </li> 
									
									    <!--- Remove loss --->
									    <li>
                                            <a href="DoctorRemoveLoss.aspx">
                                                Remove Loss
                                            </a>
									    </li> 
									
								    </ul> 
                                     
							</li>  

							<!-- My Information -->
                            <li>
                                <a href="DoctorMyInformation.aspx">
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
           Package Type:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
        
       <asp:label runat="server">
           Expire Date:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <asp:Calendar runat="server">
        </asp:Calendar>
        <br />
       <asp:Button runat="server" text="Register" />
    </div>
    </form>
</body>
</html>
