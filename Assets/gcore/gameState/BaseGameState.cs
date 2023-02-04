namespace gcore.gameState
{
    public class BaseGameState
    {
        private BaseGameState _parent;
        private BaseGameState _currentState;

        private bool _isActive = false;

        public BaseGameState(BaseGameState parent)
        {
            _parent = parent;
        }
        
        public virtual void toState(BaseGameState state)
        {
            if (_currentState != null)
            {
                _currentState.exit();
            }
            _currentState = state;
            _currentState.go();
        }

        public virtual void go()
        {
            _isActive = true;
        }

        public virtual void back()
        {
            if (_currentState != null)
                _currentState.back();
            else
                exit();
        }

        public virtual void exit()
        {
            _isActive = false;
        }

        public void update(double delta)
        {
            if (_currentState != null)
            {
                _currentState.update(delta);
            }
        }

    }
}