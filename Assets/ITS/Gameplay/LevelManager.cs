using System.Collections.Generic;
using ITS.Core;
using ITS.UI;
using UnityEngine;

namespace ITS.Gameplay
{
    public enum Levels
    {
        SampleModel,
        Jumbo,
        School,
        TheWorld
    }
    public class LevelManager : MonoBehaviour
    {
        [EnumNamedArray(typeof(Levels))] [SerializeField]
        List<Level> _levelPrefabs;

        Level _currentLevel;

        static LevelManager _instance;
        public static LevelManager Get() => _instance;

        void Awake()
        {
            _instance = this;
        }

        public Level GetCurrent() => _currentLevel;

        public void OpenLevel(Levels level)
        {
            if (_currentLevel != null)
            {
                _currentLevel.OnClose(() => Destroy(_currentLevel));
                _currentLevel = null;
            }
            _currentLevel = Instantiate(_levelPrefabs[(int)level], this.transform);
            _currentLevel.OnOpen();
        }
    }
}
