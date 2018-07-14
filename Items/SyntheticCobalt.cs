using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsRecipeMod.Items
{
	public class SyntheticCobalt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Synthetic Cobalt");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 24;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Handgun);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AquaScepter);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicMissile);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlueMoon);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltShield);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Valor);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Nazar);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(null, "SyntheticCobalt", 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.TinBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.CopperBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.LeadBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.IronBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.TungstenBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.SilverBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.PlatinumBar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.GoldBar);
			recipe.AddRecipe();

			//Accessories

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofRegeneration);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cloud, 20);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.CloudinaBottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 6);
			recipe.AddIngredient(ItemID.Cloud, 8);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HermesBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofStarpower);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 20);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 20);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 4);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(ItemID.WhiteString);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.ShinyRedBalloon);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SharkFin, 2);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Flipper);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 3);
			recipe.AddIngredient(ItemID.Vine, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.FeralClaws);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst);
			recipe.AddIngredient(ItemID.Vine, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.AnkletoftheWind);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Shackle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.NaturesGift);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GuideVoodooDoll);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Aglet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Compass);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Compass);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Compass);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Compass);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 20);
			recipe.AddIngredient(ItemID.Cloud, 20);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SandstorminaBottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddIngredient(ItemID.Flipper);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WaterWalkingBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Nazar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ClimbingClaws);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShoeSpikes);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.Cloud, 20);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.BlizzardinaBottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddIngredient(ItemID.CrimtaneBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PanicNecklace);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddIngredient(null, "SyntheticCobalt", 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.ClothierVoodooDoll);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagmaStone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 20);
			recipe.AddIngredient(ItemID.Fireblossom, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ObsidianRose);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.FlurryBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WhoopieCushion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HandWarmer);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.CrimtaneBar, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.CrimsonCloak);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.BlackThread, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.MysteriousCape);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddIngredient(ItemID.Ruby, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.RedCape);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddIngredient(ItemID.Ruby, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.RedCape);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.WinterCape);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.WinterCape);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WhiteString, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.HighTestFishingLine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddIngredient(ItemID.Bass, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AnglerEarring);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 7);
			recipe.AddIngredient(ItemID.Bass, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TackleBox);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.Vine, 2);
			recipe.AddIngredient(ItemID.Stinger, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.FlowerBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.CordageGuide);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddIngredient(null, "SyntheticCobalt", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TallyCounter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddIngredient(null, "SyntheticCobalt", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TallyCounter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddIngredient(null, "SyntheticCobalt", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TallyCounter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddIngredient(null, "SyntheticCobalt", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TallyCounter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Stopwatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Stopwatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Stopwatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.AddIngredient(ItemID.TungstenBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Stopwatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddIngredient(ItemID.SandBlock, 20);
			recipe.AddIngredient(ItemID.Coral, 5);
			recipe.AddIngredient(ItemID.Starfish, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SailfishBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 20);
			recipe.AddIngredient(ItemID.Coral, 5);
			recipe.AddIngredient(ItemID.Starfish, 5);
			recipe.AddIngredient(ItemID.Cloud, 20);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.TsunamiInABottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SharkFin, 3);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SharkToothNecklace);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.Obsidian, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BlackCounterweight);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.IceBlock, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BlueCounterweight);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddRecipeGroup("Wood", 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.GreenCounterweight);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.Amethyst, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PurpleCounterweight);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.Ruby, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.RedCounterweight);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.Sandstone, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.YellowCounterweight);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShinyRedBalloon);
			recipe.AddIngredient(ItemID.Bass, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.BalloonPufferfish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddIngredient(ItemID.Silk, 7);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.FlyingCarpet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddIngredient(ItemID.Leather, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 3);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LavaCharm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 10);
			recipe.AddIngredient(ItemID.Vine, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Bezoar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.HoneyComb);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddRecipeGroup("IronBar", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CelestialMagnet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glowstick, 50);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.JellyfishNecklace);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.AdamantiteBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PhilosophersStone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.TitaniumBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PhilosophersStone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PanicNecklace);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CrossNecklace);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddIngredient(ItemID.AdamantiteBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FleshKnuckles);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddIngredient(ItemID.TitaniumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FleshKnuckles);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TurtleShell);
			recipe.AddIngredient(ItemID.FrostCore);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FrozenTurtleShell);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddIngredient(ItemID.WoodenArrow, 200);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.MagicQuiver);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddIngredient(ItemID.WoodenArrow, 200);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.MagicQuiver);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddIngredient(ItemID.BlackThread, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.Tabi);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 20);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.AdhesiveBandage);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 15);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ArmorPolish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 15);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ArmorPolish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddIngredient(ItemID.BlackThread, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.BlackBelt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackThread, 5);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.Blindfold);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilBar, 25);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MoonCharm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldWatch);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FastClock);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 25);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Megaphone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MoonStone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 12);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PaladinsShield);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ItemID.MarbleBlock, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PocketMirror);
			recipe.AddRecipe();

			//Weapons

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddIngredient(ItemID.SilverBar, 2);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 8);
			recipe.AddIngredient(ItemID.SilverBar, 2);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddIngredient(ItemID.TungstenBar, 2);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 8);
			recipe.AddIngredient(ItemID.TungstenBar, 2);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.FallenStar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddIngredient(ItemID.FallenStar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FlowerofFire);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagicMissile);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Muramasa);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddIngredient(ItemID.GoldBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AquaScepter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AquaScepter);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.ShadowScale, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BallOHurt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BlueMoon);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddIngredient(ItemID.FlintlockPistol);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Handgun);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WaterBolt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddIngredient(ItemID.Stinger, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.StaffofRegrowth);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBolt);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.DemonScythe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.ShadowScale, 7);
			recipe.AddIngredient(ItemID.HellstoneBar , 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DarkLance);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Trident);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 8);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Trident);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Spear);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Spear);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Blowpipe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WoodenBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 70);
			recipe.AddIngredient(ItemID.EnchantedBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.IceBlock, 70);
			recipe.AddIngredient(ItemID.SilverBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceBlade);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.IceBlock, 70);
			recipe.AddIngredient(ItemID.TungstenBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceBlade);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 12);
			recipe.AddIngredient(ItemID.TissueSample, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TheUndertaker);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 12);
			recipe.AddIngredient(ItemID.ShadowScale, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Musket);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Musket);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Boomstick);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddIngredient(ItemID.ManaCrystal, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddIngredient(ItemID.ManaCrystal, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BeeGun);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BeeKeeper);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BeesKnees);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.HiveWand);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 26);
			recipe.AddIngredient(ItemID.SilverBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 26);
			recipe.AddIngredient(ItemID.TungstenBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 12);
			recipe.AddIngredient(ItemID.TissueSample, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CrimsonRod);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 12);
			recipe.AddIngredient(ItemID.ShadowScale, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Vilethorn);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBroadsword);
			recipe.AddIngredient(ItemID.Shackle);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ZombieArm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBroadsword);
			recipe.AddIngredient(ItemID.Shackle);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ZombieArm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 20);
			recipe.AddIngredient(ItemID.Gel, 200);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SlimeStaff);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book);
			recipe.AddIngredient(ItemID.WaterBolt);
			recipe.AddIngredient(ItemID.Bone, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.BookofSkulls);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 20);
			recipe.AddIngredient(ItemID.SilverBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ChainKnife);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 20);
			recipe.AddIngredient(ItemID.TungstenBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ChainKnife);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 4);
			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BladedGlove);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 20);
			recipe.AddIngredient(ItemID.SilverBar, 13);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.RedRyder);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 20);
			recipe.AddIngredient(ItemID.TungstenBar, 13);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.RedRyder);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.SnowBlock, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddIngredient(ItemID.SnowBlock, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldPickaxe);
			recipe.AddIngredient(ItemID.SnowBlock, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CnadyCanePickaxe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumPickaxe);
			recipe.AddIngredient(ItemID.SnowBlock, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CnadyCanePickaxe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EnchantedBoomerang);
			recipe.AddIngredient(ItemID.SnowBlock, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FruitcakeChakram);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TheUndertaker);
			recipe.AddIngredient(ItemID.PurificationPowder, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Revolver);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.SilverBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Katana);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.SilverBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Katana);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.TungstenBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Katana);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.TungstenBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Katana);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddIngredient(ItemID.HellstoneBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FalconBlade);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoltenFury);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.HellwingBow);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 7);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WandofSparking);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 2);
			recipe.AddIngredient(ItemID.MarbleBlock, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Javelin, 70);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 2);
			recipe.AddIngredient(ItemID.MarbleBlock, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Javelin, 70);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddIngredient(null, "SyntheticCobalt", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Arkhalis);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bass, 7);
			recipe.AddIngredient(ItemID.EbonstoneBlock, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.PurpleClubberfish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 12);
			recipe.AddIngredient(ItemID.MarbleBlock, 24);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Rally);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 12);
			recipe.AddIngredient(ItemID.MarbleBlock, 24);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Rally);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 18);
			recipe.AddIngredient(ItemID.CorruptYoyo);
			recipe.AddIngredient(ItemID.ShadowScale, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Code1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SyntheticCobalt", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Valor);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Valor);
			recipe.AddIngredient(ItemID.HellstoneBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Cascade);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Trout, 20);
			recipe.AddIngredient(ItemID.Trident);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Swordfish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.DemoniteBar, 12);
			recipe.AddIngredient(ItemID.EnchantedBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BloodyMachete);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlintlockPistol);
			recipe.AddIngredient(ItemID.Torch, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FlareGun);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChainKnife);
			recipe.AddIngredient(ItemID.Musket);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.Harpoon);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicMissile);
			recipe.AddIngredient(ItemID.HellstoneBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Flamelash);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.ShadowScale, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.AleThrowingGlove);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bass, 5);
			recipe.AddIngredient(ItemID.IceBlock, 40);
			recipe.AddIngredient(ItemID.ThrowingKnife, 40);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FrostDaggerfish, 40);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Beenade, 20);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 100);
			recipe.AddIngredient(ItemID.GoldHammer);
			recipe.AddIngredient(ItemID.Bass, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FrostDaggerfish, 40);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bomb, 20);
			recipe.AddIngredient(ItemID.Bass, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BombFish, 20);
			recipe.AddRecipe();

			//Pets

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 13);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowOrb);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bass);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Fish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FishingSeaweed, 5);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Seaweed);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 20);
			recipe.AddIngredient(ItemID.DemoniteBar, 7);
			recipe.AddIngredient(ItemID.ShadowScale, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EatersBone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Nectar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amber, 5);
			recipe.AddIngredient(ItemID.DesertFossil, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AmberMosquito);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vertebrae, 20);
			recipe.AddIngredient(ItemID.CrimtaneBar, 7);
			recipe.AddIngredient(ItemID.TissueSample, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneRattle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 13);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CrimsonHeart);
			recipe.AddRecipe();
		}
	}
}
