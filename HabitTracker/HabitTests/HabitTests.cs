namespace HabitTests;
using Habit;

[TestClass]
public sealed class HabitTests
{
    
    /// <summary>
    ///     <para>
    ///         This tests the IncrementStreak method when incrementing from the base streak of zero.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void IncrementStreak_TestIncrementFromZero_ReturnsOne()
    {
        Habit h = new Habit("Habit");
        
        Assert.AreEqual(0, h.GetCurrentStreak());
        
        h.IncrementStreak();
        
        Assert.AreEqual(1, h.GetCurrentStreak());
        Assert.AreEqual(1, h.GetLongestStreak());
    }

    [TestMethod]
    public void IncrementStreak_TestIncrementFromOne_ReturnsTwo()
    {
        Habit h = new Habit("Habit");
        
        h.IncrementStreak();
        h.IncrementStreak();
        
        Assert.AreEqual(2, h.GetCurrentStreak());
        Assert.AreEqual(2, h.GetLongestStreak());
    }

    [TestMethod]
    public void IncrementStreak_TestIncrementManyTimes_ReturnsOneThousand()
    {
        Habit h = new Habit("Habit");

        for (int i = 0; i < 999; i++)
        {
            h.IncrementStreak();
        }
        
        Assert.AreEqual(1000, h.GetCurrentStreak());
    }

    [TestMethod]
    public void IncrementStreak_TestIncrementManyManyTimes_ReturnsTenThousand()
    {
        Habit h = new Habit("Habit");

        for (int i = 0; i < 9999; i++)
        {
            h.IncrementStreak();
        }
        
        Assert.AreEqual(10000, h.GetCurrentStreak());
    }
    
    
}