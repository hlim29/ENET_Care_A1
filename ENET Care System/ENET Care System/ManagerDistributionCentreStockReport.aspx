<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerDistributionCentreStockReport.aspx.cs" Inherits="ENET_Care.Presentation.ManagerDistributionCentreStockReport" %>

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
								<!--- Reports --->
							<li class="dropdown">
								<a class="dropdown-toggle" href="#" role="button" data-toggle="dropdown">
                                    Reports
								</a>  
                                
								    <ul class="dropdown-menu">  
								
									    <!--- Dist. Centre Stock --->
									    <li>
                                              <a href="ManagerDistributionCentreStockReport.aspx">
                                                  Distribution Centre Stock
                                              </a>
									    </li>  
									
									    <!--- Dist. Centre Losses --->
									    <li>
                                            <a href="ManagerDistributionCentreLossesReport.aspx">
                                                Distribution Centre Losses
                                            </a>
									    </li> 
									
									    <!--- Doctor Activity --->
									    <li>
                                            <a href="ManagerDoctorActivityReport.aspx">
                                                Doctor Activity
                                            </a>
									    </li> 
									
                                        <!--- Global Stock --->
									    <li>
                                            <a href="ManagerGlobalStockReport.aspx">
                                                Global Stock
                                            </a>
									    </li> 

                                        <!--- Value in Transit --->
									    <li>
                                            <a href="ManagerValueInTrasitReport.aspx">
                                                Value tn Transit
                                            </a>
									    </li> 

								    </ul> 
                                     
							</li>  

							<!-- My Information -->
                            <li>
                                <a href="ManagerMyInformation.aspx">
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
       <asp:Label runat="server">
           Dist. Centre
       </asp:Label>
       <asp:DropDownList runat="server">
           <asp:ListItem>
               Centre 1
           </asp:ListItem>
           <asp:ListItem>
               Centre 2
           </asp:ListItem>
       </asp:DropDownList>
       <br />
       <asp:RadioButton ID="allProducts" runat="server" />
       <asp:Label runat="server">
           All Products
       </asp:Label> 
        <br />
        <asp:radiobutton ID="oneProduct" runat="server" />
        <asp:Label runat="server">
            Product Type:
        </asp:Label>
        <asp:DropDownList runat="server">
            <asp:ListItem>
                Ibuprofen
            </asp:ListItem>
            <asp:ListItem>
                Voltaren
            </asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button runat="server" Text="Generate" />
        <asp:Button runat="server" Text="Generate and Print" />
    </div>
    </form>
</body>
</html>
