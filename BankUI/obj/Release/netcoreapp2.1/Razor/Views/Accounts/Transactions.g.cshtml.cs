#pragma checksum "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18967976104ce1d62df6984b25f9dc177adbbf67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Transactions), @"mvc.1.0.view", @"/Views/Accounts/Transactions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Transactions.cshtml", typeof(AspNetCore.Views_Accounts_Transactions))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\_ViewImports.cshtml"
using BankUI;

#line default
#line hidden
#line 2 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\_ViewImports.cshtml"
using BankUI.Models;

#line default
#line hidden
#line 4 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\_ViewImports.cshtml"
using BankApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18967976104ce1d62df6984b25f9dc177adbbf67", @"/Views/Accounts/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b5fe776ae091166378386888a80c034eeb1924a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Transactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankApp.Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
  
    ViewData["Title"] = "Transactions";

#line default
#line hidden
            BeginContext(91, 111, true);
            WriteLiteral("\r\n<h2>Transactions</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(203, 51, false);
#line 13 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(254, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(310, 42, false);
#line 16 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(352, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 47, false);
#line 19 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(511, 51, false);
#line 22 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionType));

#line default
#line hidden
            EndContext();
            BeginContext(562, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(618, 43, false);
#line 25 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
            EndContext();
            BeginContext(661, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(756, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(805, 50, false);
#line 33 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(855, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(911, 41, false);
#line 36 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1008, 46, false);
#line 39 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1110, 50, false);
#line 42 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionType));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1216, 55, false);
#line 45 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Account.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 40, true);
            WriteLiteral("\r\n            </td>\r\n  \r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Zhanara\Kal academy\C#\Github\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
}

#line default
#line hidden
            BeginContext(1314, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankApp.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
