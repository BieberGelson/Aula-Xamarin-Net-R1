﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AulaXamarinNET.MarkupExtensions
{
    [ContentProperty("ResourceID")]
    public class ImagemInserida : IMarkupExtension
    {
        public string ResourceID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceID))
                return null;
            return ImageSource.FromResource(ResourceID);
        }
    }
}
