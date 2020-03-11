using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public interface IGame
{
    void Init();
    void test();
}

public class Game : IGame
{
   

    public void Init()
    {
        Debug.Log("Statred");

    }

   
    public void test()
    {

        Debug.Log("test");
    }

}
