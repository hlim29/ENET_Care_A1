<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerDistributionCentreReport.aspx.cs" Inherits="ENET_Care_System.ManagerDistributionCentreReport" %>

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
       <br />
       <br />
       <br />
       <asp:label runat="server">
           <b>Distribution Centre 1</b>
       </asp:label>
        <br />
        <asp:Label runat="server">
            Lost:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Discarded:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Distributed:
        </asp:Label>
        <asp:Label runat="server">
            100
        </asp:Label>
        <br />
        <asp:label runat="server">
            <b>Ratio</b>
        </asp:label>
        <asp:Label runat="server">
            <b>1.9%</b>
        </asp:Label>
       <br />
       <br />
       <asp:label runat="server">
           <b>Distribution Centre 2</b>
       </asp:label>
        <br />
        <asp:Label runat="server">
            Lost:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Discarded:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Distributed:
        </asp:Label>
        <asp:Label runat="server">
            100
        </asp:Label>
        <br />
        <asp:label runat="server">
            <b>Ratio</b>
        </asp:label>
        <asp:Label runat="server">
            <b>1.9%</b>
        </asp:Label>
        <br />
        <asp:Button runat="server" Text="Print" />
    </div>
    </form>
</body>
</html>
