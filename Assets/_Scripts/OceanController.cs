using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES +++++++++++++++++
	private int _speed;
	private Transform _transform;

	// PUBLIC PROPERTIES ++++++++++++++++++++++++++
	public int Speed {
		get {
			return this._speed;
		}

		set {
			this._speed = value;
		}
	}

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> (); // get a reference to the Transform of my ocean
		this.Speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		this._move ();
		this._borderCheck ();
	}

	/**
	 * This method moves the game object down the screen
	 */
	private void _move() {
		Vector2 newPosition;

		newPosition = this._transform.position;

		newPosition.y -= this.Speed;

		this._transform.position = newPosition;
	}

	/**
	 * This method checks to see if my game object has reached the top border
	 * of my scene
	 */
	private void _borderCheck() {
		if (this._transform.position.y <= -480) {
			this._reset ();
		}
	}

	/**
	 * This method resets the game object back to it's original position
	 */
	private void _reset() {
		Vector2 resetPosition = new Vector2 (0f, 480f);
		this._transform.position = resetPosition;
	}
}
