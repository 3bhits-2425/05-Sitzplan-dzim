using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; //Ref zu TableLayout ScriptableObject
    [SerializeField] private StudentLayoutData[] students; //
    [SerializeField] private GameObject tablePrefab; //Prefab für Tisch
    [SerializeField] private GameObject chairPrefab; //Prefab für Stuhl

    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}