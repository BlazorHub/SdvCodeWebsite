﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum CountryCode
    {
        [Display(Name = "Bulgaria (+359)")]
        BGR_359 = 1,
        [Display(Name = "Canada (+1)")]
        CAN_1 = 2,
        [Display(Name = "USA (+1)")]
        USA_1 = 3,
        [Display(Name = "Turkish (+90)")]
        TUR_90 = 4,
        [Display(Name = "France (+33)")]
        FRA_33 = 5,
        [Display(Name = "Spain (+34)")]
        ESP_34 = 6,
        [Display(Name = "Portugal (+351)")]
        PRT_351 = 7,
        [Display(Name = "Romania (+40)")]
        ROU_40 = 8,
        [Display(Name = "Russia (+9)")]
        RUS_7 = 9,
        [Display(Name = "Poland (+48)")]
        POL_48 = 10,
        [Display(Name = "India (+91)")]
        IND_91 = 11,
        [Display(Name = "Italy (+39)")]
        ITA_39 = 12,
    }
}