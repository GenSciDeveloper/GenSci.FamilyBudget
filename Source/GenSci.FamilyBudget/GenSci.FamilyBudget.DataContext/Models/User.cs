namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// User entity
    /// </summary>
    public class User
    {
        /// <summary>
        /// User identifier
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User second name
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Password hash
        /// </summary>
        public byte[] PassHash { get; set; }

        /// <summary>
        /// Password salt
        /// </summary>
        public byte[] PassSalt { get; set; }
    }
}
