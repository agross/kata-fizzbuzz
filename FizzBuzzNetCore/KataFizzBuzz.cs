using KataFizzBuzz;

namespace FizzBuzzNetCore;

public class KataFizzBuzz
{
  readonly IMapper[] _mapper;

  public KataFizzBuzz(IMapper[] mapper)
  {
    _mapper = mapper;
  }

  public string Übersetzen(int zahl)
  {
    var first = _mapper.First(mapper => mapper.KannstDuDamitUmgehen(zahl));

    return first.Übersetzen(zahl);
  }
}
