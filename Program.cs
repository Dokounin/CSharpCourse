namespace CSharpFirst
{
class Program
{
    static void Main(string[] args)
    {
      
    }   
    static void StaticAndInstanceMembers()
    {
      string name = "abracadabra";
      bool containA = name.Contains('a');
      bool containE = name.Contains('E');

      System.Console.WriteLine(containA);
      System.Console.WriteLine(containE);

      string abc = string.Concat("a", "b", "c");
      System.Console.WriteLine(abc);

      System.Console.WriteLine(int.MinValue);

      int x = 1;
      string xStr = x.ToString();

      System.Console.WriteLine(xStr);
      System.Console.WriteLine(x);  
    }
    static void Overflow()
    {
        checked 
            {
                    uint x = uint.MaxValue;
                    System.Console.WriteLine(x);

                    x = x + 1;
                    System.Console.WriteLine(x);

                    x = x - 1;
                    System.Console.WriteLine(x);
            }
    }
    static void VariablesScope()
    {
          var a = 1;
        {
            var b = 2;
            {
                var c = 3;
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                System.Console.WriteLine(c);
                
            }
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                // System.Console.WriteLine(c);
        }
        System.Console.WriteLine(a);
        // System.Console.WriteLine(b);
        // System.Console.WriteLine(c);
    }
    static void Literals()
    {
        int x = 0b11;
        int y = 0b1001;
        int k = 0b10001001;
        int m = 0b1000_1001;

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);
        System.Console.WriteLine(k);
        System.Console.WriteLine(m);

        System.Console.WriteLine();

        x = 0x1F;
        y = 0xFF0D;
        k = 0x1FAB30EF;
        m = 0x1FAB_30EF;

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);
        System.Console.WriteLine(k);
        System.Console.WriteLine(m);

        System.Console.WriteLine();

        System.Console.WriteLine(4.5e2);
        System.Console.WriteLine(3.1E-1);

        System.Console.WriteLine();

        System.Console.WriteLine('\x78');
        System.Console.WriteLine('\x5A');

        System.Console.WriteLine('\u0420');
        System.Console.WriteLine('\u0421');

    }
    static void Variables() 
    {
        int x = -1;
        int y;
        y = 2;

        // int32 x1 =  -1;
        // uint z = -1;

        float f = 1.0f;

        double d = 2.3;

        int x2 = 0;
        int x3 = new int();

        var a = 1;
        var b = 1.2;

        // Dictionary<int,string> dict = new Dictionary<int, string>();
        var dict = new Dictionary<int, string>();
        // var v;

        decimal money = 3.0m;
        
        char @char = 'A';
        string name = "John";

        bool canDrive = true;
        bool canDraw  = false;

        System.Console.WriteLine(a);
        System.Console.WriteLine(name);
    }
}
}