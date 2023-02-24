using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator jumpyArrow;

    public void PlayJumpyArrow()
    {
        jumpyArrow.enabled = true;
        jumpyArrow.Play("Arrow_jumpy");
        Debug.Log("Played Arrow_jumpy");
    }

    public void StopJumpyArrow()
    {
        jumpyArrow.enabled = false;
        Debug.Log("Stopped Arrow_jumpy");
    }
}
