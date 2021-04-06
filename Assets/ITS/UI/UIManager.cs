using System;
using UnityEngine;

namespace ITS.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _canvas;

        [SerializeField]
        Popup _popupPrefab;

        public void ShowPopup(string header, string message, string right, string left, Action rightAnswer, Action leftAnswer)
        {
            Popup dialogue = Instantiate(_popupPrefab, _canvas);
            dialogue.SetText(header, message, right, left);
            dialogue.SetButtonsCallback(rightAnswer, leftAnswer);
        }
    }
}
