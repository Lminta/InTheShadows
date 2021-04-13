using UnityEngine;

namespace ITS.UI
{
    public class MainMenu : UIWindow
    {
        public void OnStartCLick()
        {
            UIManager.Get()?.OpenWindow(UIWindowType.LevelMenu);
        }

        public void OnOptionsCLick()
        {
        }

        public void OnExitCLick()
        {
            UIManager.Get()?.ShowPopup("Exit", "Are you sure?", "Yes", "No",
                () => Application.Quit(0), () => UIManager.Get().ClosePopup());
        }
    }
}
