﻿namespace PhotOn.Core.Entities
{
    public class Like
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
    }
}
