using UnityEngine;

public class Debugger : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating(nameof(Count), 1, 1);
        InvokeRepeating(nameof(FindSmileys), 5, 5);
    }


    private void Count()
    {
        for(int i = 0; i < 5000; i++) {
            Debug.Log($"yay numbers {i}");
        }
    }


    private void FindSmileys()
    {
        var smileys = GameObject.FindGameObjectsWithTag("smiley");
        // yay :)
    }
}
