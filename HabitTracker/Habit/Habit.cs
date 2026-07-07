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
    ///         A private string variable that represents the name of the habit.
    ///     </para>
    /// </summary>
    private string _name;

    /// <summary>
    ///     <para>
    ///         A private int variable that represents the current streak of the habit.
    ///     </para>
    /// </summary>
    private int _currentStreak;
    
    /// <summary>
    ///     <para>
    ///         A private int variable that represents the longest streak of the habit.
    ///     </para>
    /// </summary>
    private int _longestStreak;

    /// <summary>
    ///     <para>
    ///         A private boolean variable that represents if a habit was completed that day.
    ///     </para>
    /// </summary>
    private bool _completedToday;

    /// <summary>
    ///     <para>
    ///         A private Dictionary that keeps track of the history of the habit.
    ///     </para>
    /// </summary>
    private Dictionary<DateTime, bool> _completionHistory;
    
    /// <summary>
    ///     <para>
    ///         A constructor that initializes a new instance of the Habit class.
    ///     </para>
    /// </summary>
    public Habit(string name)
    {
        _name = name;
        _currentStreak = 0;
        _longestStreak = 0;
        _completionHistory = new Dictionary<DateTime, bool>();
    }

    /// <summary>
    ///     <para>
    ///         Updates the current streak of the habit by one.
    ///         If the new streak is greater than the current longest streak, the longest streak is also updated.
    ///     </para>
    /// </summary>
    public void IncrementStreak()
    {
        _currentStreak++;

        if (_currentStreak > _longestStreak)
        {
            _longestStreak = _currentStreak;
        }
    }

    /// <summary>
    ///     <para>
    ///         Resets the current streak of the habit to zero.
    ///     </para>
    /// </summary>
    public void ResetStreak()
    {
        _currentStreak = 0;
    }

    /// <summary>
    ///     <para>
    ///         Retrieves the current streak of the habit.
    ///     </para>
    /// </summary>
    /// <returns>An integer value representing the current streak of the habit.</returns>
    public int GetCurrentStreak()
    {
        return _currentStreak;
    }

    /// <summary>
    ///     <para>
    ///         Retrieves the longest streak of the habit.
    ///     </para>
    /// </summary>
    /// <returns>An integer value representing the longest streak of the habit.</returns>
    public int GetLongestStreak()
    {
        return _longestStreak;
    }

    /// <summary>
    ///     <para>
    ///         Retrieves the name of the habit.
    ///     </para>
    /// </summary>
    /// <returns>A string value representing the name of the habit</returns>
    public string GetName()
    {
        return _name;
    }

    /// <summary>
    ///     <para>
    ///         Marks a habit as complete for that day
    ///     </para>
    /// </summary>
    public void MarkComplete()
    {
        IncrementStreak();
        
        _completedToday = true;
        _completionHistory.Add(DateTime.Now, true);
    }
    
}