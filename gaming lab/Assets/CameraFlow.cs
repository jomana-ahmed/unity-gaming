using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform body;
    public float CameraSpeed;
    public float minX, maxX;
    public float minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
       if (body != null)
        {
            Vector3 newCameraPosition = Vector3.Lerp(transform.position, body.position, CameraSpeed * Time.deltaTime);
            float ClampX = Mathf.Clamp(newCameraPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCameraPosition.y, minY, maxY);
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
       
    }
}
