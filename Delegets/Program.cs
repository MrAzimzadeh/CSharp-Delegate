public class Program
{
    delegate void LogDel(string text);
    // ! Delegate ler new lana bilir ona gore bunlari cagirdigimzda Newlamaliyiq ->
    delegate void DelegareMethod(double a, double b);

    public static void Main(string[] args)
    {

        // ! -> Methodu cagiranq  -> 
        /*
        ?  Methodu cagiranda onun constructoruna() <- hansi methodu icerisinde saxlayacayiqsa onu yazmaliyiq.
        ?  Exam -> 
        */
        DelegareMethod delegareMethod = new(Cevre);
        delegareMethod += alan; //todo Burada Bir Cevre Methodu Ile Alan methodunu eyni vaxta bu sekilde cagirra bilerik 
        delegareMethod(5, 5);

        //! Consoole ->
        // System.Console.WriteLine($"cevre {result}");
        // ?  Elave olunan Methodu cixarma  ->>>>>>
        System.Console.WriteLine("Elave olunan Methodu cixarma -> ");
        delegareMethod -= alan;
        delegareMethod(5, 5);


        Console.WriteLine(topla(100));

        LogDel logDel = new LogDel(LogTextToScreen);

        var name = Console.ReadLine();

        LogTextToFile(name);

        Console.ReadKey();
    }
    static void LogTextToScreen(string text)
    {
        System.Console.WriteLine($"{DateTime.Now} : {text}");
    }

    static void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now} : {text}");
        }
    }
    static int topla(int sa = 50)
    {
        return sa;
    }
    static void Cevre(double a, double b)
    {
        System.Console.WriteLine("aa" + 2 * (a + b));
    }
    static void alan(double a, double b)
    {
        System.Console.WriteLine("bb" + a * b + 5);

    }
}