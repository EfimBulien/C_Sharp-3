using System;

namespace пианино
{
    
    internal class PlayPiano
    {
        static void Main()
        {
            Console.WriteLine("Переключение между октавами F2 и F4.");
            while (true)
            {
                ConsoleKeyInfo change = Console.ReadKey();
                switch (change.Key)
                {
                    case ConsoleKey.F2:
                        int[] O2 = new int[] { 524, 555, 587, 623, 660, 699, 740, 784, 831, 880, 933, 988 };
                        Octave("Вторая октава", O2);
                        break;

                    case ConsoleKey.F4:
                        int[] O4 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3333, 3440, 3729, 3951 };
                        Octave("Четверая октава", O4);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ошибка, повторите попытку");
                        }
                        break;
                }
            }
        }
        

        static void Octave(string octave, int[] current_octaves)
        {
            int duration = 200;
            Console.Clear();
            Console.WriteLine(octave);
            Console.WriteLine("Чтобы выйти из этой октавы нажмите Enter, выберите октаву или выйдете из программы, нажав на Escape ");
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Q)
                {
                    Sound(current_octaves[0], duration);

                }
                else if (key.Key == ConsoleKey.W)
                {
                    Sound(current_octaves[1], duration);

                }
                else if (key.Key == ConsoleKey.E)
                {
                    Sound(current_octaves[2], duration);

                }
                else if (key.Key == ConsoleKey.R)
                {
                    Sound(current_octaves[3], duration);

                }
                else if (key.Key == ConsoleKey.T)
                {
                    Sound(  current_octaves[4], duration);

                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Sound(current_octaves[5], duration);

                }
                else if (key.Key == ConsoleKey.A)
                {
                    Sound(current_octaves[6], duration);

                }
                else if (key.Key == ConsoleKey.S)
                {
                    Sound(current_octaves[7], duration);

                }
                else if (key.Key == ConsoleKey.D)
                {
                    Sound(current_octaves[8], duration );

                }
                else if (key.Key == ConsoleKey.F)
                {
                    Sound(current_octaves[9], duration);

                }
                else if (key.Key == ConsoleKey.G)
                {
                    Sound(current_octaves[10], duration);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Sound(current_octaves[11], duration);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Main();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.Write("Неверная клавиша!");
                    Console.WriteLine("Используемые клавиши пианино:");
                    Console.WriteLine("R, T, Y, U, I");
                    Console.WriteLine("D, F, G, H, J, K, L");
                }
            }
        }


        static void Sound(int frequency, int duration)
        {
            Console.Beep(frequency: frequency, duration);
        }
    }
}
