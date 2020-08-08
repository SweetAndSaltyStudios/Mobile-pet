using System;
using TMPro;
using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class DebugPanel : MonoBehaviour
    {
        #region VARIABLES

        public TextMeshProUGUI CurrentSessionTimeText;
        public TextMeshProUGUI LastSessionTimeText;
        public TextMeshProUGUI BetweenSessionTimeText;

        public bool IsPaused;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Start()
        {
            CurrentSessionTimeText.text += DateTime.UtcNow.ToString("HH:mm dd MMMM, yyyy");
            LastSessionTimeText.text += PlayerPrefs.GetString("SessionDateTime", DateTime.UtcNow.ToString("HH:mm dd MMMM, yyyy"));
            //BetweenSessionTimeText.text += 
        }

        private void OnApplicationFocus(bool focusStatus)
        {
            print("OnApplicationFocus");
            IsPaused = !focusStatus;
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            print("OnApplicationPause");
            IsPaused = pauseStatus;
        }

        private void OnApplicationQuit()
        {
            print("OnApplicationQuit");

            PlayerPrefs.SetString("SessionDateTime", DateTime.UtcNow.ToString("HH:mm dd MMMM, yyyy"));
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        #endregion CUSTOM_FUNCTIONS
    }
}
