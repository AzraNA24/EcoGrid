using TMPro;
using UnityEngine;

public class TaskItem : MonoBehaviour
{
    public TextMeshProUGUI taskText;

    public void Setup(string text)
    {
        taskText.text = text;
    }
}