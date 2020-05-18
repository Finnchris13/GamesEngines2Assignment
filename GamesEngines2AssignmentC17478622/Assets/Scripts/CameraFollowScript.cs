using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public Transform target;

    public float speed;

    public float slowTimer;

    public bool slowCamRot;

    public bool startFollow;

    public float startFollowTime;

    // Start is called before the first frame update
    void Awake()
    {
        slowCamRot = false;
        Invoke("setSlowTrue", slowTimer);
        if (!startFollow)
        {
            Invoke("setFollow", startFollowTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startFollow)
        {
            Vector3 targetDir = target.position - transform.position;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(targetDir), Time.time * speed);

            if (slowCamRot)
            {
                speed -= 0.00025f;
            }

            if (speed <= 0.01)
            {
                slowCamRot = false;
            }
        }
    }

    void setSlowTrue()
    {
        slowCamRot = true;
    }

    void setFollow()
    {
        startFollow = true;
    }

}
