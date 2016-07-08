using Xunit;
using System;
using RepeatCounter;
//using RepeatCounter.Objects;

namespace RepeatCounter
{
  // using RepeatCounter.Objects;
  public class RepeatCounterTest : IDisposable
  {

    [Fact]
    public void Find_Within_Different_Month()
    {
      //Arrange
      Counter counter = new Counter();
      //Act
      int result = counter.CountOccurrences("The red fox chased the brown dog.","the");
      //Assert
      Assert.Equal(1, result);
    }



    public void Dispose()
    {

    }
  }
}
