using UnityEngine;
using Facepunch.Steamworks;



public class SteamHandler : MonoBehaviour 
{
	public static SteamHandler instance = null;
	private Client client;
	[SerializeField]
	private string steamName;

	private void Awake()
	{
		//Check if instance already exists
		if (instance == null)
			//if not, set instance to this
			instance = this;
		//If instance already exists and it's not this:
		else if (instance != this)
			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);
		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
		Facepunch.Steamworks.Config.ForUnity(Application.platform.ToString());
		client = new Client(480);
		if (client.IsValid)
		{
			print("Steam has been initialized...");
			steamName = client.Username;
		}
		else
			print("There was an error while initializing steam... Check if steam is running.");
	}

	void Start () 
	{
		
	}
		
	void Update () 
	{
		
	}

	private void OnApplicationQuit()
	{
		client.Dispose();
	}
}
