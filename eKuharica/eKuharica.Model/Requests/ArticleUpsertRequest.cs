﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class ArticleUpsertRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string KeyWords { get; set; }
        public byte[] Picture { get; set; }
        public byte[] PictureThumb { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int CreateUserId { get; set; }
    }
}
