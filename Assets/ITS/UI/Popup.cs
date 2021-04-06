using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ITS.UI
{
    public class Popup : MonoBehaviour
    {
        [SerializeField]
        TMP_Text _header;
        [SerializeField]
        TMP_Text _message;

        [SerializeField]
        Button _rightButton;
        [SerializeField]
        Button _leftButton;
        [SerializeField]
        TMP_Text _right;
        [SerializeField]
        TMP_Text _left;

        public void SetButtonsCallback(Action onRightClicked, Action onLeftClicked)
        {
            _rightButton.onClick.AddListener(() =>
            {
                onRightClicked?.Invoke();
            });

            _leftButton.onClick.AddListener(() =>
            {
                onLeftClicked?.Invoke();
            });
        }

        public void SetText(string header, string message, string right, string left)
        {
            _header.text = header;
            _message.text = message;
            _right.text = right;
            _left.text = left;
        }
    }
}
