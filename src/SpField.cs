﻿using UnityEngine;
using System.Collections;

public class SpField {
	public string Name;
	public int Tag;
	public SpType Type;
	public string TypeName;
	public bool Array;

	public SpField (string name, int tag, string type, bool array) {
		Name = name;
		Tag = tag;
		TypeName = type;
		Array = array;
	}

	public bool CheckAndUpdate () {
		if (Type != null)
			return true;

		// use GetTypeNoCheck instead of GetType, to prevent infinit GetType call
		// when a type reference itself like : foobar { a 0 : foobar }
		Type = SpTypeManager.Instance.GetTypeNoCheck (TypeName);
		return (Type != null);
	}
}
