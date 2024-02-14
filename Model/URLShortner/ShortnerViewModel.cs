﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.URLShortner
{
    public class ShortnerViewModel
    {
        public long? Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? LastUpdatedAt { get; set; }

        public string? GeneratedKey { get; set; }

        public string? URL { get; set; }
    }
}
