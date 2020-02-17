using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageCalculator
{
    public static int CalculateDamage(int amount, float mitigationPercent)
    {
        return Convert.ToInt32(amount * mitigationPercent);
    }
}
