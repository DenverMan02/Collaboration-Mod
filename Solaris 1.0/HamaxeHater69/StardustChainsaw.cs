using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{

	public class StardustChainsaw : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 80;
			item.melee = true;
			item.width = 64;
			item.height = 22;
			item.shoot = 610;
			item.shootSpeed = 15f;
			item.tileBoost = 3;
			item.useTime = 15;
			item.useAnimation = 25;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.axe = 135;
			item.tileBoost += 5;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 1, 50, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stardust Chainsaw");
			Tooltip.SetDefault("");
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentStardust, 6);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
