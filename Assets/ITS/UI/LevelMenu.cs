using System;
using System.Collections;
using System.Collections.Generic;
using ITS.UI;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : UIWindow
{
    [SerializeField]
    List<LevelButton> _buttons;

    int _save = 0;

    void Start()
    {
        if (PlayerPrefs.HasKey("SavedProgress"))
        {
            _save = PlayerPrefs.GetInt("SavedProgress");
            Debug.Log("Game data loaded!");
        }
        else
        {
            _save = 0;
            Debug.Log("There is no save data!");
        }

        for (int i = 0; i < _buttons.Count; i++)
        {
            _buttons[i].SetInteractable(i <= _save);
        }
    }

    public void OnModeSwitch(bool value)
    {
        foreach (var button in _buttons)
        {
            button.SetInteractable(value);
        }
    }
}
