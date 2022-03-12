using System;

public class PosisiKarakterGame
{
    enum State { Terbang, Jongkok, Berdiri, EXIT };
    public static void Main()
    {
        State state = State.Berdiri;
        string[] screenName = { "Terbang", "Jongkok", "Berdiri" };
        string[] outputmsg = { "posisi landing", "", "posisi take off" };
        while (state != State.EXIT)
        {
            Console.WriteLine("state: " + screenName[(int)state]);
            Console.Write("Input Command: ");
            string command = Console.ReadLine();
            Console.WriteLine("Output: " + outputmsg[(int)state]);
            Console.WriteLine("");
            switch (state)
            {
                case State.Terbang:
                    if (command == "Jongkok")
                        state = State.Jongkok;
                    else if (command == "QUIT")
                        state = State.EXIT;
                    else
                        state = State.Terbang;
                    break;
                case State.Jongkok:
                    if (command == "Berdiri")
                        state = State.Berdiri;
                    else if (command == "QUIT")
                        state = State.EXIT;
                    else
                        state = State.Jongkok;
                    break;
                case State.Berdiri:
                    if (command == "Terbang")
                        state = State.Terbang;
                    else if (command == "QUIT")
                        state = State.EXIT;
                    else
                        state = State.Berdiri;
                    break;
            }
        }
        Console.WriteLine("EXIT SCREEN");
    }
}
