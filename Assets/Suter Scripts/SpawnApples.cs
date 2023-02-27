using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApples : MonoBehaviour
{
    public GameObject Apple;
    public GameObject SpawnPoint;

    public void SpawnAnApple()
    {
        Instantiate(Apple, SpawnPoint.transform.position, Quaternion.identity);
    }
}
