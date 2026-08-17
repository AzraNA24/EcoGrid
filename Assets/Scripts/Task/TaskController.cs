using UnityEngine;

public class TaskController : MonoBehaviour
{
    public TaskLabel taskData;
    public TaskItem taskPrefab;
    public Transform taskContainer;

    void Start()
    {
        ShowTasks();
    }

    public void ShowTasks()
    {
        foreach (TaskLabel.ChooseLabel label in taskData.labels)
        {
            TaskItem item = Instantiate(taskPrefab, taskContainer);
            item.Setup(label.text);
        }
    }
}