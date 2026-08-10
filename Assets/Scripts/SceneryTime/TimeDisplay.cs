using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace WorldTime
{
    [RequireComponent(typeof(TMPro.TextMeshProUGUI))]
    public class TimeDisplay : MonoBehaviour
    {
        [SerializeField]
        private WorldTime _worldTime;
        private TMPro.TextMeshProUGUI _text;

        // Start is called before the first frame update
        private void Awake()
        {
            _text = GetComponent<TMPro.TextMeshProUGUI>();
            _worldTime.WorldTimeChanged += OnWorldTimeChanged;
        }

        private void OnWorldTimeChanged(object sender, TimeSpan newTime)
        {
            _text.SetText(newTime.ToString(@"hh\:mm"));
        }

        private void OnDestroy()
        {
            _worldTime.WorldTimeChanged -= OnWorldTimeChanged;
        }
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
