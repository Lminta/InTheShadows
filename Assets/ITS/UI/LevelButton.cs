using ITS.Gameplay;
using UnityEngine;
using UnityEngine.UI;

namespace ITS.UI
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField]
        Button _button;

        [SerializeField]
        Levels _level;

        public void SetInteractable(bool value)
        {
            _button.interactable = value;
        }

        public void OnClick()
        {
            LevelManager.Get().OpenLevel(_level);
        }
    }
}
