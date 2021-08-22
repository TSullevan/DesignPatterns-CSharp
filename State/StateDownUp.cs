using System;

namespace DesignPatternState
{
    public class StateDownUp : IState
    {
        private Context _context;

        public StateDownUp(Context context)
        {
            _context = context;
        }

        public void MoveDown()
        {
            Console.WriteLine("Moving down...");
            //_context.ChangeState(EPossibleStates.StateRightLeft);
        }

        public void MoveLeft()
        {
            //Nothing todo
        }

        public void MoveRight()
        {
            //Nothing todo
        }

        public void MoveUp()
        {
            Console.WriteLine("Moving up...");
        }
    }
}
