using System;
using UnityEngine;
using UnityEngine.UI;

namespace ITS.UI
{
    public class UIWindow : MonoBehaviour
    {
        [SerializeField] Fade _fade;

        public virtual void OnOpen(Action onIn = null)
        {
            _fade.FadeIn(onIn);
        }

        public virtual void OnClose(Action onOut = null)
        {
            _fade.FadeOut(onOut);
        }
    }
}
