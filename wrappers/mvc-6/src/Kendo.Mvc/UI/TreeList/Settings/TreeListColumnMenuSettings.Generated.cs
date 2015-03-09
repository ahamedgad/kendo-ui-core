using Kendo.Mvc.Extensions;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListColumnMenuSettings class
    /// </summary>
    public partial class TreeListColumnMenuSettings 
    {
        public bool? Columns { get; set; }

        public bool? Filterable { get; set; }

        public bool? Sortable { get; set; }


        public TreeListColumnMenuMessagesSettings Messages { get; } = new TreeListColumnMenuMessagesSettings();

        public bool Enabled { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Columns.HasValue)
            {
                settings["columns"] = Columns;
            }

            if (Filterable.HasValue)
            {
                settings["filterable"] = Filterable;
            }

            if (Sortable.HasValue)
            {
                settings["sortable"] = Sortable;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }


            return settings;
        }
    }
}
