using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{

    public TextAsset _jsontext;

    [System.Serializable]
    public class Record
    {
        public string Name;
        public string Rating;
    }

    [System.Serializable]
    public class RecordsList
    {
        public Record[] records;
    }

    public RecordsList myRecordList = new RecordsList();

    // Start is called before the first frame update
    void Start()
    {
        myRecordList = JsonUtility.FromJson<RecordsList>(_jsontext.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public RecordsList readJSON()
    {
        return myRecordList = JsonUtility.FromJson<RecordsList>(_jsontext.text);
    }
}