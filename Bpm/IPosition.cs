using System.Drawing;

namespace PmLibrary
{
    /// <summary>
    /// Defines how information is displayed for a process step
    /// </summary>
    public interface IPosition
    {
        /// <summary>
        /// Position identifier code
        /// </summary>
        string Code { get; set; }


        /// <summary>
        /// Internal display name for a position
        /// </summary>
        string Name { get; set; }


        /// <summary>
        /// Public display name for a position
        /// </summary>
        string PublicName { get; set; }


        /// <summary>
        /// Style class name for this position which can be used for formatting. 
        /// For example CSS class name.
        /// </summary>
        string StyleClass { get; set; }


        /// <summary>
        /// Internal note template for a position
        /// </summary>
        string Notes { get; set; }


        /// <summary>
        /// Public note template for a position
        /// </summary>
        string PublicNotes { get; set; }
    }
}