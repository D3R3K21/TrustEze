namespace TrustEze.Models
{
    public class AccountDto
    {
        /// <summary>
        /// UserId used as foreign key to relate an account back to a user
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Primary key, used for database
        /// </summary>
        public Guid Id { get; set; }
    }
}
