using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "New Hero Data", menuName = "Sword HeroData", order = 2)]
    public class test : ScriptableObject
    {
        [SerializeField]

        string heroName;

        [SerializeField]

        string description;

        [SerializeField]

        int goldCost;

 

        public string sName => heroName;

        public string sDesc => description;

        public int    nCoin => goldCost;


    }
}