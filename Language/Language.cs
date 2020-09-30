using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;

namespace Jelineksoft.Library.Language
{
    public class Language
    {
        
        public Dictionary<string, LanguageItem> LanguageItems = new Dictionary<string, LanguageItem>();
        public enum LanguageEnum
        {
            Cz,
            En
        }
        public LanguageEnum LanguageType { get; set; }

        public string Get(int key)
        {
            return Get(key.ToString());
        }
        public string Get(string key)
        {
            if (LanguageItems.ContainsKey(key))
                return LanguageItems[key].GetText(LanguageType);
            return $"Key '{key}' not found in LanguageItems.";
        }

        public string GetX(string en = "", string cz = "")
        {
            switch (LanguageType)
            {
                case LanguageEnum.Cz:
                    return cz;
                default:
                    return en;
            }
        }

        public void Add(int key, LanguageItem item)
        {
            Add(key.ToString(), item);
        }

        public void Add(string key, LanguageItem item)
        {
            if (LanguageItems.ContainsKey(key))
                LanguageItems.Remove(key);
            LanguageItems.Add(key, item);
        }
    }

    public class LanguageItem
    {
        public LanguageItem(string en, string cz)
        {
            En = en;
            Cz = cz;
        }
        public string En { get; private set; }
        public string Cz { get; private set; }

        public string GetText(Language.LanguageEnum lng)
        {
            var sText = "";
            switch (lng)
            {
                case Language.LanguageEnum.Cz:
                    sText = Cz;
                    break;
                case Language.LanguageEnum.En:
                    sText = En;
                    break;
            }

            if (sText.Length == 0) sText = Cz;
            return sText;
        }
        public override string ToString()
        {
            return En;
        }
    }
}