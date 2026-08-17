using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewChooseTask", menuName = "Data/New Choose Task")]
[System.Serializable]
public class TaskLabel : ScriptableObject
{
    public List<ChooseLabel> labels;

    [System.Serializable]
    public struct ChooseLabel
    {
        public string text;
    }
}
