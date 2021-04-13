using System;
using UnityEngine;

namespace ITS.Gameplay
{
    public class Level : MonoBehaviour
    {
        [SerializeField]
        string _name;

        public string GetName() => _name;
        public void OnOpen(Action onIn = null)
        {

        }

        public void OnClose(Action onOut = null)
        {

        }
    }
}
