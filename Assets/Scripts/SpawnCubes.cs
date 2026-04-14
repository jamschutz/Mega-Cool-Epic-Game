using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnCubes : MonoBehaviour
{
    public GameObject prefab;


    
    public void OnSpawn(InputAction.CallbackContext context)
    {
        if(context.started) {
            for(int i = 0; i < 100; i++) {
                Vector3 pos = new(0, Random.Range(1, 2), Random.Range(-0.5f, 1.5f));
                GameObject.Instantiate(prefab, pos, Quaternion.identity);
            }
        }
    }
}
