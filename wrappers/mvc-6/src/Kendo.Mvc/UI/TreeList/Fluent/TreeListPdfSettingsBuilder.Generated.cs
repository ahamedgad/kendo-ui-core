using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListPdfSettings
    /// </summary>
    public partial class TreeListPdfSettingsBuilder
        
    {
        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value for Author</param>
        public TreeListPdfSettingsBuilder Author(string value)
        {
            Container.Author = value;
            return this;
        }

        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value for Creator</param>
        public TreeListPdfSettingsBuilder Creator(string value)
        {
            Container.Creator = value;
            return this;
        }

        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value for Date</param>
        public TreeListPdfSettingsBuilder Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public TreeListPdfSettingsBuilder FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public TreeListPdfSettingsBuilder ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for Keywords</param>
        public TreeListPdfSettingsBuilder Keywords(string value)
        {
            Container.Keywords = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value for Landscape</param>
        public TreeListPdfSettingsBuilder Landscape(bool value)
        {
            Container.Landscape = value;
            return this;
        }

        /// <summary>
        /// Specifies the margins of the page (numbers or strings with units). Supported
		/// units are "mm", "cm", "in" and "pt" (default).
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public TreeListPdfSettingsBuilder Margin(Action<TreeListPdfMarginSettingsBuilder> configurator)
        {
            configurator(new TreeListPdfMarginSettingsBuilder(Container.Margin));
            return this;
        }

        /// <summary>
        /// Specifies the paper size of the PDF document.
		/// The default "auto" means the paper size is determined by the content.Supported values:
        /// </summary>
        /// <param name="value">The value for PaperSize</param>
        public TreeListPdfSettingsBuilder PaperSize(string value)
        {
            Container.PaperSize = value;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally.
		/// Such browsers are IE version 9 and lower, and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public TreeListPdfSettingsBuilder ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value for Subject</param>
        public TreeListPdfSettingsBuilder Subject(string value)
        {
            Container.Subject = value;
            return this;
        }

        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public TreeListPdfSettingsBuilder Title(string value)
        {
            Container.Title = value;
            return this;
        }


    }
}
