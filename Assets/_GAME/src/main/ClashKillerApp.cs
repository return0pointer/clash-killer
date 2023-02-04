using gcore.core.app;
using gcore.core.notification;

namespace _GAME.src.main
{
    public class ClashKillerApp : App
    {
        public ClashKillerApp() : base()
        {
            Notifications.get().addObserver("onInit", run, null);
            
        }
        
        protected override void init()
        {
            base.init();
        }

        protected override void postInit()
        {
            base.postInit();
            Notifications.get().postNotification("onInit", null);
        }

        protected override void run()
        {
            base.run();
        }
    }
}