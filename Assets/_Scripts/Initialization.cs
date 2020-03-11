using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class Initialization : MonoBehaviour
{
    private IGame game;

   

    [Inject]
    public void SetUp(IGame game)
    {
         this.game = game;

    }

    private void Start()
    {
        game.Init();
        game.test();
    }
}
