using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, target.transform.position, .3f);
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
