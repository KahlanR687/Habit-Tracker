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
    ///         A private string variable that represents the description of the habit.
    ///     </para>
    /// </summary>
    private string _description;
    
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
    ///         A constructor that initializes a new instance of the Habit class.
    ///     </para>
    /// </summary>
    public Habit()
    {
        
    }

    /// <summary>
    ///     <para>
    ///         Updates the current streak of the habit by one.
    ///         If the new streak is greater than the current longest streak, the longest streak is also updated.
    ///     </para>
    /// </summary>
    public void incrementStreak()
    {
        
    }

    /// <summary>
    ///     <para>
    ///         Resets the current streak of the habit to zero.
    ///     </para>
    /// </summary>
    public void resetStreak()
    {
        
    }

    /// <summary>
    ///     <para>
    ///         Retrieves the current streak of the habit.
    ///     </para>
    /// </summary>
    /// <returns>An integer value representing the current streak of the habit.</returns>
    public int getCurrentStreak()
    {
        return 0;
    }

    /// <summary>
    ///     <para>
    ///         Retrieves the longest streak of the habit.
    ///     </para>
    /// </summary>
    /// <returns>An integer value representing the longest streak of the habit.</returns>
    public int getLongestStreak()
    {
        return 0;
    }
    
}