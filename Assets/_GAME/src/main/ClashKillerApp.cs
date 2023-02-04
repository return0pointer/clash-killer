using gcore.core.app;
using gcore.core.notification;
using gcore.gameState;
using gcore.locale;
using UnityEngine;

namespace _GAME.src.main
{
    public class ClashKillerApp : App
    {
        public ClashKillerApp() : base()
        {
            LocalizationManager.setInstance(new LocalizationManager());
        }
        
        protected override void init()
        {
            base.init();
        }

        protected override void postInit()
        {
            base.postInit();
        }

        protected override void run()
        {
            base.run();
            Debug.Log(Localizer.get("NOT LOCALIZE STRING"));
        }

        protected override MainState generateMainState()
        {
            return new CKMainState(this);
        }
    }
}