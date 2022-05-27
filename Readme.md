# Methods
- One-Way Methods
	- These methods may or many not accept values, but definitely does not return any value
	- USe the 'void' keyword that represents method is One-way
- Two-Way Methods
	- These methods may or many not accept values, but definitely return value
	- They uses keyword of datatype to represent what type of dat is returned
- Rules for Preventing the APplication from any crash
	- If the Crash is happing because of Wrong Type of data, then prvent it by checking the Type of INput Data
		- use the 'typeof()' operator to verify the type of data usin the 'if' condition

# C# Programming Features
- Programming COnstructs
	- if Statement, if..else statement, if...else...if Nested if
	- Loops
		- for..loop
		- foreach..loop
		- while
		- do..while
- Data Structures
	- Array
		- A CLass that represents mutiple values of SAME-TYPE
		- Any array declared in the application, will be by-default will be an instance of Array Class. 
	- System.Collections namespace
		- ArayList, LinkedList Queue, Stack, etc.
			- Each Entry is stored as Object
	- System.Collections.Generics
		- Generic Concept
- Object Oriented Programming in C#
	- class
		- Access Specifiers
			- private : Set the access of declaration (Data Member, Method, Property) within the class, 
			- public: Set the access of declaration 'Everywhere by any consumer of the class', 
			- protected: Set the access of declaration within class an its derive class, 
			- internal: Set the access of declaration withing a containing namespace and assembly,
			- protected internal: Set the access of declaration in same assemly in derived class also in derived class of dirrerent assemly
			- 
		- Modifiers
			- abstract: When used for class, it is abstract class and it cannot be instntiated, i.e. cannot be repesented as a 'REACL-WORLD' object,
				- WHen used for the method, then the method does not have any logic (Implementation)
				- The Abstract class 'MUST BE INHERITED'
				- The Abstract methos 'MUST BE OVERIIDEN'
					- Write your logic
			- virtual: APplied only on the method, this has an implementation (logic), but this can be changed by the derived class , 
			- static : a class of which instance cannot be created, this is also knws as a 'Shared' class. The static class can have only static method,
			- sealed: Class which cannot be inherited sealed methods cannot be overriden ,
			- override: COmpletely Change implementation of virtual method of te base class or use its as it is in derived class, 
			- new: Shadowing
		- methods
		- properties
	- The class MUST ne instantiated using 'new' keyword,otherwise the runtime will not be able to assign memory to it and if we use the class reference w/o instance the 'Object Referenece is Not to Set an INstance of an object' error will occure at runtime
		- ClaMath math = new ClaMath();
		- FAct: WHen the class is instantiated, its 'DEfault COnstrutor' is called
		- NOTE: A class can have multiple COnstructors with various parameters aka parameterized constructors
	- Logcal Operator
		- || or
		- && AND
		- ! NOT

