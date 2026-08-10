using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System;
using WorldTime;

namespace WorldTime
{
    [RequireComponent(typeof(Light2D))]
    public class WorldLight : MonoBehaviour
    {
        [SerializeField]
        private WorldTime _worldTime;
        [SerializeField]
        private Gradient _lightColor;

        private Light2D _light;

        private void Awake()
        {
            _light = GetComponent<Light2D>();
            _worldTime.WorldTimeChanged += OnWorldTimeChanged;
        }

        private void OnDestroy()
        {
            _worldTime.WorldTimeChanged -= OnWorldTimeChanged;
        }

        private void OnWorldTimeChanged(object sender, TimeSpan newTime)
        {
            _light.color = _lightColor.Evaluate(CalculateTimePercentage(newTime));
        }

        private float CalculateTimePercentage(TimeSpan time)
        {
            return (float)time.TotalMinutes % ConstantTime.MinutesInDay / ConstantTime.MinutesInDay;
        }
    }
}

