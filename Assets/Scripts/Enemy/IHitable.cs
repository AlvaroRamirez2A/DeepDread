using UnityEngine;
using System.Collections;

//This is a basic interface with a single required
//method.
public interface IHitable
{
    string OnHit(int damage, Vector3 dir);
}