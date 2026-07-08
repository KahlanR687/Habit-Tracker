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
        
        Assert.AreEqual(0, h.CurrentStreak);
        
        h.IncrementStreak();
        
        Assert.AreEqual(1, h.CurrentStreak);
        Assert.AreEqual(1, h.LongestStreak);
    }

    /// <summary>
    ///     <para>
    ///         This tests the IncrementStreak method when incrementing multiple times.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void IncrementStreak_TestIncrementFromOne_ReturnsTwo()
    {
        Habit h = new Habit("Habit");
        
        h.IncrementStreak();
        h.IncrementStreak();
        
        Assert.AreEqual(2, h.CurrentStreak);
        Assert.AreEqual(2, h.LongestStreak);
    }

    /// <summary>
    ///     <para>
    ///         This tests the IncrementStreak method when it is called a thousand times
    ///     </para>
    /// </summary>
    [TestMethod]
    public void IncrementStreak_TestIncrementManyTimes_ReturnsOneThousand()
    {
        Habit h = new Habit("Habit");

        for (int i = 0; i < 1000; i++)
        {
            h.IncrementStreak();
        }
        
        Assert.AreEqual(1000, h.CurrentStreak);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the IncrementStreak method when it is called ten thousand times.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void IncrementStreak_TestIncrementManyManyTimes_ReturnsTenThousand()
    {
        Habit h = new Habit("Habit");

        for (int i = 0; i < 10000; i++)
        {
            h.IncrementStreak();
        }
        
        Assert.AreEqual(10000, h.CurrentStreak);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the ResetStreak method when the current streak is already zero.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void ResetStreak_TestResetFromZero_ReturnsZero()
    {
        Habit h = new Habit("Habit");
        
        h.ResetStreak();
        Assert.AreEqual(0, h.CurrentStreak);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the ResetStreak method when the current streak is one.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void ResetStreak_TestResetFromOne_ReturnsZero()
    {
        Habit h = new Habit("Habit");
        h.IncrementStreak();
        
        Assert.AreEqual(1, h.CurrentStreak);
        
        h.ResetStreak();
        Assert.AreEqual(0, h.CurrentStreak);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the ResetStreak method when the current streak is one thousand.
    ///         In addition, the longest streak is also verified to ensure the method doesn't reset it.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void ResetStreak_TestResetSameLongestStreak_ReturnsZero()
    {
        Habit h = new Habit("Habit");

        for (int i = 0; i < 1000; i++)
        {
            h.IncrementStreak();
        }
        
        h.ResetStreak();
        Assert.AreEqual(0, h.CurrentStreak);
        Assert.AreEqual(1000, h.LongestStreak);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the ResetStreak method when it is called multiple times, ensuring that the longest streak is not affected.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void ResetStreak_TestSameLongestStreakAfterMultipleResets_ReturnsZero()
    {
        Habit h = new Habit("Habit");
        
        h.IncrementStreak();
        h.ResetStreak();
        
        Assert.AreEqual(0, h.CurrentStreak);
        Assert.AreEqual(1, h.LongestStreak);

        for (int i = 0; i < 10; i++)
        {
            h.IncrementStreak();
        }
        
        h.ResetStreak();
        
        Assert.AreEqual(0, h.CurrentStreak);
        Assert.AreEqual(10, h.LongestStreak);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the GetName method, ensuring that the names are the same.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void GetName_TestGetSimpleName_ReturnsSimpleName()
    {
        Habit h = new Habit("Habit");
        
        Assert.AreEqual("Habit", h.Name);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the GetName method when a very long name is inputted.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void GetName_TestGetLongName_ReturnsLongName()
    {
        Habit h = new Habit("Habitsareverygoodforhumanbeingsbecauseithelpsgetthemintoaroutinetodotheirwork");
        Assert.AreEqual("Habitsareverygoodforhumanbeingsbecauseithelpsgetthemintoaroutinetodotheirwork", h.Name);
    }

    /// <summary>
    ///     <para>
    ///         This method tests the MarkComplete method on a new Habit object.
    ///     </para>
    /// </summary>
    [TestMethod]
    public void MarkComplete_TestMarkComplete_ReturnsTrue()
    {
        Habit h = new Habit("Habit");
        
        h.MarkComplete();
        
        Assert.AreEqual(1, h.CurrentStreak);
        Assert.AreEqual(1, h.LongestStreak);
        Assert.IsTrue(h.CompletedToday);
        Assert.Contains("2026-07-07", h.CompletionHistory);
        Assert.DoesNotContain("2026-07-05", h.CompletionHistory);
    }

    [TestMethod]
    public void MarkComplete_TestMarkCompleteMultipleTimes_ReturnsOneCurrentStreak()
    {
        Habit h = new Habit("Habit");
        
        h.MarkComplete();
        h.MarkComplete();
        h.MarkComplete();
        
        Assert.AreEqual(1, h.CurrentStreak);
        Assert.AreEqual(1, h.LongestStreak);
    }
}