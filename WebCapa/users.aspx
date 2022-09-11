<%@ Page Title="" Language="C#" MasterPageFile="~/inicio.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="WebCapa.users" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">


    <form runat="server">  

     <div class="sidebar" data-color="white" data-active-color="danger">
      <div class="logo">
        <a href="" class="simple-text logo-mini">
          <div class="logo-image-small">
            <img src="../assets/img/users.png">
          </div>
          <!-- <p>CT</p> -->
        </a>
        <a href="" class="simple-text logo-normal">
          ADMIN
          <!-- <div class="logo-image-big">
            <img src="../assets/img/logo-big.png">
          </div> -->
        </a>
      </div>
      <div class="sidebar-wrapper">
        <ul class="nav">
          <li>
            <a href="index.aspx">
              <i class="nc-icon nc-bank"></i>
              <p>Inicio</p>
            </a>
          </li>
          <li>
            <a href="choferes.aspx">
              <i class="nc-icon nc-single-02"></i>
              <p>Choferes</p>
            </a>
          </li>
          <li>
            <a href="unidades.aspx">
              <i class="nc-icon nc-bus-front-12"></i>
              <p>Unidades</p>
            </a>
          </li>
          <li class="active ">
            <a href="users.aspx">
              <i class="nc-icon nc-circle-10"></i>
              <p>Usuarios</p>
            </a>
          </li>
          <li>
             <a href="turnounidades.aspx">
              <i class="nc-icon nc-calendar-60"></i>
              <p>Turnos</p>
            </a>
          </li>
        </ul>
      </div>
    </div>
    <div class="main-panel">
      <!-- Navbar -->
     <nav class="navbar navbar-expand-lg navbar-absolute fixed-top navbar-transparent">
        <div class="container-fluid">
          <div class="navbar-wrapper">
            <div class="navbar-toggle">
              <button type="button" class="navbar-toggler">
                <span class="navbar-toggler-bar bar1"></span>
                <span class="navbar-toggler-bar bar2"></span>
                <span class="navbar-toggler-bar bar3"></span>
              </button>
            </div>
           <a class="navbar-brand" href="javascript:;">Sistema Transporte</a>

               </div>
          </div>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navigation" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-bar navbar-kebab"></span>
            <span class="navbar-toggler-bar navbar-kebab"></span>
            <span class="navbar-toggler-bar navbar-kebab"></span>
          </button>
              
          
 

          <div class="collapse navbar-collapse justify-content-end" id="navigation">
           
              <div class="input-group no-border">

                          <asp:TextBox ID="TextBox1" runat="server" type="text" value="" class="form-control" placeholder="Buscar..." OnTextChanged="TextBox1_TextChanged"  ></asp:TextBox>

                
                <div class="input-group-append">
                  <div class="input-group-text">
                    <i class="nc-icon nc-zoom-split"></i>
                  </div>
                </div>
              </div>
           
                <ul class="navbar-nav">
              <li class="nav-item btn-rotate dropdown">
                <a class="nav-link dropdown-toggle" href="http://example.com" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  <i class="nc-icon nc-settings-gear-65"></i>
                  <p>
                    <span class="d-lg-none d-md-block">Some Actions</span>
                  </p>
                </a>
                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdownMenuLink">
                  <a class="dropdown-item" href="login.aspx">Salir</a>
                </div>
              </li>
             
            </ul>
          </div>
   
      </nav>
      <!-- End Navbar -->
      <div class="content">
        <div class="row">
          <div class="col-md-12">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title"> Lista de Usuarios</h4>
                
              </div>
              <div class="card-body">
                <div class="table-responsive">              
                 
                      <asp:GridView runat="server" ID ="gd_usuarios"  BackColor="White" BorderColor="#D3D59F" BorderStyle="Groove" CssClass="auto-style3" EnableTheming="True" Font-Names="MS Reference Sans Serif" Font-Size="Medium" Font-Strikeout="False" ForeColor="Black" Height="249px" HorizontalAlign="Center" Width="827px"> 
                          <HeaderStyle BackColor="#D3D59F" HorizontalAlign="Center" />
                          <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                      </asp:GridView>


                    
                    <br />
                  
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
        </div>


         </form>


</asp:Content>
