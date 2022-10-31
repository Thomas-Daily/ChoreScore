using ChoreScore.Enums;
using ChoreScore.Models;

namespace ChoreScore.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Mop the floor", 1, false, ChoreArea.Kitchen),
    new Chore("Pick up clothes", 1, true, ChoreArea.Bedroom),
    new Chore("Vaccum the floor", 2, false, ChoreArea.LivingRoom),
    new Chore("Sweep off the leaves", 2, true, ChoreArea.Porch)
  };
}