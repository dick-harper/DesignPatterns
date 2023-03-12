
namespace DesingPatterns.Behavioral.Strategy;
// A 'ConcreteStrategy' class
public class QuickSort : SortStrategy
{
  public override void Sort(List<string> list)
  {
    list.Sort(); // Default is Quicksort
    Console.WriteLine("QuickSorted list ");
  }
}