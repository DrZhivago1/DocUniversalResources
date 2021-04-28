using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using HarmonyLib;
using System.Reflection;

namespace DocUniversalResources
{
    [StaticConstructorOnStartup]
    public class MainHarmonyInstance : Mod
    {
        public MainHarmonyInstance(ModContentPack content) : base(content)
        {
            Log.Message(string.Format("[DUR] Check"));
            var harmony = new Harmony("drzhivago.docuniversalresources.harmony");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(BackCompatibility), "BackCompatibleDefName")]
    public static class BackCompatibility_BackCompatibleDefName_Patch
    {
        [HarmonyPostfix]
        public static void BackCompatibleDefName_Postfix(Type defType, string defName, ref string __result)
        {
            if (GenDefDatabase.GetDefSilentFail(defType, defName, false) == null)
            {
                string newName = string.Empty;
                // Log.Message(string.Format("Checking for replacement for {0} Type: {1}", defName, defType));

                if (defType == typeof(ThingDef))
                {
                    //  ==================
                    //      Metal
                    //  ==================
                    if (defName == "Adamantite" || defName == "WoW_adamantite")
                    {
                        newName = "DZ_Adamantite";
                    }

                    if (defName == "Ind_Aluminium" || defName == "CAL_Aluminum")
                    {
                        newName = "DZ_Aluminum";
                    }

                    if (defName == "CaS_Brass" || defName == "CAL_Brass")
                    {
                        newName = "DZ_Brass";
                    }

                    if (defName == "Bronze" || defName == "CaS_Bronze" || defName == "CAL_Bronze" || defName == "VMEu_Bronze")
                    {
                        newName = "DZ_Bronze";
                    }

                    if (defName == "CAL_Chromium" || defName == "VMEu_Chromium")
                    {
                        newName = "DZ_Chromium";
                    }

                    if (defName == "Ind_Copper" || defName == "CaS_Copper" || defName == "Copper" || defName == "CAL_Copper" || defName == "PRF_Copper" || defName == "VMEu_Copper")
                    {
                        newName = "DZ_Copper";
                    }

                    if (defName == "Iron" || defName == "Owl_Iron" || defName == "NECIron" || defName == "PRF_Iron" || defName == "VMEu_Iron")
                    {
                        newName = "DZ_Iron";
                    }

                    if (defName == "CAL_Lead" || defName == "VMEu_Lead")
                    {
                        newName = "DZ_Lead";
                    }

                    if (defName == "Mithril" || defName == "WoW_mithril" || defName == "LotR_Mithril")
                    {
                        newName = "DZ_Mithril";
                    }

                    if (defName == "Ind_HighGradeSteel" || defName == "CAL_StainlessSteel" || defName == "PRF_StainlessSteel" || defName == "VMEu_StainlessSteel")
                    {
                        newName = "DZ_StainlessSteel";
                    }

                    if (defName == "Tin" || defName == "CaS_Tin" || defName == "CAL_Tin" || defName == "VMEu_Tin")
                    {
                        newName = "DZ_Tin";
                    }

                    if (defName == "Titanium" || defName == "VMEu_Titanium")
                    {
                        newName = "DZ_Titanium";
                    }

                    if (defName == "Tungsten" || defName == "VMEu_Tungsten")
                    {
                        newName = "DZ_Tungsten";
                    }

                    if (defName == "CAL_Zinc" || defName == "CaS_Zinc")
                    {
                        newName = "DZ_Zinc";
                    }
                    //  ==================
                    //      Stone_Block
                    //  ==================
                    //  ==================
                    //      Stone_Ore
                    //  ==================
                    if (defName == "MineableAdamantite" || defName == "WoW_adamantite_deposit")
                    {
                        newName = "DZ_AdamantiteOre";
                    }

                    if (defName == "Ind_MineableAluminium" || defName == "CAL_MineableBauxite")
                    {
                        newName = "DZ_AluminumOre";
                    }

                    if (defName == "CAL_MineableChromite")
                    {
                        newName = "DZ_ChromiumOre";
                    }

                    if (defName == "MineableCoalOre" || defName == "WDMineableCoal" || defName == "CaS_MineableCoal" || defName == "VMEu_MineableCoal" || defName == "MineableCoal" || defName == "PRF_MineableCoal" || defName == "RH_TET_MineableCoal")
                    {
                        newName = "DZ_CoalOre";
                    }

                    if (defName == "Ind_MineableCopper" || defName == "CaS_MineableCopper" || defName == "MineableCopper" || defName == "CAL_MineableMalachite" || defName == "PRF_MineableCopper" || defName == "VMEu_MineableCopper")
                    {
                        newName = "DZ_CopperOre";
                    }

                    if (defName == "Owl_Iron" || defName == "NECIron" || defName == "MineableIron" || defName == "PRF_MineableIron" || defName == "VMEu_MineableIron")
                    {
                        newName = "DZ_IronOre";
                    }

                    if (defName == "CAL_MineableGalena" || defName == "VMEu_MineableLead")
                    {
                        newName = "DZ_LeadOre";
                    }

                    if (defName == "MineableMithril" || defName == "WoW_mithril_deposit")
                    {
                        newName = "DZ_MithrilOre";
                    }

                    if (defName == "CaS_MineableTin" || defName == "MineableTin" || defName == "CAL_MineableCassiterite" || defName == "VMEu_MineableTin")
                    {
                        newName = "DZ_TinOre";
                    }

                    if (defName == "MineableTitanium" || defName == "VMEu_Titanium")
                    {
                        newName = "DZ_TitaniumOre";
                    }

                    if (defName == "MineableTungsten" || defName == "VMEu_Titanium")
                    {
                        newName = "DZ_TungstenOre";
                    }

                    if (defName == "CaS_MineableZinc" || defName == "CAL_MineableSphalerite")
                    {
                        newName = "DZ_ZincOre";
                    }
                    //  ==================
                    //      Synthetic
                    //  ==================
                    if (defName == "SadjuukGlass" || defName == "Glass" || defName == "GlassPane" || defName == "PRF_Glass" || defName == "AM_Glass")
                    {
                        newName = "DZ_Glass";
                    }
                }

                if (!newName.NullOrEmpty())
                {
                    __result = newName;
                }

            }
        }
    }

}