﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Areas.Administration.ViewModels.SiteReportsViewModels.BlogReports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BlogCommentReportViewModel
    {
        public string Content { get; set; }

        public string CreatorUsername { get; set; }

        public string CommentStatus { get; set; }

        public string Prediction { get; set; }
    }
}