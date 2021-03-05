using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSound : MonoBehaviour
{
   public static void Attack()
    {
        SoundManagerScript.PlaySound("sword_sound2");
    }
}
