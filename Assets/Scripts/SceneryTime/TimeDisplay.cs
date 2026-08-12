using System;
using TMPro;
using UnityEngine;

namespace WorldTime
{
    public class TimeDisplay : MonoBehaviour
    {
        [SerializeField]
        private WorldTime _worldTime;

        [SerializeField]
        private TextMeshProUGUI _timeText;

        [SerializeField]
        private TextMeshProUGUI _dayText;

        private void Awake()
        {
            _worldTime.WorldTimeChanged += OnWorldTimeChanged;
        }

        private void OnWorldTimeChanged(object sender, TimeSpan newTime)
        {
            _timeText.SetText(newTime.ToString(@"hh\:mm"));

            int day = (int)newTime.TotalDays + 1;

            _dayText.SetText($"0{day}");
        }

        private void OnDestroy()
        {
            if (_worldTime != null)
            {
                _worldTime.WorldTimeChanged -= OnWorldTimeChanged;
            }
        }
    }
}