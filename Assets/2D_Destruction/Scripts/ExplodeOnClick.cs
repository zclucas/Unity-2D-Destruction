using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	private Explodable _explodable;

	void Start()
	{
		_explodable = GetComponent<Explodable>();
	}
	void OnMouseDown()
	{
		_explodable.explode();
		ExplosionForce ef = FindObjectOfType<ExplosionForce>();
		float oriZ = Camera.main.WorldToScreenPoint(transform.position).z;
		Vector3 tar = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, oriZ));
		ef.doExplosion(tar);
	}
}
