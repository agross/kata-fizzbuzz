// 1, 2, Fizz, 4, Buzz, Fizz...

// Zahlengenerator
// Ausgabe bestimmen (n Zahlen -> n Outputs)
// Mapping einer Zahl (1 Zahl -> 1 Output, Reihenfolge der Mapper)
// zahl -> fizzbuzz (/3 && /5)
// zahl -> buzz (/5)
// zahl -> fizz (/3)
// zahl -> zahl
// Ausgabe auf der Konsole

using FizzBuzzNetCore;

using KataFizzBuzz;
using KataFizzBuzz.Durch15Teilbar;
using KataFizzBuzz.Durch3Teilbar;
using KataFizzBuzz.Durch5Teilbar;
using KataFizzBuzz.ZahlZuZahl;

var generator = new ZahlenGenerator();

var weasel = new FizzBuzzNetCore.KataFizzBuzz(new IMapper[]
{
  new ZahlZuFizzBuzzMapper(),
  new ZahlZuFizzMapper(),
  new ZahlZuBuzzMapper(),
  new ZahlZuZahlMapper(),
});

foreach (var zahl in generator.GibMirDieZahlen())
{
  var ausgabe = weasel.Übersetzen(zahl);
  Console.WriteLine(ausgabe);
}
