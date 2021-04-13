using System;
using UnityEngine;
using UnityEngine.UI;

namespace ITS.UI
{
    public class Fade : MonoBehaviour
    {
        [SerializeField]
        Image _fade;

        bool _in = false;
        bool _out = false;

        Action _onIn;
        Action _onOut;
        void Update()
        {
            if (_in)
            {
                if (_fade.color.a > 0)
                {
                    var tmp = _fade.color;
                    tmp.a -= 0.01f;
                    _fade.color = tmp;
                }
                else
                {
                    _in = false;
                    _fade.enabled = false;
                    _onIn?.Invoke();
                }
            }
            if (_out)
            {
                if (_fade.color.a < 1)
                {
                    var tmp = _fade.color;
                    tmp.a += 0.01f;
                    _fade.color = tmp;
                }
                else
                {
                    _out = false;
                    _onOut?.Invoke();
                }
            }
        }

        public void FadeIn(Action onIn = null)
        {
            _fade.enabled = true;
            var tmp = _fade.color;
            tmp.a = 1;
            _fade.color = tmp;
            _in = true;
            _onIn = onIn;
        }

        public void FadeOut(Action onOut = null)
        {
            _fade.enabled = true;
            var tmp = _fade.color;
            tmp.a = 0;
            _fade.color = tmp;
            _out = true;
            _onOut = onOut;
        }
    }
}
