﻿using UnityEngine;
using System.Collections;

namespace TDGP.Demo
{
/// <summary>
/// Demo Script. Moves ENemies towards player.
/// </summary>
	public class FollowTarget : MonoBehaviour
	{
		public Transform Player;
	
		private float zDistance = 5f;

		// Update is called once per frame
		void Update ()
		{
			transform.position = new Vector3 (Player.position.x, Player.position.y, Player.position.z - zDistance);
		}
	}
}
