<%@ Application Language="C#" %>
<%@ Import Namespace="education" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="DevExpress.Web" %>
 
<script runat="server">

  
    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
      
    } 


</script>
