using ChoreScore.Models;

namespace FullstackChoreScore.Repositories;

public class ChoresRepository : BaseRepository
{
  public ChoresRepository(IDbConnection db) : base(db)
  {
  }

  public List<Chore> Get()
  {
    var sql = "SELECT * FROM chores";
    return _db.Query<Chore>(sql).ToList();
  }


}