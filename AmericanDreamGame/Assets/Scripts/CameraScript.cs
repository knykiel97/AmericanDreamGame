using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        var vec3 = transform.position;
        vec3.z = target.position.z - distance;
        vec3.x = target.position.x + 5f;

        transform.position = vec3;
    }

    private void LateUpdate()
    {
        var camPos = Camera.main.transform.position;
        camPos.y = cameraY;

        Camera.main.transform.position = camPos;
    }

    [SerializeField] private Transform target;
    [SerializeField] private float distance = 15f;
    [SerializeField] private float cameraY = 1.5f;
}
