using gcore.core.notification;
using gcore.gameState;

namespace gcore.core.app
{
    public abstract class App
    {
        private static App _instance = null;

        private MainState _mainState;
        
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

        public MainState getMainState() => _mainState;
        public void setMainState(MainState state) => _mainState = state;

        protected virtual MainState generateMainState()
        {
            return null;
        }

        protected virtual void run()
        {
            Notifications.get().post(AppNotification.GAME_LAUNCH);
            setMainState(generateMainState());
            getMainState().go();
        }

        protected virtual void postInit()
        {
            Notifications.get().post(AppNotification.GAME_INIT);
        }

        protected virtual void init()
        {
            
        }

        public void shutdown()
        {
            Notifications.get().post(AppNotification.GAME_START_CLOSING);
            beforeShutdown();
            _instance = null;
        }

        protected virtual void beforeShutdown()
        {
            
        }
    }
}