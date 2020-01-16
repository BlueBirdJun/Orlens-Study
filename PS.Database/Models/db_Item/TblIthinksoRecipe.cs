using System;
using System.Collections.Generic;

namespace PS.Database.Models.db_Item
{
    public partial class TblIthinksoRecipe
    {
        public int RecipeSeq { get; set; }
        public string RecipeBanner { get; set; }
        public string RecipeTitle { get; set; }
        public string RecipeImgUrl { get; set; }
        public string RecipeHtml { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime Regdate { get; set; }
        public int Hit { get; set; }
    }
}
