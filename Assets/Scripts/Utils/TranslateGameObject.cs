using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateGameObject : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
