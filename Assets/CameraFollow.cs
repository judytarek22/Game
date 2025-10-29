using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Target;
    public float CameraSpeed;
    public float minX, maxX;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if (Target != null)
        {
            Vector2 newCameraPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * CameraSpeed);
            float ClampX = Mathf.Clamp(newCameraPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCameraPosition.y, minY, maxY);
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
