// <copyright file="YesNoConverter.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     YesNoConverter: Class to convert Yes and No to boolean values.
// </summary>

namespace BWHazel.Experiments.WorkflowRpg
{
    using System.Collections.Generic;

    /// <summary>
    /// Converts Yes and No to boolean values.
    /// </summary>
    public static class YesNoConverter
    {
        /// <summary>
        /// Converts a Yes or No to a boolean value.
        /// </summary>
        /// <param name="value">The input text.</param>
        /// <returns><c>true</c> for Yes or <c>false</c> for No.</returns>
        public static bool ToBoolean(string value)
        {
            switch (value.ToLower())
            {
                case "yes":
                case "y":
                    return true;
                case "no":
                case "n":
                default:
                    return false;
            }
        }
    }
}
