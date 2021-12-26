using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model.Entities
{
    [Table("Follows")]
    public class Follow
    {
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }//logovani korisnik

        [ForeignKey(nameof(Follower))]
        public int FollowerId { get; set; }
        public virtual User Follower { get; set; }//logovani korisnik prati ovog korisnika
    }
}
