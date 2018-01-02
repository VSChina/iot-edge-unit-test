## Steps

1. Create a directory called `iot-edge-unit-test` to hold the solution
1. Run `dotnet new sln`
1. Run `dotnet new aziotedgemodule -n FilterModule`
1. In Program.cs, add `public` to `class Program`, also add below method
    ```csharp
    public static bool MethodToTest() {
        return true;
    }
    ```
1. Run `dotnet sln add FilterModule/FilterModule.csproj`
1. Create the `FilterModule.Tests` directory
1. Make the `FilterModule.Tests` directory the current directory, and run `dotnet new mstest`
1. Run `dotnet add reference ../FilterModule/FilterModule.csproj`
1. Run `dotnet sln add .\FilterModule.Tests\FilterModule.Tests.csproj` in the `iot-edge-unit-test` directory
1. In UnitTest1.cs, add `using FilterModule;`, also update below method
    ```csharp
    public void TestMethod1()
    {
        Assert.IsTrue(Program.MethodToTest());
    }
    ```
1. In `iot-edge-unit-test` or `FilterModule.Tests` directory, run `dotnet test` to run unit test

## Reference

https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest