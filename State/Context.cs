namespace DesignPatternState
{
    public class Context
    {
        private IState _currentState;
        private IState _stateDownUp;
        private IState _stateRightLeft;
        public Context()
        {
            _currentState = new StateDownUp(this);
            _stateDownUp = new StateRightLeft(this);
            _stateRightLeft = _stateDownUp;
        }

        public void ChangeState(EPossibleStates possibleStates)
        {
            switch (possibleStates)
            {
                case EPossibleStates.StateDownUp: _currentState = _stateDownUp; break;
                case EPossibleStates.StateRightLeft: _currentState = _stateRightLeft; break;
            }
        }

        public void MoveDown()
        {
            _currentState.MoveDown();
        }

        public void MoveLeft()
        {
            _currentState.MoveLeft();
        }

        public void MoveRight()
        {
            _currentState.MoveRight();
        }

        public void MoveUp()
        {
            _currentState.MoveUp();
        }
    }
}
