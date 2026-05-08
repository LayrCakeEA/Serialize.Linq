DELETE THESE LEGACY FILES:

- ExpressionConfigurationSection.cs
- ExpressionConfigurationElement.cs
- ExpressionElementCollection.cs

REMOVE:

- System.Configuration package usage
- ConfigurationManager.OpenExeConfiguration(...)

ADD PACKAGE REFERENCES:

<PackageReference Include="Microsoft.Extensions.Configuration" Version="10.0.0" />
<PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="10.0.0" />
<PackageReference Include="Microsoft.Extensions.Configuration.Binder" Version="10.0.0" />
