using Xunit;
using System;
using System.Collections.Generic;
using PingPongList;

namespace PingPong
{
  public class PingPongTest : IDisposable
  {
    [Fact]
    public void Test1ReturnAllNumbers()
    {
      //Arrange
      int number = 5;
      PingPongGenerator newGeneration = new PingPongGenerator(number);
      List<string> userList = PingPongGenerator.GetAll();

      //Act
      List<string> testList = new List<string>{"1", "2", "3", "4", "5" };

      //Assert
      Assert.Equal(testList, userList);
    }
    public void Dispose()
    {
      PingPongGenerator.ClearAll();
    }
  }
}
