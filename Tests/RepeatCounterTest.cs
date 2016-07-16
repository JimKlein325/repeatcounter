using Xunit;
using System;
using Repeat_Counter.Objects;

namespace Repeat_Counter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_ForStringWithNoOccurrenceOfWord_0()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("Four score and seven years ago","the");
      //Assert
      Assert.Equal(0, result);
    }
    [Fact]
    public void CountRepeats_ForStringThatContainsOnlySearchWord_1()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("the","the");
      //Assert
      Assert.Equal(1, result);
    }
    [Fact]
    public void CountRepeats_ForStringContainingTwoOccurrencesOfSearchWord_2()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("the red fox chased the brown dog","the");
      //Assert
      Assert.Equal(2, result);
    }
    [Fact]
    public void CountRepeats_CountCaseInsensitiveWithMultipleInstancesOfInputWord_2()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("The red fox chased the brown dog.","the");
      //Assert
      Assert.Equal(2, result);
    }
    [Fact]
    public void CountRepeats_ForInstanceOfSearchStringThatOccursWithinAnotherWord_0()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("heather","the");
      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void CountRepeats_ForStringContainingStandAloneAndInstanceOfSearchStringWithinAnotherWord_1()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("the heather.","the");
      //Assert
      Assert.Equal(1, result);
    }
    [Fact]
    public void CountRepeats_ForSearchWordFollowedByPuctuation_9()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("The red fox chased the brown dog. dog, dog- dog' dog\" dog\' dog! dog? dog) ","dog");
      //Assert
      Assert.Equal(9, result);
    }
    [Fact]
    public void CountRepeats_ForSearchWordPrecededByPuctuation_4()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      int result = repeatCounter.CountRepeats("The red fox chased the brown \"dog.\" 'dog -dog (dog.","dog");
      //Assert
      Assert.Equal(4, result);
    }
  }
}
