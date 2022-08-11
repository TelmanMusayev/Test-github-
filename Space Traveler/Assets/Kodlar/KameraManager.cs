using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraManager : MonoBehaviour
{
    public Transform Hedef;
    public Vector3 mesafe;
    [SerializeField] private float speed;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Hedef.position+mesafe, speed);
    }
}
