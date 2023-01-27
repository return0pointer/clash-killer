using System.Collections;
using System.Collections.Generic;
using _GAME.src.core.app;
using _GAME.src.main;
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
