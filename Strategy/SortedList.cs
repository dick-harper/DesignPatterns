namespace DesingPatterns.Behavioral.Strategy;

public class SortedList
{
  private List<string> _list = new List<string>();
  private SortStrategy _sortStrategy;

  public void SetSortStrategy(SortStrategy sortStrategy)
  {
    this._sortStrategy = sortStrategy;
  }

  public void Add(string name)
  {
    _list.Add(name);
  }

  public void Sort()
  {
    _sortStrategy.Sort(_list);

    // Iterate over list and display results
    foreach (string name in _list)
    {
      Console.WriteLine(" " + name);
    }
    Console.WriteLine();
  }
}