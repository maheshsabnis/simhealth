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