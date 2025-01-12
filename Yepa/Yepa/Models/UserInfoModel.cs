using System;

namespace Yepa.Models {

    /// <summary>
    /// <para> <see cref="string"/> FirstName</para>
    /// <para> <see cref="string"/> LastName</para>
    /// <para> <see cref="string"/> PhoneNumber</para>
    /// <para> <see cref="DateTime"/> ModificationDate</para>
    /// </summary>
    public class UserInfoModel 
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        /// <summary>
        /// Last modification date.
        /// </summary>
        public DateTime ModificationDate { get; set; } = DateTime.Now;

        /// <summary>
        /// <para> FisrtName = <see cref="string.Empty"/> </para>
        /// <para> LastName = <see cref="string.Empty"/> </para>
        /// <para> PhoneNumber = <see cref="string.Empty"/> </para>
        /// <para> ModificationDate = <see cref="DateTime.Now"/> </para>
        /// </summary>
        public UserInfoModel () { }

        /// <summary>
        /// Sets the specified values
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="modificationDate"></param>
        /// <remarks>If values are null, the default value is set.</remarks>
        public UserInfoModel(string firstName , string lastName, string phoneNumber, DateTime modificationDate) 
        {
            FirstName = firstName ?? FirstName;
            LastName = lastName ?? LastName;
            PhoneNumber = phoneNumber ?? PhoneNumber;
            ModificationDate = modificationDate == null ? ModificationDate : modificationDate;
        }
    }
}