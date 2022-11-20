namespace Lesson9_Advanced_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle trikampis = new Triangle("Trikampis", 4, 3);
            Quadrilateral keturkampis = new Quadrilateral("Keturkampis", 4, 3);
            Pentagod penkiakampis = new Pentagod("Penkiakampis", 4, 3);
            Hexagon sesiakampis = new Hexagon("Šešiakampis", 4);
            List<Figure> figures = new List<Figure> {
            keturkampis,trikampis,sesiakampis, penkiakampis};
            Console.WriteLine("Nesurikiuotas Sąrašas:------");
            foreach(var figure in figures)
            {
                figure.Area = figure.GetArea();
                Console.WriteLine($"{figure.Name} plotas lygus {figure.Area} kv.cm.");
            }
            Console.WriteLine("\nSąrašas nuo didžiausio ploto:------");
            figures.Sort(new FigureCompare());
            foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.Name} plotas lygus {figure.Area} kv.cm.");
            }
        }
    }
}