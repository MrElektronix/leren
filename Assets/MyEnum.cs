using UnityEngine;
using System.Collections;

public class MyEnum : MonoBehaviour {

	public enum WeaponTypes
	{
		Sword,
		Mace, 
		Pistol
	}
	[SerializeField]
	private WeaponTypes weapontype;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			switch (weapontype) {
			case WeaponTypes.Mace:
				MaceAttack ();
				break;
			case WeaponTypes.Sword:
				SwordAttack ();
				break;
			case WeaponTypes.Pistol:
				PistolAttack ();
				break;
			default:
				break;
			}
		}
	}

	void MaceAttack() {
		Debug.Log ("Mace op je kop");
	}

	void SwordAttack() {
		Debug.Log ("Sword op je kop");
	}

	void PistolAttack() {
		Debug.Log ("Kogel door je hoofd");
	}
}
