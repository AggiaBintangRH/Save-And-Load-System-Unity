using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fungsi Ini Bisa Di Cari Di Dokumen Unity
[System.Serializable]

public class PlayerData
{
    public int contoh;
    public int[] contohArray = new int[10];
    


    public PlayerData (Player player)
    {
        contoh = player.contoh;

		/* Array Di Jabarkan Satu Satu Atau Juga Bisa Dengan Cara Lain Saya Belum Tau Itu Mohon Beritahu Saya
		   Apabila Anda Tau,
		*/
        #region 
        contohArray[0] = player.contohArray[0];
        contohArray[1] = player.contohArray[1];
        contohArray[2] = player.contohArray[2];
        contohArray[3] = player.contohArray[3];
        contohArray[4] = player.contohArray[4];
        contohArray[5] = player.contohArray[5];
        contohArray[6] = player.contohArray[6];
        contohArray[7] = player.contohArray[7];
        contohArray[8] = player.contohArray[8];
        contohArray[9] = player.contohArray[9];
        #endregion
	}
}
