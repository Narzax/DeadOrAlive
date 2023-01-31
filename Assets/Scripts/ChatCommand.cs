using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


using Random=UnityEngine.Random;

public class ChatCommand : MonoBehaviour
{
    SeApi seApi;
    GameManager gamemanager;
    ListManager listmanager;

    string command = "!bet ";
    int rowPoint = 13;
    int columnPoint = 4;
    int combPoint = 26;
    int evenPoint = 28;
    int oddPoint = 24;
    int numPoint = 36;
    int facePoint = 16;
    int allPoint = 52;

    string[] row_class = new string[] {"row 1", "row 2", "row 3", "row 4"};
    string[] column_class = new string[] {"column 2", "column 3", "column 4", "column 5", "column 6", "column 7", "column 8","column 9", "column 10", "column j", "column q", "column k", "column a"};
    string[] combination_class = new string[] {"comb 12", "comb 13", "comb 14", "comb 23", "comb 24", "comb 34", "even", "odd", "num", "face"};
    string all_class = "all";

    void Start()
    {
        seApi = GameObject.FindGameObjectWithTag("SE_API").GetComponent<SeApi>();
        gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        listmanager = GameObject.FindGameObjectWithTag("ListManager").GetComponent<ListManager>();
    }

    public void OnChatMessage(string pChatter, string pMessage)
    {   
        if(gamemanager.isBetEnabled)
        {
            switch(pMessage)
            {
                // ROWS
                case string row1 when row1.Contains(command + row_class[0]): 
                    bet(pChatter, rowPoint, row_class[0]);
                break;
                case string row2 when row2.Contains(command + row_class[1]): 
                    bet(pChatter, rowPoint, row_class[1]);
                break;
                case string row3 when row3.Contains(command + row_class[2]): 
                    bet(pChatter, rowPoint, row_class[2]);
                break;
                case string row4 when row4.Contains(command + row_class[3]): 
                    bet(pChatter, rowPoint, row_class[3]);
                break;

                // COLUMNS       
                case string column2 when column2.Contains(command + column_class[0]): 
                    bet(pChatter, columnPoint, column_class[0]);
                break;
                case string column3 when column3.Contains(command + column_class[1]): 
                    bet(pChatter, columnPoint, column_class[1]);                
                break;
                case string column4 when column4.Contains(command + column_class[2]): 
                    bet(pChatter, columnPoint, column_class[2]);               
                break;
                case string column5 when column5.Contains(command + column_class[3]): 
                    bet(pChatter, columnPoint, column_class[3]);               
                break;
                case string column6 when column6.Contains(command + column_class[4]): 
                    bet(pChatter, columnPoint, column_class[4]);                
                break;
                case string column7 when column7.Contains(command + column_class[5]): 
                    bet(pChatter, columnPoint, column_class[5]);                
                break;
                case string column8 when column8.Contains(command + column_class[6]): 
                    bet(pChatter, columnPoint, column_class[6]);               
                break;
                case string column9 when column9.Contains(command + column_class[7]): 
                    bet(pChatter, columnPoint, column_class[7]);               
                break;
                case string column10 when column10.Contains(command + column_class[8]): 
                    bet(pChatter, columnPoint, column_class[8]);                
                break;
                case string columnj when columnj.Contains(command + column_class[9]): 
                    bet(pChatter, columnPoint, column_class[9]);                
                break;
                case string columnq when columnq.Contains(command + column_class[10]): 
                    bet(pChatter, columnPoint, column_class[10]);               
                break;
                case string columnk when columnk.Contains(command + column_class[11]): 
                    bet(pChatter, columnPoint, column_class[11]);             
                break;
                case string columna when columna.Contains(command + column_class[12]): 
                    bet(pChatter, columnPoint, column_class[12]);               
                break;

                // COMBINATIONS
                case string comb12 when comb12.Contains(command + combination_class[0]): 
                    bet(pChatter, combPoint, combination_class[0]);               
                break;
                case string comb13 when comb13.Contains(command + combination_class[1]): 
                    bet(pChatter, combPoint, combination_class[1]);               
                break;
                case string comb14 when comb14.Contains(command + combination_class[2]): 
                    bet(pChatter, combPoint, combination_class[2]);               
                break;
                case string comb23 when comb23.Contains(command + combination_class[3]): 
                    bet(pChatter, combPoint, combination_class[3]);               
                break;
                case string comb24 when comb24.Contains(command + combination_class[4]): 
                    bet(pChatter, combPoint, combination_class[4]);               
                break;
                case string comb34 when comb34.Contains(command + combination_class[5]): 
                    bet(pChatter, combPoint, combination_class[5]);               
                break;
                case string even when even.Contains(command + combination_class[6]): 
                    bet(pChatter, evenPoint, combination_class[6]);               
                break;
                case string odd when odd.Contains(command + combination_class[7]): 
                    bet(pChatter, oddPoint, combination_class[7]);               
                break;
                case string num when num.Contains(command + combination_class[8]): 
                    bet(pChatter, numPoint, combination_class[8]);               
                break;
                case string face when face.Contains(command + combination_class[9]): 
                    bet(pChatter, facePoint, combination_class[9]);               
                break;
                
                // ALL
                case string all when all.Contains(command + all_class): 
                    bet(pChatter, allPoint, all_class); 
                break;
            }
        }   
        else
        {
            return;
        }
        
    }

    void bet(string user, int point, string bet_class)
    {
        listmanager.AddNameToList(user, point, bet_class);
    }
}
