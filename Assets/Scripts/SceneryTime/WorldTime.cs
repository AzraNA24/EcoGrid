using System;
using System.Collections;
using UnityEngine;

namespace WorldTime
{
    public class WorldTime : MonoBehaviour
    {
        [SerializeField]
        private float _dayLength;

        private TimeSpan _currentTime;

        public event EventHandler<TimeSpan> WorldTimeChanged;

        private float _minuteLength =>
            _dayLength / ConstantTime.MinutesInDay;

        private IEnumerator AddMinute()
        {
            _currentTime += TimeSpan.FromMinutes(1);

            WorldTimeChanged?.Invoke(this, _currentTime);

            yield return new WaitForSeconds(_minuteLength);

            StartCoroutine(AddMinute());
        }

        private void Start()
        {
            StartCoroutine(AddMinute());
        }
    }
}