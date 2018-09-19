using UnityEngine;

public class SteamLoader : MonoBehaviour 
{
	[SerializeField]
	private GameObject steamClient;

	void Awake () 
	{
		if (SteamHandler.instance == null)
		{
			if (Instantiate(steamClient))
				print("SteamHandler instantiated...");
		}
	}
		
	void Update () 
	{
		
	}
}
