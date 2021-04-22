using System;
using System.Collections.Generic;
using ITS.Core;
using UnityEngine;

namespace ITS.UI
{
    public enum UIWindowType
    {
        MainMenu,
        LevelMenu,
        GameplayWindow
    }

    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        RectTransform _canvas;

        [SerializeField]
        Popup _popupPrefab;

        [EnumNamedArray(typeof(UIWindowType))] [SerializeField]
        List<UIWindow> _UIWindowsPrefabs;

        Popup _currentPopup;
        UIWindow _currentWindow;

        static UIManager _instance;
        public static UIManager Get() => _instance;
        void Awake()
        {
            _instance = this;
        }

        public UIWindow GetCurrent() => _currentWindow;

        public void OpenWindow(UIWindowType type)
        {
            if (_currentWindow != null)
            {
                _currentWindow.OnClose(() =>
                {
                    Destroy(_currentWindow);
                    _currentWindow = Instantiate(_UIWindowsPrefabs[(int)type], _canvas);
                    _currentWindow.OnOpen();
                });
                _currentWindow = null;
            }
            else
            {
                _currentWindow = Instantiate(_UIWindowsPrefabs[(int) type], _canvas);
                _currentWindow.OnOpen();
            }
        }

        public void ShowPopup(string header, string message, string right, string left, Action rightAnswer, Action leftAnswer)
        {
            if (_currentPopup != null)
            {
                Destroy(_currentPopup);
                _currentPopup = null;
            }
            _currentPopup = Instantiate(_popupPrefab, _canvas);
            _currentPopup.SetText(header, message, right, left);
            _currentPopup.SetButtonsCallback(rightAnswer, leftAnswer);
        }
        public void ClosePopup()
        {
            if (_currentPopup != null)
            {
                Destroy(_currentPopup);
                _currentPopup = null;
            }
        }
    }
}
