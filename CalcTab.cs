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
            int PassiveGroup2_Amount = 2; //Bee Cat Chicken Fish Cow Fox Horses Llama Mooshroom Ocelot Panda Parrot Pig PolarBear Rabbit Sheep Squid Dolphin Turtle Wolf GlowSquid Goat (1-3)
            int MonstersGroup1_Amount = 3; //Endermite (3)
            int MonstersGroup2_Amount = 5; //CaveSpider Creeper Drowned Enderman Ghast Hoglin Husk Illusioner Phantom Piglin Pillager Shulker Silverfish Skeleton Spider Stray Vex Vindicator Witch WitherSkeleton Zombie ZombieVillager Zoglin ZombifiedPiglin (5 Ignoring armour)
            int MonstersGroup3_Amount = 10; //Blaze Evoker ElderGuardian Guardian (10)
            int MonstersGroup4_Amount = 20; //Ravager PiglinBrute (20)
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
            PassiveGroup1 = (int)Math.Ceiling(PassiveGroup1);
            PassiveGroup2 = (int)Math.Ceiling(PassiveGroup2);
            MonstersGroup1 = (int)Math.Ceiling(MonstersGroup1);
            MonstersGroup2 = (int)Math.Ceiling(MonstersGroup2);
            MonstersGroup3 = (int)Math.Ceiling(MonstersGroup3);
            MonstersGroup4 = (int)Math.Ceiling(MonstersGroup4);
            BabyMonsters = (int)Math.Ceiling(BabyMonsters);
            LargeCubicMobs = (int)Math.Ceiling(LargeCubicMobs);
            MediumCubicMobs = (int)Math.Ceiling(MediumCubicMobs);
            SmallCubicMobs = (int)Math.Ceiling(SmallCubicMobs);
            EnderDragon = (int)Math.Ceiling(EnderDragon);
            Wither = (int)Math.Ceiling(Wither);

            MiningGroup1 = (int)Math.Ceiling(MiningGroup1);
            MiningGroup2 = (int)Math.Ceiling(MiningGroup2);
            MiningGroup3 = (int)Math.Ceiling(MiningGroup3);
            MiningGroup4 = (int)Math.Ceiling(MiningGroup4);
            MiningGroup5 = (int)Math.Ceiling(MiningGroup5);
            MiningGroup6 = (int)Math.Ceiling(MiningGroup6);

            SmeltingGroup1 = (int)Math.Ceiling(SmeltingGroup1);
            SmeltingGroup2 = (int)Math.Ceiling(SmeltingGroup2);
            SmeltingGroup3 = (int)Math.Ceiling(SmeltingGroup3);
            SmeltingGroup4 = (int)Math.Ceiling(SmeltingGroup4);
            SmeltingGroup5 = (int)Math.Ceiling(SmeltingGroup5);
            SmeltingGroup6 = (int)Math.Ceiling(SmeltingGroup6);
            SmeltingGroup7 = (int)Math.Ceiling(SmeltingGroup7);
            SmeltingGroup8 = (int)Math.Ceiling(SmeltingGroup8);

            BottleoEnchanting = (int)Math.Ceiling(BottleoEnchanting);
            VillagerTrade = (int)Math.Ceiling(VillagerTrade);
            AnimalBreeding = (int)Math.Ceiling(AnimalBreeding);
            Fishing = (int)Math.Ceiling(Fishing);

            //set labels and turns visable
            lblpassivegroup1.Text = PassiveGroup1.ToString();
            lblpassivegroup1.Visible = true;
            lblpassivegroup2.Text = PassiveGroup2.ToString();
            lblpassivegroup2.Visible = true;
            lblmonstersgroup1.Text = MonstersGroup1.ToString();
            lblmonstersgroup1.Visible = true;
            lblmonstersgroup2.Text = MonstersGroup2.ToString();
            lblmonstersgroup2.Visible = true;
            lblmonstersgroup3.Text = MonstersGroup3.ToString();
            lblmonstersgroup3.Visible = true;
            lblmonstersgroup4.Text = MonstersGroup4.ToString();
            lblmonstersgroup4.Visible = true;
            lblbabymonsters.Text = BabyMonsters.ToString();
            lblbabymonsters.Visible = true;
            lbllargecubicmobs.Text = LargeCubicMobs.ToString();
            lbllargecubicmobs.Visible = true;
            lblmediumcubicmobs.Text = MediumCubicMobs.ToString();
            lblmediumcubicmobs.Visible = true;
            lblsmallcubicmobs.Text = SmallCubicMobs.ToString();
            lblsmallcubicmobs.Visible = true;
            lblenderdragon.Text = EnderDragon.ToString();
            lblenderdragon.Visible = true;
            lblwither.Text = Wither.ToString();
            lblwither.Visible = true;

            lblmininggroup1.Text = MiningGroup1.ToString();
            lblmininggroup1.Visible = true;
            lblmininggroup2.Text = MiningGroup2.ToString();
            lblmininggroup2.Visible = true;
            lblmininggroup3.Text = MiningGroup3.ToString();
            lblmininggroup3.Visible = true;
            lblmininggroup4.Text = MiningGroup4.ToString();
            lblmininggroup4.Visible = true;
            lblmininggroup5.Text = MiningGroup5.ToString();
            lblmininggroup5.Visible = true;
            lblmininggroup6.Text = MiningGroup6.ToString();
            lblmininggroup6.Visible = true;

            lblsmeltinggroup1.Text = SmeltingGroup1.ToString();
            lblsmeltinggroup1.Visible = true;
            lblsmeltinggroup2.Text = SmeltingGroup2.ToString();
            lblsmeltinggroup2.Visible = true;
            lblsmeltinggroup3.Text = SmeltingGroup3.ToString();
            lblsmeltinggroup3.Visible = true;
            lblsmeltinggroup4.Text = SmeltingGroup4.ToString();
            lblsmeltinggroup4.Visible = true;
            lblsmeltinggroup5.Text = SmeltingGroup5.ToString();
            lblsmeltinggroup5.Visible = true;
            lblsmeltinggroup6.Text = SmeltingGroup6.ToString();
            lblsmeltinggroup6.Visible = true;
            lblsmeltinggroup7.Text = SmeltingGroup7.ToString();
            lblsmeltinggroup7.Visible = true;
            lblsmeltinggroup8.Text = SmeltingGroup8.ToString();
            lblsmeltinggroup8.Visible = true;

            lblbottleoenchanting.Text = BottleoEnchanting.ToString();
            lblbottleoenchanting.Visible = true;
            lblvillagertrade.Text = VillagerTrade.ToString();
            lblvillagertrade.Visible = true;
            lblanimalbreeding.Text = AnimalBreeding.ToString();
            lblanimalbreeding.Visible = true;
            lblfishing.Text = Fishing.ToString();
            lblfishing.Visible = true;

            lblcalculatedxp.Text = calculatedxp.ToString();
            lblcalculatedxp.Visible = true;
            label14.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
