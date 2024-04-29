using UnityEngine;

public static class Pathes
{
#if UNITY_EDITOR
	public static string SaveFile => "Assets/Resources/Saves/Save.json";
#else
	public static string SaveFile => $"{Application.persistentDataPath}/Save.json";
#endif
	public static string LinkedInUrl => "https://www.linkedin.com/in/ivan-shelepeten-859658299";
}
