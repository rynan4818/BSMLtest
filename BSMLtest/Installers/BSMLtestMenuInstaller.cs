using BSMLtest.Views;
using Zenject;

namespace BSMLtest.Installers
{
    public class BSMLtestMenuInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            this.Container.BindInterfacesAndSelfTo<BSMLtestFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            this.Container.BindInterfacesAndSelfTo<BSMLtestMainViewController>().FromNewComponentAsViewController().AsSingle();
            this.Container.BindInterfacesAndSelfTo<BSMLtestLeftScreenViewController>().FromNewComponentAsViewController().AsSingle();
            this.Container.BindInterfacesAndSelfTo<BSMLtestRightScreenViewController>().FromNewComponentAsViewController().AsSingle();
            this.Container.BindInterfacesAndSelfTo<BSMLtestBottomScreenViewController>().FromNewComponentAsViewController().AsSingle();
        }
    }
}
