using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLerper : MonoBehaviour
{
    [SerializeField] Transform followTransform;
    [SerializeField] float lerpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, followTransform.position, lerpSpeed * Time.deltaTime);
    }
}
