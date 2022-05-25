using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New FoodData", menuName = "Food Data", order = 51)]
public class FoodData :   ScriptableObject
{
    public string name;
    public float speedBonus=0f;
    public float timeBonus = 0f;
    public int bodyBonus=0;
}
