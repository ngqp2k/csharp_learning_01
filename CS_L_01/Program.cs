
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello ngqp2k!");

        myFunc_1();

    }

    static int num = 0;

    static void print_1()
    {
        Console.WriteLine("print_1__{0}", ++num);
        Console.WriteLine("Phu");
    }

    static void print_2()
    {
        Console.WriteLine("print_2__{0}", ++num);
        Console.WriteLine("Nguyen");
    }

    static void myFunc_1()
    {
        Console.WriteLine("myFunc_1__{0}", ++num);
        myFunc_2(print_1, print_2);
    }

    static List<int> myFunc_2(Action action_1_cb, Action action_2_cb)
    {
        Console.WriteLine("myFunc_2__{0}", ++num);
        return myFunc_3(action_1_cb, action_2_cb);
    }

    static List<int> myFunc_3(Action action_1_cb, Action action_2_cb)
    {
        Console.WriteLine("myFunc_3__{0}", ++num);
        Action doAction = () =>
        {
            myFunc_4(action_1_cb);
        };

        Action doAction_2 = () =>
        {
            action_2_cb?.Invoke();
        };

        myFunc_5(action_1_cb, action_2_cb);

        List<int> list = new List<int>();
        list.Add(5);
        list.Add(2);
        return list;
    }

    static void myFunc_4(Action action_1_cb)
    {
        Console.WriteLine("myFunc_4__{0}", ++num);
        Console.WriteLine("ngqp2k");
    }

    static void myFunc_5(Action action_1_cb, Action action_2_cb)
    {
        Console.WriteLine("myFunc_5__{0}", ++num);
        action_1_cb?.Invoke();
        action_2_cb?.Invoke();
    }
}