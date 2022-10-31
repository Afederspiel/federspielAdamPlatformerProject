using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform followTransform;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(followTransform.position.x + offset.x, followTransform.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}