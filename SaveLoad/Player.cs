using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    //Variabel Global
    public int contoh = 0;
    public int[] contohArray = new int[10];


    #region For STAY ACTIVE
    private static bool created = false;
    void Awake()
    {
        string path = Application.persistentDataPath + "/Player.Data";
        //Jika File Tidak Ada Maka Save Dulu
		if (!File.Exists(path))
        {
            savePlayer();
        }
		//Untuk Object Supaya Tidak Hilang Pada Saat Pindah Scene.
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }
    private void Start()
    {
        instance = this;
        LoadPlayer();
    }
    #endregion

	//Save
    public void savePlayer()
    {
        SaveSystems.SavePlayer(this);
    }

	//Load
    public void LoadPlayer()
    {
        PlayerData data = SaveSystems.LoadPlayer();
        contoh = data.contoh;
		
		/* Array Di Jabarkan Satu Satu Atau Juga Bisa Dengan Cara Lain Saya Belum Tau Itu Mohon Beritahu Saya
		   Apabila Anda Tau,
		*/
        #region Array
        contohArray[0] = data.contohArray[0];
        contohArray[1] = data.contohArray[1];
        contohArray[2] = data.contohArray[2];
        contohArray[3] = data.contohArray[3];
        contohArray[4] = data.contohArray[4];
        contohArray[5] = data.contohArray[5];
        contohArray[6] = data.contohArray[6];
        contohArray[7] = data.contohArray[7];
        contohArray[8] = data.contohArray[8];
        contohArray[9] = data.contohArray[9];
        #endregion

    }

}
