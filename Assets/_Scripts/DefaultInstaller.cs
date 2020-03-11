using UnityEngine;
using Zenject;

public class DefaultInstaller : MonoInstaller
{
   


    public override void InstallBindings()
    {

        Container.Bind<IGame>().To<Game>().AsSingle();

    }
}