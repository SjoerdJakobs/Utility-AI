using UnityEngine;
using System.Collections;

public interface IAmLiving
{
    void TakeDamage();

    void ReturnStats(Stats stats);
}
