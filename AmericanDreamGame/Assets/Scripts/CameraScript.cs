using UnityEngine;

/*
 * Script makes camera follow @target
 */
public class CameraScript : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        var vec3 = transform.position;
        vec3.z = target.position.z - distance;
        vec3.x = target.position.x + 5f;
        vec3.y = target.position.y;

        transform.position = vec3;
    }

    [SerializeField] private Transform target;
    [SerializeField] private float distance = 15f;
    [SerializeField] private float cameraY = 1.5f;
}
