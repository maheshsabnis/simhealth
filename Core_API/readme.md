# API Management
1. Manage the Response to the request from the client
	- Avoid sending JSON as 'camelCase' instead pass the 'Original Schema of Entitieis'
		- COnfigure JSON Property Naming STyles
```` csharp
  services.AddControllers()
                .AddJsonOptions(options => {
                    // suppress the CamelCasing fo the JSON Response
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });
````
    - USing Server-Side Validations on the Entities, so that when the POST and PUT request is accepted, the data will be validated first using 
        - ControllerBase.ModelState.IsValid property
            - ModelState is the property used to check validations applied on each public property of the Model class using System.ComponentModel.DataAnnotations namespace
                - The 'ValidationAttribute' is the base class for all vaidations
                    - RequiredAttribute
                    - RegExAttribute
                    - StringLengthAttribute
                    - ComparerAttribute
                    - EMailAttribute
                    - .... and many more
                - All these are derived from 'ValidationAttribute' class and override the 'IsValid()' method, thos return false is the value is invalid and hece 'ModelState.IsValid' will be false 
```` csharp
 public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Required(ErrorMessage ="DeptNo is Mandatory")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "DeptName is Mandatory")]
        public string DeptName { get; set; }
        [Required(ErrorMessage = "Capacity is Mandatory")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "Location is Mandatory")]
        public string Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
````

    - Use Exception Handling in Ation Methods wisely 
        - try...catch...fially block

        https://www.webnethelper.com/2022/01/aspnet-core-6-adding-custom-middleware.html


-- Data Send in QueryString,
- QueryString: The Portion of URL after the Question Mark in the form of Name=Value 
- https://localhost:5001/api/Department?DeptNo=44&DeptName=D44&Location=Pune&Capacity=4444 
-- Use the '/' (slash-seperator) for postng data to server aka Route Values
-- https://localhost:5001/api/Department/222/D222/Pune/4444

-- USing HTML Form Post, Field=Value pair
- https://localhost:5001/api/Department/?DeptNo=44&DeptName=D44&Location=Pune&Capacity=4444 

- ASP.NET Core POST/PUT Request for Acceptig Data using ModelBinders aka Paramaters Binders
    - FromBody: Data ia acceted from HTTP Body and Map with CLR Object
    - FromQuery: Data is accepted from Query String and  Map with CLR Object
    - FormRoute: Data is acceted from Route Expression and Map with CLR Object
    - FromForm: Data is accepted from HTML Form Post/Submite request and Map with CLR Object

- ROuting
    - A MEchanism of Mapping the Incomming Request to the Controller and its corresponding Action Method
    - UseRouting()
        - Middleware 
        - Maps the Request to EndPoint
            - Map with Mvc Controller
            - API Controller
    - RouteData Class
        - USed by ControllerBase class to Evaluate the ROuting and Executing the Controller with Action Method
        - The Property 'Values'
            - RouteValueDictionary Values 
                - RouteValueDictionary
                    - RouteData.Values["controller"], reads controller name from URL
                    - RouteData.Values["action"], reads action name from URL
        - ROute Template
            - [Route("api/[controller]/[action]")]
                - [HttpPost("{deptno}/{deptname}/{location}/{capacity}")]
            - URL 
                - https://[SERVER-NAME]/api/[CONTROLLER-NAME]/[ACTION-NAME]/[TEMPLATE]
                - Map with [CONTROLLER-NAME]
                - Read [ACTION-NAME] from the COntroller
                - Evaluate [TEMPLATE]
        - ROute Constraints
            - [Route("api/[controller]/[action]/[id:[DATA-TYPE]]")]
                - The Route Parameter of name 'id' for specific [DATA-TYPE] will be used  

- FIlters
    - ActionFilterAttribute, the base class
        - IAtionFilter as interface
        - IExceptionFilter, implemented by ExceptionFilterAttribute class
        - IResultFilter, implemented by ResultFIlterAttrbute 
- Microsoft.AspNetCore.Identity
    - Package for ASP.NET Core Identity Eco-System
    - Microsoft.AspNetCore.Identity.EntityFrameworkCore 
        - USed for Establishing Cnection with Database where Aplication USers, Roles, and Claims information is stored
        - IdentityUser
            - User Entity Class that represents the user information
        - IdentityRole
            - Role ENtity class that is used to store Role INformation
        - UserManager<IdentityUser>
            - USe to Manage Application Users
                - Create, update, delete, etc.
        - RoleManager<IdetityRole>
            - USed to Manage Application Role
                - Create, List, etc.
        - SingInManager<IdentityUser>
            - Used for SignIn, and Signout
- Create Users ad the Autheticate the user

