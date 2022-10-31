using ChoreScore.Enums;

namespace ChoreScore.Models;

public class Chore
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public int Hours { get; private set; }
  public bool IsDone { get; private set; }
  public ChoreArea Area { get; private set; }

  public void ChangeName(string name)
  {
    Name = name;
  }

  public Chore(string name, int hours, bool isDone, ChoreArea area)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Hours = hours;
    IsDone = isDone;
    Area = area;
  }
}