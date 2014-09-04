using UnityEngine;
using System.Collections;

public class WarFactory : Building {

	protected override void Start () {
		base.Start();
		actions = new string[] { "Tank" };
	}
}