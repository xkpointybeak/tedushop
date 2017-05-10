using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory( this PostCategory postCategory, PostCategoryViewModel postCategoryVM)
        {
            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Description = postCategoryVM.Description;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.ParentID = postCategoryVM.ParentID;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.Image = postCategoryVM.Image;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;

            
            postCategory.CreatedDate = postCategoryVM.CreatedDate;
            postCategory.CreatedBy = postCategoryVM.CreatedBy;
            postCategory.UpdatedBy = postCategoryVM.UpdatedBy;
            postCategory.UpdatedDate = postCategoryVM.UpdatedDate;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.Status = postCategoryVM.Status;
        }
        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Description = postVM.Description;
            post.Alias = postVM.Alias;
            post.CategoryID = postVM.CategoryID;
            post.ViewCount = postVM.ViewCount;
            post.Image = postVM.Image;
            post.HomeFlag = postVM.HomeFlag;
            post.Content = postVM.Content;
            post.HotFlag = postVM.HotFlag;

            
            post.CreatedDate = postVM.CreatedDate;
            post.CreatedBy = postVM.CreatedBy;
            post.UpdatedBy = postVM.UpdatedBy;
            post.UpdatedDate = postVM.UpdatedDate;
            post.MetaDescription = postVM.MetaDescription;
            post.MetaKeyword = postVM.MetaKeyword;
            post.Status = postVM.Status;
        }
    }
}