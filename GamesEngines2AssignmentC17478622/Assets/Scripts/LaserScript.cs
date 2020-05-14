using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{

    public LineRenderer line;

    public Transform target;
    public Transform thisShip;

    public float speed;

    public float[] laserShots;

    private bool useLaser;

    // Start is called before the first frame update
    void Start()
    {
        useLaser = false;
        line.enabled = false;
        Invoke("laser", laserShots[0]);
        Invoke("laser", laserShots[1]);
        Invoke("laser", laserShots[2]);
        Invoke("laser", laserShots[3]);
    }

    // Update is called once per frame
    void Update()
    {
        lockOnTarget();

        if (useLaser)
        {
            line.enabled = true;
            line.SetPosition(0, thisShip.position);
            line.SetPosition(1, target.position);
        }

    }

    void lockOnTarget()
    {
        Vector3 targetDir = target.position - transform.position;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(targetDir), Time.time * speed);
    }

    void laser()
    {
        useLaser = true;
        Invoke("stopLaser", 0.4f);
    }

    void stopLaser()
    {
        useLaser = false;
        line.enabled = false;
    }

}
