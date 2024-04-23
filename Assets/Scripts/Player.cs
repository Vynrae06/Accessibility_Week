using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isFlat = true;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hopefulAcceleration = Input.gyro.userAcceleration;

        float accelerationX = hopefulAcceleration.x;
        float accelerationY = hopefulAcceleration.y;
        float accelerationZ = hopefulAcceleration.z;
        
        if(accelerationX >= 0.025 || accelerationX <= -0.025)
            transform.Translate(new Vector3(-accelerationX, 0, 0) * 10, Space.World);
        //if(accelerationY != 0)
            //transform.Translate(0, accelerationY, 0);
        
        // Debug.Log(Input.acceleration.x);
        Debug.Log(hopefulAcceleration);
    }
}
