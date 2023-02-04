using gcore.gameState;

namespace gcore.core.app
{
    public abstract class App
    {
        private static App _instance = null;

        private BaseGameState _mainState;
        
        public static App instance => _instance;

        public App()
        {
            
        }
        
        public static void launch(App app)
        {
            if (_instance != null)
                _instance.shutdown();
            _instance = app;
            app.init();
            app.postInit();
            app.run();
        }

        public BaseGameState getMainState() => _mainState;
        public void setMainState(BaseGameState state) => _mainState = state;

        protected virtual void run()
        {
            
        }

        protected virtual void postInit()
        {
            
        }

        protected virtual void init()
        {
            
        }

        public void shutdown()
        {
            beforeShutdown();
            _instance = null;
        }

        protected virtual void beforeShutdown()
        {
            
        }
    }
}