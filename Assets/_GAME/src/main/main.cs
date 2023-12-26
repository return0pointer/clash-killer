using _GAME.src.main;
using gcore.core.app;
using UnityEngine;

public class main : MonoBehaviour
{
    void Start()
    {
        run();
    }

    private void run()
    {
        App app = new ClashKillerApp();
        App.launch(app);
    }
}
