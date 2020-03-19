﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Services.ProfileServices
{
    using Microsoft.AspNetCore.Identity;
    using SdvCode.Data;
    using SdvCode.Models.User;
    using SdvCode.ViewModels.Profile;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProfileFavoritesService : IProfileFavoritesService
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;

        public ProfileFavoritesService(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public async Task<List<FavoritesViewModel>> ExtractFavorites(ApplicationUser user)
        {
            List<FavoritesViewModel> allFavorites = new List<FavoritesViewModel>();
            var favorites = this.db.FavouritePosts.Where(x => x.ApplicationUserId == user.Id && x.IsFavourite == true).ToList();

            foreach (var item in favorites)
            {
                var favorite = await this.userManager.FindByIdAsync(item.ApplicationUserId);
                var post = this.db.Posts.FirstOrDefault(x => x.Id == item.PostId);
                var isFavorite = this.db.FavouritePosts
                    .Any(x => x.PostId == item.PostId && x.ApplicationUserId == user.Id && x.IsFavourite == true);

                allFavorites.Add(new FavoritesViewModel
                {
                    PostId = item.PostId,
                    PostContent = post.Content.Length < 347 ? post.Content : $"{post.Content.Substring(0, 347)}...",
                    PostTitle = post.Title,
                    IsFavorite = isFavorite,
                    CreatedOn = post.CreatedOn,
                });
            }

            return allFavorites.OrderByDescending(x => x.CreatedOn).ToList();
        }
    }
}