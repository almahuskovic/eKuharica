﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class RecipeUpsertRequest
    {
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Ingredients { get; set; }
        public string Method { get; set; }
        public string Serving { get; set; }
        public string Advice { get; set; }
        public DateTime PreparationTime { get; set; }
        public int PreparationTimeCategory { get; set; } //enum
        public int MealType { get; set; } //enum
        public int WeightOfPreparation { get; set; } //enum
        public byte[] Picture { get; set; }
        public byte[] PictureThumb { get; set; }
        public bool IsTranslated { get; set; }
        public bool IsSent { get; set; }
        public bool IsApproved { get; set; }
        public bool IsRead { get; set; }
        public int UserId { get; set; }
    }
}
