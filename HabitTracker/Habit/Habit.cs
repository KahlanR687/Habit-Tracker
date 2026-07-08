namespace Habit;

/// <summary>
///     <para>
///         This class is a model for a singular habit.
///         It represents the habit's name and measurement of completion, in addition to its streak
///         It does not contain any logic for managing multiple habits or how they are completed.
///     </para>
/// </summary>
public class Habit
{

    /// <summary>
    ///     <para>
    ///         A string Property that represents the name of the habit.
    ///     </para>
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    ///     <para>
    ///         An int Property that represents the current streak of the habit.
    ///     </para>
    /// </summary>
    public int CurrentStreak { get; private set; }
    
    /// <summary>
    ///     <para>
    ///         An int Property that represents the longest streak of the habit.
    ///     </para>
    /// </summary>
    public int LongestStreak;

    /// <summary>
    ///     <para>
    ///         A public boolean variable that represents if a habit was completed that day.
    ///     </para>
    /// </summary>
    public bool CompletedToday { get; private set; }

    /// <summary>
    ///     <para>
    ///         A public Dictionary that keeps track of the history of the habit.
    ///     </para>
    /// </summary>
    public List<string> CompletionHistory;
    
    /// <summary>
    ///     <para>
    ///         A constructor that initializes a new instance of the Habit class.
    ///     </para>
    /// </summary>
    public Habit(string name)
    {
        Name = name;
        CurrentStreak = 0;
        LongestStreak = 0;
        CompletionHistory = new List<string>();
    }

    /// <summary>
    ///     <para>
    ///         Updates the current streak of the habit by one.
    ///         If the new streak is greater than the current longest streak, the longest streak is also updated.
    ///     </para>
    /// </summary>
    public void IncrementStreak()
    {
        CurrentStreak++;

        if (CurrentStreak > LongestStreak)
        {
            LongestStreak = CurrentStreak;
        }
    }

    /// <summary>
    ///     <para>
    ///         Resets the current streak of the habit to zero.
    ///     </para>
    /// </summary>
    public void ResetStreak()
    {
        CurrentStreak = 0;
    }

    /// <summary>
    ///     <para>
    ///         Marks a habit as complete for that day. Prevents habit from being marked complete multiple times per day.
    ///     </para>
    /// </summary>
    public void MarkComplete()
    {
        if (CompletedToday)
        {
            return;
        }
        
        IncrementStreak();
        
        CompletedToday = true;
        CompletionHistory.Add(DateTime.Today.ToString("yyyy-MM-dd"));
    }
    
}