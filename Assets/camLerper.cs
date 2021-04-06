using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLerper : MonoBehaviour
{
    public Transform followTransform;
    [SerializeField] float lerpSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, followTransform.position, lerpSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, followTransform.rotation, lerpSpeed * Time.deltaTime);
    }
}
