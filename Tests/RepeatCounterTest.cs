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
    public void CountOccurrences_WordThe_1()
    {
      //Arrange
      Counter counter = new Counter();
      //Act
      int result = counter.CountOccurrences("The red fox chased the brown dog.","the");
      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void CountOccurrences_WithMultipleInstancesOfInputWord_the_3()
    {
      //Arrange
      Counter counter = new Counter();
      //Act
      int result = counter.CountOccurrences("The red fox chased the brown dog through the heather.","the");
      //Assert
      Assert.Equal(3, result);
    }



    public void Dispose()
    {

    }
  }
}
