//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
using sampleadmin.Models;

#line default
#line hidden

public class _Page_Login_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Login_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
__o = model;


#line default
#line hidden

#line 3 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";


#line default
#line hidden

#line 4 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
    if (TempData["LoginMessage"] != null)
    {
        

#line default
#line hidden

#line 5 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
                              __o = TempData["LoginMessage"];


#line default
#line hidden

#line 6 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
                                                                  
    }

#line default
#line hidden

#line 7 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
    using (Html.BeginForm("Login", "Home", FormMethod.Post))
    {

        

#line default
#line hidden

#line 8 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
   __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 9 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
                                




        

#line default
#line hidden

#line 10 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.TextBoxFor(m => m.username);


#line default
#line hidden

#line 11 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.ValidationMessageFor(m => m.username, "", new { @class = "text-danger" });


#line default
#line hidden

#line 12 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.TextBoxFor(m => m.password);


#line default
#line hidden

#line 13 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.ValidationMessageFor(m => m.password, "", new { @class = "text-danger" });


#line default
#line hidden

#line 14 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
                

    }

#line default
#line hidden

#line 15 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\4\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
       __o = Html.ActionLink("Create an account", "Signup");


#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
using sampleadmin.Models;

#line default
#line hidden

public class _Page_Login_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Login_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
__o = model;


#line default
#line hidden

#line 3 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";


#line default
#line hidden

#line 4 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
    using (Html.BeginForm("Login", "Home", FormMethod.Post))
    {

        

#line default
#line hidden

#line 5 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
   __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 6 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
                                


        

#line default
#line hidden

#line 7 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.TextBoxFor(m => m.username);


#line default
#line hidden

#line 8 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.ValidationMessageFor(m => m.username, "", new { @class = "text-danger" });


#line default
#line hidden

#line 9 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.TextBoxFor(m => m.password);


#line default
#line hidden

#line 10 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
               __o = Html.ValidationMessageFor(m => m.password, "", new { @class = "text-danger" });


#line default
#line hidden

#line 11 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
                

    }

#line default
#line hidden

#line 12 "C:\Users\91949\AppData\Local\Temp\54AA6D41B9620948117932B997D9AF3634E9\3\sampleadmin\sampleadmin\Views\Home\Login.cshtml"
       __o = Html.ActionLink("Create an account", "Signup");


#line default
#line hidden
}
}
}