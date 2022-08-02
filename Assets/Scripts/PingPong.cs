using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public GameObject Enemy;
// Start is called before the first frame update


// Update is called once per frame
    public int  _roatate = 20;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,_roatate*Time.deltaTime,0);
        
    }

}