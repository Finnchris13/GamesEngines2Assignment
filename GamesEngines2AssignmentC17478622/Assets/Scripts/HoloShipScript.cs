using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloShipScript : MonoBehaviour
{

    public float timeTillDeath;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("death", timeTillDeath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void death()
    {
        Destroy(gameObject);
    }
}
