namespace HabitTests;
using Habit;

[TestClass]
public sealed class HabitTests
{
    [TestMethod]
    public void IncrementStreak_TestIncrementFromZero_ReturnsOne()
    {
        Habit h = new Habit();
        
        Assert.AreEqual(0, h.getCurrentStreak());
        
        h.incrementStreak();
        
        Assert.AreEqual(1, h.getCurrentStreak());
    }
}