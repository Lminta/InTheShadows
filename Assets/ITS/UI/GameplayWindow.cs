using System;
using ITS.Gameplay;
using TMPro;
using UnityEngine;

namespace ITS.UI
{
    public class GameplayWindow : UIWindow
    {
        [SerializeField]
        TMP_Text _levelName;

        void Start()
        {
            _levelName.text = LevelManager.Get().GetCurrent().GetName();
        }

        void Update()
        {
            if (_levelName.gameObject.activeInHierarchy)
            {
                if (Input.anyKey)
                {
                    _levelName.gameObject.SetActive(false);
                }
            }
        }
    }
}
