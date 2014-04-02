using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterStats))]
public class Character : MonoBehaviour 
{
	private CharacterStats _stats;

	public CharacterStats Stats
	{
		get
		{
			return _stats;
		}
	}

	public void Start()
	{
		_stats = GetComponent<CharacterStats>();
		if (_stats == null)
		{
			Debug.LogError("No stats attached to character! " + gameObject.name);
		}
	}
}
