﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Areas.SdvShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;
    using SdvCode.Models.User;

    public class ShoppingCart
    {
        //public ShoppingCart()
        //{
        //    this.Id = Guid.NewGuid().ToString();
        //}

        //[Key]
        //public string Id { get; set; }

        //[Required]
        //[ForeignKey(nameof(ApplicationUser))]
        //public string ApplicationUserId { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }

        //public ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; } = new HashSet<ShoppingCartProduct>();
    }
}