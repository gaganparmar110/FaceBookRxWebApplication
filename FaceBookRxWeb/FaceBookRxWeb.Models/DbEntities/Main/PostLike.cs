using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FaceBookRxWeb.BoundedContext.SqlContext;
namespace FaceBookRxWeb.Models.Main
{
    [Table("PostLikes",Schema="dbo")]
    public partial class PostLike
    {
		#region LikeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LikeId Annotations

        public int LikeId { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }


        public PostLike()
        {
        }
	}
}