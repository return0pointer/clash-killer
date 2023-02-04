using _GAME.src.input;
using gcore.core.app;
using gcore.core.notification;
using gcore.gameState;
using gcore.input;
using gcore.locale;
using UnityEngine;

namespace _GAME.src.main
{
    public class ClashKillerApp : App
    {
        public ClashKillerApp() : base()
        {
            
        }
        
        protected override void init()
        {
            base.init();
            LocalizationManager.setInstance(new LocalizationManager());
            GInput.setInstance(new CKInput());
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