namespace DesingPatterns.Behavioral.Strategy;
public class ShellSort : SortStrategy
{
  public override void Sort(List<string> list)
  {
    //list.ShellSort(); not-implemented
    Console.WriteLine("ShellSorted list ");
  }
}