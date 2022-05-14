using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    [SerializeField] float _hiz = 5f;

    private void FixedUpdate()
    {
        transform.position += new Vector3(-1* _hiz * Time.deltaTime ,0);
    }

}
