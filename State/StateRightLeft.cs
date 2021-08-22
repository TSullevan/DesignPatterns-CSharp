using System;

namespace DesignPatternState
{
    public class StateRightLeft : IState
    {
        private Context _context;

        public StateRightLeft(Context context)
        {
            _context = context;
        }

        public void MoveDown()
        {
            //Nothing todo
        }

        public void MoveLeft()
        {
            Console.WriteLine("Moving left...");
        }

        public void MoveRight()
        {
            Console.WriteLine("Moving right...");
        }

        public void MoveUp()
        {
            //Nothing todo
        }
    }
}
