using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewide : MonoBehaviour
{
    public GameObject mainCam;
    private float positionX = 0.0f;
    private float moveSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        positionX = this.transform.position.x - mainCam.transform.rotation.z * moveSpeed / 90.0f;
        this.transform.position = new Vector3(positionX, this.transform.position.y, this.transform.position.z);
    }
}
