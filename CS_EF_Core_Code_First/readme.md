-- USing EF Core Code-First APproach

1. Create Model classes with Relationships
2. Create DbCOntext class with DbSet<T> properties ad the Coection String
3. Generate Migrations
	- dotnet ef migrations add [MIgration-Name] -c [Nameapce-path-for-DbCotext] 
		- e.g.
			- dotnet ef migrations add firstMigration -c CS_EF_Core_Code_First.MyAppDbContext
		- This will generate 'Migrations' folder with migration files thatd define mapping between the CLR Object/ENtity Class and Tablele 
4. Apply Migration to Generate Database and Table
	- dotnet ef database update -c [Nameapce-path-for-DbCotext] 
	- e.g.
		-  dotnet ef database update -c CS_EF_Core_Code_First.MyAppDbContext
		- This command ill geerate database with tables