namespace Piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение октавы F5-F8");
            int[] octave = Change_octave(ConsoleKey.F12, null);
            while (true)
            {
                ConsoleKeyInfo klavisha = Console.ReadKey(true);
                octave = Change_octave(klavisha.Key, octave);
                Notes(octave, klavisha);
                if (klavisha.Key == ConsoleKey.F12)
                { break; }
            }
        }
        static int[] Change_octave(ConsoleKey klavisha, int[]?octave)
        {
            int[] fifth_octave = new int[] {523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987};
            int[] sixth_octave = new int[] {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1978};
            int[] seventh_octave = new int[] {2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951};
            int[] eight_octave = new int[] {4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902};
            switch (klavisha) 
            {
                case ConsoleKey.F5: 
                    { return fifth_octave; }
                case ConsoleKey.F6: 
                    { return sixth_octave; }
                case ConsoleKey.F7: 
                    { return seventh_octave; }
                case ConsoleKey.F8: 
                    { return eight_octave; }
                default: return octave;
            }
        }
        static void Notes(int[]? octave, ConsoleKeyInfo klavisha) 
        {
            switch (klavisha.Key) 
            {
                case ConsoleKey.Q: 
                    { Console.Beep(octave[0], 120); break; }
                case ConsoleKey.W:
                    { Console.Beep(octave[1], 120); break; }
                case ConsoleKey.E:
                    { Console.Beep(octave[2], 120); break; }
                case ConsoleKey.R:
                    { Console.Beep(octave[3], 120); break; }
                case ConsoleKey.T:
                    { Console.Beep(octave[4], 120); break; }
                case ConsoleKey.Y:
                    { Console.Beep(octave[5], 120); break; }
                case ConsoleKey.U:
                    { Console.Beep(octave[6], 120); break; }
                case ConsoleKey.I:
                    { Console.Beep(octave[7], 120); break; }
                case ConsoleKey.O:
                    { Console.Beep(octave[8], 120); break; }
                case ConsoleKey.P:
                    { Console.Beep(octave[9], 120); break; }
                case ConsoleKey.A:
                    { Console.Beep(octave[10], 120); break; }
                case ConsoleKey.S:
                    { Console.Beep(octave[11], 120); break; }
            }
        }
    }
}