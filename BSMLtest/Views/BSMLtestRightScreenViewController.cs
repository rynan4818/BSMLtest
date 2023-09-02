using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace BSMLtest.Views
{
    [HotReload]
    public class BSMLtestRightScreenViewController : BSMLAutomaticViewController
    {
        [UIAction("#post-parse")]
        internal void PostParse()
        {
            // Code to run after BSML finishes
        }
    }
}
