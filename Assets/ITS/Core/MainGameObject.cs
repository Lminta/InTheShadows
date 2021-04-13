using ITS.UI;
using UnityEngine;

public class MainGameObject : MonoBehaviour
{
    void Start()
    {
        UIManager.Get()?.OpenWindow(UIWindowType.MainMenu);
    }
}
