using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UISetting : ScriptableObject
{
   private const string SettingFileDirectory = "Assets/Resources";
   private const string SettingFilePath = "Assets/Resources/UISetting.asset";

   private static UISetting _instance;

   public static UISetting Instance
   {
      get
      {
         if (_instance != null)
         {
            return _instance;
         }

         _instance = Resources.Load<UISetting>("UISetting");
#if UNITY_EDITOR
         if (_instance == null)
         {
            if (!AssetDatabase.IsValidFolder(SettingFileDirectory))
            {
               AssetDatabase.CreateFolder("Assets", "Resources");
            }

            _instance = AssetDatabase.LoadAssetAtPath<UISetting>(SettingFilePath);

            if (_instance == null)
            {
               _instance = CreateInstance<UISetting>();
               AssetDatabase.CreateAsset(_instance, SettingFilePath);
            }
         }
#endif
         return _instance;
      }
   }

   public string language = "kr";
   public Color themeColor;
   public Sprite sprite;
   public GameObject popupPrefab;

   public Font defaultFont;
   public int defaultFontSize = 100;
   public Color defaultFontColor = Color.gray;
   
   [SerializeField]
   string heroName;

   [SerializeField]
   string description;


}
