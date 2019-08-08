using System;

namespace Penguin.Extensions.DateTime
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public static class DateTimeExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        #region Methods

        /// <summary>
        /// Returns a DateTime representing the begining of the week the requested datetime falls within
        /// </summary>
        /// <param name="dt">The datetime to check</param>
        /// <param name="startOfWeek">The day of the week to use as the first day</param>
        /// <returns>The 00:00 of the day that marks the start of the week</returns>
        public static System.DateTime StartOfWeek(this System.DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Sunday)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        #endregion Methods
    }
}