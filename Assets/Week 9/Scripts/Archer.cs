using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;

public class Archer : Villager
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;

    public override ChestType CanOpen()
    {
        return ChestType.Archer;
    }
    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
