using UnityEngine;

public class Debugger : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating(nameof(Count), 2.5f, 2.5f);
    }


    private void Count()
    {
        for(int i = 0; i < 1000; i++) {
            Debug.Log($"yay numbers {i}");
        }
    }
}
