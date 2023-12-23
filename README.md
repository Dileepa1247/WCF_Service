Hosting WCF services in ASP.NET compatibility mode
Although the WCF model is designed to behave consistently across hosting environments and transports, there are often scenarios where an application does not require this degree of flexibility. WCF’s ASP.NET compatibility mode is suitable for scenarios that do not require the ability to host outside of IIS or to communicate over protocols other than HTTP, but that use all of features of the ASP.NET Web application platform.

Unlike the default side-by-side configuration, where the WCF hosting infrastructure intercepts WCF messages and routes them out of the HTTP pipeline, WCF services running in ASP.NET Compatibility Mode participate fully in the ASP.NET HTTP request lifecycle. In compatibility mode, WCF services use the HTTP pipeline through an IHttpHandler implementation, similar to the way requests for ASPX pages and ASMX Web services are handled. As a result, WCF behaves identically to ASMX with respect to the following ASP.NET features:

HttpContext: WCF services running in ASP.NET Compatibility Mode can access Current and its associated state.

File-based authorization: WCF services running in ASP.NET compatibility mode can be secure by attaching file system access control lists (ACLs) to the service’s .svc file.

Configurable URL authorization: ASP.NET’s URL authorization rules are enforced for WCF requests when the WCF service is running in ASP.NET Compatibility Mode.

HttpModuleCollection extensibility: Because WCF services running in ASP.NET Compatibility Mode participate fully in the ASP.NET HTTP request lifecycle, any HTTP module configured in the HTTP pipeline is able to operate on WCF requests both before and after service invocation.

ASP.NET Impersonation: WCF services run using the current identity of the ASP.NET impersonated thread, which may be different than the IIS process identity if ASP.NET impersonation has been enabled for the application. If ASP.NET impersonation and WCF impersonation are both enabled for a particular service operation, the service implementation ultimately runs using the identity obtained from WCF.
