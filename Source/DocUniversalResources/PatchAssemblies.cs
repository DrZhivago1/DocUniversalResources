using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Threading.Tasks;
using RimWorld;
using HarmonyLib;
using Verse;


namespace DocUniversalResources
{
    [HarmonyPatch]
    public static class Patch
    {

        public static Dictionary<string, string> replacedDefNames = new Dictionary<string, string>();

        public static MethodInfo TargetMethod()
        {
            return AccessTools.Method(typeof(DefDatabase<ThingDef>), "GetNamed");
        }

        public static void Prefix(ref string defName)
        {
            if (replacedDefNames.TryGetValue(defName, out var myReplacementDefName))
            {
                defName = myReplacementDefName;
            }
        }

    }

    public static class XmlParser
    {
        public static void CollectXmlData()
        {
            foreach (DirectoryInfo dir in ModLister.AllActiveModDirs)
            {
                var xmlFiles = dir.GetFiles("AssemblyResourceReplacer.xml");
                if (xmlFiles.Length != 0)
                {
                    foreach (var file in xmlFiles)
                    {
                        // load our xml file
                        var doc = new XmlDocument();
                        doc.Load(file.OpenRead());

                        // parse our doc
                        Parse(doc);
                    }
                }
            }

        }

        private static void Parse(XmlDocument doc)
        {
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string value = null;
                List<string> keys = new List<string>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name.ToLower() == "value")
                    {
                        value = child.InnerText;
                    }
                    else if (child.Name.ToLower() == "keys")
                    {
                        foreach (XmlNode childNode in child.ChildNodes)
                        {
                            keys.Add(childNode.InnerText);
                        }
                    }
                }
                foreach (var key in keys)
                {
                    Patch.replacedDefNames.Add(key, value);
                }
            }
        }

    }

}
