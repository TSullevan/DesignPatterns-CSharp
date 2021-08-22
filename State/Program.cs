using System;

namespace DesignPatternState
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");

            Context context = new Context();

            context.MoveUp();
            context.MoveRight();
            context.MoveLeft();
            context.MoveDown();

            Console.WriteLine("Changed State");
            context.ChangeState(EPossibleStates.StateRightLeft);

            context.MoveUp();
            context.MoveRight();
            context.MoveLeft();
            context.MoveDown();

            Console.WriteLine("End Program");
        }
    }
}
