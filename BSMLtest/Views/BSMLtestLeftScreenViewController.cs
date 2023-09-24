using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using System.Collections.Generic;

namespace BSMLtest.Views
{
    [HotReload]
    public class BSMLtestLeftScreenViewController : BSMLAutomaticViewController
    {
        [UIValue("targetDevice1choices")]
        public List<object> TargetDevice1choices { get; set; } = new List<object>() { "NONE" };

        [UIAction("LoadPosition")]
        public void LoadPosition()
        {
        }

        [UIAction("#post-parse")]
        internal void PostParse()
        {
            // Code to run after BSML finishes
        }
    }
}
