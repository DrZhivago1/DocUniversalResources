using System;
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
                    //      Condiments
                    //  ==================
                    if (defName == "RC2_AgaveNectar" || defName == "VCE_AgaveNectar")
                    {
                        newName = "DZ_AgaveNectar";
                    }

                    if (defName == "RC2_Flour" || defName == "Flour" || defName == "VCE_Flour")
                    {
                        newName = "DZ_Flour";
                    }

                    if (defName == "Honey" || defName == "RC2_Honey" || defName == "RB_BaseHoney")
                    {
                        newName = "DZ_Honey";
                    }

                    if (defName == "VCE_SmokeleafButter" || defName == "VCE_SmokeleafButter")
                    {
                        newName = "DZ_SmokeleafButter";
                    }

                    if (defName == "RC2_Sugar" || defName == "Sugar" || defName == "VCE_RawSugar")
                    {
                        newName = "DZ_Sugar";
                    }

                    if (defName == "RC2_Tofu" || defName == "Rawtofu")
                    {
                        newName = "DZ_Tofu";
                    }
                    //  ==================
                    //      Earthy
                    //  ==================
                    if (defName == "AdobeRaw" || defName == "VBY_ClayPaste" || defName == "AM_RawMud" || defName == "N7_RawMudbrick")
                    {
                        newName = "DZ_Adobe";
                    }

                    if (defName == "D9Cement" || defName == "RFFCement" || defName == "PRF_Cement")
                    {
                        newName = "DZ_Cement";
                    }

                    if (defName == "Charcoal" || defName == "CharCoalOre" || defName == "SRV_Charcoal" || defName == "AYCharcoal" || defName == "VMEu_Charcoal")
                    {
                        newName = "DZ_Charcoal";
                    }

                    if (defName == "AM_RawClay" || defName == "N7_RawClay" || defName == "PRF_RawClay" || defName == "RFFClay")
                    {
                        newName = "DZ_Clay";
                    }

                    if (defName == "MedTimes_Resource_Coal" || defName == "CoalOre" || defName == "AM_Coal" || defName == "CaS_Coal" || defName == "WDCoal" || defName == "Coal" || defName == "RH_TET_Coal" || defName == "SB_coal_ore" || defName == "PRF_Coal" || defName == "VMEu_Coal")
                    {
                        newName = "DZ_Coal";
                    }

                    if (defName == "AM_CokeCoal" || defName == "PRF_Coke")
                    {
                        newName = "DZ_CoalCoke";
                    }

                    if (defName == "AC_RawCompost" || defName == "RF_Compost" || defName == "RPC_Compost" || defName == "AYCompost" || defName == "VG_Compost" || defName == "RawCompost")
                    {
                        newName = "DZ_Compost";
                    }

                    if (defName == "CrushedRocks" || defName == "VMEu_RockPowder")
                    {
                        newName = "DZ_CrushedRock";
                    }

                    if (defName == "AC_Fertilizer" || defName == "RawFertilizer" || defName == "Fertilizer")
                    {
                        newName = "DZ_Fertilizer";
                    }

                    if (defName == "PRF_Fossil" || defName == "VMEu_Fossil")
                    {
                        newName = "DZ_Fossil";
                    }

                    if (defName == "AM_CrudeOil" || defName == "OilBarrel" || defName == "PRF_Oil" || defName == "VMEu_DarkOil")
                    {
                        newName = "DZ_Oil";
                    }

                    if (defName == "RawCotton")
                    {
                        newName = "DZ_RawCotton";
                    }

                    if (defName == "RawDevilstrand")
                    {
                        newName = "DZ_RawDevilstrand";
                    }

                    if (defName == "RWF_Salt" || defName == "RimSeasoning_Salt" || defName == "AYSalt" || defName == "ChunkSalt" || defName == "VCE_Salt")
                    {
                        newName = "DZ_Salt";
                    }

                    if (defName == "AM_RawSand" || defName == "N7_Sand" || defName == "PRF_RawSand" || defName == "SandPile")
                    {
                        newName = "DZ_Sand";
                    }
                    //  ==================
                    //      Fruit/Veggie
                    //  ==================
                    if (defName == "RC2_RawApples" || defName == "Rawapple" || defName == "VCE_RawApple")
                    {
                        newName = "DZ_RawApple";
                    }

                    if (defName == "RC2_RawBanana" || defName == "Rawbanana" || defName == "VCE_RawBanana")
                    {
                        newName = "DZ_RawBanana";
                    }

                    if (defName == "RC2_RawBarley" || defName == "RawBarley")
                    {
                        newName = "DZ_RawBarley";
                    }

                    if (defName == "RC2_RawBeets" || defName == "Rawsnowbeet" || defName == "VCE_RawBeets")
                    {
                        newName = "DZ_RawBeet";
                    }

                    if (defName == "RawBlueberries" || defName == "Rawblueberry")
                    {
                        newName = "DZ_RawBlueberry";
                    }

                    if (defName == "RC2_RawCabbages" || defName == "VCE_Cabbage")
                    {
                        newName = "DZ_RawCabbage";
                    }

                    if (defName == "RC2_RawCactusFruit" || defName == "RawCactusFruit" || defName == "VCE_RawPricklyPear")
                    {
                        newName = "DZ_RawCactusFruit";
                    }

                    if (defName == "RC2_RawCarrots" || defName == "RawCarrots")
                    {
                        newName = "DZ_RawCarrot";
                    }

                    if (defName == "RC2_RawCherries" || defName == "RawCherry" || defName == "VCE_RawCherry")
                    {
                        newName = "DZ_RawCherry";
                    }

                    if (defName == "RC2_RawCocoaBeans" || defName == "RawCocoaBeans")
                    {
                        newName = "DZ_RawCocoaBean";
                    }

                    if (defName == "RC2_RawCoconut" || defName == "RawCoconut")
                    {
                        newName = "DZ_RawCoconut";
                    }

                    if (defName == "RC2_RawCoffeeBeans" || defName == "CPD_CoffeeBeans")
                    {
                        newName = "DZ_RawCoffeeBean";
                    }

                    if (defName == "RC2_RawEggplants" || defName == "Raweggplant" || defName == "VCE_RawEggplant")
                    {
                        newName = "DZ_RawEggplant";
                    }

                    if (defName == "RC2_RawFigs" || defName == "Rawfig")
                    {
                        newName = "DZ_RawFig";
                    }

                    if (defName == "RC2_RawGrapes" || defName == "Rawgrape" || defName == "VFEM_RawGrapes")
                    {
                        newName = "DZ_RawGrape";
                    }

                    if (defName == "RC2_RawOnion" || defName == "VCE_RawOnion")
                    {
                        newName = "DZ_RawOnion";
                    }

                    if (defName == "RC2_RawOrange" || defName == "Raworange" || defName == "VCE_RawOrange")
                    {
                        newName = "DZ_RawOrange";
                    }

                    if (defName == "RC2_RawSnapPeas" || defName == "VCE_RawPeas")
                    {
                        newName = "DZ_RawPea";
                    }

                    if (defName == "RC2_RawPeaches" || defName == "Rawpeach" || defName == "VCE_RawPeach")
                    {
                        newName = "DZ_RawPeach";
                    }

                    if (defName == "RC2_RawPeppers" || defName == "VCE_RawPepper")
                    {
                        newName = "DZ_RawPepper";
                    }

                    if (defName == "RC2_RawPineapples" || defName == "Rawpineapple")
                    {
                        newName = "DZ_RawPineapple";
                    }

                    if (defName == "RC2_RawPlums" || defName == "VCE_RawPlum")
                    {
                        newName = "DZ_RawPlum";
                    }

                    if (defName == "RC2_RawPumpkins" || defName == "Rawpumpkin" || defName == "VCE_RawPumpkin")
                    {
                        newName = "DZ_RawPumpkin";
                    }

                    if (defName == "RC2_RawSugarcane" || defName == "Rawsugarcane")
                    {
                        newName = "DZ_RawSugarcane";
                    }

                    if (defName == "RC2_RawTeaLeaves" || defName == "Rawtea")
                    {
                        newName = "DZ_RawTeaLeaf";
                    }

                    if (defName == "RC2_RawTomato" || defName == "RawTomatoes" || defName == "VCE_RawTomatoes")
                    {
                        newName = "DZ_RawTomato";
                    }

                    if (defName == "RC2_RawWheat" || defName == "Rawwheat")
                    {
                        newName = "DZ_RawWheat";
                    }
                    //  ==================
                    //      Gemstone
                    //  ==================
                    if (defName == "Amethyst" || defName == "KAmethyst" || defName == "Z_Amethyst")
                    {
                        newName = "DZ_Amethyst";
                    }

                    if (defName == "Diamond" || defName == "PRF_RawDiamond" || defName == "KDiamond" || defName == "Z_Diamond")
                    {
                        newName = "DZ_Diamond";
                    }

                    if (defName == "Emerald" || defName == "KEmerald" || defName == "Z_Emerald")
                    {
                        newName = "DZ_Emerald";
                    }

                    if (defName == "KGarnet" || defName == "Z_Garnet")
                    {
                        newName = "DZ_Garnet";
                    }

                    if (defName == "LapisLazuli" || defName == "Z_Lapis")
                    {
                        newName = "DZ_LapisLazuli";
                    }

                    if (defName == "Peridot" || defName == "KPeridot")
                    {
                        newName = "DZ_Peridot";
                    }

                    if (defName == "Quartz" || defName == "PRF_quartz" || defName == "KQuartz" || defName == "Z_Quartz")
                    {
                        newName = "DZ_Quartz";
                    }

                    if (defName == "Ruby" || defName == "CaS_Ruby" || defName == "KRuby" || defName == "Z_Ruby")
                    {
                        newName = "DZ_Ruby";
                    }

                    if (defName == "Sapphire" || defName == "CaS_Sapphire" || defName == "KSapphire" || defName == "Z_Sapphire")
                    {
                        newName = "DZ_Sapphire";
                    }

                    if (defName == "Turquoise" || defName == "Z_Turquoise")
                    {
                        newName = "DZ_Turquoise";
                    }
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