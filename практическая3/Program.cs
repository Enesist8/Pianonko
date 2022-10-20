namespace pianinko
{
    internal class program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ask;
            {
                ask = Console.ReadKey();
                while (ask.Key != ConsoleKey.Escape)
                {
                    int[] currentoct = new int[] { };
                    ask = Console.ReadKey();
                    if (ask.Key == ConsoleKey.O)
                    {
                        Console.WriteLine("\nМеню октав. Для выбора нажмите f1, f2, f3 и так далее!");
                        int[] oktava_1 = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
                        int[] oktava_2 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                        int[] oktava_3 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                        int[] oktava_4 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                        int[] oktava_5 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                        int[] oktava_6 = new int[] { 2094, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3952 };
                        int[] oktava_7 = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902, };
                        ConsoleKeyInfo Clavisha = Console.ReadKey();
                        switch (Clavisha.Key)
                        {
                            case (ConsoleKey.F1):
                                {
                                    currentoct = oktava_1;
                                    break;
                                }
                            case (ConsoleKey.F2):
                                {
                                    currentoct = oktava_2;
                                    break;
                                }
                            case (ConsoleKey.F3):
                                {
                                    currentoct = oktava_3;
                                    break;
                                }
                            case (ConsoleKey.F4):
                                {
                                    currentoct = oktava_4;
                                    break;
                                }
                            case (ConsoleKey.F5):
                                {
                                    currentoct = oktava_5;
                                    break;
                                }
                            case (ConsoleKey.F6):
                                {
                                    currentoct = oktava_6;
                                    break;
                                }
                            case (ConsoleKey.F7):
                                {
                                    currentoct = oktava_7;
                                    break;
                                }
                                Octava(currentoct);
                        }
                    }
                }
            }
            static void Octava(int[] notes)
            {
                Console.WriteLine("q,w,e,r,t,y-black" +
                "a,s,d,f,g,h,j-white");
                ConsoleKeyInfo musica;
                do
                {
                    musica = Console.ReadKey();
                    switch (musica.Key)
                    {
                        case ConsoleKey.A:
                            Console.Beep(notes[0], 200);
                            break;
                        case ConsoleKey.Q:
                            Console.Beep(notes[1], 200);
                            break;
                        case ConsoleKey.S:
                            Console.Beep(notes[2], 200);
                            break;
                        case ConsoleKey.W:
                            Console.Beep(notes[3], 200);
                            break;
                        case ConsoleKey.D:
                            Console.Beep(notes[4], 200);
                            break;
                        case ConsoleKey.F:
                            Console.Beep(notes[5], 200);
                            break;
                        case ConsoleKey.E:
                            Console.Beep(notes[6], 200);
                            break;
                        case ConsoleKey.G:
                            Console.Beep(notes[7], 200);
                            break;
                        case ConsoleKey.R:
                            Console.Beep(notes[8], 200);
                            break;
                        case ConsoleKey.H:
                            Console.Beep(notes[9], 200);
                            break;
                        case ConsoleKey.T:
                            Console.Beep(notes[10], 200);
                            break;
                        case ConsoleKey.J:
                            Console.Beep(notes[11], 200);
                            break;
                    }
                } while (musica.Key != ConsoleKey.Escape);
            }
        }
    }
}