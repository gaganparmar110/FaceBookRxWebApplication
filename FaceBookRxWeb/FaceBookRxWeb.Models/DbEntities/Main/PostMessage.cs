using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FaceBookRxWeb.BoundedContext.SqlContext;
namespace FaceBookRxWeb.Models.Main
{
    [Table("PostMessages",Schema="dbo")]
    public partial class PostMessage
    {
		#region PostMessageId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostMessageId Annotations

        public int PostMessageId { get; set; }

		#region Message Annotations

        [Required]
		#endregion Message Annotations

        public string Message { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region PostDateTime Annotations

        [Required]
		#endregion PostDateTime Annotations

        public System.DateTimeOffset PostDateTime { get; set; }


        public PostMessage()
        {
        }
	}
}