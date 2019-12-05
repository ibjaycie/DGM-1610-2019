using UnityEngine;

public class Instancer : MonoBehaviour
{
	public GameObject prefab;

	public void CreateInstance()
	{
		Instantiate(prefab, transform.position, Quaternion.identity);
	}
}
