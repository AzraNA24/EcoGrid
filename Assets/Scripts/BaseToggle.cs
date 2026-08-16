using UnityEngine;

public class ToggleAnimation : MonoBehaviour
{
    public Animator animator; 
    public string boolParameter = "Show";

    public void OnButtonToggle()
    {
        if (animator != null)
        {
            bool currentState = animator.GetBool(boolParameter);
            animator.SetBool(boolParameter, !currentState);
        }
    }
}
