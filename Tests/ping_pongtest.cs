using Xunit;
using System;
using System.Collections.Generic;
using PingPongList;

namespace PingPong
{
  public class PingPongTest : IDisposable
  {
    [Fact]
    public void Test1ReturnAllNumbersWithPingsAndPongs()
    {
      //Arrange
      int number = 15;
      PingPongGenerator newGeneration = new PingPongGenerator(number);
      List<string> userList = PingPongGenerator.GetAll();

      //Act
      List<string> testList = new List<string>{"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong" };

      //Assert
      Assert.Equal(testList, userList);
    }

    public void Dispose()
    {
      PingPongGenerator.ClearAll();
    }
  }
}
