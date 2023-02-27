using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator BookLooper;

    public void PlayBookLoop()
    {
        BookLooper.Play("BookLoop");
    }
}
