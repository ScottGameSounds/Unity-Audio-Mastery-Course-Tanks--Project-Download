using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerUp : MonoBehaviour
{
    private Vector3 startPos;
    public float amplitude = 1f;
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        transform.Rotate(new Vector3(0f, Random.Range(0f, 360f), 0f)); 

    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;

        float x = transform.position.x;
        float y = (startPos.y + Mathf.Sin(Time.time)) * amplitude;
        float z = transform.position.z;
        transform.Rotate(new Vector3(0f, rotationSpeed, 0f));
        transform.position = new Vector3(x, y, z);
    }
}
