using C = System.Console;
class P
{
    static int Main()
    {
        int p(string s) => int.Parse(s);
        var i = C.ReadLine().Split(' ');
        int Z = p(i[0]), T = p(i[1]), X = p(i[2]), Y = p(i[3]);
        for (; ; )
        {
            var d = "";
            if (T > Y) { d += "S"; Y++; }
            if (T < Y) { d += "N"; Y--; }
            if (Z > X) { d += "E"; X++; }
            if (Z < X) { d += "W"; X--; }
            C.WriteLine(d);
        }
    }
}