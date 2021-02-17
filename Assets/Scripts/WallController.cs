using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField]
    private GameObject wall = null;

    [SerializeField]
    private Vector3 direction = Vector3.zero;

    void Update()
    {
        float angle = Vector3.Angle(transform.forward, direction);

        if (angle < 90)
            wall.SetActive(true);
        else
            wall.SetActive(false);
    }
}
