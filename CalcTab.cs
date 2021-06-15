using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftXPCalculatorGUI
{
    public partial class CalcTab : Form
    {
        public CalcTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level;//TODO: Just make all this on a panel and info on other panel.
            int levelsquared;
            double calculatedxp;

            //Killing
            double PassiveGroup1_Amount = 1.5; //Strider (1-2)
            int PassiveGroup2_Amount = 2; //Bee Cat Chicken Fish Cow Fox Horses Llama Mooshroom Ocelot Panda Parrot Pig PolarBear Rabbit Sheep Squid Dolphin Turtle Wolf (1-3)
            int MonstersGroup1_Amount = 3; //Endermite (3)
            int MonstersGroup2_Amount = 5; //CaveSpider Creeper Drowned Enderman Ghast Hoglin Husk Illusioner Phantom Piglin Pillager Shulker Silverfish Skeleton Spider Stray Vex Vindicator Witch WitherSkeleton Zombie ZombieVillager Zoglin ZombifiedPiglin (5 Ignoring armour)
            int MonstersGroup3_Amount = 10; //Blaze Evoker ElderGuardian Guardian (10)
            int MonstersGroup4_Amount = 20; //Ravager PiglinBrute
            int BabyMonsters_Amount = 12; //BabyHusk BabyDrowned BabyZombie BabyZombifiedPiglin BabyZombieVillager (12 Ignoring armour)
            int LargeCubicMobs_Amount = 4; //LargeSlime LargeMagmaCube (4)
            int MediumCubicMobs_Amount = 2; //MediumSlime MediumMagmaCube (2)
            int SmallCubicMobs_Amount = 1; //SmallSlime SmallMagmaCube (1)
            int EnderDragon_Amount = 500; //EnderDragon (500 Unless it's the first dragon in which case it's 12000)
            int Wither_Amount = 50; //Wither (50)
            //Mining
            double MiningGroup1_Amount = 0.5; //NetherGoldOre (0-1)
            int MiningGroup2_Amount = 1; //CoalOre (0-2)
            int MiningGroup3_Amount = 3; //RedstoneOre (1-5)
            double MiningGroup4_Amount = 3.5; //LapisLazuliOre NetherQuartzOre (2-5)
            int MiningGroup5_Amount = 5; //DiamondOre EmeraldOre (3-7)
            int MiningGroup6_Amount = 29; //MobSpawner (15-43)
            //Smelting and cooking
            int SmeltingGroup1_Amount = 2; //AncientDebris (2)
            int SmeltingGroup2_Amount = 1; //Cactus DiamondOre EmeraldOre GoldOre NetherGoldOre (1)
            double SmeltingGroup3_Amount = 0.7; //IronOre RedstoneOre (0.7)
            double SmeltingGroup4_Amount = 0.35; //ClayBlock Potato Beef Chicken Cod Mutton Porkchop Rabbit Salmon (0.35)
            double SmeltingGroup5_Amount = 0.3; //ClayBall (0.3)
            double SmeltingGroup6_Amount = 0.2; //LapisLazuliOre NetherQuartzOre (0.2)
            double SmeltingGroup7_Amount = 0.15; //WetSponge Wood (0.15)
            double SmeltingGroup8_Amount = 0.1; //ChorusFruit CoalOre Cobblestone Stone DyedTerracotta Netherrack Sand StoneBricks Iron, Gold, Chainmail Gear IronHorseArmour GoldHorseArmour Kelp (0.1)
            //Other
            int BottleoEnchanting_Amount = 7; //Bottle o' Enchanting (3-11)
            double VillagerTrade_Amount = 4.5; //Villager trades (3-6 Unless the villagers are willing to breed then it's 8-11)
            int AnimalBreeding_Amount = 4; //Breeding any mob (1-7)
            double Fishing_Amount = 3.5; //Catching any item (1-6)


            bool isParsable = Int32.TryParse(textBox1.Text, out level);
            if (isParsable)
                lbldebug.Text = "Parse succeeded"; //TODO: Make only calculate and update labels if parse succeeds when not lazy
            else
                lbldebug.Text = ("Could not be parsed.");

            //Math for xp needed for set level
            //Note: this only works for level 31+ so there needs to be something to catch levels lower than 31 and deal with it but i'm lazy
            levelsquared = level * level;
            calculatedxp = 4.5 * levelsquared - 162.5 * level + 2220;

            double PassiveGroup1 = calculatedxp / PassiveGroup1_Amount;
            double PassiveGroup2 = calculatedxp / PassiveGroup2_Amount;
            double MonstersGroup1 = calculatedxp / MonstersGroup1_Amount;
            double MonstersGroup2 = calculatedxp / MonstersGroup2_Amount;
            double MonstersGroup3 = calculatedxp / MonstersGroup3_Amount;
            double MonstersGroup4 = calculatedxp / MonstersGroup4_Amount;
            double BabyMonsters = calculatedxp / BabyMonsters_Amount;
            double LargeCubicMobs = calculatedxp / LargeCubicMobs_Amount;
            double MediumCubicMobs = calculatedxp / MediumCubicMobs_Amount;
            double SmallCubicMobs = calculatedxp / SmallCubicMobs_Amount;
            double EnderDragon = calculatedxp / EnderDragon_Amount;
            double Wither = calculatedxp / Wither_Amount;

            double MiningGroup1 = calculatedxp / MiningGroup1_Amount;
            double MiningGroup2 = calculatedxp / MiningGroup2_Amount;
            double MiningGroup3 = calculatedxp / MiningGroup3_Amount;
            double MiningGroup4 = calculatedxp / MiningGroup4_Amount;
            double MiningGroup5 = calculatedxp / MiningGroup5_Amount;
            double MiningGroup6 = calculatedxp / MiningGroup6_Amount;

            double SmeltingGroup1 = calculatedxp / SmeltingGroup1_Amount;
            double SmeltingGroup2 = calculatedxp / SmeltingGroup2_Amount;
            double SmeltingGroup3 = calculatedxp / SmeltingGroup3_Amount;
            double SmeltingGroup4 = calculatedxp / SmeltingGroup4_Amount;
            double SmeltingGroup5 = calculatedxp / SmeltingGroup5_Amount;
            double SmeltingGroup6 = calculatedxp / SmeltingGroup6_Amount;
            double SmeltingGroup7 = calculatedxp / SmeltingGroup7_Amount;
            double SmeltingGroup8 = calculatedxp / SmeltingGroup8_Amount;

            double BottleoEnchanting = calculatedxp / BottleoEnchanting_Amount;
            double VillagerTrade = calculatedxp / VillagerTrade_Amount;
            double AnimalBreeding = calculatedxp / AnimalBreeding_Amount;
            double Fishing = calculatedxp / Fishing_Amount;

            //Round up to nearest integer because you can't do only a fraction of an action
            double PassiveGroup1_Ceil = Math.Ceiling(PassiveGroup1);
            double PassiveGroup2_Ceil = Math.Ceiling(PassiveGroup2);
            double MonstersGroup1_Ceil = Math.Ceiling(MonstersGroup1);
            double MonstersGroup2_Ceil = Math.Ceiling(MonstersGroup2);
            double MonstersGroup3_Ceil = Math.Ceiling(MonstersGroup3);
            double MonstersGroup4_Ceil = Math.Ceiling(MonstersGroup4);
            double BabyMonsters_Ceil = Math.Ceiling(BabyMonsters);
            double LargeCubicMobs_Ceil = Math.Ceiling(LargeCubicMobs);
            double MediumCubicMobs_Ceil = Math.Ceiling(MediumCubicMobs);
            double SmallCubicMobs_Ceil = Math.Ceiling(SmallCubicMobs);
            double EnderDragon_Ceil = Math.Ceiling(EnderDragon);
            double Wither_Ceil = Math.Ceiling(Wither);

            double MiningGroup1_Ceil = Math.Ceiling(MiningGroup1);
            double MiningGroup2_Ceil = Math.Ceiling(MiningGroup2);
            double MiningGroup3_Ceil = Math.Ceiling(MiningGroup3);
            double MiningGroup4_Ceil = Math.Ceiling(MiningGroup4);
            double MiningGroup5_Ceil = Math.Ceiling(MiningGroup5);
            double MiningGroup6_Ceil = Math.Ceiling(MiningGroup6);

            double SmeltingGroup1_Ceil = Math.Ceiling(SmeltingGroup1);
            double SmeltingGroup2_Ceil = Math.Ceiling(SmeltingGroup2);
            double SmeltingGroup3_Ceil = Math.Ceiling(SmeltingGroup3);
            double SmeltingGroup4_Ceil = Math.Ceiling(SmeltingGroup4);
            double SmeltingGroup5_Ceil = Math.Ceiling(SmeltingGroup5);
            double SmeltingGroup6_Ceil = Math.Ceiling(SmeltingGroup6);
            double SmeltingGroup7_Ceil = Math.Ceiling(SmeltingGroup7);
            double SmeltingGroup8_Ceil = Math.Ceiling(SmeltingGroup8);

            double BottleoEnchanting_Ceil = Math.Ceiling(BottleoEnchanting);
            double VillagerTrade_Ceil = Math.Ceiling(VillagerTrade);
            double AnimalBreeding_Ceil = Math.Ceiling(AnimalBreeding);
            double Fishing_Ceil = Math.Ceiling(Fishing);

            //Convertion of finals to be used with labels
            string strcalculatedxp = calculatedxp.ToString();
            string strpassivegroup1 = PassiveGroup1_Ceil.ToString();
            string strpassivegroup2 = PassiveGroup2_Ceil.ToString();
            string strmonstersgroup1 = MonstersGroup1_Ceil.ToString();
            string strmonstersgroup2 = MonstersGroup2_Ceil.ToString();
            string strmonstersgroup3 = MonstersGroup3_Ceil.ToString();
            string strmonstersgroup4 = MonstersGroup4_Ceil.ToString();
            string strbabymonsters = BabyMonsters_Ceil.ToString();
            string strlargecubicmobs = LargeCubicMobs_Ceil.ToString();
            string strmediumcubicmobs = MediumCubicMobs_Ceil.ToString();
            string strsmallcubicmobs = SmallCubicMobs_Ceil.ToString();
            string strenderdragon = EnderDragon_Ceil.ToString();
            string strwither = Wither_Ceil.ToString();

            string strmininggroup1 = MiningGroup1_Ceil.ToString();//TODO: Create and implement icons/labels for the rest of the sources.
            string strmininggroup2 = MiningGroup2_Ceil.ToString();
            string strmininggroup3 = MiningGroup3_Ceil.ToString();
            string strmininggroup4 = MiningGroup4_Ceil.ToString();
            string strmininggroup5 = MiningGroup5_Ceil.ToString();
            string strmininggroup6 = MiningGroup6_Ceil.ToString();

            string strsmeltinggroup1 = SmeltingGroup1_Ceil.ToString();
            string strsmeltinggroup2 = SmeltingGroup2_Ceil.ToString();
            string strsmeltinggroup3 = SmeltingGroup3_Ceil.ToString();
            string strsmeltinggroup4 = SmeltingGroup4_Ceil.ToString();
            string strsmeltinggroup5 = SmeltingGroup5_Ceil.ToString();
            string strsmeltinggroup6 = SmeltingGroup6_Ceil.ToString();
            string strsmeltinggroup7 = SmeltingGroup7_Ceil.ToString();
            string strsmeltinggroup8 = SmeltingGroup8_Ceil.ToString();

            string strbottleoenchanting = BottleoEnchanting_Ceil.ToString();
            string strvillagertrade = VillagerTrade_Ceil.ToString();
            string stranimalbreeding = AnimalBreeding_Ceil.ToString();
            string strfishing = Fishing_Ceil.ToString();

            //set labels and turns visable
            lblpassivegroup1.Text = strpassivegroup1;
            lblpassivegroup1.Visible = true;
            lblpassivegroup2.Text = strpassivegroup2;
            lblpassivegroup2.Visible = true;
            lblmonstersgroup1.Text = strmonstersgroup1;
            lblmonstersgroup1.Visible = true;
            lblmonstersgroup2.Text = strmonstersgroup2;
            lblmonstersgroup2.Visible = true;
            lblmonstersgroup3.Text = strmonstersgroup3;
            lblmonstersgroup3.Visible = true;
            lblmonstersgroup4.Text = strmonstersgroup4;
            lblmonstersgroup4.Visible = true;
            lblbabymonsters.Text = strbabymonsters;
            lblbabymonsters.Visible = true;
            lbllargecubicmobs.Text = strlargecubicmobs;
            lbllargecubicmobs.Visible = true;
            lblmediumcubicmobs.Text = strmediumcubicmobs;
            lblmediumcubicmobs.Visible = true;
            lblsmallcubicmobs.Text = strsmallcubicmobs;
            lblsmallcubicmobs.Visible = true;
            lblenderdragon.Text = strenderdragon;
            lblenderdragon.Visible = true;
            lblwither.Text = strwither;
            lblwither.Visible = true;

            lblmininggroup1.Text = strmininggroup1;
            lblmininggroup1.Visible = true;
            lblmininggroup2.Text = strmininggroup2;
            lblmininggroup2.Visible = true;
            lblmininggroup3.Text = strmininggroup3;
            lblmininggroup3.Visible = true;
            lblmininggroup4.Text = strmininggroup4;
            lblmininggroup4.Visible = true;
            lblmininggroup5.Text = strmininggroup5;
            lblmininggroup5.Visible = true;
            lblmininggroup6.Text = strmininggroup6;
            lblmininggroup6.Visible = true;

            lblsmeltinggroup1.Text = strsmeltinggroup1;
            lblsmeltinggroup1.Visible = true;
            lblsmeltinggroup2.Text = strsmeltinggroup2;
            lblsmeltinggroup2.Visible = true;
            lblsmeltinggroup3.Text = strsmeltinggroup3;
            lblsmeltinggroup3.Visible = true;
            lblsmeltinggroup4.Text = strsmeltinggroup4;
            lblsmeltinggroup4.Visible = true;
            lblsmeltinggroup5.Text = strsmeltinggroup5;
            lblsmeltinggroup5.Visible = true;
            lblsmeltinggroup6.Text = strsmeltinggroup6;
            lblsmeltinggroup6.Visible = true;
            lblsmeltinggroup7.Text = strsmeltinggroup7;
            lblsmeltinggroup7.Visible = true;
            lblsmeltinggroup8.Text = strsmeltinggroup8;
            lblsmeltinggroup8.Visible = true;

            lblbottleoenchanting.Text = strbottleoenchanting;
            lblbottleoenchanting.Visible = true;
            lblvillagertrade.Text = strvillagertrade;
            lblvillagertrade.Visible = true;
            lblanimalbreeding.Text = stranimalbreeding;
            lblanimalbreeding.Visible = true;
            lblfishing.Text = strfishing;
            lblfishing.Visible = true;

            lblcalculatedxp.Text = strcalculatedxp;
            lblcalculatedxp.Visible = true;
            label14.Visible = true;
        }
    }
}
