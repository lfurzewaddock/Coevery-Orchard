﻿using System.Collections.Generic;
using Orchard.ContentManagement;

namespace Orchard.Core.Localization.ViewModels {
    public class EditLocalizationViewModel  {
        public string SelectedCulture { get; set; }
        public IEnumerable<string> SiteCultures { get; set; }
        public IContent ContentItem { get; set; }
        public IContent MasterContentItem { get; set; }
        public ContentLocalizationsViewModel ContentLocalizations { get; set; }
    }
}