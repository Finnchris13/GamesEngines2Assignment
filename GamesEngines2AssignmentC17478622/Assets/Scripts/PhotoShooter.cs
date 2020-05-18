using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoShooter : MonoBehaviour
{

    public GameObject photonShot;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("instantiatePhoton", 16.4f);
        Invoke("instantiatePhoton", 23.4f);
        Invoke("instantiatePhoton", 25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instantiatePhoton()
    {
        Instantiate(photonShot, gameObject.transform.position, Quaternion.identity);
    }

}
