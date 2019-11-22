using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float distanceFromPlanet = 20f;
    public float spawnDelay = 1f;
    public Transform meterorParent;

    // Start is called before the first frame update
    void Start ()
	{
		StartCoroutine(SpawnMeteor());
	}

	IEnumerator SpawnMeteor()
	{
		Vector3 pos = Random.onUnitSphere * distanceFromPlanet;
		GameObject meteror = Instantiate(meteorPrefab, pos, Quaternion.identity);
        meteror.transform.parent = meterorParent;

		yield return new WaitForSeconds(1f);

		StartCoroutine(SpawnMeteor());
	}
}
