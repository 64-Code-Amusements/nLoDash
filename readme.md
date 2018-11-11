# Floatingman.nLoDash

Two things, build some C# functional tools and setting up a build pipeline on the _Azure DevOps_ site.

## The Code

For the code itself, I've leveraged [la-yumba](https://github.com/la-yumba/functional-csharp-code) and [LoDash](https://lodash.com/) for inspiration.

## The Infrastructure

This is standing mostly on out of the box _Azure DevOps_ documentation.

## The Dev Process

Doing this entirely within _VSCode_ is a learning experience too:

```ps
# creates the `sln` file that _Azure DevOps_ wants to build
dotnet new sln --name nLoDash

# creates the folder and `csproj` file
dotnet new classlib --name nLoDash

# builds the `sln`
dotnet build

# adds the project to the `sln`
dotnet sln '.\nLoDash.sln' add '.\nLoDash\nLodash.csproj'

#  creates the xunit test project
dotnet new xunit --name nloDash.Test

# adds the project to the `sln`
dotnet sln '.\nLoDash.sln' add '.\nLoDash.Test\nLodash.Test.csproj'

# add fluentassertions to the xunit tests
dotnet add .\nLoDash.Test\nLoDash.Test.csproj package FluentAssertions --version 5.5.0

# add the nLoDash project to the test project to test
dotnet add .\nloDash.Test\nloDash.Test.csproj reference .\nLoDash\nLoDash.csproj

# run the tests
dotnet test .\nLoDash.Test\nLoDash.Test.csproj
```