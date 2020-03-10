﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdvCode.Constraints
{
    public static class ErrorMessages
    {
        public const string UserNotInRol = "{0} is not in role {1}.";

        public const string InvalidInputModel = "Unexpected error :( Maybe invalid Input Model.";

        public const string UserAlreadyInRole = "{0} is already in role {1}.";

        public const string RoleExist = "{0} role already exits.";

        public const string NoActionsByGivenName = "There is no more \"{0}\" actions for cleaning.";

        public const string NoActionsForRemoving = "There is no more users actions for removing.";

        public const string NoUserImagesByGivenUsername = "{0} has no any images for deleting.";

        public const string NoMoreUsersImagesForRemoving = "There is no more users images for removing.";

        public const string NoDataForSyncFollowUnfollow = "There is no Follow-Unfollow relations for synchronize.";

        public const string UserAlreadyBlocked = "User {0} is already blocked.";

        public const string UserAlreadyUnblocked = "User {0} is already unblocked.";

        public const string AllUsersAlreadyBlocked = "All users except Administrators are already blocked.";

        public const string AllUsersAlreadyUnblocked = "All users  are already unblocked.";
    }
}