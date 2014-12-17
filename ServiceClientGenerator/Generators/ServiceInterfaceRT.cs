﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ServiceInterfaceRT : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Threading;\r\nusing System.Threading.Tasks;\r\nusing " +
                    "System.Collections.Generic;\r\n\r\nusing ");
            
            #line 16 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\n\r\nnamespace ");
            
            #line 18 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 20 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
    this.FormatServiceInterfaceDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("\tpublic partial interface IAmazon");
            
            #line 21 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(" : IDisposable\r\n\t{\r\n\t\t");
            
            #line 23 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"

    // Generates definitions for each operation in the service model
		foreach(var operation in this.Config.ServiceModel.Operations)
		{
            if(operation.IsInternal)
                continue;
		
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t\t#region  ");
            
            #line 31 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 33 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
AddAsyncDocumentation(operation.Name);
            
            #line default
            #line hidden
            this.Write("        Task<");
            
            #line 34 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response> ");
            
            #line 34 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 34 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, CancellationToken cancellationToken = default(CancellationToken)" +
                    ");\r\n\r\n\t\t#endregion\r\n\t\t");
            
            #line 37 "C:\codebase\GitBranches\Master\sdk\src\ServiceClientGenerator\Generators\ServiceInterfaceRT.tt"

		}
		
            
            #line default
            #line hidden
            this.Write("\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}