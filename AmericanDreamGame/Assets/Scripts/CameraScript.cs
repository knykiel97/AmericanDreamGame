using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vec3 = transform.position;
        vec3.z = target.position.z - distance;
        vec3.x = target.position.x + 5f;
        //vec3.y = target.position.y;

        transform.position = vec3;
    }

    void LateUpdate()
    {
        var camPos = Camera.main.transform.position;
        camPos.y = cameraY;

        Camera.main.transform.position = camPos;
    }

    [SerializeField] private Transform target;
    [SerializeField] private float distance = 15f;
    [SerializeField] private float cameraY = 1.5f;
}
