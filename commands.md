```bash
dotnet new webapi -n BlogoSphere
cd BlogoSphere

dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.1
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.1
dotnet add package HotChocolate.AspNetCore --version 14.0.0-p.29
dotnet add package HotChocolate.Data.EntityFramework --version 14.0.0-p.29
dotnet add package Faker.Net --version 2.0.163
```