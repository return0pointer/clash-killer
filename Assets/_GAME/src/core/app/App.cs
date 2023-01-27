using UnityEditorInternal;

namespace _GAME.src.core.app
{
    public abstract class App
    {
        private static App _instance = null;

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