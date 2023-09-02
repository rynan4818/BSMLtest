using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using BSMLtest.Views;
using HMUI;
using Zenject;

namespace BSMLtest
{
    public class BSMLtestFlowCoordinator : FlowCoordinator, IInitializable
    {
        private BSMLtestMainViewController _mainViewController;
        private BSMLtestLeftScreenViewController _leftScreenViewController;
        private BSMLtestRightScreenViewController _rightScreenViewController;
        private BSMLtestBottomScreenViewController _bottomScreenViewController;
        private MenuButton _menuButton;

        [Inject]
        public void Constractor(BSMLtestMainViewController mainViewController, 
            BSMLtestLeftScreenViewController leftScreenViewController, 
            BSMLtestRightScreenViewController rightScreenViewController, 
            BSMLtestBottomScreenViewController bottomScreenViewController)
        {
            this._mainViewController = mainViewController;
            this._leftScreenViewController = leftScreenViewController;
            this._rightScreenViewController = rightScreenViewController;
            this._bottomScreenViewController = bottomScreenViewController;
        }

        public void Initialize()
        {
            this._menuButton = new MenuButton("BSMLtest", "", this.ShowMainFlowCoodniator);
            MenuButtons.instance?.RegisterButton(this._menuButton);
        }

        public void OnDestroy()
        {
            MenuButtons.instance?.UnregisterButton(this._menuButton);
        }

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (firstActivation)
            {
                this.SetTitle("BSMLtest");
                this.showBackButton = true;
                // topScreenViewControllerを使用するとタイトルとバックボタンが消える（たぶん自前で実装が必要）
                this.ProvideInitialViewControllers(this._mainViewController, this._leftScreenViewController, this._rightScreenViewController, this._bottomScreenViewController);
            }
        }

        protected override void BackButtonWasPressed(ViewController topViewController)
        {
            BeatSaberUI.MainFlowCoordinator.DismissFlowCoordinator(this);
            base.BackButtonWasPressed(topViewController);
        }

        private void ShowMainFlowCoodniator()
        {
            BeatSaberUI.MainFlowCoordinator.PresentFlowCoordinator(this);
        }
    }
}