# Using OOPs For Appliaction Development
- CReate Two-Types of Classes
	- A Class that will only contains properties to accept nd store data	
		- Model Class /  Entity Classes (Generally Name USed) / Value Object / Data Transmision Object (DTO)
		- These propertie with be public properties with get/set
			- set to to accept the data and pass it to the private member
			- get is to read data from provate member and return it
	- A Class that will contain methods to proform Crete / Read / Update /Delete operations using the ENtity Class.
		- Every method in this class with eithr accepts Entity class or return entity class or Both 
	- A class can have 'only one' base class 
	- If the class is DTO / ENtity class, then it can have 'AUTO-IMPLEMENTED' properties (C# 3.0)
- Create an Abstract class that contains Blue-Print for the Implementation
	- This class can contains FOllowing methods
		- virtual methods with default implemenattion, this can be as it is used by derived class or can be changed by derived class by overriding virtual method
		- abstract method, this is a method declaration w/o any implementation, this MUST be implemented by derived class by overriding it, if derived class is not overriding abstract method, then the derived class MUST be made as abstract class otherwise it will not compiled.
- CReate a Sealed class for the logic which cannot be oveiien by deriving the class
	- TaxRules
- Create a 'static' class for having 'one-logic' global to entire application
	- Static class need not tob instantiated
	- It can have only static methods
	- Methods from static class  are directly accessed using name of the class
	
# Delegate and Events
1. System.Delegate is an object used to eclare delegate
	- The 'delegate' as a Keyword used to declara delegate in codes
	- Delegate MUST be declared at 'Namesace level', so that it is available for all clases inside that namespace
2. Event is a speial delegate that is raised when a condition Occurs
	- EVent is always declared inside the class
	- Event is declared using delegate
	- The delegate which is used to declare an event MUST have return type as void

# Generics
1. TypeSafe Data Structre
2. They have collections
	- All these are IEnumerable<T>, ICollection<T>
	- Dictionary<TKey,TValue>
		- Most used collection to store data as KeyValue Pair
# LANGUAGE INTEGRATED QUEIRY (Linq)

https://1drv.ms/u/s!AuCjRTzCu2zzlDAel1Wu8ZazuL9h?e=TKnYwg

	- Namespace
		- using System.Linq;
	- Extension Methods
	- Lambda Expression
	- Autom-Implemented Properties
	- Anonymous Types
		- AN Instance w/o class
		- e.g. var obj  =  new {Property1=1, Property2="DD"};
			- Encapsulations of values at runtime


- Needs of LINQ
	- A Collection
	- Operator Expression Methods
		- Select(Predicate)
		- Where(Predicate)
		- OrderBy(Predicate)
		- OrderByDescending(Predicate)
		- GroupBy(Predicate)
		- Join(Predicate)
		- ... and many more
		- Most of the "Operator Expression Methods" returns "IEnumerable<T>"
	- Predicate
		- AN expression (aka Lambda Expression) that will be executed on the Collection
	- Format Conversion Methods
		- These are the extesnion methods used for format conversion of the result from Query
			- ToList()
			- ToArray()
			- ... an many more
	- Result Selection Operator Methods
		- First(), FirstOrDefault()
		- Last(), LastOrDefault()
		- Take()
		- Skip()
		- Sum()
		- Min()
		- Max()
		- ... and many more
- Two Types of LINQ
	- Declarative
		- USes Extension Methods with Lambda Expression for Query
	- Imperative
		- USes SQL like Syntax
			- from, select, where, orderby, group, by, desc, etc. 

# EntityFrameworkCore (EF Core)

1. Packages
	- Microsoft.EntityFrameworkCore
		- Base Package for EF Core
		- DB Connetion
		- Table Mapping
	- Microsoft.EntityFrameworkCore.SqlServer
		- SQL Server DB Access and Connectivity
	- Microsoft.EntityFrameworkCore.Relational
		- Access to RDBMS or Ralation DB
	- Microsoft.EntityFrameworkCore.Design
		- DB Design using Code-First Approah with Fluent APIs
	- Microsoft.EntityFrameworkCore.Tools
		- Tools for
			- Generation Conceptual Model (Entity Classes) from Database, Database	
			- Generate Database from Model Design, Code-First
2. COmmand Line to Work with .NET Core
	- Add Package for the Project
		- dotnet add package [PACKAGE-NAME] -v [VERSION-NO]
		- e.g.
			- dotnet add package Microsoft.EntityFrameworkCore -v 5.0 
3. Using Database-First Approach
	- You MUST have database and Tables
- Create Database Company	
- USE [Company]
GO

/****** Object:  Table [dbo].[Department]    Script Date: 5/27/2022 11:45:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Department](
	[DeptNo] [int] NOT NULL,
	[DeptName] [varchar](100) NOT NULL,
	[Capacity] [int] NOT NULL,
	[Location] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Company]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 5/27/2022 11:45:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EmpNo] [int] NOT NULL,
	[EmpName] [varchar](200) NOT NULL,
	[Designation] [varchar](200) NOT NULL,
	[Salary] [int] NOT NULL,
	[DeptNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DeptNo])
REFERENCES [dbo].[Department] ([DeptNo])
GO


- Generate Logical Model from Database
 - The EF Core Comand Line MUST be installed on the Maching
	- dotnet tool install --global dotnet-ef
- dotnet ef dbcontext scaffold "[CONNECTION-STRING-TO-DATABASE]" [RELATIONAL-DB-PROVIDER-PACKAGE] -o [FOLDER-WHERE-MODEL-CLASSES-WILL-BE-CREATED]

- e.g.
	- dotnet ef dbcontext scaffold "Data Source=.;INitial Catalog=Company;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models
		- Data Source: The Name/IP Address of the MAchne with Database is installed
			- The '.' means local mahcine, Oteh values (local) 
		- Initial Catalog: The NAme of the database
		- Integrated Security: USed only if you are using WIndows USer as database Admin/Owner
		- If not Admin then connection string will be
			- "Data Source=.;INitial Catalog=Company;User Id=[NAME];Password=[Password]"
		- Sometimes the Server has NAmed instances, in that case "Data Source" will be
			- Data Source=[SERVER-NAME|IP|.]\[NSTANCE-NAME]
				- e.g.
					- Data Source=.\SQLExpress
		- Other Type of Connection String
			- Server=[SERVER-NAME|IP ADDRESS|.];Database=[DATABASE-NAME];Integrated Security=SSPI
			- Server=[SERVER-NAME|IP ADDRESS|.];Database=[DATABASE-NAME];User Id=[NAME];Password=[Password]
	- FOr Further details please read
		- https://www.connectionstrings.com/microsoft-data-sqlclient/

	- To USe ORM the Table MUST have Primary Key 

- Classes and APIs
	- DbContext
		- BAse class for EF COre
		- Manages DB Connection
		- Manages CLass Mapping with Database Table using DbSet<T> class
			- USes Fluent-API to Map Class and its proeprties with Database Tables and its columns
		- Manages DB Trasactions using
			- SaveChanges() and SaveChangesAsync()
	- DbSet<T>
		- Map the class of name T with Database Table of name T
		- A Cursor that contains Records of the mapped table
	- Pseduo COde
		- COnsider 'ctx' is an instance of DbContext, Entity class is Employee and DbSet<Employee> is Emps
		- List all Records of Employee table
			- var res = ctx.Emps.ToList(); -- This needs Microsoft.EntityFrameworkCore used in code
			- var res = await ctx.Emps.ToListAsync(); -- This needs Microsoft.EntityFrameworkCore used in code
		- To Read/Search record based on Primary Key
			- var rec = ctx.Emps.Find(PK Value);
			- var rec = await ctx.Emps.FindAsync(PK Value);
		- To Add New Records
			- Create an instance of Entity class
				- var emp = new Employee();
			- Set its Property Values
				- e.g.
					- emp.EmpNo=90; emp.EmpName="AA";
			- Call Add() / AddAsync() method of DbSet and pass employee instance
				- var res = ctx.Emps.Add(emp); var res = await ctx.EMps.AddAsync(emp);
			- Complete Transactions
				- ctx.SaveChanges() / await ctx.SaveChangesAsync()
		- TO Add Multiple Records
			- CReate an Array/List of Entity class
			- Set its values
			- Call AddRange
				- ctx.Emps.AddRange(Array / List);
				- await ctx.Emps.AddRangeAsync(Array / List);
			- Complete Transaction	
		- To Update REcord
			- First Search Record based on P.K.
			- Chagne its property values
			- Complete Transaction
		- To Delete Record
			- FIrst Search Record based on P.K.
			- Call Remove (This is always Synchronous)
				- ctx.Emps.Remove(SEARCHED-RECORD)
			- Complete Transaction
				

			