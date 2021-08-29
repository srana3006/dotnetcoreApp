using Xunit;
using System;
using dotnetcoreApp.Controllers;

namespace dotnetcoreApp.Tests;

public class UnitTest1
{

    WeatherForecastController obj = new WeatherForecastController();
    [Fact]
    public void Test1()
    {
        var test1 = obj.Get(101);
        Assert.Equal("Saurabh", test1);

    
    }
}