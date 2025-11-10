using UnityEngine;

public class PlayerData : MonoBehaviour
{

    public static PlayerData Instance;
    public string playerName;
    public Vector3 playerPosition;
    public int playerMaxHealth;
    public int playerMaxMana;
    public int playerExp;

    /*void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject); 
       
    }*/

    public void SaveData()
    {
        /*UserData.playerName = playerName;
        UserData.playerMaxHealth = playerMaxHealth;
        UserData.playerMaxMana = playerMaxMana;
        UserData.playerExp = playerExp;
        Debug.Log("Data Saved");
        UserData.playerPosition = playerPosition;*/

        Stats.UserStats.playerName = playerName;
        Stats.UserStats.playerExp = playerExp;
        Stats.UserStats.playerMaxHealth = playerMaxHealth;
        Stats.UserStats.playerMaxMana = playerMaxMana;
        Stats.UserStats.playerPosition = playerPosition;

        SavingDataSystem.Save();


        
    }

    public void LoadData()
    { 
        
        /*playerName = UserData.playerName;
        playerMaxHealth = UserData.playerMaxHealth;
        playerMaxMana = UserData.playerMaxMana;
        playerExp = UserData.playerExp;
        Debug.Log("Data Loaded");
        playerPosition = UserData.playerPosition;*/

        SavingDataSystem.Load();
        
        playerName = Stats.UserStats.playerName;
        playerExp = Stats.UserStats.playerExp;
        playerMaxHealth = Stats.UserStats.playerMaxHealth;
        playerMaxMana = Stats.UserStats.playerMaxMana;
        playerPosition = Stats.UserStats.playerPosition;

        

        
    }


    public void SavePrefs()
    {
        PlayerPrefs.SetString("Player Name", playerName);
        PlayerPrefs.SetInt("Player Health", playerMaxHealth);
        PlayerPrefs.SetInt("Player Mana", playerMaxMana);
        PlayerPrefs.SetInt("Player EXP", playerExp);
        PlayerPrefs.SetFloat("Player Coord X", playerPosition.x);
        PlayerPrefs.SetFloat("Player Coord Y", playerPosition.y);
        PlayerPrefs.SetFloat("Player Coord Z", playerPosition.z);
    }
    
    public void LoadPrefs()
    {
        playerName = PlayerPrefs.GetString("Player Name", "No Name");
        playerMaxHealth = PlayerPrefs.GetInt("Player Health;", 2);
        playerMaxMana = PlayerPrefs.GetInt("Player Mana", 2);
        playerExp = PlayerPrefs.GetInt("Player EXP", 2);
        playerPosition.x = PlayerPrefs.GetFloat("Player Coord X", 0);
        playerPosition.y = PlayerPrefs.GetFloat("Player Coord Y", 0);
        playerPosition.z = PlayerPrefs.GetFloat("Player Coord Z", 0);
    }
    
}
