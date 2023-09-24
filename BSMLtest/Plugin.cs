using BSMLtest.Installers;
using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace BSMLtest
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        /// <summary>
        /// IPAによってプラグインが最初にロードされたときに呼び出される（ゲームが開始されたとき、またはプラグインが無効な状態で開始された場合は有効化されたときのいずれか）
        /// [Init]コンストラクタを使用するメソッドや、InitWithConfigなどの通常のメソッドの前に呼び出されるメソッド
        /// [Init]は1つのコンストラクタにのみ使用してください
        /// </summary>
        public void Init(IPALogger logger, Zenjector zenjector)
        {
            Instance = this;
            Log = logger;
            Log.Info("BSMLtest initialized.");
            zenjector.Install<BSMLtestMenuInstaller>(Location.Menu);
        }

        [OnStart]
        public void OnApplicationStart()
        {
            Log.Debug("OnApplicationStart");
        }

        [OnExit]
        public void OnApplicationQuit()
        {
            Log.Debug("OnApplicationQuit");
        }
    }
}
