using Terraria.ID;
using Terraria.ModLoader;

namespace MoreCrap.Items
{
	public class SandSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Bruh how does this not fall apart instantly");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}