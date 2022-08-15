namespace CSharpFirst
{
class Program
{
    static void Main(string[] args)
    {
      string nameConcat = string.Concat("My ", "name ", "is ", "John");
      System.Console.WriteLine(nameConcat);

      nameConcat = string.Join(" ", "My","name", "is", "John");
      System.Console.WriteLine(nameConcat);

      nameConcat = nameConcat.Insert(0, "By the way,");
      System.Console.WriteLine(nameConcat);

      nameConcat = nameConcat.Remove(0, 1);
      System.Console.WriteLine(nameConcat);

      string replaced = nameConcat.Replace('n', 'z');
      System.Console.WriteLine(replaced);
    }   
    static void StringEmptiness()
    {
      string str = string.Empty; // same as "";

      string empty = "";
      string withSpaced = " ";
      string notEmpty = " b";
      string nullString = null;

      System.Console.WriteLine("IsNullOrEmpty");
      bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
      System.Console.WriteLine(isNullOrEmpty);

      isNullOrEmpty = string.IsNullOrEmpty(withSpaced);
      System.Console.WriteLine(isNullOrEmpty);

      isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
      System.Console.WriteLine(isNullOrEmpty);

      isNullOrEmpty = string.IsNullOrEmpty(empty);
      System.Console.WriteLine(isNullOrEmpty);

      System.Console.WriteLine();
      System.Console.WriteLine("IsNullOrWithSpace");

      bool isNullOrWithSpace = string.IsNullOrWhiteSpace(nullString);
      System.Console.WriteLine(isNullOrWithSpace);

      isNullOrWithSpace = string.IsNullOrWhiteSpace(withSpaced);
      System.Console.WriteLine(isNullOrWithSpace);

      isNullOrWithSpace = string.IsNullOrWhiteSpace(notEmpty);
      System.Console.WriteLine(isNullOrWithSpace);

      isNullOrWithSpace = string.IsNullOrWhiteSpace(empty);
      System.Console.WriteLine(isNullOrWithSpace);
    }
    static void QueryingStrings()
    {
      string name = "abracadabra";
      bool containA = name.Contains('a');
      bool containE = name.Contains('E');

      System.Console.WriteLine(containA);
      System.Console.WriteLine(containE);

      bool endWithAbra = name.EndsWith("abra");
      System.Console.WriteLine(endWithAbra);

      bool startWithAbra = name.StartsWith("abra");
      System.Console.WriteLine(startWithAbra);

      int indexOfA = name.IndexOf('a', 1);
      System.Console.WriteLine(indexOfA);

      int lastIndexOfR = name.LastIndexOf('r');
      System.Console.WriteLine(lastIndexOfR);

      System.Console.WriteLine(name.Length);

      string substrFrom5 = name.Substring(5);
      System.Console.WriteLine(substrFrom5);

      string substrFromTo = name.Substring(0, 3);
      System.Console.WriteLine(substrFromTo);
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